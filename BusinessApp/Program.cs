using System;
using System.Windows.Forms;
using RMS.Utility;

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
            ObjectHandler.GetMessageDL().DeleteEmptyMessages();
            Application.Run(new Homepage());
        }
    }
}