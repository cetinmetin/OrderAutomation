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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User User=new User();
            if (tbUserName.Text.Length >= 8)
            {
                if (User.UserNameUsedControl(tbUserName.Text))
                {
                    if (tbCustomerName.Text != "")
                    {
                        if (tbPassword.Text.Length >= 8)
                        {
                            if (tbPassword.Text == tbPasswordAgain.Text)
                            {
                                if (maskedPhone.Text.Length == 17)
                                {
                                    User.UserAdd(tbCustomerName.Text, maskedPhone.Text, tbUserName.Text, tbPassword.Text, tbAddressTitle.Text, tbAdress.Text);
                                    MessageBox.Show("Hoş Geldiniz " + User.Name, "HOŞ GELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen doğru telefon numarası giriniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Şifreler birbirleriyle uyuşmalıdır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("Kullanıcı Adı Kullanılmaktadır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı 7 karakterden oluşmalıdır.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAdress_TextChanged(object sender, EventArgs e)
        {
            int addressLetterCount = tbAdress.Text.Length;
            if (addressLetterCount <= 200)
            {
                lbAddressLetterCount.Text = addressLetterCount.ToString() + "/200";
            }
            else
            {
                tbAdress.Text = tbAdress.Text.Substring(0, 200);
                tbAdress.Select(200, 0);
            }
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•'; tbPasswordAgain.PasswordChar = '•';
            pbShowPassword.ImageLocation = "Images\\eye1.png";
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0'; tbPasswordAgain.PasswordChar = '\0';
            pbShowPassword.ImageLocation = "Images\\eye2.png";
        }
    }
}
