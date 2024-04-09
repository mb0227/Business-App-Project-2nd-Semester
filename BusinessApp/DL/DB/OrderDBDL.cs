using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;
using RMS.BL;
using SSC;
using static RMS.BL.Order;
using System.Web.UI.WebControls.WebParts;
using SSC.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RMS.DL
{
    public class OrderDBDL : IOrderDL
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

        public void UpdateOrderStatus(int id, int status)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Orders Set Status = @Status Where ID=@ID", connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Status", status);
                command.ExecuteNonQuery();
            }
        }

        public List<Order> GetOrders(int status)
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Orders WHERE Status = @Status", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Status", status);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                List<Order> Orders = new List<Order>();
                while (reader.Read())
                {
                    int orderID = Convert.ToInt32(reader["ID"]);
                    int customerID = Convert.IsDBNull(reader["CustomerID"]) ? -1 : Convert.ToInt32(reader["CustomerID"]);
                    string customerComments = reader["CustomerComments"].ToString();
                    Order.OrderStatus orderStatus = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), reader["Status"].ToString());
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    string paymentMethod = reader["PaymentMethod"].ToString();            

                    string productsOrdered = reader["ProductsOrdered"].ToString();
                    List<OrderedProduct> cart = new List<OrderedProduct>();

                    string[] productItems = productsOrdered.Split(',');
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
                    Order order = new Order(orderID, cart, orderStatus, orderDate, customerComments, customerID,paymentMethod);
                    Orders.Add(order);
                }
                return Orders;
            }
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public void SaveOrder(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                StringBuilder cartString = new StringBuilder();

                foreach (var orderedProduct in order.GetProducts())
                {
                    cartString.Append($"{orderedProduct.GetQuantity()} of {orderedProduct.GetProduct().GetProductName()},");
                }
                string cartAsString = cartString.ToString().TrimEnd(',');

                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerID, CustomerComments, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerID, @CustomerComments, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerID", order.GetCustomerID());
                command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
                command.Parameters.AddWithValue("@Status", order.GetStatus());
                command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
                command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
                command.Parameters.AddWithValue("@PaymentMethod", order.GetPaymentMethod());
                command.ExecuteNonQuery();
            }
        }

        public void TakeOrder(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                StringBuilder cartString = new StringBuilder();

                foreach (var orderedProduct in order.GetProducts())
                {
                    cartString.Append($"{orderedProduct.GetQuantity()} of {orderedProduct.GetProduct().GetProductName()},");
                }
                string cartAsString = cartString.ToString().TrimEnd(',');

                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerComments, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerComments, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
                command.Parameters.AddWithValue("@Status", order.GetStatus());
                command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
                command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
                command.Parameters.AddWithValue("@PaymentMethod", order.GetPaymentMethod());
                command.ExecuteNonQuery();
            }
        }

        public int HasOrder(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE CustomerID=@CustomerID AND Status=0", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
                }
            }
            return -1;
        }

        public int GetOrderStatus(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Status FROM Orders WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int status = Convert.ToInt32(reader["Status"]);
                    return status;
                }
                else
                {
                    return -1;
                }
            }
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

        //public static void InsertOrderInDatabase(Order order)
        //{
        //    using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
        //    {
        //        connection.Open();
        //        StringBuilder cartString = new StringBuilder();

        //        foreach (var orderedProduct in order.GetProducts())
        //        {
        //            cartString.Append($"{orderedProduct.GetQuantity()}:{orderedProduct.GetProduct().GetProductName()},");
        //        }
        //        string cartAsString = cartString.ToString().TrimEnd(',');

        //        SqlCommand command = new SqlCommand("INSERT INTO Orders (OrderID, CustomerName, CustomerComments, OrderStatus, OrderDate, ProductsOrdered,TotalPrice) VALUES (@OrderID, @CustomerName, @CustomerComments, @OrderStatus, @OrderDate, @ProductsOrdered,@TotalPrice)", connection);
        //        command.Parameters.AddWithValue("@OrderID", order.GetOrderID());
        //        command.Parameters.AddWithValue("@CustomerName", order.GetCustomerName());
        //        command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
        //        command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
        //        command.Parameters.AddWithValue("@OrderStatus", order.GetStatus());
        //        command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
        //        command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
        //        command.ExecuteNonQuery();
                
        //    }
        //}

        //public static void ReadOrdersFromDatabase()
        //{
        //    using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT * FROM Orders", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int orderID = Convert.ToInt32(reader["OrderID"]);
        //            string customerName = reader["CustomerName"].ToString();
        //            string customerComments = reader["CustomerComments"].ToString();
        //            Order.OrderStatus orderStatus = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), reader["OrderStatus"].ToString());
        //            DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
        //            string productsOrdered = reader["ProductsOrdered"].ToString();

        //            List<OrderedProduct> cart = new List<OrderedProduct>();
        //            string[] productItems = productsOrdered.Split(',');
        //            foreach (string productItem in productItems)
        //            {
        //                string[] parts = productItem.Split(':');
        //                if (parts.Length == 2 && int.TryParse(parts[0], out int quantity))
        //                {
        //                    string productName = parts[1];
        //                    Product product = ProductDBDL.SearchProductByName(productName);
        //                    if (product != null)
        //                    {
        //                        cart.Add(new OrderedProduct(product, quantity));
        //                    }
        //                }
        //            }

        //            Order order = new Order(orderID, cart, orderStatus, orderDate, customerComments, customerName);
        //            Orders.Add(order);
        //        }
        //    }
        //}

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

        public void OrderDeal(Deal deal)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                StringBuilder cartString = new StringBuilder();

                foreach (var orderedProduct in deal.GetMenu())
                {
                    cartString.Append($"{orderedProduct.Quantity} of {orderedProduct.Name},");
                }
                string cartAsString = cartString.ToString().TrimEnd(',');

                SqlCommand command = new SqlCommand("INSERT INTO Orders (Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES ( @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@Status", 0);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
                command.Parameters.AddWithValue("@TotalPrice", deal.GetPrice());
                command.Parameters.AddWithValue("@PaymentMethod", "Cash on Delivery");
                command.ExecuteNonQuery();
            }
        }

        public void OrderDeal(Deal deal,int customerID) 
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                StringBuilder cartString = new StringBuilder();

                foreach (var orderedProduct in deal.GetMenu())
                {
                    cartString.Append($"{orderedProduct.Quantity} of {orderedProduct.Name},");
                }
                string cartAsString = cartString.ToString().TrimEnd(',');

                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerID, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerID, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Status", 0);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                command.Parameters.AddWithValue("@ProductsOrdered", cartAsString);
                command.Parameters.AddWithValue("@TotalPrice", deal.GetPrice());
                command.Parameters.AddWithValue("@PaymentMethod", "Cash on Delivery");
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
