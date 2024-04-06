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
    public class AdminDL
    {
        public static void StoreAdminInDB(Admin admin)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Admins(ToolsUsed, Permissions, EmployeeID) VALUES (@ToolsUsed, @Permissions, @EmployeeID)", connection);
                command.Parameters.AddWithValue("@ToolsUsed", string.Join(", ", admin.GetToolsUsed()));
                command.Parameters.AddWithValue("@Permissions", string.Join(", ", admin.GetPermissions()));
                command.Parameters.AddWithValue("@EmployeeID", admin.GetEmployeeID());
                command.ExecuteNonQuery();
            }
        }
    }
}
