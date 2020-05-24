using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderAutomation
{
    public class Order
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OrderAutomation;Integrated Security=True");
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderState { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        private int AddressID { get; set; }

        public string addressTitle { get; set; }
        public string address { get; set; }

        public Item Item;
        public OrderDetail OrderDetail;
        public List<Order> Orders;
        public Credit Credit;
        public Cash Cash;
        public Check Check;
        public double calcTax()
        {
            double taxTotal = OrderDetail.calcSubTotal() * OrderDetail.Tax;
            return taxTotal;
        }
        public double calcTotal()
        {
            double priceTotal = OrderDetail.calcSubTotal() + calcTax();
            return priceTotal;
        }
        public void CreditPayment(string Number, string ExpirationDate, int CVV,double Amount)
        {
            Credit = new Credit(Number, ExpirationDate, CVV);
            Credit.Amount = Amount;
        }
        public void CashPayment( double Amount)
        {
            Cash = new Cash();
            Cash.Amount = Amount;
        }
        public void CheckPayment(string bankID,double Amount)
        {
            Check = new Check(bankID);
            Check.Amount = Amount;
        }

        public Order(Item Item, int Quantity, int UserID,int AddressID)
        {
            OrderDetail = new OrderDetail(Item, Quantity);
            this.ItemID = Item.ID;
            this.UserID = UserID;
            OrderState = 0;
            OrderDate = DateTime.Today;
            this.AddressID = AddressID;
        }
        public void OrderSave(string[,] address,int addressID)
        {
            SqlCommand cmd = new SqlCommand("insert into OrderTable(date,state,itemID,userID,addressTitle,address,quantity,calcTax,priceTotal,weightTotal,Credit,Cash,CheckAmount) values (@date,@state,@itemID,@userID,@addressTitle,@address,@quantity,@calcTax,@priceTotal,@weightTotal,@Credit,@Cash,@Check)", connection);
            cmd.Parameters.AddWithValue("@date",OrderDate);
            cmd.Parameters.AddWithValue("@state",OrderState);
            cmd.Parameters.AddWithValue("@itemID",ItemID);
            cmd.Parameters.AddWithValue("@userID", UserID);
            cmd.Parameters.AddWithValue("@addressTitle", address[addressID,1]);
            cmd.Parameters.AddWithValue("@address", address[addressID, 2]);
            cmd.Parameters.AddWithValue("@quantity",OrderDetail.Quantity);
            cmd.Parameters.AddWithValue("@calcTax",calcTax());
            cmd.Parameters.AddWithValue("@priceTotal",calcTotal());
            cmd.Parameters.AddWithValue("@weightTotal",OrderDetail.calcWeight());
            if (Credit == null) cmd.Parameters.AddWithValue("@Credit",0);
            else cmd.Parameters.AddWithValue("@Credit", Credit.Amount);
            if (Cash == null) cmd.Parameters.AddWithValue("@Cash", 0);
            else cmd.Parameters.AddWithValue("@Cash", Cash.Amount);
            if (Check == null) cmd.Parameters.AddWithValue("@Check", 0);
            else cmd.Parameters.AddWithValue("@Check", Check.Amount);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public  void getOrderList(int userID)
        {
            SqlCommand cmd = new SqlCommand("select * from OrderTable inner join Item on OrderTable.itemID=Item.ID where OrderTable.userID=@userID", connection);
            cmd.Parameters.AddWithValue("@userID", userID);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Item tempItem = new Item();
                tempItem.ID = (int)sdr["ID"];
                tempItem.Name = (string)sdr["Name"];
                tempItem.Price = (double)sdr["Price"];
                tempItem.Tax = (double)sdr["Tax"];
                tempItem.Weight = (double)sdr["Weight"];
                tempItem.Description = (string)sdr["Description"];

                Orders.Add(new Order() { OrderID = (int)sdr["ID"], OrderDate = (DateTime)sdr["date"], OrderState = (int)sdr["state"], UserID = userID, ItemID = (int)sdr["itemID"], addressTitle = (string)sdr["addressTitle"],address=(string)sdr["address"], OrderDetail = new OrderDetail(tempItem, (int)sdr["Quantity"]),Item=tempItem});
            }
        }
        public Order()
        {
            if (Orders==null)
            {
                Orders = new List<Order>();
            }
        }

    }
}
