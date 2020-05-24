namespace OrderAutomation
{
    partial class SelectedItemUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedItemUpdate));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.btnPicture1 = new System.Windows.Forms.Button();
            this.btnPicture2 = new System.Windows.Forms.Button();
            this.btnPicture3 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbItemTax = new System.Windows.Forms.ComboBox();
            this.tbItemWeight = new System.Windows.Forms.TextBox();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPicture2 = new System.Windows.Forms.Label();
            this.lbPicture3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(978, 15);
            this.pbFormClose.Margin = new System.Windows.Forms.Padding(6);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(48, 46);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 23;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnPicture1
            // 
            this.btnPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture1.Location = new System.Drawing.Point(12, 41);
            this.btnPicture1.Name = "btnPicture1";
            this.btnPicture1.Size = new System.Drawing.Size(276, 464);
            this.btnPicture1.TabIndex = 24;
            this.btnPicture1.Tag = "0";
            this.btnPicture1.UseVisualStyleBackColor = true;
            this.btnPicture1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPicture2
            // 
            this.btnPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture2.Location = new System.Drawing.Point(352, 41);
            this.btnPicture2.Name = "btnPicture2";
            this.btnPicture2.Size = new System.Drawing.Size(276, 464);
            this.btnPicture2.TabIndex = 25;
            this.btnPicture2.Tag = "1";
            this.btnPicture2.UseVisualStyleBackColor = true;
            this.btnPicture2.Visible = false;
            this.btnPicture2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPicture3
            // 
            this.btnPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture3.Location = new System.Drawing.Point(692, 41);
            this.btnPicture3.Name = "btnPicture3";
            this.btnPicture3.Size = new System.Drawing.Size(276, 464);
            this.btnPicture3.TabIndex = 26;
            this.btnPicture3.Tag = "2";
            this.btnPicture3.UseVisualStyleBackColor = true;
            this.btnPicture3.Visible = false;
            this.btnPicture3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(56, 511);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(184, 76);
            this.btnDelete1.TabIndex = 27;
            this.btnDelete1.Tag = "0";
            this.btnDelete1.Text = "Güncelle";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(387, 511);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(184, 76);
            this.btnDelete2.TabIndex = 28;
            this.btnDelete2.Tag = "1";
            this.btnDelete2.Text = "SİL";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Visible = false;
            this.btnDelete2.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(736, 511);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(184, 76);
            this.btnDelete3.TabIndex = 29;
            this.btnDelete3.Tag = "2";
            this.btnDelete3.Text = "SİL";
            this.btnDelete3.UseVisualStyleBackColor = true;
            this.btnDelete3.Visible = false;
            this.btnDelete3.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 59;
            this.label7.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(991, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Kg";
            // 
            // cbItemTax
            // 
            this.cbItemTax.DisplayMember = "0,01";
            this.cbItemTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemTax.FormattingEnabled = true;
            this.cbItemTax.Items.AddRange(new object[] {
            "%1",
            "%8",
            "%18"});
            this.cbItemTax.Location = new System.Drawing.Point(739, 710);
            this.cbItemTax.Name = "cbItemTax";
            this.cbItemTax.Size = new System.Drawing.Size(249, 33);
            this.cbItemTax.TabIndex = 57;
            // 
            // tbItemWeight
            // 
            this.tbItemWeight.Location = new System.Drawing.Point(739, 643);
            this.tbItemWeight.Name = "tbItemWeight";
            this.tbItemWeight.Size = new System.Drawing.Size(249, 31);
            this.tbItemWeight.TabIndex = 56;
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Location = new System.Drawing.Point(258, 746);
            this.tbItemDescription.Multiline = true;
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(279, 125);
            this.tbItemDescription.TabIndex = 55;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(258, 676);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(249, 31);
            this.tbItemPrice.TabIndex = 54;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(258, 603);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(249, 31);
            this.tbItemName.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Vergi Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ağırlığını Giriniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 746);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Açıklama Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Vergisiz Fiyatını Giriniz : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ürün İsmini Giriniz : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(756, 781);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 90);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "1. Fotoğraf";
            // 
            // lbPicture2
            // 
            this.lbPicture2.AutoSize = true;
            this.lbPicture2.Location = new System.Drawing.Point(421, 9);
            this.lbPicture2.Name = "lbPicture2";
            this.lbPicture2.Size = new System.Drawing.Size(116, 25);
            this.lbPicture2.TabIndex = 62;
            this.lbPicture2.Text = "2. Fotoğraf";
            this.lbPicture2.Visible = false;
            // 
            // lbPicture3
            // 
            this.lbPicture3.AutoSize = true;
            this.lbPicture3.Location = new System.Drawing.Point(776, 9);
            this.lbPicture3.Name = "lbPicture3";
            this.lbPicture3.Size = new System.Drawing.Size(116, 25);
            this.lbPicture3.TabIndex = 63;
            this.lbPicture3.Text = "3. Fotoğraf";
            this.lbPicture3.Visible = false;
            // 
            // SelectedItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 912);
            this.Controls.Add(this.lbPicture3);
            this.Controls.Add(this.lbPicture2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbItemTax);
            this.Controls.Add(this.tbItemWeight);
            this.Controls.Add(this.tbItemDescription);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnPicture3);
            this.Controls.Add(this.btnPicture2);
            this.Controls.Add(this.btnPicture1);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectedItemUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectedItemUpdate";
            this.Load += new System.EventHandler(this.SelectedItemUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.Button btnPicture1;
        private System.Windows.Forms.Button btnPicture2;
        private System.Windows.Forms.Button btnPicture3;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbItemTax;
        private System.Windows.Forms.TextBox tbItemWeight;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPicture2;
        private System.Windows.Forms.Label lbPicture3;
    }
}