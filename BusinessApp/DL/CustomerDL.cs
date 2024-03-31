using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class CustomerDL
    {
        private static List<Customer> Customers = new List<Customer>();

        public static void GetCustomersFromDatabase()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            { 
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string password = reader["Password"].ToString();
                    string role = reader["Role"].ToString();
                    string gender = reader["Gender"].ToString();
                    string email = reader["Email"].ToString();
                    string phoneNumber = reader["Contact"].ToString();
                    string orderSpecifications = reader["OrderSpecifications"].ToString();
                    string productsOrdered = reader["Cart"].ToString();

                    object orderIdObj = reader["OrderID"];
                    int orderID = -1;
                    if (orderIdObj != DBNull.Value)
                    {
                        orderID = Convert.ToInt32(orderIdObj);
                    }

                    Order order = OrderDL.SearchOrderById(orderID);

                    string[] products = productsOrdered.Split(',');
                    List<Product> cart = new List<Product>();
                    foreach (string product in products)
                    {
                        Product p = ProductDL.SearchProductByName(product);
                        cart.Add(p);
                    }
                    Customer customer = new Customer(username, password, role, gender, email, phoneNumber, orderSpecifications, order, cart);
                    Customers.Add(customer);
                }
            }
        }

        public void UpdateCustomerInDatabase(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET Username = @Username, Password = @Password, Role = @Role, Gender = @Gender, Email = @Email, PhoneNumber = @PhoneNumber, OrderSpecifications = @OrderSpecifications, Cart=@Cart WHERE ID = @ID", connection);

                command.Parameters.AddWithValue("@Username", customer.GetName());
                command.Parameters.AddWithValue("@Password", customer.GetPassword());
                command.Parameters.AddWithValue("@Role", customer.GetRole());
                command.Parameters.AddWithValue("@Gender", customer.GetGender());
                command.Parameters.AddWithValue("@Email", customer.GetEmail());
                command.Parameters.AddWithValue("@Contact", customer.GetPhoneNumber());
                command.Parameters.AddWithValue("@OrderSpecifications", customer.GetSpecifications());
                command.Parameters.AddWithValue("@Cart", customer.GetCart());

                command.ExecuteNonQuery();
            }
        }

        public static void AddCustomerToDatabase(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Customers(Username, Password, Role, Gender, Email, Contact) VALUES (@Username, @Password, @Role, @Gender, @Email, @Contact)", connection);
                command.Parameters.AddWithValue("@Username", customer.GetName());
                command.Parameters.AddWithValue("@Password", customer.GetPassword());
                command.Parameters.AddWithValue("@Role", customer.GetRole());
                command.Parameters.AddWithValue("@Gender", customer.GetGender());
                command.Parameters.AddWithValue("@Email", customer.GetEmail());
                command.Parameters.AddWithValue("@Contact", customer.GetPhoneNumber());
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteCustomerFromDatabase(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Customers WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", customer.GetName());
                command.ExecuteNonQuery();
            }
        }

        public static void InsertOrderIntoCustomerDatabase(Customer customer, Order order)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET OrderSpecifications=@OrderSpecifications,OrderID = @OrderID, Cart = @Cart WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@OrderID", order.GetOrderID());
                command.Parameters.AddWithValue("@OrderSpecifications", customer.GetSpecifications());
                command.Parameters.AddWithValue("@Cart", order.GetProducts());
                command.Parameters.AddWithValue("@Username", customer.GetName());
                command.ExecuteNonQuery();
            }
        }

        public static bool UserAlreadyExists(string username)
        {
            foreach (var customer in Customers)
            {
                if (customer.GetName() == username)
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

        public static Customer SearchCustomer(string searchBy, string searchFor) //search by is either username, email or password and search for is attribute to search for
        {
            foreach (Customer customer in Customers)
            {
                if (customer.GetName() == searchBy && searchFor == "username")
                {
                    return customer;
                }
                else if(customer.GetEmail() == searchBy && searchFor == "email")
                {
                    return customer;
                }
                else if (customer.GetPassword() == searchBy && searchFor == "password")
                {
                    return customer;
                }
                else if (customer.GetPassword() == searchBy && searchFor == "password")
                {
                    return customer;
                }
            }
            return null;
        }

        public static Customer SearchCustomerForSignUp(string username, string password)
        {
             foreach (Customer customer in Customers)
            {
                if (customer.GetName()==username && customer.GetPassword()==password)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
