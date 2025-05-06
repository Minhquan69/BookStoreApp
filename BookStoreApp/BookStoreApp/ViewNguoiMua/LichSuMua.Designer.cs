using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace BookStoreApp.ViewNguoiMua
{
    partial class LichSuMua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dtTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGiaTu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaDen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInLichSu = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuayLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.ptbAnhSach = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbLanXB = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.lbTGPhatHanh = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxTTS = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBoxCTDH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBoxDSDH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtThoiGian = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxttdon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).BeginInit();
            this.groupBoxTTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBoxCTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.groupBoxDSDH.SuspendLayout();
            this.groupBoxttdon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label18.Location = new System.Drawing.Point(12, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 23);
            this.label18.TabIndex = 127;
            this.label18.Text = "Từ ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(342, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 126;
            this.label5.Text = "Đến ngày:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 10;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::BookStoreApp.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(1096, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 123;
            this.button1.Text = "Tìm kiếm";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.BorderRadius = 10;
            this.dtTuNgay.Checked = true;
            this.dtTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(111, 8);
            this.dtTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(188, 28);
            this.dtTuNgay.TabIndex = 17;
            this.dtTuNgay.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.BorderRadius = 10;
            this.dtDenNgay.Checked = true;
            this.dtDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(454, 11);
            this.dtDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(188, 28);
            this.dtDenNgay.TabIndex = 128;
            this.dtDenNgay.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(662, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 23);
            this.label14.TabIndex = 129;
            this.label14.Text = "Giá từ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(860, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 23);
            this.label15.TabIndex = 130;
            this.label15.Text = "đến";
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.BorderRadius = 10;
            this.txtGiaTu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTu.DefaultText = "";
            this.txtGiaTu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaTu.Location = new System.Drawing.Point(728, 12);
            this.txtGiaTu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.PlaceholderText = "";
            this.txtGiaTu.SelectedText = "";
            this.txtGiaTu.Size = new System.Drawing.Size(120, 28);
            this.txtGiaTu.TabIndex = 18;
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.BorderRadius = 10;
            this.txtGiaDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaDen.DefaultText = "";
            this.txtGiaDen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaDen.Location = new System.Drawing.Point(905, 11);
            this.txtGiaDen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.PlaceholderText = "";
            this.txtGiaDen.SelectedText = "";
            this.txtGiaDen.Size = new System.Drawing.Size(108, 28);
            this.txtGiaDen.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.Location = new System.Drawing.Point(1019, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 23);
            this.label16.TabIndex = 132;
            this.label16.Text = "VNĐ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderRadius = 10;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtGiaDen);
            this.panel1.Controls.Add(this.txtGiaTu);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtDenNgay);
            this.panel1.Controls.Add(this.dtTuNgay);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(28, 44);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Enabled = true;
            this.panel1.Size = new System.Drawing.Size(1245, 49);
            this.panel1.TabIndex = 122;
            // 
            // btnInLichSu
            // 
            this.btnInLichSu.BackColor = System.Drawing.Color.Transparent;
            this.btnInLichSu.BorderRadius = 10;
            this.btnInLichSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInLichSu.ForeColor = System.Drawing.Color.Black;
            this.btnInLichSu.Location = new System.Drawing.Point(535, 681);
            this.btnInLichSu.Name = "btnInLichSu";
            this.btnInLichSu.Size = new System.Drawing.Size(145, 35);
            this.btnInLichSu.TabIndex = 119;
            this.btnInLichSu.Text = "In";
            this.btnInLichSu.Click += new System.EventHandler(this.btnInLichSu_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.BorderRadius = 10;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.Location = new System.Drawing.Point(1100, 680);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(133, 36);
            this.btnQuayLai.TabIndex = 120;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BorderRadius = 10;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(77, 681);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(265, 35);
            this.btnShowAll.TabIndex = 121;
            this.btnShowAll.Text = "Hiển thị tất cả đơn hàng";
            this.btnShowAll.TextFormatNoPrefix = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // ptbAnhSach
            // 
            this.ptbAnhSach.BackColor = System.Drawing.Color.White;
            this.ptbAnhSach.BorderRadius = 10;
            this.ptbAnhSach.ImageRotate = 0F;
            this.ptbAnhSach.Location = new System.Drawing.Point(109, 68);
            this.ptbAnhSach.Name = "ptbAnhSach";
            this.ptbAnhSach.Size = new System.Drawing.Size(180, 216);
            this.ptbAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhSach.TabIndex = 0;
            this.ptbAnhSach.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tác giả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Lần XB:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thể loại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "NXB:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "TG phát hành:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.BackColor = System.Drawing.Color.Transparent;
            this.lbTenSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTenSach.ForeColor = System.Drawing.Color.Black;
            this.lbTenSach.Location = new System.Drawing.Point(105, 303);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(86, 23);
            this.lbTenSach.TabIndex = 24;
            this.lbTenSach.Text = "lbTenSach";
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.BackColor = System.Drawing.Color.Transparent;
            this.lbTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTacGia.ForeColor = System.Drawing.Color.Black;
            this.lbTacGia.Location = new System.Drawing.Point(96, 335);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(73, 23);
            this.lbTacGia.TabIndex = 25;
            this.lbTacGia.Text = "lbTacGia";
            // 
            // lbLanXB
            // 
            this.lbLanXB.AutoSize = true;
            this.lbLanXB.BackColor = System.Drawing.Color.Transparent;
            this.lbLanXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbLanXB.ForeColor = System.Drawing.Color.Black;
            this.lbLanXB.Location = new System.Drawing.Point(96, 369);
            this.lbLanXB.Name = "lbLanXB";
            this.lbLanXB.Size = new System.Drawing.Size(71, 23);
            this.lbLanXB.TabIndex = 26;
            this.lbLanXB.Text = "lbLanXB";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lbTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTheLoai.ForeColor = System.Drawing.Color.Black;
            this.lbTheLoai.Location = new System.Drawing.Point(98, 406);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(83, 23);
            this.lbTheLoai.TabIndex = 27;
            this.lbTheLoai.Text = "lbTheLoai";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.BackColor = System.Drawing.Color.Transparent;
            this.lbNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbNXB.ForeColor = System.Drawing.Color.Black;
            this.lbNXB.Location = new System.Drawing.Point(77, 441);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(57, 23);
            this.lbNXB.TabIndex = 28;
            this.lbNXB.Text = "lbNXB";
            // 
            // lbTGPhatHanh
            // 
            this.lbTGPhatHanh.AutoSize = true;
            this.lbTGPhatHanh.BackColor = System.Drawing.Color.Transparent;
            this.lbTGPhatHanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbTGPhatHanh.ForeColor = System.Drawing.Color.Black;
            this.lbTGPhatHanh.Location = new System.Drawing.Point(140, 472);
            this.lbTGPhatHanh.Name = "lbTGPhatHanh";
            this.lbTGPhatHanh.Size = new System.Drawing.Size(120, 23);
            this.lbTGPhatHanh.TabIndex = 29;
            this.lbTGPhatHanh.Text = "lbTGPhatHanh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(20, 511);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "File Sách:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderRadius = 10;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(121, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 28);
            this.button2.TabIndex = 129;
            this.button2.Text = "Download";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxTTS
            // 
            this.groupBoxTTS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBoxTTS.Controls.Add(this.button2);
            this.groupBoxTTS.Controls.Add(this.label13);
            this.groupBoxTTS.Controls.Add(this.lbTGPhatHanh);
            this.groupBoxTTS.Controls.Add(this.lbNXB);
            this.groupBoxTTS.Controls.Add(this.lbTheLoai);
            this.groupBoxTTS.Controls.Add(this.lbLanXB);
            this.groupBoxTTS.Controls.Add(this.lbTacGia);
            this.groupBoxTTS.Controls.Add(this.lbTenSach);
            this.groupBoxTTS.Controls.Add(this.label12);
            this.groupBoxTTS.Controls.Add(this.label11);
            this.groupBoxTTS.Controls.Add(this.label10);
            this.groupBoxTTS.Controls.Add(this.label9);
            this.groupBoxTTS.Controls.Add(this.label6);
            this.groupBoxTTS.Controls.Add(this.label2);
            this.groupBoxTTS.Controls.Add(this.ptbAnhSach);
            this.groupBoxTTS.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.groupBoxTTS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxTTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxTTS.Location = new System.Drawing.Point(895, 99);
            this.groupBoxTTS.Name = "groupBoxTTS";
            this.groupBoxTTS.Size = new System.Drawing.Size(378, 576);
            this.groupBoxTTS.TabIndex = 5;
            this.groupBoxTTS.Text = "Thông tin sách";
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.ColumnHeadersHeight = 40;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvCTHD.Location = new System.Drawing.Point(3, 38);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 30;
            this.dgvCTHD.Size = new System.Drawing.Size(855, 146);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCTHD.ThemeStyle.ReadOnly = false;
            this.dgvCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // groupBoxCTDH
            // 
            this.groupBoxCTDH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBoxCTDH.Controls.Add(this.dgvCTHD);
            this.groupBoxCTDH.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.groupBoxCTDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxCTDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxCTDH.Location = new System.Drawing.Point(28, 488);
            this.groupBoxCTDH.Name = "groupBoxCTDH";
            this.groupBoxCTDH.Size = new System.Drawing.Size(861, 187);
            this.groupBoxCTDH.TabIndex = 4;
            this.groupBoxCTDH.Text = "Chi tiết đơn hàng";
            // 
            // dgvHD
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHD.AlternatingRowsDefaultCellStyle = null;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHD.ColumnHeadersHeight = 40;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvHD.Location = new System.Drawing.Point(3, 38);
            this.dgvHD.Name = "dgvHD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 30;
            this.dgvHD.Size = new System.Drawing.Size(855, 219);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHD.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHD.ThemeStyle.ReadOnly = false;
            this.dgvHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.dgvHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHD.ThemeStyle.RowsStyle.Height = 30;
            this.dgvHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // groupBoxDSDH
            // 
            this.groupBoxDSDH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBoxDSDH.Controls.Add(this.dgvHD);
            this.groupBoxDSDH.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.groupBoxDSDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxDSDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxDSDH.Location = new System.Drawing.Point(28, 222);
            this.groupBoxDSDH.Name = "groupBoxDSDH";
            this.groupBoxDSDH.Size = new System.Drawing.Size(861, 260);
            this.groupBoxDSDH.TabIndex = 3;
            this.groupBoxDSDH.Text = "Danh sách đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch sử mua hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(44, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày mua: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(44, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(461, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng số sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(461, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tổng tiền:";
            // 
            // txtTongSach
            // 
            this.txtTongSach.BorderRadius = 10;
            this.txtTongSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongSach.DefaultText = "";
            this.txtTongSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongSach.Location = new System.Drawing.Point(587, 48);
            this.txtTongSach.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTongSach.Name = "txtTongSach";
            this.txtTongSach.PlaceholderText = "";
            this.txtTongSach.SelectedText = "";
            this.txtTongSach.Size = new System.Drawing.Size(188, 28);
            this.txtTongSach.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderRadius = 10;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongTien.Location = new System.Drawing.Point(587, 81);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(188, 28);
            this.txtTongTien.TabIndex = 11;
            // 
            // dtNgayMua
            // 
            this.dtNgayMua.BackColor = System.Drawing.Color.AliceBlue;
            this.dtNgayMua.BorderRadius = 10;
            this.dtNgayMua.Checked = true;
            this.dtNgayMua.FillColor = System.Drawing.Color.AliceBlue;
            this.dtNgayMua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMua.Location = new System.Drawing.Point(176, 48);
            this.dtNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayMua.Name = "dtNgayMua";
            this.dtNgayMua.Size = new System.Drawing.Size(188, 28);
            this.dtNgayMua.TabIndex = 15;
            this.dtNgayMua.Value = new System.DateTime(2024, 10, 27, 0, 0, 0, 0);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.BorderRadius = 10;
            this.txtThoiGian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGian.DefaultText = "";
            this.txtThoiGian.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThoiGian.Location = new System.Drawing.Point(176, 81);
            this.txtThoiGian.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.PlaceholderText = "";
            this.txtThoiGian.SelectedText = "";
            this.txtThoiGian.Size = new System.Drawing.Size(188, 28);
            this.txtThoiGian.TabIndex = 17;
            // 
            // groupBoxttdon
            // 
            this.groupBoxttdon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.groupBoxttdon.Controls.Add(this.txtThoiGian);
            this.groupBoxttdon.Controls.Add(this.dtNgayMua);
            this.groupBoxttdon.Controls.Add(this.txtTongTien);
            this.groupBoxttdon.Controls.Add(this.txtTongSach);
            this.groupBoxttdon.Controls.Add(this.label7);
            this.groupBoxttdon.Controls.Add(this.label8);
            this.groupBoxttdon.Controls.Add(this.label4);
            this.groupBoxttdon.Controls.Add(this.label3);
            this.groupBoxttdon.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.groupBoxttdon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxttdon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxttdon.Location = new System.Drawing.Point(28, 99);
            this.groupBoxttdon.Name = "groupBoxttdon";
            this.groupBoxttdon.Size = new System.Drawing.Size(861, 117);
            this.groupBoxttdon.TabIndex = 1;
            this.groupBoxttdon.Text = "Thông tin đơn hàng";
            // 
            // LichSuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnInLichSu);
            this.Controls.Add(this.groupBoxTTS);
            this.Controls.Add(this.groupBoxCTDH);
            this.Controls.Add(this.groupBoxDSDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxttdon);
            this.Name = "LichSuMua";
            this.Size = new System.Drawing.Size(1298, 791);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).EndInit();
            this.groupBoxTTS.ResumeLayout(false);
            this.groupBoxTTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBoxCTDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.groupBoxDSDH.ResumeLayout(false);
            this.groupBoxttdon.ResumeLayout(false);
            this.groupBoxttdon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private Guna2Button button1;
        private Guna2DateTimePicker dtTuNgay;
        private Guna2DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna2TextBox txtGiaTu;
        private Guna2TextBox txtGiaDen;
        private System.Windows.Forms.Label label16;
        private Guna2Panel panel1;
        private Guna2Button btnInLichSu;
        private Guna2Button btnQuayLai;
        private Guna2Button btnShowAll;
        private Guna2PictureBox ptbAnhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbLanXB;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Label lbTGPhatHanh;
        private System.Windows.Forms.Label label13;
        private Guna2Button button2;
        private Guna2GroupBox groupBoxTTS;
        private Guna2DataGridView dgvCTHD;
        private Guna2GroupBox groupBoxCTDH;
        private Guna2DataGridView dgvHD;
        private Guna2GroupBox groupBoxDSDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna2TextBox txtTongSach;
        private Guna2TextBox txtTongTien;
        private Guna2DateTimePicker dtNgayMua;
        private Guna2TextBox txtThoiGian;
        private Guna2GroupBox groupBoxttdon;
    }
}