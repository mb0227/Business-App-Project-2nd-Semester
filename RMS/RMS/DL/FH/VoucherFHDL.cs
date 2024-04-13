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
    public class VoucherFHDL : IVoucherDL
    {
        public List<string> AwardVouchers(int number)
        {
            List<string> vouchers = new List<string>();
            string path = UtilityFunctions.GetPath("Vouchers.txt");

            if (!File.Exists(path))
            {
                return vouchers;
            }

            string[] lines = File.ReadAllLines(path);
            Random rng = new Random();
            lines = lines.OrderBy(line => rng.Next()).ToArray();

            for (int i = 0; i < Math.Min(number, lines.Length); i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length > 0)
                {
                    vouchers.Add(parts[0].Trim());
                }
            }
            return vouchers;
        }

        public Voucher GetVoucher(int ID)
        {
            string path = UtilityFunctions.GetPath("Vouchers.txt");
            if (!File.Exists(path))
            {
                return null;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3 && parts[0].Trim() == ID.ToString())
                {
                    int id = Convert.ToInt32(parts[0]);
                    DateTime e;
                    if (!DateTime.TryParse(parts[1], out e))
                    {
                        return null;
                    }
                    if (!decimal.TryParse(parts[2], out decimal d))
                    {
                        return null;
                    }
                    double v = Convert.ToDouble(d);
                    return new Voucher(id, e, v);
                }
            }

            return null;
        }

        public void GenerateVouchers()
        {
            Random random = new Random();
            string path = UtilityFunctions.GetPath("Vouchers.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 200; i++)
                {
                    DateTime expirationDate = DateTime.Today.AddDays(random.Next(1, 365));
                    decimal value = (decimal)random.NextDouble() * 1000;
                    string voucherData = $"{i + 1},{expirationDate},{value}";
                    writer.WriteLine(voucherData);
                }
            }
            Console.WriteLine("Vouchers generated.");
        }
    }
}
