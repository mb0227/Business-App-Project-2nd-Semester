using RMS.BL;
using RMS.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class AdminFHDL : IAdminDL
    {
        public void SaveAdmin(Admin admin)
        {
            string path = UtilityFunctions.GetPath("Admins.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{string.Join(";", admin.GetToolsUsed())}, {string.Join(";", admin.GetPermissions())}, {admin.GetEmployeeID()}");
            }
        }

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();
            string path = UtilityFunctions.GetPath("Admins.txt");
            string path2 = UtilityFunctions.GetPath("Employees.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        int id = Convert.ToInt32(parts[0].Trim());
                        string tools = parts[1].Trim();
                        string permissions = parts[2].Trim();
                        int employeeID = Convert.ToInt32(parts[3].Trim());

                        if (File.Exists(path2))
                        {
                            string[] Lines = File.ReadAllLines(path2);
                            foreach (string Line in Lines)
                            {
                                string[] Parts = Line.Split(',');
                                if (Parts.Length == 7 && Parts[0].Trim() == employeeID.ToString())
                                {
                                    int empID = Convert.ToInt32(Parts[0].Trim());
                                    string username = Parts[1].Trim();
                                    double salary = Convert.ToDouble(Parts[3].Trim());

                                    Admin admin = new Admin(id, username, salary, tools.Split(';').ToList(), permissions.Split(';').ToList(), empID);
                                    admins.Add(admin);
                                }
                            }
                        }
                    }
                }
            }
            return admins;
        }
    }
}
