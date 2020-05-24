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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int Move, Mouse_X, Mouse_Y;
       
        public User User;
       
        void form1Open()
        {
            if (Application.OpenForms["Form1"] == null)
            {
                Form1 frm1 = new Form1();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }
       
        void allFormClose()
        {
            Form[] Forms = this.MdiChildren;
            for (int i = 0; i < Forms.Length; i++)
                Forms[i].Close();
        }
       
        void SignOut()
        {
            btnHome.Visible = false;
            lbHome.Visible = false;
            btnAdmin.Visible = false;
            lbAdmin.Visible = false;
            btnAccount.Visible = false;
            lbAccountName.Visible = false;
            toolStripSeparator2.Visible = false;
            btnLogin.Visible = true;
            lbLogin.Visible = true;
            btnRegister.Visible = true;
            lbRegister.Visible = true;
            subMenuAdmin.Visible = false;
            allFormClose();
            form1Open();

        }
       
        public void Form1Closed()
        {
            if (User.UserState==true)
            {
                lbAdmin.Visible = true;
                btnAdmin.Visible = true;
                toolStripSeparator1.Visible = false;
            }
            else
            {
                toolStripSeparator1.Visible = false;
            }
            btnHome.Visible = true;
            lbHome.Visible = true;
            btnAccount.Visible = true;
            lbAccountName.Visible = true;
            btnLogin.Visible = false;
            lbLogin.Visible = false;
            btnRegister.Visible = false;
            lbRegister.Visible = false;
            toolStripSeparator2.Visible = true;
            lbAccountName.Text = User.Name;
}
       
        public void FormOperationOpen()
        {
            if (Application.OpenForms["UserOperation"] == null)
            {
                UserOperation frmUserOperation = new UserOperation();
                frmUserOperation.User = User;
                frmUserOperation.MdiParent = this;
                frmUserOperation.Show();
            }
        }
        
        private void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        
        private void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
       
        void Form1Open(object sender, EventArgs e)
        {
            form1Open();
        }
      
        void RegisterFormOpen(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["RegisterForm"]==null)
            {
                RegisterForm frmregister = new RegisterForm();
                frmregister.MdiParent = this;
                frmregister.Show();
                Application.OpenForms["Form1"].Close();
            }
        }
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1Open(sender,e);
            btnAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            lbAccountName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void subMenuShow(object sender, EventArgs e)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
                subMenuAdmin.Visible = false;
            }
            else
            {
                subMenu.Visible = true;
                subMenuAdmin.Visible = false;
            }
        }

        private void subMenuAdminShow(object sender, EventArgs e)
        {
            if (subMenuAdmin.Visible)
            {
                subMenu.Visible = false;
                subMenuAdmin.Visible = false;
            }
            else
            {
                subMenu.Visible = false;
                subMenuAdmin.Visible = true;
            }
        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
   
        private void mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
  
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1Open(sender, e);
            SignOut();
        }
    
        private void btnAccountProperty_Click(object sender, EventArgs e)
        {
            FormOperationOpen();
        }
   
        private void btnAccountRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabınızı silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                User.UserDelete(User.UserID);
                MessageBox.Show("Hesabınız Başarıyla Silindi.", "SİLİNDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignOut();
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory frmHistory = new OrderHistory
            {
                User = User,
                MdiParent = Application.OpenForms["MainForm"]
            };
            if (Application.OpenForms["OrderHistory"]==null)
            {
                frmHistory.Show();
            }
            else
            {
                Application.OpenForms["OrderHistory"].Focus();
            }

        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            ItemAdd frmItemAdd = new ItemAdd();
            frmItemAdd.MdiParent = this;
            if (Application.OpenForms["ItemAdd"]==null)
            {
                frmItemAdd.Show();
            }
            else
            {
                Application.OpenForms["ItemAdd"].Focus();
            }
        }

        private void tbItemRemove_Click(object sender, EventArgs e)
        {
            ItemRemove frmItemRemove = new ItemRemove();
            frmItemRemove.MdiParent = this;
            if (Application.OpenForms["ItemRemove"] == null)
            {
                frmItemRemove.Show();
            }
            else
            {
                Application.OpenForms["ItemRemove"].Focus();
            }
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            ItemUpdate frmItemUpdate = new ItemUpdate();
            frmItemUpdate.MdiParent = this;
            if (Application.OpenForms["ItemUpdate"] == null)
            {
                frmItemUpdate.Show();
            }
            else
            {
                Application.OpenForms["ItemUpdate"].Focus();
            }
        }

        private void btnCustomerFollow_Click(object sender, EventArgs e)
        {
            CustomerFollow frmCustomerFollow = new CustomerFollow();
            frmCustomerFollow.MdiParent = this;
            if (Application.OpenForms["CustomerFollow"] == null)
            {
                frmCustomerFollow.Show();
            }
            else
            {
                Application.OpenForms["CustomerFollow"].Focus();
            }
        }

        private void lbAccountName_Click(object sender, EventArgs e)
        {
            FormOperationOpen();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            ItemShop frmItem = new ItemShop();
            frmItem.MdiParent = this;
            frmItem.User = User;
            frmItem.Show();
        }


    }
}
