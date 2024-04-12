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
    public class ChefFHDL : IChefDL
    {
        public void SaveChef(Chef chef)
        {
            string path = UtilityFunctions.GetPath("Chefs.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{chef.GetShift()}, {chef.GetExperience()}, {chef.GetSpecialization()}, {chef.GetEmployeeID()}");
            }
        }

        public List<Chef> GetChefs()
        {
            List<Chef> chefs = new List<Chef>();
            string path = UtilityFunctions.GetPath("Chefs.txt");
            string path2 = UtilityFunctions.GetPath("Employees.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        int id = Convert.ToInt32(parts[0].Trim());
                        string shift = parts[1].Trim();
                        string experience = parts[2].Trim();
                        string specialization = parts[3].Trim();
                        int employeeID = Convert.ToInt32(parts[4].Trim());

                        if (File.Exists(path2))
                        {
                            string[] Lines = File.ReadAllLines(path2);
                            foreach (string Line in Lines)
                            {
                                string[] Parts = Line.Split(',');
                                if (Parts.Length == 7 && Parts[0].Trim() == employeeID.ToString())
                                {
                                    string username = Parts[1].Trim();
                                    double salary = Convert.ToDouble(Parts[3].Trim());

                                    Chef chef = new Chef(id, username, salary, shift, specialization, experience, employeeID);
                                    chefs.Add(chef);
                                }
                            }
                        }
                    }
                }
            }
            return chefs;
        }
    }
}
