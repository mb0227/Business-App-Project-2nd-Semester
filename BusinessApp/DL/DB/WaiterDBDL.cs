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
    }
}
