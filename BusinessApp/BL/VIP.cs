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
        private List<string> Vouchers = new List<string>();
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private int CustomerID;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        private int ID;
        public VIP(string username, string contact, string status, string gender, string membershipLevel, int customerID, List<string> vouchers) : base(username, contact, status, gender)
        {
            MembershipLevel = membershipLevel;
            CustomerID = customerID;
            Vouchers = vouchers;
        }

        public VIP(string username, int id, string membershipLevel, int customerID) : base(username)
        {
            Username = username;
            ID = id;
            MembershipLevel = membershipLevel;
            CustomerID = customerID;
        }

        public VIP(int id, string membershipLevel, int customerID) 
        {
            ID = id;
            MembershipLevel = membershipLevel;
            CustomerID = customerID;
        }

        public VIP(int id, string membershipLevel, int customerID, List<string> vouchers)
        {
            ID = id;
            MembershipLevel = membershipLevel;
            CustomerID = customerID;
            Vouchers = vouchers;
        }

        public int GetVipID()
        {
            return ID;
        }

        public List<string> GetVouchers()
        {
            return Vouchers;
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

        public int GetVoucherID()
        {
            string[] numbersArray = (string.Join(",", Vouchers)).Split(',');
            int[] numbers = Array.ConvertAll(numbersArray, int.Parse);
            Random random = new Random();
            int randomIndex = random.Next(0, numbers.Length);
            Vouchers.RemoveAt(randomIndex);
            return numbers[randomIndex];
        }
    }
}
