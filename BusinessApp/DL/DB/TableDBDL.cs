using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using SSC;

namespace RMS.DL
{
    public class TableDBDL : ITableDL
    {
        public void SaveTable(Table table)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [Table](Capacity, Status) VALUES (@Capacity,@Status)", connection);
                command.Parameters.AddWithValue("@Capacity", table.GetCapacity());
                command.Parameters.AddWithValue("@Status", "Unbooked");
                command.ExecuteNonQuery();
            }
        }

        public Table GetTableById(int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [TABLE] WHERE ID=@ID)", connection);
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    int ID = Convert.ToInt32(reader["ID"]);
                    int c = Convert.ToInt32(reader["Capacity"]);
                    string s = Convert.ToString(reader["Status"]);
                    return new Table(c, ID, s);
                }
            }
            return null;
        }

        public List<Table> GetTables()
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<Table> list = new List<Table>();
                while (sqlDataReader.Read())
                {
                    int id = Convert.ToInt32(sqlDataReader["ID"]);
                    int c = Convert.ToInt32(sqlDataReader["Capacity"]);
                    string s = Convert.ToString(sqlDataReader["Status"]);
                    Table t = new Table(c, id, s);
                    list.Add(t);
                }
                return list;
            }
        }

        public void UpdateTable(Table t)
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = $"UPDATE [Table] SET Capacity=@Capacity, Status=@Status WHERE ID={t.GetID()} ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Capacity", t.GetCapacity());
                sqlCommand.Parameters.AddWithValue("@Status", t.GetStatus());
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteTable(int id)
        {
            using (SqlConnection sqlConnection = UtilityFunctions.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"DELETE FROM [Table] WHERE ID={id}", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public int GetTableCapacity(int id)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT Capacity FROM [Table] WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }
            return id; 
        }
        

        public void UpdateTablesStatus()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE [Table] SET Status = 'Unbooked' WHERE ID IN (SELECT T.ID FROM [Table] T JOIN Reservation R ON T.ID = R.TableID WHERE GETDATE() > R.ReservationDate);";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                string query2 = "DELETE R FROM Reservation R JOIN [Table] T ON T.ID = R.TableID WHERE GETDATE() > R.ReservationDate;";
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.ExecuteNonQuery();
            }
        }

        public void UpdateTablesStatus(int tableID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string query = "UPDATE [Table] SET Status = 'Unbooked' WHERE ID =@ID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", tableID);
                command.ExecuteNonQuery();
            }
        }

        public int GetReservedTableID(int customerid)
        {
            int id = -1;
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT R.TableID FROM Customers C JOIN Reservation R ON {customerid}= R.CustomerID", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }
            return id;
        }
    }
}
