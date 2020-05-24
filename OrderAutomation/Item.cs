using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderAutomation
{
    public class Item
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OrderAutomation;Integrated Security=True");
        public int ID { get;  set; }
        public string Name { get;  set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        public List<Item> Items;
        public double Tax { get; set; }
        public Item()
        {
            if (Items == null)
            {
                Items = new List<Item>();
            }
        }
        public void getItem()
        {
            SqlCommand cmd = new SqlCommand("select * from Item",connection);
            connection.Open();
           
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Items.Add(new Item { ID = (int)sdr["ID"], Name = (string)sdr["Name"], Price = (double)sdr["Price"], Description = (string)sdr["Description"], Weight = (double)sdr["Weight"] ,Tax=(double)sdr["Tax"]});
            }
            connection.Close();
        }

        public int maxItemID()
        {
            SqlCommand cmd = new SqlCommand("select MAX(ID) from Item",connection);
            connection.Open();
            int maxItemID = (int)cmd.ExecuteScalar();
            connection.Close();
            if (maxItemID<=0)
            {
                return 0;
            }
            else
            {
                return maxItemID;
            }
            
        }

        public void ItemAdd()
        {
            SqlCommand cmd = new SqlCommand("insert into Item(Name,Price,Description,Weight,Tax) values (@Name,@Price,@Description,@Weight,@Tax)",connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@Weight", this.Weight);
            cmd.Parameters.AddWithValue("@Tax", this.Tax);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void ItemRemove(int ID)
        {
            SqlCommand cmd = new SqlCommand("delete from Item where ID=@ID",connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ItemUpdate()
        {
            SqlCommand cmd = new SqlCommand("update Item set Name=@Name,Price=@Price,Description=@Description,Weight=@Weight,Tax=@Tax where ID=@ID",connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@Price", this.Price);
            cmd.Parameters.AddWithValue("@Description", this.Description);
            cmd.Parameters.AddWithValue("@Weight", this.Weight);
            cmd.Parameters.AddWithValue("@Tax", this.Tax);
            cmd.Parameters.AddWithValue("@ID", this.ID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
