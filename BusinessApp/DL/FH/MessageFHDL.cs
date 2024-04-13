using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class MessageFHDL : IMessageDL
    {
        public void SendMessage(Message message)
        {
            string path = UtilityFunctions.GetPath("Messages.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{message.GetSenderID()}, {message.GetReceiverID()}, {message.GetMessageText()}, {DateTime.Now}");
            }
        }

        public List<Message> ReceiveMessages(int id, string query)
        {
            List<Message> messages = new List<Message>();
            string path = UtilityFunctions.GetPath("Messages.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                if (query == "SELECT * FROM Messages WHERE ReceiverID = @ID ORDER BY Timestamp ASC")
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5 && parts[2].Trim()==id.ToString() || parts[1].Trim()==id.ToString())
                        {
                            int senderID = Convert.ToInt32(parts[1].Trim());
                            string messageText = parts[3].Trim();
                            string time = parts[4].Trim();
                            DateTime Time = Convert.ToDateTime(time);

                            Message message = new Message(senderID, id, messageText, Time);
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
                            int senderID = Convert.ToInt32(parts[1].Trim());
                            string messageText = parts[3].Trim();
                            string time = parts[4].Trim();
                            DateTime Time = Convert.ToDateTime(time);
                            Console.WriteLine(id.ToString()+" "+senderID+" "+ parts[2]+" "+ messageText);
                            if ((parts[1].Trim() == senderID.ToString() && parts[2].Trim() == id.ToString()) || (senderID.ToString()== id.ToString()))
                            {
                                Console.WriteLine(id.ToString()+" "+messageText);
                                Message message = new Message(senderID, id, messageText, Time);
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
            string path = UtilityFunctions.GetPath("Messages.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{employeeID}, {customerID}, {replyText}, {DateTime.Now}");
            }
        }
    }
}
