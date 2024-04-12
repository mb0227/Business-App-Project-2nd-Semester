using RMS.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSC;

namespace RMS.DL
{
    public class RegularFHDL : IRegularDL
    {
        public void SaveRegular(Regular regular)
        {
            string path = UtilityFunctions.GetPath("Regular.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{id},{regular.GetLoyaltyPoints()}, {regular.GetCustomerID()}");
            }
        }

        public void UpdateRegular(Regular regular)
        {
            string path = UtilityFunctions.GetPath("Regular.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && parts[0].Trim() == regular.GetID().ToString())
                    {
                        parts[1] = regular.GetLoyaltyPoints().ToString();
                        parts[2] = regular.GetCustomerID().ToString();
                        lines[i] = string.Join(",", parts);
                        File.WriteAllLines(path, lines);
                        return;
                    }
                }
            }
        }

        public Regular GetRegular(int customerID)
        {
            string path = UtilityFunctions.GetPath("Regular.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && parts[2].Trim() == customerID.ToString())
                    {
                        int id = int.Parse(parts[0]);
                        int loyaltyPoints = int.Parse(parts[1]);
                        return new Regular(id, loyaltyPoints, customerID);
                    }
                }
            }
            return null;
        }

        public List<Regular> GetRegulars()
        {
            List<Regular> regulars = new List<Regular>();
            string path = UtilityFunctions.GetPath("Regular.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        int loyaltyPoints = int.Parse(parts[1]);
                        int customerID = int.Parse(parts[2]);
                        regulars.Add(new Regular(id, loyaltyPoints, customerID));
                    }
                }
            }
            return regulars;
        }

        public void DeleteRegular(int id)
        {
            string path = UtilityFunctions.GetPath("Regular.txt");

            if (File.Exists(path))
            {
                List<string> lines = File.ReadAllLines(path).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && parts[0].Trim() == id.ToString())
                    {
                        lines.RemoveAt(i);
                        File.WriteAllLines(path, lines);
                        return;
                    }
                }
            }
        }
    }
}
