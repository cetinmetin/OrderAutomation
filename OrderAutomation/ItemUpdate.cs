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
    public partial class ItemUpdate : Form
    {
        public ItemUpdate()
        {
            InitializeComponent();
        }
        List<Item> Items;
        Item Item;
        public void lists()
        {
            Item = new Item();
            Item.getItem();
            Items = Item.Items;
            ItemTable.Items.Clear();
            ItemTable.View = View.Details;
            ItemTable.FullRowSelect = true;
            ItemTable.GridLines = true;
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
        public void CursorChangeHand(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        public void CursorChangeArrow(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void ItemUpdate_Load(object sender, EventArgs e)
        {
            lists();
            ItemTable.Columns.Add("No", 50);
            ItemTable.Columns.Add("İsmi", 200);
            ItemTable.Columns.Add("Açıklaması", 300);
            ItemTable.Columns.Add("Ağırlığı", 70);
            ItemTable.Columns.Add("Vergi Oranı", 50);
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms["SelectedItemUpdate"] != null)
            {
                Application.OpenForms["SelectedItemUpdate"].Close();
            }
        }

        private void ItemTable_DoubleClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["SelectedItemUpdate"] == null)
            {
                
                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].ID == Convert.ToInt32(ItemTable.SelectedItems[0].Text))
                    {
                        SelectedItemUpdate frmSelectedItemUpdate = new SelectedItemUpdate();
                        frmSelectedItemUpdate.Item = Items[i];
                        frmSelectedItemUpdate.MdiParent = Application.OpenForms["MainForm"];
                        frmSelectedItemUpdate.Show();

                    }
                }
            }
        }
    }
}
