namespace OrderAutomation
{
    partial class ItemRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemRemove));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.ItemTable = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(1324, 15);
            this.pbFormClose.Margin = new System.Windows.Forms.Padding(6);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(48, 46);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 22;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // ItemTable
            // 
            this.ItemTable.HideSelection = false;
            this.ItemTable.Location = new System.Drawing.Point(12, 105);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.Size = new System.Drawing.Size(1360, 788);
            this.ItemTable.TabIndex = 23;
            this.ItemTable.UseCompatibleStateImageBehavior = false;
            this.ItemTable.DoubleClick += new System.EventHandler(this.ItemTable_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "Silmek İstediğiniz Ürüne Çift Tıklayın.";
            // 
            // ItemRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 915);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemTable);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemRemove";
            this.Load += new System.EventHandler(this.ItemRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.ListView ItemTable;
        private System.Windows.Forms.Label label1;
    }
}