using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;

namespace SignInSignUp
{
    internal class OrderDL
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

        public static void ReadOrdersFromDataBase()
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

                    string[] products = productsOrdered.Split(',');
                    List<Product> orderedProducts = new List<Product>();
                    foreach (string product in products)
                    {
                        Product p = ProductDL.SearchProductByName(product);
                        orderedProducts.Add(p);
                    }

                    Order order = new Order(orderID, orderedProducts, orderStatus, orderDate, customerComments, customerName);
                    Orders.Add(order);
                }
            }
        }

        public static void UpdateOrderInDataBase(Order order)
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

        public static void DeleteOrderFromDataBase(Order order)
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
