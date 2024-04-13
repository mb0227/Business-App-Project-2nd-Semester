using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface  IVoucherDL
    {
        Voucher GetVoucher(int ID);
        void GenerateVouchers();
        List<string> AwardVouchers(int number);
    }
}
