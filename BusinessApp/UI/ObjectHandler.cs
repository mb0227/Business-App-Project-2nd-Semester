using RMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SSC.UI
{
    public class ObjectHandler
    {
        public static IUserDBDL GetUserDBDL()
        {
            return new UserDL();
        }

        public static ICustomerDBDL GetCustomerDBDL()
        {
            return new CustomerDL();
        }

        public static IEmployeeDBDL GetEmployeeDBDL()
        {
            return new EmployeeDL();
        }
    }
}
