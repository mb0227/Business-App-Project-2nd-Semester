using RMS.BL;
using SSC;
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

        public Chef SearchChefById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT E.Username, E.Contact, E.Salary, E.JoinDate, E.Gender, C.Shift, C.Experience, C.Specialization, C.EmployeeID FROM Users AS U JOIN Employees AS E ON U.ID = E.UserID JOIN Chefs as C ON C.EmployeeID = E.ID WHERE U.ID={userID}", connection);
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

                    Chef chef = new Chef(username, contact, salary,joindate, gender, userID, shift,specialization, experience, empID);
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

                    Waiter watier = new Waiter(username, contact, salary, joindate, gender, userID, shift, area, lang, empID);
                    return watier;
                }
            }
            return null;
        }

        public Admin SearchAdminById(int userID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT E.Username, E.Contact, E.Salary, E.JoinDate, E.Gender, A.ToolsUsed, A.Permissions, A.EmployeeID FROM Users AS U JOIN Employees AS E ON U.ID = E.UserID JOIN Admins as A ON A.EmployeeID = E.ID WHERE U.ID={userID}", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    string contact = reader["Contact"].ToString();
                    double salary = Convert.ToDouble(reader["Salary"]);
                    DateTime joindate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                    string gender = reader["Gender"].ToString();
                    string permissions = reader["Permissions"].ToString();
                    string tools = reader["ToolsUsed"].ToString();

                    List<string> permissionList = permissions.Split(',').ToList();
                    List<string> toolsList = tools.Split(',').ToList();


                    int empID = Convert.ToInt32(reader["EmployeeID"]);

                    Admin admin = new Admin(username, contact, salary, joindate, gender, userID, toolsList, permissionList, empID);
                    return admin;
                }
            }
            return null;
        }

        public int GetEmployeeID(string username)
        {
            int empID = -1; // Default value if emp is not found

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
                        empID = reader.GetInt32(0);
                    }
                }
            }
            return empID; // Return -1 if user is not found 
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

    }
}
