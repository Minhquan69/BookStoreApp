using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.ViewNguoiMua
{

    public partial class LichSuMua : UserControl
    {
        Classes.DataBaseProcess db = new Classes.DataBaseProcess();
        string imageName = "";
        string NameKH = "";
        string MaKH = "";
        private string fileSach = "";
        public LichSuMua(string tenkh)
        {
            NameKH = tenkh;
            InitializeComponent();
            LayMaKH();
            LoadData();
            resetStutus();
        }
        private void LayMaKH()
        {
            DataTable dtNhanVien = db.DataReader($"SELECT MaKH FROM KhachHang WHERE TenKhachHang = N'{NameKH}'");
            MaKH = dtNhanVien.Rows[0]["MaKH"].ToString();
        }
        private DataTable dtHoaDon;
        private int currentPage = 0;
        private int rowsPerPage = 1;

        private void LoadData()
        {
            DataTable dtHoaDon = db.DataReader(
                $"SELECT ROW_NUMBER() OVER (ORDER BY MaHDB) AS STT,MaHDB, " +
                $"CONVERT(VARCHAR(10), NgayBan, 120) AS Ngay, " +
                $"CONVERT(VARCHAR(8), NgayBan, 108) AS Gio, TongTien " +
                $"FROM HoaDonBan " +
                $"WHERE MaKH = '{MaKH}'");
            dgvHD.DataSource = dtHoaDon;

            // Đặt tiêu đề cột
            dgvHD.Columns[0].HeaderText = "STT";
            dgvHD.Columns[1].HeaderText = "Đơn Hàng";
            dgvHD.Columns[2].HeaderText = "Ngày Mua";
            dgvHD.Columns[3].HeaderText = "Thời Gian";
            dgvHD.Columns[4].HeaderText = "Tổng Tiền";
            dgvHD.Columns[0].Width = 50;


        }
        private void resetStutus()
        {
            dtTuNgay.Value = DateTime.Now;
            dtDenNgay.Value = DateTime.Now;
            txtGiaTu.Clear();
            txtGiaTu.Clear();
            txtTongSach.Clear();
            txtTongTien.Clear();
            txtThoiGian.Clear();
            dtNgayMua.Value = DateTime.Now;
            groupBoxCTDH.Visible = false;
            groupBoxTTS.Visible = false;
            imageName = "";
            this.Select();
        }

        public delegate void OnBackButtonClickedHandler();
        public event OnBackButtonClickedHandler OnBackButtonClicked;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            OnBackButtonClicked?.Invoke();
            // this.Close();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dtNgayMua.Text = dgvHD.CurrentRow.Cells[2].Value.ToString();
            txtThoiGian.Text = dgvHD.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dgvHD.CurrentRow.Cells[4].Value.ToString();
            // Lấy MaHDB của hóa đơn đã chọn
            string maHDB = dgvHD.CurrentRow.Cells[1].Value.ToString(); // Lấy giá trị Mã Hóa Đơn (MaHDB)

            // Thực hiện câu lệnh SQL để lấy số lượng sách
            DataTable dtSL = db.DataReader($"SELECT SUM(SoLuong) " +
                           $"FROM HoaDonBan " +
                           $"JOIN ChiTietHDB ON HoaDonBan.MaHDB = ChiTietHDB.MaHDB " +
                           $"WHERE HoaDonBan.MaHDB = '{maHDB}' AND HoaDonBan.MaKH = '{MaKH}'");
            if (dtSL.Rows.Count > 0 && dtSL.Rows[0][0] != DBNull.Value)
            {
                txtTongSach.Text = dtSL.Rows[0][0].ToString(); // Hiển thị số lượng sách vào txtTongSach
            }
            else
            {
                txtTongSach.Text = "0"; // Nếu không có dữ liệu thì hiển thị 0
            }
            groupBoxCTDH.Visible = true;
            LoadCTHD(maHDB);
        }
        private void btnInLichSu_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng
            DataTable TTKH = db.DataReader(
                           $"SELECT TenKhachHang, GioiTinh, FORMAT(NgaySinh, 'dd/MM/yyyy'), SDT, DiaChi FROM KhachHang " +
                           $"WHERE MaKH = '{MaKH}'");

            string tenkh = "", gioitinh = "", ngaysinh = "", sdt = "", diachi = "";
            if (TTKH.Rows.Count > 0)
            {
                tenkh = TTKH.Rows[0][0]?.ToString();
                gioitinh = TTKH.Rows[0][1]?.ToString();
                ngaysinh = TTKH.Rows[0][2]?.ToString();
                sdt = TTKH.Rows[0][3]?.ToString();
                diachi = TTKH.Rows[0][4]?.ToString();
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("LichSuMua");

                // Thêm tiêu đề
                worksheet.Cell("A1").Value = "CỬA HÀNG BÁN SÁCH - MINH QUÂN";
                worksheet.Range("A1:H1").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontSize(15)
                    .Font.SetFontColor(XLColor.Blue)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                worksheet.Cell("A2").Value = "MINH QUÂN";
                worksheet.Range("A2:H2").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontSize(15)
                    .Font.SetFontColor(XLColor.Blue)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                worksheet.Cell("A4").Value = "Lịch Sử Mua Hàng";
                worksheet.Range("A4:H4").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontColor(XLColor.Red)
                    .Font.SetFontSize(14)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                // Thêm thông tin khách hàng
                worksheet.Cell("A6").Value = "Họ Tên:";
                worksheet.Cell("B6").Value = tenkh;
                worksheet.Cell("E6").Value = "Giới Tính:";
                worksheet.Cell("F6").Value = gioitinh;

                worksheet.Cell("A7").Value = "Ngày Sinh:";
                worksheet.Cell("B7").Value = ngaysinh;
                worksheet.Cell("E7").Value = "SĐT:";
                worksheet.Cell("F7").Value = sdt;

                worksheet.Cell("A8").Value = "Địa Chỉ:";
                worksheet.Cell("B8").Value = diachi;
                worksheet.Range("B8:F8").Merge();

                // Thêm tiêu đề bảng
                worksheet.Cell("A10").Value = "STT";
                worksheet.Cell("B10").Value = "Đơn hàng";
                worksheet.Cell("C10").Value = "Ngày mua";
                worksheet.Cell("D10").Value = "Thời gian";
                worksheet.Cell("E10").Value = "Tên sách";
                worksheet.Range("E10:F10").Merge();
                worksheet.Cell("G10").Value = "Tác Giả";
                worksheet.Cell("H10").Value = "Tổng tiền";

                var headerRange = worksheet.Range("A10:H10");
                headerRange.Style
                    .Font.SetBold(true)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Fill.SetBackgroundColor(XLColor.LightGray);
                // Thêm dữ liệu từ DataGridView
                int row = 11; // Bắt đầu từ dòng 11
                decimal tongTienTatCa = 0; // Tổng tiền

                foreach (DataGridViewRow dgvRow in dgvHD.Rows)
                {
                    if (!dgvRow.IsNewRow)
                    {
                        worksheet.Cell(row, 1).Value = dgvRow.Cells[0].Value?.ToString(); // STT
                        worksheet.Cell(row, 2).Value = dgvRow.Cells[1].Value?.ToString(); // Đơn hàng
                        worksheet.Cell(row, 3).Value = dgvRow.Cells[2].Value?.ToString(); // Ngày mua
                        worksheet.Cell(row, 4).Value = dgvRow.Cells[3].Value?.ToString(); // Thời gian
                        worksheet.Range(row, 8, row + 1, 8).Merge(); // Gộp ô từ dòng row đến dòng row + 1 tại cột 8 (H)
                                                                     // Đặt giá trị Tổng tiền
                        worksheet.Cell(row, 8).Value = dgvRow.Cells[4].Value?.ToString(); // Tổng tiền
                                                                                          // Canh giữa giá trị trong ô gộp
                        worksheet.Cell(row, 8).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                        worksheet.Cell(row, 8).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                        // Cộng tổng tiền
                        if (decimal.TryParse(dgvRow.Cells[4].Value?.ToString(), out decimal tongTien))
                        {
                            tongTienTatCa += tongTien;
                        }

                        // Ghi chi tiết từng hóa đơn
                        string maHDB = dgvRow.Cells[1].Value?.ToString();
                        DataTable dtChiTiet = db.DataReader(
                            $"SELECT Sach.TenSach, Sach.TacGia " +
                            $"FROM ChiTietHDB JOIN Sach ON ChiTietHDB.MaSach = Sach.MaSach " +
                            $"WHERE ChiTietHDB.MaHDB = '{maHDB}'");
                        foreach (DataRow chiTiet in dtChiTiet.Rows)
                        {
                            worksheet.Cell(row, 5).Value = chiTiet["TenSach"]?.ToString(); // Tên sách
                            worksheet.Range(row, 5, row, 6).Merge(); // Gộp 2 ô E và F
                            worksheet.Cell(row, 7).Value = chiTiet["TacGia"]?.ToString();
                            row++;
                        }
                    }
                }

                // Thêm tổng tiền
                worksheet.Cell(row, 7).Value = "Tổng tiền tất cả:";
                worksheet.Cell(row, 8).Value = tongTienTatCa;
                worksheet.Cell(row, 7).Style.Font.SetBold(true);
                worksheet.Cell(row, 8).Style.Font.SetBold(true);

                // Kiểm tra và lưu file Excel với tên mới nếu file đã tồn tại
                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Lưu file lịch sử mua hàng",
                    Filter = "Excel Files|*.xlsx",
                    FileName = "LichSuMuaHang.xlsx"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        string fileExtension = Path.GetExtension(filePath);
                        string directory = Path.GetDirectoryName(filePath);

                        int count = 1;
                        string newFilePath = filePath;

                        // Kiểm tra nếu file đã tồn tại thì thêm số vào tên file
                        while (File.Exists(newFilePath))
                        {
                            newFilePath = Path.Combine(directory, $"{fileName}_{count}{fileExtension}");
                            count++;
                        }

                        workbook.SaveAs(newFilePath);
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void LoadCTHD(string maHDB)
        {

            DataTable dtCTHoaDon = db.DataReader(
                $"SELECT ROW_NUMBER() OVER (ORDER BY MaHDB) AS STT, " +
                $"ChiTietHDB.MaSach , TenSach, Sach.TacGia, KhuyenMai " +
                $"from ChiTietHDB join Sach on ChiTietHDB.MaSach = Sach.MaSach " +
                $"WHERE MaHDB = '{maHDB}'");
            dgvCTHD.DataSource = dtCTHoaDon;

            // Đặt tiêu đề cột
            dgvCTHD.Columns[0].HeaderText = "STT";
            dgvCTHD.Columns[1].HeaderText = "Sách";
            dgvCTHD.Columns[2].HeaderText = "Tên Sách";
            dgvCTHD.Columns[3].HeaderText = "Tác Giả";
            dgvCTHD.Columns[4].HeaderText = "Giảm Giá";
            dgvCTHD.Columns[0].Width = 50;
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            string maSach = dgvCTHD.CurrentRow.Cells[1].Value.ToString();
            lbTenSach.Text = dgvCTHD.CurrentRow.Cells[2].Value.ToString();
            DataTable TTSach = db.DataReader(
                           $"select TenSach, TacGia, LanXB, TenTheLoai, TenNXB, FORMAT(ThoiGianPhatHanh, 'dd/MM/yyyy') AS Ngay, Anh, FileSach " +
                           $"from Sach join TheLoai on Sach.MaTheLoai = TheLoai.MaTheLoai " +
                           $"join NhaXuatBan on Sach.MaNXB = NhaXuatBan.MaNXB " +
                           $"where MaSach = '{maSach}' ");

            if (TTSach.Rows.Count > 0)
            {
                lbTacGia.Text = TTSach.Rows[0][1].ToString();
                lbLanXB.Text = TTSach.Rows[0][2].ToString();
                lbTheLoai.Text = TTSach.Rows[0][3].ToString();
                lbNXB.Text = TTSach.Rows[0][4].ToString();
                lbTGPhatHanh.Text = TTSach.Rows[0][5].ToString();
                imageName = TTSach.Rows[0][6].ToString();
                groupBoxTTS.Visible = true;
                fileSach = TTSach.Rows[0][7].ToString();
            }
            else
            {
                lbTacGia.Text = "";
                lbLanXB.Text = "";
                lbNXB.Text = "";
                lbTheLoai.Text = "";
                lbTGPhatHanh.Text = "";
                groupBoxTTS.Visible = false;
            }
            if (imageName != "")
            {
                ptbAnhSach.Image = Image.FromFile(Application.StartupPath + "\\AnhSP\\" + imageName);
            }
            else
            {
                ptbAnhSach.Image = null;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            resetStutus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCTHD.DataSource = null;
            string query = @"
                SELECT ROW_NUMBER() OVER (ORDER BY MaHDB) AS STT,MaHDB, 
                CONVERT(VARCHAR(10), NgayBan, 120) AS Ngay,
                CONVERT(VARCHAR(8), NgayBan, 108) AS Gio, TongTien 
                FROM HoaDonBan
                WHERE MaKH = '" + MaKH + "' ";
            if (!string.IsNullOrEmpty(dtTuNgay.Text))
            {
                string tuNgay = DateTime.Parse(dtTuNgay.Text).ToString("yyyy-MM-dd");
                query += $" AND NgayBan >= '{tuNgay}'";
            }
            if (!string.IsNullOrEmpty(dtDenNgay.Text))
            {
                string DenNgay = DateTime.Parse(dtDenNgay.Text).ToString("yyyy-MM-dd");
                query += $" AND NgayBan <= '{DenNgay}'";
            }
            if (!string.IsNullOrEmpty(txtGiaTu.Text))
            {
                query += $" AND TongTien >= '{txtGiaTu.Text}'";
            }
            if (!string.IsNullOrEmpty(txtGiaDen.Text))
            {
                query += $" AND TongTien <= '{txtGiaDen.Text}'";
            }
            DataTable dtHoaDon = db.DataReader(query);
            dgvHD.DataSource = dtHoaDon;

            // Đặt tiêu đề cột
            dgvHD.Columns[0].HeaderText = "STT";
            dgvHD.Columns[1].HeaderText = "Đơn Hàng";
            dgvHD.Columns[2].HeaderText = "Ngày Mua";
            dgvHD.Columns[3].HeaderText = "Thời Gian";
            dgvHD.Columns[4].HeaderText = "Tổng Tiền";
            dgvHD.Columns[0].Width = 50;

            LoadTK();
        }
        private void LoadTK()
        {
            txtTongSach.Clear();
            txtTongTien.Clear();
            txtThoiGian.Clear();
            dtNgayMua.Value = DateTime.Now;
            groupBoxCTDH.Visible = false;
            groupBoxTTS.Visible = false;
            imageName = "";
            this.Select();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileSach))
            {
                MessageBox.Show("Không có file sách nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Lưu file sách",
                Filter = "PDF Files|*.pdf|All Files|*.*", // Thay đổi tùy theo loại file
                FileName = Path.GetFileNameWithoutExtension(fileSach) // Lấy tên file từ đường dẫn (không phần mở rộng)
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourcePath = Path.Combine(Application.StartupPath, "FileSach", fileSach);
                    string destinationPath = saveFileDialog.FileName;

                    // Kiểm tra xem file nguồn có tồn tại không
                    if (!File.Exists(sourcePath))
                    {
                        MessageBox.Show("File nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra xem file đích đã tồn tại chưa
                    if (File.Exists(destinationPath))
                    {
                        DialogResult result = MessageBox.Show("File đã tồn tại. Bạn có muốn tiếp tục tải xuống không?",
                                                              "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            return; // Người dùng không muốn tiếp tục
                        }

                        // Đánh số file mới
                        string directory = Path.GetDirectoryName(destinationPath);
                        string fileName = Path.GetFileNameWithoutExtension(destinationPath);
                        string extension = Path.GetExtension(destinationPath);
                        int counter = 1;

                        do
                        {
                            destinationPath = Path.Combine(directory, $"{fileName} ({counter}){extension}");
                            counter++;
                        } while (File.Exists(destinationPath)); // Lặp cho đến khi tên file không trùng
                    }

                    // Copy file tới đích
                    File.Copy(sourcePath, destinationPath, true);
                    MessageBox.Show("Tải file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
