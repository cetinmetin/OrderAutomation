using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrderAutomation
{
    public partial class ItemDetail : Form
    {
        public ItemDetail()
        {
            InitializeComponent();
        }
        public Item Item;
        public User User;
        PictureBox prevPb = new PictureBox();
        private string getImagePath(int imageIndex)
        {
            string pictureFilePath = @Application.StartupPath + "\\Images\\Item" + Item.ID + "-" + imageIndex + ".png";
            if (File.Exists(pictureFilePath))
            {
                return pictureFilePath;
            }
            else
            {
                return "File not found";
            }
        }
        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void getDataForLabel()
        {
            lbItemName.Text = Item.Name;
            double totalPrice = Item.Price * (double)itemQuantity.Value;
            double totalTax = +Item.Price * (double)itemQuantity.Value * Item.Tax;
            double totalWeight = Item.Weight * (double)itemQuantity.Value;
            lbItemDescription.Text = Item.Description + "\nAğırlığı = " + totalWeight + " kg\n\n Fiyatı = " + totalPrice + " ₺ + KDV\n\nKDV = " + totalTax + " ₺\n\nToplam = " + Convert.ToDouble(totalPrice + totalTax) + " ₺";
        }
        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void pbFormClose_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BuyItem"]!=null)
            {
                Application.OpenForms["BuyItem"].Close();
            }
            this.Close();
            
        }
        private void itemQuantity_ValueChanged(object sender, EventArgs e)
        {
            getDataForLabel();
        }
        private void pbNewClick(object sender, EventArgs e)
        {
            PictureBox pbPicture = (PictureBox)sender;
            
                prevPb.Padding = new Padding(0);
                prevPb.BackColor = Color.Transparent;
            
            pbMain.Image = pbPicture.Image;
            pbPicture.Padding = new Padding(2);
            pbPicture.BackColor = Color.DodgerBlue;
            prevPb = pbPicture;
        }
        private void pbCreate()
        {
            int Y = 12;
            
            for (int i = 1; i < 4; i++)
            {
                if (getImagePath(i) == "File not found")
                    break;
                PictureBox pbNew = new PictureBox();
                pbNew.Name = "pb" + i.ToString();
                pbNew.Size = new Size(80, 120);
                pbNew.ImageLocation = getImagePath(i);
                pbNew.SizeMode = PictureBoxSizeMode.StretchImage;
                pbNew.Location = new Point(10,Y);
                Y += 126;
                pbNew.Click += new EventHandler(pbNewClick);
                pbNew.MouseEnter += new EventHandler(CursorChangeHand);
                pbNew.MouseLeave += new EventHandler(CursorChangeArrow);
                if (i == 1)
                {
                    pbMain.ImageLocation = getImagePath(i);
                    pbNew.Padding = new Padding(2);
                    pbNew.BackColor = Color.DodgerBlue;
                    prevPb = pbNew;
                }
                this.Controls.Add(pbNew);
                
            }
            
        }

        private void ItemDetail_Load(object sender, EventArgs e)
        {
            pbCreate();
            getDataForLabel();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyItem frmBuy = new BuyItem();
            frmBuy.MdiParent = (MainForm)Application.OpenForms["MainForm"];
            frmBuy.Item = Item;
            frmBuy.User = User;
            frmBuy.Quantity = Convert.ToInt32(itemQuantity.Value);
            frmBuy.Show();
        }
    }
}
