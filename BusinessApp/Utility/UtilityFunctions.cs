using RMS.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSC
{
    public class UtilityFunctions
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=RMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static string GetPath(string filename)
        {
            string directory = "..//..//Files";
            return Path.Combine(directory, filename);
        }

        public static int AssignID(string path)
        {
            int userID = 1;

            if (File.Exists(path))
            {
                string lastLine = File.ReadAllLines(path).LastOrDefault();
                if (!string.IsNullOrEmpty(lastLine))
                {
                    string[] parts = lastLine.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int lastID))
                    {
                        userID = lastID + 1;
                    }
                }
            }
            return userID;
        }

        public static List <string> AwardVouchers(int number)
        {
            List<string> vouchers = new List<string>();
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                string selectQuery = $"SELECT TOP {number} ID FROM Vouchers ORDER BY NEWID()";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vouchers.Add(reader["ID"].ToString());
                    }
                    reader.Close();
                }
            }
            return vouchers;
        }

        public static Voucher GetVoucher(int ID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM Vouchers ID=@ID";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        DateTime e = Convert.ToDateTime(reader["ExpirationDate"]);
                        Decimal d = Convert.ToDecimal(reader["Value"]);
                        double v = Convert.ToDouble(d);
                        return new Voucher(id, e, v);
                    }
                    reader.Close();
                }
            }
            return null;
        }
    }
}
