using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface IVipDL
    {
        List<VIP> GetVIPs();
        void SaveVIP(VIP vip);
        VIP GetVIP(int customerID);
        void UpdateVIP(string membershipLevel, int customerID, List<string> Vouchers);
    }
}
