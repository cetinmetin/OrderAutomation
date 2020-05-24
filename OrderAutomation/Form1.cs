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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public User user = new User();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.ConnectionQuery(tbUserName.Text,tbPassword.Text))
            {
                MainForm mfrm = (MainForm)Application.OpenForms["MainForm"];
                mfrm.User = user;
                mfrm.Focus();
                this.Close();
                mfrm.Form1Closed();
               
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
