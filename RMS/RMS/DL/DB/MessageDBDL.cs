using RMS.BL;
using RMS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

                string query = "SELECT TOP 1 E.ID, COALESCE(COUNT(M.MessageID), 0) AS MessageCount\nFROM Employees E \nJOIN Users U ON E.UserID = U.ID\nLEFT JOIN [Messages] M ON E.ID = -1 * M.ReceiverID\nWHERE U.Role = 'Admin'\nGROUP BY E.ID\nORDER BY COALESCE(COUNT(M.MessageID), 0)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
            return -1;
        }

        public Message GetNewMessage(int receiverID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Messages WHERE Timestamp >= DATEADD(SECOND, -6, GETDATE()) AND ReceiverID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", receiverID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int senderID = Convert.ToInt32(reader["SenderID"]);
                    string messageText = Convert.ToString(reader["MessageText"]);
                    DateTime time = Convert.ToDateTime(reader["Timestamp"]);
                    Message message = new Message(senderID, receiverID, messageText, time);
                    return message;
                }
            }
            return null;
        }

        public bool HasChat(int receiverID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(MessageID)  FROM Messages WHERE ReceiverID = @ID OR SenderID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ID", receiverID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int count =  reader.GetInt32(0);
                    if(count>0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetReceiverID(int senderID) //get admin's id
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT ReceiverID FROM Messages WHERE SenderID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ID", senderID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
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
                List<Message> messages = new List<Message>();
                while (reader.Read())
                {
                    int messageID = Convert.ToInt32(reader["MessageID"]);
                    int senderID = Convert.ToInt32(reader["SenderID"]);
                    int receiverID = Convert.ToInt32(reader["ReceiverID"]);
                    string messageText = Convert.ToString(reader["MessageText"]);
                    DateTime time = Convert.ToDateTime(reader["Timestamp"]);
                    Message message = new Message(messageID, senderID, receiverID, messageText, time);
                    messages.Add(message);
                }
                return messages;
            }
        }

        public void DeleteEmptyMessages()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "DELETE FROM Messages WHERE MessageText = ''";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetCustomersNames(int empID)
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT DISTINCT C.ID, C.Username FROM Customers C JOIN [Messages] M ON C.ID = M.SenderID WHERE ReceiverID=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", empID*-1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    Customer customer = new Customer(id, username);
                    customers.Add(customer);
                }
            }
            return customers;
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
