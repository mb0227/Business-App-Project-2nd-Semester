using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using RMS.BL;
using SSC;
using System.Windows.Forms;

namespace RMS.DL
{
    public class UserFHDL : IUserDL
    {
        public void SaveUser(User user)
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{user.GetEmail()}, {user.GetPassword()}, {user.GetRole()}");
            }
        }

        private bool EmailAlreadyExistsInFile(string email)
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            if (!File.Exists(path))
                return false;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email)
                    return true;
            }
            return false;
        }

        public bool EmailAlreadyExists(string email)
        {
            return EmailAlreadyExistsInFile(email);
        }


        public int GetUserID(string email)
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            if (!File.Exists(path))
                return -1;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email)
                    return Convert.ToInt32(parts[0].Trim()); 
            }
            return -1; 
        }

        public int GetUserID(int id)
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            if (!File.Exists(path))
                return -1;

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3 && parts[2].Trim() == id.ToString())
                    return Convert.ToInt32(parts[0].Trim()); // Assuming email is at index 0
            }
            return -1; // Return -1 if user is not found
        }

        public string SearchUserForRole(string email, string password)
        {
            string path = UtilityFunctions.GetPath("Users.txt");
            if (!File.Exists(path))
                return ""; 

            foreach (string line in File.ReadLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4 && parts[1].Trim() == email && parts[2]==password)
                    return parts[3].Trim(); 
            }
            return ""; 
        }
    }
}
