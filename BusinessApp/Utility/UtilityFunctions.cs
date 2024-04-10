using RMS.BL;
using SSC.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSC
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

        public static int AssignID(string path)
        {
            int userID = 1;

            if (File.Exists(path))
            {
                string lastLine = File.ReadAllLines(path).LastOrDefault();
                if (!string.IsNullOrEmpty(lastLine))
                {
                    string[] parts = lastLine.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int lastID))
                    {
                        userID = lastID + 1;
                    }
                }
            }
            return userID;
        }

        public static List <string> AwardVouchers(int number)
        {
            List<string> vouchers = new List<string>();
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                string selectQuery = $"SELECT TOP {number} ID FROM Vouchers ORDER BY NEWID()";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vouchers.Add(reader["ID"].ToString());
                    }
                    reader.Close();
                }
            }
            return vouchers;
        }

        public static Voucher GetVoucher(int ID)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Vouchers WHERE ID=@ID";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        DateTime e = Convert.ToDateTime(reader["ExpirationDate"]);
                        Decimal d = Convert.ToDecimal(reader["Value"]);
                        double v = Convert.ToDouble(d);
                        return new Voucher(id, e, v);
                    }
                    reader.Close();
                }

            }
            return null;
        }

        public static string GetCartString(List <OrderedProduct> cart)
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

        public static string GetDealString(Deal deal)
        {
            StringBuilder cartString = new StringBuilder();

            foreach (var orderedProduct in deal.GetMenu())
            {
                cartString.Append($"{orderedProduct.Quantity} of {orderedProduct.Name};");
            }
            return cartString.ToString().TrimEnd(';');
        }

        public static List<(string , string )> GetDealList(string items)
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
