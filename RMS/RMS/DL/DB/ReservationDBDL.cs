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
    public class ReservationDBDL : IReservationDL
    {
        public void SaveReservation(Reservation r, int x)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Reservation(ReservationDate,TotalPersons, TableID) VALUES (@ReservationDate, @TotalPersons, @TableID)", connection);
                command.Parameters.AddWithValue("@ReservationDate", r.GetReservationDate());
                command.Parameters.AddWithValue("@TotalPersons", r.GetTotalPersons());
                command.Parameters.AddWithValue("@TableID", r.GetTableID());
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReservationByID(int reservationID)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = @"DELETE
                FROM Reservation WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", reservationID);
                command.ExecuteNonQuery();
            }
        }

        public List<Reservation> GetReservations()
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                List<Reservation> Reservations = new List<Reservation>();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Reservation", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    DateTime date = Convert.ToDateTime(reader["ReservationDate"].ToString());
                    int perosns = Convert.ToInt32(reader["TotalPersons"]);
                    int customerID = Convert.IsDBNull(reader["CustomerID"]) ? -1 : Convert.ToInt32(reader["CustomerID"]);
                    int tableId = Convert.ToInt32(reader["TableID"]);
                    Reservation reservation = new Reservation(id, date, perosns, customerID, tableId);
                    Reservations.Add(reservation);
                }
                return Reservations;
            }
        }

        public void SaveReservation(Reservation r)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Reservation(ReservationDate,TotalPersons,CustomerID, TableID) VALUES (@ReservationDate, @TotalPersons, @CustomerID, @TableID)", connection);

                command.Parameters.AddWithValue("@ReservationDate", r.GetReservationDate());
                command.Parameters.AddWithValue("@TotalPersons", r.GetTotalPersons());
                command.Parameters.AddWithValue("@CustomerID", r.GetCustomerID());
                command.Parameters.AddWithValue("@TableID", r.GetTableID());
                command.ExecuteNonQuery();
            }
        }

        public int GetCustomerReservationCount(int customerId)
        {
            int reservations = -1;
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string query = @"
                SELECT COUNT(*)
                FROM [RMS].[dbo].[Reservation] R
                INNER JOIN [RMS].[dbo].[Customers] C ON R.CustomerID = C.ID
                WHERE C.ID = @CustomerId
                AND R.ReservationDate >= CAST(GETDATE() AS DATETIME);
            ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                reservations = (int)command.ExecuteScalar();
            }
            return reservations;
        }

        public DateTime GetReservationDate(int customerid)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();

                string query = @"SELECT ReservationDate
                FROM [Reservation] R JOIN Customers C
                ON R.CustomerID = C.ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerid);
                DateTime date = (DateTime)command.ExecuteScalar();
                return date;
            }
        }

        public void DeleteReservation(int customerid)
        {
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                string query = @"DELETE
                FROM Reservation WHERE CustomerID=@CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerid);
                command.ExecuteNonQuery();
            }
        }
    }
}
