using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderAutomation
{
    public class User
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=OrderAutomation;Integrated Security=True");
        public int UserID { get; private set; }
        public string Name { get; private set; }
        public string[,] UserAddress = new string[5, 3];
        public string UserPhone { get; private set; }
        private string UserName { get; set; }
        private string UserPassword { get; set; }
        public Boolean UserState { get; private set; }

        public List<User> Users;
        public bool ConnectionQuery(string userName, string password)
        {

            SqlCommand cmd = new SqlCommand("select * from UserTable", connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if ((sdr["userName"].ToString() == userName) && (sdr["userPassword"].ToString() == password))
                {
                    this.UserID = (int)sdr["userID"];
                    this.Name = (string)sdr["Name"];
                    this.UserPhone = (string)sdr["userPhone"];
                    this.UserName = (string)sdr["userName"];
                    this.UserPassword = (string)sdr["userPassword"];
                    this.UserState = (Boolean)sdr["userState"];
                    connection.Close();
                    SqlCommand cmd1 = new SqlCommand("select * from UserAddress where UserID=@userID", connection);
                    cmd1.Parameters.AddWithValue("@userID", this.UserID);
                    connection.Open();
                    sdr = cmd1.ExecuteReader();
                    int i = 0;
                    while (sdr.Read())
                    {
                        UserAddress[i, 0] = sdr["AddressID"].ToString();
                        UserAddress[i, 1] = (string)sdr["AddressTitle"];
                        UserAddress[i, 2] = (string)sdr["Address"];
                        i++;
                    }
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
        public bool UserNameUsedControl(string UserName)
        {
            SqlCommand cmd = new SqlCommand("select COUNT(userName) from UserTable where userName=@userName", connection);
            cmd.Parameters.AddWithValue("@userName", UserName);
            connection.Open();
            int userCount = (int)cmd.ExecuteScalar();
            connection.Close();
            if (userCount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void UserAdd(string Name, string UserPhone, string UserName, string UserPassword, string AddressTitle, string Address)
        {
            this.Name = Name;
            this.UserPhone = UserPhone;
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserAddress[0, 0] = AddressTitle;
            this.UserAddress[0, 1] = Address;
            SqlCommand cmd = new SqlCommand("insert into UserTable(Name,userPhone,userName,userPassword) values (@Name,@userPhone,@userName,@userPassword)", connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@userPhone", this.UserPhone);
            cmd.Parameters.AddWithValue("@userName", this.UserName);
            cmd.Parameters.AddWithValue("@userPassword", this.UserPassword);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            if (Address != "")
            {
                cmd.CommandText = "select MAX(userID) from UserTable";
                connection.Open();
                int maxUserID = (int)cmd.ExecuteScalar();
                connection.Close();
                cmd.CommandText = "insert into UserAddress(AddressTitle,Address,UserID) values (@AddressTitle,@Address,@UserID)";
                cmd.Parameters.AddWithValue("@AddressTitle", this.UserAddress[0, 0]);
                cmd.Parameters.AddWithValue("@address", this.UserAddress[0, 1]);
                cmd.Parameters.AddWithValue("@UserID", maxUserID);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }
        public void UserUpdate(int UserID,string Name, string UserPhone, string UserPassword)
        {
            this.Name = Name;
            this.UserPhone = UserPhone;
            this.UserPassword = UserPassword;
            this.UserID = UserID;
            SqlCommand cmd = new SqlCommand("update UserTable set Name=@Name,userPhone=@userPhone,userPassword=@userPassword where userID=@userID",connection);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@userPhone", this.UserPhone);
            cmd.Parameters.AddWithValue("@userPassword", this.UserPassword);
            cmd.Parameters.AddWithValue("@userID", this.UserID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UserDelete(int userID)
        {
            UserID = userID;
            SqlCommand cmd = new SqlCommand("delete from UserTable where userID=@userID",connection);
            cmd.Parameters.AddWithValue("@userID",UserID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            SqlCommand cmd1 = new SqlCommand("delete from UserAddress where userID=@UserID",connection);
            cmd1.Parameters.AddWithValue("@UserID", UserID);
            connection.Open();
            cmd1.ExecuteNonQuery();
            connection.Close();
        }
        public void AddressUpdate(int ListNumber, string AddressTitle, string Address)
        {
            UserAddress[ListNumber, 1] = AddressTitle;
            UserAddress[ListNumber, 2] = Address;
            SqlCommand cmd = new SqlCommand("update UserAddress set AddressTitle=@AddressTitle,Address=@Address where AddressID=@AddressID",connection);
            cmd.Parameters.AddWithValue("@AddressTitle",UserAddress[ListNumber, 1]);
            cmd.Parameters.AddWithValue("@Address", UserAddress[ListNumber, 2]);
            cmd.Parameters.AddWithValue("@AddressID", UserAddress[ListNumber, 0]);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void AddressAdd(int ListNumber, string AddressTitle, string Address)
        {
            SqlCommand cmd1 = new SqlCommand("select MAX(AddressID) from UserAddress",connection);
            connection.Open();
            int maxAddressID = (int)cmd1.ExecuteScalar();
            connection.Close();
            UserAddress[ListNumber, 0] = maxAddressID.ToString();
            UserAddress[ListNumber, 1] = AddressTitle;
            UserAddress[ListNumber, 2] = Address;
            SqlCommand cmd = new SqlCommand("insert into UserAddress(AddressTitle,Address,UserID) values (@AddressTitle,@Address,@UserID)", connection);
            cmd.Parameters.AddWithValue("@AddressTitle", UserAddress[ListNumber, 1]);
            cmd.Parameters.AddWithValue("@Address", UserAddress[ListNumber, 2]);
            cmd.Parameters.AddWithValue("@UserID",UserID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void AddressRemove(int ListNumber)
        {
            int addressID = Convert.ToInt32(UserAddress[ListNumber, 0]);
            for (int i = 0; i < 3; i++)
                UserAddress[ListNumber, i] = null;
            SqlCommand cmd = new SqlCommand("delete from UserAddress where AddressID=@AddressID",connection);
            cmd.Parameters.AddWithValue("@AddressID",addressID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void getAddress(int userID)
        {
            SqlCommand cmd = new SqlCommand("select * from UserAddress where UserID=@userID", connection);
            cmd.Parameters.AddWithValue("@userID",userID);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            for (int j = 0; j < UserAddress.Length / 3; j++)
            {
                UserAddress[j, 0] = null;
                UserAddress[j, 1] = null;
                UserAddress[j, 2] = null;
            }
            int i = 0;
            while (sdr.Read())
            {
                UserAddress[i, 0] = sdr["AddressID"].ToString();
                UserAddress[i, 1] = (string)sdr["AddressTitle"];
                UserAddress[i, 2] = (string)sdr["Address"];
                i++;
            }
            connection.Close();
        }
        public User()
        {
            if (Users==null)
            {
                Users = new List<User>();
            }
        }
        
        public void getUsers()
        {

            SqlCommand cmd = new SqlCommand("select * from UserTable where userState='0'", connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Users.Add(new User { UserID = (int)sdr["userID"], UserName = (string)sdr["userName"],Name=(string)sdr["Name"],UserPhone=(string)sdr["userPhone"]});
            }
            connection.Close();
        }
    }
}
