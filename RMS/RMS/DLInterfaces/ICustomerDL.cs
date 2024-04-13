using System;
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
        void DeleteCustomer(int id, string status, int userid);
        void UpdateCredentials(string newCred, string credType, int userID);
        void SaveCart(Customer customer);
        void UpdateCart(Customer customer);
        void UpdateStatus(string status, int id);
        Customer ForgotPassword(int userID);
    }
}
