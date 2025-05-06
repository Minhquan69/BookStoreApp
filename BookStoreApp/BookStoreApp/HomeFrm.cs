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

        private void tblDuLieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = tblDuLieu.Rows[e.RowIndex];
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtMaSach.Enabled = false;
                txtTenTG.Text = row.Cells["TacGia"].Value.ToString();
                string phanLoai = row.Cells["TenTheLoai"].Value.ToString();

                for (int i = 0; i < comboBoxPhanLoai.Items.Count; i++)
                {
                    // Chuyển mục hiện tại sang DataRowView
                    var item = comboBoxPhanLoai.Items[i] as DataRowView;
                    if (item != null && item["TenTheLoai"].ToString() == phanLoai)
                    {
                        comboBoxPhanLoai.SelectedIndex = i; // Chọn mục tương ứng
                        break;
                    }
                }


                string nxb = row.Cells["TenNXB"].Value.ToString();
                for (int i = 0; i < comboBoxNXB.Items.Count; i++)
                {
                    // Chuyển mục hiện tại sang DataRowView
                    var item = comboBoxNXB.Items[i] as DataRowView;
                    if (item != null && item["TenNXB"].ToString() == nxb)
                    {
                        comboBoxNXB.SelectedIndex = i; // Chọn mục tương ứng
                        break;
                    }
                }
                Console.WriteLine(nxb);

                txtGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoTrang.Text = row.Cells["SoTrang"].Value.ToString();
                txtMoTa.Text = row.Cells["GioiThieu"].Value.ToString();
                string file = row.Cells["FileSach"].Value.ToString();
                txtFileSach.Text = file.Split('/').Last();
                string fileXemThu = row.Cells["FileXemThu"].Value.ToString();
                txtFileXemThu.Text = Path.GetFileName(fileXemThu);

                string fileAnh = row.Cells["Anh"].Value.ToString();
                string imgPath = "";
                if (fileAnh.StartsWith("/files/"))
                {
                    imgPath = fileAnh.Substring(7); // Cắt bỏ "/files/"
                }
                else if (fileAnh.StartsWith("/images/"))
                {
                    imgPath = fileAnh.Substring(8);
                }
                else
                {
                    imgPath = fileAnh;
                }
                Console.WriteLine(imgPath);
                try
                {
                    picAnh.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\AnhSP\\" + imgPath);
                }
                catch (Exception ex)
                {
                    picAnh.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\AnhSP\\" + "bia.jpg");
                }

                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                btnXoaSP.Enabled = true;
                btnSuaSP.Enabled = true;
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DataTable dtItems = dtBase.DataReader("SELECT * FROM Sach s JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai " +
                                                      "JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB");
                PaginateDataGridView(tblDuLieu, dtItems, pageSize, currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataTable dtItems = dtBase.DataReader("SELECT * FROM Sach s JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai " +
                                                  "JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB");
            int totalPages = (int)Math.Ceiling((double)dtItems.Rows.Count / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                PaginateDataGridView(tblDuLieu, dtItems, pageSize, currentPage);
            }
        }
        private void btnNextt_Click(object sender, EventArgs e)
        {
            DataTable dtCustomers = dtBase.DataReader("SELECT * FROM KhachHang");
            int totalPages = (int)Math.Ceiling((double)dtCustomers.Rows.Count / pageSizeKH);

            if (currentPageKH < totalPages)
            {
                currentPageKH++;
                PaginateDataGridViewForCustomers(tblKhachHang, dtCustomers, pageSizeKH, currentPageKH, label_phanTrang);
            }
        }

        private void btnPree_Click(object sender, EventArgs e)
        {
            if (currentPageKH > 1)
            {
                currentPageKH--;
                DataTable dtCustomers = dtBase.DataReader("SELECT * FROM KhachHang");
                PaginateDataGridViewForCustomers(tblKhachHang, dtCustomers, pageSizeKH, currentPageKH, label_phanTrang);
            }
        }

        private void btnFileSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
            openFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\pdf\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị tên file PDF đã chọn trong txtFileSach
                string link = openFileDialog.FileName;
                if (sender == btnFileSach)
                {
                    txtFileSach.Text = link.Split('\\').Last(); // Chia bằng dấu \ thay vì /
                    return;
                }
                if (sender == btnFileXemThu)
                {
                    txtFileXemThu.Text = link.Split('\\').Last(); // Chia bằng dấu \ thay vì /
                }

            }
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\AnhSP\\";

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Chọn hình ảnh";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Đặt hình ảnh đã chọn vào PictureBox
                picAnh.Image = Image.FromFile(openFileDialog1.FileName);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            anhSachDaThayDoi = true;
            currentPathImage = openFileDialog1.SafeFileName;

        }

        // close app
        private void BtnCloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txtMaSach.Text;
                string tenSP = txtTenSach.Text;
                string tg = txtTenTG.Text;
                string nxb = comboBoxNXB.Text;
                string gia = txtGia.Text;
                string sotrang = txtSoTrang.Text;
                string theloai = comboBoxPhanLoai.Text;

                string mota = txtMoTa.Text;
                string filesach = txtFileSach.Text;
                string filexemthu = txtFileXemThu.Text;


                if (tenSP == "" || tg == "" || sotrang == "" || gia == "" || theloai == "" || filesach == "" || filexemthu == "" || nxb == "" || mota == "" || picAnh.Image == null)
                {
                    MessageBox.Show("Bạn không được để trống trường thông tin của sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(sotrang, out int soTrangValue) || soTrangValue <= 0)
                {
                    MessageBox.Show("Số trang phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(gia, out decimal giaTri) || giaTri <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Thực hiện cập nhật trong cơ sở dữ liệu
                string anh = "";
                if (anhSachDaThayDoi)
                {
                    anh = currentPathImage.ToString();
                }
                else
                {
                    DataGridViewRow selectedRow = tblKhachHang.SelectedRows[0];

                    // Lấy dữ liệu từ ô trong cột "MaKH"
                    anh = selectedRow.Cells["Anh"].Value.ToString();
                }
                string query = $@"
    UPDATE Sach
    SET
        TenSach = N'{tenSP}',
        TacGia = N'{tg}',
        MaTheLoai = (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theloai}'),
        MaNXB = (SELECT MaNXB FROM NhaXuatBan WHERE TenNXB = N'{nxb}'),
        DonGia = {gia},
        GioiThieu = N'{mota}',
        SoTrang = {sotrang},
        Anh = '{anh}',
        FileSach = N'{filesach}',
        FileXemThu = N'{filexemthu}'
    WHERE MaSach = '{masach}'";



                dtBase.DataChange(query);
                DisplayItems();
                MessageBox.Show("Sản phẩm này đã sửa thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSP = txtMaSach.Text;

                // Thực hiện xóa trong cơ sở dữ liệu
                string query = $"DELETE FROM Sach WHERE MaSach = '{maSP}'";
                dtBase.DataChange(query); // Thực thi truy vấn

                string truyvan = $"Select *  FROM Sach WHERE MaSach = '{maSP}'";
                if (!dtBase.Exist(truyvan))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLaiSach(); // Load lại dữ liệu vào DataGridView

                }
                else
                {
                    MessageBox.Show("Không thể xóa sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các ô nhập liệu

                string tenSP = txtTenSach.Text;
                string tg = txtTenTG.Text;
                string nxb = comboBoxNXB.Text;
                string gia = txtGia.Text;
                string sotrang = txtSoTrang.Text;
                string theloai = comboBoxPhanLoai.Text;

                string mota = txtMoTa.Text;
                string filesach = txtFileSach.Text;
                string filexemthu = txtFileXemThu.Text;



                if (tenSP == "" || tg == "" || sotrang == "" || gia == "" || theloai == "" || filesach == "" || filexemthu == "" || nxb == "" || mota == "" || currentPathImage == "" || picAnh.Image == null)
                {
                    MessageBox.Show("Bạn không được để trống trường thông tin của sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string query = $"INSERT INTO Sach ( TenSach, TacGia," +
                    $" MaTheLoai, MaNXB, DonGia, GioiThieu, SoTrang, Anh," +
                    $" FileSach, FileXemThu)\r\n" +
                    $"VALUES (   N'{tenSP}', N'{tg}'," +
                    $"(SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theloai}'), " +
                    $"(SELECT MaNXB FROM NhaXuatBan WHERE TenNXB = N'{nxb}'),{gia},N'{mota}'," +
                    $"{sotrang},'{currentPathImage}', -- Đường dẫn ảnh\r\n " +
                    $"'{filesach}', -- File sách\r\n    " +
                    $"'{filexemthu}' -- File xem thử\r\n);\r\n";

                // Thực thi query
                dtBase.DataChange(query);

                // Thông báo thành công
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiSach();
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFresh_Click(object sender, EventArgs e)
        {
            if (sender.Equals(btnFreshItem))
            {
                LoadLaiSach();

            }
            if (sender.Equals(btnRefreshCustomer))
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtSDTKH.Text = "";
                txtDiaChiKH.Text = "";
                txtMatKhau.Text = "";
                dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
                dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy"; // Chỉ hiển thị ngày/tháng/năm
                dateTimePickerNgaySinh.Value = DateTime.Now;
                pictureBoxKH.Image = null;
                btnHienMatKhau.Enabled = true;
                DisplayCustomers();
            }
            if (sender.Equals(btnRefreshDiscount))
            {
                //LoadLaiKM();
            }
        }

        private void LoadLaiSach()
        {
            try
            {
                tblDuLieu.Columns.Clear();
                tblDuLieu.Rows.Clear();

                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtTenTG.Text = "";
                comboBoxPhanLoai.Text = "";
                comboBoxNXB.Text = "";
                txtMoTa.Text = "";
                txtSoTrang.Text = "";
                txtGia.Text = "";
                txtFileSach.Text = "";
                txtFileXemThu.Text = "";
                picAnh.Image = null;

                tblDuLieu.Columns.Add("MaSach", "Mã Sách");
                tblDuLieu.Columns.Add("TenSach", "Tên Sách");
                tblDuLieu.Columns.Add("TacGia", "Tác giả");
                tblDuLieu.Columns.Add("TenTheLoai", "Thể loại");
                tblDuLieu.Columns.Add("TenNXB", "Nhà xuất bản");
                tblDuLieu.Columns.Add("DonGia", "Giá bán");
                tblDuLieu.Columns.Add("GioiThieu", "Số lượng");
                tblDuLieu.Columns["GioiThieu"].Visible = false;
                tblDuLieu.Columns.Add("SoTrang", "Số trang");
                tblDuLieu.Columns.Add("Anh", "Anh");
                tblDuLieu.Columns["Anh"].Visible = false;
                tblDuLieu.Columns["SoTrang"].Visible = false;
                tblDuLieu.Columns.Add("FileSach", "FileSach");
                tblDuLieu.Columns["FileSach"].Visible = false;
                tblDuLieu.Columns.Add("FileXemThu", "File Xem thử");
                tblDuLieu.Columns["FileXemThu"].Visible = false;


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

        private void SortItemHandler(object sender, EventArgs e)
        {

            if (radioSortItemByPriceASC.Checked)
            {
                tblDuLieu.Sort(tblDuLieu.Columns["DonGia"], ListSortDirection.Ascending);
            }
            else if (radioSortItemByPriceDESC.Checked)
            {
                tblDuLieu.Sort(tblDuLieu.Columns["DonGia"], ListSortDirection.Descending);
            }
            else if (radioSortItemByTonKho.Checked)
            {

            }
            else if (radioSortItemByName.Checked)
            {
                tblDuLieu.Sort(tblDuLieu.Columns["TenSach"], ListSortDirection.Ascending);
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            radioSortItemByPriceASC.Checked = false;
            radioSortItemByPriceDESC.Checked = false;
            radioSortItemByTonKho.Checked = false;
            radioSortItemByName.Checked = false;
            LoadLaiSach();
        }

        private void ComboSearchItemSelectefIndexChanged(object sender, EventArgs e)
        {

            switch (comboSearchItem.SelectedIndex)
            {
                case 0:
                case 1:
                    txtSearchItem.Enabled = true;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    LocPhanLoai.Enabled = false;
                    break;
                case 2:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    LocPhanLoai.Enabled = true;
                    labelTimKiem.Text = "Phân loại";
                    DataTable dt = dtBase.DataReader("select TheLoai.TenTheLoai from TheLoai");
                    LocPhanLoai.DataSource = dt;
                    LocPhanLoai.DisplayMember = "TenTheLoai";
                    break;
                case 3:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    LocPhanLoai.Enabled = true;
                    labelTimKiem.Text = "NXB";
                    DataTable tbl = dtBase.DataReader("select NhaXuatBan.TenNXB from NhaXuatBan");
                    LocPhanLoai.DataSource = tbl;
                    LocPhanLoai.DisplayMember = "TenNXB";
                    break;
                case 4:
                case 5:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = true;
                    numericItemTo.Enabled = true;
                    LocPhanLoai.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void BtnSearchItemClick(object sender, EventArgs e)
        {
            string sql = "";
            string name = "";
            if (comboSearchItem.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSearchItem.SelectedIndex == 0)//theo ten sach
            {
                name = txtSearchItem.Text;
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere s.TenSach like N'%{name}%'";

            }
            else if (comboSearchItem.SelectedIndex == 1)//ten tg
            {
                name = txtSearchItem.Text;
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere s.TacGia like N'%{name}%'";
            }
            else if (comboSearchItem.SelectedIndex == 2)//the loai
            {
                name = LocPhanLoai.Text;
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere tl.TenTheLoai =N'{name}'";
            }
            else if (comboSearchItem.SelectedIndex == 3)//nxb
            {
                name = LocPhanLoai.Text;
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere nxb.TenNXB = N'{name}'";
            }
            else if (comboSearchItem.SelectedIndex == 4)//soluong 
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                if (from > to)
                {
                    MessageBox.Show($"{from} không nhỏ hơn {to}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere s.SoLuong between {from} and {to}";

            }
            else if (comboSearchItem.SelectedIndex == 5)//khoang gia 
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                if (from > to)
                {
                    MessageBox.Show($"{from} không nhỏ hơn {to}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = $"select * from sach s join TheLoai tl on s.MaTheLoai = tl.MaTheLoai\r\njoin NhaXuatBan nxb on s.MaNXB = nxb.MaNXB\r\nwhere s.DonGia between {from} and {to}";

            }

            LoadSPCoQuery(sql);
            if (radioSortItemByName.Checked || radioSortItemByPriceASC.Checked || radioSortItemByPriceDESC.Checked || radioSortItemByTonKho.Checked)
            {
                SortItemHandler(sender, new EventArgs());
            }
        }

        private void LoadSPCoQuery(string query)
        {
            tblDuLieu.Columns.Clear();
            tblDuLieu.Rows.Clear();
            tblDuLieu.Columns.Add("MaSach", "Mã Sách");
            tblDuLieu.Columns.Add("TenSach", "Tên Sách");
            tblDuLieu.Columns.Add("TacGia", "Tác giả");
            tblDuLieu.Columns.Add("TenTheLoai", "Thể loại");
            tblDuLieu.Columns.Add("TenNXB", "Nhà xuất bản");
            tblDuLieu.Columns.Add("DonGia", "Giá bán");
            tblDuLieu.Columns.Add("GioiThieu", "Số lượng");
            tblDuLieu.Columns["GioiThieu"].Visible = false;
            tblDuLieu.Columns.Add("SoTrang", "Số trang");
            tblDuLieu.Columns["SoTrang"].Visible = false;
            tblDuLieu.Columns.Add("Anh", "Anh");
            tblDuLieu.Columns["Anh"].Visible = false;
            tblDuLieu.Columns.Add("FileSach", "FileSach");
            tblDuLieu.Columns["FileSach"].Visible = false;
            tblDuLieu.Columns.Add("FileXemThu", "File Xem thử");
            tblDuLieu.Columns["FileXemThu"].Visible = false;

            DataTable dtItems = new DataTable();
            dtItems = dtBase.DataReader(query);
            if (dtItems != null && dtItems.Rows.Count > 0)
            {
                foreach (DataRow row in dtItems.Rows)
                {
                    int rowIndex = tblDuLieu.Rows.Add(row["MaSach"],
                        row["TenSach"],
                        row["TacGia"],
                        row["TenTheLoai"], row["TenNXB"],
                        row["DonGia"], row["GioiThieu"], row["SoTrang"], row["Anh"],
                        row["FileSach"], row["FileXemThu"]
                        );

                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //KH
        private void tblKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxGioiTinh.SelectedItem = null;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = tblKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtMaKH.Enabled = false;
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtDiaChiKH.Text = row.Cells["DiaChi"].Value.ToString();
                string gt = row.Cells["GioiTinh"].Value.ToString();
                Console.WriteLine(gt);
                if (gt == "Nam")
                {
                    comboBoxGioiTinh.SelectedItem = comboBoxGioiTinh.Items[0];
                }
                if (gt == "Nữ")
                {
                    comboBoxGioiTinh.SelectedItem = comboBoxGioiTinh.Items[1];
                }
                txtSDTKH.Text = row.Cells["SDT"].Value.ToString();
                // Xử lý ngày sinh
                string ngaysinh = row.Cells["NgaySinh"].Value?.ToString();
                if (!string.IsNullOrEmpty(ngaysinh))
                {
                    try
                    {
                        DateTime dateTimeNgaySinh = DateTime.ParseExact(ngaysinh, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        dateTimePickerNgaySinh.Value = dateTimeNgaySinh;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ngày sinh không đúng định dạng dd-MM-yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu ngày sinh bị trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtMatKhau.PasswordChar = '*'; //hien thi mat khau bang *

                //xu ly anh
                string imgPath = row.Cells["Anh"].Value.ToString(); ;
                try
                {
                    pictureBoxKH.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\AnhKhachHang\\" + imgPath);
                }
                catch (Exception ex)
                {
                    pictureBoxKH.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\AnhKhachHang\\" + "avatar.png");
                }
                pictureBoxKH.SizeMode = PictureBoxSizeMode.StretchImage;

                btnHienMatKhau.Enabled = true;
                btnXoaKH.Enabled = true;
                btnSuaKH.Enabled = true;
            }
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (btnHienMatKhau.Text == "Hiện")
            {
                txtMatKhau.PasswordChar = '\0';
                btnHienMatKhau.Text = "Ẩn";
                return;
            }
            if (btnHienMatKhau.Text == "Ẩn")
            {
                txtMatKhau.PasswordChar = '*';
                btnHienMatKhau.Text = "Hiện";
                return;
            }

        }
        private void btnAnhKH_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\AnhKhachHang\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Chọn hình ảnh";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Đặt hình ảnh đã chọn vào PictureBox
                pictureBoxKH.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBoxKH.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (tblKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tblKhachHang.SelectedRows[0];

                // Lấy dữ liệu từ ô trong cột "MaKH"
                prePathImage = selectedRow.Cells["Anh"].Value.ToString();
            }
            anhKHDaThayDoi = true;
            currentPathImage = openFileDialog1.SafeFileName;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtDiaChiKH.Text == "" || txtSDTKH.Text == "" || comboBoxGioiTinh.SelectedItem.ToString() == "" || dateTimePickerNgaySinh.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn không được để trống trường thông tin của khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictureBoxKH.Image == null)
            {
                MessageBox.Show("Bạn không được để trống trường ảnh của khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenKH = txtTenKH.Text;
            string diachi = txtDiaChiKH.Text;
            string sdt = txtSDTKH.Text;
            string gt = comboBoxGioiTinh.SelectedItem.ToString();
            DateTime ngaysinh = dateTimePickerNgaySinh.Value;
            string ngaysinh2 = ngaysinh.ToString("yyyy-MM-dd");
            string matkhau = txtMatKhau.Text;
            string makh = txtMaKH.Text;
            string anh = "";

            if (anhKHDaThayDoi)
            {
                anh = currentPathImage;
            }
            else
            {
                anh = prePathImage;
            }

            //kiem tra da co khach hang hay chua ?
            string kiemtra = $"SELECT COUNT(*) \r\nFROM KhachHang \r\nWHERE TenKhachHang = N'{tenKH}'" +
                $"AND GioiTinh = N'{gt}'\r\n  " +
                $"AND DiaChi = N'{diachi}'\r\n  " +
                $"AND NgaySinh = '{ngaysinh2}'\r\n  " +
                $"AND SDT = '{sdt}'\r\n  " +
                $"AND Anh = '{anh}'\r\n  " +
                $"AND MatKhau = '{matkhau}';";
            if (!dtBase.Exist(kiemtra))
            {
                MessageBox.Show("Da ton tai khach hang nay", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tạo câu truy vấn SQL để cập nhật thông tin khách hàng
            string query = $@"UPDATE KhachHang  
                SET TenKhachHang = N'{tenKH}',  
                    GioiTinh = '{gt}',  
                    DiaChi = N'{diachi}',  
                    NgaySinh = '{ngaysinh2}',  
                    SDT = '{sdt}',  
                    Anh = '{anh}',  
                    MatKhau = '{matkhau}'  
                WHERE MaKH = '{makh}';
                ";

            try
            {
                dtBase.DataChange(query);
                DisplayCustomers();
                MessageBox.Show("Thông tin khách hàng đã sửa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi sửa thông tin khách hàng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra khách hàng đã từng mua hàng (tồn tại hóa đơn)
            string checkHoaDon = $"SELECT COUNT(*) FROM HoaDonBan WHERE MaKH = '{maKH}'";
            int count = dtBase.GetScalarValue(checkHoaDon); // Giả sử hàm này trả về int

            if (count > 0)
            {
                MessageBox.Show("Khách hàng này đã từng mua hàng. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lấy MaGH từ bảng GioHang theo MaKH
                string getMaGHQuery = $"SELECT MaGH FROM GioHang WHERE MaKH = '{maKH}'";
                string maGH = dtBase.GetFieldValue(getMaGHQuery); // Hàm này trả về string

                // Xóa dữ liệu trong bảng GioSanPham trước
                if (!string.IsNullOrEmpty(maGH))
                {
                    string deleteGioSanPham = $"DELETE FROM GioSanPham WHERE MaGH = '{maGH}'";
                    dtBase.DataChange(deleteGioSanPham);
                }

                // Xóa giỏ hàng
                string deleteGioHang = $"DELETE FROM GioHang WHERE MaKH = '{maKH}'";
                dtBase.DataChange(deleteGioHang);

                // Xóa khách hàng
                string deleteKH = $"DELETE FROM KhachHang WHERE MaKH = '{maKH}'";
                dtBase.DataChange(deleteKH);

                // Kiểm tra lại
                string truyvan = $"SELECT * FROM KhachHang WHERE MaKH = '{maKH}'";
                if (!dtBase.Exist(truyvan))
                {
                    MessageBox.Show("Xóa Khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCustomers();
                }
                else
                {
                    MessageBox.Show("Không thể xóa Khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddNewCustomerClick(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtDiaChiKH.Text == "" || txtSDTKH.Text == "" || comboBoxGioiTinh.SelectedItem.ToString() == "" || dateTimePickerNgaySinh.Text == "" || txtMatKhau.Text == "" || pictureBoxKH.Image == null)
            {
                MessageBox.Show("Bạn không được để trống trường thông tin của khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictureBoxKH.Image == null)
            {
                errorProvider1.SetError(btnAnhKH, "Chọn ảnh cho khách hàng");
            }

            string tenKH = txtTenKH.Text;
            string diachi = txtDiaChiKH.Text;
            string sdt = txtSDTKH.Text;
            string gt = comboBoxGioiTinh.SelectedItem.ToString();
            DateTime ngaysinh = dateTimePickerNgaySinh.Value;
            string ngaysinh2 = ngaysinh.ToString("yyyy-MM-dd");
            string matkhau = txtMatKhau.Text;

            string kiemtra = $"select * from KhachHang where SDT = '{sdt}'";
            DataTable dtcheck = dtBase.DataReader(kiemtra);
            if (dtcheck.Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại khách hàng \n Vui lòng nhập số điện thoại mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTKH.Text = "";
                errorProvider1.SetError(txtSDTKH, "Nhập số điện thoại mới!");
                return;
            }

            // Thực hiện cập nhật trong cơ sở dữ liệu

            string query = $"INSERT INTO KhachHang ( TenKhachHang, GioiTinh, DiaChi, NgaySinh, SDT, Anh, MatKhau)" +
                $"  \r\nVALUES ( N'{tenKH}', N'{gt}', N'{diachi}', '{ngaysinh2}', '{sdt}', '{currentPathImage}', '{matkhau}');\r\n"; //dg dan anh chua co

            dtBase.DataChange(query);
            DisplayItems();
            MessageBox.Show("Thông tin khách hàng này đã them thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayCustomers();
            return;
        }

        private void RadioSortCustomerCheckedChanged(object sender, EventArgs e)
        {
            if (tblKhachHang.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dòng để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (radioSortCustomerByName.Checked)
            {
                tblKhachHang.Sort(tblKhachHang.Columns["TenKhachHang"], ListSortDirection.Ascending);
            }
            else if (radioSortCustomerById.Checked)
            {
                tblKhachHang.Sort(tblKhachHang.Columns["MaKH"], ListSortDirection.Ascending);
            }
            else if (radioSortCustomerByBirthDate.Checked)
            {
                tblKhachHang.Sort(tblKhachHang.Columns["NgaySinh"], ListSortDirection.Ascending);
            }

        }

        private void btbBoLoc_Click(object sender, EventArgs e)
        {
            radioSortCustomerByBirthDate.Checked = false;
            radioSortCustomerById.Checked = false;
            radioSortCustomerByName.Checked = false;
        }

        private void BtnSearchCustomerClick(object sender, EventArgs e)
        {
            string sql = "";
            string name = "";
            if (comboSearchCustomer.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboSearchCustomer.SelectedIndex == 0) // ten khach hang gan dung
            {
                name = txtSearchCustomer.Text;
                sql = $"SELECT * \r\nFROM KhachHang\r\nWHERE TenKhachHang LIKE N'%{name}%';\r\n";
            }
            else if (comboSearchCustomer.SelectedIndex == 1) // ma khach hang
            {
                name = txtSearchCustomer.Text;
                sql = $"SELECT * \r\nFROM KhachHang\r\nWHERE MaKH = '{name}';\r\n";

            }
            else if (comboSearchCustomer.SelectedIndex == 2) // dia chi
            {
                name = txtSearchCustomer.Text;
                sql = $"SELECT * \r\nFROM KhachHang\r\nWHERE DiaChi LIKE N'%{name}%';\r\n";

            }
            else if (comboSearchCustomer.SelectedIndex == 3) // so dien thoai
            {
                name = txtSearchCustomer.Text.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql = $"SELECT * \r\nFROM KhachHang\r\nWHERE SDT = '{name}';\r\n";
            }
            LoadLaiKHCoQuery(sql);
            RadioSortCustomerCheckedChanged(sender, e);
        }

        private void LoadLaiKHCoQuery(string sql)
        {
            txtMaKH.Text = "";
            txtMaKH.Enabled = false;
            txtTenKH.Text = "";
            txtDiaChiKH.Text = "";
            comboBoxGioiTinh.Text = "";
            txtSDTKH.Text = "";
            dateTimePickerNgaySinh.Text = "";
            txtMatKhau.Text = "";

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
                DataTable dtItems = dtBase.DataReader(sql);

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

        //KM
        private void tblKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo dòng được chọn hợp lệ
            {
                DataGridViewRow row = tblKhuyenMai.Rows[e.RowIndex];

                // Lấy tên sách từ cột
                comboBoxTenSach.Text = row.Cells["TenSach"].Value?.ToString() ?? "";

                // Lấy phần trăm khuyến mãi
                txtKM.Text = row.Cells["KM"].Value?.ToString() ?? "";

                // Lấy thời gian bắt đầu và kết thúc
                if (DateTime.TryParse(row.Cells["ThoiGianBatDau"].Value?.ToString(), out DateTime thoigianbatdau))
                {
                    dateTimePickerTGBD.Value = thoigianbatdau;
                }
                else
                {
                    // Xử lý nếu dữ liệu thời gian không hợp lệ
                    dateTimePickerTGBD.Value = DateTime.Now; // Hoặc đặt giá trị mặc định
                }

                if (DateTime.TryParse(row.Cells["ThoiGianKetThuc"].Value?.ToString(), out DateTime thoigianketthuc))
                {
                    dateTimePickerTGKT.Value = thoigianketthuc;
                }
                else
                {
                    // Xử lý nếu dữ liệu thời gian không hợp lệ
                    dateTimePickerTGKT.Value = DateTime.Now; // Hoặc đặt giá trị mặc định
                }
            }
            SetControlsState(false);
        }

        private void BtnSearchDiscountClick(object sender, EventArgs e)
        {
            string searchText = txtSearchDiscount.Text.Trim();
            string searchOption = comboSearchDiscount.SelectedItem?.ToString();
            string query = string.Empty;
            DateTime currentDate = DateTime.Now;

            if (string.IsNullOrEmpty(searchOption))
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (searchOption.Equals("Sách trong thời gian khuyến mãi"))
            {
                query = $@"
               SELECT s.TenSach, km.ThoiGianBatDau, km.ThoiGianKetThuc, km.KM
               FROM Sach s
               JOIN KhuyenMai km ON s.MaSach = km.MaSach
               WHERE km.ThoiGianBatDau <= '{currentDate:yyyy-MM-dd}'
                 AND km.ThoiGianKetThuc >= '{currentDate:yyyy-MM-dd}'
                 {(string.IsNullOrEmpty(searchText) ? "" : $"AND s.TenSach LIKE N'%{searchText}%'")}";
            }
            else if (searchOption.Equals("Sách hết thời gian khuyến mãi"))
            {
                query = $@"
               SELECT s.TenSach, km.ThoiGianBatDau, km.ThoiGianKetThuc, km.KM
               FROM Sach s
               JOIN KhuyenMai km ON s.MaSach = km.MaSach
               WHERE '{currentDate:yyyy-MM-dd}' NOT BETWEEN km.ThoiGianBatDau AND km.ThoiGianKetThuc
                 {(string.IsNullOrEmpty(searchText) ? "" : $"AND s.TenSach LIKE N'%{searchText}%'")}";
            }

            // Đọc dữ liệu từ cơ sở dữ liệu
            if (!string.IsNullOrEmpty(query))
            {
                DataTable discounts = dtBase.DataReader(query);
                DisplayDiscountResults(discounts, searchOption);
            }
        }
        private void DisplayDiscountResults(DataTable discounts, string searchOption)
        {
            try
            {
                // Xóa các cột và dòng cũ (nếu có)
                tblKhuyenMai.Columns.Clear();
                tblKhuyenMai.Rows.Clear();

                // Thêm các cột vào tblKhuyenMai
                tblKhuyenMai.Columns.Add("TenSach", "Tên Sách");
                tblKhuyenMai.Columns.Add("ThoiGianBatDau", "Bắt đầu");
                tblKhuyenMai.Columns.Add("ThoiGianKetThuc", "Kết thúc");
                tblKhuyenMai.Columns.Add("KM", "Phần trăm KM");

                // Thêm dữ liệu vào tblKhuyenMai
                foreach (DataRow row in discounts.Rows)
                {
                    tblKhuyenMai.Rows.Add(
                        row["TenSach"],
                        row["ThoiGianBatDau"] ?? DBNull.Value,
                        row["ThoiGianKetThuc"] ?? DBNull.Value,
                        row["KM"] ?? DBNull.Value
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị khuyến mãi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadComboBoxSach();
            SetControlsState(false);
        }

        string tenSachCu;
        // Sự kiện btnSuaKM_Click
        private void btnSuaKM_Click(object sender, EventArgs e)
        {
            tenSachCu = comboBoxTenSach.Text;

            if (tblKhuyenMai.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetControlsState(true); // Chỉ bật trạng thái chỉnh sửa
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn
            if (tblKhuyenMai.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lấy thông tin dòng hiện tại
                DataGridViewRow row = tblKhuyenMai.CurrentRow;
                string tenSach = row.Cells["TenSach"].Value.ToString();

                // Lấy mã sách từ tên sách
                string queryMaSach = $"SELECT MaSach FROM Sach WHERE TenSach = N'{tenSach}'";
                DataTable dtMaSach = dtBase.DataReader(queryMaSach);

                if (dtMaSach.Rows.Count > 0)
                {
                    string maSach = dtMaSach.Rows[0]["MaSach"].ToString();

                    // Xóa khuyến mãi
                    string queryDelete = $"DELETE FROM KhuyenMai WHERE MaSach = '{maSach}'";
                    dtBase.DataChange(queryDelete);

                    MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại DataGridView
                    DisplayDiscount();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddNewDiscountClick(object sender, EventArgs e)
        {
            SetControlsState(true);
            comboBoxTenSach.Text = "";
            txtKM.Text = "";
            dateTimePickerTGBD.Value = DateTime.Now;
            dateTimePickerTGKT.Value = DateTime.Now;
            tenSachCu = null; // Reset tenSachCu khi thêm mới
        }

        private void BtnRefreshClick(object sender, EventArgs e)
        {
            if (sender.Equals(btnFreshItem))
            {
                //tblItem.Clear();
                comboSearchItem.SelectedIndex = -1;
                numericItemFrom.Value = 0;
                numericItemTo.Value = 0;
                txtSearchItem.Text = "";
                //display items again
                DisplayItems();
            }
            else if (sender.Equals(btnRefreshCustomer))
            {
                comboSearchCustomer.SelectedIndex = -1;
                txtSearchCustomer.Text = "";
                //display items again
                DisplayCustomers();
            }
            else if (sender.Equals(btnRefreshDiscount))
            {
                comboSearchDiscount.SelectedIndex = -1;
                txtSearchDiscount.Text = "";
                //display discount again
                DisplayDiscount();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveDiscount();
        }

        private void SaveDiscount()
        {
            string tenSach = comboBoxTenSach.Text;
            DateTime thoiGianBatDauMoi = dateTimePickerTGBD.Value;
            DateTime thoiGianKetThucMoi = dateTimePickerTGKT.Value;

            // Kiểm tra input
            if (string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(txtKM.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (thoiGianBatDauMoi >= thoiGianKetThucMoi)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formattedStartDate = thoiGianBatDauMoi.ToString("yyyy-MM-dd");
            string formattedEndDate = thoiGianKetThucMoi.ToString("yyyy-MM-dd");

            // Lấy MaSach mới từ tên sách được chọn
            string queryMaSachMoi = $"SELECT MaSach FROM Sach WHERE TenSach = N'{tenSach}'";
            DataTable dtMaSachMoi = dtBase.DataReader(queryMaSachMoi);
            string maSachMoi = dtMaSachMoi.Rows.Count > 0 ? dtMaSachMoi.Rows[0]["MaSach"].ToString() : string.Empty;

            if (string.IsNullOrEmpty(maSachMoi))
            {
                MessageBox.Show("Không tìm thấy sách với tên đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tblKhuyenMai.CurrentRow != null && !string.IsNullOrEmpty(tenSachCu)) // Trường hợp sửa
            {
                // Lấy MaSach từ tên sách cũ
                string queryMaSachCu = $"SELECT MaSach FROM Sach WHERE TenSach = N'{tenSachCu}'";
                DataTable dtMaSachCu = dtBase.DataReader(queryMaSachCu);
                string maSachCu = dtMaSachCu.Rows.Count > 0 ? dtMaSachCu.Rows[0]["MaSach"].ToString() : string.Empty;

                // Lấy thời gian cũ
                string queryOldTime = $"SELECT ThoiGianBatDau, ThoiGianKetThuc FROM KhuyenMai WHERE MaSach = '{maSachCu}'";
                DataTable dtOldTime = dtBase.DataReader(queryOldTime);
                DateTime oldStart = Convert.ToDateTime(dtOldTime.Rows[0]["ThoiGianBatDau"]);
                DateTime oldEnd = Convert.ToDateTime(dtOldTime.Rows[0]["ThoiGianKetThuc"]);

                // Kiểm tra xem ngày có thay đổi không
                bool isDateChanged = thoiGianBatDauMoi != oldStart || thoiGianKetThucMoi != oldEnd;

                // Nếu ngày có thay đổi thì mới cần kiểm tra chồng chéo
                if (isDateChanged && !IsTimeValid(maSachMoi, thoiGianBatDauMoi, thoiGianKetThucMoi))
                {
                    MessageBox.Show("Thời gian khuyến mãi bị chồng chéo với khuyến mãi hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string queryUpdate = $@"
                    UPDATE KhuyenMai 
                    SET MaSach = '{maSachMoi}', 
                        ThoiGianBatDau = '{formattedStartDate}', 
                        ThoiGianKetThuc = '{formattedEndDate}', 
                        KM = '{txtKM.Text}' 
                    WHERE MaSach = '{maSachCu}'";

                int result = dtBase.DataChange(queryUpdate);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Trường hợp thêm mới
            {
                // Kiểm tra thời gian chồng chéo
                if (!IsTimeValid(maSachMoi, thoiGianBatDauMoi, thoiGianKetThucMoi))
                {
                    MessageBox.Show("Thời gian khuyến mãi bị chồng chéo với khuyến mãi hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string queryInsert = $@"
                    INSERT INTO KhuyenMai (MaSach, ThoiGianBatDau, ThoiGianKetThuc, KM) 
                    VALUES ('{maSachMoi}', '{formattedStartDate}', '{formattedEndDate}', '{txtKM.Text}')";

                int result = dtBase.DataChange(queryInsert);

                if (result > 0)
                {
                    MessageBox.Show("Thêm khuyến mãi mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm khuyến mãi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DisplayDiscount();
            SetControlsState(false);
        }

        private bool IsTimeValid(string maSach, DateTime thoiGianBatDauMoi, DateTime thoiGianKetThucMoi)
        {
            string query = $@"
               SELECT COUNT(*) 
               FROM KhuyenMai 
               WHERE MaSach = '{maSach}' 
                 AND (
                     (ThoiGianBatDau <= '{thoiGianKetThucMoi:yyyy-MM-dd}' AND ThoiGianKetThuc >= '{thoiGianBatDauMoi:yyyy-MM-dd}')
                 )";

            // Kiểm tra nếu có bản ghi chồng chéo
            int count = Convert.ToInt32(dtBase.DataReader(query).Rows[0][0]);
            return count == 0; // Nếu không có chồng chéo, trả về true
        }

        private void BtnSearchStatClick(object sender, EventArgs e)
        {
            DateTime batdau = tuNgay.Value;
            DateTime ketthuc = denNgay.Value;

            string ngaydau = batdau.ToString("yyyy-MM-dd");
            string ngaycuoi = ketthuc.ToString("yyyy-MM-dd");

            clearTblThongKe();

            string query = $"";
            bool checkTime = checkBoxTime.Checked;
            if (!checkTime)
            {
                if (batdau > ketthuc)
                {
                    MessageBox.Show("Vui lòng chọn ngày bắt đầu nhỏ hơn !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (comboStat.SelectedIndex == 0) //            Các sách có danh thu tốt nhất
            {
                if (!checkTime) // check time
                {
                    query = $"select Sach.MaSach, TenSach, isnull(sum(ChiTietHDB.SoLuong * Sach.DonGia - ChiTietHDB.KhuyenMai), 0) DoanhThu\r\nfrom Sach left join ChiTietHDB on Sach.MaSach = ChiTietHDB.MaSach\r\njoin HoaDonBan on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\n" +
                        $"where Ngayban between '{ngaydau}' and '{ngaycuoi}'\r\ngroup by Sach.MaSach, TenSach\r\norder by sum(ChiTietHDB.SoLuong * Sach.DonGia) desc";
                }
                else
                {
                    query = "select Sach.MaSach, TenSach, isnull(sum(ChiTietHDB.SoLuong * Sach.DonGia - ChiTietHDB.KhuyenMai), 0) DoanhThu\r\nfrom Sach left join ChiTietHDB on Sach.MaSach = ChiTietHDB.MaSach\r\ngroup by Sach.MaSach, TenSach\r\norder by sum(ChiTietHDB.SoLuong * Sach.DonGia) desc";
                }

            }
            else if (comboStat.SelectedIndex == 1)//Các sách có nhiều lượt mua nhất
            {
                if (!checkTime)
                {
                    query = $"select Sach.MaSach, TenSach, isnull(sum(ChiTietHDB.SoLuong), 0) as LuotMua\r\nfrom Sach left join ChiTietHDB on Sach.MaSach = ChiTietHDB.MaSach\r\njoin HoaDonBan on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\n" +
                        $"where Ngayban between '{ngaydau}' and '{ngaycuoi}'\r\ngroup by Sach.MaSach, TenSach\r\norder by count(ChiTietHDB.SoLuong) desc";
                }
                else
                {
                    query = "select Sach.MaSach, TenSach, count(ChiTietHDB.SoLuong) LuotMua\r\nfrom Sach left join ChiTietHDB on Sach.MaSach = ChiTietHDB.MaSach\r\ngroup by Sach.MaSach, TenSach\r\norder by count(ChiTietHDB.SoLuong) desc";
                }
            }
            else if (comboStat.SelectedIndex == 2)//Các khách hàng mua nhiều hàng nhất
            {
                if (!checkTime)
                {
                    query = $"select KhachHang.MaKH, KhachHang.TenKhachHang, isnull(sum(ChiTietHDB.SoLuong), 0 ) SoLuongDaMua\r\nfrom KhachHang left join HoaDonBan on KhachHang.MaKH = HoaDonBan.MaKH\r\njoin ChiTietHDB on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\n" +
                        $"where Ngayban between '{ngaydau}' and '{ngaycuoi}'\r\ngroup by KhachHang.MaKH, KhachHang.TenKhachHang\r\norder by count(ChiTietHDB.SoLuong) desc";
                }
                else
                {
                    query = "select KhachHang.MaKH, KhachHang.TenKhachHang, isnull(sum(ChiTietHDB.SoLuong), 0 ) SoLuongDaMua\r\nfrom KhachHang left join HoaDonBan on KhachHang.MaKH = HoaDonBan.MaKH\r\njoin ChiTietHDB on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\ngroup by KhachHang.MaKH, KhachHang.TenKhachHang\r\norder by count(ChiTietHDB.SoLuong) desc";
                }
            }
            else if (comboStat.SelectedIndex == 3)//Các khách hàng chi nhiều tiền nhất
            {
                if (!checkTime)
                {
                    query = $"select KhachHang.MaKH, KhachHang.TenKhachHang, \r\n\tisnull(sum(ChiTietHDB.SoLuong*Sach.DonGia - ChiTietHDB.KhuyenMai), 0 ) as TongChiTieu\r\nfrom KhachHang left join HoaDonBan on KhachHang.MaKH = HoaDonBan.MaKH\r\njoin ChiTietHDB on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\njoin Sach on Sach.MaSach = ChiTietHDB.MaSach\r\n" +
                        $"where HoaDonBan.Ngayban between '{ngaydau}' and '{ngaycuoi}'\r\ngroup by KhachHang.MaKH, KhachHang.TenKhachHang\r\norder by TongChiTieu desc";
                }
                else
                {
                    query = "select KhachHang.MaKH, KhachHang.TenKhachHang, \r\n\tisnull(sum(ChiTietHDB.SoLuong*Sach.DonGia - ChiTietHDB.KhuyenMai), 0 ) as TongChiTieu\r\nfrom KhachHang left join HoaDonBan on KhachHang.MaKH = HoaDonBan.MaKH\r\njoin ChiTietHDB on HoaDonBan.MaHDB = ChiTietHDB.MaHDB\r\njoin Sach on Sach.MaSach = ChiTietHDB.MaSach\r\ngroup by KhachHang.MaKH, KhachHang.TenKhachHang\r\norder by TongChiTieu desc";
                }
            }
            else if (comboStat.SelectedIndex == 4)//Doanh thu theo từng tháng
            {
                if (!checkTime)
                {

                    query = $"DECLARE @NgayBatDau DATE = '{ngaydau}'; -- Thay đổi giá trị này\r\nDECLARE @NgayKetThuc DATE = '{ngaycuoi}'; -- Thay đổi giá trị này\r\n\r\nWITH ThangNamList AS (\r\n    SELECT \r\n        YEAR(Ngay) AS Nam, \r\n        MONTH(Ngay) AS Thang\r\n    FROM (\r\n        SELECT DATEADD(MONTH, v.number, @NgayBatDau) AS Ngay\r\n        FROM master.dbo.spt_values v\r\n        WHERE v.type = 'P' AND DATEADD(MONTH, v.number, @NgayBatDau) <= @NgayKetThuc\r\n    ) AS GeneratedDates\r\n)\r\nSELECT \r\n    T.Nam, \r\n    T.Thang, \r\n    ISNULL(SUM(ct.SoLuong * s.DonGia - ct.KhuyenMai), 0) AS DoanhThu\r\nFROM \r\n    ThangNamList T\r\nLEFT JOIN \r\n    HoaDonBan HDB \r\n    ON T.Thang = MONTH(HDB.NgayBan) AND T.Nam = YEAR(HDB.NgayBan)\r\nLEFT JOIN \r\n    ChiTietHDB ct \r\n    ON HDB.MaHDB = ct.MaHDB\r\nLEFT JOIN \r\n    Sach s \r\n    ON ct.MaSach = s.MaSach\r\nGROUP BY \r\n    T.Nam, T.Thang\r\nORDER BY \r\n    T.Nam, T.Thang;\r\n";
                }
                else
                {
                    query = "with ThangList as (\r\n\tselect 1 as Thang union all select 2 union all select 3 union all\r\n\tselect 4  union all select 5 union all select 6 union all\r\n\tselect 7  union all select 8 union all select 9 union all\r\n\tselect 10  union all select 11 union all select 12 )\r\nselect T.Thang, isnull(sum(ct.SoLuong*s.DonGia - ct.KhuyenMai), 0) as DoanhThu\r\nfrom Thanglist T left join HoaDonBan HDB on T.Thang = MONTH(HDB.NgayBan) AND YEAR(HDB.NgayBan) = 2024\r\nleft join ChiTietHDB ct on HDB.MaHDB = ct.MaHDB\r\nleft join Sach s on ct.MaSach = s.MaSach\r\ngroup by T.Thang";
                }

            }
            else if (comboStat.SelectedIndex == 5)//Danh thu theo từng ngày
            {
                if (!checkTime)
                {

                    query = $"WITH NgayList AS (  SELECT CONVERT(DATE, '{ngaydau}') AS Ngay    UNION ALL   SELECT DATEADD(DAY, 1, Ngay) FROM NgayList    WHERE Ngay < '{ngaycuoi}') SELECT  N.Ngay, ISNULL(SUM(ct.SoLuong * s.DonGia - ct.KhuyenMai), 0) AS DoanhThu FROM NgayList N LEFT JOIN HoaDonBan HDB ON N.Ngay = CAST(HDB.NgayBan AS DATE) LEFT JOIN ChiTietHDB ct ON HDB.MaHDB = ct.MaHDB LEFT JOIN Sach s ON ct.MaSach = s.MaSach GROUP BY N.Ngay OPTION (MAXRECURSION 0)";
                }
                else
                {
                    query = "WITH NgayList AS (\r\n    SELECT CONVERT(DATE, '2024-09-15') AS Ngay\r\n    UNION ALL\r\n    SELECT DATEADD(DAY, 1, Ngay)\r\n    FROM NgayList\r\n    WHERE Ngay < '2024-11-30'\r\n)\r\nSELECT  N.Ngay, ISNULL(SUM(ct.SoLuong * s.DonGia - ct.KhuyenMai), 0) AS DoanhThu\r\nFROM NgayList N\r\nLEFT JOIN HoaDonBan HDB ON N.Ngay = CAST(HDB.NgayBan AS DATE)\r\nLEFT JOIN ChiTietHDB ct ON HDB.MaHDB = ct.MaHDB\r\nLEFT JOIN Sach s ON ct.MaSach = s.MaSach\r\nGROUP BY N.Ngay\r\nOPTION (MAXRECURSION 0)";

                }
            }
            else if (comboStat.SelectedIndex == 6)//Danh thu theo từng năm
            {
                if (!checkTime)
                {
                    string nam1 = batdau.ToString("yyyy");
                    string nam2 = ketthuc.ToString("yyyy");
                    query = $"DECLARE @NamBatDau INT = {nam1}; -- Thay đổi năm bắt đầu\r\nDECLARE @NamKetThuc INT = {nam2}; -- Thay đổi năm kết thúc\r\n\r\nWITH DanhSachNam AS (\r\n    SELECT @NamBatDau AS Nam\r\n    UNION ALL\r\n    SELECT Nam + 1\r\n    FROM DanhSachNam\r\n    WHERE Nam < @NamKetThuc\r\n)\r\nSELECT \r\n    ds.Nam, \r\n    ISNULL(SUM(ct.SoLuong * s.DonGia - ct.KhuyenMai), 0) AS DoanhThu\r\nFROM \r\n    DanhSachNam ds\r\nLEFT JOIN \r\n    HoaDonBan HDB \r\n    ON ds.Nam = YEAR(HDB.NgayBan)\r\nLEFT JOIN \r\n    ChiTietHDB ct \r\n    ON HDB.MaHDB = ct.MaHDB\r\nLEFT JOIN \r\n    Sach s \r\n    ON ct.MaSach = s.MaSach\r\nGROUP BY \r\n    ds.Nam\r\nORDER BY \r\n    ds.Nam;\r\n";
                }
                else
                {
                    query = "SELECT \r\n    YEAR(HDB.NgayBan) AS Nam, \r\n    ISNULL(SUM(ct.SoLuong * s.DonGia - ct.KhuyenMai), 0) AS DoanhThu\r\nFROM \r\n    HoaDonBan HDB\r\nLEFT JOIN \r\n    ChiTietHDB ct \r\n    ON HDB.MaHDB = ct.MaHDB\r\nLEFT JOIN \r\n    Sach s \r\n    ON ct.MaSach = s.MaSach\r\nGROUP BY \r\n    YEAR(HDB.NgayBan)\r\nORDER BY \r\n    Nam;\r\n";
                }
            }
            else if (comboStat.Text != "")
            {
                MessageBox.Show("Vui lòng chọn đúng điều kiện để thống kê !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (comboStat.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tiêu chí thống kê !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = dtBase.DataReader(query);
            tblThongKe.DataSource = dt;
            return;
        }

        private void clearTblThongKe()
        {
            tblThongKe.DataSource = null;
            tblThongKe.Rows.Clear();
            tblThongKe.Columns.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tblThongKe.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Thiết lập phần đầu (Thông tin trường đại học và đề tài)
                worksheet.Cells[1, 1] = "Của hàng bán Sách - Minh Quân";
                worksheet.Cells[2, 1] = "Chi nhánh: Hà Nội";
                worksheet.Cells[3, 1] = "";  // Dòng trống
                if (comboStat.SelectedIndex == 0)
                    worksheet.Cells[4, 1] = "Thông kê sách có danh thu tốt nhất";
                if (comboStat.SelectedIndex == 1)
                    worksheet.Cells[4, 1] = "Thông kê sách có nhiều lượt mua nhất";
                if (comboStat.SelectedIndex == 2)
                    worksheet.Cells[4, 1] = "Thông kê sách có nhiều lượt mua nhất";
                if (comboStat.SelectedIndex == 3)
                    worksheet.Cells[4, 1] = "Thông kê khách hàng chi nhiều tiền nhất";
                if (comboStat.SelectedIndex == 4)
                    worksheet.Cells[4, 1] = "Thông kê Doanh thu theo từng tháng";
                if (comboStat.SelectedIndex == 5)
                    worksheet.Cells[4, 1] = "Thông kê Doanh thu theo từng ngày";
                if (comboStat.SelectedIndex == 6)
                    worksheet.Cells[4, 1] = "Thông kê Doanh thu theo từng năm";

                // Định dạng cho phần đầu
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].Font.Size = 14;
                worksheet.Range["A1"].Font.Color = Excel.XlRgbColor.rgbBlue;

                worksheet.Range["A2"].Font.Bold = true;
                worksheet.Range["A2"].Font.Size = 12;

                worksheet.Range["A4"].Font.Bold = true;
                worksheet.Range["A4"].Font.Size = 12;
                worksheet.Range["A4"].Font.Color = Excel.XlRgbColor.rgbRed;

                // Dòng trống trước khi thêm bảng dữ liệu
                worksheet.Cells[5, 1] = "";  // Dòng trống

                // Thêm tiêu đề cột từ DataGridView vào Excel
                for (int col = 0; col < tblThongKe.Columns.Count; col++)
                {
                    worksheet.Cells[6, col + 1] = tblThongKe.Columns[col].HeaderText;
                }

                // Định dạng tiêu đề bảng
                worksheet.Range["A6:" + (char)(64 + tblThongKe.Columns.Count) + "6"].Font.Bold = true;
                worksheet.Range["A6:" + (char)(64 + tblThongKe.Columns.Count) + "6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range["A6:" + (char)(64 + tblThongKe.Columns.Count) + "6"].Interior.Color = Excel.XlRgbColor.rgbGray;

                // Xuất dữ liệu từng dòng từ DataGridView vào Excel
                for (int row = 0; row < tblThongKe.Rows.Count; row++)
                {
                    for (int col = 0; col < tblThongKe.Columns.Count; col++)
                    {
                        var cellValue = tblThongKe.Rows[row].Cells[col].Value;
                        worksheet.Cells[row + 7, col + 1] = (cellValue != null) ? cellValue.ToString() : ""; // Kiểm tra và thay thế ô trống bằng ""
                    }
                }

                // Lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "ExportedData.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Dữ liệu đã được xuất ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Đóng workbook và ứng dụng Excel
                workbook.Close(false);
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu bạn cần !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || txtTop.Text == "" || LoaiBieuDoCB.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đủ điều kiện để tạo bảng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string top = txtTop.Text;
            DateTime tu = TuNgayPicker.Value;
            DateTime den = denNgayPicker.Value;
            if (tu >= den)
            {
                MessageBox.Show("Date Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //dinh dang lai bang
            tblBaoCao.DataSource = null;
            tblBaoCao.Rows.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                chart2.Visible = false;
                //bao cao theo san pham               
                tblBaoCao.Columns.Clear();
                string tuNgay = tu.ToString("yyyy-MM-dd");
                string denNgay = den.ToString("yyyy-MM-dd");

                string query = $"SELECT TOP {top} \r\n    Sach.TenSach,\r\n" +
                   $"    SUM(ChiTietHDB.SoLuong) AS TongSoLuongBan,\r\n " +
                   $"   SUM((ChiTietHDB.SoLuong * Sach.DonGia)- ChiTietHDB.KhuyenMai) AS TongDoanhThu\r\n" +
                   $"FROM ChiTietHDB\r\nINNER JOIN HoaDonBan ON HoaDonBan.MaHDB = ChiTietHDB.MaHDB \r\n" +
                   $" JOIN Sach ON Sach.MaSach = ChiTietHDB.MaSach\r\n" +
                   $"WHERE HoaDonBan.Ngayban >= '{tuNgay}'\r\n  AND HoaDonBan.Ngayban < '{denNgay}'" +
                   $"\r\nGROUP BY Sach.TenSach\r\nORDER BY TongSoLuongBan DESC;\r\n";

                DataTable tblsach = dtBase.DataReader(query);
                tblBaoCao.DataSource = tblsach;
                if (tblsach.Rows.Count == 0)
                {
                    chart1.Titles.Clear();
                    chart1.Titles.Add("Không có dữ liệu để hiển thị !");
                    chart1.Series.Clear();
                    return;
                }

                if (LoaiBieuDoCB.SelectedIndex == 0)
                {
                    chart1.Series.Clear(); // Xóa các series cũ

                    // Tạo danh sách lưu trữ tên sản phẩm và tổng số lượng bán
                    List<string> productNames = new List<string>();
                    List<double> totalSales = new List<double>();

                    double maxValue = 0;

                    // Duyệt qua dữ liệu và thêm vào danh sách
                    foreach (DataRow row in tblsach.Rows)
                    {
                        string tenSach = row["TenSach"].ToString();
                        double tongSoLuongBan = Convert.ToDouble(row["TongSoLuongBan"]);

                        productNames.Add(tenSach); // Lưu tên sản phẩm
                        totalSales.Add(tongSoLuongBan); // Lưu số lượng bán

                        if (tongSoLuongBan > maxValue)
                            maxValue = tongSoLuongBan; // Tìm giá trị lớn nhất
                    }

                    // Tạo series cho biểu đồ cột
                    var seriesSanPham = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Sản Phẩm Bán Chạy",
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                        XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                        YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double
                    };

                    // Thêm dữ liệu từ danh sách vào series
                    for (int i = 0; i < productNames.Count; i++)
                    {
                        seriesSanPham.Points.AddXY(productNames[i], totalSales[i]);
                    }

                    chart1.Series.Add(seriesSanPham);

                    chart1.Titles.Clear();
                    chart1.Titles.Add("Top Sản Phẩm Bán Chạy Nhất");
                    chart1.Width = 400;
                    chart1.Height = 250;
                }
                if (LoaiBieuDoCB.SelectedIndex == 1)//bieu do tron 
                {
                    chart1.Series.Clear();

                    // Tạo một series mới cho biểu đồ tròn
                    var seriesSanPham = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Sản Phẩm Bán Chạy",
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, // Đặt loại biểu đồ là tròn (Pie chart)
                        XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String, // Trục X có giá trị chuỗi
                        YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double  // Trục Y có giá trị số thực
                    };

                    // Thêm dữ liệu vào biểu đồ từ bảng tblsach (bảng sản phẩm)
                    foreach (DataRow row in tblsach.Rows)
                    {
                        string tenSach = row["TenSach"].ToString();
                        double tongSoLuongBan = Convert.ToDouble(row["TongSoLuongBan"]);

                        seriesSanPham.Points.AddXY(tenSach, tongSoLuongBan);
                    }

                    // Thêm series vào biểu đồ
                    chart1.Series.Add(seriesSanPham);

                    // Cấu hình tiêu đề và các thuộc tính khác của biểu đồ
                    chart1.Titles.Clear();
                    chart1.Titles.Add("Top Sản Phẩm Bán Chạy Nhất");
                    chart1.Width = 400;
                    chart1.Height = 250;

                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                //bao cao theo khach hang

                string query = $"SELECT TOP {top} \r\n    KhachHang.MaKH,\r\n    KhachHang.TenKhachHang,\r\n " +
                   $"   SUM(HoaDonBan.TongTien) AS TongChiTieu\r\n" +
                   $"FROM \r\n    KhachHang\r\nINNER JOIN \r\n    HoaDonBan ON KhachHang.MaKH = HoaDonBan.MaKH\r\n\t" +
                   $"WHERE HoaDonBan.Ngayban BETWEEN '{tu}' AND '{den}'\r\n" +
                   $"GROUP BY \r\n    KhachHang.MaKH, KhachHang.TenKhachHang\r\n" +
                   $"ORDER BY \r\n    TongChiTieu DESC;";
                DataTable tblKH = dtBase.DataReader(query);
                tblBaoCao.DataSource = tblKH;
                chart2.Visible = true;
                if (tblKH.Rows.Count == 0)
                {
                    chart2.Titles.Clear();
                    chart2.Titles.Add("Không có dữ liệu để hiển thị !");
                    chart2.Series.Clear();
                    return;
                }
                chart2.Series.Clear();
                List<string> customerNames = new List<string>();
                List<double> totalSpending = new List<double>();

                foreach (DataRow row in tblKH.Rows)
                {
                    string tenKH = row["TenKhachHang"].ToString();
                    double tongChiTieu = Convert.ToDouble(row["TongChiTieu"]);

                    customerNames.Add(tenKH);
                    totalSpending.Add(tongChiTieu);
                }
                if (LoaiBieuDoCB.SelectedIndex == 0)
                {
                    double maxValue = 0;
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Tổng chi tiêu",
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column, // Loại biểu đồ
                        XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String, // Trục X có giá trị là chuỗi
                        YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double  // Trục Y có giá trị là số thực
                    };

                    for (int i = 0; i < customerNames.Count; i++)
                    {
                        series.Points.AddXY(customerNames[i], totalSpending[i]);  // Thêm tên khách hàng và tổng chi tiêu vào biểu đồ
                        if (totalSpending[i] > maxValue)
                            maxValue = totalSpending[i];
                    }

                    chart2.Series.Add(series);
                    AdjustYAxis(chart1.ChartAreas[0], maxValue);
                    chart2.ChartAreas[0].AxisX.Title = "Khách Hàng";
                    chart2.ChartAreas[0].AxisY.Title = "Tổng Chi Tiêu (VND)";
                    chart2.Titles.Clear();
                    chart2.Titles.Add("Top Khách Hàng Theo Tổng Chi Tiêu");

                    chart2.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                    chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

                    series["PointWidth"] = "0.8";
                    chart2.Width = 400;
                    chart2.Height = 250;
                }
                if (LoaiBieuDoCB.SelectedIndex == 1)
                {
                    chart2.Series.Clear();

                    var seriesKhachHang = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Khách Hàng",
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                        XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                        YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double
                    };

                    foreach (DataRow row in tblKH.Rows)
                    {
                        string tenKhachHang = row["TenKhachHang"].ToString();
                        double tongChiTieu = Convert.ToDouble(row["TongChiTieu"]);

                        seriesKhachHang.Points.AddXY(tenKhachHang, tongChiTieu);
                    }

                    chart2.Series.Add(seriesKhachHang);
                    chart2.Titles.Clear();
                    chart2.Titles.Add("Top Khách Hàng Theo Tổng Chi Tiêu");
                    foreach (var point in seriesKhachHang.Points)
                    {
                        point.Label = ""; // Xóa nhãn (tên hoặc tỷ lệ phần trăm) trên từng phần tử
                    }
                    chart2.Width = 400;
                    chart2.Height = 250;
                }
            }
        }

        private void AdjustYAxis(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, double maxValue)
        {
            if (maxValue <= 10)
                chartArea.AxisY.Interval = 1; // Nếu giá trị nhỏ, chia từng đơn vị
            else if (maxValue <= 100)
                chartArea.AxisY.Interval = 10; // Nếu giá trị vừa, chia mỗi 10
            else if (maxValue <= 1000)
                chartArea.AxisY.Interval = 100; // Nếu giá trị lớn hơn
            else if (maxValue <= 10000)
                chartArea.AxisY.Interval = 1000; // Với giá trị cực lớn
            else if (maxValue <= 900000)
                chartArea.AxisX.Interval = 10000;
            else
                chartArea.AxisY.Interval = Math.Ceiling(maxValue / 10); // Chia thành 10 phần
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string defaultFolder = @"C:";

            if (chart2.Visible == false)
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Lưu biểu đồ dưới dạng hình ảnh",
                    FileName = "BieuDo.png",
                    InitialDirectory = defaultFolder
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Đảm bảo file có phần mở rộng .png
                    if (!filePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        filePath += ".png";
                    }

                    // Đặt kích thước ảnh đầu ra (bạn có thể thay đổi giá trị này cho phù hợp)
                    int outputWidth = 1200; // Chiều rộng ảnh đầu ra
                    int outputHeight = 800; // Chiều cao ảnh đầu ra

                    // Tạo Bitmap với kích thước gốc của biểu đồ
                    Bitmap bitmap = new Bitmap(chart1.Width, chart1.Height);
                    chart1.DrawToBitmap(bitmap, new Rectangle(0, 0, chart1.Width, chart1.Height));

                    // Tính tỷ lệ để giữ nguyên tỷ lệ gốc
                    float ratioX = (float)outputWidth / chart1.Width;
                    float ratioY = (float)outputHeight / chart1.Height;
                    float ratio = Math.Min(ratioX, ratioY); // Chọn tỷ lệ nhỏ hơn để giữ tỷ lệ của biểu đồ

                    // Tạo ảnh Bitmap mới với tỷ lệ đúng
                    int newWidth = (int)(chart1.Width * ratio);
                    int newHeight = (int)(chart1.Height * ratio);
                    Bitmap resizedBitmap = new Bitmap(bitmap, new Size(newWidth, newHeight));

                    // Lưu ảnh đã thay đổi kích thước
                    resizedBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                    // Giải phóng bộ nhớ
                    bitmap.Dispose();
                    resizedBitmap.Dispose();

                    MessageBox.Show("Biểu đồ đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Lưu biểu đồ dưới dạng hình ảnh",
                    FileName = "BieuDo.png",
                    InitialDirectory = defaultFolder
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Đảm bảo file có phần mở rộng .png
                    if (!filePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        filePath += ".png";
                    }

                    // Đặt kích thước ảnh đầu ra (bạn có thể thay đổi giá trị này cho phù hợp)
                    int outputWidth = 1200; // Chiều rộng ảnh đầu ra
                    int outputHeight = 800; // Chiều cao ảnh đầu ra

                    // Tạo Bitmap với kích thước gốc của biểu đồ
                    Bitmap bitmap = new Bitmap(chart2.Width, chart2.Height);
                    chart2.DrawToBitmap(bitmap, new Rectangle(0, 0, chart2.Width, chart2.Height));

                    // Tính tỷ lệ để giữ nguyên tỷ lệ gốc
                    float ratioX = (float)outputWidth / chart2.Width;
                    float ratioY = (float)outputHeight / chart2.Height;
                    float ratio = Math.Min(ratioX, ratioY); // Chọn tỷ lệ nhỏ hơn để giữ tỷ lệ của biểu đồ

                    // Tạo ảnh Bitmap mới với tỷ lệ đúng
                    int newWidth = (int)(chart2.Width * ratio);
                    int newHeight = (int)(chart2.Height * ratio);
                    Bitmap resizedBitmap = new Bitmap(bitmap, new Size(newWidth, newHeight));

                    // Lưu ảnh đã thay đổi kích thước
                    resizedBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                    // Giải phóng bộ nhớ
                    bitmap.Dispose();
                    resizedBitmap.Dispose();

                    MessageBox.Show("Biểu đồ đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
