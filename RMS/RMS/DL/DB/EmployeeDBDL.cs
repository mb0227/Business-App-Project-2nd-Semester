using RMS.BL;
using RMS.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class EmployeeDBDL : IEmployeeDL
    {
        public void SaveEmployee(Employee employee)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Employees(Username, Contact, Salary, JoinDate,Gender, UserID) VALUES (@Username, @Contact, @Salary,@JoinDate, @Gender,@UserID)", connection);
                command.Parameters.AddWithValue("@Username", employee.GetUsername());
                command.Parameters.AddWithValue("@Contact", employee.GetContact());
                command.Parameters.AddWithValue("@Salary", employee.GetSalary());
                command.Parameters.AddWithValue("@JoinDate", employee.GetJoinDate());
                command.Parameters.AddWithValue("@Gender", employee.GetGender());
                command.Parameters.AddWithValue("@UserID", employee.GetUserID());
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCredentials(string newCred, string credType, int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                string query = "";
                if (credType == "username")
                {
                    query = "UPDATE Employees SET Username = @NewCredential WHERE ID = @ID";
                }
                else if (credType == "password")
                {
                    query = "UPDATE Users SET Password = @NewCredential WHERE ID = @ID";
                }

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewCredential", newCred);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Employee> GetEmployees()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                List<Employee> employees = new List<Employee>();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    double salary = Convert.ToDouble(reader["Salary"]);
                    string gender = reader["Gender"].ToString();
                    DateTime joindate = DateTime.Parse(reader["JoinDate"].ToString());
                    int userID = Convert.ToInt32(reader["UserID"]);

                    Employee employee = new Employee(id, username, contact, salary, joindate, gender, userID);
                    employees.Add(employee);
                }
                return employees;
            }
        }

        public Chef SearchChefById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT E.Username, E.Contact, E.Salary, E.JoinDate, E.Gender, C.Shift, C.Experience, C.Specialization, C.EmployeeID FROM Users AS U JOIN Employees AS E ON U.ID = E.UserID JOIN Chefs as C ON C.EmployeeID = E.ID WHERE U.ID=@ID", connection);
                command.Parameters.AddWithValue("@ID", userID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    double salary = Convert.ToDouble(reader["Salary"]);
                    DateTime joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                    string gender = reader["Gender"].ToString();
                    string shift = reader["Shift"].ToString();
                    string experience = reader["Experience"].ToString();
                    string specialization = reader["Specialization"].ToString();
                    int empID = Convert.ToInt32(reader["EmployeeID"]);

                    Chef chef = new Chef(username, contact, salary, joindate, gender, userID, shift, specialization, experience, empID);
                    return chef;
                }
            }
            return null;
        }

        public Waiter SearchWaiterById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT E.Username, E.Contact, E.Salary, E.JoinDate, E.Gender, W.Shift, W.Language, W.Area, W.EmployeeID FROM Users AS U JOIN Employees AS E ON U.ID = E.UserID JOIN Waiters as W ON W.EmployeeID = E.ID WHERE U.ID={userID}", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    double salary = Convert.ToDouble(reader["Salary"]);
                    DateTime joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                    string gender = reader["Gender"].ToString();
                    string shift = reader["Shift"].ToString();
                    string area = reader["Area"].ToString();
                    string lang = reader["Language"].ToString();
                    int empID = Convert.ToInt32(reader["EmployeeID"]);

                    Waiter waiter = new Waiter(username, contact, salary, joindate, gender, userID, shift, area, lang, empID);
                    return waiter;
                }
            }
            return null;
        }

        public Admin SearchAdminById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = @"SELECT A.ID, E.Username, E.Contact, E.Salary, E.JoinDate, E.Gender, A.ToolsUsed, A.Permissions, A.EmployeeID 
                        FROM Users AS U 
                        JOIN Employees AS E ON U.ID = E.UserID 
                        JOIN Admins AS A ON A.EmployeeID = E.ID 
                        WHERE U.ID = @UserID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string username = reader["Username"].ToString();
                        string contact = reader["Contact"].ToString();
                        double salary = Convert.ToDouble(reader["Salary"]);
                        DateTime joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                        string gender = reader["Gender"].ToString();
                        string permissions = reader["Permissions"].ToString();
                        string tools = reader["ToolsUsed"].ToString();

                        List<string> permissionList = permissions.Split(';').ToList();
                        List<string> toolsList = tools.Split(';').ToList();

                        int empID = Convert.ToInt32(reader["EmployeeID"]);

                        Admin admin = new Admin(empID, id, username, contact, salary, joindate, gender, userID, toolsList, permissionList);
                        return admin;
                    }
                }
            }
            return null;
        }

        public int GetEmployeeID(string username)
        {
            int empID = -1;

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT ID FROM Employees WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empID = Convert.ToInt32(reader["ID"]);
                    }
                }
            }
            return empID; 
        }

        public bool UsernameAlreadyExists(string username)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Employees WHERE Username = @Username";
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

        public string GetEmployeeRole(int id)
        {
            string role = "";
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT U.Role FROM Users U JOIN Employees E on E.UserID = U.ID WHERE E.ID =@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader.GetString(0);
                    }
                }
            }
            return role; 
        }

        public void DeleteEmployee(int id, string role, int userid)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command3 = new SqlCommand("DELETE FROM Employees WHERE ID = @ID", connection);
                command3.Parameters.AddWithValue("@ID", id);
                command3.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("DELETE FROM Users WHERE ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", userid);
                command.ExecuteNonQuery();
            }
        }
    }
}
