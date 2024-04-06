using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class Employee
    {
        protected string Username;
        protected string Contact;
        protected double Salary;
        protected DateTime JoinDate;
        protected string Gender;
        protected int UserID;

        public Employee(string username, string contact, double salary, DateTime joinDate, string gender, int userID)
        {
            Username = username;
            Contact = contact;
            Salary = salary;
            JoinDate = joinDate;
            Gender = gender;
            UserID = userID;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetContact()
        {
            return Contact;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public DateTime GetJoinDate()
        {
            return JoinDate;
        }

        public string GetGender()
        {
            return Gender;
        }

        public int GetUserID()
        {
            return UserID;
        }

        public void SetUsername(string username)
        {
            Username = username;
        }

        public void SetContact(string contact)
        {
            Contact = contact;
        }

        public void SetSalary(double salary)
        {
            Salary = salary;
        }

        public void SetJoinDate(DateTime joinDate)
        {
            JoinDate = joinDate;
        }

        public void SetGender(string gender)
        {
            Gender = gender;
        }

        public void SetUserID(int userID)
        {
            UserID = userID;
        }
    }
}
