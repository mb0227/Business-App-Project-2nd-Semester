using RMS.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Utility;

namespace RMS.DL
{
    public class FeedbackDBDL : IFeedbackDL
    {
        public void SaveReview(Feedback feedback)
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

        public List<Feedback> GetReviews()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Feedback", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Feedback> feedbacks = new List<Feedback>();
                while (reader.Read())
                {
                    feedbacks.Add(new Feedback(reader.GetString(1), reader.GetInt32(2)));
                }
                return feedbacks;
            }
        }
    }
}
