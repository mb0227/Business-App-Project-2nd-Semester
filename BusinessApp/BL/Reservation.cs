using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Reservation
    {
        private DateTime ReservationDate;
        private int TotalPersons;
        private int CustomerID;
        private int TableID;

        public Reservation(DateTime reservationDate, int totalPersons, int customerID, int tableID)
        {
            ReservationDate = reservationDate;
            TotalPersons = totalPersons;
            CustomerID = customerID;
            TableID = tableID;
        }

        public DateTime GetReservationDate()
        {
            return ReservationDate;
        }


        public int GetTotalPersons()
        {
            return TotalPersons;
        }

        public int GetCustomerID()
        {
            return CustomerID;
        }

        public int GetTableID()
        {
            return TableID;
        }

        public void SetReservationDate(DateTime reservationDate)
        {
            ReservationDate = reservationDate;
        }

        public void SetTotalPersons(int totalPersons)
        {
            TotalPersons = totalPersons;
        }

        public void SetCustomerID(int customerID)
        {
            CustomerID = customerID;
        }

        public void SetTableID(int tableID)
        {
            TableID = tableID;
        }
    }
}
