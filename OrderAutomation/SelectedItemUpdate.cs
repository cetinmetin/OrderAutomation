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
    public partial class SelectedItemUpdate : Form
    {
        public SelectedItemUpdate()
        {
            InitializeComponent();
        }
        public Item Item;
        string[] PictureLocation = new string[3];
        private void getImagePath()
        {
            for (int i = 0; i < 3; i++)
            {
                if (File.Exists(Application.StartupPath + @"\Images\Item" + Item.ID + "-" + Convert.ToInt32(i + 1) + ".png"))
                {
                    PictureLocation[i] = Application.StartupPath + @"\Images\Item" + Item.ID + "-" + Convert.ToInt32(i + 1) + ".png";
                }
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
        void btnDeleteControl()
        {
            if (PictureLocation[0]==null)
            {
                btnDelete1.Visible = false;
                btnPicture1.Text = "(+) Resim Ekle";

                btnPicture2.Visible = false;
                btnDelete2.Visible = false;
                lbPicture2.Visible = false;

                btnPicture3.Visible = false;
                btnDelete3.Visible = false;
                lbPicture3.Visible = false;
            }
            if (PictureLocation[0] != null)
            {
                btnDelete1.Visible = true;
                btnPicture1.Text = "";

                btnPicture2.Visible = true;
                btnDelete2.Visible = false;
                lbPicture2.Visible = true;
                btnPicture2.Text = "(+) Resim Ekle";

                btnPicture3.Visible = false;
                btnDelete3.Visible = false;
                lbPicture3.Visible = false;
            }
            if (PictureLocation[1] != null)
            {
                btnPicture2.Visible = true;
                btnDelete2.Visible = true;
                lbPicture2.Visible = true;
                btnPicture2.Text = "";

                btnPicture3.Visible = true;
                btnDelete3.Visible = false;
                btnPicture3.Text = "(+) Resim Ekle";
                lbPicture3.Visible = true;
            }
            if (PictureLocation[2]!=null)
            {
                btnDelete3.Visible = true;
                btnPicture3.Text = "";
            }
        }
        void PictureSave()
        {
            for (int i = 0; i < 3; i++)
            {
                if (File.Exists(Application.StartupPath + @"\Images\Item" + Item.ID + "-" + Convert.ToInt32(i + 1) + ".png"))
                {
                    continue;
                }
                else
                {
                    if (PictureLocation[i] != null)
                    {
                        string target = Application.StartupPath + @"\Images\";
                        string newPictureFileName = "Item" + Item.ID + "-" + Convert.ToInt32(i + 1) + ".png";
                        File.Copy(PictureLocation[i], target + newPictureFileName);
                    }
                }
            }
        }
        void getPicture()
        {
            getImagePath();
            btnPicture1.BackgroundImage = Image.FromFile(PictureLocation[0]);
            if (PictureLocation[1] != null)
            {
                btnPicture2.BackgroundImage = Image.FromFile(PictureLocation[1]);
            }
            else
            {
                btnPicture2.Text = "(+) Resim Ekle";
            }
            if (PictureLocation[2] != null)
            {
                btnPicture3.BackgroundImage = Image.FromFile(PictureLocation[2]);
            }
            else
            {
                btnPicture3.Text = "(+) Resim Ekle";
            }
            btnDeleteControl();
        }
        void getItemtb()
        {
            tbItemName.Text = Item.Name;
            tbItemPrice.Text = Item.Price.ToString();
            tbItemDescription.Text = Item.Description;
            tbItemWeight.Text = Item.Weight.ToString();
            if (Item.Tax == 0.01)
                cbItemTax.SelectedIndex = 0;
            else if (Item.Tax == 0.08)
                cbItemTax.SelectedIndex = 1;
            else
                cbItemTax.SelectedIndex = 2;
        }
        private void SelectedItemUpdate_Load(object sender, EventArgs e)
        {
            getPicture();
            getItemtb();
        }
        public void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "(+) Resim Ekle")
            {
                OpenFileDialog PictureFile = new OpenFileDialog();
                PictureFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;";
                if (PictureFile.ShowDialog() == DialogResult.OK)
                {
                    PictureLocation[Convert.ToInt32(btn.Tag)] = PictureFile.FileName;
                    btn.BackgroundImage = Image.FromFile(PictureLocation[Convert.ToInt32(btn.Tag)]);
                    btnDeleteControl();
                    btn.Text = "";
                }
            }
        }
        public void ButtonDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Güncelle")
            {
                OpenFileDialog PictureFile = new OpenFileDialog();
                PictureFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;";
                if (PictureFile.ShowDialog() == DialogResult.OK)
                {
                    btnPicture1.BackgroundImage.Dispose();
                    btnPicture1.BackgroundImage = null;
                    File.Delete(PictureLocation[0]);
                    PictureLocation[0] = PictureFile.FileName;
                    btnPicture1.BackgroundImage = Image.FromFile(PictureLocation[0]);
                }
            }
            else if (MessageBox.Show("Fotoğrafı silmek istediğinize emin misiniz ?", "FOTOĞRAF SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToInt32(btn.Tag) == 0)
                {
                    btnPicture1.BackgroundImage.Dispose();
                    btnPicture1.BackgroundImage = null;
                }
                else if (Convert.ToInt32(btn.Tag) == 1)
                {
                    btnPicture2.BackgroundImage.Dispose();
                    btnPicture2.BackgroundImage = null;
                }
                else
                {
                    btnPicture3.BackgroundImage.Dispose();
                    btnPicture3.BackgroundImage = null;
                }

                File.Delete(PictureLocation[Convert.ToInt32(btn.Tag)]);
                PictureLocation[Convert.ToInt32(btn.Tag)] = null;
                btnDeleteControl();
            }
        }
        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbItemName.Text.Length > 0)
            {
                if (tbItemPrice.Text.Length > 0)
                {

                    if (tbItemDescription.Text.Length > 0)
                    {

                        if (tbItemWeight.Text.Length > 0)
                        {
                            if (cbItemTax.Text != "")
                            {
                                if (PictureLocation[0] != null)
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
                                    Item.ItemUpdate();
                                    PictureSave();
                                    MessageBox.Show("Ürün başarıyla güncellendi", "GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ItemUpdate frmItemUpdate = (ItemUpdate)Application.OpenForms["ItemUpdate"];
                                    frmItemUpdate.lists();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("1.Fotoğraf boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}