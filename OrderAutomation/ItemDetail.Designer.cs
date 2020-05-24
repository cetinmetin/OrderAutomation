namespace OrderAutomation
{
    partial class ItemDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetail));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbItemDescription = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(674, 12);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 20;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(593, 349);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 48;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(504, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Adet";
            // 
            // itemQuantity
            // 
            this.itemQuantity.Location = new System.Drawing.Point(554, 350);
            this.itemQuantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.itemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(33, 20);
            this.itemQuantity.TabIndex = 46;
            this.itemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemQuantity.ValueChanged += new System.EventHandler(this.itemQuantity_ValueChanged);
            // 
            // lbItemDescription
            // 
            this.lbItemDescription.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbItemDescription.Location = new System.Drawing.Point(338, 91);
            this.lbItemDescription.Name = "lbItemDescription";
            this.lbItemDescription.Size = new System.Drawing.Size(359, 255);
            this.lbItemDescription.TabIndex = 45;
            this.lbItemDescription.Text = "Erkek çizgili GömlEk";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbItemName.Location = new System.Drawing.Point(337, 50);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(224, 30);
            this.lbItemName.TabIndex = 44;
            this.lbItemName.Text = "Erkek çizgili Gömlek ";
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(97, 12);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(225, 372);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 43;
            this.pbMain.TabStop = false;
            this.pbMain.Tag = "1";
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 399);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemQuantity);
            this.Controls.Add(this.lbItemDescription);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDetail";
            this.Load += new System.EventHandler(this.ItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown itemQuantity;
        private System.Windows.Forms.Label lbItemDescription;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.PictureBox pbMain;
    }
}