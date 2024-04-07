using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IEmployeeDL
    {
        void SaveEmployee(Employee employee);
        Chef SearchChefById(int id);
        Admin SearchAdminById(int id);
        Waiter SearchWaiterById(int id);
        bool UsernameAlreadyExists(string username);
        int GetEmployeeID(string username);
        List<Employee> GetEmployees();
        string GetEmployeeRole(int id);
        void DeleteEmployee(int id, string role, int userid);
    }
}
