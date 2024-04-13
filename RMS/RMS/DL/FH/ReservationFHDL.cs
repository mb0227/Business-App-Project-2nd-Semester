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
    public class ReservationFHDL : IReservationDL
    {
        public void SaveReservation(Reservation r)
        {
            string path = UtilityFunctions.GetPath("Reservations.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{r.GetTotalPersons()}, {r.GetReservationDate()},{r.GetTableID()},{r.GetCustomerID()}");
            }
        }

        public void SaveReservation(Reservation r, int x)
        {
            string path = UtilityFunctions.GetPath("Reservations.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{r.GetTotalPersons()}, {r.GetReservationDate()},{r.GetTableID()}, {"-1"}");
            }
        }

        public void DeleteReservationByID(int reservationID)
        {
            string path = UtilityFunctions.GetPath("Reservations.txt");
            List<string> lines = new List<string>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 1 && parts[0] != reservationID.ToString())
                        {
                            lines.Add(line);
                        }
                    }
                }
                File.WriteAllLines(path, lines);
            }
        }

        public List<Reservation> GetReservations()
        {
            string path = UtilityFunctions.GetPath("Reservations.txt");
            List<Reservation> reservations = new List<Reservation>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4)
                        {
                            int id = int.Parse(parts[0]);
                            DateTime date = DateTime.Parse(parts[2]);
                            int persons = int.Parse(parts[1]);
                            int tableId = int.Parse(parts[3]);
                            int customerID = int.Parse(parts[4]);
                            Reservation reservation = new Reservation(id, date, persons, customerID, tableId);
                            reservations.Add(reservation);
                        }
                    }
                }
            }

            return reservations;
        }

        public int GetCustomerReservationCount(int customerId)
        {
            int reservationCount = 0;
            string path = UtilityFunctions.GetPath("Reservations.txt");

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[4] == customerId.ToString())
                        {
                            DateTime reservationDate = DateTime.Parse(parts[2]);
                            if (reservationDate >= DateTime.Now)
                            {
                                reservationCount++;
                            }
                        }
                    }
                }
            }
            return reservationCount;
        }

        public DateTime GetReservationDate(int customerid)
        {
            DateTime date = DateTime.MinValue;
            string path = UtilityFunctions.GetPath("Reservations.txt");

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[4].Trim() == customerid.ToString())
                        {
                            date = DateTime.Parse(parts[2]);
                            break;
                        }
                    }
                }
            }

            return date;
        }

        public void DeleteReservation(int customerid)
        {
            string path = UtilityFunctions.GetPath("Reservations.txt");
            List<string> updatedLines = new List<string>();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5 && parts[4].Trim() != customerid.ToString())
                        {
                            updatedLines.Add(line);
                        }
                    }
                }
                File.WriteAllLines(path, updatedLines);
            }
        }

    }
}
