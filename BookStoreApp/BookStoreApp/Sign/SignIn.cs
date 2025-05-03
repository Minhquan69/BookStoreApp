using BookStoreApp.ViewNguoiMua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.Sign
{
    public partial class SignIn : Form
    {
        public static string userName;

        // Declare and constructor global variable in class to use DataBaseProcess
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();
        public SignIn()
        {
            InitializeComponent();
            CenterToScreen();
            //   tabControl1.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
            panel1.Visible = false;
        }
        private void ShowPanel1()
        {
            // tabControl1.Visible = false;
            panel1.Visible = true;
        }
        private void ShowTabControl()
        {
            panel1.Visible = false;
            //tabControl1.Visible = true;
        }
        private void BtnHuyClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDangNhapCkick(object sender, EventArgs e)
        {
            string sdt = txtName.Text; // Sử dụng số điện thoại (SDT)
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(sdt) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Tài khoản không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bool isNguoiDung = checkNguoiDung(sdt, password); // Kiểm tra người dùng với số điện thoại
            bool isNhanVien = checkNhanVien(sdt, password); // Kiểm tra nhân viên với số điện thoại

            if (isNhanVien)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var childView = new HomeFrm();

                this.Hide();
                childView.Show();
            }
            else if (isNguoiDung)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Truy vấn để lấy mã khách hàng (makh)
                string query = @"SELECT MaKH FROM KhachHang WHERE SDT = '" + sdt + "'"; // Thêm dấu nháy đơn quanh giá trị sdt
                DataTable dt = dtBase.DataReader(query); // Lấy dữ liệu trả về từ cơ sở dữ liệu

                if (dt.Rows.Count > 0)
                {
                    string makh = dt.Rows[0]["MaKH"].ToString(); // Lấy giá trị MaKH
                    userName = makh; // Gán giá trị vào userName
                }

                HomeView home = new HomeView(Program.currentUser.TenUser);
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //var childView = new SignUp();


            //childView.OnBackButtonClicked += () =>
            //{
            //    panel1.Controls.Clear();
            //    panel1.Visible = false;
            //    ShowTabControl();
            //    //   splitContainer3.Panel1Collapsed = false;
            //};
        }


        private bool checkNhanVien(string sdt, string password) // Thay username thành SDT
        {
            bool check = false;
            string query = "select * from NhanVien where SDT = '" + sdt + "' and MatKhau ='" + password + "'"; // Cập nhật truy vấn SQL
            DataTable dt = new DataTable();
            dt = dtBase.DataReader(query);
            if (dt.Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }

        private bool checkNguoiDung(string sdt, string password) // Thay username thành SDT
        {
            bool check = false;
            string query = "select * from KhachHang where SDT = '" + sdt + "' and MatKhau ='" + password + "'"; // Cập nhật truy vấn SQL
            DataTable dt = new DataTable();
            dt = dtBase.DataReader(query);
            if (dt.Rows.Count > 0)
            {
                check = true;
                Program.currentUser.TenUser = dt.Rows[0]["TenKhachHang"].ToString();
                Program.currentUser.MaUser = dt.Rows[0]["MaKH"].ToString();
            }
            return check;
        }

        private void BtnSignUpClick(object sender, EventArgs e)
        {

            ShowProductDetails_signUp();
            ShowPanel1();
        }


        private void ShowProductDetails_signUp()
        {
            // Kiểm tra xem panel1 có controls không
            panel1.Controls.Clear();

            // Tạo form SignUp mới
            var childView = new SignUp();

            // Thiết lập sự kiện OnBackButtonClicked
            childView.OnBackButtonClicked += () =>
            {
                panel1.Controls.Clear();
                panel1.Visible = false;
                ShowTabControl();
            };

            // Thêm form SignUp vào panel1
            panel1.Controls.Add(childView);

            // Dock form SignUp để fill toàn bộ panel
            childView.Dock = DockStyle.Fill;

            // Hiển thị panel1
            panel1.Visible = true;
        }


        
    }
}
