using RMS.BL;
using SSC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class MessageDBDL : IMessageDL
    {
        public void SendMessage(Message msg)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string query = "INSERT INTO Messages (SenderID, ReceiverID, MessageText, Timestamp) VALUES (@SenderID, @ReceiverID, @MessageText, @Timestamp)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SenderID", msg.GetSenderID());
                command.Parameters.AddWithValue("@ReceiverID", msg.GetReceiverID());
                command.Parameters.AddWithValue("@MessageText", msg.GetMessageText());
                command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

        public int GetAvailableEmployee()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string query = "SELECT TOP 1 E.ID FROM Employees E JOIN Users U ON U.ID = E.UserID WHERE U.Role = 'Admin';";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return -1;
        }

        public List<Message> ReceiveMessages(int id, string query)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                List <Message> messages = new List<Message>();
                while (reader.Read())
                {
                    int senderID = Convert.ToInt32(reader["SenderID"]);
                    string messageText = Convert.ToString(reader["MessageText"]);
                    DateTime time = Convert.ToDateTime(reader["Timestamp"]);
                    Message message = new Message(senderID, id, messageText,time);
                    messages.Add(message);
                }
                return messages;
            }
        }

        public void ReplyToMessage(string replyText, int employeeID, int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "INSERT INTO Messages (SenderID, ReceiverID, MessageText, Timestamp) VALUES (@SenderID, @ReceiverID, @MessageText, @Timestamp)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SenderID", employeeID);
                command.Parameters.AddWithValue("@ReceiverID", customerID);
                command.Parameters.AddWithValue("@MessageText", replyText);
                command.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
    }
}
