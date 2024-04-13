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
    public class VoucherDBDL : IVoucherDL
    {
        public void GenerateVouchers()
        {
            Random random = new Random();

            for (int i = 0; i < 200; i++)
            {
                DateTime expirationDate = DateTime.Today.AddDays(random.Next(1, 365));
                decimal value = (decimal)random.NextDouble() * 1000;

                string insertQuery = $"INSERT INTO Vouchers (ExpirationDate, Value) VALUES ('{expirationDate}', {value})";
                using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error inserting voucher: {ex.Message}");
                        }
                    }
                }
            }
        }

        public List<string> AwardVouchers(int number)
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

        public Voucher GetVoucher(int ID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Vouchers WHERE ID=@ID";
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
