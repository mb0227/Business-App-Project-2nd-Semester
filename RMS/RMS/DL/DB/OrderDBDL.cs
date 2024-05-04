using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;
using RMS.BL;
using RMS.Utility;
using System.Data.SqlTypes;


namespace RMS.DL
{
    public class OrderDBDL : IOrderDL
    {
        public void SaveOrder(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerID, CustomerComments, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerID, @CustomerComments, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerID", order.GetCustomerID());
                command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
                command.Parameters.AddWithValue("@Status", order.GetStatus());
                command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                command.Parameters.AddWithValue("@ProductsOrdered", UtilityFunctions.GetCartString(order.GetProducts()));
                command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
                command.Parameters.AddWithValue("@PaymentMethod", order.GetPaymentMethod());
                command.ExecuteNonQuery();
            }
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
                    Order order = new Order(orderID, UtilityFunctions.GetCartList(productsOrdered), orderStatus, orderDate, customerComments, customerID, paymentMethod);
                    Orders.Add(order);
                }
                return Orders;
            }
        }

        public void TakeOrder(Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerComments, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerComments, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerComments", order.GetCustomerComments());
                command.Parameters.AddWithValue("@Status", order.GetStatus());
                command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                command.Parameters.AddWithValue("@ProductsOrdered", UtilityFunctions.GetCartString(order.GetProducts()));
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
            return 0;
        }

        public int CountOrders(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE CustomerID=@CustomerID AND Status = 3", connection);
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
                SqlCommand command = new SqlCommand("SELECT TOP 1 Status FROM Orders WHERE CustomerID=@CustomerID ORDER BY OrderDate DESC", connection);
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

        public int FindOrderByID(int CustomerId)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Orders WHERE CustomerID=@ID AND Status=0", connection);
                command.Parameters.AddWithValue("@ID", CustomerId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    return id;
                }
            }
            return -1;
        }

        public void OrderDeal(Deal deal)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Orders (Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES ( @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@Status", 0);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                command.Parameters.AddWithValue("@ProductsOrdered", UtilityFunctions.GetDealString(deal));
                command.Parameters.AddWithValue("@TotalPrice", deal.GetPrice());
                command.Parameters.AddWithValue("@PaymentMethod", "Cash on Delivery");
                command.ExecuteNonQuery();
            }
        }

        public void OrderDeal(Deal deal, int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerID, Status, OrderDate, ProductsOrdered, TotalPrice, PaymentMethod) VALUES (@CustomerID, @Status, @OrderDate, @ProductsOrdered,@TotalPrice, @PaymentMethod)", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Status", 0);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                command.Parameters.AddWithValue("@ProductsOrdered", UtilityFunctions.GetDealString(deal));
                command.Parameters.AddWithValue("@TotalPrice", deal.GetPrice());
                command.Parameters.AddWithValue("@PaymentMethod", "Cash on Delivery");
                command.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(int customerID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE CustomerID=@CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.ExecuteNonQuery();
            }
        }
    }
}
