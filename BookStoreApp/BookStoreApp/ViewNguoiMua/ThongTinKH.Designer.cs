using Guna.UI2.WinForms;
using System.Drawing;
namespace BookStoreApp.ViewNguoiMua
{
    partial class ThongTinKH
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtGioiTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnXoaAnh = new Guna.UI2.WinForms.Guna2Button();
            this.ptbAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoi = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(450, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 32);
            this.label3.TabIndex = 117;
            this.label3.Text = "Thông Tin Người Dùng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtDiaChi.BorderRadius = 5;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(650, 280);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(300, 35);
            this.txtDiaChi.TabIndex = 114;
            this.txtDiaChi.Enter += new System.EventHandler(this.txtDiaChi_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(500, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 113;
            this.label1.Text = "Giới tính:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.dtNgaySinh.BorderRadius = 5;
            this.dtNgaySinh.Checked = true;
            this.dtNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(650, 190);
            this.dtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(300, 35);
            this.dtNgaySinh.TabIndex = 111;
            this.dtNgaySinh.Value = new System.DateTime(2025, 5, 5, 22, 52, 55, 464);
            // 
            // btnAnh
            // 
            this.btnAnh.BorderRadius = 10;
            this.btnAnh.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.ForeColor = System.Drawing.Color.White;
            this.btnAnh.Location = new System.Drawing.Point(150, 340);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(120, 40);
            this.btnAnh.TabIndex = 109;
            this.btnAnh.Text = "Thay ảnh";
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(725, 340);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(225, 40);
            this.btnCapNhat.TabIndex = 107;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtGioiTinh.BorderRadius = 5;
            this.txtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiTinh.DefaultText = "";
            this.txtGioiTinh.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(650, 135);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.PlaceholderText = "";
            this.txtGioiTinh.SelectedText = "";
            this.txtGioiTinh.Size = new System.Drawing.Size(300, 35);
            this.txtGioiTinh.TabIndex = 106;
            this.txtGioiTinh.Enter += new System.EventHandler(this.txtGioiTinh_Enter);
            this.txtGioiTinh.Leave += new System.EventHandler(this.txtGioiTinh_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtSDT.BorderRadius = 5;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(650, 235);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(300, 35);
            this.txtSDT.TabIndex = 105;
            this.txtSDT.Enter += new System.EventHandler(this.txtSDT_Enter);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtHoTen.BorderRadius = 5;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(650, 80);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(300, 35);
            this.txtHoTen.TabIndex = 104;
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(500, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 94;
            this.label12.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(500, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 93;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(500, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(500, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "Họ và tên:";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderRadius = 10;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnXoaAnh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtNgaySinh);
            this.panel1.Controls.Add(this.btnAnh);
            this.panel1.Controls.Add(this.ptbAnh);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txtGioiTinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 400);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 25);
            this.toolStrip1.TabIndex = 119;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.BorderRadius = 10;
            this.btnXoaAnh.Enabled = false;
            this.btnXoaAnh.FillColor = System.Drawing.Color.LightCoral;
            this.btnXoaAnh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.ForeColor = System.Drawing.Color.White;
            this.btnXoaAnh.Location = new System.Drawing.Point(300, 340);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(120, 40);
            this.btnXoaAnh.TabIndex = 118;
            this.btnXoaAnh.Text = "Xóa Ảnh";
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // ptbAnh
            // 
            this.ptbAnh.BorderRadius = 65;
            this.ptbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAnh.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ptbAnh.ImageRotate = 0F;
            this.ptbAnh.Location = new System.Drawing.Point(200, 80);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(180, 180);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 108;
            this.ptbAnh.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(377, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 23);
            this.label17.TabIndex = 99;
            this.label17.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtMatKhau.BorderRadius = 5;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(550, 117);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 35);
            this.txtMatKhau.TabIndex = 102;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(377, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 23);
            this.label16.TabIndex = 98;
            this.label16.Text = "Tên tài đăng nhập:";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.Enabled = false;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(550, 65);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(250, 35);
            this.txtUserName.TabIndex = 103;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BorderRadius = 10;
            this.btnDoiMK.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Location = new System.Drawing.Point(650, 160);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(184, 40);
            this.btnDoiMK.TabIndex = 115;
            this.btnDoiMK.Text = "Lưu Mật Khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(450, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 116;
            this.label2.Text = "Thông Tin Đăng Nhập";
            // 
            // btnDoi
            // 
            this.btnDoi.BorderRadius = 10;
            this.btnDoi.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoi.ForeColor = System.Drawing.Color.White;
            this.btnDoi.Location = new System.Drawing.Point(414, 160);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(186, 40);
            this.btnDoi.TabIndex = 118;
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderRadius = 10;
            this.panel2.BorderThickness = 1;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnDoi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDoiMK);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label17);
            this.panel2.FillColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(20, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 300);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BookStoreApp.Properties.Resources.mat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(806, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 121;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinKH";
            this.Size = new System.Drawing.Size(1200, 782);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgaySinh;
        private Guna.UI2.WinForms.Guna2Button btnAnh;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAnh;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnXoaAnh;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDoi;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}