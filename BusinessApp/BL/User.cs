using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSC
{
    public class User
    {
        public User(string username, string password,string role, string gender)
        {
            Username = username;
            Password = password;
            Role = role;
            Gender = gender;
        }

        protected string Username;
        protected string Password;
        protected string Role;
        protected string Gender;

        public string GetName()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetRole()
        {
            return Role;
        }

        public string GetGender()
        {
            return Gender;
        }

        public void SetName(string n)
        {
            Username = n;
        }

        public void SetPassword(string p)
        {
            Password = p;
        }

        public void SetRole(string r)
        {
            Role = r;
        }

        public void SetGender(string g)
        {
            Gender = g;
        }
    }
}
