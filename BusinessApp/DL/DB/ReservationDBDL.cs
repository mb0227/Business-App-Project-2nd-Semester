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
        public void SaveReservation(Reservation r)
        {
            using (SqlConnection connection= UtilityFunctions.GetSqlConnection())
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

        //delete reservation
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
