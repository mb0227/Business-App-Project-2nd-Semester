using SSC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.DL;
using SignInSignUp.UI;

namespace SSC
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

            ProductDL.ReadProductsFromDatabase();
            OrderDL.ReadOrdersFromDatabase();
            CustomerDL.GetCustomersFromDatabase();

            Application.Run(new SignIn());
        }
    }
}
