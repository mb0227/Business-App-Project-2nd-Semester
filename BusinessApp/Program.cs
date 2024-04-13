using SSC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.DL;


namespace RMS.UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //OrderDBDL.ReadOrdersFromDatabase();
            //CustomerDBDL.GetCustomersFromDatabase();
            ObjectHandler.GetTableDL().UpdateTablesStatus();
            ObjectHandler.GetRegularDL().GetRegulars();
            Application.Run(new Homepage());
        }
    }
}
