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
    }
}
