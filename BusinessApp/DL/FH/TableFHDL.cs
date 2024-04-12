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
    public class TableFHDL : ITableDL
    {
        public void SaveTable(Table table)
        {
            string path = UtilityFunctions.GetPath("Tables.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{table.GetCapacity()}, {"Unbooked"}");
            }
        }

        public void UpdateTablesStatus(int tableID)
        {
            string path = UtilityFunctions.GetPath("Tables.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && parts[0] == tableID.ToString())
                    {
                        parts[2] = "Unbooked";
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }

        public void UpdateTablesStatus()
        {
            string path = "Tables.txt";
            string path2 = "Reservations.txt";
            List<string> updatedLines = new List<string>(); 

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            int id = int.Parse(parts[0]);
                            int capacity = int.Parse(parts[1]);
                            string status = parts[2];
                            if (File.Exists(path2))
                            {
                                using (StreamReader reader2 = new StreamReader(path2))
                                {
                                    string line2;
                                    while ((line2 = reader2.ReadLine()) != null)
                                    {
                                        string[] parts2 = line2.Split(',');
                                        if (parts2.Length >= 3 && parts2[3] == id.ToString())
                                        {
                                            DateTime reservationDate = DateTime.Parse(parts2[2]);
                                            if (DateTime.Now > reservationDate)
                                            {
                                                status = "Unbooked";
                                                line = $"{id},{capacity},{status}";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        updatedLines.Add(line); 
                    }
                }
                File.WriteAllLines(path, updatedLines);
            }
        }

        public Table GetTableById(int id)
        {
            string path = "Tables.txt"; 
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[0] == id.ToString())
                        {
                            int capacity = int.Parse(parts[1]);
                            string status = parts[2];
                            return new Table(capacity, id, status);
                        }
                    }
                }
            }
            return null;
        }

        public List<Table> GetTables()
        {
            string path = "Tables.txt"; 
            List<Table> tables = new List<Table>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            int id = int.Parse(parts[0]);
                            int capacity = int.Parse(parts[1]);
                            string status = parts[2];
                            tables.Add(new Table(capacity, id, status));
                        }
                    }
                }
            }

            return tables;
        }

        public void UpdateTable(Table t)
        {
            string path = "Tables.txt";
            if (File.Exists(path))
            {
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[0] == t.GetID().ToString())
                        {
                            parts[1] = t.GetCapacity().ToString();
                            parts[2] = t.GetStatus();
                        }
                        lines.Add(string.Join(",", parts)); 
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }


        public int GetTableCapacity(int id)
        {
            string path = "Tables.txt";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[0] == id.ToString())
                        {
                            return int.Parse(parts[1]);
                        }
                    }
                }
            }
            return id; 
        }

        public int GetReservedTableID(int customerid)
        {
            string path = "Reservations.txt"; 
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3 && parts[1] == customerid.ToString())
                        {
                            return int.Parse(parts[2]);
                        }
                    }
                }
            }
            return -1; 
        }

        public void DeleteTable(int id)
        {
            string path = UtilityFunctions.GetPath("Tables.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && parts[0] == id.ToString())
                    {
                        lines[i] = "";
                        break;
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }
    }
}
