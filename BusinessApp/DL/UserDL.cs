using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSC
{
    public class UserDL
    {
        public static List<User> Users = new List<User>();

        public static void ReadDataIntoList()
        {
            
        }
        //public static bool AddUser(User user)
        //{
            //string query = "INSERT INTO Users(Username,Password, Role) VALUES (@Username,@Password,@Role)";
            //SqlConnection con = new SqlConnection(UtilityFunctions.GetConnectionString());
            //con.Open();
            //SqlCommand command = new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@Username", user.GetName());
            //command.Parameters.AddWithValue("@Password", user.GetPassword());
            //command.Parameters.AddWithValue("@Role", user.GetRole());

            //int x = command.ExecuteNonQuery();

            //con.Close();
            //if (x == -1)
            //    return false;
            //else
            //    return true;
        //}

        //public static bool IsUser(string username, string password)
        //{
        //    string query = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
        //    SqlConnection con = new SqlConnection(connectionString);
        //    con.Open();
        //    SqlCommand command = new SqlCommand(query, con);
        //    command.Parameters.AddWithValue("@Username", username);
        //    command.Parameters.AddWithValue("@Password", password);
        //    SqlDataReader reader = command.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        con.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        con.Close();
        //        return false;
        //    }
        //}
    }
}
