using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class VIP : Customer
    {
        private string MembershipLevel;
        private List<Voucher> Vouchers = new List<Voucher>();
        private int CustomerID;

        public VIP(string username, string contact, string status, string gender, string membershipLevel, int customerID, List<Voucher> vouchers) : base(username, contact, status, gender)
        {
            Username = username;
            Contact = contact;
            Status = status;
            Gender = gender;
            Cart = new List<OrderedProduct>();
            MembershipLevel = membershipLevel;
            CustomerID = customerID;
            Vouchers = vouchers;
        }


        public void AddVoucher(Voucher voucher)
        {
            Vouchers.Add(voucher);
        }

        public List<Voucher> GetVouchers()
        {
            return Vouchers;
        }

        public void SetVouchers(List<Voucher> vouchers)
        {
            Vouchers = vouchers;
        }

        public string GetMembershipLevel()
        {
            return MembershipLevel;
        }

        public void SetMembershipLevel(string level)
        {
            MembershipLevel = level;
        }

        public int GetCustomerID()
        {
            return CustomerID;
        }

        public void SetCustomerID(int id)
        {
            CustomerID = id;
        }

        public void RedeemVoucher(Voucher voucher)
        {
            Vouchers.Remove(voucher);
        }
    }
}
