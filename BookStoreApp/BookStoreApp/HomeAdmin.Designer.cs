using System.Windows.Forms;

namespace BookStoreApp
{
    partial class HomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.tabStat = new System.Windows.Forms.TabPage();
            this.tblThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.denNgay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tuNgay = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.btnStatResult = new System.Windows.Forms.Button();
            this.comboStat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTGKT = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimePickerTGBD = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTenSach = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearchDiscount = new System.Windows.Forms.Button();
            this.txtSearchDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSearchDiscount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaKM = new System.Windows.Forms.Button();
            this.btnSuaKM = new System.Windows.Forms.Button();
            this.btnRefreshDiscount = new System.Windows.Forms.Button();
            this.btnAddNewDiscount = new System.Windows.Forms.Button();
            this.tblKhuyenMai = new System.Windows.Forms.DataGridView();
            this.NameDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.label_phanTrang = new System.Windows.Forms.Label();
            this.btnNextt = new System.Windows.Forms.Button();
            this.btnPree = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnAnhKH = new System.Windows.Forms.Button();
            this.pictureBoxKH = new System.Windows.Forms.PictureBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btbBoLoc = new System.Windows.Forms.Button();
            this.radioSortCustomerByBirthDate = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerByName = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerById = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnRefreshCustomer = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.tblKhachHang = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblCustomerRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.labelPhanTrang = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.txtFileXemThu = new System.Windows.Forms.TextBox();
            this.btnFileXemThu = new System.Windows.Forms.Button();
            this.txtFileSach = new System.Windows.Forms.TextBox();
            this.btnFileSach = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxPhanLoai = new System.Windows.Forms.ComboBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAnh = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tblDuLieu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocPhanLoai = new System.Windows.Forms.ComboBox();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.numericItemTo = new System.Windows.Forms.NumericUpDown();
            this.numericItemFrom = new System.Windows.Forms.NumericUpDown();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSearchItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.radioSortItemByTonKho = new System.Windows.Forms.RadioButton();
            this.radioSortItemByName = new System.Windows.Forms.RadioButton();
            this.radioSortItemByPriceDESC = new System.Windows.Forms.RadioButton();
            this.radioSortItemByPriceASC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnFreshItem = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnIn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LoaiBieuDoCB = new System.Windows.Forms.ComboBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tblBaoCao = new System.Windows.Forms.DataGridView();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.denNgayPicker = new System.Windows.Forms.DateTimePicker();
            this.label40 = new System.Windows.Forms.Label();
            this.TuNgayPicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblThongKe)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhuyenMai)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHang)).BeginInit();
            this.tabItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuLieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCao)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.tblThongKe);
            this.tabStat.Controls.Add(this.groupBox11);
            this.tabStat.Location = new System.Drawing.Point(4, 26);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat.Size = new System.Drawing.Size(927, 672);
            this.tabStat.TabIndex = 4;
            this.tabStat.Text = "Thống Kê";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // tblThongKe
            // 
            this.tblThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblThongKe.BackgroundColor = System.Drawing.Color.White;
            this.tblThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblThongKe.DefaultCellStyle = dataGridViewCellStyle1;
            this.tblThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblThongKe.Location = new System.Drawing.Point(3, 181);
            this.tblThongKe.Name = "tblThongKe";
            this.tblThongKe.RowHeadersWidth = 51;
            this.tblThongKe.RowTemplate.Height = 40;
            this.tblThongKe.Size = new System.Drawing.Size(921, 488);
            this.tblThongKe.TabIndex = 15;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkBoxTime);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.denNgay);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.tuNgay);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.btnStatResult);
            this.groupBox11.Controls.Add(this.comboStat);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(1, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(930, 150);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Thống kê theo tiêu chí";
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTime.Location = new System.Drawing.Point(517, 98);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(194, 23);
            this.checkBoxTime.TabIndex = 13;
            this.checkBoxTime.Text = "Không áp dụng thời gian";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(738, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lưu file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // denNgay
            // 
            this.denNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.denNgay.Location = new System.Drawing.Point(363, 95);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(124, 26);
            this.denNgay.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(291, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Đến ngày";
            // 
            // tuNgay
            // 
            this.tuNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(141, 95);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(124, 26);
            this.tuNgay.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(74, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 19);
            this.label28.TabIndex = 8;
            this.label28.Text = "Từ ngày";
            // 
            // btnStatResult
            // 
            this.btnStatResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatResult.Location = new System.Drawing.Point(738, 31);
            this.btnStatResult.Name = "btnStatResult";
            this.btnStatResult.Size = new System.Drawing.Size(112, 38);
            this.btnStatResult.TabIndex = 7;
            this.btnStatResult.Text = "Thống kê";
            this.btnStatResult.UseVisualStyleBackColor = true;
            // 
            // comboStat
            // 
            this.comboStat.FormattingEnabled = true;
            this.comboStat.Items.AddRange(new object[] {
            "Các sách có danh thu tốt nhất",
            "Các sách có nhiều lượt mua nhất",
            "Các khách hàng mua nhiều hàng nhất",
            "Các khách hàng chi nhiều tiền nhất",
            "Doanh thu theo từng tháng ",
            "Danh thu theo từng ngày",
            "Danh thu theo từng năm"});
            this.comboStat.Location = new System.Drawing.Point(138, 40);
            this.comboStat.Name = "comboStat";
            this.comboStat.Size = new System.Drawing.Size(521, 26);
            this.comboStat.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tiêu chí";
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.groupBox13);
            this.tabDiscount.Controls.Add(this.groupBox7);
            this.tabDiscount.Controls.Add(this.groupBox9);
            this.tabDiscount.Controls.Add(this.tblKhuyenMai);
            this.tabDiscount.Location = new System.Drawing.Point(4, 26);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(927, 672);
            this.tabDiscount.TabIndex = 2;
            this.tabDiscount.Text = "QL Khuyến Mãi ";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.dateTimePickerTGKT);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.dateTimePickerTGBD);
            this.groupBox13.Controls.Add(this.comboBoxTenSach);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.txtKM);
            this.groupBox13.Controls.Add(this.label31);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Location = new System.Drawing.Point(1, 315);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(924, 122);
            this.groupBox13.TabIndex = 12;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Thông tin chung";
            // 
            // dateTimePickerTGKT
            // 
            this.dateTimePickerTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTGKT.Location = new System.Drawing.Point(753, 55);
            this.dateTimePickerTGKT.Name = "dateTimePickerTGKT";
            this.dateTimePickerTGKT.Size = new System.Drawing.Size(115, 25);
            this.dateTimePickerTGKT.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(558, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 17);
            this.label29.TabIndex = 28;
            this.label29.Text = "Thời gian kết thúc";
            // 
            // dateTimePickerTGBD
            // 
            this.dateTimePickerTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTGBD.Location = new System.Drawing.Point(184, 55);
            this.dateTimePickerTGBD.Name = "dateTimePickerTGBD";
            this.dateTimePickerTGBD.Size = new System.Drawing.Size(115, 25);
            this.dateTimePickerTGBD.TabIndex = 27;
            // 
            // comboBoxTenSach
            // 
            this.comboBoxTenSach.FormattingEnabled = true;
            this.comboBoxTenSach.Location = new System.Drawing.Point(184, 23);
            this.comboBoxTenSach.Name = "comboBoxTenSach";
            this.comboBoxTenSach.Size = new System.Drawing.Size(207, 25);
            this.comboBoxTenSach.TabIndex = 24;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(819, 24);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 17);
            this.label37.TabIndex = 23;
            this.label37.Text = "%";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(24, 61);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(111, 17);
            this.label34.TabIndex = 19;
            this.label34.Text = "Thời gian bắt đầu";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(753, 23);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(51, 25);
            this.txtKM.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(558, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(140, 17);
            this.label31.TabIndex = 13;
            this.label31.Text = "Phần trăm khuyến mại";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(24, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "Tên sách";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearchDiscount);
            this.groupBox7.Controls.Add(this.txtSearchDiscount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.comboSearchDiscount);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(485, 423);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(445, 198);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm kiếm";
            // 
            // btnSearchDiscount
            // 
            this.btnSearchDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDiscount.Location = new System.Drawing.Point(144, 132);
            this.btnSearchDiscount.Name = "btnSearchDiscount";
            this.btnSearchDiscount.Size = new System.Drawing.Size(131, 41);
            this.btnSearchDiscount.TabIndex = 6;
            this.btnSearchDiscount.Text = "Tìm kiếm";
            this.btnSearchDiscount.UseVisualStyleBackColor = true;
            // 
            // txtSearchDiscount
            // 
            this.txtSearchDiscount.Location = new System.Drawing.Point(144, 85);
            this.txtSearchDiscount.Name = "txtSearchDiscount";
            this.txtSearchDiscount.Size = new System.Drawing.Size(240, 25);
            this.txtSearchDiscount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nội dung";
            // 
            // comboSearchDiscount
            // 
            this.comboSearchDiscount.FormattingEnabled = true;
            this.comboSearchDiscount.Items.AddRange(new object[] {
            "Sách trong thời gian khuyến mãi",
            "",
            "Sách hết thời gian khuyến mãi"});
            this.comboSearchDiscount.Location = new System.Drawing.Point(144, 47);
            this.comboSearchDiscount.Name = "comboSearchDiscount";
            this.comboSearchDiscount.Size = new System.Drawing.Size(240, 25);
            this.comboSearchDiscount.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiêu chí";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnLuu);
            this.groupBox9.Controls.Add(this.btnXoaKM);
            this.groupBox9.Controls.Add(this.btnSuaKM);
            this.groupBox9.Controls.Add(this.btnRefreshDiscount);
            this.groupBox9.Controls.Add(this.btnAddNewDiscount);
            this.groupBox9.Location = new System.Drawing.Point(7, 423);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(476, 198);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hành động";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(140, 145);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 42);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoaKM
            // 
            this.btnXoaKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKM.Location = new System.Drawing.Point(262, 47);
            this.btnXoaKM.Name = "btnXoaKM";
            this.btnXoaKM.Size = new System.Drawing.Size(185, 42);
            this.btnXoaKM.TabIndex = 5;
            this.btnXoaKM.Text = "Xoá";
            this.btnXoaKM.UseVisualStyleBackColor = true;
            // 
            // btnSuaKM
            // 
            this.btnSuaKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKM.Location = new System.Drawing.Point(35, 47);
            this.btnSuaKM.Name = "btnSuaKM";
            this.btnSuaKM.Size = new System.Drawing.Size(183, 42);
            this.btnSuaKM.TabIndex = 4;
            this.btnSuaKM.Text = "Sửa";
            this.btnSuaKM.UseVisualStyleBackColor = true;
            // 
            // btnRefreshDiscount
            // 
            this.btnRefreshDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshDiscount.Location = new System.Drawing.Point(262, 97);
            this.btnRefreshDiscount.Name = "btnRefreshDiscount";
            this.btnRefreshDiscount.Size = new System.Drawing.Size(185, 42);
            this.btnRefreshDiscount.TabIndex = 1;
            this.btnRefreshDiscount.Text = "Làm mới";
            this.btnRefreshDiscount.UseVisualStyleBackColor = true;
            // 
            // btnAddNewDiscount
            // 
            this.btnAddNewDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewDiscount.Location = new System.Drawing.Point(33, 97);
            this.btnAddNewDiscount.Name = "btnAddNewDiscount";
            this.btnAddNewDiscount.Size = new System.Drawing.Size(185, 42);
            this.btnAddNewDiscount.TabIndex = 0;
            this.btnAddNewDiscount.Text = "Thêm mới";
            this.btnAddNewDiscount.UseVisualStyleBackColor = true;
            // 
            // tblKhuyenMai
            // 
            this.tblKhuyenMai.AllowUserToAddRows = false;
            this.tblKhuyenMai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblKhuyenMai.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDiscount,
            this.StartTime,
            this.EndTime,
            this.DiscountPercent});
            this.tblKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKhuyenMai.Location = new System.Drawing.Point(3, 3);
            this.tblKhuyenMai.Name = "tblKhuyenMai";
            this.tblKhuyenMai.ReadOnly = true;
            this.tblKhuyenMai.RowHeadersWidth = 51;
            this.tblKhuyenMai.RowTemplate.Height = 24;
            this.tblKhuyenMai.Size = new System.Drawing.Size(921, 666);
            this.tblKhuyenMai.TabIndex = 8;
            // 
            // NameDiscount
            // 
            this.NameDiscount.HeaderText = "Tên KM";
            this.NameDiscount.MinimumWidth = 6;
            this.NameDiscount.Name = "NameDiscount";
            this.NameDiscount.ReadOnly = true;
            this.NameDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "TG bắt đầu";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "TG kết thúc";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "% KM";
            this.DiscountPercent.MinimumWidth = 6;
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.ReadOnly = true;
            this.DiscountPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.label_phanTrang);
            this.tabCustomer.Controls.Add(this.btnNextt);
            this.tabCustomer.Controls.Add(this.btnPree);
            this.tabCustomer.Controls.Add(this.groupBox12);
            this.tabCustomer.Controls.Add(this.groupBox4);
            this.tabCustomer.Controls.Add(this.groupBox5);
            this.tabCustomer.Controls.Add(this.groupBox6);
            this.tabCustomer.Controls.Add(this.tblKhachHang);
            this.tabCustomer.Location = new System.Drawing.Point(4, 26);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(927, 672);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "QL Khách Hàng";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // label_phanTrang
            // 
            this.label_phanTrang.AutoSize = true;
            this.label_phanTrang.Location = new System.Drawing.Point(414, 323);
            this.label_phanTrang.Name = "label_phanTrang";
            this.label_phanTrang.Size = new System.Drawing.Size(26, 17);
            this.label_phanTrang.TabIndex = 11;
            this.label_phanTrang.Text = "0/0";
            // 
            // btnNextt
            // 
            this.btnNextt.Location = new System.Drawing.Point(505, 319);
            this.btnNextt.Name = "btnNextt";
            this.btnNextt.Size = new System.Drawing.Size(75, 23);
            this.btnNextt.TabIndex = 10;
            this.btnNextt.Text = "Trang sau";
            this.btnNextt.UseVisualStyleBackColor = true;
            // 
            // btnPree
            // 
            this.btnPree.Location = new System.Drawing.Point(302, 319);
            this.btnPree.Name = "btnPree";
            this.btnPree.Size = new System.Drawing.Size(75, 23);
            this.btnPree.TabIndex = 9;
            this.btnPree.Text = "Trang trước";
            this.btnPree.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnAnhKH);
            this.groupBox12.Controls.Add(this.pictureBoxKH);
            this.groupBox12.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox12.Controls.Add(this.btnHienMatKhau);
            this.groupBox12.Controls.Add(this.txtMatKhau);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.comboBoxGioiTinh);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.txtDiaChiKH);
            this.groupBox12.Controls.Add(this.label25);
            this.groupBox12.Controls.Add(this.txtSDTKH);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.txtTenKH);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.txtMaKH);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Location = new System.Drawing.Point(2, 339);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(923, 157);
            this.groupBox12.TabIndex = 8;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chung";
            // 
            // btnAnhKH
            // 
            this.btnAnhKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnhKH.Location = new System.Drawing.Point(814, 123);
            this.btnAnhKH.Name = "btnAnhKH";
            this.btnAnhKH.Size = new System.Drawing.Size(80, 33);
            this.btnAnhKH.TabIndex = 27;
            this.btnAnhKH.Text = "Ảnh";
            this.btnAnhKH.UseVisualStyleBackColor = true;
            // 
            // pictureBoxKH
            // 
            this.pictureBoxKH.Location = new System.Drawing.Point(793, 10);
            this.pictureBoxKH.Name = "pictureBoxKH";
            this.pictureBoxKH.Size = new System.Drawing.Size(116, 111);
            this.pictureBoxKH.TabIndex = 26;
            this.pictureBoxKH.TabStop = false;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(367, 60);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(106, 26);
            this.dateTimePickerNgaySinh.TabIndex = 25;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienMatKhau.Location = new System.Drawing.Point(704, 90);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(65, 23);
            this.btnHienMatKhau.TabIndex = 24;
            this.btnHienMatKhau.Text = "Hiển thị";
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(556, 91);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(142, 26);
            this.txtMatKhau.TabIndex = 23;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(556, 64);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 19);
            this.label38.TabIndex = 22;
            this.label38.Text = "Mật khẩu";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(367, 95);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(106, 27);
            this.comboBoxGioiTinh.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(289, 98);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 19);
            this.label27.TabIndex = 17;
            this.label27.Text = "Giới tính";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(289, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 19);
            this.label26.TabIndex = 15;
            this.label26.Text = "Ngày sinh";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(367, 19);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(167, 26);
            this.txtDiaChiKH.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(289, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 19);
            this.label25.TabIndex = 13;
            this.label25.Text = "Địa chỉ";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(120, 90);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(134, 26);
            this.txtSDTKH.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 19);
            this.label24.TabIndex = 11;
            this.label24.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(120, 54);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(134, 26);
            this.txtTenKH.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 19);
            this.label23.TabIndex = 9;
            this.label23.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(120, 19);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(68, 26);
            this.txtMaKH.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 19);
            this.label22.TabIndex = 7;
            this.label22.Text = "Mã khách hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchCustomer);
            this.groupBox4.Controls.Add(this.txtSearchCustomer);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboSearchCustomer);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(646, 496);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 153);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(88, 97);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(131, 41);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(88, 68);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(180, 26);
            this.txtSearchCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nội dung";
            // 
            // comboSearchCustomer
            // 
            this.comboSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchCustomer.FormattingEnabled = true;
            this.comboSearchCustomer.Items.AddRange(new object[] {
            "Tên khách hàng gần đúng",
            "Mã khách hàng",
            "Địa chỉ",
            "Số điện thoại"});
            this.comboSearchCustomer.Location = new System.Drawing.Point(88, 30);
            this.comboSearchCustomer.Name = "comboSearchCustomer";
            this.comboSearchCustomer.Size = new System.Drawing.Size(180, 27);
            this.comboSearchCustomer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiêu chí";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btbBoLoc);
            this.groupBox5.Controls.Add(this.radioSortCustomerByBirthDate);
            this.groupBox5.Controls.Add(this.radioSortCustomerByName);
            this.groupBox5.Controls.Add(this.radioSortCustomerById);
            this.groupBox5.Location = new System.Drawing.Point(302, 496);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 153);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sắp xếp theo";
            // 
            // btbBoLoc
            // 
            this.btbBoLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBoLoc.Location = new System.Drawing.Point(240, 52);
            this.btbBoLoc.Name = "btbBoLoc";
            this.btbBoLoc.Size = new System.Drawing.Size(75, 23);
            this.btbBoLoc.TabIndex = 3;
            this.btbBoLoc.Text = "Bỏ lọc";
            this.btbBoLoc.UseVisualStyleBackColor = true;
            // 
            // radioSortCustomerByBirthDate
            // 
            this.radioSortCustomerByBirthDate.AutoSize = true;
            this.radioSortCustomerByBirthDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerByBirthDate.Location = new System.Drawing.Point(28, 102);
            this.radioSortCustomerByBirthDate.Name = "radioSortCustomerByBirthDate";
            this.radioSortCustomerByBirthDate.Size = new System.Drawing.Size(156, 23);
            this.radioSortCustomerByBirthDate.TabIndex = 2;
            this.radioSortCustomerByBirthDate.TabStop = true;
            this.radioSortCustomerByBirthDate.Text = "Ngày sinh tăng dần";
            this.radioSortCustomerByBirthDate.UseVisualStyleBackColor = true;
            // 
            // radioSortCustomerByName
            // 
            this.radioSortCustomerByName.AutoSize = true;
            this.radioSortCustomerByName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerByName.Location = new System.Drawing.Point(28, 66);
            this.radioSortCustomerByName.Name = "radioSortCustomerByName";
            this.radioSortCustomerByName.Size = new System.Drawing.Size(192, 23);
            this.radioSortCustomerByName.TabIndex = 1;
            this.radioSortCustomerByName.TabStop = true;
            this.radioSortCustomerByName.Text = "Tên khách hàng tăng dần";
            this.radioSortCustomerByName.UseVisualStyleBackColor = true;
            // 
            // radioSortCustomerById
            // 
            this.radioSortCustomerById.AutoSize = true;
            this.radioSortCustomerById.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerById.Location = new System.Drawing.Point(28, 31);
            this.radioSortCustomerById.Name = "radioSortCustomerById";
            this.radioSortCustomerById.Size = new System.Drawing.Size(189, 23);
            this.radioSortCustomerById.TabIndex = 0;
            this.radioSortCustomerById.TabStop = true;
            this.radioSortCustomerById.Text = "Mã khách hàng tăng dần";
            this.radioSortCustomerById.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnXoaKH);
            this.groupBox6.Controls.Add(this.btnSuaKH);
            this.groupBox6.Controls.Add(this.btnRefreshCustomer);
            this.groupBox6.Controls.Add(this.btnAddNewCustomer);
            this.groupBox6.Location = new System.Drawing.Point(0, 496);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 153);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hành động";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKH.Location = new System.Drawing.Point(155, 25);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(131, 35);
            this.btnXoaKH.TabIndex = 5;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKH.Location = new System.Drawing.Point(18, 25);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(131, 35);
            this.btnSuaKH.TabIndex = 4;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCustomer.Location = new System.Drawing.Point(155, 71);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(131, 35);
            this.btnRefreshCustomer.TabIndex = 1;
            this.btnRefreshCustomer.Text = "Làm mới";
            this.btnRefreshCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnAddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(18, 71);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(131, 35);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Thêm mới";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // tblKhachHang
            // 
            this.tblKhachHang.AllowUserToAddRows = false;
            this.tblKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.FullName,
            this.BirthDate,
            this.Address,
            this.PhoneNumber,
            this.CustomerType,
            this.Point,
            this.CreateTime,
            this.Email,
            this.tblCustomerEdit,
            this.tblCustomerRemove});
            this.tblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKhachHang.Location = new System.Drawing.Point(3, 3);
            this.tblKhachHang.Name = "tblKhachHang";
            this.tblKhachHang.ReadOnly = true;
            this.tblKhachHang.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblKhachHang.RowTemplate.Height = 24;
            this.tblKhachHang.ShowCellToolTips = false;
            this.tblKhachHang.Size = new System.Drawing.Size(921, 666);
            this.tblKhachHang.TabIndex = 4;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Ma KH";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ tên KH";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Ngày sinh";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Số ĐT";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerType
            // 
            this.CustomerType.HeaderText = "Loại KH";
            this.CustomerType.MinimumWidth = 6;
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Point
            // 
            this.Point.HeaderText = "Điểm TL";
            this.Point.MinimumWidth = 6;
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTime
            // 
            this.CreateTime.HeaderText = "Ngày tạo TK";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblCustomerEdit
            // 
            this.tblCustomerEdit.HeaderText = "Sửa";
            this.tblCustomerEdit.MinimumWidth = 6;
            this.tblCustomerEdit.Name = "tblCustomerEdit";
            this.tblCustomerEdit.ReadOnly = true;
            this.tblCustomerEdit.Text = "Sửa";
            this.tblCustomerEdit.UseColumnTextForButtonValue = true;
            // 
            // tblCustomerRemove
            // 
            this.tblCustomerRemove.HeaderText = "Xóa";
            this.tblCustomerRemove.MinimumWidth = 6;
            this.tblCustomerRemove.Name = "tblCustomerRemove";
            this.tblCustomerRemove.ReadOnly = true;
            this.tblCustomerRemove.Text = "Xóa";
            this.tblCustomerRemove.UseColumnTextForButtonValue = true;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.labelPhanTrang);
            this.tabItem.Controls.Add(this.btnNext);
            this.tabItem.Controls.Add(this.btnPrevious);
            this.tabItem.Controls.Add(this.comboBoxNXB);
            this.tabItem.Controls.Add(this.txtFileXemThu);
            this.tabItem.Controls.Add(this.btnFileXemThu);
            this.tabItem.Controls.Add(this.txtFileSach);
            this.tabItem.Controls.Add(this.btnFileSach);
            this.tabItem.Controls.Add(this.txtMoTa);
            this.tabItem.Controls.Add(this.label13);
            this.tabItem.Controls.Add(this.comboBoxPhanLoai);
            this.tabItem.Controls.Add(this.txtSoTrang);
            this.tabItem.Controls.Add(this.label21);
            this.tabItem.Controls.Add(this.btnAnh);
            this.tabItem.Controls.Add(this.picAnh);
            this.tabItem.Controls.Add(this.label20);
            this.tabItem.Controls.Add(this.txtGia);
            this.tabItem.Controls.Add(this.label19);
            this.tabItem.Controls.Add(this.label18);
            this.tabItem.Controls.Add(this.txtTenSach);
            this.tabItem.Controls.Add(this.label17);
            this.tabItem.Controls.Add(this.txtTenTG);
            this.tabItem.Controls.Add(this.label16);
            this.tabItem.Controls.Add(this.txtMaSach);
            this.tabItem.Controls.Add(this.label15);
            this.tabItem.Controls.Add(this.tblDuLieu);
            this.tabItem.Controls.Add(this.groupBox3);
            this.tabItem.Controls.Add(this.groupBox2);
            this.tabItem.Controls.Add(this.groupBox1);
            this.tabItem.Location = new System.Drawing.Point(4, 26);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(927, 672);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "QL Mặt Hàng";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // labelPhanTrang
            // 
            this.labelPhanTrang.AutoSize = true;
            this.labelPhanTrang.Location = new System.Drawing.Point(443, 307);
            this.labelPhanTrang.Name = "labelPhanTrang";
            this.labelPhanTrang.Size = new System.Drawing.Size(49, 17);
            this.labelPhanTrang.TabIndex = 31;
            this.labelPhanTrang.Text = "label35";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(514, 304);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 21);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(336, 304);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 21);
            this.btnPrevious.TabIndex = 29;
            this.btnPrevious.Text = "Pre";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(305, 348);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(209, 27);
            this.comboBoxNXB.TabIndex = 28;
            // 
            // txtFileXemThu
            // 
            this.txtFileXemThu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileXemThu.Location = new System.Drawing.Point(551, 431);
            this.txtFileXemThu.Name = "txtFileXemThu";
            this.txtFileXemThu.Size = new System.Drawing.Size(203, 26);
            this.txtFileXemThu.TabIndex = 27;
            // 
            // btnFileXemThu
            // 
            this.btnFileXemThu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileXemThu.Location = new System.Drawing.Point(551, 407);
            this.btnFileXemThu.Name = "btnFileXemThu";
            this.btnFileXemThu.Size = new System.Drawing.Size(113, 23);
            this.btnFileXemThu.TabIndex = 26;
            this.btnFileXemThu.Text = "File xem thử";
            this.btnFileXemThu.UseVisualStyleBackColor = true;
            // 
            // txtFileSach
            // 
            this.txtFileSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileSach.Location = new System.Drawing.Point(551, 366);
            this.txtFileSach.Name = "txtFileSach";
            this.txtFileSach.Size = new System.Drawing.Size(203, 26);
            this.txtFileSach.TabIndex = 25;
            // 
            // btnFileSach
            // 
            this.btnFileSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileSach.Location = new System.Drawing.Point(551, 340);
            this.btnFileSach.Name = "btnFileSach";
            this.btnFileSach.Size = new System.Drawing.Size(113, 23);
            this.btnFileSach.TabIndex = 24;
            this.btnFileSach.Text = "File sách";
            this.btnFileSach.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(320, 416);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(194, 77);
            this.txtMoTa.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mô tả";
            // 
            // comboBoxPhanLoai
            // 
            this.comboBoxPhanLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhanLoai.FormattingEnabled = true;
            this.comboBoxPhanLoai.Location = new System.Drawing.Point(73, 453);
            this.comboBoxPhanLoai.Name = "comboBoxPhanLoai";
            this.comboBoxPhanLoai.Size = new System.Drawing.Size(170, 27);
            this.comboBoxPhanLoai.TabIndex = 21;
            // txtSoTrang
            // 
            this.txtSoTrang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(320, 381);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(61, 26);
            this.txtSoTrang.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(259, 384);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 19);
            this.label21.TabIndex = 19;
            this.label21.Text = "Số trang";
            // 
            // btnAnh
            // 
            this.btnAnh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.Location = new System.Drawing.Point(825, 435);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 36);
            this.btnAnh.TabIndex = 18;
            this.btnAnh.Text = "Ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(812, 321);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(100, 109);
            this.picAnh.TabIndex = 17;
            this.picAnh.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 456);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 19);
            this.label20.TabIndex = 15;
            this.label20.Text = "Thể loại";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(432, 384);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(82, 26);
            this.txtGia.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(400, 387);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 19);
            this.label19.TabIndex = 13;
            this.label19.Text = "Giá";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(259, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "NXB";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(73, 381);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(170, 26);
            this.txtTenSach.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 384);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 19);
            this.label17.TabIndex = 9;
            this.label17.Text = "Tên sách";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(73, 416);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(170, 26);
            this.txtTenTG.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tên TG";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(73, 344);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(68, 26);
            this.txtMaSach.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Mã sách";
            // 
            // tblDuLieu
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblDuLieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDuLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDuLieu.Location = new System.Drawing.Point(3, 3);
            this.tblDuLieu.Name = "tblDuLieu";
            this.tblDuLieu.ReadOnly = true;
            this.tblDuLieu.RowHeadersWidth = 92;
            this.tblDuLieu.RowTemplate.Height = 37;
            this.tblDuLieu.Size = new System.Drawing.Size(921, 295);
            this.tblDuLieu.TabIndex = 4;
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.LocPhanLoai);
            this.groupBox3.Controls.Add(this.labelTimKiem);
            this.groupBox3.Controls.Add(this.numericItemTo);
            this.groupBox3.Controls.Add(this.numericItemFrom);
            this.groupBox3.Controls.Add(this.btnSearchItem);
            this.groupBox3.Controls.Add(this.txtSearchItem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboSearchItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(529, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 178);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // LocPhanLoai
            // 
            this.LocPhanLoai.Enabled = false;
            this.LocPhanLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocPhanLoai.FormattingEnabled = true;
            this.LocPhanLoai.Items.AddRange(new object[] {
            "Đồ Ăn",
            "Đồ Uống",
            "Snack"});
            this.LocPhanLoai.Location = new System.Drawing.Point(83, 92);
            this.LocPhanLoai.Name = "LocPhanLoai";
            this.LocPhanLoai.Size = new System.Drawing.Size(180, 27);
            this.LocPhanLoai.TabIndex = 10;
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimKiem.Location = new System.Drawing.Point(16, 95);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(72, 19);
            this.labelTimKiem.TabIndex = 9;
            this.labelTimKiem.Text = "Phân loại";
            // 
            // numericItemTo
            // 
            this.numericItemTo.Enabled = false;
            this.numericItemTo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericItemTo.Location = new System.Drawing.Point(317, 95);
            this.numericItemTo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemTo.Name = "numericItemTo";
            this.numericItemTo.Size = new System.Drawing.Size(66, 26);
            this.numericItemTo.TabIndex = 8;
            // 
            // numericItemFrom
            // 
            this.numericItemFrom.Enabled = false;
            this.numericItemFrom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericItemFrom.Location = new System.Drawing.Point(317, 63);
            this.numericItemFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemFrom.Name = "numericItemFrom";
            this.numericItemFrom.Size = new System.Drawing.Size(66, 26);
            this.numericItemFrom.TabIndex = 7;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(83, 122);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(131, 41);
            this.btnSearchItem.TabIndex = 6;
            this.btnSearchItem.Text = "Tìm kiếm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Enabled = false;
            this.txtSearchItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(83, 63);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(180, 26);
            this.txtSearchItem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // comboSearchItem
            // 
            this.comboSearchItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchItem.FormattingEnabled = true;
            this.comboSearchItem.Items.AddRange(new object[] {
            "Tìm theo tên sách",
            "Tìm theo tên tác giả",
            "Tìm theo thể loại",
            "Tìm theo nhà xuất bản",
            "Theo khoảng số lượng ",
            "Tìm theo khoảng giá "});
            this.comboSearchItem.Location = new System.Drawing.Point(83, 25);
            this.comboSearchItem.Name = "comboSearchItem";
            this.comboSearchItem.Size = new System.Drawing.Size(180, 27);
            this.comboSearchItem.TabIndex = 1;// 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnBoLoc);
            this.groupBox2.Controls.Add(this.radioSortItemByTonKho);
            this.groupBox2.Controls.Add(this.radioSortItemByName);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceDESC);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceASC);
            this.groupBox2.Location = new System.Drawing.Point(302, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp theo";
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(30, 137);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(90, 28);
            this.btnBoLoc.TabIndex = 4;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            // 
            // radioSortItemByTonKho
            // 
            this.radioSortItemByTonKho.AutoSize = true;
            this.radioSortItemByTonKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortItemByTonKho.Location = new System.Drawing.Point(30, 68);
            this.radioSortItemByTonKho.Name = "radioSortItemByTonKho";
            this.radioSortItemByTonKho.Size = new System.Drawing.Size(149, 23);
            this.radioSortItemByTonKho.TabIndex = 3;
            this.radioSortItemByTonKho.TabStop = true;
            this.radioSortItemByTonKho.Text = "Tồn kho giảm dần";
            this.radioSortItemByTonKho.UseVisualStyleBackColor = true;
            // 
            // radioSortItemByName
            // 
            this.radioSortItemByName.AutoSize = true;
            this.radioSortItemByName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortItemByName.Location = new System.Drawing.Point(30, 112);
            this.radioSortItemByName.Name = "radioSortItemByName";
            this.radioSortItemByName.Size = new System.Drawing.Size(143, 23);
            this.radioSortItemByName.TabIndex = 2;
            this.radioSortItemByName.TabStop = true;
            this.radioSortItemByName.Text = "Tên mặt hàng a-z";
            this.radioSortItemByName.UseVisualStyleBackColor = true;
            // 
            // radioSortItemByPriceDESC
            // 
            this.radioSortItemByPriceDESC.AutoSize = true;
            this.radioSortItemByPriceDESC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortItemByPriceDESC.Location = new System.Drawing.Point(30, 90);
            this.radioSortItemByPriceDESC.Name = "radioSortItemByPriceDESC";
            this.radioSortItemByPriceDESC.Size = new System.Drawing.Size(184, 23);
            this.radioSortItemByPriceDESC.TabIndex = 1;
            this.radioSortItemByPriceDESC.TabStop = true;
            this.radioSortItemByPriceDESC.Text = "Giá niêm yếu giảm dần";
            this.radioSortItemByPriceDESC.UseVisualStyleBackColor = true;
            // 
            // radioSortItemByPriceASC
            // 
            this.radioSortItemByPriceASC.AutoSize = true;
            this.radioSortItemByPriceASC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortItemByPriceASC.Location = new System.Drawing.Point(30, 47);
            this.radioSortItemByPriceASC.Name = "radioSortItemByPriceASC";
            this.radioSortItemByPriceASC.Size = new System.Drawing.Size(176, 23);
            this.radioSortItemByPriceASC.TabIndex = 0;
            this.radioSortItemByPriceASC.TabStop = true;
            this.radioSortItemByPriceASC.Text = "Giá niêm yết tăng dần";
            this.radioSortItemByPriceASC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Controls.Add(this.btnFreshItem);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Location = new System.Drawing.Point(2, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(148, 43);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(131, 35);
            this.btnXoaSP.TabIndex = 3;
            this.btnXoaSP.Text = "Xoá";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(11, 43);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(131, 35);
            this.btnSuaSP.TabIndex = 2;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnFreshItem
            // 
            this.btnFreshItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreshItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreshItem.Location = new System.Drawing.Point(148, 93);
            this.btnFreshItem.Name = "btnFreshItem";
            this.btnFreshItem.Size = new System.Drawing.Size(131, 35);
            this.btnFreshItem.TabIndex = 1;
            this.btnFreshItem.Text = "Làm mới";
            this.btnFreshItem.UseVisualStyleBackColor = true;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(11, 93);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(131, 35);
            this.btnThemSP.TabIndex = 0;
            this.btnThemSP.Text = "Thêm mới";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabItem);
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabDiscount);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 702);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnIn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.LoaiBieuDoCB);
            this.tabPage1.Controls.Add(this.txtTop);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnTaoBaoCao);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.denNgayPicker);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.TuNgayPicker);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 672);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Báo cáo";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(783, 66);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(123, 40);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "Lưu biểu đồ";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Loại biểu đồ";
            // 
            // LoaiBieuDoCB
            // 
            this.LoaiBieuDoCB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiBieuDoCB.FormattingEnabled = true;
            this.LoaiBieuDoCB.Items.AddRange(new object[] {
            "Cột",
            "Tròn"});
            this.LoaiBieuDoCB.Location = new System.Drawing.Point(292, 76);
            this.LoaiBieuDoCB.Name = "LoaiBieuDoCB";
            this.LoaiBieuDoCB.Size = new System.Drawing.Size(100, 27);
            this.LoaiBieuDoCB.TabIndex = 11;
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTop.Location = new System.Drawing.Point(292, 31);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(100, 26);
            this.txtTop.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Top";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(783, 26);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(123, 31);
            this.btnTaoBaoCao.TabIndex = 8;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 518);
            this.panel1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox14);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox15);
            this.splitContainer1.Size = new System.Drawing.Size(922, 569);
            this.splitContainer1.SplitterDistance = 406;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.White;
            this.groupBox14.Controls.Add(this.tblBaoCao);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(406, 569);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Bảng chi tiết";
            // 
            // tblBaoCao
            // 
            this.tblBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.tblBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBaoCao.Location = new System.Drawing.Point(3, 23);
            this.tblBaoCao.Name = "tblBaoCao";
            this.tblBaoCao.RowHeadersWidth = 51;
            this.tblBaoCao.Size = new System.Drawing.Size(400, 459);
            this.tblBaoCao.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.White;
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(512, 569);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Biểu đồ";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart2.Location = new System.Drawing.Point(6, 22);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Size = new System.Drawing.Size(500, 369);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            legend2.Name = "Legend1";
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Size = new System.Drawing.Size(445, 372);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // denNgayPicker
            // 
            this.denNgayPicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.denNgayPicker.Location = new System.Drawing.Point(624, 31);
            this.denNgayPicker.Name = "denNgayPicker";
            this.denNgayPicker.Size = new System.Drawing.Size(124, 26);
            this.denNgayPicker.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(621, 14);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 19);
            this.label40.TabIndex = 5;
            this.label40.Text = "Đến ngày";
            // 
            // TuNgayPicker
            // 
            this.TuNgayPicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuNgayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TuNgayPicker.Location = new System.Drawing.Point(445, 31);
            this.TuNgayPicker.Name = "TuNgayPicker";
            this.TuNgayPicker.Size = new System.Drawing.Size(124, 26);
            this.TuNgayPicker.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Báo cáo hàng bán chạy",
            "Báo cáo khách hàng theo chi tiêu"});
            this.comboBox1.Location = new System.Drawing.Point(29, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(442, 14);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 19);
            this.label39.TabIndex = 1;
            this.label39.Text = "Từ ngày";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "BÁO CÁO THEO";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(935, 702);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeFrm";
            this.Text = "Quản Lý Bán Hàng";
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblThongKe)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabDiscount.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKhuyenMai)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHang)).EndInit();
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuLieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCao)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private TabPage tabStat;
        private GroupBox groupBox11;
        private Button btnStatResult;
        private ComboBox comboStat;
        private Label label12;
        private TabPage tabDiscount;
        private TabPage tabCustomer;
        private GroupBox groupBox4;
        private Button btnSearchCustomer;
        private TextBox txtSearchCustomer;
        private Label label7;
        private ComboBox comboSearchCustomer;
        private Label label8;
        private GroupBox groupBox5;
        private RadioButton radioSortCustomerByBirthDate;
        private RadioButton radioSortCustomerByName;
        private RadioButton radioSortCustomerById;
        private GroupBox groupBox6;
        private Button btnRefreshCustomer;
        private Button btnAddNewCustomer;
        private DataGridView tblKhachHang;
        private TabPage tabItem;
        private GroupBox groupBox3;
        private NumericUpDown numericItemTo;
        private NumericUpDown numericItemFrom;
        private Button btnSearchItem;
        private TextBox txtSearchItem;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboSearchItem;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioSortItemByTonKho;
        private RadioButton radioSortItemByName;
        private RadioButton radioSortItemByPriceDESC;
        private RadioButton radioSortItemByPriceASC;
        private GroupBox groupBox1;
        private Button btnFreshItem;
        private Button btnThemSP;
        private TabControl tabControl1;
        private DataGridView tblDuLieu;
        private Button btnXoaKH;
        private Button btnSuaKH;
        private Button btnXoaSP;
        private Button btnSuaSP;
        private Label label18;
        private TextBox txtTenSach;
        private Label label17;
        private TextBox txtTenTG;
        private Label label16;
        private TextBox txtMaSach;
        private Label label15;
        private TextBox txtSoTrang;
        private Label label21;
        private Button btnAnh;
        private PictureBox picAnh;
        private Label label20;
        private TextBox txtGia;
        private Label label19;
        private GroupBox groupBox12;
        private Label label27;
        private Label label26;
        private TextBox txtDiaChiKH;
        private Label label25;
        private TextBox txtSDTKH;
        private Label label24;
        private TextBox txtTenKH;
        private Label label23;
        private TextBox txtMaKH;
        private Label label22;
        private ComboBox comboBoxPhanLoai;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBoxGioiTinh;
        private Button btnHienMatKhau;
        private TextBox txtMatKhau;
        private Label label38;
        private DataGridViewTextBoxColumn Customer_ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn Point;
        private DataGridViewTextBoxColumn CreateTime;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn tblCustomerEdit;
        private DataGridViewButtonColumn tblCustomerRemove;
        private ComboBox LocPhanLoai;
        private Label labelTimKiem;
        private TabPage tabPage1;
        private Button btnFileSach;
        private TextBox txtMoTa;
        private Label label13;
        private TextBox txtFileXemThu;
        private Button btnFileXemThu;
        private TextBox txtFileSach;
        private DateTimePicker dateTimePickerNgaySinh;
        private PictureBox pictureBoxKH;
        private Button btbBoLoc;
        private ComboBox comboBoxNXB;
        private Label label14;
        private ComboBox comboBox1;
        private Label label39;
        private DateTimePicker TuNgayPicker;
        private DateTimePicker denNgayPicker;
        private Label label40;
        private Button btnTaoBaoCao;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox14;
        private GroupBox groupBox15;
        private DataGridView tblBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label labelPhanTrang;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnBoLoc;
        private ErrorProvider errorProvider1;
        private Button btnAnhKH;
        private TextBox txtTop;
        private Label label9;
        private Label label10;
        private ComboBox LoaiBieuDoCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button btnIn;
        private DateTimePicker denNgay;
        private Label label11;
        private DateTimePicker tuNgay;
        private Label label28;
        private DataGridView tblThongKe;
        private Button button1;
        private CheckBox checkBoxTime;
        private Label label_phanTrang;
        private Button btnNextt;
        private Button btnPree;
        private GroupBox groupBox13;
        private DateTimePicker dateTimePickerTGBD;
        private ComboBox comboBoxTenSach;
        private Label label37;
        private Label label34;
        private TextBox txtKM;
        private Label label31;
        private Label label30;
        private GroupBox groupBox7;
        private Button btnSearchDiscount;
        private TextBox txtSearchDiscount;
        private Label label5;
        private ComboBox comboSearchDiscount;
        private Label label6;
        private GroupBox groupBox9;
        private Button btnXoaKM;
        private Button btnSuaKM;
        private Button btnRefreshDiscount;
        private Button btnAddNewDiscount;
        private DataGridView tblKhuyenMai;
        private DateTimePicker dateTimePickerTGKT;
        private Label label29;
        private Button btnLuu;
        private DataGridViewTextBoxColumn NameDiscount;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn DiscountPercent;
    }
}