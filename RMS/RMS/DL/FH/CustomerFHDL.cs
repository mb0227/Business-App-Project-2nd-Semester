using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RMS.BL;
using RMS.Utility;

namespace RMS.DL
{
    public class CustomerFHDL : ICustomerDL
    {
        private readonly string path = UtilityFunctions.GetPath("Customers.txt");
        public void SaveCustomer(Customer customer)
        {
            int id = UtilityFunctions.AssignID(path);

            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{id},{customer.GetUsername()}, {customer.GetContact()}, {customer.GetStatus()}, {customer.GetGender()}, {UtilityFunctions.GetCartString(customer.GetCart())},{customer.GetUserID()}");
            }
        }

        public void SaveCart(Customer customer)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length == 7 && parts[1].Trim() == customer.GetUsername())
                {
                    parts[5] = UtilityFunctions.GetCartString(customer.GetCart());
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines(path, lines);
        }

        public int GetCustomerID(string username)
        {
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7 && parts[1].Trim() == username)
                    {
                        return int.Parse(parts[0].Trim());
                    }
                }
            }
            return -1;
        }

        public void UpdateStatus(string status, int id)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length == 7 && parts[0].Trim() == id.ToString())
                {
                    parts[3] = status;
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines(path, lines);
        }

        public Customer SearchCustomerById(int userID)
        {
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        string username = parts[1].Trim();
                        if (parts[6].Trim().ToString() == (userID.ToString()))
                        {
                            string contact = parts[2].Trim();
                            string status = parts[3].Trim();
                            string gender = parts[4].Trim();
                            string productsOrdered = parts[5].Trim();
                            return new Customer(Convert.ToInt32(parts[0]), username, contact, status, gender, UtilityFunctions.GetCartList(productsOrdered), userID);
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateCredentials(string newCred, string credType, int userID)
        {
            string path = "";
            if (credType == "username")
                path = UtilityFunctions.GetPath("Customers.txt");
            else if (credType == "password")
                path = UtilityFunctions.GetPath("Users.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (credType == "username")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length == 7 && parts[6].Trim() == userID.ToString())
                        {
                            parts[1] = newCred;
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                else if (credType == "password")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length == 4 && parts[0].Trim() == userID.ToString())
                        {
                            parts[2] = newCred;
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }


        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        int id = int.Parse(parts[0].Trim());
                        string username = parts[1].Trim();
                        string contact = parts[2].Trim();
                        string status = parts[3].Trim();
                        string gender = parts[4].Trim();
                        string productsOrdered = parts[5].Trim();
                        int userId = int.Parse(parts[6].Trim());
                        customers.Add(new Customer(id, username, contact, status, gender, UtilityFunctions.GetCartList(productsOrdered), userId));
                    }
                }
            }

            return customers;
        }


        public void UpdateCart(Customer customer)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length == 7 && parts[1].Trim() == customer.GetUsername())
                {
                    parts[5] = UtilityFunctions.GetCartString(customer.GetCart());
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines(path, lines);
        }

        public bool UsernameAlreadyExists(string username)
        {
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7 && parts[1].Trim() == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Customer ForgotPassword(int userID)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7 && parts[6].Trim() == userID.ToString())
                    {
                        int id = int.Parse(parts[0]);
                        string username = parts[1];
                        string contact = parts[2];
                        string status = parts[3];
                        string gender = parts[4];
                        string productsOrdered = parts[5];
                        return new Customer(id, username, contact, status, gender, UtilityFunctions.GetCartList(productsOrdered), userID);
                    }
                }
            }
            return null;
        }

        public void DeleteCustomer(int id, string status, int userid)
        {
            string path = "";
            if (status.ToLower() == "regular")
                path = UtilityFunctions.GetPath("Regular.txt");
            else if (status.ToLower() == "vip")
                path = UtilityFunctions.GetPath("VIP.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<string> newLines = new List<string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && int.Parse(parts[2]) == id && status.ToLower() == "regular")
                        continue;
                    else if (parts.Length == 4 && int.Parse(parts[3].Trim()) == id && status.ToLower() == "vip")
                        continue;
                    newLines.Add(line);
                }
                File.WriteAllLines(path, newLines);
            }

            path = UtilityFunctions.GetPath("Customers.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<string> newLines = new List<string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7 && int.Parse(parts[0].Trim()) == id)
                    {
                        continue;
                    }
                    newLines.Add(line);
                }
                File.WriteAllLines(path, newLines);
            }

            path = UtilityFunctions.GetPath("Users.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<string> newLines = new List<string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4 && int.Parse(parts[0]) == userid)
                    {
                        continue;
                    }
                    newLines.Add(line);
                }
                File.WriteAllLines(path, newLines);
            }
        }
    }
}
