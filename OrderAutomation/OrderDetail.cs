using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public double Tax { get; set; }
        Item Item;
        public OrderDetail(Item Item, int Quantity)
        {
            Tax = Item.Tax;
            this.Quantity = Quantity;
            this.Item = Item;
            calcSubTotal();
            calcWeight();
        }
        public double calcSubTotal()
        {
            double subTotal = Item.Price * Quantity;
            return subTotal;
        }
        public double calcWeight()
        {
            double weightTotal = Item.Weight * Quantity;
            return weightTotal;
        }
    }
}
