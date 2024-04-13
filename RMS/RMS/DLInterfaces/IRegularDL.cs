using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface IRegularDL
    {
        void SaveRegular(Regular regular);
        List<Regular> GetRegulars();
        void DeleteRegular(int id);
        void UpdateRegular(Regular regular);
        Regular GetRegular(int customerID);
    }
}
