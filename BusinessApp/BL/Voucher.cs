using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Voucher
    {
        private DateTime ExpirationDate;
        private double Value;
        private int ID;

        public Voucher(DateTime expirationDate, double value)
        {
            ExpirationDate = expirationDate;
            Value = value;
        }

        public DateTime GetExpirationDate()
        {
            return ExpirationDate;
        }

        public double GetValue()
        {
            return Value;
        }

        public int GetID()
        {
            return ID;
        }

        public void SetExpirationDate(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }

        public void SetValue(double value)
        {
            Value = value;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public bool IsValidVoucher()
        {
            if (ExpirationDate > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
