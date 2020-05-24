namespace OrderAutomation
{
    partial class BuyItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyItem));
            this.pbFormClose = new System.Windows.Forms.PictureBox();
            this.checkCard = new System.Windows.Forms.CheckBox();
            this.checkCash = new System.Windows.Forms.CheckBox();
            this.checkCheck = new System.Windows.Forms.CheckBox();
            this.groupCard = new System.Windows.Forms.GroupBox();
            this.lbAmountCard = new System.Windows.Forms.Label();
            this.tbCVV = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCard = new System.Windows.Forms.Label();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.groupCash = new System.Windows.Forms.GroupBox();
            this.lbAmountCash = new System.Windows.Forms.Label();
            this.lbCash = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.groupCheck = new System.Windows.Forms.GroupBox();
            this.tbBankID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAmountCheck = new System.Windows.Forms.Label();
            this.lbCheck = new System.Windows.Forms.Label();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbRemaining = new System.Windows.Forms.Label();
            this.AdresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).BeginInit();
            this.groupCard.SuspendLayout();
            this.groupCash.SuspendLayout();
            this.groupCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFormClose
            // 
            this.pbFormClose.Image = ((System.Drawing.Image)(resources.GetObject("pbFormClose.Image")));
            this.pbFormClose.Location = new System.Drawing.Point(912, 12);
            this.pbFormClose.Name = "pbFormClose";
            this.pbFormClose.Size = new System.Drawing.Size(24, 24);
            this.pbFormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormClose.TabIndex = 21;
            this.pbFormClose.TabStop = false;
            this.pbFormClose.Click += new System.EventHandler(this.pbFormClose_Click);
            this.pbFormClose.MouseEnter += new System.EventHandler(this.CursorEnterHand);
            this.pbFormClose.MouseLeave += new System.EventHandler(this.CursorLeaveArrow);
            // 
            // checkCard
            // 
            this.checkCard.AutoSize = true;
            this.checkCard.Location = new System.Drawing.Point(12, 29);
            this.checkCard.Name = "checkCard";
            this.checkCard.Size = new System.Drawing.Size(124, 17);
            this.checkCard.TabIndex = 22;
            this.checkCard.Text = "Kredi Kartıyla Ödeme";
            this.checkCard.UseVisualStyleBackColor = true;
            this.checkCard.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // checkCash
            // 
            this.checkCash.AutoSize = true;
            this.checkCash.Location = new System.Drawing.Point(322, 29);
            this.checkCash.Name = "checkCash";
            this.checkCash.Size = new System.Drawing.Size(88, 17);
            this.checkCash.TabIndex = 23;
            this.checkCash.Text = "Nakit Ödeme";
            this.checkCash.UseVisualStyleBackColor = true;
            this.checkCash.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // checkCheck
            // 
            this.checkCheck.AutoSize = true;
            this.checkCheck.Location = new System.Drawing.Point(632, 29);
            this.checkCheck.Name = "checkCheck";
            this.checkCheck.Size = new System.Drawing.Size(95, 17);
            this.checkCheck.TabIndex = 24;
            this.checkCheck.Text = "Çek ile Ödeme";
            this.checkCheck.UseVisualStyleBackColor = true;
            this.checkCheck.CheckedChanged += new System.EventHandler(this.CheckedChange);
            // 
            // groupCard
            // 
            this.groupCard.Controls.Add(this.lbAmountCard);
            this.groupCard.Controls.Add(this.tbCVV);
            this.groupCard.Controls.Add(this.label3);
            this.groupCard.Controls.Add(this.tbExpirationDate);
            this.groupCard.Controls.Add(this.label2);
            this.groupCard.Controls.Add(this.tbCardNumber);
            this.groupCard.Controls.Add(this.label1);
            this.groupCard.Controls.Add(this.lbCard);
            this.groupCard.Controls.Add(this.tbCard);
            this.groupCard.Location = new System.Drawing.Point(12, 52);
            this.groupCard.Name = "groupCard";
            this.groupCard.Size = new System.Drawing.Size(304, 165);
            this.groupCard.TabIndex = 28;
            this.groupCard.TabStop = false;
            this.groupCard.Text = "Kart İle Ödeme";
            this.groupCard.Visible = false;
            // 
            // lbAmountCard
            // 
            this.lbAmountCard.AutoSize = true;
            this.lbAmountCard.Location = new System.Drawing.Point(69, 149);
            this.lbAmountCard.Name = "lbAmountCard";
            this.lbAmountCard.Size = new System.Drawing.Size(137, 13);
            this.lbAmountCard.TabIndex = 34;
            this.lbAmountCard.Text = "ÖDENECEK MİKTAR = 0 ₺";
            // 
            // tbCVV
            // 
            this.tbCVV.Location = new System.Drawing.Point(240, 107);
            this.tbCVV.Mask = "999";
            this.tbCVV.Name = "tbCVV";
            this.tbCVV.Size = new System.Drawing.Size(26, 20);
            this.tbCVV.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "CVV :";
            // 
            // tbExpirationDate
            // 
            this.tbExpirationDate.Location = new System.Drawing.Point(136, 107);
            this.tbExpirationDate.Mask = "00/0000";
            this.tbExpirationDate.Name = "tbExpirationDate";
            this.tbExpirationDate.Size = new System.Drawing.Size(55, 20);
            this.tbExpirationDate.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Son Kullanma Tarihi :";
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(136, 77);
            this.tbCardNumber.Mask = "9999-9999-9999-9999";
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(130, 20);
            this.tbCardNumber.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kart Numarası :";
            // 
            // lbCard
            // 
            this.lbCard.AutoSize = true;
            this.lbCard.Location = new System.Drawing.Point(6, 31);
            this.lbCard.Name = "lbCard";
            this.lbCard.Size = new System.Drawing.Size(168, 13);
            this.lbCard.TabIndex = 31;
            this.lbCard.Text = "Ödemek istediğiniz miktarı Giriniz : ";
            // 
            // tbCard
            // 
            this.tbCard.Location = new System.Drawing.Point(180, 28);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(100, 20);
            this.tbCard.TabIndex = 31;
            this.tbCard.TextChanged += new System.EventHandler(this.tbCard_TextChanged);
            // 
            // groupCash
            // 
            this.groupCash.Controls.Add(this.lbAmountCash);
            this.groupCash.Controls.Add(this.lbCash);
            this.groupCash.Controls.Add(this.tbCash);
            this.groupCash.Location = new System.Drawing.Point(322, 52);
            this.groupCash.Name = "groupCash";
            this.groupCash.Size = new System.Drawing.Size(304, 165);
            this.groupCash.TabIndex = 29;
            this.groupCash.TabStop = false;
            this.groupCash.Text = "Nakit Ödeme";
            this.groupCash.Visible = false;
            // 
            // lbAmountCash
            // 
            this.lbAmountCash.AutoSize = true;
            this.lbAmountCash.Location = new System.Drawing.Point(82, 149);
            this.lbAmountCash.Name = "lbAmountCash";
            this.lbAmountCash.Size = new System.Drawing.Size(137, 13);
            this.lbAmountCash.TabIndex = 32;
            this.lbAmountCash.Text = "ÖDENECEK MİKTAR = 0 ₺";
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.Location = new System.Drawing.Point(6, 31);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(168, 13);
            this.lbCash.TabIndex = 31;
            this.lbCash.Text = "Ödemek istediğiniz miktarı Giriniz : ";
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(180, 28);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(100, 20);
            this.tbCash.TabIndex = 31;
            this.tbCash.TextChanged += new System.EventHandler(this.tbCash_TextChanged);
            // 
            // groupCheck
            // 
            this.groupCheck.Controls.Add(this.tbBankID);
            this.groupCheck.Controls.Add(this.label4);
            this.groupCheck.Controls.Add(this.lbAmountCheck);
            this.groupCheck.Controls.Add(this.lbCheck);
            this.groupCheck.Controls.Add(this.tbCheck);
            this.groupCheck.Location = new System.Drawing.Point(632, 52);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Size = new System.Drawing.Size(304, 165);
            this.groupCheck.TabIndex = 30;
            this.groupCheck.TabStop = false;
            this.groupCheck.Text = "Çek İle Ödeme";
            this.groupCheck.Visible = false;
            // 
            // tbBankID
            // 
            this.tbBankID.Location = new System.Drawing.Point(145, 77);
            this.tbBankID.Name = "tbBankID";
            this.tbBankID.Size = new System.Drawing.Size(100, 20);
            this.tbBankID.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Banka Numarası : ";
            // 
            // lbAmountCheck
            // 
            this.lbAmountCheck.AutoSize = true;
            this.lbAmountCheck.Location = new System.Drawing.Point(93, 149);
            this.lbAmountCheck.Name = "lbAmountCheck";
            this.lbAmountCheck.Size = new System.Drawing.Size(137, 13);
            this.lbAmountCheck.TabIndex = 33;
            this.lbAmountCheck.Text = "ÖDENECEK MİKTAR = 0 ₺";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(6, 31);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(168, 13);
            this.lbCheck.TabIndex = 31;
            this.lbCheck.Text = "Ödemek istediğiniz miktarı Giriniz : ";
            // 
            // tbCheck
            // 
            this.tbCheck.Location = new System.Drawing.Point(180, 28);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(100, 20);
            this.tbCheck.TabIndex = 31;
            this.tbCheck.TextChanged += new System.EventHandler(this.tbCheck_TextChanged);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(363, 234);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(239, 13);
            this.lbAmount.TabIndex = 31;
            this.lbAmount.Text = "TOPLAM ÖDENMESİ GEREKEN TUTAR = 131 ";
            this.lbAmount.Visible = false;
            // 
            // lbRemaining
            // 
            this.lbRemaining.AutoSize = true;
            this.lbRemaining.Location = new System.Drawing.Point(427, 256);
            this.lbRemaining.Name = "lbRemaining";
            this.lbRemaining.Size = new System.Drawing.Size(109, 13);
            this.lbRemaining.TabIndex = 32;
            this.lbRemaining.Text = "KALAN TUTAR = 21 ";
            this.lbRemaining.Visible = false;
            // 
            // AdresPanel
            // 
            this.AdresPanel.Location = new System.Drawing.Point(12, 293);
            this.AdresPanel.Name = "AdresPanel";
            this.AdresPanel.Size = new System.Drawing.Size(923, 173);
            this.AdresPanel.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Adres Seçiniz";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(860, 475);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 35;
            this.btnBuy.Text = "Ödeme Yap";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // 
            // BuyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 505);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdresPanel);
            this.Controls.Add(this.lbRemaining);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.groupCheck);
            this.Controls.Add(this.groupCash);
            this.Controls.Add(this.groupCard);
            this.Controls.Add(this.checkCheck);
            this.Controls.Add(this.checkCash);
            this.Controls.Add(this.checkCard);
            this.Controls.Add(this.pbFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyItem";
            this.Load += new System.EventHandler(this.BuyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormClose)).EndInit();
            this.groupCard.ResumeLayout(false);
            this.groupCard.PerformLayout();
            this.groupCash.ResumeLayout(false);
            this.groupCash.PerformLayout();
            this.groupCheck.ResumeLayout(false);
            this.groupCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFormClose;
        private System.Windows.Forms.CheckBox checkCard;
        private System.Windows.Forms.CheckBox checkCash;
        private System.Windows.Forms.CheckBox checkCheck;
        private System.Windows.Forms.GroupBox groupCard;
        private System.Windows.Forms.Label lbCard;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.GroupBox groupCash;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.GroupBox groupCheck;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.TextBox tbCheck;
        private System.Windows.Forms.Label lbAmountCard;
        private System.Windows.Forms.MaskedTextBox tbCVV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbExpirationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAmountCash;
        private System.Windows.Forms.TextBox tbBankID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAmountCheck;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbRemaining;
        private System.Windows.Forms.FlowLayoutPanel AdresPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuy;
    }
}