using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using RMS.UI;

namespace RMS.DL
{
    public class RegularDBDL : IRegularDL
    {
        public void SaveRegular(Regular regular)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Regular(LoyaltyPoints, CustomerID) VALUES (@LoyaltyPoints, @CustomerID)", connection);
                command.Parameters.AddWithValue("@LoyaltyPoints", regular.GetLoyaltyPoints());
                command.Parameters.AddWithValue("@CustomerID", regular.GetCustomerID());
                command.ExecuteNonQuery();
            }
        }

        public void UpdateRegular(Regular regular)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Regular SET LoyaltyPoints = @LoyaltyPoints WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@LoyaltyPoints", regular.GetLoyaltyPoints());
                command.Parameters.AddWithValue("@CustomerID", regular.GetCustomerID());
                command.ExecuteNonQuery();
            }
        }

        public Regular GetRegular(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Regular WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int loyaltyPoints = reader.GetInt32(1);

                        return new Regular(id, loyaltyPoints, customerID);
                    }
                }
                return null;
            }
        }

        public List<Regular> GetRegulars()
        {
            List<Regular> regulars = new List<Regular>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT R.ID, C.Username, R.LoyaltyPoints, R.CustomerID FROM Customers C JOIN Regular R ON C.ID = R.CustomerID;", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        int loyaltyPoints = reader.GetInt32(2);
                        int customerID = reader.GetInt32(3);

                        Regular regular = new Regular(username, id, loyaltyPoints, customerID);
                        regulars.Add(regular);
                    }
                }
            }
            return regulars;
        }

        public void DeleteRegular(int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Regular WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
