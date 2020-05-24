namespace OrderAutomation
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.maskedPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbAdress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddressTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAddressLetterCount = new System.Windows.Forms.Label();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(210, 47);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(210, 73);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre : ";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(210, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre Tekrar : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ad Soyad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon Numarası : ";
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Location = new System.Drawing.Point(210, 125);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.PasswordChar = '•';
            this.tbPasswordAgain.ShortcutsEnabled = false;
            this.tbPasswordAgain.Size = new System.Drawing.Size(100, 20);
            this.tbPasswordAgain.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adres : ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(210, 288);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // maskedPhone
            // 
            this.maskedPhone.Location = new System.Drawing.Point(210, 151);
            this.maskedPhone.Mask = "+90(999) 000-0000";
            this.maskedPhone.Name = "maskedPhone";
            this.maskedPhone.Size = new System.Drawing.Size(100, 20);
            this.maskedPhone.TabIndex = 8;
            this.maskedPhone.Text = "90";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(210, 204);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.ShortcutsEnabled = false;
            this.tbAdress.Size = new System.Drawing.Size(213, 78);
            this.tbAdress.TabIndex = 10;
            this.tbAdress.Text = "";
            this.tbAdress.TextChanged += new System.EventHandler(this.tbAdress_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(510, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kayıt Ol";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddressTitle
            // 
            this.tbAddressTitle.Location = new System.Drawing.Point(210, 177);
            this.tbAddressTitle.Name = "tbAddressTitle";
            this.tbAddressTitle.Size = new System.Drawing.Size(213, 20);
            this.tbAddressTitle.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Adres Başlığı : ";
            // 
            // lbAddressLetterCount
            // 
            this.lbAddressLetterCount.AutoSize = true;
            this.lbAddressLetterCount.Location = new System.Drawing.Point(387, 285);
            this.lbAddressLetterCount.Name = "lbAddressLetterCount";
            this.lbAddressLetterCount.Size = new System.Drawing.Size(36, 13);
            this.lbAddressLetterCount.TabIndex = 18;
            this.lbAddressLetterCount.Text = "0/200";
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(497, 10);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 19;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbFormClose.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.Location = new System.Drawing.Point(316, 99);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(24, 24);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 20;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.pbFormClose);
            this.Controls.Add(this.lbAddressLetterCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAddressTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.maskedPhone);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPasswordAgain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox maskedPhone;
        private System.Windows.Forms.RichTextBox tbAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddressTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAddressLetterCount;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.PictureBox pbShowPassword;
    }
}