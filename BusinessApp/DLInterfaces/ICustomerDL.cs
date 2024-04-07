﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface ICustomerDL
    {
        void SaveCustomer(Customer customer);
        Customer SearchCustomerById(int id);
        int GetCustomerID(string username);
        bool UsernameAlreadyExists(string username);
        List<Customer> GetCustomers();
        void DeleteCustomer(int id, string status,int userid);
    }
}
