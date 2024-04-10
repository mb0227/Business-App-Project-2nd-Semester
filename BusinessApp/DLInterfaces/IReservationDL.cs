using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface IReservationDL
    {
        void DeleteReservation(int customerid);
        void DeleteReservationByID(int reservationID);
        DateTime GetReservationDate(int customerid);
        int GetCustomerReservationCount(int customerId);
        void SaveReservation(Reservation r);
        void SaveReservation(Reservation r, int x);
        List<Reservation> GetReservations();
    }
}
