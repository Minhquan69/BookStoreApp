using BookStoreApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookStoreApp.ViewNguoiMua;

namespace BookStoreApp.ViewNguoiMua
{
    public partial class HomeView : Form
    {
        // **1. Field Declarations**
        DataBaseProcess db = new DataBaseProcess();
        private bool isTheLoaiLoaded = false;

        private TabPage currentTab;// duyet tab free 
        private int currentPageSanPham = 1;// 
        private int currentPageSachMienPhi = 1;
        private const int rowsPerPage = 2;
        private List<DataRow> allProductsSanPham = new List<DataRow>();
        private List<DataRow> allProductsSachMienPhi = new List<DataRow>();
        private Button btnPreviousSanPham;// <=
        private Button btnNextSanPham; 
        private Label lblPageInfoSanPham;
        private Button btnPreviousSachMienPhi;
        private Button btnNextSachMienPhi;
        private Label lblPageInfoSachMienPhi;
        private List<DataRow> searchResults = new List<DataRow>(); // Kết quả tìm kiếm
        private int currentPageSearch = 1; // Trang hiện tại của kết quả tìm kiếm



        private int currentPageMoiPhatHanh = 1;
        private int currentPageSapPhatHanh = 1;
        private List<DataRow> allProductsMoiPhatHanh = new List<DataRow>();
        private List<DataRow> allProductsSapPhatHanh = new List<DataRow>();
        private Button btnPreviousMoiPhatHanh;
        private Button btnNextMoiPhatHanh;
        private Label lblPageInfoMoiPhatHanh;
        private Button btnPreviousSapPhatHanh;
        private Button btnNextSapPhatHanh;
        private Label lblPageInfoSapPhatHanh;


        private int currentPageSachBanChay = 1;
        private const int rowsPerPageSachBanChay = 2;
        private List<DataRow> allProductsSachBanChay = new List<DataRow>();
        private Label lblPageInfoSachBanChay;
        private Button btnPreviousSachBanChay;
        private Button btnNextSachBanChay;
        private string tenKH = "";
        // **2. Constructor**
        public HomeView(string name)
        {
            InitializeComponent();
            InitializePagingControls();
         //   label1.Text += " " + name;
            tenKH = name;
            tableSanPhams.ColumnCount = 5;
            tableSanPhams.RowCount = 2;
            splitContainer3.SplitterDistance = 65;

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            splitContainer3.IsSplitterFixed = true;
            splitContainer2.IsSplitterFixed = true;
            splitContainer1.IsSplitterFixed = true;
            panel1.Visible = false;
            for (int i = 0; i < tableSanPhams.ColumnCount; i++) tableSanPhams.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161));

            for (int i = 0; i < tableSanPhams.RowCount; i++) tableSanPhams.RowStyles.Add(new RowStyle(SizeType.Absolute, 231));
            tabControl1.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;

            tableSanPhams.Size = new Size(161 * tableSanPhams.ColumnCount, 231 * tableSanPhams.RowCount);
            cbTheloai.DropDown += CbTheloai_DropDown;

            Panel pnlPagingSanPham = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            Panel pnlPagingSapPhatHanh = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            Panel pnlPagingMoiPhatHanh = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            Panel pnlPagingSachBanChay = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            Panel pnlPagingSachMienPhi = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            pnlPagingSanPham.Controls.Add(btnPreviousSanPham);
            pnlPagingSanPham.Controls.Add(lblPageInfoSanPham);
            pnlPagingSanPham.Controls.Add(btnNextSanPham);

            // Thêm controls vào panel phân trang cho Sách miễn phí
            pnlPagingSachMienPhi.Controls.Add(btnPreviousSachMienPhi);
            pnlPagingSachMienPhi.Controls.Add(lblPageInfoSachMienPhi);
            pnlPagingSachMienPhi.Controls.Add(btnNextSachMienPhi);


            pnlPagingSapPhatHanh.Controls.Add(btnPreviousSapPhatHanh);
            pnlPagingSapPhatHanh.Controls.Add(lblPageInfoSapPhatHanh);
            pnlPagingSapPhatHanh.Controls.Add(btnNextSapPhatHanh);


            pnlPagingMoiPhatHanh.Controls.Add(btnPreviousMoiPhatHanh);
            pnlPagingMoiPhatHanh.Controls.Add(lblPageInfoMoiPhatHanh);
            pnlPagingMoiPhatHanh.Controls.Add(btnNextMoiPhatHanh);


            pnlPagingSachBanChay.Controls.Add(btnPreviousSachBanChay);
            pnlPagingSachBanChay.Controls.Add(lblPageInfoSachBanChay);
            pnlPagingSachBanChay.Controls.Add(btnNextSachBanChay);
            // Thêm panels vào tabs tương ứng
            tabSanPham.Controls.Add(pnlPagingSanPham);
            tabSachmienphi.Controls.Add(pnlPagingSachMienPhi);
            tabSapphathanh.Controls.Add(pnlPagingSapPhatHanh);
            tabMoiphathanh.Controls.Add(pnlPagingMoiPhatHanh);
            tabSachbanchay.Controls.Add(pnlPagingSachBanChay);

            // Căn chỉnh vị trí các controls
            ArrangePagingControls(pnlPagingSanPham, btnPreviousSanPham, lblPageInfoSanPham, btnNextSanPham);
            ArrangePagingControls(pnlPagingSachMienPhi, btnPreviousSachMienPhi, lblPageInfoSachMienPhi, btnNextSachMienPhi);
            ArrangePagingControls(pnlPagingMoiPhatHanh, btnPreviousMoiPhatHanh, lblPageInfoMoiPhatHanh, btnNextMoiPhatHanh);
            ArrangePagingControls(pnlPagingSapPhatHanh, btnPreviousSapPhatHanh, lblPageInfoSapPhatHanh, btnNextSapPhatHanh);
            ArrangePagingControls(pnlPagingSachBanChay, btnPreviousSachBanChay, lblPageInfoSachBanChay, btnNextSachBanChay);
        }
        private void ShowPanel1()
        {
            tabControl1.Visible = false;
            panel1.Visible = true;
        }
        private void ShowTabControl()
        {
            panel1.Visible = false;
            tabControl1.Visible = true;
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1090, 676);
            splitContainer2.SplitterDistance = 100;
            tabControl1.SelectedTab = tabSanPham;
            currentTab = tabSanPham;
            LoadCacSanPham();
            LoadSachBanChay();
            LoadTheLoai();
            CenterToScreen();
            LoadUserImage();

        }
        private void CbTheloai_DropDown(object sender, EventArgs e)
        {
            if (!isTheLoaiLoaded)
            {
                LoadTheLoai();
                isTheLoaiLoaded = true;
            }
        }
        private void LoadTheLoai()
        {
            try
            {
                string query = "SELECT TenTheLoai FROM TheLoai";
                DataTable dt = db.DataReader(query);


                cbTheloai.Items.Clear();


                foreach (DataRow row in dt.Rows)
                {
                    cbTheloai.Items.Add(row["TenTheLoai"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thể loại: " + ex.Message);
            }
        }
        // **3. Initialization Methods**
        private void InitializePagingControls()
        {
            // Initialize for Sản phẩm tab
            btnPreviousSanPham = new Button { Text = "Trước", Width = 80, Height = 30, Margin = new Padding(5) };
            btnNextSanPham = new Button { Text = "Sau", Width = 80, Height = 30, Margin = new Padding(5) };
            lblPageInfoSanPham = new Label { AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };

            // Initialize for Sách miễn phí tab
            btnPreviousSachMienPhi = new Button { Text = "Trước", Width = 80, Height = 30, Margin = new Padding(5) };
            btnNextSachMienPhi = new Button { Text = "Sau", Width = 80, Height = 30, Margin = new Padding(5) };
            lblPageInfoSachMienPhi = new Label { AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };


            btnPreviousMoiPhatHanh = new Button { Text = "Trước", Width = 80, Height = 30, Margin = new Padding(5) };
            btnNextMoiPhatHanh = new Button { Text = "Sau", Width = 80, Height = 30, Margin = new Padding(5) };
            lblPageInfoMoiPhatHanh = new Label { AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };

            btnPreviousSapPhatHanh = new Button { Text = "Trước", Width = 80, Height = 30, Margin = new Padding(5) };
            btnNextSapPhatHanh = new Button { Text = "Sau", Width = 80, Height = 30, Margin = new Padding(5) };
            lblPageInfoSapPhatHanh = new Label { AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };

            btnPreviousSachBanChay = new Button { Text = "Trước", Width = 80, Height = 30, Margin = new Padding(5) };
            btnNextSachBanChay = new Button { Text = "Sau", Width = 80, Height = 30, Margin = new Padding(5) };
            lblPageInfoSachBanChay = new Label { AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(5) };


            // Add event handlers
            btnPreviousSanPham.Click += btnPreviousSanPham_Click;
            btnNextSanPham.Click += btnNextSanPham_Click;
            btnPreviousSachMienPhi.Click += btnPreviousSachMienPhi_Click;
            btnNextSachMienPhi.Click += btnNextSachMienPhi_Click;
            btnPreviousMoiPhatHanh.Click += btnPreviousMoiPhatHanh_Click;
            btnNextMoiPhatHanh.Click += btnNextMoiPhatHanh_Click;
            btnPreviousSapPhatHanh.Click += btnPreviousSapPhatHanh_Click;
            btnNextSapPhatHanh.Click += btnNextSapPhatHanh_Click;
            btnPreviousSachBanChay.Click += btnPreviousSachBanChay_Click;
            btnNextSachBanChay.Click += btnNextSachBanChay_Click;
        }



        private void ArrangePagingControls(Panel panel, Button btnPrevious, Label lblInfo, Button btnNext)
        {
            // Set and center controls within the panel
            lblInfo.AutoSize = true;
            lblInfo.MinimumSize = new Size(60, 25);
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;

            int margin = 20;
            int totalWidth = btnPrevious.Width + lblInfo.Width + btnNext.Width + (margin * 2);
            int startX = (panel.Width - totalWidth) / 2;
            // 1/7 
            btnPrevious.Location = new Point(startX, (panel.Height - btnPrevious.Height) / 2);
            lblInfo.Location = new Point(btnPrevious.Right + margin, (panel.Height - lblInfo.Height) / 2);
            btnNext.Location = new Point(lblInfo.Right + margin, (panel.Height - btnNext.Height) / 2);
        }

        public void AddProductPanel(TableLayoutPanel tableSanPhams, string tenfileanh, string label1Text,
                    string label2Text, string masp, bool dangGiamGia, decimal giaGoc)
        {
            TableLayoutPanel innerTable = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 3,
                Size = new Size(170, 240),
                BackColor = Color.AliceBlue,
                Margin = new Padding(10),
            };

            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            innerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

            innerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
            innerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            innerTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            // Ảnh sản phẩm
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightGray,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Margin = new Padding(0),
                Padding = new Padding(0)
            };

            string imagePath = Application.StartupPath + "\\AnhSP\\" + tenfileanh;
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch { /* Không làm gì nếu lỗi ảnh */ }

            innerTable.Controls.Add(pictureBox, 0, 0);
            innerTable.SetColumnSpan(pictureBox, 2);

            // Tên sản phẩm
            Label label1 = new Label
            {
                Text = label1Text,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Bold),
                ForeColor = Color.Black,
                Padding = new Padding(3)
            };
            innerTable.Controls.Add(label1, 0, 1);
            innerTable.SetColumnSpan(label1, 2);

            // Giá sản phẩm
            Label label2 = new Label
            {
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.DarkGreen,
                BackColor = Color.Transparent
            };

            if (dangGiamGia)
            {
                label2.Text = $"{decimal.Parse(label2Text):N0} VND\n(Giảm giá)";
                label2.ForeColor = Color.OrangeRed;
            }
            else
            {
                label2.Text = $"{giaGoc:N0} VND";
            }

            innerTable.Controls.Add(label2, 0, 2);

            // Nút "Mua ngay"
            Label buyNowLabel = new Label
            {
                Text = "Mua ngay",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                BackColor = Color.RoyalBlue,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            buyNowLabel.MouseEnter += (s, e) => buyNowLabel.BackColor = Color.DodgerBlue;
            buyNowLabel.MouseLeave += (s, e) => buyNowLabel.BackColor = Color.RoyalBlue;
            buyNowLabel.Click += (sender, e) => BuyNowLabel_Click(sender, e, label1Text, label2Text, tenfileanh, masp);

            innerTable.Controls.Add(buyNowLabel, 1, 2);

            tableSanPhams.Controls.Add(innerTable);
        }


        private void BuyNowLabel_Click(object sender, EventArgs e, string label1Text, string label2Text, string anh, string masp)
        {

            ShowProductDetails(label1Text, label2Text, anh, masp);
            ShowPanel1();


        }

        private void ShowProductDetails(string label1Text, string label2Text, string anh, string masp)
        {
            var chitietView = new ChiTietSanPhamView(label1Text, label2Text, anh, masp);
            chitietView.OnBackButtonClicked += () =>
            {
                panel1.Controls.Clear();
                panel1.Visible = false;
                ShowTabControl();
                splitContainer3.Panel1Collapsed = false;
            };
            splitContainer3.Panel1Collapsed = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(chitietView);
            chitietView.Dock = DockStyle.Fill;
            panel1.Visible = true;
        }





        // **4. Paging and Display Methods**
        private void DisplayPage(int page, List<DataRow> products, TableLayoutPanel table)
        {
            table.Controls.Clear();
            int startIndex = (page - 1) * rowsPerPage * table.ColumnCount;
            int endIndex = Math.Min(startIndex + rowsPerPage * table.ColumnCount, products.Count);

            if (table == tableSanPhams)
            {
                UpdatePageInfo(page, products, lblPageInfoSanPham, table);
                btnPreviousSanPham.Enabled = page > 1;
                btnNextSanPham.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }
            else if (table == tableSanPhamsSachmienphi)
            {
                UpdatePageInfo(page, products, lblPageInfoSachMienPhi, table);
                btnPreviousSachMienPhi.Enabled = page > 1;
                btnNextSachMienPhi.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }
            else if (table == tableSanPhamsPhathanh)
            {
                UpdatePageInfo(page, products, lblPageInfoMoiPhatHanh, table);
                btnPreviousMoiPhatHanh.Enabled = page > 1;
                btnNextMoiPhatHanh.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }
            else if (table == tableSanPhamsSapphathanh)
            {
                UpdatePageInfo(page, products, lblPageInfoSapPhatHanh, table);
                btnPreviousSapPhatHanh.Enabled = page > 1;
                btnNextSapPhatHanh.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }
            else if (table == tableSachbanchay)
            {
                UpdatePageInfo(page, products, lblPageInfoSachBanChay, table);
                btnPreviousSachBanChay.Enabled = page > 1;
                btnNextSachBanChay.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                var dr = products[i];
                string linksp = dr["Anh"].ToString();
                string tensp = dr["TenSach"].ToString();
                string gia = dr.Table.Columns.Contains("GiaMoi") ? dr["GiaMoi"].ToString() : dr["DonGia"].ToString();
                string masp = dr["MaSach"].ToString();
                bool dangGiamGia = dr.Table.Columns.Contains("DangGiamGia") && Convert.ToInt32(dr["DangGiamGia"]) == 1;
                decimal giaGoc = Convert.ToDecimal(dr["DonGia"]);

                AddProductPanel(table, linksp, tensp, gia, masp, dangGiamGia, giaGoc);
            }
        }
        private void DisplayPageSachBanChay(int page, List<DataRow> products, TableLayoutPanel table)
        {
            table.Controls.Clear();
            int startIndex = (page - 1) * rowsPerPage * table.ColumnCount;
            int endIndex = Math.Min(startIndex + rowsPerPage * table.ColumnCount, products.Count);

            if (table == tableSachbanchay)
            {
                UpdatePageInfo(page, products, lblPageInfoSachBanChay, table);
                btnPreviousSachBanChay.Enabled = page > 1;
                btnNextSachBanChay.Enabled = page < (int)Math.Ceiling((double)products.Count / (rowsPerPage * table.ColumnCount));
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                var dr = products[i];
                string linksp = dr["Anh"].ToString();
                string tensp = dr["TenSach"].ToString();

                // Lấy giá mới nếu tồn tại, nếu không thì dùng giá gốc
                string gia = dr.Table.Columns.Contains("GiaMoi") ? dr["GiaMoi"].ToString() : dr["DonGia"].ToString();

                string masp = dr["MaSach"].ToString();
                bool dangGiamGia = dr.Table.Columns.Contains("DangGiamGia") && Convert.ToInt32(dr["DangGiamGia"]) == 1;

                decimal giaGoc = Convert.ToDecimal(dr["DonGia"]);

                AddProductPanel(table, linksp, tensp, gia, masp, dangGiamGia, giaGoc);
            }
        }


        private void UpdatePageInfo(int currentPage, List<DataRow> allProducts, Label lblPageInfo, TableLayoutPanel table)
        {
            int totalPages = (int)Math.Ceiling((double)allProducts.Count / (rowsPerPage * table.ColumnCount));
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages}";



        }

        // **5. Data Loading Methods**
        private void LoadCacSanPham()
        {
            string query = @"
                        SELECT 
                            s.MaSach,
                            s.TenSach,
                            s.DonGia,
                            ISNULL(km.KM, 0) AS GiamGia,
                            CASE 
                                WHEN km.MaSach IS NOT NULL 
                                AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                                THEN (s.DonGia - (s.DonGia * km.KM / 100))
                                ELSE s.DonGia 
                            END AS GiaMoi,
                            s.Anh,
                            CASE 
                                WHEN km.MaSach IS NOT NULL 
                                AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                                THEN 1 
                                ELSE 0 
                            END AS DangGiamGia
                        FROM Sach s 
                        LEFT JOIN KhuyenMai km ON s.MaSach = km.MaSach";

            string queryMoiPhatHanh = query + @" WHERE s.ThoiGianPhatHanh <= GETDATE() 
                                     AND DATEDIFF(day, s.ThoiGianPhatHanh, GETDATE()) <= 30";

            string querySapPhatHanh = query + @" WHERE s.ThoiGianPhatHanh > GETDATE()";



            DataTable dt = db.DataReader(query);
            allProductsSanPham = dt.AsEnumerable().ToList(); // Lưu toàn bộ dữ liệu
            currentPageSanPham = 1; // Reset trang về 1
            DisplayPage(currentPageSanPham, allProductsSanPham, tableSanPhams);


            DataTable dtMoiPhatHanh = db.DataReader(queryMoiPhatHanh);
            allProductsMoiPhatHanh = dtMoiPhatHanh.AsEnumerable().ToList();

            DataTable dtSapPhatHanh = db.DataReader(querySapPhatHanh);
            allProductsSapPhatHanh = dtSapPhatHanh.AsEnumerable().ToList();

        }
        private void LoadSachBanChay()
        {
            string querySachBanChay = @"
                            SELECT TOP 25
                                Sach.MaSach,
                                Sach.TenSach,
                                Sach.DonGia,
                                Sach.Anh, 
                                A.GiaMoi,
                                A.DangGiamGia,
                                SUM(ChiTietHDB.SoLuong) AS SoLuongBan
                            FROM (
                                SELECT 
                                    Sach.MaSach,
                                    CASE 
                                        WHEN km.MaSach IS NOT NULL 
                                             AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                                        THEN (Sach.DonGia - (Sach.DonGia * km.KM / 100))
                                        ELSE Sach.DonGia 
                                    END AS GiaMoi,
                                    CASE 
                                        WHEN km.MaSach IS NOT NULL 
                                             AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                                        THEN 1 
                                        ELSE 0 
                                    END AS DangGiamGia
                                FROM Sach
                                LEFT JOIN KhuyenMai km ON km.MaSach = Sach.MaSach
                            ) A
                            JOIN Sach ON A.MaSach = Sach.MaSach
                            JOIN ChiTietHDB ON Sach.MaSach = ChiTietHDB.MaSach
                            GROUP BY Sach.MaSach, Sach.TenSach, Sach.DonGia, Sach.Anh, A.GiaMoi, A.DangGiamGia
                            ORDER BY SUM(ChiTietHDB.SoLuong) DESC"
                ;



            currentPageSanPham = 1;
            DisplayPageSachBanChay(currentPageSanPham, allProductsSanPham, tableSanPhams);

            DataTable dtSachBanChay = db.DataReader(querySachBanChay);
            allProductsSachBanChay = dtSachBanChay.AsEnumerable().ToList();
        }
        private void LoadSachMienPhi()
        {
            try
            {

                string query = @"
                    SELECT 
                        s.MaSach,
                        s.TenSach,
                        s.DonGia,
                        s.Anh
                    FROM Sach s
                    WHERE s.DonGia = 0";

                DataTable dt = db.DataReader(query);
                allProductsSachMienPhi = dt.AsEnumerable().ToList();
                currentPageSachMienPhi = 1;
                DisplayPage(currentPageSachMienPhi, allProductsSachMienPhi, tableSanPhamsSachmienphi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sách miễn phí: {ex.Message}");
            }
        }

        // **6. Event Handlers**
        private void btnNextSanPham_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allProductsSanPham.Count / (rowsPerPage * tableSanPhams.ColumnCount));
            if (currentPageSanPham < totalPages)
            {
                currentPageSanPham++;
                DisplayPage(currentPageSanPham, allProductsSanPham, tableSanPhams);
            }
        }

        private void btnPreviousSanPham_Click(object sender, EventArgs e)
        {

            if (currentPageSanPham > 1)
            {
                currentPageSanPham--;
                DisplayPage(currentPageSanPham, allProductsSanPham, tableSanPhams);
            }
        }
        private void btnNextMoiPhatHanh_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allProductsMoiPhatHanh.Count / (rowsPerPage * tableSanPhamsPhathanh.ColumnCount));
            if (currentPageMoiPhatHanh < totalPages)
            {
                currentPageMoiPhatHanh++;
                DisplayPage(currentPageMoiPhatHanh, allProductsMoiPhatHanh, tableSanPhamsPhathanh);
            }
        }

        private void btnPreviousMoiPhatHanh_Click(object sender, EventArgs e)
        {
            if (currentPageMoiPhatHanh > 1)
            {
                currentPageMoiPhatHanh--;
                DisplayPage(currentPageMoiPhatHanh, allProductsMoiPhatHanh, tableSanPhamsPhathanh);
            }
        }
        private void btnNextSapPhatHanh_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allProductsSapPhatHanh.Count / (rowsPerPage * tableSanPhamsSapphathanh.ColumnCount));
            if (currentPageSapPhatHanh < totalPages)
            {
                currentPageSapPhatHanh++;
                DisplayPage(currentPageSapPhatHanh, allProductsSapPhatHanh, tableSanPhamsSapphathanh);
            }
        }

        private void btnPreviousSapPhatHanh_Click(object sender, EventArgs e)
        {

            if (currentPageSapPhatHanh > 1)
            {
                currentPageSapPhatHanh--;
                DisplayPage(currentPageSapPhatHanh, allProductsSapPhatHanh, tableSanPhamsSapphathanh);
            }
        }
        private void btnNextSachBanChay_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allProductsSachBanChay.Count / (rowsPerPage * tableSachbanchay.ColumnCount));
            if (currentPageSachBanChay < totalPages)
            {
                currentPageSachBanChay++;
                DisplayPageSachBanChay(currentPageSachBanChay, allProductsSachBanChay, tableSachbanchay);
            }
        }

        private void btnPreviousSachBanChay_Click(object sender, EventArgs e)
        {
            if (currentPageSachBanChay > 1)
            {
                currentPageSachBanChay--;
                DisplayPageSachBanChay(currentPageSachBanChay, allProductsSachBanChay, tableSachbanchay);
            }
        }
        private void btnNextSachMienPhi_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allProductsSachMienPhi.Count / (rowsPerPage * tableSanPhamsSachmienphi.ColumnCount));
            if (currentPageSachMienPhi < totalPages)
            {
                currentPageSachMienPhi++;
                DisplayPage(currentPageSachMienPhi, allProductsSachMienPhi, tableSanPhamsSachmienphi);
            }
        }

        private void btnPreviousSachMienPhi_Click(object sender, EventArgs e)
        {
            if (currentPageSachMienPhi > 1)
            {
                currentPageSachMienPhi--;
                DisplayPage(currentPageSachMienPhi, allProductsSachMienPhi, tableSanPhamsSachmienphi);
            }
        }

        // **7. Search Methods**
        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string tenSach = txtTensanpham.Text.Trim();
            string tacGia = txtTentacgia.Text.Trim();
            string theLoai = cbTheloai.SelectedItem?.ToString();
            string giaTu = txtGiatu.Text.Trim();
            string giaDen = txtGiaden.Text.Trim();
            string trangThaiGiamGia = cbTrangthaigiamgia.SelectedItem?.ToString();
            string nhaXuatBan = txtNXB.Text.Trim();
            StringBuilder queryBuilder = new StringBuilder();

            if (currentTab == tabSanPham || currentTab == tabMoiphathanh || currentTab == tabSapphathanh)
            {
                queryBuilder.Append(@"
                SELECT s.MaSach, s.TenSach, s.DonGia,
                  ISNULL(km.KM, 0) AS GiamGia, (s.DonGia - (s.DonGia * ISNULL(km.KM, 0) / 100)) as GiaMoi, s.Anh,
                  CASE 
                      WHEN km.MaSach IS NOT NULL AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                      THEN 1 
                      ELSE 0 
                  END AS DangGiamGia, nxb.TenNXB
              FROM Sach s 
              LEFT JOIN KhuyenMai km ON s.MaSach = km.MaSach
              LEFT JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB 
              WHERE 1=1 ");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND s.TenSach LIKE N'%{tenSach}%'");
                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND s.TacGia LIKE N'%{tacGia}%'");
                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND s.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}')");
                if (!string.IsNullOrEmpty(giaTu) && decimal.TryParse(giaTu, out decimal giaMin))
                    queryBuilder.Append($" AND (s.DonGia - (s.DonGia * ISNULL(km.KM, 0) / 100)) >= {giaMin}");
                if (!string.IsNullOrEmpty(giaDen) && decimal.TryParse(giaDen, out decimal giaMax))
                    queryBuilder.Append($" AND (s.DonGia - (s.DonGia * ISNULL(km.KM, 0) / 100)) <= {giaMax}");
                if (!string.IsNullOrEmpty(trangThaiGiamGia))
                {
                    if (trangThaiGiamGia == "Đang giảm giá")
                    {
                        queryBuilder.Append(@" AND km.MaSach IS NOT NULL 
                                     AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc");
                    }
                    else if (trangThaiGiamGia == "Không giảm giá")
                    {
                        queryBuilder.Append(@" AND (km.MaSach IS NULL 
                                     OR GETDATE() NOT BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc)");
                    }
                }
                if (!string.IsNullOrEmpty(nhaXuatBan))
                    queryBuilder.Append($" AND nxb.TenNXB LIKE N'%{nhaXuatBan}%'");


                if (currentTab == tabMoiphathanh)
                {
                    queryBuilder.Append(@" AND s.ThoiGianPhatHanh <= GETDATE() 
                                 AND DATEDIFF(day, s.ThoiGianPhatHanh, GETDATE()) <= 30"); // Sách phát hành trong 30 ngày gần đây
                }
                else if (currentTab == tabSapphathanh)
                {
                    queryBuilder.Append(@" AND s.ThoiGianPhatHanh > GETDATE()"); // Sách có ngày phát hành trong tương lai
                }
            }
            else if (currentTab == tabSachmienphi)
            {
                queryBuilder.Append(@"
            SELECT 
                s.MaSach,
                s.TenSach,
                s.DonGia,
                s.Anh,
                nxb.TenNXB
            FROM Sach s
             LEFT JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB 
            WHERE s.DonGia = 0");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND s.TenSach LIKE N'%{tenSach}%'");
                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND s.TacGia LIKE N'%{tacGia}%'");
                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND s.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}')");
                if (!string.IsNullOrEmpty(nhaXuatBan))
                    queryBuilder.Append($" AND nxb.TenNXB LIKE N'%{nhaXuatBan}%'");
            }
            if (currentTab == tabSachbanchay)
            {
                queryBuilder.Append(@"
        SELECT TOP 25
            Sach.MaSach, Sach.TenSach, Sach.DonGia, Sach.Anh, 
            A.GiaMoi, SUM(ChiTietHDB.SoLuong) AS SoLuongBan 
        FROM 
            (SELECT 
                Sach.MaSach, 
                CASE 
                    WHEN km.MaSach IS NOT NULL 
                    AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                    THEN (Sach.DonGia - (Sach.DonGia * km.KM / 100))
                    ELSE Sach.DonGia 
                END AS GiaMoi
            FROM Sach 
            LEFT JOIN KhuyenMai km ON km.MaSach = Sach.MaSach) A 
        JOIN Sach ON A.MaSach = Sach.MaSach
        JOIN ChiTietHDB ON Sach.MaSach = ChiTietHDB.MaSach
        WHERE 1=1 ");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND Sach.TenSach LIKE N'%{tenSach}%'");

                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND Sach.TacGia LIKE N'%{tacGia}%'");

                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND Sach.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}')     ");

                if (!string.IsNullOrEmpty(giaTu) && decimal.TryParse(giaTu, out decimal giaMin))
                    queryBuilder.Append($" AND A.GiaMoi >= {giaMin}");

                if (!string.IsNullOrEmpty(giaDen) && decimal.TryParse(giaDen, out decimal giaMax))
                    queryBuilder.Append($" AND A.GiaMoi <= {giaMax}");

                queryBuilder.Append(@"
        GROUP BY Sach.MaSach, Sach.TenSach, Sach.DonGia, Sach.Anh, A.GiaMoi
        ORDER BY SUM(ChiTietHDB.SoLuong) DESC");
            }


            DataTable dt = db.DataReader(queryBuilder.ToString());
            searchResults = dt.AsEnumerable().ToList();
            currentPageSearch = 1;


            if (currentTab == tabSanPham)
                DisplayPage(currentPageSearch, searchResults, tableSanPhams);
            else if (currentTab == tabSachmienphi)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsSachmienphi);
            else if (currentTab == tabMoiphathanh)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsPhathanh);
            else if (currentTab == tabSapphathanh)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsSapphathanh);
            else if (currentTab == tabSachbanchay)
                DisplayPageSachBanChay(currentPageSearch, searchResults, tableSachbanchay);
        }


        private void LoadKetQuaTimKiem(string query, TableLayoutPanel tableToLoad)
        {
            try
            {
                DataTable dt = db.DataReader(query);
                searchResults = dt.AsEnumerable().ToList(); // Lưu kết quả tìm kiếm
                currentPageSearch = 1; // Reset trang hiện tại về 1

                // Hiển thị trang đầu tiên của kết quả tìm kiếm
                DisplayPage(currentPageSearch, searchResults, tableToLoad);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải kết quả tìm kiếm: {ex.Message}");
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void tabSanPham_Click(object sender, EventArgs e)
        {
            tabSanPham.AutoScroll = true;
            this.AutoScroll = true;

        }
        private void tabSachmienphi_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTab = tabControl1.SelectedTab;
            if (currentTab == tabSachmienphi)
            {
                txtGiatu.Enabled = false;
                txtGiaden.Enabled = false;
                cbTrangthaigiamgia.Enabled = false;

            }
            else if (currentTab == tabSanPham || currentTab == tabMoiphathanh || currentTab == tabSapphathanh || currentTab == tabSachbanchay)
            {
                txtGiatu.Enabled = true;
                txtGiaden.Enabled = true;
                cbTrangthaigiamgia.Enabled = true;
            }


            if (currentTab == tabSanPham)
            {
                if (allProductsSanPham.Count == 0)
                    LoadCacSanPham();
                else
                    DisplayPage(currentPageSanPham, allProductsSanPham, tableSanPhams);
            }
            else if (currentTab == tabSachmienphi)
            {
                if (allProductsSachMienPhi.Count == 0)
                    LoadSachMienPhi();
                else
                    DisplayPage(currentPageSachMienPhi, allProductsSachMienPhi, tableSanPhamsSachmienphi);
            }
            else if (currentTab == tabMoiphathanh)
            {
                if (allProductsMoiPhatHanh.Count == 0)
                    LoadCacSanPham();
                else
                    DisplayPage(currentPageMoiPhatHanh, allProductsMoiPhatHanh, tableSanPhamsPhathanh);
            }
            else if (currentTab == tabSapphathanh)
            {
                if (allProductsSapPhatHanh.Count == 0)
                    LoadCacSanPham();
                else
                    DisplayPage(currentPageSapPhatHanh, allProductsSapPhatHanh, tableSanPhamsSapphathanh);
            }
            else if (currentTab == tabSachbanchay)
            {
                if (allProductsSachBanChay.Count == 0)
                    LoadSachBanChay();
                else
                    DisplayPageSachBanChay(currentPageSachBanChay, allProductsSachBanChay, tableSachbanchay);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserImage()
        {
            try
            {
                string currentUser = Program.currentUser.MaUser;

                string tenfileanh = GetUserImageFileName(currentUser);

                string imagePath = System.Windows.Forms.Application.StartupPath + "\\AnhKhachHang\\" + tenfileanh;

                if (File.Exists(imagePath))
                {
                    pictureBox3.Image = Image.FromFile(imagePath);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\AnhKhachHang\\" + "avatar.png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
            }
        }

        private string GetUserImageFileName(string userId)
        {
            string fileName = "";

            string query = $"SELECT Anh FROM KhachHang WHERE MaKH = '{userId}'";
            DataTable dt = db.DataReader(query);

            if (dt.Rows.Count > 0)
            {
                fileName = dt.Rows[0]["Anh"].ToString();
            }

            return fileName;
        }

        private void btTimkiem1_Click(object sender, EventArgs e)
        {

            string tenSach = txtTensanpham.Text.Trim();
            string tacGia = txtTentacgia.Text.Trim();
            string theLoai = cbTheloai.SelectedItem?.ToString();
            string giaTu = txtGiatu.Text.Trim();
            string giaDen = txtGiaden.Text.Trim();
            string trangThaiGiamGia = cbTrangthaigiamgia.SelectedItem?.ToString();
            string nhaXuatBan = txtNXB.Text.Trim();
            StringBuilder queryBuilder = new StringBuilder();

            if (currentTab == tabSanPham || currentTab == tabMoiphathanh || currentTab == tabSapphathanh)
            {
                queryBuilder.Append(@"
                               SELECT 
                          s.MaSach,
                          s.TenSach,
                          s.DonGia,
                          ISNULL(km.KM, 0) AS GiamGia,
                          CASE 
                              WHEN km.MaSach IS NOT NULL 
                              AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                              THEN (s.DonGia - (s.DonGia * km.KM / 100))
                              ELSE s.DonGia 
                          END AS GiaMoi,
                          s.Anh,
                          CASE 
                              WHEN km.MaSach IS NOT NULL 
                              AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc 
                              THEN 1 
                              ELSE 0 
                          END AS DangGiamGia, nxb.TenNXB
                      FROM Sach s 
                      LEFT JOIN KhuyenMai km ON s.MaSach = km.MaSach
                      LEFT JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB 
                      WHERE 1=1 ");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND s.TenSach LIKE N'%{tenSach}%'");
                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND s.TacGia LIKE N'%{tacGia}%'");
                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND s.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}')");
                if (!string.IsNullOrEmpty(giaTu) && decimal.TryParse(giaTu, out decimal giaMin))
                    queryBuilder.Append($" AND (s.DonGia - (s.DonGia * km.KM / 100)) >= {giaMin}");
                if (!string.IsNullOrEmpty(giaDen) && decimal.TryParse(giaDen, out decimal giaMax))
                    queryBuilder.Append($" AND (s.DonGia - (s.DonGia * km.KM / 100)) <= {giaMax}");
                if (!string.IsNullOrEmpty(trangThaiGiamGia))
                {
                    if (trangThaiGiamGia == "Đang giảm giá")
                    {
                        queryBuilder.Append(@" AND km.MaSach IS NOT NULL 
                                     AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc");
                    }
                    else if (trangThaiGiamGia == "Không giảm giá")
                    {
                        queryBuilder.Append(@" AND (km.MaSach IS NULL 
                                     OR GETDATE() NOT BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc)");
                    }
                }
                if (!string.IsNullOrEmpty(nhaXuatBan))
                    queryBuilder.Append($" AND nxb.TenNXB LIKE N'%{nhaXuatBan}%'");


                if (currentTab == tabMoiphathanh)
                {
                    queryBuilder.Append(@" AND s.ThoiGianPhatHanh <= GETDATE() 
                                 AND DATEDIFF(day, s.ThoiGianPhatHanh, GETDATE()) <= 30"); // Sách phát hành trong 30 ngày gần đây
                }
                else if (currentTab == tabSapphathanh)
                {
                    queryBuilder.Append(@" AND s.ThoiGianPhatHanh > GETDATE()"); // Sách có ngày phát hành trong tương lai
                }
            }
            else if (currentTab == tabSachmienphi)
            {
                queryBuilder.Append(@"
            SELECT 
                s.MaSach,
                s.TenSach,
                s.DonGia,
                s.Anh,
                nxb.TenNXB
            FROM Sach s
             LEFT JOIN NhaXuatBan nxb ON s.MaNXB = nxb.MaNXB 
            WHERE s.DonGia = 0");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND s.TenSach LIKE N'%{tenSach}%'");
                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND s.TacGia LIKE N'%{tacGia}%'");
                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND s.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}')");
                if (!string.IsNullOrEmpty(nhaXuatBan))
                    queryBuilder.Append($" AND nxb.TenNXB LIKE N'%{nhaXuatBan}%'");
            }
            if (currentTab == tabSachbanchay)
            {
                queryBuilder.Append(@"
                                              SELECT top 25
                         Sach.MaSach, Sach.TenSach, Sach.DonGia, Sach.Anh, 
                         A.GiaMoi,SUM(ChiTietHDB.SoLuong) AS SoLuongBan 
                    From (select Sach.MaSach,km.ThoigianBatDau, km.ThoiGianKetThuc, CASE 
                             WHEN km.MaSach IS NOT NULL AND GETDATE() BETWEEN km.ThoigianBatDau AND km.ThoiGianKetThuc THEN (Sach.DonGia - (Sach.DonGia * km.KM / 100))
			                    ELSE Sach.DonGia 
		                    END AS GiaMoi
		                    from Sach join KhuyenMai km on km.MaSach = Sach.MaSach) A 
                    join Sach on A.MaSach = Sach.MaSach
                    JOIN ChiTietHDB ON Sach.MaSach = ChiTietHDB.MaSach
                    join NhaXuatBan on Sach.MaNXB = NhaXuatBan.MaNXB 
where 1=1
                            ");

                if (!string.IsNullOrEmpty(tenSach))
                    queryBuilder.Append($" AND Sach.TenSach LIKE N'%{tenSach}%'");

                if (!string.IsNullOrEmpty(tacGia))
                    queryBuilder.Append($" AND Sach.TacGia LIKE N'%{tacGia}%'");

                if (!string.IsNullOrEmpty(theLoai))
                    queryBuilder.Append($" AND Sach.MaTheLoai IN (SELECT MaTheLoai FROM TheLoai WHERE TenTheLoai = N'{theLoai}') ");

                if (!string.IsNullOrEmpty(giaTu) && decimal.TryParse(giaTu, out decimal giaMin))
                    queryBuilder.Append($" AND A.GiaMoi >= {giaMin}");

                if (!string.IsNullOrEmpty(giaDen) && decimal.TryParse(giaDen, out decimal giaMax))
                    queryBuilder.Append($" AND A.GiaMoi <= {giaMax}");

                if (!string.IsNullOrEmpty(trangThaiGiamGia))
                {

                    if (trangThaiGiamGia == "Đang giảm giá")
                        queryBuilder.Append(@"  and GETDATE() BETWEEN A.ThoigianBatDau AND A.ThoiGianKetThuc ");
                    else if (trangThaiGiamGia == "Không giảm giá")
                        queryBuilder.Append(@" and GETDATE() not BETWEEN A.ThoigianBatDau AND A.ThoiGianKetThuc  ");
                }
                if (!string.IsNullOrEmpty(nhaXuatBan))
                    queryBuilder.Append($" AND NhaXuatBan.TenNXB LIKE N'%{nhaXuatBan}%'");
                queryBuilder.Append(@"
                     GROUP BY Sach.MaSach, Sach.TenSach, Sach.DonGia, Sach.Anh, 
                                             A.GiaMoi
                     ORDER BY SUM(ChiTietHDB.SoLuong) DESC");
            }

            DataTable dt = db.DataReader(queryBuilder.ToString());
            searchResults = dt.AsEnumerable().ToList();
            currentPageSearch = 1;


            if (currentTab == tabSanPham)
                DisplayPage(currentPageSearch, searchResults, tableSanPhams);
            else if (currentTab == tabSachmienphi)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsSachmienphi);
            else if (currentTab == tabMoiphathanh)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsPhathanh);
            else if (currentTab == tabSapphathanh)
                DisplayPage(currentPageSearch, searchResults, tableSanPhamsSapphathanh);
            else if (currentTab == tabSachbanchay)
                DisplayPageSachBanChay(currentPageSearch, searchResults, tableSachbanchay);
        }


        private void btLichsumua_Click(object sender, EventArgs e)
        {

            string currentUser = Program.currentUser.MaUser;
            string tenkh = GetUserName(currentUser);

            if (string.IsNullOrEmpty(tenkh))
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowProductDetails_lichsumua(tenkh);
            ShowPanel1();
        }

        private void ShowProductDetails_lichsumua(string tenkh)
        {
            


        }


        private string GetUserName(string userId)
        {
            string query = $"SELECT TenKhachHang FROM KhachHang WHERE MaKH = '{userId}'";
            DataTable dt = db.DataReader(query);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenKhachHang"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên khách hàng cho mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void btThongtinKH_Click(object sender, EventArgs e)
        {
            string currentUser = Program.currentUser.MaUser;
            string tenkh = GetUserName(currentUser);

            if (string.IsNullOrEmpty(tenkh))
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowProductDetails_thongtinkh(tenkh);
            ShowPanel1();

        }

        private void ShowProductDetails_thongtinkh(string tenkh1)
        {
            
        }


        private void ShowProductDetails_giohang()
        {
            var giohang = new GioHangView();

            giohang.OnBackButtonClicked += () =>
            {
                panel1.Controls.Clear();
                panel1.Visible = false;
                ShowTabControl();
                splitContainer3.Panel1Collapsed = false;
            };
            splitContainer3.Panel1Collapsed = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(giohang);
            giohang.Dock = DockStyle.Fill;
            panel1.Visible = true;
            giohang.Show();
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            ShowProductDetails_giohang();
            ShowPanel1();
        }

        private void txtGiatu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void txtTensanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void txtTentacgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void txtNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

        }

        private void cbTheloai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = true;

        }

        private void cbTrangthaigiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) e.Handled = true;

        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1090, 676);
            splitContainer2.SplitterDistance = 100;
            tabControl1.SelectedTab = tabSanPham;
            currentTab = tabSanPham;
            LoadCacSanPham();
            LoadSachBanChay();
            LoadTheLoai();
            CenterToScreen();
            LoadUserImage();
            panel1.Controls.Clear();
            panel1.Visible = false;
            ShowTabControl();
            splitContainer3.Panel1Collapsed = false;
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Sign.SignIn signInForm = new Sign.SignIn();
            signInForm.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtTensanpham.Clear();
            txtTentacgia.Clear();
            txtGiatu.Clear();
            txtGiaden.Clear();
            txtNXB.Clear();
            cbTheloai.SelectedIndex = -1;
            cbTrangthaigiamgia.SelectedIndex = -1;
        }

        

    }
}
