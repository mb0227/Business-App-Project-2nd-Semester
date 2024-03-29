using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    internal class User
    {
        public User(string n, string p,string r )
        {
            Name = n;
            Password = p;
            Role = r;
        }
        private string Name;
        private string Password;
        private string Role;

        public string GetName()
        {
            return Name;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetRole()
        {
            return Role;
        }

        public void SetName(string n)
        {
            Name = n;
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
