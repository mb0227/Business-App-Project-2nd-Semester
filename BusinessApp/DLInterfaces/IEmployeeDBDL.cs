using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IEmployeeDBDL
    {
        void StoreEmployeeInDB(Employee employee);
        Chef SearchChefById(int id);
        Admin SearchAdminById(int id);
        Waiter SearchWaiterById(int id);

    }
}
