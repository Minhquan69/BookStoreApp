using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace BookStoreApp.Sign
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnh = new Guna.UI2.WinForms.Guna2Button(); // Đổi thành Guna2Button
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox(); // Đổi thành Guna2TextBox
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox(); // Đổi thành Guna2TextBox
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox(); // Đổi thành Guna2TextBox
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordComfirm = new Guna.UI2.WinForms.Guna2TextBox(); // Đổi thành Guna2TextBox
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button(); // Đổi thành Guna2Button
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button(); // Đổi thành Guna2Button
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox(); // Đổi thành Guna2TextBox
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();

            // 
            // button2 (Giữ nguyên)
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(461, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 24);
            this.button2.TabIndex = 146;
            this.button2.UseVisualStyleBackColor = true;

            // 
            // btnAnh (Guna2Button)
            // 
            this.btnAnh.BorderRadius = 10;
            this.btnAnh.CheckedState.Parent = this.btnAnh;
            this.btnAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnh.CustomImages.Parent = this.btnAnh;
            this.btnAnh.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnh.ForeColor = System.Drawing.Color.White;
            this.btnAnh.HoverState.Parent = this.btnAnh;
            this.btnAnh.Location = new System.Drawing.Point(64, 306);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.ShadowDecoration.Parent = this.btnAnh;
            this.btnAnh.Size = new System.Drawing.Size(80, 34);
            this.btnAnh.TabIndex = 126;
            this.btnAnh.Text = "Ảnh";

            // 
            // radioButtonNu (Giữ nguyên)
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.BackColor = System.Drawing.Color.White;
            this.radioButtonNu.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNu.Location = new System.Drawing.Point(838, 104);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(45, 20);
            this.radioButtonNu.TabIndex = 128;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = false;

            // 
            // radioButtonNam (Giữ nguyên)
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.BackColor = System.Drawing.Color.White;
            this.radioButtonNam.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNam.Location = new System.Drawing.Point(681, 103);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(57, 20);
            this.radioButtonNam.TabIndex = 127;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = false;

            // 
            // errorProvider (Giữ nguyên)
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // button1 (Giữ nguyên)
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(461, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 145;
            this.button1.UseVisualStyleBackColor = true;

            // 
            // label12 (Giữ nguyên)
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(440, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 35);
            this.label12.TabIndex = 143;
            this.label12.Text = "Đăng ký";

            // 
            // dtpDate (Giữ nguyên)
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(681, 279);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(283, 22);
            this.dtpDate.TabIndex = 132;

            // 
            // txtAddress (Guna2TextBox)
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtAddress.Location = new System.Drawing.Point(681, 218);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Nhập địa chỉ";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(283, 36);
            this.txtAddress.TabIndex = 131;

            // 
            // txtPhoneNumber (Guna2TextBox)
            // 
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPhoneNumber.BorderRadius = 10;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPhoneNumber.Location = new System.Drawing.Point(209, 100);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(283, 36);
            this.txtPhoneNumber.TabIndex = 123;

            // 
            // txtFullName (Guna2TextBox)
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtFullName.Location = new System.Drawing.Point(681, 160);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "Nhập họ và tên";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(283, 36);
            this.txtFullName.TabIndex = 129;

            // 
            // label11 (Giữ nguyên)
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Constantia", 12F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(155, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 142;
            this.label11.Text = "Thông tin tài khoản";

            // 
            // label10 (Giữ nguyên)
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(186)))));
            this.label10.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(541, 287);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 141;
            this.label10.Text = "Ngày sinh:";

            // 
            // label9 (Giữ nguyên)
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(186)))));
            this.label9.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(541, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 140;
            this.label9.Text = "Địa chỉ:";

            // 
            // label8 (Giữ nguyên)
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(60, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 139;
            this.label8.Text = "Số điện thoai:";

            // 
            // label6 (Giữ nguyên)
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(186)))));
            this.label6.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 138;
            this.label6.Text = "Họ và tên:";

            // 
            // label5 (Giữ nguyên)
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(186)))));
            this.label5.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(541, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 137;
            this.label5.Text = "Giới tính";

            // 
            // label4 (Giữ nguyên)
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(677, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 24);
            this.label4.TabIndex = 136;
            this.label4.Text = "Thông tin người dùng";

            // 
            // txtPasswordComfirm (Guna2TextBox)
            // 
            this.txtPasswordComfirm.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPasswordComfirm.BorderRadius = 10;
            this.txtPasswordComfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordComfirm.DefaultText = "";
            this.txtPasswordComfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPasswordComfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPasswordComfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPasswordComfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPasswordComfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPasswordComfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordComfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPasswordComfirm.Location = new System.Drawing.Point(209, 218);
            this.txtPasswordComfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordComfirm.Name = "txtPasswordComfirm";
            this.txtPasswordComfirm.PasswordChar = '●';
            this.txtPasswordComfirm.PlaceholderText = "Nhập lại mật khẩu";
            this.txtPasswordComfirm.SelectedText = "";
            this.txtPasswordComfirm.Size = new System.Drawing.Size(283, 36);
            this.txtPasswordComfirm.TabIndex = 125;
            this.txtPasswordComfirm.UseSystemPasswordChar = true;

            // 
            // label3 (Giữ nguyên)
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 135;
            this.label3.Text = "Nhập lại mật khẩu:";

            // 
            // btnHuy (Guna2Button)
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderThickness = 2;
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Location = new System.Drawing.Point(545, 457);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(137, 48);
            this.btnHuy.TabIndex = 133;
            this.btnHuy.Text = "Hủy bỏ";

            // 
            // btnSignUp (Guna2Button)
            // 
            this.btnSignUp.BorderRadius = 10;
            this.btnSignUp.CheckedState.Parent = this.btnSignUp;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.CustomImages.Parent = this.btnSignUp;
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnSignUp.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.FillColor = System.Drawing.Color.FromArgb(0, 85, 153);
            this.btnSignUp.HoverState.Parent = this.btnSignUp;
            this.btnSignUp.Location = new System.Drawing.Point(342, 457);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.ShadowDecoration.Parent = this.btnSignUp;
            this.btnSignUp.Size = new System.Drawing.Size(137, 48);
            this.btnSignUp.TabIndex = 134;
            this.btnSignUp.Text = "Đăng ký";

            // 
            // txtPassword (Guna2TextBox)
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.txtPassword.Location = new System.Drawing.Point(209, 157);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Nhập mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(283, 36);
            this.txtPassword.TabIndex = 124;
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // label2 (Giữ nguyên)
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 130;
            this.label2.Text = "Mật khẩu:";

            // 
            // pictureBoxAvatar (Giữ nguyên)
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(209, 279);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(212, 160);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 144;
            this.pictureBoxAvatar.TabStop = false;

            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordComfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1009, 521);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2Button btnAnh;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordComfirm;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}