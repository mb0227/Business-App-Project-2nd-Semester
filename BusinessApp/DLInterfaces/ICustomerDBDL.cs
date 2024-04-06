using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface ICustomerDBDL
    {
        void AddCustomerToDB(Customer customer);
        Customer SearchCustomerById(int id);
        int GetCustomerID(string username);
    }
}
