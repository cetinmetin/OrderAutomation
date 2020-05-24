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
    public partial class AddressAdd : Form
    {
        public AddressAdd()
        {
            InitializeComponent();
        }
        public int AddressID;
        public User User;
        int listNumber;
        private void AddressAdd_Load(object sender, EventArgs e)
        {
            if (AddressID>0)
            {
                for (int i = 0; i < User.UserAddress.Length / 3; i++)
                {
                    if (Convert.ToInt32(User.UserAddress[i, 0]) == AddressID)
                    {
                        lbTitle.Text = User.UserAddress[i, 1] + " Adresi";
                        tbAddressTitle.Text = User.UserAddress[i, 1];
                        tbAdress.Text = User.UserAddress[i, 2];
                        listNumber = i;
                    }
                }
            }
            else
            {
                lbTitle.Text = "YENİ ADRES";
                btnUpdate.Text = "Kaydet";
                btnRemove.Visible = false;
                for (int i = 0; i < User.UserAddress.Length / 3; i++)
                {
                    if (User.UserAddress[i, 0]==null)
                    {
                        listNumber = i;
                        break;
                    }
                }
            }
            
        }
        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            UserOperation frmuser = (UserOperation)Application.OpenForms["UserOperation"];
            frmuser.insertButton();
        }
        private void pbFormClose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void pbFormClose_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbAddressTitle.Text!="")
            {
                if (tbAdress.Text!="")
                {
                    if (btnUpdate.Text == "Güncelle")
                    {


                        if (MessageBox.Show("Adres bilgilerini güncellemek istediğinize emin misiniz?", "GÜNCELLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            User.AddressUpdate(listNumber, tbAddressTitle.Text, tbAdress.Text);
                            MessageBox.Show("Adres başarıyla güncellendi.", "GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        User.AddressAdd(listNumber, tbAddressTitle.Text, tbAdress.Text);
                        MessageBox.Show("Adres başarıyla kaydedildi.", "KAYDEDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserOperation frmuser = (UserOperation)Application.OpenForms["UserOperation"];
                        frmuser.insertButton();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Adres boş bırakılamaz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Adres başlığı boş bırakılamaz", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(User.UserAddress[listNumber,1] +" Adres bilgilerini silmek istediğinize emin misiniz?", "SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                User.AddressRemove(listNumber);
                UserOperation frmuser = (UserOperation)Application.OpenForms["UserOperation"];
                frmuser.insertButton();
                this.Close();
            }
        }
    }
}
