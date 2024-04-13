using RMS.BL;
using SSC;
using SSC.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public class VipFHDL : IVipDL
    {
        public void SaveVIP(VIP vip)
        {
            string path = UtilityFunctions.GetPath("VIP.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{id},{vip.GetMembershipLevel()}, {vip.GetCustomerID()}, {string.Join(";", vip.GetVouchers())}");
            }
        }

        public List<VIP> GetVIPs()
        {
            List<VIP> vips = new List<VIP>();
            string path = UtilityFunctions.GetPath("VIP.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        int id = int.Parse(parts[0]);
                        string membershipLevel = parts[1];
                        int customerID = int.Parse(parts[2]);
                        VIP vip = new VIP(ObjectHandler.GetCustomerDL().SearchCustomerById(customerID).GetUsername(), id, membershipLevel, customerID);
                        vips.Add(vip);
                    }
                }
            }
            return vips;
        }

        public VIP GetVIP(int customerID)
        {
            string path = UtilityFunctions.GetPath("VIP.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4 && parts[2].Trim() == customerID.ToString())
                    {
                        int id = int.Parse(parts[0]);
                        string membershipLevel = parts[1];
                        string vouchers = parts[3];
                        List<string> Vouchers;
                        if (!string.IsNullOrEmpty(vouchers))
                        {
                            Vouchers = new List<string>(vouchers.Split(';'));
                        }
                        else
                        {
                            Vouchers = new List<string>();
                        }
                        return new VIP(id, membershipLevel, customerID, Vouchers);
                    }
                }
            }
            return null;
        }

        public void UpdateVIP(string membershipLevel, int customerID, List<string> Vouchers)
        {
            string path = UtilityFunctions.GetPath("VIP.txt");

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 4 && parts[0].Trim() == customerID.ToString())
                    {
                        parts[1] = membershipLevel;
                        parts[3] = string.Join(";", Vouchers);
                        lines[i] = string.Join(",", parts);
                        File.WriteAllLines(path, lines);
                        return;
                    }
                }
            }
        }
    }
}
