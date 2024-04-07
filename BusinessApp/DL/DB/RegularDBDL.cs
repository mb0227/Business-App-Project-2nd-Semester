using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using SSC;

namespace RMS.DL
{
    public class RegularDBDL : IRegularDL
    {
        public void StoreRegularInDB(Regular regular)
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

                        Regular regular = new Regular(username,id, loyaltyPoints, customerID);
                        regulars.Add(regular);
                    }
                }
            }
            return regulars;
        }
    }
}
