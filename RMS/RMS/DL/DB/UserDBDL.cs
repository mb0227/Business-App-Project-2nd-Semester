using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using RMS.BL;
using SSC;
using System.Text.RegularExpressions;
using System.IO;

namespace RMS.DL
{
    public class UserDBDL : IUserDL, IPhotoDL
    {
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
                    return true;
                }
            }
            return false;
        }

        public int GetUserID(string email)
        {
            int userID = -1;
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
            return userID;
        }

        public int GetUserID(int id)
        {
            int userID = -1;
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT U.ID FROM Users U JOIN Customers C on U.ID = C.UserID WHERE C.ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }
                }
            }
            return userID;
        }

        public int GetUserIDEmp(int id)
        {
            int userID = -1;

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT U.ID FROM Users U JOIN Employees E on U.ID = E.UserID WHERE E.ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetInt32(0);
                    }
                }
            }
            return userID;
        }

        public string SearchUserForRole(string email, string password)
        {
            string role = "";
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
            return role;
        }

        public void SaveImage(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "INSERT INTO UserPictures(UserID) VALUES(@UserID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateImage(int userID, byte[] photo)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE UserPictures SET Image=@Image WHERE UserID=@ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Image", photo);
                    command.Parameters.AddWithValue("@ID", userID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Image LoadImage(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT Image FROM UserPictures WHERE UserID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", userID);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value && result is byte[])
                    {
                        byte[] imageData = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
