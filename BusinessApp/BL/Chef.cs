using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Chef: Employee
    {
        private string Shift;
        private string Specialization;
        private string Experience;
        private int EmployeeID;

        public Chef(string username, string contact, double salary, DateTime joinDate, string gender, int userID,string shift, string specialization, string experience, int employeeID) : base(username, contact, salary, joinDate, gender, userID)
        {
            Username = username;
            Contact = contact;
            Salary = salary;
            JoinDate = joinDate;
            Gender = gender;
            UserID = userID;
            Shift = shift;
            Experience = experience;
            Specialization = specialization;
            EmployeeID = employeeID;
        }

        public string GetShift()
        {
            return Shift;
        }

        public string GetSpecialization()
        {
            return Specialization;
        }

        public string GetExperience()
        {
            return Experience;
        }

        public int GetEmployeeID()
        {
            return EmployeeID;
        }

        public void SetShift(string shift)
        {
            Shift = shift;
        }

        public void SetSpecialization(string specialization)
        {
            Specialization = specialization;
        }

        public void SetExperience(string experience)
        {
            Experience = experience;
        }

        public void SetEmployeeID(int employeeID)
        {
            EmployeeID = employeeID;
        }
    }
}
