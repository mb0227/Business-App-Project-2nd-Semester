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
        private List<Regular> Regulars = new List<Regular>();
        public void SaveRegular(Regular regular)
        {
            string path = UtilityFunctions.GetPath("Regular.txt");
            int id = UtilityFunctions.AssignID(path);
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine($"{id},{regular.GetLoyaltyPoints()}, {regular.GetCustomerID()}");
            }
        }

        public List<Regular> GetRegulars()
        {
            return Regulars;
        }

        public void DeleteRegular(int id)
        {

        }

        public void UpdateRegular(Regular regular)
        {

        }
        public Regular GetRegular(int customerID)
        {
            return new Regular(2, 22, 3);
        }
    }
}
