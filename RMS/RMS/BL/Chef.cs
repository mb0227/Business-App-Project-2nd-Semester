using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Chef : Employee
    {
        private string Shift;
        private string Specialization;
        private string Experience;
        private int EmployeeID;

        private int ChefID;

        public Chef(string username, string contact, double salary, DateTime joinDate, string gender, int userID, string shift, string specialization, string experience, int employeeID) : base(username, contact, salary, joinDate, gender, userID)
        {
            Shift = shift;
            Experience = experience;
            Specialization = specialization;
            EmployeeID = employeeID;
        }

        public Chef(int id, string username, double salary, string shift, string specialization, string experience, int employeeID) : base(username, salary)
        {
            ChefID = id;
            Shift = shift;
            Experience = experience;
            Specialization = specialization;
            EmployeeID = employeeID;
        }

        public int GetChefID()
        {
            return ChefID;
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

        public void SetShift(string shift)
        {
            Shift = shift;
        }

        public override int GetEmployeeID()
        {
            return EmployeeID;
        }

        public void SetSpecialization(string specialization)
        {
            Specialization = specialization;
        }

        public void SetExperience(string experience)
        {
            Experience = experience;
        }

        public void SetChefID(int id)
        {
            ChefID = id;
        }
    }
}
