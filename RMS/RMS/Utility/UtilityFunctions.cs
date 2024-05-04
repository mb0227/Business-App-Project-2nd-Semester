using RMS.BL;
using RMS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Utility
{
    public class UtilityFunctions
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=RMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static string GetPath(string filename)
        {
            string directory = "..//..//Files";
            return Path.Combine(directory, filename);
        }

        public static string GetImagesPath(string filename)
        {
            string directory = "..//..//Profiles";
            return Path.Combine(directory, filename);
        }

        public static int AssignID(string path)
        {
            int userID = 1;

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                {
                    string lastLine = lines.LastOrDefault();
                    if (!string.IsNullOrEmpty(lastLine))
                    {
                        string[] parts = lastLine.Split(',');
                        if (parts.Length > 0 && int.TryParse(parts[0], out int lastID))
                        {
                            userID = lastID + 1;
                        }
                    }
                }
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int existingID))
                    {
                        if (existingID == userID)
                        {
                            userID++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return userID;
        }


        public static string GetCartString(List<OrderedProduct> cart)
        {
            StringBuilder cartString = new StringBuilder();
            foreach (var orderedProduct in cart)
            {
                cartString.Append($"{orderedProduct.GetQuantity()} of {orderedProduct.GetProduct().GetProductName()};");
            }
            return cartString.ToString().TrimEnd(';');
        }

        public static List<OrderedProduct> GetCartList(string productsOrdered)
        {
            List<OrderedProduct> cart = new List<OrderedProduct>();
            string[] productItems = productsOrdered.Split(';');
            foreach (string productItem in productItems)
            {
                string[] parts = productItem.Trim().Split(new string[] { " of " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    string quantity = parts[0].Trim();
                    string productName = parts[1].Trim();

                    Product product = ObjectHandler.GetProductDL().SearchProductByName(productName);
                    if (product != null)
                    {
                        cart.Add(new OrderedProduct(product, quantity));
                    }
                }
            }
            return cart;
        }

        public static string GetDealString(string input)
        {
            string[] items = input.Split(';');
            Dictionary<string, int> itemCounts = new Dictionary<string, int>();
            foreach (string item in items)
            {
                string trimmedItem = item.Trim();
                if (itemCounts.ContainsKey(trimmedItem))
                {
                    itemCounts[trimmedItem]++;
                }
                else
                {
                    itemCounts[trimmedItem] = 1;
                }
            }
            List<string> modifiedItems = new List<string>();
            foreach (var pair in itemCounts)
            {
                string itemString = $"{pair.Value} {pair.Key}";
                modifiedItems.Add(itemString);
            }
            string result = string.Join("; ", modifiedItems);

            return result;
        }

        public static string GetDealString(Deal deal)
        {
            StringBuilder cartString = new StringBuilder();

            foreach (var orderedProduct in deal.GetMenu())
            {
                cartString.Append($"{orderedProduct.Quantity} of {orderedProduct.Name};");
            }
            return cartString.ToString().TrimEnd(';');
        }

        public static List<(string, string)> GetDealList(string items)
        {
            string[] parts = items.Split(';');
            List<(string name, string quantity)> menu = new List<(string name, string quantity)>();
            foreach (string part in parts)
            {
                string[] subParts = part.Trim().Split(new string[] { " of " }, StringSplitOptions.None);
                if (subParts.Length == 2)
                {
                    string quantity = subParts[0].Trim();
                    string n = subParts[1].Trim();

                    menu.Add((n, quantity));
                }
            }
            return menu;
        }
    }
}
