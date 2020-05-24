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
    public partial class ItemRemove : Form
    {
        public ItemRemove()
        {
            InitializeComponent();
        }
        
        List<Item> Items;
        Item Item;
        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        void lists()
        {
            Item = new Item();
            Item.getItem();
            Items = Item.Items;
            ItemTable.Items.Clear();
            ItemTable.View = View.Details;
            ItemTable.FullRowSelect = true;
            ItemTable.GridLines = true;
            ItemTable.Columns.Add("No", 50);
            ItemTable.Columns.Add("İsmi", 200);
            ItemTable.Columns.Add("Açıklaması", 300);
            ItemTable.Columns.Add("Ağırlığı", 70);
            ItemTable.Columns.Add("Vergi Oranı", 50);
            string Tax;
            for (int i = 0; i < Items.Count; i++)
            {

                if (Items[i].Tax == 0.01)
                    Tax = "%1";
                else if (Items[i].Tax == 0.08)
                    Tax = "%8";
                else
                    Tax = "%18";

                string[] row =
                {
                    Items[i].ID.ToString(),
                    Items[i].Name,
                    Items[i].Description,
                    Items[i].Weight.ToString()+" kg",
                    Tax
                };
                var listviewLine = new ListViewItem(row);
                ItemTable.Items.Add(listviewLine);
            }
        }
        private void ItemRemove_Load(object sender, EventArgs e)
        {
            lists();
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemTable_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = ItemTable.SelectedItems[0];
            string ItemString = "Ürün Numarası = " + item.SubItems[0].Text + "\nÜrün İsmi = " + item.SubItems[1].Text + "\nÜrün Açıklaması = " + item.SubItems[2].Text + "\nÜrün Ağırlığı = " + item.SubItems[3].Text + "\nÜrün Vergi Oranı = " + item.SubItems[4].Text;
            if (MessageBox.Show(ItemString+"\n\nBu ürünü silmek istediğinize emin misiniz ?","ONAY",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (File.Exists(Application.StartupPath+@"\Images\Item"+ item.SubItems[0].Text+"-"+Convert.ToInt32(i+1)+".png"))
                    {
                        File.Delete(Application.StartupPath + @"\Images\Item" + item.SubItems[0].Text + "-" + Convert.ToInt32(i + 1) + ".png");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                Item.ItemRemove(Convert.ToInt32(item.SubItems[0].Text));
                lists();
                MessageBox.Show("Ürün Başarıyla Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
