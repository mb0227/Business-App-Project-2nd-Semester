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
    public class ChefDBDL : IChefDL
    {
        public void SaveChef(Chef chef)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Chefs(Shift, Specialization, Experience, EmployeeID) VALUES (@Shift, @Specialization, @Experience, @EmployeeID)", connection);
                command.Parameters.AddWithValue("@Shift", chef.GetShift());
                command.Parameters.AddWithValue("@Specialization", chef.GetSpecialization());
                command.Parameters.AddWithValue("@Experience", chef.GetExperience());
                command.Parameters.AddWithValue("@EmployeeID", chef.GetEmployeeID());
                command.ExecuteNonQuery();
            }
        }
    }
}
