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
    public class EmployeeDL : IEmployeeDBDL
    {
        public void StoreEmployeeInDB(Employee employee)
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

        public static int GetEmployeeID(string username)
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

        public static bool UsernameAlreadyExists(string username)
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
