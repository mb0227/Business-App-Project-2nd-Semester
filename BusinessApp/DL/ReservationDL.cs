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
    public class ReservationDL
    {
        public static void InsertReservationInDB(Reservation r)
        {
            using (SqlConnection connection= UtilityFunctions.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Reservation(ReservationDate,ReservationTime,TotalPersons,CustomerID, TableID) VALUES (@ReservationDate, @ReservationTime, @TotalPersons, @CustomerID, @TableID)", connection);
                command.Parameters.AddWithValue("@ReservationDate", r.GetReservationDate());
                command.Parameters.AddWithValue("@ReservationTime", r.GetReservationTime());
                command.Parameters.AddWithValue("@TotalPersons", r.GetTotalPersons());
                command.Parameters.AddWithValue("@CustomerID", r.GetCustoemrID());
                command.Parameters.AddWithValue("@TableID", r.GetTableID());
                command.ExecuteNonQuery();
            }
        }
    }
}
