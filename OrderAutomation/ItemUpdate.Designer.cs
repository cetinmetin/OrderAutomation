namespace OrderAutomation
{
    partial class ItemUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUpdate));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.ItemTable = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(1333, 15);
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
            // ItemTable
            // 
            this.ItemTable.HideSelection = false;
            this.ItemTable.Location = new System.Drawing.Point(24, 70);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.Size = new System.Drawing.Size(1360, 788);
            this.ItemTable.TabIndex = 24;
            this.ItemTable.UseCompatibleStateImageBehavior = false;
            this.ItemTable.DoubleClick += new System.EventHandler(this.ItemTable_DoubleClick);
            // 
            // ItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 878);
            this.Controls.Add(this.ItemTable);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemUpdate";
            this.Load += new System.EventHandler(this.ItemUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.ListView ItemTable;
    }
}