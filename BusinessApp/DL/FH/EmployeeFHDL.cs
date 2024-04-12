using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class EmployeeFHDL : IEmployeeDL
    {
        public void SaveEmployee(Employee employee)
        {
            string path = UtilityFunctions.GetPath("Employees.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{employee.GetUsername()}, {employee.GetContact()}, {employee.GetSalary()}, {employee.GetJoinDate()}, {employee.GetGender()}, {employee.GetUserID()}");
            }
        }

        public void UpdateCredentials(string newCred, string credType, int userID)
        {
            string path = "";
            if (credType == "username")
                path = UtilityFunctions.GetPath("Employees.txt");
            else if (credType == "password")
                path = UtilityFunctions.GetPath("Users.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (credType == "username")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length == 7 && parts[6].Trim() == userID.ToString())
                        {
                            parts[1] = newCred;
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                else if (credType == "password")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');
                        if (parts.Length == 4 && parts[0].Trim() == userID.ToString())
                        {
                            parts[2] = newCred;
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }

        public int GetEmployeeID(string username)
        {
            string path = UtilityFunctions.GetPath("Employees.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7 && parts[1].Trim() == username)
                    {
                        return int.Parse(parts[0]);
                    }
                }
            }
            return -1;  
        }

        public bool UsernameAlreadyExists(string username)
        {
            string path = UtilityFunctions.GetPath("Employees.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7 && parts[1].Trim() == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string GetEmployeeRole(int id)
        {
            string path = UtilityFunctions.GetPath("Users.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4 && int.Parse(parts[0]) == id)
                    {
                        return parts[3].Trim();
                    }
                }
            }
            return ""; 
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string path = UtilityFunctions.GetPath("Employees.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7)
                    {
                        int id = int.Parse(parts[0]);
                        string username = parts[1].Trim();
                        string contact = parts[2].Trim();
                        double salary = double.Parse(parts[3]);
                        DateTime joindate = DateTime.Parse(parts[4]);
                        string gender = parts[5].Trim();
                        int userID = int.Parse(parts[6]);

                        Employee employee = new Employee(id, username, contact, salary, joindate, gender, userID);
                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }

        public void DeleteEmployee(int id, string role, int userid)
        {
            //string path = UtilityFunctions.GetPath("Employees.txt");
            //if (File.Exists(path))
            //{
            //    string[] lines = File.ReadAllLines(path);
            //    List<string> newLines = new List<string>();
            //    foreach (string line in lines)
            //    {
            //        string[] parts = line.Split(',');
            //        if (parts.Length == 7 && int.Parse(parts[0]) == id)
            //        {
            //            continue;
            //        }
            //        newLines.Add(line);
            //    }
            //    File.WriteAllLines(path, newLines);
            //}

            //path = UtilityFunctions.GetPath("Users.txt");
            //if (File.Exists(path))
            //{
            //    string[] lines = File.ReadAllLines(path);
            //    List<string> newLines = new List<string>();
            //    foreach (string line in lines)
            //    {
            //        string[] parts = line.Split(',');
            //        if (parts.Length == 4 && int.Parse(parts[0]) == userid)
            //        {
            //            continue;
            //        }
            //        newLines.Add(line);
            //    }
            //    File.WriteAllLines(path, newLines);
            //}
        }

        public Chef SearchChefById(int userID)
        {
            //string path = UtilityFunctions.GetPath("Employees.txt");

            //if (File.Exists(path))
            //{
            //    string[] lines = File.ReadAllLines(path);
            //    foreach (string line in lines)
            //    {
            //        string[] parts = line.Split(',');
            //        if (parts.Length == 7 && int.Parse(parts[6]) == userID)
            //        {
            //            int id = int.Parse(parts[0]);
            //            string username = parts[1].Trim();
            //            string contact = parts[2].Trim();
            //            double salary = double.Parse(parts[3]);
            //            DateTime joindate = DateTime.Parse(parts[4]);

            //        }
            //    }
            //}
            return null;
        }

        public Waiter SearchWaiterById(int userID)
        {
            //string path = UtilityFunctions.GetPath("Employees.txt");

            //if
            return null;
        }

        public Admin SearchAdminById(int userID)
        {
            return null;
        }
    }
}
