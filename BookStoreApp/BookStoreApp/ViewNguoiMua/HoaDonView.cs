using ClosedXML.Excel;
using BookStoreApp.Classes;
using BookStoreApp.Sign;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreApp.ViewNguoiMua
{
    public partial class HoaDonView : Form
    {
        private string userName = SignIn.userName;
        private readonly DataBaseProcess db = new DataBaseProcess();
        private List<string> selectedMasach;
        private bool isOrderPlaced = false;
        public HoaDonView()
        {
            InitializeComponent();
            LoadThongTinSanPham();
            LoadThongTinKhachHang();
        }
        public HoaDonView(List<string> selectedMasach)
        {

            InitializeComponent();
            this.selectedMasach = selectedMasach;
            LoadThongTinSanPham();
            LoadThongTinKhachHang();
        }

        // Hàm tải thông tin khách hàng
        public void LoadThongTinKhachHang()
        {
            try
            {
                string query = "SELECT Tenkhachhang, DiaChi FROM KhachHang WHERE MaKH = @userName";
                var parameters = new Dictionary<string, object>
                {
                    { "@userName", userName }
                };

                DataTable customerData = db.DataRead(query, parameters);

                if (customerData.Rows.Count > 0)
                {
                    labelTenKH.Text = customerData.Rows[0]["tenkhachhang"].ToString();
                    labelDiaChi.Text = customerData.Rows[0]["DiaChi"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message);
            }
        }

        // Hàm cập nhật tổng tiền, voucher, và tiền cố định
        public void UpdateTotalItems()
        {
            try
            {
                if (selectedMasach == null || selectedMasach.Count == 0)
                {
                    MessageBox.Show("Danh sách sản phẩm được chọn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string masachParams = string.Join(",", selectedMasach.Select((s, i) => "@masach" + i));

                string query = $@"
                    SELECT 
                        SUM(giosanpham.soluong * sach.dongia) AS TongTienCoDinh,
                        SUM(
                            CASE 
                                WHEN khuyenmai.Masach IS NOT NULL 
                                     AND GETDATE() BETWEEN khuyenmai.ThoigianBatDau AND khuyenmai.ThoiGianKetThuc
                                THEN giosanpham.soluong * sach.dongia * khuyenmai.KM / 100
                                ELSE 0
                            END
                        ) AS TongTienVoucher
                    FROM giohang
                    JOIN giosanpham ON giohang.magh = giosanpham.magh
                    JOIN sach ON sach.Masach = giosanpham.Masach
                    LEFT JOIN khuyenmai ON khuyenmai.Masach = sach.Masach
                    WHERE giohang.MaKH = @userName
                      AND giosanpham.Masach IN ({masachParams})";

                var parameters = new Dictionary<string, object>
        {
            { "@userName", userName }
        };

                for (int i = 0; i < selectedMasach.Count; i++)
                {
                    parameters.Add($"@masach{i}", selectedMasach[i]);
                }

                DataTable totalData = db.DataRead(query, parameters);

                if (totalData.Rows.Count > 0)
                {
                    decimal tongTienCoDinh = Convert.ToDecimal(totalData.Rows[0]["TongTienCoDinh"] ?? 0);
                    decimal tongTienVoucher = Convert.ToDecimal(totalData.Rows[0]["TongTienVoucher"] ?? 0);
                    decimal tongThanhToan = tongTienCoDinh - tongTienVoucher;

                    labelTongTienCoDinh.Text = tongTienCoDinh.ToString("N0") + " VND";
                    labelTongTienVoucher.Text = tongTienVoucher.ToString("N0") + " VND";
                    labelTongThanhToan.Text = tongThanhToan.ToString("N0") + " VND";
                }
                else
                {
                    labelTongTienCoDinh.Text = "0 VND";
                    labelTongTienVoucher.Text = "0 VND";
                    labelTongThanhToan.Text = "0 VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
            }
        }

        private Panel CreateSanPhamPanel(DataRow row, string imagePath, int yOffset)
        {
            Panel panelSanPham = new Panel
            {
                Width = panelHienThiThongTinSanPham.Width - 20,
                Height = 100,
                Location = new Point(10, yOffset)
            };
            PictureBox productImage = new PictureBox
            {
                Width = 80,
                Height = 80,
                Location = new Point(10, 10),
                ImageLocation = imagePath + "\\" + row["Anh"].ToString(),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label labelTenSach = new Label
            {
                Text = "Tên sách: " + row["tensach"].ToString(),
                Location = new Point(100, 10),
                Width = panelSanPham.Width - 110
            };
            Label labelGiaGoc = new Label
            {
                Text = "Giá gốc: " + Convert.ToDecimal(row["dongia"]).ToString(),
                Location = new Point(100, 60)
            };

            Label labelGiaKhuyenMai = new Label
            {
                AutoSize = true,
                Location = new Point(100, 35) // Set position above the "Giá gốc"
            };
            // Sửa lại điều kiện kiểm tra
            if (row["km"] != DBNull.Value)
            {
                labelGiaKhuyenMai.Text = $"Khuyến mãi: {row["km"]}%";
            }
            else
            {
                labelGiaKhuyenMai.Text = "Khuyến mãi: 0%";
            }

            panelSanPham.Controls.Add(productImage);
            panelSanPham.Controls.Add(labelTenSach);
            panelSanPham.Controls.Add(labelGiaGoc);
            panelSanPham.Controls.Add(labelGiaKhuyenMai);

            return panelSanPham;
        }

        // Hàm tải thông tin giỏ hàng
        public void LoadThongTinSanPham()
        {
            try
            {
                // Tạo chuỗi parameter cho IN clause
                string masachParams = string.Join(",", selectedMasach.Select((s, i) => "@masach" + i));

                string query = $@"
                SELECT 
                    giohang.magh, 
                    giosanpham.Masach, 
                    sach.tensach,
                    sach.tacgia,
                    giosanpham.soluong AS soluong_giohang,
                    sach.soluong AS soluong_tonkho,
                    sach.dongia, 
                    sach.Anh,
                    CASE 
                        WHEN khuyenmai.Masach IS NOT NULL 
                             AND GETDATE() BETWEEN khuyenmai.ThoigianBatDau AND khuyenmai.ThoiGianKetThuc
                        THEN khuyenmai.km 
                        ELSE 0 
                    END AS km,
                    khuyenmai.Masach AS km_masach 
                FROM giohang 
                JOIN giosanpham ON giohang.magh = giosanpham.magh 
                JOIN sach ON sach.Masach = giosanpham.Masach 
                LEFT JOIN khuyenmai ON sach.Masach = khuyenmai.Masach
                WHERE giohang.MaKH = @userName
                  AND giosanpham.Masach IN ({masachParams})";

                var parameters = new Dictionary<string, object>
            {
                { "@userName", userName }
            };

                // Thêm các tham số cho mã sách
                for (int i = 0; i < selectedMasach.Count; i++)
                {
                    parameters.Add($"@masach{i}", selectedMasach[i]);
                }

                DataTable cartData = db.DataRead(query, parameters);

                // ... (phần code hiển thị sản phẩm giữ nguyên)
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\AnhSP";

                panelHienThiThongTinSanPham.AutoScroll = true;
                panelHienThiThongTinSanPham.Controls.Clear();

                if (cartData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm trong giỏ hàng!");
                    return;
                }

                int yOffset = 10;

                foreach (DataRow row in cartData.Rows)
                {
                    Panel panelSanPham = CreateSanPhamPanel(row, imagePath, yOffset);
                    panelHienThiThongTinSanPham.Controls.Add(panelSanPham);
                    yOffset += panelSanPham.Height + 10;
                }
                panelHienThiThongTinSanPham.AutoScrollMinSize = new Size(panelHienThiThongTinSanPham.Width, yOffset);

                UpdateTotalItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải giỏ hàng: " + ex.Message);
            }
        }


        // Xử lý sự kiện đặt hàng
        private string GetCurrentNhanVien()
        {
            try
            {
                // Lấy thời gian hiện tại
                DateTime currentTime = DateTime.Now;
                TimeSpan currentTimeOfDay = currentTime.TimeOfDay;
                int currentMonth = currentTime.Month;
                int currentYear = currentTime.Year;

                // Xác định ca làm việc dựa trên thời gian hiện tại
                string query = @"
                        SELECT pc.MaNV
                        FROM PhanCong pc
                        JOIN CaLamViec clv ON pc.MaCa = clv.MaCa
                        WHERE @currentTime BETWEEN clv.GioBatDau AND clv.GioKetThuc
                        AND pc.ThangLamViec = @month
                        AND pc.NamLamViec = @year";

                var parameters = new Dictionary<string, object>
        {
            { "@currentTime", currentTimeOfDay },
            { "@month", currentMonth },
            { "@year", currentYear }
        };

                // Trường hợp đặc biệt cho ca đêm (từ 23:00 đến 06:00)
                if (currentTimeOfDay >= new TimeSpan(23, 0, 0) || currentTimeOfDay < new TimeSpan(6, 0, 0))
                {
                    query = @"
                SELECT pc.MaNV
                FROM PhanCong pc
                JOIN CaLamViec clv ON pc.MaCa = clv.MaCa
                WHERE clv.TenCa = N'Ca Đêm'
                AND pc.ThangLamViec = @month
                AND pc.NamLamViec = @year";
                }

                DataTable result = db.DataRead(query, parameters);
                if (result.Rows.Count > 0)
                {
                    return result.Rows[0]["MaNV"].ToString();
                }

                throw new Exception("Không tìm thấy nhân viên cho ca làm việc hiện tại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
                return null;
            }
        }


        private void buttonDatHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                if (comboBoxPhuongThucTT.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxPhuongThucTT.SelectedItem.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc hàm
                }
                // Begin transaction
                (connection, transaction) = db.BeginTransaction();

                // 1. Lấy mã nhân viên hiện tại
                string maNV = GetCurrentNhanVien();
                if (string.IsNullOrEmpty(maNV))
                {
                    throw new Exception("Không thể xác định nhân viên cho ca làm việc hiện tại.");
                }

                // 2. Lấy tổng tiền từ label và xử lý chuỗi
                string tongTienStr = labelTongThanhToan.Text.Replace(" VND", "").Replace(",", "");
                if (!decimal.TryParse(tongTienStr, out decimal tongTien))
                {
                    throw new Exception("Lỗi khi chuyển đổi tổng tiền.");
                }

                // 3. Thêm vào bảng HoaDonBan và lấy MaHDB mới
                string insertHoaDonQuery = @"
            INSERT INTO HoaDonBan (MaNV, MaKH, Ngayban, TongTien, PhuongThucThanhToan)
            OUTPUT INSERTED.MaHDB
            VALUES (@maNV, @maKH, @ngayBan, @tongTien, @phuongThucTT)";

                var hoaDonParameters = new Dictionary<string, object>
        {
            { "@maNV", maNV },
            { "@maKH", userName },
            { "@ngayBan", DateTime.Now },
            { "@tongTien", tongTien },
            { "@phuongThucTT", comboBoxPhuongThucTT.SelectedItem.ToString() }
        };

                string maHDB = db.ExecuteScalarTransactionQuery(insertHoaDonQuery, hoaDonParameters, connection, transaction)?.ToString();
                if (string.IsNullOrEmpty(maHDB))
                {
                    throw new Exception("Không thể tạo hóa đơn.");
                }

                // 4. Thêm chi tiết hóa đơn và cập nhật tồn kho
                foreach (string maSach in selectedMasach)
                {
                    string getProductInfoQuery = @"
                        SELECT 
                                gsp.soluong AS SoLuongMua, 
                                CASE 
                                    WHEN km.Masach IS NOT NULL 
                                         AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc
                                    THEN km.KM 
                                    ELSE 0 
                                END AS KhuyenMai,
                                s.DonGia AS DonGia, 
                                s.soluong AS TonKho
                            FROM giosanpham gsp
                            JOIN sach s ON s.Masach = gsp.Masach
                            LEFT JOIN khuyenmai km ON km.masach = gsp.Masach
                            JOIN giohang gh ON gh.magh = gsp.magh
                            WHERE gsp.Masach = @maSach AND gh.MaKH = @maKH";
                    var productParameters = new Dictionary<string, object>
            {
                { "@maSach", maSach },
                { "@maKH", userName }
            };

                    DataTable productInfo = db.DataRead(getProductInfoQuery, productParameters);

                    if (productInfo.Rows.Count > 0)
                    {
                        DataRow row = productInfo.Rows[0];
                        int soLuongMua = Convert.ToInt32(row["SoLuongMua"]);
                        int tonKho = Convert.ToInt32(row["TonKho"]);
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);

                        if (soLuongMua > tonKho)
                        {
                            throw new Exception($"Sách có mã {maSach} không đủ số lượng trong kho.");
                        }

                        string insertChiTietQuery = @"
                    INSERT INTO ChiTietHDB (MaHDB, MaSach, SoLuong, KhuyenMai)
                    VALUES (@maHDB, @maSach, @soLuong, @khuyenMai)";

                        var chiTietParameters = new Dictionary<string, object>
                {
                    { "@maHDB", maHDB },
                    { "@maSach", maSach },
                    { "@soLuong", soLuongMua },
                    { "@khuyenMai", row["KhuyenMai"] ?? DBNull.Value }
                };

                        db.ExecuteTransactionQuery(insertChiTietQuery, chiTietParameters, connection, transaction);

                        string updateStockQuery = @"
                    UPDATE Sach 
                    SET SoLuong = SoLuong - @soLuongMua 
                    WHERE MaSach = @maSach";

                        var updateStockParams = new Dictionary<string, object>
                {
                    { "@soLuongMua", soLuongMua },
                    { "@maSach", maSach }
                };

                        db.ExecuteTransactionQuery(updateStockQuery, updateStockParams, connection, transaction);
                    }
                }

                string deleteCartQuery = @"
            DELETE gsp 
            FROM giosanpham gsp
            JOIN giohang gh ON gh.magh = gsp.magh
            WHERE gh.MaKH = @maKH AND gsp.Masach IN (SELECT value FROM STRING_SPLIT(@selectedMasach, ','))";

                var deleteCartParams = new Dictionary<string, object>
        {
            { "@maKH", userName },
            { "@selectedMasach", string.Join(",", selectedMasach) }
        };

                db.ExecuteTransactionQuery(deleteCartQuery, deleteCartParams, connection, transaction);

                transaction.Commit();

                isOrderPlaced = true;
                MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị hộp thoại xác nhận xuất hóa đơn
                var result = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnXuatFile_Click(sender, e); // Gọi hàm xuất hóa đơn
                }

                // Mở HomeView trước
                HomeView homeView = new HomeView(userName); // `userName` là thông tin người dùng hiện tại
                homeView.Show();

                // Đóng tất cả các form khác trừ HomeView
                Form mainForm = Application.OpenForms[0]; // Form chính (nếu có)
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != mainForm && !(form is HomeView)) // Không đóng form chính hoặc HomeView
                    {
                        form.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Lỗi khi đặt hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection?.Close();
            }
        }


        // Hàm tải toàn bộ thông tin khi form được mở
        public void LoadAllInformation()
        {
            LoadThongTinKhachHang();
            LoadThongTinSanPham();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (!isOrderPlaced) // Check if order is placed before exporting
            {
                MessageBox.Show("Vui lòng đặt hàng trước khi xuất hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin khách hàng
            DataTable TTKH = db.DataRead($"SELECT TenKhachHang, GioiTinh, FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, SDT, DiaChi FROM KhachHang WHERE MaKH = '{userName}'");

            string tenkh = "", gioitinh = "", ngaysinh = "", sdt = "", diachi = "";
            if (TTKH.Rows.Count > 0)
            {
                tenkh = TTKH.Rows[0]["TenKhachHang"]?.ToString();
                gioitinh = TTKH.Rows[0]["GioiTinh"]?.ToString();
                ngaysinh = TTKH.Rows[0]["NgaySinh"]?.ToString();
                sdt = TTKH.Rows[0]["SDT"]?.ToString();
                diachi = TTKH.Rows[0]["DiaChi"]?.ToString();
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Hóa Đơn");

                // Thêm tiêu đề
                worksheet.Cell("A1").Value = "CỦA HÀNG BÁN SÁCH _ MINH QUAN";
                worksheet.Range("A1:E1").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontSize(15)
                    .Font.SetFontColor(XLColor.Blue)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                worksheet.Cell("A2").Value = "Minh Quan";
                worksheet.Range("A2:E2").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontSize(15)
                    .Font.SetFontColor(XLColor.Blue)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                worksheet.Cell("A4").Value = "Hóa đơn đặt hàng";
                worksheet.Range("A4:E4").Merge().Style
                    .Font.SetBold(true)
                    .Font.SetFontColor(XLColor.Red)
                    .Font.SetFontSize(14)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                // Thêm thông tin khách hàng
                worksheet.Cell("A6").Value = "Họ Tên:";
                worksheet.Cell("B6").Value = tenkh;
                worksheet.Cell("D6").Value = "Giới Tính:";
                worksheet.Cell("E6").Value = gioitinh;

                worksheet.Cell("A7").Value = "Ngày Sinh:";
                worksheet.Cell("B7").Value = ngaysinh;
                worksheet.Cell("D7").Value = "SĐT:";
                worksheet.Cell("E7").Value = sdt;
                worksheet.Cell("A8").Value = "Địa Chỉ:";
                worksheet.Cell("B8").Value = diachi;
                worksheet.Range("B8:E8").Merge();

                // Thêm ngày bán
                worksheet.Cell("A9").Value = "Ngày Bán:";
                worksheet.Cell("B9").Value = DateTime.Now.ToString("dd/MM/yyyy");

                // Thêm tiêu đề bảng hóa đơn
                worksheet.Cell("A11").Value = "STT";
                worksheet.Cell("B11").Value = "Tên sách";
                worksheet.Cell("C11").Value = "Số lượng"; // Thêm cột số lượng
                worksheet.Cell("D11").Value = "Giá bán"; // Điều chỉnh các cột
                worksheet.Cell("E11").Value = "Tổng tiền";

                var headerRange = worksheet.Range("A11:E11"); // Điều chỉnh lại phạm vi
                headerRange.Style
                    .Font.SetBold(true)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Fill.SetBackgroundColor(XLColor.LightGray);

                // Thêm dữ liệu từ giỏ hàng
                int row = 12; // Bắt đầu từ dòng 12
                decimal totalAmount = 0;

                foreach (string maSach in selectedMasach)
                {
                    // Lấy thông tin chi tiết sản phẩm bao gồm giá khuyến mãi
                    string query = @"
                            SELECT 
                                s.TenSach,
                                s.DonGia AS DonGia,
                                COALESCE(km.KM, 0) AS KhuyenMai,
                                (1 * s.DonGia * (1 - COALESCE(km.KM, 0) / 100)) AS TongTien
                            FROM Sach s
                            LEFT JOIN KhuyenMai km ON km.MaSach = s.MaSach AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc
                            WHERE s.MaSach = @maSach";

                    var parameters = new Dictionary<string, object>
            {
                { "@maSach", maSach }
            };

                    DataTable productData = db.DataRead(query, parameters);
                    if (productData.Rows.Count > 0)
                    {
                        DataRow rowData = productData.Rows[0];
                        decimal discountPrice = Convert.ToDecimal(rowData["DonGia"]) * (1 - Convert.ToDecimal(rowData["KhuyenMai"]) / 100);
                        worksheet.Cell(row, 1).Value = row - 11; // STT
                        worksheet.Cell(row, 2).Value = rowData["TenSach"].ToString(); // Tên sách
                        worksheet.Cell(row, 3).Value = 1; // Số lượng mặc định là 1
                        worksheet.Cell(row, 4).Value = discountPrice.ToString("N0") + " VNĐ"; // Giá (đã khuyến mãi)
                        worksheet.Cell(row, 5).Value = Convert.ToDecimal(rowData["TongTien"]).ToString("N0") + " VNĐ"; // Tổng tiền
                        totalAmount += Convert.ToDecimal(rowData["TongTien"]); // Cộng dồn tổng tiền
                        row++;
                    }
                }

                // Thêm hàng tổng cộng
                worksheet.Cell(row, 4).Value = "Tổng cộng:"; // Điều chỉnh cột
                worksheet.Cell(row, 5).Value = totalAmount.ToString("N0") + " VNĐ"; // Tổng cộng

                // Kiểm tra và lưu file Excel với tên mới nếu file đã tồn tại
                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Lưu file hóa đơn",
                    Filter = "Excel Files|*.xlsx",
                    FileName = "HoaDon.xlsx"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {

            HomeView homeView = new HomeView(userName);
            homeView.Show();

            // Đóng tất cả các form khác trừ HomeView và form chính
            Form mainForm = Application.OpenForms[0]; // Form chính (nếu có)
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != mainForm && !(form is HomeView)) // Không đóng form chính hoặc HomeView
                {
                    form.Close();
                }
            }

        }
    }
}