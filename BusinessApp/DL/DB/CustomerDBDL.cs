using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using SSC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RMS.DL
{
    public class CustomerDBDL : ICustomerDL
    {
        private static List<Customer> Customers = new List<Customer>();

        public Customer SearchCustomerById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT C.Username, C.Contact, C.Status, C.Gender, C.Cart FROM Customers AS C JOIN Users AS U ON C.UserID = {userID}", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    string status = reader["Status"].ToString();
                    string gender = reader["Gender"].ToString();
                    string productsOrdered = reader["Cart"].ToString();

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

                    Customer customer = new Customer(username, contact, status, gender, cart, userID);
                    return customer;
                }
                return null;
            }    
        }

        public static void GetCustomersFromDatabase()
        {
            //using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string username = reader["Username"].ToString();
            //        string password = reader["Password"].ToString();
            //        string role = reader["Role"].ToString();
            //        string gender = reader["Gender"].ToString();
            //        string email = reader["Email"].ToString();
            //        string Contact = reader["Contact"].ToString();
            //        string productsOrdered = reader["Cart"].ToString();

            //        object orderIdObj = reader["OrderID"];
            //        int orderID = -1;
            //        if (orderIdObj != DBNull.Value)
            //        {
            //            orderID = Convert.ToInt32(orderIdObj);
            //        }

            //        Order order = OrderDL.SearchOrderById(orderID);

            //        List<OrderedProduct> cart = new List<OrderedProduct>();
            //        string[] productItems = productsOrdered.Split(',');
            //        foreach (string productItem in productItems)
            //        {
            //            string[] parts = productItem.Split(':');
            //            if (parts.Length == 2 && int.TryParse(parts[0], out int quantity))
            //            {
            //                string productName = parts[1];
            //                Product product = ProductDL.SearchProductByName(productName);
            //                if (product != null)
            //                {
            //                    cart.Add(new OrderedProduct(product,quantity));
            //                }
            //            }
            //        }
            //        Customer customer = new Customer(username, password, role, gender, email, Contact, order, cart);
            //        Customers.Add(customer);
            //    }
            //}
        }


        public static void UpdateCustomerInDatabase(Customer customer)
        {
            //using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            //{
            //    connection.Open();

            //    StringBuilder cartString = new StringBuilder();
            //    foreach (var orderedProduct in customer.GetCart())
            //    {
            //        cartString.Append($"{orderedProduct.GetQuantity()}:{orderedProduct.GetProduct().GetProductName()},");
            //    }
            //    string cartAsString = cartString.ToString().TrimEnd(',');

            //    SqlCommand command = new SqlCommand("UPDATE Customers SET Username = @Username, Password = @Password, Role = @Role, Gender = @Gender, Email = @Email, Contact = @Contact, Cart=@Cart WHERE Username = @Username", connection);

            //    command.Parameters.AddWithValue("@Username", customer.GetName());
            //    command.Parameters.AddWithValue("@Password", customer.GetPassword());
            //    command.Parameters.AddWithValue("@Role", customer.GetRole());
            //    command.Parameters.AddWithValue("@Gender", customer.GetGender());
            //    command.Parameters.AddWithValue("@Email", customer.GetEmail());
            //    command.Parameters.AddWithValue("@Contact", customer.GetContact());
            //    command.Parameters.AddWithValue("@Cart", cartAsString);

            //    command.ExecuteNonQuery();
            //}
        }

        public void SaveCustomer(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Customers(Username, Contact, Status, Gender, UserID) VALUES (@Username, @Contact, @Status, @Gender,@UserID)", connection);
                command.Parameters.AddWithValue("@Username", customer.GetUsername());
                command.Parameters.AddWithValue("@Status", customer.GetStatus());
                command.Parameters.AddWithValue("@Gender", customer.GetGender());
                command.Parameters.AddWithValue("@Contact", customer.GetContact());
                command.Parameters.AddWithValue("@UserID", customer.GetUserID());
                command.ExecuteNonQuery();
            }
        }

        public int GetCustomerID(string username)
        {
            int customerID = -1; // Default value if customer is not found

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT ID FROM Customers WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerID = reader.GetInt32(0);
                    }
                }
            }
            return customerID; // Return -1 if user is not found 
        }

        public static void DeleteCustomerFromDatabase(Customer customer)
        {
            //using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand("DELETE FROM Customers WHERE Username = @Username", connection);
            //    command.Parameters.AddWithValue("@Username", customer.GetName());
            //    command.ExecuteNonQuery();
            //}
        }

        public static void InsertOrderIntoCustomerDatabase(Customer customer) //OrderSpecifications, OrderID, Cart, Username
        {
            //using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            //{
            //    connection.Open();

            //    StringBuilder cartString = new StringBuilder();
            //    foreach (var orderedProduct in customer.GetCart())
            //    {
            //        cartString.Append($"{orderedProduct.GetQuantity()}:{orderedProduct.GetProduct().GetProductName()},");
            //    }
            //    string cartAsString = cartString.ToString().TrimEnd(',');

            //    SqlCommand command = new SqlCommand("UPDATE Customers SET OrderID=@OrderID, Cart=@Cart WHERE Username=@Username", connection);
            //    command.Parameters.AddWithValue("@OrderID", OrderDL.GetTotalOrders());
            //    command.Parameters.AddWithValue("@Cart", cartAsString);
            //    command.Parameters.AddWithValue("@Username", customer.GetName());

            //    command.ExecuteNonQuery();
            //}
        }
        public static void UpdateCustomer(Customer customer)
        {
            //foreach (Customer c in Customers)
            //{
            //    if(c.GetName()== customer.GetName())
            //    {
            //        c.SetName(customer.GetName());
            //        c.SetPassword(customer.GetPassword());
            //        c.SetGender(customer.GetGender());
            //    }
            //}
        }

        public bool UsernameAlreadyExists(string username)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Customers WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool UserAlreadyExists(string username)
        {
            foreach (var customer in Customers)
            {
                if (customer.GetUsername() == username)
                    return true;
            }
            return false;
        }

        public static void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public static void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public static List<Customer> GetCustomers()
        {
            return Customers;
        }

        //public static Customer SearchCustomer(string searchBy, string searchFor) //search by is either username, email or password and search for is attribute to search for
        //{
        //    foreach (Customer customer in Customers)
        //    {
        //        if (customer.GetName() == searchBy && searchFor == "username")
        //        {
        //            return customer;
        //        }
        //        else if(customer.GetEmail() == searchBy && searchFor == "email")
        //        {
        //            return customer;
        //        }
        //        else if (customer.GetPassword() == searchBy && searchFor == "password")
        //        {
        //            return customer;
        //        }
        //        else if (customer.GetPassword() == searchBy && searchFor == "password")
        //        {
        //            return customer;
        //        }
        //    }
        //    return null;
        //}

        //public static Customer SearchCustomerForSignUp(string username, string password)
        //{
        //     foreach (Customer customer in Customers)
        //    {
        //        if (customer.GetName()==username && customer.GetPassword()==password)
        //        {
        //            return customer;
        //        }
        //    }
        //    return null;
        //}
    }
}
