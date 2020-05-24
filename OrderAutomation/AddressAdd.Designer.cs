namespace OrderAutomation
{
    partial class AddressAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressAdd));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAddressLetterCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddressTitle = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTitle.Location = new System.Drawing.Point(6, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(426, 40);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAddressLetterCount
            // 
            this.lbAddressLetterCount.AutoSize = true;
            this.lbAddressLetterCount.Location = new System.Drawing.Point(299, 190);
            this.lbAddressLetterCount.Name = "lbAddressLetterCount";
            this.lbAddressLetterCount.Size = new System.Drawing.Size(36, 13);
            this.lbAddressLetterCount.TabIndex = 23;
            this.lbAddressLetterCount.Text = "0/200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Adres Başlığı : ";
            // 
            // tbAddressTitle
            // 
            this.tbAddressTitle.Location = new System.Drawing.Point(122, 82);
            this.tbAddressTitle.Name = "tbAddressTitle";
            this.tbAddressTitle.Size = new System.Drawing.Size(213, 20);
            this.tbAddressTitle.TabIndex = 20;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(122, 109);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.ShortcutsEnabled = false;
            this.tbAdress.Size = new System.Drawing.Size(213, 78);
            this.tbAdress.TabIndex = 21;
            this.tbAdress.Text = "";
            this.tbAdress.TextChanged += new System.EventHandler(this.tbAdress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adres : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(405, 12);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 25;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.pbFormClose_MouseLeave);
            this.pbFormClose.MouseHover += new System.EventHandler(this.pbFormClose_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(179, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AddressAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 240);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pbFormClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbAddressLetterCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAddressTitle);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddressAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressAdd";
            this.Load += new System.EventHandler(this.AddressAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAddressLetterCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAddressTitle;
        private System.Windows.Forms.RichTextBox tbAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.Button btnRemove;
    }
}