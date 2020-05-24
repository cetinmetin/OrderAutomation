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
    public partial class CustomerFollow : Form
    {
        public CustomerFollow()
        {
            InitializeComponent();
        }
        User User;
        List<User> Users;
        void lists()
        {
            User = new User();
            User.getUsers();
            Users = User.Users;
            UserTable.Items.Clear();
            UserTable.View = View.Details;
            UserTable.FullRowSelect = true;
            UserTable.GridLines = true;
            UserTable.Columns.Add("No", 50);
            UserTable.Columns.Add("İsmi", 300);
            UserTable.Columns.Add("Telefon Numarası", 200);
            for (int i = 0; i < Users.Count; i++)
            {
                string[] row =
                {
                    Users[i].UserID.ToString(),
                    Users[i].Name,
                    Users[i].UserPhone
                };
                var listviewLine = new ListViewItem(row);
                UserTable.Items.Add(listviewLine);
            }
        }
        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void CustomerFollow_Load(object sender, EventArgs e)
        {
            lists();
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
