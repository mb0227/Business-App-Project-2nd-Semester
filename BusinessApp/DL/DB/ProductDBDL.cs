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
    public class ProductDBDL : IProductDL
    {
        public void SaveProduct(Product product)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products (ProductName, Description,Category,IsAvailable) VALUES (@ProductName, @Description, @Category, @IsAvailable)", connection);
                command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                command.Parameters.AddWithValue("@Description", product.GetProductDescription());
                command.Parameters.AddWithValue("@Category", product.GetProductCategory());
                command.Parameters.AddWithValue("@IsAvailable", product.GetAvailable());
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Products SET ProductName = @ProductName, Description = @Description, Category = @Category, IsAvailable = @IsAvailable WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                command.Parameters.AddWithValue("@Description", product.GetProductDescription());
                command.Parameters.AddWithValue("@Category", product.GetProductCategory());
                command.Parameters.AddWithValue("@IsAvailable", product.GetAvailable());
                command.Parameters.AddWithValue("@ID", product.GetProductID()); 
                command.ExecuteNonQuery();
            }
        }

        public List<Product> GetProducts()
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<Product> list = new List<Product>();
                while (sqlDataReader.Read())
                {
                    int id = Convert.ToInt32(sqlDataReader["ID"]);
                    string n = Convert.ToString(sqlDataReader["ProductName"]);
                    string c = Convert.ToString(sqlDataReader["Category"]);
                    string d = Convert.ToString(sqlDataReader["Description"]);
                    int a = Convert.ToInt32(sqlDataReader["IsAvailable"]);

                    Product p = new Product(id, n, d, c, a);
                    list.Add(p);
                }
                return list;
            }
        }

        public void SaveVariant(ProductVariant PV, int productID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO ProductVariants (Quantity,Price,ProductID) VALUES (@Quantity, @Price, @ProductID)", connection);
                command.Parameters.AddWithValue("@Quantity", PV.GetQuantity());
                command.Parameters.AddWithValue("@Price", PV.GetPrice());
                command.Parameters.AddWithValue("@ProductID", productID);
                command.ExecuteNonQuery();
            }
        }

        public bool HasVariants(int productID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ProductVariants V JOIN Products P ON P.ID = V.ProductID WHERE P.ID = @id", connection);
                command.Parameters.AddWithValue("@id", productID);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool ProductExists(string productName)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Products WHERE ProductName=@ProductName", connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public List<Product> GetProductsForCustomers()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                List<Product> products = new List<Product>();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT P.ID,P.ProductName,P.Category ,V.Price, V.Quantity FROM Products P JOIN ProductVariants V ON P.ID = V.ProductID AND P.IsAvailable = 1;", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string n = Convert.ToString(reader["ProductName"]);
                        string c = Convert.ToString(reader["Category"]);
                        string q = Convert.ToString(reader["Quantity"]);
                        decimal priceDecimal = Convert.ToDecimal(reader["Price"]); 
                        double p = Convert.ToDouble(priceDecimal);
                        Product product = new Product(id,n, c, p, q);
                        products.Add(product);
                    }
                }
                return products;
            }
        }

        public double GetPrice(int productId, string quantity)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                double price =0;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Price FROM ProductVariants Where Quantity = @Quantity AND ProductID = @ProductID;", connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ProductID", productId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal priceDecimal = Convert.ToDecimal(reader["Price"]);
                        price = Convert.ToDouble(priceDecimal);
                    }
                }
                return price;
            }
        }

        public Product SearchProductByName(string productName)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ProductName=@ProductName", connection);
                command.Parameters.AddWithValue("@ProductName", productName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string n = Convert.ToString(reader["ProductName"]);
                        string c = Convert.ToString(reader["Category"]);
                        string d = Convert.ToString(reader["Description"]);
                        int a = Convert.ToInt32(reader["IsAvailable"]);
                        return new Product(id, n, d, c, a);
                    }
                    else
                    {
                        return null; 
                    }
                }
            }

        }

        public List<string> GetQuantities(int productId)
        {
            List<string> quantities = new List<string>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Quantity FROM ProductVariants V JOIN Products P ON P.ID = V.ProductID WHERE V.ProductID = @ProductId", connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string quantity = reader["Quantity"].ToString();
                    quantities.Add(quantity);
                }

                reader.Close();
                return quantities;
            }
        }

        public int GetProductID(string productName)
        {
            int id = -1;
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Products WHERE ProductName=@ProductName", connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                }
            }
            return id;
        }

        public void DeleteProduct(int productID)
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand($"DELETE FROM ProductVariants WHERE ProductID=@ID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ID", productID);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand($"DELETE FROM Products WHERE ID=@ID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ID", productID);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
