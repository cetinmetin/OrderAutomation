namespace OrderAutomation
{
    partial class UserOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre : ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(118, 52);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon Numarası : ";
            // 
            // maskedPhone
            // 
            this.maskedPhone.Location = new System.Drawing.Point(118, 80);
            this.maskedPhone.Mask = "+90(999) 000-0000";
            this.maskedPhone.Name = "maskedPhone";
            this.maskedPhone.Size = new System.Drawing.Size(100, 20);
            this.maskedPhone.TabIndex = 9;
            this.maskedPhone.Text = "90";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(257, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 82);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.Location = new System.Drawing.Point(224, 51);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(24, 24);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 21;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(466, 12);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 22;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pbFormClose_MouseLeave);
            this.pbFormClose.MouseHover += new System.EventHandler(this.pbFormClose_MouseHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 362);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // UserOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 496);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbFormClose);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.maskedPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOperation";
            this.Load += new System.EventHandler(this.UserOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}