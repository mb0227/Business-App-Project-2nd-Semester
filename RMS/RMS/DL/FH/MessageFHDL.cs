using RMS.BL;
using RMS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class MessageFHDL : IMessageDL
    {
        private readonly string path = UtilityFunctions.GetPath("Messages.txt");
        public void SendMessage(Message message)
        {
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{message.GetSenderID()}, {message.GetReceiverID()}, {message.GetMessageText()}, {DateTime.Now}");
            }
        }

        public void DeleteEmptyMessages()
        {
            string[] lines = File.ReadAllLines(path);
            List<string> newLines = new List<string>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length==5 )
                {
                    if(parts[3] == "")
                        continue;
                }
                newLines.Add(line);
            }
            File.WriteAllLines(path, newLines);
        }   

        public List<Customer> GetCustomersNames(int empID)
        {
            List<Customer> customers = new List<Customer>();
            HashSet<string> encounteredNames = new HashSet<string>(); 
            string path2 = UtilityFunctions.GetPath("Customers.txt");

            using (StreamReader reader = new StreamReader(path2))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int id = int.Parse(parts[0]);
                    string username = parts[1];

                    if (!encounteredNames.Contains(username))
                    {
                        using (StreamReader reader2 = new StreamReader(path))
                        {
                            string line2;
                            while ((line2 = reader2.ReadLine()) != null)
                            {
                                string[] parts2 = line2.Split(',');
                                int senderID = int.Parse(parts2[1]);
                                int receiverID = int.Parse(parts2[2]);

                                if (id == senderID && receiverID == empID*-1)
                                {
                                    Customer customer = new Customer(id, username);
                                    customers.Add(customer);
                                    encounteredNames.Add(username); 
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return customers;
        }



        public bool HasChat(int receiverID)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int messageReceiverID = int.Parse(parts[2].Trim());
                    int messageSenderID = int.Parse(parts[1].Trim());

                    if (messageReceiverID == receiverID || messageSenderID == receiverID)
                    {
                        return true;
                    }
                }
            }
           
            return false;
        }

        public int GetReceiverID(int senderID)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int messageSenderID = int.Parse(parts[1].Trim());
                    int messageReceiverID = int.Parse(parts[2].Trim());
           
                    if (messageSenderID == senderID)
                    {
                        return messageReceiverID;
                    }
                }
            }
            return -1;
        }

        public Message GetNewMessage(int receiverID)
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int senderID = int.Parse(parts[1]);
                int messageReceiverID = int.Parse(parts[2]);
                string messageText = parts[3];
                DateTime timestamp = DateTime.Parse(parts[4]);

                if (messageReceiverID == receiverID && DateTime.Now.Subtract(timestamp).TotalSeconds <= 6)
                {
                    return new Message(senderID, receiverID, messageText, timestamp);
                }
            }

            return null;
        }

        public List<Message> ReceiveMessages(int id, string query)
        {
            List<Message> messages = new List<Message>();

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                if (query == "SELECT * FROM Messages WHERE ReceiverID = @ID OR SenderID=@ID ORDER BY Timestamp ASC")
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5 && parts[2].Trim() == id.ToString())
                        {
                            int messageID = Convert.ToInt32(parts[0].Trim());
                            int senderID = Convert.ToInt32(parts[1].Trim());
                            string messageText = parts[3].Trim();
                            string time = parts[4].Trim();
                            DateTime Time = Convert.ToDateTime(time);
                            Message message = new Message(messageID, senderID, id, messageText, Time);
                            messages.Add(message);
                        }
                    }
                }
                else
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            int messageID = Convert.ToInt32(parts[0].Trim());
                            int senderID = Convert.ToInt32(parts[1].Trim());
                            string messageText = parts[3].Trim();
                            string time = parts[4].Trim();
                            DateTime Time = Convert.ToDateTime(time);
                            if ((parts[1].Trim() == senderID.ToString() && parts[2].Trim() == id.ToString()) || (senderID.ToString() == id.ToString()))
                            {
                                Console.WriteLine(id.ToString() + " " + messageText);
                                Message message = new Message(messageID, senderID, id, messageText, Time);
                                messages.Add(message);
                            }
                        }
                    }

                }
            }
            return messages;
        }

        public int GetAvailableEmployee()
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4 && parts[3].Trim().ToLower() == "admin")
                        {
                            int id = int.Parse(parts[0]);
                            path = UtilityFunctions.GetPath("Employees.txt");
                            if (File.Exists(path))
                            {
                                using (StreamReader reader2 = new StreamReader(path))
                                {
                                    string line2;
                                    while ((line2 = reader2.ReadLine()) != null)
                                    {
                                        string[] parts2 = line2.Split(',');
                                        if (parts2.Length == 7 && parts2[6].Trim() == id.ToString())
                                        {
                                            return Convert.ToInt32(parts2[0]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return -1;
        }

        public void ReplyToMessage(string replyText, int employeeID, int customerID)
        {
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{employeeID}, {customerID}, {replyText}, {DateTime.Now}");
            }
        }
    }
}
