using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BL
{
    public class User
    {
        public User(string email, string password,string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }

        private string Email;
        private string Password;
        private string Role;

        public string GetEmail()
        {
            return Email;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetRole()
        {
            return Role;
        }

        public void SetEmail(string e)
        {
            Email = e;
        }

        public void SetPassword(string p)
        {
            Password = p;
        }

        public void SetRole(string r)
        {
            Role = r;
        }
    }
}
