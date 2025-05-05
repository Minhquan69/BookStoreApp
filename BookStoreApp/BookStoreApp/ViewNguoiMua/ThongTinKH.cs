using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace BookStoreApp.ViewNguoiMua
{
    public partial class ThongTinKH : UserControl
    {
        Classes.DataBaseProcess db = new Classes.DataBaseProcess();
        string imageName = "";
        string NameKH = "";
        string userName = "";
        public event Action<string> OnNameUpdated;
        public ThongTinKH(string tenkh)
        {
            NameKH = tenkh;
            InitializeComponent();
            LayMaND();
            LoadData();

        }
        private void LayMaND()
        {
            DataTable dtNhanVien = db.DataReader($"SELECT MaKH FROM KhachHang WHERE TenKhachHang = N'{NameKH}'");
            userName = dtNhanVien.Rows[0]["MaKH"].ToString();
        }
        private void LoadData()
        {
            DataTable dtNhanVien = db.DataReader($"SELECT * FROM KhachHang WHERE MaKH = '{userName}'");
            txtHoTen.Text = dtNhanVien.Rows[0]["TenKhachHang"].ToString();
            txtGioiTinh.Text = dtNhanVien.Rows[0]["GioiTinh"].ToString();
            txtDiaChi.Text = dtNhanVien.Rows[0]["DiaChi"].ToString();
            txtSDT.Text = dtNhanVien.Rows[0]["SDT"].ToString();
            imageName = dtNhanVien.Rows[0]["Anh"].ToString();
            if (imageName != "")
            {
                ptbAnh.Image = Image.FromFile(Application.StartupPath + "\\AnhKhachHang\\" + imageName);
                btnXoaAnh.Enabled = true;
            }

            else
            {
                ptbAnh.Image = Image.FromFile(Application.StartupPath + "\\AnhKhachHang\\" + "avatar.png");
                btnXoaAnh.Enabled = false;
            }
            anh = imageName;
            dtNgaySinh.Text = dtNhanVien.Rows[0]["NgaySinh"].ToString();
            txtUserName.Text = dtNhanVien.Rows[0]["SDT"].ToString();
            txtMatKhau.Text = dtNhanVien.Rows[0]["MatKhau"].ToString();
            txtMatKhau.Enabled = false;
            txtMatKhau.PasswordChar = '*';
            this.Select();
        }




        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] file;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap Images|*.bmp|JPEG Images|*.jpg|All Files|*.*";
            openFile.FilterIndex = 2;
            openFile.InitialDirectory = Application.StartupPath + "\\AnhKhachHang";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(openFile.FileName);
                file = openFile.FileName.Split('\\');
                imageName = file[file.Length - 1];

            }


        }
        private string anh;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            anh = imageName;
            if (!ValidateInput()) return;
            string formattedNgaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
            string sqlUpdate = $"UPDATE KhachHang SET " +
                               $"TenKhachHang = N'{txtHoTen.Text}', " +
                               $"DiaChi = N'{txtDiaChi.Text}', " +
                               $"SDT = '{txtSDT.Text}', " +
                               $"NgaySinh = '{formattedNgaySinh}', " +
                               $"GioiTinh = N'{txtGioiTinh.Text}', " +
                               $"Anh = '{imageName}' " +
                               $"Where MaKH = '{userName}' ";

            try
            {
                db.DataChange(sqlUpdate);
                LoadData();
                MessageBox.Show("Cập nhật thông tin Người Dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnNameUpdated?.Invoke(anh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ToolTip tooltip = new ToolTip()
        {
            IsBalloon = true,
            ToolTipIcon = ToolTipIcon.Warning,
            ToolTipTitle = "Lỗi nhập liệu",
            AutoPopDelay = 2500,
            InitialDelay = 200,
            ReshowDelay = 500,
            ShowAlways = true
        };

        private bool ValidateInput()
        {
            tooltip.RemoveAll(); // Xóa tooltip cũ

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                tooltip.Show("Vui lòng nhập họ tên.", txtHoTen, txtHoTen.Width / 2, -60);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGioiTinh.Text))
            {
                tooltip.Show("Vui lòng nhập giới tính.", txtGioiTinh, txtGioiTinh.Width / 2, -60);
                txtGioiTinh.Focus();
                return false;
            }

            // Kiểm tra giá trị giới tính
            string gioiTinh = txtGioiTinh.Text.Trim().ToLower();
            if (gioiTinh != "nam" && gioiTinh != "nữ" && gioiTinh != "nu" && gioiTinh != "giới tính thứ 3" && gioiTinh != "gioi tinh thu 3")
            {
                tooltip.Show("Giới tính: Nam, Nữ hoặc GT thứ 3.", txtGioiTinh, txtGioiTinh.Width / 2, -60);
                txtGioiTinh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                tooltip.Show("Vui lòng nhập số điện thoại.", txtSDT, txtSDT.Width / 2, -60);
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            string sdt = txtSDT.Text.Trim();
            if (!(sdt.All(char.IsDigit) && (sdt.Length == 10 || sdt.Length == 11)))
            {
                tooltip.Show("Số điện thoại phải gồm 10 hoặc 11 chữ số.", txtSDT, txtSDT.Width / 2, -60);
                txtSDT.Focus();
                return false;
            }

            return true;
        }




        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                toolTip.Show("Số điện thoại chỉ được nhập số!", txtSDT, 0, -20, 3000); // Hiển thị tooltip trong 3 giây
                e.Handled = true; // Ngăn chặn nhập ký tự không hợp lệ
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                tooltip.RemoveAll(); // Xóa tooltip cũ nếu có
                tooltip.Show("Vui lòng nhập mật khẩu mới!", txtMatKhau, txtMatKhau.Width / 2, -60);
                txtMatKhau.Focus();
                return;
            }
            string sqlUpdate = $"UPDATE KhachHang SET " +
                               $"MatKhau = '{txtMatKhau.Text}' " +
                               $"Where MaKH = '{userName}' ";

            try
            {
                db.DataChange(sqlUpdate);
                LoadData();
                MessageBox.Show("Cập nhật thông tin Người Dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            string sqlUpdate = $"UPDATE KhachHang SET " +
                               $"Anh = '' " +
                               $"Where MaKH = '{userName}' ";

            try
            {
                db.DataChange(sqlUpdate);

                MessageBox.Show("Xóa ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = true;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                // Nếu đang là '*' thì đổi thành rỗng để hiển thị chữ
                txtMatKhau.PasswordChar = '\0';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat1.jpg");
            }
            else
            {
                // Nếu đang hiển thị chữ, đổi lại thành '*' để hiển thị dấu
                txtMatKhau.PasswordChar = '*';

                // Thay đổi hình nền của button1 (đảm bảo đường dẫn đúng)
                button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Button\\mat.jpg");
            }
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Green;
            }
        }
        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Black;
            }
        }

        private void txtGioiTinh_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Green;
            }
        }

        private void txtGioiTinh_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Green;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.ForeColor = Color.Green;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null) { txt.ForeColor = Color.Black; }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null) { txt.ForeColor = Color.Green; }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
