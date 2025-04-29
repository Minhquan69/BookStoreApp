using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace BookStoreApp
{
    public partial class HomeFrm : Form
    {
        // Declare and constructor global variable in class to use DataBaseProcess
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();
        //image path
        string prePathImage = "";
        string currentPathImage = "";

        bool anhKHDaThayDoi = false;
        bool anhSachDaThayDoi = false;

        private int currentPage = 1; // Trang hiện tại
        private int pageSize = 12;
        private int currentPageKH = 1; // Trang hiện tại
        private int pageSizeKH = 12;
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void HomeFrm_Load(object sender, EventArgs e)
        {
            DataTable dtbl = dtBase.DataReader("select TheLoai.TenTheLoai from TheLoai");
            comboBoxPhanLoai.DataSource = dtbl;
            comboBoxPhanLoai.DisplayMember = "TenTheLoai"; // Cột hiển thị
            comboBoxPhanLoai.ValueMember = "TenTheLoai";

            DataTable tblNXb = dtBase.DataReader("select NhaXuatBan.TenNXB from NhaXuatBan");
            comboBoxNXB.DataSource = tblNXb;
            comboBoxNXB.DisplayMember = "TenNXB";

            TuNgayPicker.CustomFormat = "dd/MM/yyyy";
            denNgayPicker.CustomFormat = "dd/MM/yyyy";

            DisplayItems();
            DisplayCustomers();
            DisplayDiscount();

            //DisplayBill();

            // DisplayThongKeSP();
            //DisplayThongKeKH();

            //DisplayNgayBanChay();
            //DisplayDoanhThu();
        }
        private void DisplayCustomers()
        {
            try
            {
                // Định nghĩa cấu trúc cột cho DataGridView
                tblKhachHang.Columns.Clear();
                tblKhachHang.Rows.Clear();

                tblKhachHang.Columns.Add("MaKH", "Mã Khách hàng");
                tblKhachHang.Columns.Add("TenKhachHang", "Tên Khách hàng");
                tblKhachHang.Columns.Add("DiaChi", "Địa chỉ");
                tblKhachHang.Columns.Add("SDT", "SĐT");
                tblKhachHang.Columns.Add("GioiTinh", "Giới tính");
                tblKhachHang.Columns.Add("NgaySinh", "Ngày sinh");
                tblKhachHang.Columns.Add("MatKhau", "Mật Khẩu");
                tblKhachHang.Columns["MatKhau"].Visible = false;
                tblKhachHang.Columns.Add("Anh", "Ảnh");
                tblKhachHang.Columns["Anh"].Visible = false;

                tblKhachHang.Columns["TenKhachHang"].Width = 180;

                // Lấy dữ liệu từ cơ sở dữ liệu
                DataTable dtItems = dtBase.DataReader("SELECT * FROM KhachHang");

                // Phân trang dữ liệu
                PaginateDataGridViewForCustomers(tblKhachHang, dtItems, pageSize, currentPage, label_phanTrang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnHienMatKhau.Enabled = true;
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;
        }

        private void PaginateDataGridViewForCustomers(DataGridView dataGridView, DataTable data, int pageSizeKH, int currentPageKH, Label label_PhanTrang)
        {
            try
            {
                // Tính toán chỉ số bắt đầu và kết thúc
                int startRow = (currentPageKH - 1) * pageSizeKH;
                int endRow = Math.Min(startRow + pageSizeKH, data.Rows.Count);

                // Xóa dữ liệu cũ trên DataGridView
                dataGridView.Rows.Clear();

                // Hiển thị dữ liệu thuộc trang hiện tại
                for (int i = startRow; i < endRow; i++)
                {
                    DataRow row = data.Rows[i];

                    // Lấy các giá trị cụ thể từ các cột theo tên
                    object maKH = row["MaKH"];
                    object tenKhachHang = row["TenKhachHang"];
                    object diaChi = row["DiaChi"];
                    object sdt = row["SDT"];
                    object gioiTinh = row["GioiTinh"];
                    object matKhau = row["MatKhau"];
                    object anh = row["Anh"];

                    // Định dạng ngày sinh
                    string ngaySinhFormatted = "";
                    if (DateTime.TryParse(row["NgaySinh"]?.ToString(), out DateTime ngaySinh))
                    {
                        ngaySinhFormatted = ngaySinh.ToString("dd-MM-yyyy");
                    }

                    // Thêm các giá trị vào DataGridView
                    dataGridView.Rows.Add(maKH, tenKhachHang, diaChi, sdt, gioiTinh, ngaySinhFormatted, matKhau, anh);
                }

                // Tính số trang
                int totalPages = (int)Math.Ceiling((double)data.Rows.Count / pageSizeKH);

                // Hiển thị thông tin phân trang lên label
                label_PhanTrang.Text = $"Trang {currentPageKH}/{totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân trang: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayItems()
        {


            try
            {
                tblDuLieu.Columns.Clear();
                tblDuLieu.Rows.Clear();

                tblDuLieu.Columns.Add("MaSach", "Mã Sách");
                tblDuLieu.Columns.Add("TenSach", "Tên Sách");
                tblDuLieu.Columns.Add("TacGia", "Tác giả");
                tblDuLieu.Columns.Add("TenTheLoai", "Thể loại");
                tblDuLieu.Columns.Add("TenNXB", "Nhà xuất bản");
                tblDuLieu.Columns.Add("DonGia", "Giá bán");
                tblDuLieu.Columns.Add("GioiThieu", "Giới thiệu");
                tblDuLieu.Columns.Add("SoTrang", "Số trang");
                tblDuLieu.Columns.Add("Anh", "Anh");
                tblDuLieu.Columns["Anh"].Visible = false;
                tblDuLieu.Columns["SoTrang"].Visible = false;
                tblDuLieu.Columns.Add("FileSach", "FileSach");
                tblDuLieu.Columns["FileSach"].Visible = false;
                tblDuLieu.Columns.Add("FileXemThu", "File Xem thử");
                tblDuLieu.Columns["FileXemThu"].Visible = false;

                tblDuLieu.Columns["TenSach"].Width = 180;


                // Lấy dữ liệu từ cơ sở dữ liệu
                DataTable dtItems = dtBase.DataReader("select * from Sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai" +
                                                      " join NhaXuatBan nxb\r\non s.MaNXB = nxb.MaNXB");
                if (dtItems != null && dtItems.Rows.Count > 0)
                {
                    PaginateDataGridView(tblDuLieu, dtItems, pageSize, currentPage);
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }

        private void PaginateDataGridView(DataGridView dataGridView, DataTable data, int pageSize, int currentPage)
        {
            try
            {
                // Tính toán chỉ số bắt đầu và kết thúc
                int startRow = (currentPage - 1) * pageSize;
                int endRow = Math.Min(startRow + pageSize, data.Rows.Count);

                // Xóa dữ liệu cũ trên DataGridView
                dataGridView.Rows.Clear();

                // Hiển thị dữ liệu thuộc trang hiện tại
                for (int i = startRow; i < endRow; i++)
                {
                    DataRow row = data.Rows[i];

                    // Lấy các giá trị cụ thể từ các cột theo tên
                    object maSach = row["MaSach"];
                    object tenSach = row["TenSach"];
                    object tacGia = row["TacGia"];
                    object tenTheLoai = row["TenTheLoai"];
                    object tenNXB = row["TenNXB"];
                    object donGia = row["DonGia"];
                    object gioithieu = row["GioiThieu"];
                    object soTrang = row["SoTrang"];
                    object anh = row["Anh"];
                    object fileSach = row["FileSach"];
                    object fileXemThu = row["FileXemThu"];

                    // Thêm các giá trị vào DataGridView
                    dataGridView.Rows.Add(maSach, tenSach, tacGia, tenTheLoai, tenNXB, donGia, gioithieu, soTrang, anh, fileSach, fileXemThu);
                }

                int totalPages = (int)Math.Ceiling((double)data.Rows.Count / pageSize);
                labelPhanTrang.Text = $"Trang {currentPage}/{totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân trang: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayDiscount()
        {
            try
            {
                // Thêm cột vào bảng tblDuLieu
                tblKhuyenMai.Columns.Clear(); // Xóa các cột cũ (nếu có)
                tblKhuyenMai.Rows.Clear(); // Xóa các dòng cũ (nếu có)

                // Thêm cột vào tblDuLieu giống như tblItem
                tblKhuyenMai.Columns.Add("TenSach", "Tên Sách");
                tblKhuyenMai.Columns.Add("ThoigianBatDau", "Bắt đầu");
                tblKhuyenMai.Columns.Add("ThoigianKetThuc", "Kết thúc");
                tblKhuyenMai.Columns.Add("KM", "Phần trăm KM");



                // Lấy dữ liệu từ cơ sở dữ liệu
                DataTable dtItems = dtBase.DataReader("select * from KhuyenMai join sach on khuyenmai.masach = sach.masach");

                if (dtItems != null && dtItems.Rows.Count > 0)
                {
                    foreach (DataRow row in dtItems.Rows)
                    {
                        int rowIndex = tblKhuyenMai.Rows.Add(row["TenSach"], row["ThoigianBatDau"],
                            row["ThoigianKetThuc"], row["KM"]);

                    }
                }
                else
                {
                    MessageBox.Show("Không có khuyến mãi nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị khuyến mãi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadComboBoxSach();
            SetControlsState(false);


        }
        private void LoadComboBoxSach()
        {
            string query = "SELECT TenSach FROM Sach";
            DataTable dt = dtBase.DataReader(query);

            comboBoxTenSach.DataSource = dt;
            comboBoxTenSach.DisplayMember = "TenSach"; // Hiển thị tên sách
        }
        private void SetControlsState(bool isEditing)
        {
            comboBoxTenSach.Enabled = isEditing;
            txtKM.Enabled = isEditing;
            dateTimePickerTGBD.Enabled = isEditing;
            dateTimePickerTGKT.Enabled = isEditing;
            btnLuu.Enabled = isEditing;
        }

    }
}
