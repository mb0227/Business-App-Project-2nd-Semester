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
    public class AdminDBDL : IAdminDL
    {
        public void SaveAdmin(Admin admin)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Admins(ToolsUsed, Permissions, EmployeeID) VALUES (@ToolsUsed, @Permissions, @EmployeeID)", connection);
                command.Parameters.AddWithValue("@ToolsUsed", string.Join(";", admin.GetToolsUsed()));
                command.Parameters.AddWithValue("@Permissions", string.Join(";", admin.GetPermissions()));
                command.Parameters.AddWithValue("@EmployeeID", admin.GetEmployeeID());
                command.ExecuteNonQuery();
            }
        }

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT A.ID, E.Username,E.Salary, A.ToolsUsed, A.Permissions, A.EmployeeID FROM Admins A JOIN Employees E ON E.ID = A.EmployeeID", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        decimal salaryDecimal = reader.GetDecimal(2);
                        double salary = Convert.ToDouble(salaryDecimal);
                        string tools = reader.GetString(3);
                        string permissions = reader.GetString(4);
                        int employeeID = reader.GetInt32(5);

                        Admin admin = new Admin(id, username, salary, tools.Split(';').ToList(), permissions.Split(';').ToList(), employeeID);
                        admins.Add(admin);
                    }
                }
            }
            return admins;
        }
    }
}
