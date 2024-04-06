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
        private string ReservationTime;
        private int TotalPersons;
        private int CustoemrID;
        private int TableID;

        public Reservation(DateTime reservationDate, string reservationTime, int totalPersons, int custoemrID, int tableID)
        {
            ReservationDate = reservationDate;
            ReservationTime = reservationTime;
            TotalPersons = totalPersons;
            CustoemrID = custoemrID;
            TableID = tableID;
        }

        public DateTime GetReservationDate()
        {
            return ReservationDate;
        }

        public string GetReservationTime()
        {
            return ReservationTime;
        }

        public int GetTotalPersons()
        {
            return TotalPersons;
        }

        public int GetCustoemrID()
        {
            return CustoemrID;
        }

        public int GetTableID()
        {
            return TableID;
        }

        public void SetReservationDate(DateTime reservationDate)
        {
            ReservationDate = reservationDate;
        }

        public void SetReservationTime(string reservationTime)
        {
            ReservationTime = reservationTime;
        }

        public void SetTotalPersons(int totalPersons)
        {
            TotalPersons = totalPersons;
        }

        public void SetCustoemrID(int custoemrID)
        {
            CustoemrID = custoemrID;
        }

        public void SetTableID(int tableID)
        {
            TableID = tableID;
        }
    }
}
