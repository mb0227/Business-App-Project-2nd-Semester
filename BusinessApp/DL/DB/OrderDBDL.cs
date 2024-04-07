using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;
using RMS.BL;
using SSC;


namespace RMS.DL
{
    public class OrderDBDL
    {
        private static List<Order> Orders = new List<Order>();

        public static void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

        public static List<Order> GetOrders()
        {
            return Orders;
        }

        public static int FindOrderByID()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE ID=@ID", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    return id;
                }
            }
            return -1;
        }

        public static void InsertOrderInDatabase(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                StringBuilder cartString = new StringBuilder();

                foreach (var orderedProduct in order.GetProducts())
                {
                    cartString.Append($"{orderedProduct.GetQuantity()}:{orderedProduct.GetProduct().GetProductName()},");
                }
                string cartAsString = cartString.ToString().TrimEnd(',');

                SqlCommand command = new SqlCommand("INSERT INTO Orders (OrderID, CustomerName, CustomerComments, OrderStatus, OrderDate, ProductsOrdered,TotalPrice) VALUES (@OrderID, @CustomerName, @CustomerComments, @OrderStatus, @OrderDate, @ProductsOrdered,@TotalPrice)", connection);
                command.Parameters.AddWithValue("@OrderID", order.GetOrderID());
                command.Parameters.AddWithValue("@CustomerName", order.GetCustomerName());
                command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
                command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
                command.Parameters.AddWithValue("@OrderStatus", order.GetStatus());
                command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
                command.ExecuteNonQuery();
                
            }
        }

        public static void ReadOrdersFromDatabase()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Orders", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int orderID = Convert.ToInt32(reader["OrderID"]);
                    string customerName = reader["CustomerName"].ToString();
                    string customerComments = reader["CustomerComments"].ToString();
                    Order.OrderStatus orderStatus = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), reader["OrderStatus"].ToString());
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    string productsOrdered = reader["ProductsOrdered"].ToString();

                    List<OrderedProduct> cart = new List<OrderedProduct>();
                    string[] productItems = productsOrdered.Split(',');
                    foreach (string productItem in productItems)
                    {
                        string[] parts = productItem.Split(':');
                        if (parts.Length == 2 && int.TryParse(parts[0], out int quantity))
                        {
                            string productName = parts[1];
                            Product product = ProductDBDL.SearchProductByName(productName);
                            if (product != null)
                            {
                                cart.Add(new OrderedProduct(product, quantity));
                            }
                        }
                    }

                    Order order = new Order(orderID, cart, orderStatus, orderDate, customerComments, customerName);
                    Orders.Add(order);
                }
            }
        }

        public static void UpdateOrderInDatabase(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Orders SET OrderStatus=@OrderStatus, Products=@Products WHERE OrderID=@OrderID", connection);
                command.Parameters.AddWithValue("@OrderID", order.GetOrderID());
                command.Parameters.AddWithValue("@OrderStatus", order.GetStatus());
                command.Parameters.AddWithValue("@Products", order.GetProducts());
                command.ExecuteNonQuery();
            }        
        }

        public static void DeleteOrderFromDatabase(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE OrderID=@OrderID", connection);
                command.Parameters.AddWithValue("@OrderID", order.GetOrderID());
                command.ExecuteNonQuery();
            }
        }

        public static Order SearchOrderById(int orderID)
        {
            foreach (Order order in Orders)
            {
                if (order.GetOrderID() == orderID)
                {
                    return order;
                }
            }
            return null;
        }

        public static int GetTotalOrders()
        {
            return Orders.Count;
        }
    }
}
