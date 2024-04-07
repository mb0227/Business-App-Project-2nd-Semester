using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface IChefDL
    {
        void SaveChef(Chef chef);
        List<Chef> GetChefs();

    }
}
