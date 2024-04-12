using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class NotificationFHDL : INotificationDL
    {
        public List<int> GetAllCustomerIDs()
        {
            List<int> customerIDs = new List<int>();
            string path = UtilityFunctions.GetPath("Customers.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        int customerID = Convert.ToInt32(parts[0].Trim());
                        customerIDs.Add(customerID);
                    }
                }
            }
            return customerIDs;
        }

        public void SaveNotification(Notification n)
        {
            string path = UtilityFunctions.GetPath("Notifications.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{n.GetMessage()}");
            }

            List<int> customerIDs = GetAllCustomerIDs();
            string path2 = UtilityFunctions.GetPath("ViewNotifications.txt");
            int id2 = UtilityFunctions.AssignID(path2);
            using (StreamWriter writer = File.AppendText(path2))
            {
                foreach (int customerID in customerIDs)
                {
                    writer.WriteLine($"{id2},{customerID}, {id}, 0");
                }
            }
        }

        public List<string> GetNotifications(int customerId)
        {
            List<string> notifications = new List<string>();
            string path = UtilityFunctions.GetPath("Notifications.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        notifications.Add(parts[1].Trim());
                    }
                }
            }
            return notifications;
        }

        public void MarkAsRead(int customerId)
        {
            string path = UtilityFunctions.GetPath("ViewNotifications.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 4 && parts[3]=="0" && parts[1] == customerId.ToString())
                    {
                        lines[i] = $"{parts[0]},{parts[1]},{parts[2]},1";
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }
    }
}
