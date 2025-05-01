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
    }
}
