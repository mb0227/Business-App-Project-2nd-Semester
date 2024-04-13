using RMS.BL;
using RMS.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class ProductFHDL : IProductDL
    {
        public void SaveProduct(Product product)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{product.GetProductName()}, {product.GetProductCategory()}, {product.GetProductDescription()}, {product.GetAvailable()}");
            }
        }

        public void UpdateProduct(Product product)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 5 && parts[0].Trim() == product.GetProductID().ToString())
                    {
                        parts[1] = product.GetProductName();
                        parts[2] = product.GetProductCategory();
                        parts[3] = product.GetProductDescription();
                        parts[4] = product.GetAvailable().ToString();
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            int id = Convert.ToInt32(parts[0]);
                            string name = parts[1];
                            string category = parts[2];
                            string description = parts[3];
                            int available = Convert.ToInt32(parts[4]);
                            products.Add(new Product(id, name, description, category, available));
                        }
                    }
                }
            }
            return products;
        }

        public void SaveVariant(ProductVariant PV, int productID)
        {
            string path = UtilityFunctions.GetPath("ProductVariants.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{PV.GetQuantity()}, {PV.GetPrice()}, {productID}");
            }
        }

        public bool HasVariants(int productID)
        {
            string path = UtilityFunctions.GetPath("ProductVariants.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4 && parts[3].Trim() == productID.ToString())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool ProductExists(string productName)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5 && parts[1].Trim() == productName)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public List<Product> GetProductsForCustomers()
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            string path2 = UtilityFunctions.GetPath("ProductVariants.txt");
            List<Product> products = new List<Product>();
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5 && parts[4].Trim() == "1")
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string category = parts[2];
                            if (File.Exists(path2))
                            {
                                string[] lines = File.ReadAllLines(path2);
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    string[] parts2 = lines[i].Split(',');
                                    if (parts2.Length == 4 && parts2[3].Trim() == id.ToString())
                                    {
                                        string quantity = parts2[1];
                                        double price = double.Parse(parts2[2]);
                                        Product product = new Product(id, name, category, price, quantity);
                                        products.Add(product);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return products;
        }


        public double GetPrice(int productId, string quantity)
        {
            string path = UtilityFunctions.GetPath("ProductVariants.txt");
            double price = 0;

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4 && parts[3].Trim() == productId.ToString() && parts[1].Trim() == quantity)
                        {
                            price = double.Parse(parts[2]);
                            break;
                        }
                    }
                }
            }
            return price;
        }

        public Product SearchProductByName(string productName)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[1].Trim() == productName)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string category = parts[2];
                            string description = parts[3];
                            int available = int.Parse(parts[4]);
                            return new Product(id, name, description, category, available);
                        }
                    }
                }
            }
            return null;
        }

        public List<string> GetQuantities(int productId)
        {
            string path = UtilityFunctions.GetPath("ProductVariants.txt");
            List<string> quantities = new List<string>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4 && parts[3].Trim() == productId.ToString())
                        {
                            quantities.Add(parts[1]);
                        }
                    }
                }
            }

            return quantities;
        }

        public int GetProductID(string productName)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5 && parts[1].Trim() == productName)
                        {
                            return int.Parse(parts[0]);
                        }
                    }
                }
            }
            return -1;
        }

        public void DeleteProduct(int id)
        {
            string path = UtilityFunctions.GetPath("Products.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 5 && parts[0].Trim() == id.ToString())
                    {
                        lines[i] = "";
                        break;
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }
    }
}
