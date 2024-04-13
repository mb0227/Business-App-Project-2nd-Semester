using RMS.BL;
using RMS.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class NotificationDBDL : INotificationDL
    {
        public List<int> GetAllCustomerIDs()
        {
            List<int> customerIDs = new List<int>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string sqlQuery = "SELECT ID FROM Customers"; // Adjust the table name if necessary

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = reader.GetInt32(reader.GetOrdinal("ID"));
                            customerIDs.Add(customerId);
                        }
                    }
                }
            }
            return customerIDs;
        }

        public void SaveNotification(Notification n)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Notifications(Notification) VALUES (@Notification); SELECT SCOPE_IDENTITY()", connection);
                command.Parameters.AddWithValue("@Notification", n.GetMessage());
                int notificationId = Convert.ToInt32(command.ExecuteScalar());

                foreach (int customerId in GetAllCustomerIDs())
                {
                    command = new SqlCommand("INSERT INTO ViewNotification(CustomerID, NotificationID, HasSeen) VALUES (@CustomerID, @NotificationID, 0)", connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@NotificationID", notificationId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetNotifications(int customerId)
        {
            List<string> notifications = new List<string>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string sqlQuery = @"
            SELECT N.Notification 
            FROM Notifications N
            INNER JOIN ViewNotification VN ON N.ID = VN.NotificationID
            WHERE VN.CustomerID = @CustomerID AND VN.HasSeen = 0";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string notification = reader["Notification"].ToString();
                            notifications.Add(notification);
                        }
                    }
                }
            }

            return notifications;
        }

        public void MarkAsRead(int customerId)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string sqlQuery = @"
            UPDATE ViewNotification 
            SET HasSeen = 1
            WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
