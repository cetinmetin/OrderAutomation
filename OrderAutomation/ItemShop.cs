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
    public partial class ItemShop : Form
    {
        public ItemShop()
        {
            InitializeComponent();
        }
        Item Item = new Item();
        public User User;
        List<Item> Items;
        private string getImagePath(int ItemsID)
        {
            string pictureFilePath = Application.StartupPath + "\\Images\\Item" + Items[ItemsID].ID + "-1.png";
            return pictureFilePath;
        }
        private void btnPictureHover(object sender,  System.EventArgs e)
        {
            Button btnPicture = (Button)sender;
            btnPicture.BackgroundImage = null;
            btnPicture.Text = Items[Convert.ToInt32(btnPicture.Tag)].Name + "\n\n" + Convert.ToDouble(Items[Convert.ToInt32(btnPicture.Tag)].Price + (Items[Convert.ToInt32(btnPicture.Tag)].Price * Items[Convert.ToInt32(btnPicture.Tag)].Tax)) + " ₺\n\n" + "Ayrıntılı bilgi için tıklayınız..";
            this.Cursor = Cursors.Hand;
            
        }
        private void btnPictureClick(object sender, System.EventArgs e)
        {
            Button btnPicture = (Button)sender;
            if (Application.OpenForms["ItemDetail"] == null)
            {
                ItemDetail frmItemDetail = new ItemDetail();
                frmItemDetail.MdiParent = Application.OpenForms["MainForm"];
                frmItemDetail.User = User;
                frmItemDetail.Item = Items[Convert.ToInt32(btnPicture.Tag)];
                frmItemDetail.Show();
            }
            else
            {
                ItemDetail frmItemDetail = (ItemDetail)Application.OpenForms["ItemDetail"];
                frmItemDetail.Close();
                frmItemDetail = new ItemDetail();
                frmItemDetail.MdiParent = Application.OpenForms["MainForm"];
                frmItemDetail.User = User;
                frmItemDetail.Item = Items[Convert.ToInt32(btnPicture.Tag)];
                frmItemDetail.Show();
            }
        }
        private void btnPictureLeave(object sender, System.EventArgs e)
        {
            Button btnPicture = (Button)sender;
            btnPicture.BackgroundImage = Image.FromFile(getImagePath(Convert.ToInt32(btnPicture.Tag)));
            btnPicture.Text = "";
            this.Cursor = Cursors.Arrow;
        }
        private void ItemShop_Load(object sender, EventArgs e)
        {

            Item.getItem();
            Items = Item.Items;
            for (int i = 0; i < Items.Count; i++)
            {
                Button btnPicture = new Button();
                btnPicture.Name = "BtnPicture" + (i + 1).ToString();
                btnPicture.BackgroundImage = Image.FromFile(getImagePath(i));
                btnPicture.BackgroundImageLayout = ImageLayout.Stretch;
                btnPicture.FlatStyle = FlatStyle.Flat;
                btnPicture.Tag = i;
                btnPicture.Width = 160;
                btnPicture.Height = 260;
                btnPicture.Margin = new Padding(6, 3, 6, 3);
                btnPicture.MouseEnter += new EventHandler(btnPictureHover);
                btnPicture.MouseLeave += new EventHandler(btnPictureLeave);
                btnPicture.Click += new EventHandler(btnPictureClick);
                flowLayoutPanel1.Controls.Add(btnPicture);
            }
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemDetail"] != null)
            {
                Application.OpenForms["ItemDetail"].Close();
            }
            if (Application.OpenForms["BuyItem"] != null)
            {
                Application.OpenForms["BuyItem"].Close();
            }
            this.Close();
        }

        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
