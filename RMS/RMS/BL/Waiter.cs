using RMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Waiter : Employee
    {
        private string Shift;
        private string Tables;
        private string Language;
        private int EmployeeID;

        private int WaiterID;

        public Waiter(string username, string contact, double salary, DateTime joinDate, string gender, int userID, string shift, string tables, string language, int employeeID) : base(username, contact, salary, joinDate, gender, userID)
        {
            Shift = shift;
            Language = language;
            Tables = tables;
            EmployeeID = employeeID;
        }

        public Waiter(int id, string username, double salary, string shift, string tables, string language, int employeeID) : base(username, salary)
        {
            WaiterID = id;
            Shift = shift;
            Language = language;
            Tables = tables;
            EmployeeID = employeeID;
        }

        public int GetWaiterID()
        {
            return WaiterID;
        }

        public string GetShift()
        {
            return Shift;
        }

        public string GetTables()
        {
            return Tables;
        }

        public string GetLanguage()
        {
            return Language;
        }

        public override int GetEmployeeID()
        {
            return EmployeeID;
        }

        public void SetShift(string shift)
        {
            Shift = shift;
        }

        public void SetTables(string tables)
        {
            Tables = tables;
        }

        public void SetLanguage(string language)
        {
            Language = language;
        }

        public void SetWaiterID(int id)
        {
            WaiterID = id;
        }
    }
}
