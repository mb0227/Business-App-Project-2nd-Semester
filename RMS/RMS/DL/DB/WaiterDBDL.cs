using RMS.BL;
using RMS.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class WaiterDBDL : IWaiterDL
    {
        public void SaveWaiter(Waiter waiter)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Waiters(Shift, Area, Language, EmployeeID) VALUES (@Shift, @Area, @Language, @EmployeeID)", connection);
                command.Parameters.AddWithValue("@Shift", waiter.GetShift());
                command.Parameters.AddWithValue("@Area", waiter.GetTables());
                command.Parameters.AddWithValue("@Language", waiter.GetLanguage());
                command.Parameters.AddWithValue("@EmployeeID", waiter.GetEmployeeID());
                command.ExecuteNonQuery();
            }
        }

        public List<Waiter> GetWaiters()
        {
            List<Waiter> waiters = new List<Waiter>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT W.ID, E.Username,E.Salary, W.Shift, W.Area, W.Language, W.EmployeeID FROM Waiters W JOIN Employees E ON E.ID = W.EmployeeID", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        decimal salaryDecimal = reader.GetDecimal(2);
                        double salary = Convert.ToDouble(salaryDecimal);
                        string shift = reader.GetString(3);
                        string area = reader.GetString(4);
                        string language = reader.GetString(5);
                        int employeeID = reader.GetInt32(6);

                        Waiter waiter = new Waiter(id, username, salary, shift, area, language, employeeID);
                        waiters.Add(waiter);
                    }
                }
            }
            return waiters;
        }
    }
}
