using RMS.BL;
using RMS.UI;
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
        private readonly string path = UtilityFunctions.GetPath("Notifications.txt");
        private readonly string path2 = UtilityFunctions.GetPath("ViewNotifications.txt");
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
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{n.GetMessage()}");
            }

            List<int> customerIDs = GetAllCustomerIDs();
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

            if (File.Exists(path) && File.Exists(path2))
            {
                string[] lines = File.ReadAllLines(path);
                string[] lines2 = File.ReadAllLines(path2);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    int id = Convert.ToInt32(parts[0].Trim());
                    foreach (string line2 in lines2)
                    {
                        string[] parts2 = line2.Split(',');
                        if (parts2.Length == 4 && parts2[1].Trim() == customerId.ToString() && parts2[2].Trim() == id.ToString() && parts2[3].Trim() == "0")
                        {
                            notifications.Add(parts[1].Trim());
                        }
                    }
                }
            }
            return notifications;
        }

        public void MarkAsRead(int customerId)
        {
            if (File.Exists(path2))
            {
                string[] lines = File.ReadAllLines(path2);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 4 && parts[3].Trim() == "0" && parts[1].Trim() == customerId.ToString())
                    {
                        lines[i] = $"{parts[0]},{parts[1]},{parts[2]},1";
                    }
                }
                File.WriteAllLines(path2, lines);
            }
        }
    }
}
