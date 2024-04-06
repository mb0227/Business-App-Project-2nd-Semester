using RMS.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSC;

namespace RMS.DL
{
    public class FeedbackDL
    {
        public static void InsertReviewInDatabase(Feedback feedback)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Feedback(Reviews, CustomerID) VALUES (@Reviews, @CustomerID)", connection);
                command.Parameters.AddWithValue("@Reviews", feedback.GetReview());
                command.Parameters.AddWithValue("@CustomerID", feedback.GetCustomerID());
                command.ExecuteNonQuery();
            }
        }
    }
}
