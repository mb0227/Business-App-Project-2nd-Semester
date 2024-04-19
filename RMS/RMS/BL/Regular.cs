﻿using RMS.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Regular : Customer
    {
        private int LoyaltyPoints;
        private int CustomerID;
        private int ID;

        public Regular(int loyaltyPoints, int customerID)
        {
            LoyaltyPoints = loyaltyPoints;
            CustomerID = customerID;
        }

        public Regular(int id, int loyaltyPoints, int customerID)
        {
            ID = id;
            LoyaltyPoints = loyaltyPoints;
            CustomerID = customerID;
        }

        public Regular(string username, int id, int loyaltyPoints, int customerID) : base(username)
        {
            Username = username;
            ID = id;
            LoyaltyPoints = loyaltyPoints;
            CustomerID = customerID;
        }

        public Regular(string username, string contact, string status, string gender, int loyaltyPoints, int customerID) : base(username, contact, status, gender)
        {
            Username = username;
            Contact = contact;
            Status = status;
            Gender = gender;
            Cart = new List<OrderedProduct>();
            LoyaltyPoints = loyaltyPoints;
            CustomerID = customerID;
        }

        public void PromoteToVip(List<string> vouchers)
        {
            VIP vip = new VIP(Username, Contact, "VIP", Gender, "Silver", CustomerID, vouchers);
            ObjectHandler.GetCustomerDL().UpdateStatus("VIP", CustomerID);
            ObjectHandler.GetVipDL().SaveVIP(vip);
            ObjectHandler.GetRegularDL().DeleteRegular(ID);
        }

        public int GetRegularID()
        {
            return ID;
        }

        public void AddLoyaltyPoints(int points)
        {
            LoyaltyPoints += points;
        }

        public int GetLoyaltyPoints()
        {
            return LoyaltyPoints;
        }

        public void SetLoyaltyPoints(int points)
        {
            LoyaltyPoints = points;
        }

        public int GetCustomerID()
        {
            return CustomerID;
        }

        public void SetCustomerID(int id)
        {
            CustomerID = id;
        }

        public void RedeemLoyaltyPoints(int points)
        {
            LoyaltyPoints -= points;
        }
    }
}
