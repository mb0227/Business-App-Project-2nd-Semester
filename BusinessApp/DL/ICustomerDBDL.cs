using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    interface ICustomerDBDL
    {
        void AddCustomerToDB(Customer customer);
    }
}
