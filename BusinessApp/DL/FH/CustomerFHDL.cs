using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RMS.BL;
using SSC;
using SSC.UI;

namespace RMS.DL
{
    public class CustomerFHDL : ICustomerDL
    {
        private List<Customer> Customers = new List<Customer>();
        public void SaveCustomer(Customer customer)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            int id = UtilityFunctions.AssignID(path);

            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{id},{customer.GetUsername()}, {customer.GetContact()}, {customer.GetStatus()}, {customer.GetGender()}, {UtilityFunctions.GetCartString(customer.GetCart())},{customer.GetUserID()}");
            }
        }

        public int GetCustomerID(string username)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");

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

        public void SaveCart(Customer customer)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{customer.GetUsername()}, {UtilityFunctions.GetCartString(customer.GetCart())}");
            }
        }

        public Customer SearchCustomerById(int userID)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        string username = parts[1].Trim();
                        if (parts[0].Equals(userID.ToString()))
                        {
                            string contact = parts[2].Trim();
                            string status = parts[3].Trim();
                            string gender = parts[4].Trim();
                            List<OrderedProduct> cart = new List<OrderedProduct>();
                            string productsOrdered = parts[5].Trim();
                            string[] productItems = productsOrdered.Split(',');
                            foreach (string productItem in productItems)
                            {
                                string[] itemParts = productItem.Trim().Split(new string[] { " of " }, StringSplitOptions.None);
                                if (itemParts.Length == 2)
                                {
                                    string quantity = itemParts[0].Trim();
                                    string productName = itemParts[1].Trim();
                                    Product product = ObjectHandler.GetProductDL().SearchProductByName(productName);
                                    if (product != null)
                                    {
                                        cart.Add(new OrderedProduct(product, quantity));
                                    }
                                }
                            }
                            Customer customer = new Customer(Convert.ToInt32(parts[0]), username, contact, status, gender, cart, userID);
                        }
                    }
                }
            }
            return null;
        }
        public void UpdateStatus(string status, int id)
        {

        }
        public void UpdateCredentials(string newCred, string credType, int userID)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            string tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int id = int.Parse(parts[0].Trim());
                    string username = parts[1].Trim();
                    string contact = parts[2].Trim();
                    string status = parts[3].Trim();
                    string gender = parts[4].Trim();
                    string productsOrdered = parts[5].Trim();

                    if (id == userID)
                    {
                        if (credType == "username")
                        {
                            username = newCred;
                        }
                        else if (credType == "password")
                        {
                            // Assuming password is not stored in this file
                        }
                    }

                    string updatedLine = $"{id}, {username}, {contact}, {status}, {gender}, {productsOrdered}";
                    writer.WriteLine(updatedLine);
                }
            }

            File.Delete(path);
            File.Move(tempFile, path);
        }

        public List<Customer> GetCustomers()
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            List<Customer> customers = new List<Customer>();

            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 6)
                    {
                        int id = int.Parse(parts[0].Trim());
                        string username = parts[1].Trim();
                        string contact = parts[2].Trim();
                        string status = parts[3].Trim();
                        string gender = parts[4].Trim();

                        List<OrderedProduct> cart = new List<OrderedProduct>();
                        string productsOrdered = parts[5].Trim();
                        UtilityFunctions.GetCartList(productsOrdered);

                        customers.Add(new Customer());
                    }
                }
            }

            return customers;
        }

        public void UpdateCart(Customer customer)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");
            string tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int id = int.Parse(parts[0].Trim());
                    string username = parts[1].Trim();
                    string contact = parts[2].Trim();
                    string status = parts[3].Trim();
                    string gender = parts[4].Trim();

                    if (id == customer.GetUserID())
                    {
                        writer.WriteLine($"{id}, {username}, {contact}, {status}, {gender}, {UtilityFunctions.GetCartString(customer.GetCart())}");
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            File.Delete(path);
            File.Move(tempFile, path);
        }

        public void DeleteCustomer(int id, string status, int userid)
        {
            // Implementation to delete a customer
        }

        public bool UsernameAlreadyExists(string username)
        {
            string path = UtilityFunctions.GetPath("Customers.txt");

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
    }
}
