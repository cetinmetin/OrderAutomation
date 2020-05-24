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
    public partial class UserOperation : Form
    {
        public UserOperation()
        {
            InitializeComponent();
        }
        public User User;
        public void insertButton()
        {
            flowLayoutPanel1.Controls.Clear();
            tbName.Text = User.Name;
            maskedPhone.Text = User.UserPhone;
            int maxAddressNumber = User.UserAddress.Length / 3;
            int X = 10; int Y = 130;
            User.getAddress(User.UserID);
            for (int i = 0; i < maxAddressNumber; i++)
            {
                if (User.UserAddress[i , 0] == null)
                {
                    Button btn1 = new Button();
                    btn1.Name = "Btn" + (i + 2).ToString();
                    btn1.Text = "(+) ADRES EKLE";
                    btn1.Width = 150;
                    btn1.Height = 165;
                    btn1.Tag = 0;
                    btn1.Location = new Point(X, Y);
                    btn1.Click += new EventHandler(ButtonClick);
                    flowLayoutPanel1.Controls.Add(btn1);
                    break;
                }
                Button btn = new Button();
                btn.Name = "Btn" + (i + 1).ToString();
                btn.Text = User.UserAddress[i, 1] + "\n\n" + User.UserAddress[i, 2];
                btn.Tag = User.UserAddress[i, 0];
                btn.Width = 150;
                btn.Height = 165;
                btn.Location = new Point(X, Y);
                btn.Click+=new EventHandler(ButtonClick);
                flowLayoutPanel1.Controls.Add(btn);
                X += 160;
                if (i == 2)
                {
                    Y += 180;
                    X = 10;
                }
                if (i == maxAddressNumber - 1)
                {
                    break;
                }
                if (User.UserAddress[i + 1, 0] == null)
                {
                    Button btn1 = new Button();
                    btn1.Name = "Btn" + (i + 2).ToString();
                    btn1.Text = "(+) ADRES EKLE";
                    btn1.Width = 150;
                    btn1.Height = 165;
                    btn1.Tag = 0;
                    btn1.Location = new Point(X, Y);
                    btn1.Click += new EventHandler(ButtonClick);
                    flowLayoutPanel1.Controls.Add(btn1);
                    break;
                }
            }
        }
        private void ButtonClick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            MainForm frmMain = (MainForm)Application.OpenForms["MainForm"];
            if (true)
            {
                AddressAdd frmAddressAdd = new AddressAdd();
                frmAddressAdd.MdiParent = frmMain;
                frmAddressAdd.AddressID = Convert.ToInt32(btn.Tag);
                frmAddressAdd.User = User;
                frmAddressAdd.Show();
            }
        }
        private void UserOperation_Load(object sender, EventArgs e)
        {
            insertButton();   
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (tbPassword.Text.Length >= 8)
                {
                    if (maskedPhone.Text.Length == 17)
                    {


                        if (MessageBox.Show("Kullanıcı bilgilerini güncellemek istediğinize emin misiniz?", "GÜNCELLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            User.UserUpdate(User.UserID, tbName.Text, maskedPhone.Text, tbPassword.Text);
                            MessageBox.Show("Kullanıcı başarıyla güncellendi.", "GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm frmMain = (MainForm)Application.OpenForms["MainForm"];
                            frmMain.lbAccountName.Text = User.Name;
                            frmMain.User = User;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen doğru telefon numarası giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("şifre en az 8 karakterden oluşmalıdır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ad Soyad boş bırakılamaz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
            pbShowPassword.ImageLocation = "Images\\eye1.png";
        }
        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            pbShowPassword.ImageLocation = "Images\\eye2.png";
        }
        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms["AddressAdd"]!=null)
            {
                
                AddressAdd frmAddress = (AddressAdd)Application.OpenForms["AddressAdd"];
                frmAddress.Close();
            }
            
        }
        private void pbFormClose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbFormClose_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
