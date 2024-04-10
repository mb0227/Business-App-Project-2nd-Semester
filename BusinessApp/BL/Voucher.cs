using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Voucher
    {
        private int ID;
        private DateTime ExpirationDate;
        private double Discount;

        public Voucher()
        {
            ID = 0;
            ExpirationDate = DateTime.MinValue;
            Discount = 0.0;
        }

        public Voucher(int id, DateTime expirationDate, double discount)
        {
            ID = id;
            ExpirationDate = expirationDate;
            Discount = discount;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public DateTime GetExpirationDate()
        {
            return ExpirationDate;
        }

        public void SetExpirationDate(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }

        public double GetDiscount()
        {
            return Discount;
        }
        public void SetDiscount(double discount)
        {
            Discount = discount;
        }
    }
}
