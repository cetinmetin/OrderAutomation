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
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }
        string[] PictureFileLocation=new string[3];
        Item Item = new Item();
        int PictureCount = 0;
        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void ItemAdd_Load(object sender, EventArgs e)
        {
        }
        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            if (tbItemName.Text.Length>0)
            {
                if (tbItemPrice.Text.Length > 0)
                {

                    if (tbItemDescription.Text.Length > 0)
                    {

                        if (tbItemWeight.Text.Length > 0)
                        {
                            if (cbItemTax.Text != "")
                            {
                                if (flowLayoutPanel1.Controls.Count > 0)
                                {


                                    double Tax;
                                    Item.Name = tbItemName.Text;
                                    Item.Price = Convert.ToDouble(tbItemPrice.Text);
                                    Item.Description = tbItemDescription.Text;
                                    Item.Weight = Convert.ToDouble(tbItemWeight.Text);
                                    if (cbItemTax.SelectedIndex == 0)
                                        Tax = 0.01;
                                    else if (cbItemTax.SelectedIndex == 1)
                                        Tax = 0.08;
                                    else
                                        Tax = 0.18;
                                    Item.Tax = Tax;
                                    string target = Application.StartupPath + @"\Images\";
                                    int ItemID = Item.maxItemID() + 1;
                                    Item.ItemAdd();
                                    for (int i = 0; i < 3; i++)
                                    {
                                        if (PictureFileLocation[i] != null)
                                        {
                                            string newPictureFileName = "Item" + ItemID + "-" + Convert.ToInt32(i + 1) + ".png";
                                            File.Copy(PictureFileLocation[i], target + newPictureFileName);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("En az 1 tane ürün fotoğrafı ekleyiniz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen vergi seçiniz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ürün ağırlığı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün açıklaması boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün fiyatı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ürün ismi boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btnPicture1_Click(object sender, EventArgs e)
        {
            OpenFileDialog PictureFile = new OpenFileDialog();
            PictureBox pbPicture = new PictureBox();
            PictureFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;";
            if (PictureCount<3)
            {
                if (PictureFile.ShowDialog() == DialogResult.OK)
                {
                    pbPicture.Name = "Pbpicture";
                    pbPicture.Tag = PictureCount;
                    pbPicture.Width = 130;
                    pbPicture.Height = 230;
                    PictureFileLocation[PictureCount] = PictureFile.FileName;
                    pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbPicture.ImageLocation = PictureFileLocation[PictureCount];
                    flowLayoutPanel1.Controls.Add(pbPicture);
                    PictureCount++;


                }
            }
            else
            {
                MessageBox.Show("En fazla 3 adet fotoğraf ekliyebilirsiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count>0)
            {
                flowLayoutPanel1.Controls.Clear();
                PictureCount = 0;
                for (int i = 0; i < PictureFileLocation.Length; i++)
                {
                    PictureFileLocation[i] = null;
                }
            }

            
        }
    }
}
