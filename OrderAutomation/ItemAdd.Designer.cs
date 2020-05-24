namespace OrderAutomation
{
    partial class ItemAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAdd));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.tbItemWeight = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.cbItemTax = new System.Windows.Forms.ComboBox();
            this.btnItemSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(1349, 15);
            this.pbFormClose.Margin = new System.Windows.Forms.Padding(6);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(48, 46);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 21;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ürün İsmini Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vergisiz Fiyatını Giriniz : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Açıklama Giriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ağırlığını Giriniz :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vergi Seçiniz :";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(267, 39);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(249, 31);
            this.tbItemName.TabIndex = 28;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(267, 112);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(249, 31);
            this.tbItemPrice.TabIndex = 29;
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.Location = new System.Drawing.Point(267, 182);
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(249, 31);
            this.tbItemDescription.TabIndex = 30;
            // 
            // tbItemWeight
            // 
            this.tbItemWeight.Location = new System.Drawing.Point(748, 79);
            this.tbItemWeight.Name = "tbItemWeight";
            this.tbItemWeight.Size = new System.Drawing.Size(249, 31);
            this.tbItemWeight.TabIndex = 31;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPicture.Image")));
            this.btnAddPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPicture.Location = new System.Drawing.Point(82, 292);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(294, 178);
            this.btnAddPicture.TabIndex = 40;
            this.btnAddPicture.Text = "Fotoğraf Ekle";
            this.btnAddPicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnPicture1_Click);
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
            this.cbItemTax.Location = new System.Drawing.Point(748, 146);
            this.cbItemTax.Name = "cbItemTax";
            this.cbItemTax.Size = new System.Drawing.Size(249, 33);
            this.cbItemTax.TabIndex = 42;
            // 
            // btnItemSave
            // 
            this.btnItemSave.Location = new System.Drawing.Point(1179, 843);
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.Size = new System.Drawing.Size(146, 107);
            this.btnItemSave.TabIndex = 43;
            this.btnItemSave.Text = "Kaydet";
            this.btnItemSave.UseVisualStyleBackColor = true;
            this.btnItemSave.Click += new System.EventHandler(this.btnItemSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(493, 255);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(871, 530);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePicture.Image")));
            this.btnRemovePicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePicture.Location = new System.Drawing.Point(82, 500);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(294, 178);
            this.btnRemovePicture.TabIndex = 45;
            this.btnRemovePicture.Text = "Fotoğrafları Sil";
            this.btnRemovePicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1003, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "₺";
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 982);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnItemSave);
            this.Controls.Add(this.cbItemTax);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.tbItemWeight);
            this.Controls.Add(this.tbItemDescription);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemAdd";
            this.Load += new System.EventHandler(this.ItemAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.TextBox tbItemWeight;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.ComboBox cbItemTax;
        private System.Windows.Forms.Button btnItemSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}