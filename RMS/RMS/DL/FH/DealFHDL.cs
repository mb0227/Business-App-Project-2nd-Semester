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
    public class DealFHDL : IDealDL
    {
        public void SaveDeal(Deal deal)
        {
            string path = UtilityFunctions.GetPath("Deals.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{id},{deal.GetDealName()}, {deal.GetPrice()}, {deal.GetDealString()}");
            }
        }

        public List<Deal> GetDeals()
        {
            List<Deal> deals = new List<Deal>();
            string path = UtilityFunctions.GetPath("Deals.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        int id = Convert.ToInt32(parts[0].Trim());
                        string name = parts[1].Trim();
                        double price = Convert.ToDouble(parts[2].Trim());
                        string items = parts[3].ToString();

                        Deal deal = new Deal(id, name, price, UtilityFunctions.GetDealList(items));
                        deals.Add(deal);
                    }
                }
            }
            return deals;
        }

        public Deal GetDeal(int id)
        {
            List<Deal> deals = GetDeals();
            foreach (Deal deal in deals)
            {
                if (deal.GetID() == id)
                    return deal;
            }
            return null;
        }

        public Deal GetDeal(string name)
        {
            List<Deal> deals = GetDeals();
            foreach (Deal deal in deals)
            {
                if (deal.GetDealName() == name)
                    return deal;
            }
            return null;
        }

        public void RemoveDeal(int id)
        {
            string path = UtilityFunctions.GetPath("Deals.txt");
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length == 4 && parts[0].Trim() == id.ToString())
                {
                    lines[i] = "";
                    break;
                }
            }
            File.WriteAllLines(path, lines);
        }
    }
}

