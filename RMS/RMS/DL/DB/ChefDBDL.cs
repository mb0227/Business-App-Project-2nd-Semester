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

        public List<Chef> GetChefs()
        {
            List<Chef> chefs = new List<Chef>();

            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT C.ID,E.Username,E.Salary, C.Shift, C.Specialization, C.Experience, C.EmployeeID  FROM Chefs C JOIN Employees E ON E.ID = C.EmployeeID", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        decimal salaryDecimal = reader.GetDecimal(2);
                        double salary = Convert.ToDouble(salaryDecimal);
                        string shift = reader.GetString(3);
                        string specialization = reader.GetString(4);
                        string experience = reader.GetString(5);
                        int employeeID = reader.GetInt32(6);

                        Chef chef = new Chef(id, username, salary, shift, specialization, experience, employeeID);
                        chefs.Add(chef);
                    }
                }
            }
            return chefs;
        }
    }
}
