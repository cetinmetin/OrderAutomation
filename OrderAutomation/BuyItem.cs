using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class BuyItem : Form
    {
        public BuyItem()
        {
            InitializeComponent();
        }
        public User User;
        public Item Item;
        public int Quantity;
        Button lastBtn;
        double amount,CardQuantity = 0, CashQuantity = 0, CheckQuantity = 0, totalTextBox = 0;
        int paymentCount = 0,AddressID=-1;
     
        void getDataForlb()
        {
            lbAmountCard.Text = "ÖDENECEK MİKTAR = " + amount + " ₺";
            lbAmountCash.Text = "ÖDENECEK MİKTAR = " + amount + " ₺";
            lbAmountCheck.Text = "ÖDENECEK MİKTAR = " + amount + " ₺";
            lbAmount.Text = "TOPLAM ÖDENMESİ GEREKEN MİKTAR = " + amount + " ₺";
        }
      
        void checkControl()
        {
            if (checkCard.Checked)
            {
                lbCard.Visible = true;
                tbCard.Visible = true;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
            else
            {
                lbCard.Visible = false;
                tbCard.Visible = false;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
            if (checkCash.Checked)
            {
                lbCash.Visible = true;
                tbCash.Visible = true;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
            else
            {
                lbCash.Visible = false;
                tbCash.Visible = false;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
            if (checkCheck.Checked)
            {
                lbCheck.Visible = true;
                tbCheck.Visible = true;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
            else
            {
                lbCheck.Visible = false;
                tbCheck.Visible = false;
                tbCard.Text = "0";
                tbCash.Text = "0";
                tbCheck.Text = "0";
            }
        }
      
        void groupControl()
        {
            if (checkCard.Checked)
                groupCard.Visible = true;
            else
                groupCard.Visible = false;
            if (checkCash.Checked)
                groupCash.Visible = true;
            else
                groupCash.Visible = false;
            if (checkCheck.Checked)
                groupCheck.Visible = true;
            else
                groupCheck.Visible = false;
        }
       
        void totalTextBoxCalc()
        {
            totalTextBox = CardQuantity + CashQuantity + CheckQuantity;
            if ((amount - totalTextBox) > 0)
            {
                lbRemaining.Text = "KALAN TUTAR = " + (amount - totalTextBox).ToString() + " ₺";
            }
            else
            {
                lbRemaining.Text = "FAZLA TUTAR = " + (totalTextBox - amount).ToString() + " ₺";
            }

            if (totalTextBox == amount)
            {
                lbAmount.BackColor = Color.Green;
                lbAmount.ForeColor = Color.White;
                lbRemaining.Visible = false;
            }
            else
            {
                lbAmount.BackColor = Color.Red;
                lbAmount.ForeColor = Color.White;
                lbRemaining.Visible = true;
            }
        }
      
        void insertButton()
        {
            for (int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Name = "btn"+(i+1);
                btn.Size = new Size(150, 165);
                btn.Text = User.UserAddress[i, 1] + "\n\n" + User.UserAddress[i, 2];
                btn.Tag = i;
                btn.BackColor = Color.White;
                btn.Click += new EventHandler(BtnClick);
                btn.MouseEnter += new EventHandler(CursorEnterHand);
                btn.MouseLeave += new EventHandler(CursorLeaveArrow);
                AdresPanel.Controls.Add(btn);
                if (User.UserAddress[i+1,1]==null)
                {
                    break;
                }
            }
           
        }
      
        bool checkCardCheck()
        {

            if (tbCardNumber.Text.Length == 19)
            {
                if (tbExpirationDate.Text.Length == 7)
                {
                    if (tbCVV.Text.Length == 3)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen kartın CVV numarasını doğru giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kartın Son kullanma tarihini doğru giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kart numarasını doğru giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
   
        bool checkCheckCheck()
        {
            if (tbBankID.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen banka numarasını giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
      
        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lastBtn!=null)
            {
                lastBtn.BackColor = Color.White;
                lastBtn.ForeColor = Color.Black;
            }
            AddressID = Convert.ToInt32(btn.Tag);
            btn.BackColor = Color.DodgerBlue;
            btn.ForeColor = Color.White;
            lastBtn = btn;
        }

        private void CursorEnterHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
     
        private void CursorLeaveArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
   
        private void BuyItem_Load(object sender, EventArgs e)
        {
            amount = Item.Price * Convert.ToDouble(Quantity)+(Item.Price * Convert.ToDouble(Quantity)*Item.Tax);
            getDataForlb();
            insertButton();
        }
     
        private void CheckedChange(object sender,EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            groupControl();
            getDataForlb();
            if (cb.Checked)
            {
                paymentCount++;
            }
            else
            {
                paymentCount--;
            }
            if (paymentCount > 1)
            {
                checkControl();
                lbAmountCard.Text = "ÖDENECEK MİKTAR = 0 ₺";
                lbAmountCash.Text = "ÖDENECEK MİKTAR = 0 ₺";
                lbAmountCheck.Text = "ÖDENECEK MİKTAR = 0 ₺";
                lbAmount.Visible = true; lbRemaining.Visible = true;
            }
            else
            {
                lbCard.Visible = false; tbCard.Visible = false;
                lbCash.Visible = false; tbCash.Visible = false;
                lbCheck.Visible = false; tbCheck.Visible = false;
                lbAmount.Visible = false; lbRemaining.Visible = false;
            }
        }
      
        private void tbCard_TextChanged(object sender, EventArgs e)
        {
            if (tbCard.Text == "")
            {
                tbCard.Text = "0";
            }
            CardQuantity = Convert.ToDouble(tbCard.Text);
            lbAmountCard.Text = "ÖDENECEK MİKTAR = " + CardQuantity + " ₺";
            totalTextBoxCalc();
            if (tbCard.Text == amount.ToString())
            {
                checkCash.Checked = false;
                checkCheck.Checked = false;
            }
        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            if (tbCash.Text == "")
            {
                tbCash.Text = "0";
            }
            CashQuantity = Convert.ToDouble(tbCash.Text);
            lbAmountCash.Text = "ÖDENECEK MİKTAR = " + CashQuantity + " ₺";
            totalTextBoxCalc();
            if (tbCash.Text == amount.ToString())
            {
                checkCard.Checked = false;
                checkCheck.Checked = false;
            }
        }
  
        private void tbCheck_TextChanged(object sender, EventArgs e)
        {
            if (tbCheck.Text == "")
            {
                tbCheck.Text = "0";
            }
            CheckQuantity = Convert.ToDouble(tbCheck.Text);
            lbAmountCheck.Text = "ÖDENECEK MİKTAR = " + CheckQuantity + " ₺";
            totalTextBoxCalc();
            if (tbCheck.Text == amount.ToString())
            {
                checkCard.Checked = false;
                checkCash.Checked = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            double CardAmount = Convert.ToDouble(lbAmountCard.Text.Substring(18, (lbAmountCard.Text.IndexOf("₺") - 1) - (lbAmountCard.Text.IndexOf("=") + 1)));
            double CashAmount = Convert.ToDouble(lbAmountCash.Text.Substring(18, (lbAmountCash.Text.IndexOf("₺") - 1) - (lbAmountCash.Text.IndexOf("=") + 1)));
            double CheckAmount = Convert.ToDouble(lbAmountCheck.Text.Substring(18, (lbAmountCheck.Text.IndexOf("₺") - 1) - (lbAmountCheck.Text.IndexOf("=") + 1)));
            if (checkCard.Checked)
            {
                if (checkCardCheck())
                {
                    if (checkCash.Checked)
                    {
                        if (checkCheck.Checked)
                        {
                            if (checkCheckCheck())
                            {
                                if (amount == totalTextBox)
                                {
                                    if (AddressID >= 0)
                                    {
                                        //kredi kartı - nakit - çek
                                        Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                                        Order.CreditPayment(tbCardNumber.Text, tbExpirationDate.Text, Convert.ToInt32(tbCVV.Text), CardAmount);
                                        Order.CashPayment(CashAmount);
                                        Order.CheckPayment(tbBankID.Text, CheckAmount);
                                        Order.OrderSave(User.UserAddress, AddressID);
                                        MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen tutarı eşitleyiniz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (amount == totalTextBox)
                            {
                                if (AddressID >= 0)
                                {
                                    //kredi kartı - nakit
                                    Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                                    Order.CreditPayment(tbCardNumber.Text, tbExpirationDate.Text, Convert.ToInt32(tbCVV.Text), CardAmount);
                                    Order.CashPayment(CashAmount);
                                    Order.OrderSave(User.UserAddress, AddressID);
                                    MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen tutarı eşitleyiniz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        if (checkCheck.Checked)
                        {
                            if (checkCheckCheck())
                            {
                                if (amount == totalTextBox)
                                {
                                    if (AddressID >= 0)
                                    {
                                        //kredi kartı - çek
                                        Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                                        Order.CreditPayment(tbCardNumber.Text, tbExpirationDate.Text, Convert.ToInt32(tbCVV.Text), CardAmount);
                                        Order.CheckPayment(tbBankID.Text, CheckAmount);
                                        Order.OrderSave(User.UserAddress, AddressID);
                                        MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen tutarı eşitleyiniz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (AddressID >= 0)
                            {
                                //kredi kartı
                                Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                                Order.CreditPayment(tbCardNumber.Text, tbExpirationDate.Text, Convert.ToInt32(tbCVV.Text), CardAmount);
                                Order.OrderSave(User.UserAddress, AddressID);
                                MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkCash.Checked)
            {
                if (checkCheck.Checked)
                {
                    if (checkCheckCheck())
                    {
                        if (amount == totalTextBox)
                        {
                            if (AddressID >= 0)
                            {
                                // nakit - çek
                                Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                                Order.CashPayment(CashAmount);
                                Order.CheckPayment(tbBankID.Text, CheckAmount);
                                Order.OrderSave(User.UserAddress, AddressID);
                                MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen tutarı eşitleyiniz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (AddressID >= 0)
                    {
                        //sadece Nakit
                        Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                        Order.CashPayment(CashAmount);
                        Order.OrderSave(User.UserAddress, AddressID);
                        MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (checkCheck.Checked)
            {
                if (checkCheckCheck())
                {

                    if (AddressID >= 0)
                    {
                        //sadece çek
                        Order Order = new Order(Item, Quantity, User.UserID, AddressID);
                        Order.CheckPayment(tbBankID.Text, CheckAmount);
                        Order.OrderSave(User.UserAddress, AddressID);
                        MessageBox.Show("Siparişiniz başarıyla oluşturuldu.", "Sipariş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen adres seçiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri kontrol edip tekrar deneyiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
