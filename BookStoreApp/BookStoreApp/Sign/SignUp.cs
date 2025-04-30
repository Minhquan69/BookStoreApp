using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BookStoreApp.Sign
{
    public partial class SignUp : UserControl
    {
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();

        public SignUp()
        {
            InitializeComponent();
            //CenterToScreen();
        }

        private void BtnSignUpClick(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập
                if (!ValidateFields())
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Lỗi nhập liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dữ liệu từ form
                var tenKhachHang = txtFullName.Text.Trim();
                var diaChi = txtAddress.Text.Trim();
                var sdt = txtPhoneNumber.Text.Trim();
                var ngaySinh = dtpDate.Value.Date;
                var password = txtPassword.Text.Trim();
                var gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                var anh = pictureBoxAvatar.Image != null && !string.IsNullOrEmpty(pictureBoxAvatar.ImageLocation)
                          ? Path.GetFileName(pictureBoxAvatar.ImageLocation)
                          : "";

                using (SqlConnection conn = dtBase.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Kiểm tra số điện thoại đã tồn tại
                            string checkPhoneQuery = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT";
                            using (SqlCommand checkCmd = new SqlCommand(checkPhoneQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@SDT", sdt);
                                int existingCount = (int)checkCmd.ExecuteScalar();
                                if (existingCount > 0)
                                {
                                    MessageBox.Show("Số điện thoại này đã tồn tại!", "Cảnh báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    transaction.Rollback();
                                    return;
                                }
                            }

                            // Thêm khách hàng vào cơ sở dữ liệu
                            string insertCustomerQuery = @"
                                INSERT INTO KhachHang (tenKhachHang, DiaChi, SDT, ngaySinh, matkhau, anh, gioitinh)
                                VALUES (@TenKH, @DiaChi, @SDT, @NgaySinh, @MatKhau, @Anh, @GioiTinh);
                                SELECT CAST(SCOPE_IDENTITY() AS INT);";
                            int makh;
                            using (SqlCommand cmd = new SqlCommand(insertCustomerQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@TenKH", tenKhachHang);
                                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                                cmd.Parameters.AddWithValue("@SDT", sdt);
                                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                                cmd.Parameters.AddWithValue("@MatKhau", password);
                                cmd.Parameters.AddWithValue("@Anh", anh);
                                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                                makh = (int)cmd.ExecuteScalar();
                            }

                            // Tạo mã khách hàng với tiền tố KH
                            string formattedMaKH = "KH" + makh.ToString("D3");

                            // Thêm giỏ hàng cho khách hàng
                            string insertCartQuery = "INSERT INTO giohang (makh, tongsanpham) VALUES (@MaKH, 0)";
                            using (SqlCommand cartCmd = new SqlCommand(insertCartQuery, conn, transaction))
                            {
                                cartCmd.Parameters.AddWithValue("@MaKH", formattedMaKH);
                                cartCmd.ExecuteNonQuery();
                            }

                            // Lưu các thay đổi
                            transaction.Commit();
                            MessageBox.Show("Đăng ký thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Chuyển đến trang đăng nhập
                            var signInView = new SignIn();
                            OnBackButtonClicked?.Invoke();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm kiểm tra tất cả các trường
        private bool ValidateFields()
        {
            bool isValid = true;

            // Kiểm tra tên
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Hãy nhập họ và tên.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtFullName, null);
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || txtPhoneNumber.Text.Length != 10 || !long.TryParse(txtPhoneNumber.Text, out _))
            {
                errorProvider.SetError(txtPhoneNumber, "Số điện thoại không hợp lệ.");
                isValid = false;
            }

            // Kiểm tra mật khẩu và xác nhận
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Hãy nhập mật khẩu.");
                isValid = false;
            }
            else if (txtPassword.Text != txtPasswordComfirm.Text)
            {
                errorProvider.SetError(txtPasswordComfirm, "Mật khẩu xác nhận không khớp.");
                isValid = false;
            }

            // Kiểm tra ngày sinh
            if (dtpDate.Value.Date >= DateTime.Now.Date)
            {
                errorProvider.SetError(dtpDate, "Ngày sinh phải trước ngày hiện tại.");
                isValid = false;
            }

            return isValid;
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra độ dài số điện thoại
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, "Hãy nhập số điện thoại.");
                e.Cancel = true;
            }
            else if (txtPhoneNumber.Text.Length < 10 || txtPhoneNumber.Text.Length > 11)
            {
                errorProvider.SetError(txtPhoneNumber, "Số điện thoại phải từ 10 đến 11 số.");
                e.Cancel = true;
            }
            else
            {
                // Kiểm tra số điện thoại đã tồn tại
                string query = $"SELECT * FROM KhachHang WHERE SDT = '{txtPhoneNumber.Text}'";
                DataTable dt = dtBase.DataReader(query);
                if (dt.Rows.Count > 0)
                {
                    errorProvider.SetError(txtPhoneNumber, "Số điện thoại đã tồn tại.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtPhoneNumber, null);
                }
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Hãy nhập mật khẩu.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke();
        }
        public delegate void OnBackButtonClickedHandler();
        public event OnBackButtonClickedHandler OnBackButtonClicked;


        private void buttonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAvatar.Image = Image.FromFile(ofd.FileName);
                    pictureBoxAvatar.ImageLocation = ofd.FileName; // Đặt ImageLocation để lấy tên file
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định cho form
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            ActiveControl = null;
            //    txtPhoneNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                // Nếu đang là '*' thì đổi thành rỗng để hiển thị chữ
                txtPassword.PasswordChar = '\0';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat.jpg");
            }
            else
            {
                // Nếu đang hiển thị chữ, đổi lại thành '*' để hiển thị dấu
                txtPassword.PasswordChar = '*';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat1.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordComfirm.PasswordChar == '*')
            {
                // Nếu đang là '*' thì đổi thành rỗng để hiển thị chữ
                txtPasswordComfirm.PasswordChar = '\0';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat.jpg");
            }
            else
            {
                // Nếu đang hiển thị chữ, đổi lại thành '*' để hiển thị dấu
                txtPasswordComfirm.PasswordChar = '*';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat1.jpg");
            }
        }
        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDate.Value.Date >= DateTime.Now.Date)
            {
                errorProvider.SetError(dtpDate, "Ngày sinh phải trước ngày hiện tại.");
                e.Cancel = true; // Ngăn không cho focus di chuyển nếu có lỗi
            }
            else
            {
                errorProvider.SetError(dtpDate, null);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím điều khiển
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Kiểm tra độ dài của TextBox
            if (txtPhoneNumber.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

        }
    }
}
