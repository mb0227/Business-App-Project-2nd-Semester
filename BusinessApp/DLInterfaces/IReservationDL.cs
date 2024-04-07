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
        DateTime GetReservationDate(int customerid);
        int GetCustomerReservationCount(int customerId);
        void SaveReservation(Reservation r);
        
    }
}
