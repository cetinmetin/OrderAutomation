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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }
        public User User;
        List<Order> Orders;
        Order Order = new Order();
        void lists()
        {
            Order.getOrderList(User.UserID);
            Orders = Order.Orders;

            OrderTable.View = View.Details;
            OrderTable.FullRowSelect = true;
            OrderTable.GridLines = true;
            OrderTable.Columns.Add("No", 50);
            OrderTable.Columns.Add("Sipariş Tarihi", 70);
            OrderTable.Columns.Add("Sipariş Durumu", 70);
            OrderTable.Columns.Add("Sipariş Edilen Ürün", 150);
            OrderTable.Columns.Add("Miktar", 70);
            OrderTable.Columns.Add("Fiyatı", 70);
            OrderTable.Columns.Add("Ağırlığı", 70);
            OrderTable.Columns.Add("Vergisi", 70);
            OrderTable.Columns.Add("Adres Başlığı", 150);
            OrderTable.Columns.Add("Adres", 150);
            string tempOrderState = "";
            for (int i = 0; i < Orders.Count; i++)
            {
                switch (Orders[i].OrderState)
                {
                    case 0:
                        tempOrderState = "Hazırlanıyor";
                        break;
                    default:
                        break;
                }
                string[] row =
                {
                    Orders[i].OrderID.ToString(),
                    Orders[i].OrderDate.ToString().Substring(0,10),
                    tempOrderState,
                    Orders[i].Item.Name,
                    Orders[i].OrderDetail.Quantity.ToString()+" Adet",
                    Orders[i].calcTotal().ToString()+" ₺",
                    Orders[i].OrderDetail.calcWeight().ToString()+" Kg",
                    Orders[i].OrderDetail.Tax.ToString(),
                    Orders[i].addressTitle,
                    Orders[i].address
                };
                var listviewLine = new ListViewItem(row);
                OrderTable.Items.Add(listviewLine);
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
        private void OrderHistory_Load(object sender, EventArgs e)
        {
            lists();
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderTable_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = OrderTable.SelectedItems[0];
            MessageBox.Show("Sipariş Numarası = " + item.SubItems[0].Text+"\nSipariş Tarihi = "+ item.SubItems[1].Text + "\nSipraiş Durumu = " + item.SubItems[2].Text + "\nSipariş Edilen Ürün = " + item.SubItems[3].Text + "\nMiktar = " + item.SubItems[4].Text + "\nFiyatı = " + item.SubItems[5].Text + "\nAğırlığı = " + item.SubItems[6].Text + "\nVergisi = " + item.SubItems[7].Text + "\nAdres Başlığı = " + item.SubItems[8].Text + "\nAdres = " + item.SubItems[9].Text);
        }
    }
}
