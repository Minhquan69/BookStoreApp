using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class HomeFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.tabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.groupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LocPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.numericItemTo = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numericItemFrom = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSearchItem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSearchItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBoLoc = new Guna.UI2.WinForms.Guna2Button();
            this.radioSortItemByTonKho = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSortItemByName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSortItemByPriceDESC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSortItemByPriceASC = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnFreshItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.labelPhanTrang = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxNXB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFileXemThu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFileXemThu = new Guna.UI2.WinForms.Guna2Button();
            this.txtFileSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFileSach = new Guna.UI2.WinForms.Guna2Button();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAnh = new Guna.UI2.WinForms.Guna2Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenTG = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tblDuLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.label_phanTrang = new System.Windows.Forms.Label();
            this.btnNextt = new System.Windows.Forms.Button();
            this.btnPree = new System.Windows.Forms.Button();
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
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnAnhKH = new System.Windows.Forms.Button();
            this.pictureBoxKH = new System.Windows.Forms.PictureBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
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
            this.tabDiscount = new System.Windows.Forms.TabPage();
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
            this.tblKhuyenMai = new System.Windows.Forms.DataGridView();
            this.NameDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tblBaoCao = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.LoaiBieuDoCB = new System.Windows.Forms.ComboBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.denNgayPicker = new System.Windows.Forms.DateTimePicker();
            this.label40 = new System.Windows.Forms.Label();
            this.TuNgayPicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.tabControl1.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuLieu)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHang)).BeginInit();
            this.tabDiscount.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhuyenMai)).BeginInit();
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblThongKe)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabItem);
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabDiscount);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 774);
            this.tabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.tabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.tabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSize = new System.Drawing.Size(140, 50);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.groupBox3);
            this.tabItem.Controls.Add(this.groupBox2);
            this.tabItem.Controls.Add(this.groupBox1);
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
            this.tabItem.Location = new System.Drawing.Point(144, 4);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(1265, 766);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "QL Sản Phẩm";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox3.BorderRadius = 10;
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
            this.groupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.groupBox3.Location = new System.Drawing.Point(656, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 234);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // LocPhanLoai
            // 
            this.LocPhanLoai.AutoRoundedCorners = true;
            this.LocPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.LocPhanLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.LocPhanLoai.BorderRadius = 14;
            this.LocPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LocPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocPhanLoai.Enabled = false;
            this.LocPhanLoai.FocusedColor = System.Drawing.Color.Empty;
            this.LocPhanLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LocPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LocPhanLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.LocPhanLoai.ItemHeight = 25;
            this.LocPhanLoai.Items.AddRange(new object[] {
            "Đồ Ăn",
            "Đồ Uống",
            "Snack"});
            this.LocPhanLoai.Location = new System.Drawing.Point(116, 142);
            this.LocPhanLoai.Name = "LocPhanLoai";
            this.LocPhanLoai.Size = new System.Drawing.Size(278, 31);
            this.LocPhanLoai.TabIndex = 10;
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.labelTimKiem.Location = new System.Drawing.Point(21, 150);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(81, 23);
            this.labelTimKiem.TabIndex = 9;
            this.labelTimKiem.Text = "Phân loại";
            // 
            // numericItemTo
            // 
            this.numericItemTo.AutoRoundedCorners = true;
            this.numericItemTo.BackColor = System.Drawing.Color.Transparent;
            this.numericItemTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numericItemTo.BorderRadius = 14;
            this.numericItemTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericItemTo.Enabled = false;
            this.numericItemTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numericItemTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numericItemTo.Location = new System.Drawing.Point(463, 146);
            this.numericItemTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericItemTo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemTo.Name = "numericItemTo";
            this.numericItemTo.Size = new System.Drawing.Size(66, 30);
            this.numericItemTo.TabIndex = 8;
            // 
            // numericItemFrom
            // 
            this.numericItemFrom.AutoRoundedCorners = true;
            this.numericItemFrom.BackColor = System.Drawing.Color.Transparent;
            this.numericItemFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numericItemFrom.BorderRadius = 14;
            this.numericItemFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericItemFrom.Enabled = false;
            this.numericItemFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numericItemFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numericItemFrom.Location = new System.Drawing.Point(463, 99);
            this.numericItemFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericItemFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemFrom.Name = "numericItemFrom";
            this.numericItemFrom.Size = new System.Drawing.Size(66, 30);
            this.numericItemFrom.TabIndex = 7;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.BorderRadius = 10;
            this.btnSearchItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSearchItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchItem.ForeColor = System.Drawing.Color.White;
            this.btnSearchItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSearchItem.Image = global::BookStoreApp.Properties.Resources.search;
            this.btnSearchItem.Location = new System.Drawing.Point(206, 187);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(142, 34);
            this.btnSearchItem.TabIndex = 6;
            this.btnSearchItem.Text = "Tìm kiếm";
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchItemClick);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.AutoRoundedCorners = true;
            this.txtSearchItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSearchItem.BorderRadius = 15;
            this.txtSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.DefaultText = "";
            this.txtSearchItem.Enabled = false;
            this.txtSearchItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearchItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSearchItem.Location = new System.Drawing.Point(116, 97);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PlaceholderText = "";
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.Size = new System.Drawing.Size(279, 32);
            this.txtSearchItem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(412, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(412, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // comboSearchItem
            // 
            this.comboSearchItem.AutoRoundedCorners = true;
            this.comboSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.comboSearchItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboSearchItem.BorderRadius = 14;
            this.comboSearchItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSearchItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchItem.FocusedColor = System.Drawing.Color.Empty;
            this.comboSearchItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboSearchItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboSearchItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.comboSearchItem.ItemHeight = 25;
            this.comboSearchItem.Items.AddRange(new object[] {
            "Tìm theo tên sách",
            "Tìm theo tên tác giả",
            "Tìm theo thể loại",
            "Tìm theo nhà xuất bản",
            "Theo khoảng số lượng ",
            "Tìm theo khoảng giá "});
            this.comboSearchItem.Location = new System.Drawing.Point(116, 51);
            this.comboSearchItem.Name = "comboSearchItem";
            this.comboSearchItem.Size = new System.Drawing.Size(279, 31);
            this.comboSearchItem.TabIndex = 1;
            this.comboSearchItem.SelectedIndexChanged += new System.EventHandler(this.ComboSearchItemSelectefIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox2.BorderRadius = 10;
            this.groupBox2.Controls.Add(this.btnBoLoc);
            this.groupBox2.Controls.Add(this.radioSortItemByTonKho);
            this.groupBox2.Controls.Add(this.radioSortItemByName);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceDESC);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceASC);
            this.groupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.groupBox2.Location = new System.Drawing.Point(331, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 234);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.Text = "Sắp xếp theo";
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.BorderRadius = 10;
            this.btnBoLoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnBoLoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBoLoc.ForeColor = System.Drawing.Color.White;
            this.btnBoLoc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnBoLoc.Location = new System.Drawing.Point(119, 183);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(97, 38);
            this.btnBoLoc.TabIndex = 4;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // radioSortItemByTonKho
            // 
            this.radioSortItemByTonKho.AutoSize = true;
            this.radioSortItemByTonKho.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByTonKho.CheckedState.BorderThickness = 0;
            this.radioSortItemByTonKho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByTonKho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioSortItemByTonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioSortItemByTonKho.Location = new System.Drawing.Point(15, 77);
            this.radioSortItemByTonKho.Name = "radioSortItemByTonKho";
            this.radioSortItemByTonKho.Size = new System.Drawing.Size(170, 27);
            this.radioSortItemByTonKho.TabIndex = 3;
            this.radioSortItemByTonKho.Text = "Tồn kho giảm dần";
            this.radioSortItemByTonKho.UncheckedState.BorderThickness = 0;
            this.radioSortItemByTonKho.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByName
            // 
            this.radioSortItemByName.AutoSize = true;
            this.radioSortItemByName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByName.CheckedState.BorderThickness = 0;
            this.radioSortItemByName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioSortItemByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioSortItemByName.Location = new System.Drawing.Point(15, 146);
            this.radioSortItemByName.Name = "radioSortItemByName";
            this.radioSortItemByName.Size = new System.Drawing.Size(169, 27);
            this.radioSortItemByName.TabIndex = 2;
            this.radioSortItemByName.Text = "Tên mặt hàng A-Z";
            this.radioSortItemByName.UncheckedState.BorderThickness = 0;
            this.radioSortItemByName.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByPriceDESC
            // 
            this.radioSortItemByPriceDESC.AutoSize = true;
            this.radioSortItemByPriceDESC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByPriceDESC.CheckedState.BorderThickness = 0;
            this.radioSortItemByPriceDESC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByPriceDESC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioSortItemByPriceDESC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioSortItemByPriceDESC.Location = new System.Drawing.Point(15, 110);
            this.radioSortItemByPriceDESC.Name = "radioSortItemByPriceDESC";
            this.radioSortItemByPriceDESC.Size = new System.Drawing.Size(208, 27);
            this.radioSortItemByPriceDESC.TabIndex = 1;
            this.radioSortItemByPriceDESC.Text = "Giá niêm yếu giảm dần";
            this.radioSortItemByPriceDESC.UncheckedState.BorderThickness = 0;
            this.radioSortItemByPriceDESC.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByPriceASC
            // 
            this.radioSortItemByPriceASC.AutoSize = true;
            this.radioSortItemByPriceASC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByPriceASC.CheckedState.BorderThickness = 0;
            this.radioSortItemByPriceASC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.radioSortItemByPriceASC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioSortItemByPriceASC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioSortItemByPriceASC.Location = new System.Drawing.Point(15, 44);
            this.radioSortItemByPriceASC.Name = "radioSortItemByPriceASC";
            this.radioSortItemByPriceASC.Size = new System.Drawing.Size(201, 27);
            this.radioSortItemByPriceASC.TabIndex = 0;
            this.radioSortItemByPriceASC.Text = "Giá niêm yết tăng dần";
            this.radioSortItemByPriceASC.UncheckedState.BorderThickness = 0;
            this.radioSortItemByPriceASC.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox1.BorderRadius = 10;
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Controls.Add(this.btnFreshItem);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 526);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 234);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.Text = "Hành động";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BorderRadius = 10;
            this.btnXoaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnXoaSP.Image = global::BookStoreApp.Properties.Resources.remove;
            this.btnXoaSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaSP.Location = new System.Drawing.Point(172, 77);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(131, 44);
            this.btnXoaSP.TabIndex = 3;
            this.btnXoaSP.Text = "Xoá";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BorderRadius = 10;
            this.btnSuaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSuaSP.Image = global::BookStoreApp.Properties.Resources.loop;
            this.btnSuaSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaSP.Location = new System.Drawing.Point(26, 77);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(131, 44);
            this.btnSuaSP.TabIndex = 2;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnFreshItem
            // 
            this.btnFreshItem.BorderRadius = 10;
            this.btnFreshItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFreshItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFreshItem.ForeColor = System.Drawing.Color.White;
            this.btnFreshItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnFreshItem.Image = global::BookStoreApp.Properties.Resources.refresh;
            this.btnFreshItem.Location = new System.Drawing.Point(172, 156);
            this.btnFreshItem.Name = "btnFreshItem";
            this.btnFreshItem.Size = new System.Drawing.Size(131, 47);
            this.btnFreshItem.TabIndex = 1;
            this.btnFreshItem.Text = "   Làm mới";
            this.btnFreshItem.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BorderRadius = 10;
            this.btnThemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnThemSP.Image = global::BookStoreApp.Properties.Resources.plus;
            this.btnThemSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemSP.Location = new System.Drawing.Point(26, 156);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(131, 47);
            this.btnThemSP.TabIndex = 0;
            this.btnThemSP.Text = "Thêm mới";
            this.btnThemSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // labelPhanTrang
            // 
            this.labelPhanTrang.AutoSize = true;
            this.labelPhanTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPhanTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.labelPhanTrang.Location = new System.Drawing.Point(587, 315);
            this.labelPhanTrang.Name = "labelPhanTrang";
            this.labelPhanTrang.Size = new System.Drawing.Size(35, 23);
            this.labelPhanTrang.TabIndex = 56;
            this.labelPhanTrang.Text = "0/0";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnNext.Location = new System.Drawing.Point(681, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 28);
            this.btnNext.TabIndex = 55;
            this.btnNext.Text = "Sau";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BorderRadius = 10;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnPrevious.Location = new System.Drawing.Point(465, 309);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 30);
            this.btnPrevious.TabIndex = 54;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.AutoRoundedCorners = true;
            this.comboBoxNXB.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxNXB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboBoxNXB.BorderRadius = 14;
            this.comboBoxNXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNXB.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxNXB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.comboBoxNXB.ItemHeight = 25;
            this.comboBoxNXB.Location = new System.Drawing.Point(466, 361);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(280, 31);
            this.comboBoxNXB.TabIndex = 53;
            // 
            // txtFileXemThu
            // 
            this.txtFileXemThu.AutoRoundedCorners = true;
            this.txtFileXemThu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFileXemThu.BorderRadius = 15;
            this.txtFileXemThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileXemThu.DefaultText = "";
            this.txtFileXemThu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFileXemThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFileXemThu.Location = new System.Drawing.Point(799, 487);
            this.txtFileXemThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileXemThu.Name = "txtFileXemThu";
            this.txtFileXemThu.PlaceholderText = "";
            this.txtFileXemThu.SelectedText = "";
            this.txtFileXemThu.Size = new System.Drawing.Size(205, 32);
            this.txtFileXemThu.TabIndex = 52;
            // 
            // btnFileXemThu
            // 
            this.btnFileXemThu.BorderRadius = 10;
            this.btnFileXemThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFileXemThu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFileXemThu.ForeColor = System.Drawing.Color.White;
            this.btnFileXemThu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnFileXemThu.Location = new System.Drawing.Point(799, 442);
            this.btnFileXemThu.Name = "btnFileXemThu";
            this.btnFileXemThu.Size = new System.Drawing.Size(142, 34);
            this.btnFileXemThu.TabIndex = 51;
            this.btnFileXemThu.Text = "File xem thử";
            this.btnFileXemThu.TextFormatNoPrefix = true;
            this.btnFileXemThu.Click += new System.EventHandler(this.btnFileSach_Click);
            // 
            // txtFileSach
            // 
            this.txtFileSach.AutoRoundedCorners = true;
            this.txtFileSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFileSach.BorderRadius = 15;
            this.txtFileSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileSach.DefaultText = "";
            this.txtFileSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFileSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFileSach.Location = new System.Drawing.Point(799, 403);
            this.txtFileSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileSach.Name = "txtFileSach";
            this.txtFileSach.PlaceholderText = "";
            this.txtFileSach.SelectedText = "";
            this.txtFileSach.Size = new System.Drawing.Size(205, 32);
            this.txtFileSach.TabIndex = 50;
            // 
            // btnFileSach
            // 
            this.btnFileSach.BorderRadius = 10;
            this.btnFileSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFileSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFileSach.ForeColor = System.Drawing.Color.White;
            this.btnFileSach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnFileSach.Location = new System.Drawing.Point(799, 360);
            this.btnFileSach.Name = "btnFileSach";
            this.btnFileSach.Size = new System.Drawing.Size(115, 34);
            this.btnFileSach.TabIndex = 49;
            this.btnFileSach.Text = "File sách";
            this.btnFileSach.Click += new System.EventHandler(this.btnFileSach_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtMoTa.BorderRadius = 20;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMoTa.Location = new System.Drawing.Point(466, 447);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(280, 64);
            this.txtMoTa.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(370, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 23);
            this.label13.TabIndex = 47;
            this.label13.Text = "Mô tả";
            // 
            // comboBoxPhanLoai
            // 
            this.comboBoxPhanLoai.AutoRoundedCorners = true;
            this.comboBoxPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPhanLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.comboBoxPhanLoai.BorderRadius = 14;
            this.comboBoxPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhanLoai.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxPhanLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxPhanLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.comboBoxPhanLoai.ItemHeight = 25;
            this.comboBoxPhanLoai.Location = new System.Drawing.Point(137, 485);
            this.comboBoxPhanLoai.Name = "comboBoxPhanLoai";
            this.comboBoxPhanLoai.Size = new System.Drawing.Size(206, 31);
            this.comboBoxPhanLoai.TabIndex = 46;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.AutoRoundedCorners = true;
            this.txtSoTrang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSoTrang.BorderRadius = 15;
            this.txtSoTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTrang.DefaultText = "";
            this.txtSoTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSoTrang.Location = new System.Drawing.Point(466, 407);
            this.txtSoTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.PlaceholderText = "";
            this.txtSoTrang.SelectedText = "";
            this.txtSoTrang.Size = new System.Drawing.Size(77, 32);
            this.txtSoTrang.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label21.Location = new System.Drawing.Point(370, 412);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 23);
            this.label21.TabIndex = 44;
            this.label21.Text = "Số trang";
            // 
            // btnAnh
            // 
            this.btnAnh.BorderRadius = 10;
            this.btnAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAnh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnh.ForeColor = System.Drawing.Color.White;
            this.btnAnh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnAnh.Location = new System.Drawing.Point(1063, 477);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(73, 34);
            this.btnAnh.TabIndex = 43;
            this.btnAnh.Text = "Ảnh";
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(1039, 332);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(125, 138);
            this.picAnh.TabIndex = 42;
            this.picAnh.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label20.Location = new System.Drawing.Point(39, 488);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 23);
            this.label20.TabIndex = 41;
            this.label20.Text = "Thể loại";
            // 
            // txtGia
            // 
            this.txtGia.AutoRoundedCorners = true;
            this.txtGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtGia.BorderRadius = 15;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGia.Location = new System.Drawing.Point(599, 408);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(147, 32);
            this.txtGia.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label19.Location = new System.Drawing.Point(557, 412);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 23);
            this.label19.TabIndex = 39;
            this.label19.Text = "Giá";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(370, 369);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "NXB";
            // 
            // txtTenSach
            // 
            this.txtTenSach.AutoRoundedCorners = true;
            this.txtTenSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtTenSach.BorderRadius = 15;
            this.txtTenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSach.DefaultText = "";
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTenSach.Location = new System.Drawing.Point(137, 405);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PlaceholderText = "";
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.Size = new System.Drawing.Size(206, 32);
            this.txtTenSach.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label17.Location = new System.Drawing.Point(39, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 23);
            this.label17.TabIndex = 36;
            this.label17.Text = "Tên sách";
            // 
            // txtTenTG
            // 
            this.txtTenTG.AutoRoundedCorners = true;
            this.txtTenTG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtTenTG.BorderRadius = 15;
            this.txtTenTG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTG.DefaultText = "";
            this.txtTenTG.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTenTG.Location = new System.Drawing.Point(137, 445);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.PlaceholderText = "";
            this.txtTenTG.SelectedText = "";
            this.txtTenTG.Size = new System.Drawing.Size(206, 32);
            this.txtTenTG.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(39, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 23);
            this.label16.TabIndex = 34;
            this.label16.Text = "Tên TG";
            // 
            // txtMaSach
            // 
            this.txtMaSach.AutoRoundedCorners = true;
            this.txtMaSach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtMaSach.BorderRadius = 15;
            this.txtMaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSach.DefaultText = "";
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaSach.Location = new System.Drawing.Point(137, 364);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PlaceholderText = "";
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.Size = new System.Drawing.Size(206, 32);
            this.txtMaSach.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(39, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "Mã sách";
            // 
            // tblDuLieu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tblDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDuLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDuLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDuLieu.ColumnHeadersHeight = 40;
            this.tblDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDuLieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblDuLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDuLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tblDuLieu.Location = new System.Drawing.Point(3, 3);
            this.tblDuLieu.Name = "tblDuLieu";
            this.tblDuLieu.ReadOnly = true;
            this.tblDuLieu.RowHeadersVisible = false;
            this.tblDuLieu.RowHeadersWidth = 92;
            this.tblDuLieu.RowTemplate.Height = 37;
            this.tblDuLieu.Size = new System.Drawing.Size(1259, 300);
            this.tblDuLieu.TabIndex = 5;
            this.tblDuLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tblDuLieu.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tblDuLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblDuLieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblDuLieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tblDuLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.tblDuLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblDuLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tblDuLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblDuLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblDuLieu.ThemeStyle.HeaderStyle.Height = 40;
            this.tblDuLieu.ThemeStyle.ReadOnly = true;
            this.tblDuLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblDuLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblDuLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tblDuLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblDuLieu.ThemeStyle.RowsStyle.Height = 37;
            this.tblDuLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblDuLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblDuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDuLieu_CellDoubleClick);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.label_phanTrang);
            this.tabCustomer.Controls.Add(this.btnNextt);
            this.tabCustomer.Controls.Add(this.btnPree);
            this.tabCustomer.Controls.Add(this.groupBox4);
            this.tabCustomer.Controls.Add(this.groupBox5);
            this.tabCustomer.Controls.Add(this.groupBox6);
            this.tabCustomer.Controls.Add(this.groupBox12);
            this.tabCustomer.Controls.Add(this.tblKhachHang);
            this.tabCustomer.Location = new System.Drawing.Point(144, 4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1265, 766);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "QL Khách Hàng";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // label_phanTrang
            // 
            this.label_phanTrang.AutoSize = true;
            this.label_phanTrang.Location = new System.Drawing.Point(575, 314);
            this.label_phanTrang.Name = "label_phanTrang";
            this.label_phanTrang.Size = new System.Drawing.Size(39, 25);
            this.label_phanTrang.TabIndex = 15;
            this.label_phanTrang.Text = "0/0";
            // 
            // btnNextt
            // 
            this.btnNextt.Location = new System.Drawing.Point(652, 307);
            this.btnNextt.Name = "btnNextt";
            this.btnNextt.Size = new System.Drawing.Size(75, 29);
            this.btnNextt.TabIndex = 14;
            this.btnNextt.Text = "Sau";
            this.btnNextt.UseVisualStyleBackColor = true;
            this.btnNextt.Click += new System.EventHandler(this.btnNextt_Click);
            // 
            // btnPree
            // 
            this.btnPree.Location = new System.Drawing.Point(482, 307);
            this.btnPree.Name = "btnPree";
            this.btnPree.Size = new System.Drawing.Size(75, 29);
            this.btnPree.TabIndex = 13;
            this.btnPree.Text = "Trước";
            this.btnPree.UseVisualStyleBackColor = true;
            this.btnPree.Click += new System.EventHandler(this.btnPree_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchCustomer);
            this.groupBox4.Controls.Add(this.txtSearchCustomer);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboSearchCustomer);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(746, 563);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 174);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = global::BookStoreApp.Properties.Resources.search;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(185, 117);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(132, 44);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomerClick);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(155, 80);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(244, 26);
            this.txtSearchCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
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
            this.comboSearchCustomer.Location = new System.Drawing.Point(155, 35);
            this.comboSearchCustomer.Name = "comboSearchCustomer";
            this.comboSearchCustomer.Size = new System.Drawing.Size(244, 27);
            this.comboSearchCustomer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiêu chí";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btbBoLoc);
            this.groupBox5.Controls.Add(this.radioSortCustomerByBirthDate);
            this.groupBox5.Controls.Add(this.radioSortCustomerByName);
            this.groupBox5.Controls.Add(this.radioSortCustomerById);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(349, 563);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 174);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sắp xếp theo";
            // 
            // btbBoLoc
            // 
            this.btbBoLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBoLoc.Location = new System.Drawing.Point(39, 123);
            this.btbBoLoc.Name = "btbBoLoc";
            this.btbBoLoc.Size = new System.Drawing.Size(81, 32);
            this.btbBoLoc.TabIndex = 3;
            this.btbBoLoc.Text = "Bỏ lọc";
            this.btbBoLoc.UseVisualStyleBackColor = true;
            this.btbBoLoc.Click += new System.EventHandler(this.btbBoLoc_Click);
            // 
            // radioSortCustomerByBirthDate
            // 
            this.radioSortCustomerByBirthDate.AutoSize = true;
            this.radioSortCustomerByBirthDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerByBirthDate.Location = new System.Drawing.Point(39, 93);
            this.radioSortCustomerByBirthDate.Name = "radioSortCustomerByBirthDate";
            this.radioSortCustomerByBirthDate.Size = new System.Drawing.Size(168, 24);
            this.radioSortCustomerByBirthDate.TabIndex = 2;
            this.radioSortCustomerByBirthDate.TabStop = true;
            this.radioSortCustomerByBirthDate.Text = "Ngày sinh tăng dần";
            this.radioSortCustomerByBirthDate.UseVisualStyleBackColor = true;
            this.radioSortCustomerByBirthDate.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerByName
            // 
            this.radioSortCustomerByName.AutoSize = true;
            this.radioSortCustomerByName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerByName.Location = new System.Drawing.Point(39, 64);
            this.radioSortCustomerByName.Name = "radioSortCustomerByName";
            this.radioSortCustomerByName.Size = new System.Drawing.Size(212, 24);
            this.radioSortCustomerByName.TabIndex = 1;
            this.radioSortCustomerByName.TabStop = true;
            this.radioSortCustomerByName.Text = "Tên khách hàng tăng dần";
            this.radioSortCustomerByName.UseVisualStyleBackColor = true;
            this.radioSortCustomerByName.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerById
            // 
            this.radioSortCustomerById.AutoSize = true;
            this.radioSortCustomerById.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSortCustomerById.Location = new System.Drawing.Point(39, 35);
            this.radioSortCustomerById.Name = "radioSortCustomerById";
            this.radioSortCustomerById.Size = new System.Drawing.Size(207, 24);
            this.radioSortCustomerById.TabIndex = 0;
            this.radioSortCustomerById.TabStop = true;
            this.radioSortCustomerById.Text = "Mã khách hàng tăng dần";
            this.radioSortCustomerById.UseVisualStyleBackColor = true;
            this.radioSortCustomerById.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnXoaKH);
            this.groupBox6.Controls.Add(this.btnSuaKH);
            this.groupBox6.Controls.Add(this.btnRefreshCustomer);
            this.groupBox6.Controls.Add(this.btnAddNewCustomer);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 563);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 176);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hành động";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Image = global::BookStoreApp.Properties.Resources.remove;
            this.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKH.Location = new System.Drawing.Point(166, 30);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(131, 52);
            this.btnXoaKH.TabIndex = 5;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Image = global::BookStoreApp.Properties.Resources.loop;
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKH.Location = new System.Drawing.Point(29, 30);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(131, 52);
            this.btnSuaKH.TabIndex = 4;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomer.Image = global::BookStoreApp.Properties.Resources.refresh;
            this.btnRefreshCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCustomer.Location = new System.Drawing.Point(166, 102);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(131, 49);
            this.btnRefreshCustomer.TabIndex = 1;
            this.btnRefreshCustomer.Text = "    Làm mới";
            this.btnRefreshCustomer.UseVisualStyleBackColor = true;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.Image = global::BookStoreApp.Properties.Resources.plus;
            this.btnAddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(29, 102);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(131, 49);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "       Thêm mới";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomerClick);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnAnhKH);
            this.groupBox12.Controls.Add(this.pictureBoxKH);
            this.groupBox12.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox12.Controls.Add(this.btnHienMatKhau);
            this.groupBox12.Controls.Add(this.comboBoxGioiTinh);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.txtMatKhau);
            this.groupBox12.Controls.Add(this.txtDiaChiKH);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.label25);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.txtSDTKH);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.txtTenKH);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.txtMaKH);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Location = new System.Drawing.Point(6, 342);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1204, 208);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chung";
            // 
            // btnAnhKH
            // 
            this.btnAnhKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnhKH.Location = new System.Drawing.Point(1043, 159);
            this.btnAnhKH.Name = "btnAnhKH";
            this.btnAnhKH.Size = new System.Drawing.Size(80, 29);
            this.btnAnhKH.TabIndex = 27;
            this.btnAnhKH.Text = "Ảnh";
            this.btnAnhKH.UseVisualStyleBackColor = true;
            this.btnAnhKH.Click += new System.EventHandler(this.btnAnhKH_Click);
            // 
            // pictureBoxKH
            // 
            this.pictureBoxKH.Location = new System.Drawing.Point(1023, 21);
            this.pictureBoxKH.Name = "pictureBoxKH";
            this.pictureBoxKH.Size = new System.Drawing.Size(116, 132);
            this.pictureBoxKH.TabIndex = 26;
            this.pictureBoxKH.TabStop = false;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(526, 32);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(167, 26);
            this.dateTimePickerNgaySinh.TabIndex = 25;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienMatKhau.Location = new System.Drawing.Point(360, 159);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(68, 26);
            this.btnHienMatKhau.TabIndex = 24;
            this.btnHienMatKhau.Text = "Hiện";
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(526, 75);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(167, 27);
            this.comboBoxGioiTinh.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(436, 78);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 19);
            this.label27.TabIndex = 17;
            this.label27.Text = "Giới tính";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(156, 159);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(189, 26);
            this.txtMatKhau.TabIndex = 23;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(526, 117);
            this.txtDiaChiKH.Multiline = true;
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(411, 68);
            this.txtDiaChiKH.TabIndex = 14;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(31, 164);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 19);
            this.label38.TabIndex = 22;
            this.label38.Text = "Mật khẩu";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(436, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 19);
            this.label25.TabIndex = 13;
            this.label25.Text = "Địa chỉ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(436, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 19);
            this.label26.TabIndex = 15;
            this.label26.Text = "Ngày sinh";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(156, 118);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(189, 26);
            this.txtSDTKH.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(31, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 19);
            this.label24.TabIndex = 11;
            this.label24.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(156, 75);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(189, 26);
            this.txtTenKH.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(31, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 19);
            this.label23.TabIndex = 9;
            this.label23.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(156, 32);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(189, 26);
            this.txtMaKH.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(31, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 19);
            this.label22.TabIndex = 7;
            this.label22.Text = "Mã khách hàng";
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Email});
            this.tblKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblKhachHang.Location = new System.Drawing.Point(3, 3);
            this.tblKhachHang.Name = "tblKhachHang";
            this.tblKhachHang.ReadOnly = true;
            this.tblKhachHang.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblKhachHang.RowTemplate.Height = 24;
            this.tblKhachHang.ShowCellToolTips = false;
            this.tblKhachHang.Size = new System.Drawing.Size(1259, 298);
            this.tblKhachHang.TabIndex = 5;
            this.tblKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblKhachHang_CellContentDoubleClick);
            this.tblKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblKhachHang_CellContentDoubleClick);
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
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.groupBox7);
            this.tabDiscount.Controls.Add(this.groupBox9);
            this.tabDiscount.Controls.Add(this.groupBox13);
            this.tabDiscount.Controls.Add(this.tblKhuyenMai);
            this.tabDiscount.Location = new System.Drawing.Point(144, 4);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(1265, 766);
            this.tabDiscount.TabIndex = 2;
            this.tabDiscount.Text = "QL Khuyến mãi";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearchDiscount);
            this.groupBox7.Controls.Add(this.txtSearchDiscount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.comboSearchDiscount);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(584, 472);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(626, 265);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm kiếm";
            // 
            // btnSearchDiscount
            // 
            this.btnSearchDiscount.Enabled = false;
            this.btnSearchDiscount.Image = global::BookStoreApp.Properties.Resources.search;
            this.btnSearchDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDiscount.Location = new System.Drawing.Point(240, 202);
            this.btnSearchDiscount.Name = "btnSearchDiscount";
            this.btnSearchDiscount.Size = new System.Drawing.Size(151, 41);
            this.btnSearchDiscount.TabIndex = 6;
            this.btnSearchDiscount.Text = "Tìm kiếm";
            this.btnSearchDiscount.UseVisualStyleBackColor = true;
            this.btnSearchDiscount.Click += new System.EventHandler(this.BtnSearchDiscountClick);
            // 
            // txtSearchDiscount
            // 
            this.txtSearchDiscount.Location = new System.Drawing.Point(189, 112);
            this.txtSearchDiscount.Name = "txtSearchDiscount";
            this.txtSearchDiscount.Size = new System.Drawing.Size(240, 28);
            this.txtSearchDiscount.TabIndex = 5;
            this.txtSearchDiscount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nội dung";
            this.label5.Visible = false;
            // 
            // comboSearchDiscount
            // 
            this.comboSearchDiscount.FormattingEnabled = true;
            this.comboSearchDiscount.Items.AddRange(new object[] {
            "Sách trong thời gian khuyến mãi",
            "Sách hết thời gian khuyến mãi"});
            this.comboSearchDiscount.Location = new System.Drawing.Point(189, 61);
            this.comboSearchDiscount.Name = "comboSearchDiscount";
            this.comboSearchDiscount.Size = new System.Drawing.Size(240, 28);
            this.comboSearchDiscount.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
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
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(6, 472);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(572, 265);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hành động";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BookStoreApp.Properties.Resources.floppy_disk;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(141, 201);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 42);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaKM
            // 
            this.btnXoaKM.Image = global::BookStoreApp.Properties.Resources.remove;
            this.btnXoaKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKM.Location = new System.Drawing.Point(283, 61);
            this.btnXoaKM.Name = "btnXoaKM";
            this.btnXoaKM.Size = new System.Drawing.Size(185, 42);
            this.btnXoaKM.TabIndex = 5;
            this.btnXoaKM.Text = "Xoá";
            this.btnXoaKM.UseVisualStyleBackColor = true;
            this.btnXoaKM.Click += new System.EventHandler(this.btnXoaKM_Click);
            // 
            // btnSuaKM
            // 
            this.btnSuaKM.Image = global::BookStoreApp.Properties.Resources.loop;
            this.btnSuaKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKM.Location = new System.Drawing.Point(44, 61);
            this.btnSuaKM.Name = "btnSuaKM";
            this.btnSuaKM.Size = new System.Drawing.Size(183, 42);
            this.btnSuaKM.TabIndex = 4;
            this.btnSuaKM.Text = "Sửa";
            this.btnSuaKM.UseVisualStyleBackColor = true;
            this.btnSuaKM.Click += new System.EventHandler(this.btnSuaKM_Click);
            // 
            // btnRefreshDiscount
            // 
            this.btnRefreshDiscount.Image = global::BookStoreApp.Properties.Resources.refresh;
            this.btnRefreshDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshDiscount.Location = new System.Drawing.Point(283, 132);
            this.btnRefreshDiscount.Name = "btnRefreshDiscount";
            this.btnRefreshDiscount.Size = new System.Drawing.Size(185, 42);
            this.btnRefreshDiscount.TabIndex = 1;
            this.btnRefreshDiscount.Text = "Làm mới";
            this.btnRefreshDiscount.UseVisualStyleBackColor = true;
            this.btnRefreshDiscount.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNewDiscount
            // 
            this.btnAddNewDiscount.Image = global::BookStoreApp.Properties.Resources.plus;
            this.btnAddNewDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewDiscount.Location = new System.Drawing.Point(42, 132);
            this.btnAddNewDiscount.Name = "btnAddNewDiscount";
            this.btnAddNewDiscount.Size = new System.Drawing.Size(185, 42);
            this.btnAddNewDiscount.TabIndex = 0;
            this.btnAddNewDiscount.Text = "Thêm mới";
            this.btnAddNewDiscount.UseVisualStyleBackColor = true;
            this.btnAddNewDiscount.Click += new System.EventHandler(this.BtnAddNewDiscountClick);
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
            this.groupBox13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(6, 319);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1204, 136);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Thông tin chung";
            // 
            // dateTimePickerTGKT
            // 
            this.dateTimePickerTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTGKT.Location = new System.Drawing.Point(789, 89);
            this.dateTimePickerTGKT.Name = "dateTimePickerTGKT";
            this.dateTimePickerTGKT.Size = new System.Drawing.Size(268, 28);
            this.dateTimePickerTGKT.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(574, 93);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 19);
            this.label29.TabIndex = 28;
            this.label29.Text = "Thời gian kết thúc";
            // 
            // dateTimePickerTGBD
            // 
            this.dateTimePickerTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTGBD.Location = new System.Drawing.Point(200, 89);
            this.dateTimePickerTGBD.Name = "dateTimePickerTGBD";
            this.dateTimePickerTGBD.Size = new System.Drawing.Size(268, 28);
            this.dateTimePickerTGBD.TabIndex = 27;
            // 
            // comboBoxTenSach
            // 
            this.comboBoxTenSach.FormattingEnabled = true;
            this.comboBoxTenSach.Location = new System.Drawing.Point(200, 41);
            this.comboBoxTenSach.Name = "comboBoxTenSach";
            this.comboBoxTenSach.Size = new System.Drawing.Size(268, 28);
            this.comboBoxTenSach.TabIndex = 24;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(846, 41);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 22);
            this.label37.TabIndex = 23;
            this.label37.Text = "%";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(40, 95);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(136, 19);
            this.label34.TabIndex = 19;
            this.label34.Text = "Thời gian bắt đầu";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(789, 37);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(51, 28);
            this.txtKM.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(574, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(174, 19);
            this.label31.TabIndex = 13;
            this.label31.Text = "Phần trăm khuyến mại";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(40, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 19);
            this.label30.TabIndex = 11;
            this.label30.Text = "Tên sách";
            // 
            // tblKhuyenMai
            // 
            this.tblKhuyenMai.AllowUserToAddRows = false;
            this.tblKhuyenMai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tblKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblKhuyenMai.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tblKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDiscount,
            this.StartTime,
            this.EndTime,
            this.DiscountPercent});
            this.tblKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblKhuyenMai.Location = new System.Drawing.Point(3, 3);
            this.tblKhuyenMai.Name = "tblKhuyenMai";
            this.tblKhuyenMai.ReadOnly = true;
            this.tblKhuyenMai.RowHeadersWidth = 51;
            this.tblKhuyenMai.RowTemplate.Height = 24;
            this.tblKhuyenMai.Size = new System.Drawing.Size(1259, 300);
            this.tblKhuyenMai.TabIndex = 9;
            this.tblKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblKhuyenMai_CellClick);
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
            // tabStat
            // 
            this.tabStat.Controls.Add(this.tblThongKe);
            this.tabStat.Controls.Add(this.groupBox11);
            this.tabStat.Location = new System.Drawing.Point(144, 4);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(1265, 766);
            this.tabStat.TabIndex = 3;
            this.tabStat.Text = "Thống kê";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // tblThongKe
            // 
            this.tblThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblThongKe.BackgroundColor = System.Drawing.Color.White;
            this.tblThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblThongKe.DefaultCellStyle = dataGridViewCellStyle9;
            this.tblThongKe.Location = new System.Drawing.Point(10, 146);
            this.tblThongKe.Name = "tblThongKe";
            this.tblThongKe.RowHeadersWidth = 51;
            this.tblThongKe.RowTemplate.Height = 40;
            this.tblThongKe.Size = new System.Drawing.Size(1200, 585);
            this.tblThongKe.TabIndex = 0;
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
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(10, 15);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1200, 125);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Thống kê theo tiêu chí";
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTime.Location = new System.Drawing.Point(556, 80);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(208, 24);
            this.checkBoxTime.TabIndex = 13;
            this.checkBoxTime.Text = "Không áp dụng thời gian";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BookStoreApp.Properties.Resources.floppy_disk;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1018, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "      Xuất file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denNgay
            // 
            this.denNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.denNgay.Location = new System.Drawing.Point(399, 80);
            this.denNgay.Name = "denNgay";
            this.denNgay.Size = new System.Drawing.Size(124, 26);
            this.denNgay.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(294, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Đến ngày";
            // 
            // tuNgay
            // 
            this.tuNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tuNgay.Location = new System.Drawing.Point(144, 81);
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.Size = new System.Drawing.Size(124, 26);
            this.tuNgay.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(51, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 20);
            this.label28.TabIndex = 8;
            this.label28.Text = "Từ ngày";
            // 
            // btnStatResult
            // 
            this.btnStatResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatResult.Location = new System.Drawing.Point(874, 48);
            this.btnStatResult.Name = "btnStatResult";
            this.btnStatResult.Size = new System.Drawing.Size(112, 38);
            this.btnStatResult.TabIndex = 7;
            this.btnStatResult.Text = "Thống kê";
            this.btnStatResult.UseVisualStyleBackColor = true;
            this.btnStatResult.Click += new System.EventHandler(this.BtnSearchStatClick);
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
            this.comboStat.Location = new System.Drawing.Point(144, 33);
            this.comboStat.Name = "comboStat";
            this.comboStat.Size = new System.Drawing.Size(620, 28);
            this.comboStat.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tiêu chí";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.LoaiBieuDoCB);
            this.tabPage1.Controls.Add(this.txtTop);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnTaoBaoCao);
            this.tabPage1.Controls.Add(this.denNgayPicker);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.TuNgayPicker);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btnIn);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(144, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1265, 766);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Báo cáo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.White;
            this.groupBox15.Controls.Add(this.chart2);
            this.groupBox15.Controls.Add(this.chart1);
            this.groupBox15.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(486, 157);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(724, 569);
            this.groupBox15.TabIndex = 29;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Biểu đồ";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(16, 26);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(686, 522);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(16, 42);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(702, 506);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.White;
            this.groupBox14.Controls.Add(this.tblBaoCao);
            this.groupBox14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(4, 157);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(476, 574);
            this.groupBox14.TabIndex = 27;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Bảng chi tiết";
            // 
            // tblBaoCao
            // 
            this.tblBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.tblBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBaoCao.Location = new System.Drawing.Point(6, 26);
            this.tblBaoCao.Name = "tblBaoCao";
            this.tblBaoCao.RowHeadersWidth = 51;
            this.tblBaoCao.Size = new System.Drawing.Size(464, 542);
            this.tblBaoCao.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(370, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Loại biểu đồ";
            // 
            // LoaiBieuDoCB
            // 
            this.LoaiBieuDoCB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiBieuDoCB.FormattingEnabled = true;
            this.LoaiBieuDoCB.Items.AddRange(new object[] {
            "Cột",
            "Tròn"});
            this.LoaiBieuDoCB.Location = new System.Drawing.Point(374, 124);
            this.LoaiBieuDoCB.Name = "LoaiBieuDoCB";
            this.LoaiBieuDoCB.Size = new System.Drawing.Size(135, 27);
            this.LoaiBieuDoCB.TabIndex = 24;
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTop.Location = new System.Drawing.Point(374, 54);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(135, 26);
            this.txtTop.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Top";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(811, 76);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(123, 40);
            this.btnTaoBaoCao.TabIndex = 21;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // denNgayPicker
            // 
            this.denNgayPicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denNgayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.denNgayPicker.Location = new System.Drawing.Point(554, 125);
            this.denNgayPicker.Name = "denNgayPicker";
            this.denNgayPicker.Size = new System.Drawing.Size(179, 26);
            this.denNgayPicker.TabIndex = 20;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(550, 96);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 20);
            this.label40.TabIndex = 19;
            this.label40.Text = "Đến ngày";
            // 
            // TuNgayPicker
            // 
            this.TuNgayPicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuNgayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TuNgayPicker.Location = new System.Drawing.Point(554, 54);
            this.TuNgayPicker.Name = "TuNgayPicker";
            this.TuNgayPicker.Size = new System.Drawing.Size(179, 26);
            this.TuNgayPicker.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Báo cáo hàng bán chạy",
            "Báo cáo khách hàng theo chi tiêu"});
            this.comboBox1.Location = new System.Drawing.Point(33, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 27);
            this.comboBox1.TabIndex = 17;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(550, 29);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(70, 20);
            this.label39.TabIndex = 16;
            this.label39.Text = "Từ ngày";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 22);
            this.label14.TabIndex = 15;
            this.label14.Text = "BÁO CÁO THEO";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::BookStoreApp.Properties.Resources.floppy_disk;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(968, 76);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(141, 40);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "       Lưu biểu đồ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 776);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeFrm";
            this.Text = "Quản Lý Bán Sách";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuLieu)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHang)).EndInit();
            this.tabDiscount.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhuyenMai)).EndInit();
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblThongKe)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelPhanTrang;
        private Guna2Button btnNext;
        private Guna2Button btnPrevious;
        private Guna2ComboBox comboBoxNXB;
        private Guna2TextBox txtFileXemThu;
        private Guna2Button btnFileXemThu;
        private Guna2TextBox txtFileSach;
        private Guna2Button btnFileSach;
        private Guna2TextBox txtMoTa;
        private System.Windows.Forms.Label label13;
        private Guna2ComboBox comboBoxPhanLoai;
        private OpenFileDialog openFileDialog1;
        private Guna2TextBox txtSoTrang;
        private System.Windows.Forms.Label label21;
        private Guna2Button btnAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label20;
        private Guna2TextBox txtGia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private Guna2TextBox txtTenSach;
        private System.Windows.Forms.Label label17;
        private Guna2TextBox txtTenTG;
        private System.Windows.Forms.Label label16;
        private Guna2TextBox txtMaSach;
        private System.Windows.Forms.Label label15;
        private Guna2GroupBox groupBox3;
        private Guna2ComboBox LocPhanLoai;
        private System.Windows.Forms.Label labelTimKiem;
        private Guna2NumericUpDown numericItemTo;
        private Guna2NumericUpDown numericItemFrom;
        private Guna2Button btnSearchItem;
        private Guna2TextBox txtSearchItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna2ComboBox comboSearchItem;
        private System.Windows.Forms.Label label1;
        private Guna2GroupBox groupBox2;
        private Guna2Button btnBoLoc;
        private Guna2RadioButton radioSortItemByTonKho;
        private Guna2RadioButton radioSortItemByName;
        private Guna2RadioButton radioSortItemByPriceDESC;
        private Guna2RadioButton radioSortItemByPriceASC;
        private Guna2GroupBox groupBox1;
        private Guna2Button btnXoaSP;
        private Guna2Button btnSuaSP;
        private Guna2Button btnFreshItem;
        private ErrorProvider errorProvider1;
        private Guna2Button btnThemSP;
        private System.Windows.Forms.DataGridView tblKhachHang;
        private System.Windows.Forms.Label label_phanTrang;
        private System.Windows.Forms.Button btnNextt;
        private System.Windows.Forms.Button btnPree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSearchCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btbBoLoc;
        private System.Windows.Forms.RadioButton radioSortCustomerByBirthDate;
        private System.Windows.Forms.RadioButton radioSortCustomerByName;
        private System.Windows.Forms.RadioButton radioSortCustomerById;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnRefreshCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnAnhKH;
        private System.Windows.Forms.PictureBox pictureBoxKH;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSearchDiscount;
        private System.Windows.Forms.TextBox txtSearchDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSearchDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaKM;
        private System.Windows.Forms.Button btnSuaKM;
        private System.Windows.Forms.Button btnRefreshDiscount;
        private System.Windows.Forms.Button btnAddNewDiscount;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DateTimePicker dateTimePickerTGKT;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dateTimePickerTGBD;
        private System.Windows.Forms.ComboBox comboBoxTenSach;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView tblKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridView tblThongKe;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker denNgay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tuNgay;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnStatResult;
        private System.Windows.Forms.ComboBox comboStat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DataGridView tblBaoCao;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LoaiBieuDoCB;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.DateTimePicker denNgayPicker;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DateTimePicker TuNgayPicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private DataGridViewTextBoxColumn Customer_ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn Point;
        private DataGridViewTextBoxColumn CreateTime;
        private DataGridViewTextBoxColumn Email;
        private GroupBox groupBox15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2TabControl tabControl1;
        private Guna2DataGridView tblDuLieu;
    }
}