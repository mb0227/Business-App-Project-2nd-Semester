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
using SSC.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RMS.DL
{
    public class CustomerDBDL : ICustomerDL
    {
        public void SaveCart(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET Cart=@Cart WHERE Username=@Username", connection);
                command.Parameters.AddWithValue("@Cart", UtilityFunctions.GetCartString(customer.GetCart()));
                command.Parameters.AddWithValue("@Username", customer.GetUsername());
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStatus(string status, int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET Status=@Status WHERE ID=@ID", connection);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }

        public Customer SearchCustomerById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT C.ID,C.Username, C.Contact, C.Status, C.Gender, C.Cart,U.ID FROM Customers AS C JOIN Users AS U ON C.UserID = {userID}", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    string status = reader["Status"].ToString();
                    string gender = reader["Gender"].ToString();
                    string productsOrdered = reader["Cart"].ToString();
                    Customer customer = new Customer(id,username, contact, status, gender, UtilityFunctions.GetCartList(productsOrdered), userID);
                    return customer;
                }
                return null;
            }    
        }

        public void UpdateCredentials(string newCred, string credType, int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                string query = "";
                if (credType == "username")
                {
                    query = "UPDATE Customers SET Username = @NewCredential WHERE UserID = @UserID";
                }
                else if (credType == "password")
                {
                    query = "UPDATE Users SET Password = @NewCredential WHERE ID = @ID";
                }

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewCredential", newCred);
                if (credType == "username")
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                }
                else
                {
                    command.Parameters.AddWithValue("@ID", userID);
                }
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                List<Customer> customers = new List<Customer>();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    string status = reader["Status"].ToString();
                    string gender = reader["Gender"].ToString();
                    string productsOrdered = reader["Cart"].ToString();
                    int userID = Convert.ToInt32(reader["UserID"]);
                    Customer customer = new Customer(id,username, contact, status, gender, UtilityFunctions.GetCartList(productsOrdered), userID);
                    customers.Add(customer);
                }
                return customers;
            }
        }

        public void UpdateCart(Customer customer)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET Cart=@Cart WHERE Username=@Username", connection);
                command.Parameters.AddWithValue("@Cart", UtilityFunctions.GetCartString(customer.GetCart()));
                command.Parameters.AddWithValue("@Username", customer.GetUsername());
                command.ExecuteNonQuery();
            }
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

        public void DeleteCustomer(int id, string status, int userid)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command2;
                if (status == "regular")
                {
                    command2 = new SqlCommand("DELETE FROM Regular WHERE CustomerID = @CustomerID", connection);
                    command2.Parameters.AddWithValue("@CustomerID", id);
                    command2.ExecuteNonQuery();
                }
                else if(status=="vip")
                {
                    command2 = new SqlCommand("DELETE FROM VIP WHERE CustomerID = @CustomerID", connection);
                    command2.Parameters.AddWithValue("@CustomerID", id);
                    command2.ExecuteNonQuery();
                }

                SqlCommand command3 = new SqlCommand("DELETE FROM Feedback WHERE CustomerID = @CustomerID", connection);
                command3.Parameters.AddWithValue("@CustomerID", id);
                command3.ExecuteNonQuery();

                SqlCommand command4 = new SqlCommand("DELETE FROM Reservation WHERE CustomerID = @CustomerID", connection);
                command4.Parameters.AddWithValue("@CustomerID", id);
                command4.ExecuteNonQuery();

                SqlCommand command5 = new SqlCommand("DELETE FROM Orders WHERE CustomerID = @CustomerID", connection);
                command5.Parameters.AddWithValue("@CustomerID", id);
                command5.ExecuteNonQuery();

                
                SqlCommand command6 = new SqlCommand("DELETE FROM Customers WHERE ID = @ID", connection);
                command6.Parameters.AddWithValue("@ID", id);
                command6.ExecuteNonQuery();

                SqlCommand command7 = new SqlCommand("DELETE FROM ViewNotification WHERE CustomerID = @CustomerID", connection);
                command7.Parameters.AddWithValue("@CustomerID", id);
                command7.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("DELETE FROM Users WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", userid);
                command.ExecuteNonQuery();
            }
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
    }
}
