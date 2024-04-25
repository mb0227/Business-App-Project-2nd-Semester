using System;
using System.Windows.Forms;

namespace RMS.UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ObjectHandler.GetTableDL().UpdateTablesStatus();
            Application.Run(new SignIn());
        }
    }
}
