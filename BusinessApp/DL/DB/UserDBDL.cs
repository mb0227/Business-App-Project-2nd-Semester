using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using RMS.BL;
using SSC;
using System.Text.RegularExpressions;


namespace RMS.DL
{
    public class UserDBDL : IUserDL
    {
        private static List<User> Users = new List<User>();
        public static List<User> GetUsers()
        {
            return Users;
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public bool EmailAlreadyExists(string email)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return  true;
                }
            }
            return false;
        }

        public static void ReadDataIntoList()
        {            
        }

        public void SaveUser(User user)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "INSERT INTO Users(Email,Password, Role) VALUES (@Email,@Password,@Role)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", user.GetEmail());
                command.Parameters.AddWithValue("@Password", user.GetPassword());
                command.Parameters.AddWithValue("@Role", user.GetRole());
                command.ExecuteNonQuery();
            }
        }

        public int GetUserID(string email)
        {
            int userID = -1; // Default value if user is not found

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT ID FROM Users WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }
                }
            }
            return userID; // Return -1 if user is not found 
        }

        public int GetUserID(int id)
        {
            int userID = -1; 

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT U.ID FROM Users U JOIN Customers C on U.ID=C.UserID WHERE C.UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }
                }
            }
            return userID; // Return -1 if user is not found 
        }

        public string SearchCustomerForRole(string email, string password)
        {
            string role = ""; // Default value if user is not found

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader.GetString(0);
                    }
                }
            }
            return role; // Return "" if user is not found 
        }
    }
}
