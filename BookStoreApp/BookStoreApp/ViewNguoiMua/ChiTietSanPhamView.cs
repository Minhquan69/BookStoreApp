using BookStoreApp.Classes;
using BookStoreApp.Sign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookStoreApp.ViewNguoiMua
{
    public partial class ChiTietSanPhamView : UserControl
    {
        private Timer blinkTimer; private bool isTextVisible = true;
        private string fileSachPath;
        private string fileXemThuPath; 
        private bool isFreeBook;
        private string name;
        private string userName = SignIn.userName;
        public delegate void OnBackButtonClickedHandler();
        public event OnBackButtonClickedHandler OnBackButtonClicked;

        DataBaseProcess db = new DataBaseProcess();

        string tensp, gia, fileanh, masp;
        public ChiTietSanPhamView(string label1Text, string label2Text, string anh, string masp2)
        {
            InitializeComponent();
            //  FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //panel1.Visible = false;
            tensp = label1Text;
            gia = label2Text;
            fileanh = anh;
            masp = masp2;
            labelTenSP.Text = tensp;
            linkLabel1.Visible = true;
            string imagePath = System.Windows.Forms.Application.StartupPath + "\\AnhSP\\" + fileanh;
            boxAnhSP.Image = Image.FromFile(imagePath);
            boxAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
     
            string query = @"
            SELECT s.*, 
                   tl.TenTheLoai, 
                   nxb.TenNXB,
                   km.KM,
                   km.ThoigianBatDau,
                   km.ThoiGianKetThuc,
                   CASE 
                        WHEN km.MaSach IS NOT NULL 
                        AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                        THEN 1 
                        ELSE 0 
                   END AS DangGiamGia
            FROM Sach s
            LEFT JOIN TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
            LEFT JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB
            LEFT JOIN KhuyenMai km ON s.MaSach = km.MaSach
            WHERE s.MaSach = @MaSach";

            DataTable dt = db.DataReader(query.Replace("@MaSach", $"'{masp}'"));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

            DataRow dataRow = dt.Rows[0];
            bool dangGiamGia = Convert.ToInt32(dataRow["DangGiamGia"]) == 1;
            decimal donGia = Convert.ToDecimal(dataRow["DonGia"]);
            string tacGia = dataRow["TacGia"].ToString();
            string theLoai = dataRow["TenTheLoai"].ToString();
            string nhaXuatBan = dataRow["TenNXB"].ToString();
            string soTrang = dataRow["SoTrang"].ToString();
            decimal giamGia = dataRow["KM"] != DBNull.Value ? Convert.ToDecimal(dataRow["KM"]) : 0;
       
            if (dataRow["GioiThieu"] != DBNull.Value)
            {
                txtMoTaSP.Text = dataRow["GioiThieu"].ToString(); 


                if (txtMoTaSP.GetPreferredSize(txtMoTaSP.ClientSize).Height > txtMoTaSP.ClientSize.Height)
                    txtMoTaSP.ScrollBars = ScrollBars.Vertical;
                else txtMoTaSP.ScrollBars = ScrollBars.None;


                txtMoTaSP.WordWrap = true; 
                txtMoTaSP.ReadOnly = true; 
            }
            else
            {
                txtMoTaSP.Text = "Thông tin giới thiệu không có sẵn."; 
                txtMoTaSP.ScrollBars = ScrollBars.None; 
            }

            if (dataRow["ThoigianBatDau"] != DBNull.Value && dataRow["ThoiGianKetThuc"] != DBNull.Value)
            {
                DateTime thoiGianBatDau = Convert.ToDateTime(dataRow["ThoigianBatDau"]);
                DateTime thoiGianKetThuc = Convert.ToDateTime(dataRow["ThoiGianKetThuc"]);
                DateTime now = DateTime.Now;
                if (now >= thoiGianBatDau && now <= thoiGianKetThuc)
                {
                    decimal giaMoi = donGia - (donGia * giamGia / 100);
                    labelGia.Text = $"{giaMoi:F2} VND";
                    lbGiagoc.Text = $"{donGia:F2} VND";
                    lbGiagoc.Visible = true;

                    lbEnd.Text = $"Đang giảm giá {giamGia}%!";
                    lbEnd.Visible = true;

      
                    if (blinkTimer == null)
                    {
                        blinkTimer = new Timer
                        {
                            Interval = 400 
                        };
                        blinkTimer.Tick += (s, e) =>
                        {
                            isTextVisible = !isTextVisible;
                            lbEnd.Visible = isTextVisible;
                        };
                        blinkTimer.Start();
                    }
                }
                else
                {
        
                    labelGia.Text = $"{donGia:F2} VND"; 
                    lbEnd.Visible = false;
                    lbGiagoc.Visible = false;
                    if (blinkTimer != null)
                    {
                        blinkTimer.Stop(); 
                        blinkTimer.Dispose();
                        blinkTimer = null; 
                    }
                }

            }
            else
            {
                // Trường hợp không có thông tin thời gian khuyến mãi
                labelGia.Text = $"{donGia:F2} VND";
                lbEnd.Visible = false; 
                lbGiagoc.Visible = false;

                if (blinkTimer != null)
                {
                    blinkTimer.Stop();
                    blinkTimer.Dispose();
                    blinkTimer = null;
                }
            }
            DateTime? ngayPhatHanh = null;
            if (dataRow["ThoiGianPhatHanh"] != DBNull.Value)
            {
                ngayPhatHanh = Convert.ToDateTime(dataRow["ThoiGianPhatHanh"]);
            }

            if (ngayPhatHanh.HasValue)
            {
                lbNgayPhatHanh.Text = $"{ngayPhatHanh.Value.ToString("dd/MM/yyyy")}";
            }
            else
            {
                lbNgayPhatHanh.Text = "Ngày phát hành không xác định";
            }

            if (ngayPhatHanh.HasValue)
            {
                DateTime now = DateTime.Now;

                if (ngayPhatHanh.Value.Date >= now.AddDays(-30).Date && ngayPhatHanh.Value.Date <= now.Date)
                {
                    lbthongbao.Text = "NEW!!!";
                    lbthongbao.Visible = true;
                    lbthongbao.Location = new Point(800, 70);
                    picture_pgg.Visible = true;
                    if (blinkTimer == null)
                    {
                        blinkTimer = new Timer
                        {
                            Interval = 400
                        };
                        blinkTimer.Tick += (s, e) =>
                        {
                            isTextVisible = !isTextVisible;
                            lbthongbao.Visible = isTextVisible;
                        };
                        blinkTimer.Start();
                    }
                }
       
                else if (ngayPhatHanh.Value.Date > now.Date)
                {
                    picture_pgg.Visible = true;
                    lbthongbao.Text = "SẮP PHÁT HÀNH!!!";
                    lbthongbao.Location = new Point(740, 77);
                    lbthongbao.Font = new Font("Modern No. 20", 18, FontStyle.Italic);
                    lbthongbao.Visible = true;
                    btnMuaNgay.Enabled = false;
                    btnThem.Enabled = false;
                    if (blinkTimer == null)
                    {
                        blinkTimer = new Timer
                        {
                            Interval = 400
                        };
                        blinkTimer.Tick += (s, e) =>
                        {
                            isTextVisible = !isTextVisible;
                            lbthongbao.Visible = isTextVisible;
                        };
                        blinkTimer.Start();
                    }
                }
                else
                {
                    lbthongbao.Visible = false;
                    picture_pgg.Visible = false;
                }
            }
            else
            {
                lbthongbao.Visible = false;
                picture_pgg.Visible = false;
            }


            labelHangSP.Text = nhaXuatBan;
            labelLoaiSP.Text = theLoai;
            lbSotrang.Text = soTrang;
            lbTacgia.Text = tacGia;

            if (donGia == 0)
            {
                btnThem.Enabled = false;
                btnMuaNgay.Enabled = false;
                isFreeBook = true;
                if (dataRow["FileSach"] != DBNull.Value)
                {
                    fileSachPath = dataRow["FileSach"].ToString();
                    linkLabel1.Text = "Tải sách PDF miễn phí";
                    linkLabel1.Visible = true;
                }
                if (ngayPhatHanh.HasValue && ngayPhatHanh.Value.Date > DateTime.Now.Date)
                {
                    linkLabel1.Text = "Tải bản xem thử";
                    fileXemThuPath = dataRow["FileXemThu"].ToString();
                    linkLabel1.Text = "Tải bản xem thử";
                    linkLabel1.Visible = true;
                }
            }
            else
            {
                isFreeBook = false;
                if (dataRow["FileXemThu"] != DBNull.Value)
                {
                    fileXemThuPath = dataRow["FileXemThu"].ToString();
                    linkLabel1.Text = "Tải bản xem thử";
                    linkLabel1.Visible = true;
                }
            }

            txtMoTaSP.ReadOnly = true;
            txtMoTaSP.TabStop = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            // Truy vấn để lấy mã giỏ hàng của người dùng
            string queryMaGH = "SELECT magh FROM giohang WHERE makh = @manguoidung";
            var parametersMaGH = new Dictionary<string, object>
{
    { "@manguoidung", userName } // Thay thế bằng mã người dùng thực tế
};

            DataTable dtMaGH = db.ExecuteSelectQuery(queryMaGH, parametersMaGH);
            if (dtMaGH.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng không tồn tại", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã giỏ hàng từ kết quả truy vấn
            string magh = dtMaGH.Rows[0]["magh"].ToString();

            // Kiểm tra sản phẩm đã tồn tại trong giỏ hàng chưa
            string queryCheckExist = "SELECT soluong FROM giosanpham WHERE magh = @magh AND masach = @masp";
            var parametersCheckExist = new Dictionary<string, object>
{
    { "@magh", magh },
    { "@masp", masp }
};

            DataTable dtCheckExist = db.ExecuteSelectQuery(queryCheckExist, parametersCheckExist);

            if (dtCheckExist.Rows.Count > 0)
            {
                // Nếu sản phẩm đã tồn tại, thực hiện UPDATE
                MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thực hiện INSERT
                string queryInsert = "INSERT INTO giosanpham (magh, masach, soluong) VALUES (@magh, @masp, @soLuong)";
                var parametersInsert = new Dictionary<string, object>
    {
        { "@magh", magh },
        { "@masp", masp },
        { "@soLuong", 1 }  // Thêm tham số @soLuong và gán giá trị là 1 (hoặc giá trị khác nếu cần)
    };

                int rowsInserted = db.ExecuteUpdateQuery(queryInsert, parametersInsert);
                if (rowsInserted > 0)
                {
                    MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm vào giỏ hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void lblQuaylai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                OnBackButtonClicked?.Invoke();
        }
        private List<string> selectedMasach = new List<string>();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            
            string queryMaGH = "SELECT magh FROM giohang WHERE makh = @manguoidung";
            var parametersMaGH = new Dictionary<string, object>
                    {
                        { "@manguoidung", userName }
                    };

            DataTable dtMaGH = db.ExecuteSelectQuery(queryMaGH, parametersMaGH);


            // Lấy mã giỏ hàng từ kết quả truy vấn
            string magh = dtMaGH.Rows[0]["magh"].ToString();

            // Kiểm tra sản phẩm đã tồn tại trong giỏ hàng chưa
            string queryCheckExist = "SELECT soluong FROM giosanpham WHERE magh = @magh AND masach = @masp";
            var parametersCheckExist = new Dictionary<string, object>
                {
                    { "@magh", magh },
                    { "@masp", masp }
                };

            DataTable dtCheckExist = db.ExecuteSelectQuery(queryCheckExist, parametersCheckExist);

            if (dtCheckExist.Rows.Count > 0)
            {
                // Nếu sản phẩm đã tồn tại, thực hiện UPDATE
                string queryUpdate = "UPDATE giosanpham SET soluong = soluong + 1 WHERE magh = @magh AND masach = @masp";
                var parametersUpdate = new Dictionary<string, object>
                    {
                        { "@magh", magh },
                        { "@masp", masp }
                    };

                int rowsUpdated = db.ExecuteUpdateQuery(queryUpdate, parametersUpdate);

            }
            else
            {
             
                string queryInsert = "INSERT INTO giosanpham (magh, masach, soluong) VALUES (@magh, @masp, @soLuong)";
                var parametersInsert = new Dictionary<string, object>
                    {
                        { "@magh", magh },
                        { "@masp", masp },
                        { "@soLuong", 1 }  
                    };

                int rowsInserted = db.ExecuteUpdateQuery(queryInsert, parametersInsert);

            }
            try
            {
               
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn mua sản phẩm {tensp} ngay bây giờ?",
                    "Xác nhận mua hàng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return; 
                }

                // Tạo danh sách mã sản phẩm cần mua
                List<string> selectedMasach = new List<string> { masp }; // Thêm mã sản phẩm hiện tại vào danh sách
                // Mở form hóa đơn và truyền danh sách mã sách đã chọn
                Form parentForm = this.FindForm(); 
                parentForm?.Close();
                HoaDonView hoaDonView = new HoaDonView(selectedMasach);
                hoaDonView.TopMost = true;
                hoaDonView.Show();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra vấn đề
                MessageBox.Show("Đã xảy ra lỗi khi mua hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

      



        private void linkLabel1_Click(object sender, EventArgs e)
        {
            string fullPath;
            string baseFileName;

            if (isFreeBook)
            {
                fullPath = System.Windows.Forms.Application.StartupPath + "\\pdf\\" + fileSachPath;
                baseFileName = $"{tensp}_Full";
            }
            else
            {
                fullPath = System.Windows.Forms.Application.StartupPath + "\\pdf_teaser\\" + fileXemThuPath;
                baseFileName = $"{tensp}_Preview";
            }

            if (!Directory.Exists("E:"))
            {
                MessageBox.Show("Không tìm thấy ổ đĩa E", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string downloadFolder = "E:";
            if (!Directory.Exists(downloadFolder))
            {
                Directory.CreateDirectory(downloadFolder);
            }

            try
            {
                if (!File.Exists(fullPath))
                {
                    MessageBox.Show("Không tìm thấy file PDF!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileName = $"{baseFileName}.pdf";
                string destinationPath = Path.Combine(downloadFolder, fileName);

                if (File.Exists(destinationPath))
                {
                    DialogResult result = MessageBox.Show(
                        $"File {fileName} đã tồn tại trong ổ F. Bạn có muốn tải thêm bản mới không?",
                        "File đã tồn tại",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        if (MessageBox.Show("Bạn có muốn mở file hiện có không?", "Mở file",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Process.Start(destinationPath);
                        }
                        return;
                    }
                    else
                    {
                        int maxNumber = 0;
                        string searchPattern = $"{baseFileName}(*).pdf";
                        foreach (string file in Directory.GetFiles(downloadFolder, $"{baseFileName}*.pdf"))
                        {
                            string filename = Path.GetFileName(file);
                            if (filename == $"{baseFileName}.pdf") continue;

                            int startIndex = filename.LastIndexOf('(');
                            int endIndex = filename.LastIndexOf(')');
                            if (startIndex != -1 && endIndex != -1)
                            {
                                string numberStr = filename.Substring(startIndex + 1, endIndex - startIndex - 1);
                                if (int.TryParse(numberStr, out int number))
                                {
                                    maxNumber = Math.Max(maxNumber, number);
                                }
                            }
                        }

                        fileName = $"{baseFileName} ({maxNumber + 1}).pdf";
                        destinationPath = Path.Combine(downloadFolder, fileName);
                    }
                }

                File.Copy(fullPath, destinationPath, true);
                if (MessageBox.Show($"Đã tải thành công file {fileName}! Bạn có muốn mở file không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start(destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChiTietSanPhamView_Load(object sender, EventArgs e)
        {
            this.Size = new Size(670, 470);
         //   CenterToScreen();
        }

 

 
    }
}
