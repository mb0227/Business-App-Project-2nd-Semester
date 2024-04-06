using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using SSC;



namespace RMS.DL
{
    public class ProductDL
    {
        private static List<Product> Products = new List<Product>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public static List<Product> GetProducts()
        {
            return Products;
        }

        public static void InsertProductsIntoDatabase(Product product)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products (ProductName, ProductDescription, ProductCategory, Price, Stock,QuantitiesAvailable) VALUES (@ProductName, @ProductDescription, @ProductCategory, @Price, @Stock,@QuantitiesAvailable)", connection);
                command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                command.Parameters.AddWithValue("@ProductDescription", product.GetProductDescription());
                command.Parameters.AddWithValue("@ProductCategory", product.GetProductCategory());
                command.Parameters.AddWithValue("@Price", product.GetPrice());
                command.Parameters.AddWithValue("@Stock", product.GetStock());
                command.Parameters.AddWithValue("@QuantitiesAvailable", product.ReturnQuantityString());
                command.ExecuteNonQuery();                
            }
        }

        public static void ReadProductsFromDatabase()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    string productDescription = reader["ProductDescription"].ToString();
                    string productCategory = reader["ProductCategory"].ToString();
                    int price = Convert.ToInt32(reader["Price"]);
                    int stock = Convert.ToInt32(reader["Stock"]);
                    string quantities = reader["QuantitiesAvailable"].ToString();

                    string[] splittedRecord = quantities.Split(',');
                    List<string> quantitiesList = new List<string>();
                    foreach (string record in splittedRecord)
                    {
                        quantitiesList.Add(record);
                    }

                    Product product = new Product(productName, productDescription, productCategory, price, stock);
                    product.SetAvailableQuantities(quantitiesList);
                    Products.Add(product);
                }
            }
        }

        public static void UpdateProductInDatabase(Product product)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Products SET ProductName=@ProductName, ProductDescription=@ProductDescription, ProductCategory=@ProductCategory, Price=@Price, Stock=@Stock,QuantitiesAvailable=@QuantitiesAvailable WHERE ProductName=@ProductName", connection);
                command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                command.Parameters.AddWithValue("@ProductDescription", product.GetProductDescription());
                command.Parameters.AddWithValue("@ProductCategory", product.GetProductCategory());
                command.Parameters.AddWithValue("@Price", product.GetPrice());
                command.Parameters.AddWithValue("@Stock", product.GetStock());
                command.Parameters.AddWithValue("@QuantitiesAvailable", product.ReturnQuantityString());
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteProductFromDatabase(Product product)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Products WHERE ProductName=@ProductName", connection);
                command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                command.ExecuteNonQuery();
            }        
        }   

        public static int FindProductByID()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ID=@ID", connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    return id;
                }
            }
            return -1;
        }

        public static Product SearchProductByName(string productName)
        {
            foreach (Product product in Products)
            {
                if (product.GetProductName() == productName)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
