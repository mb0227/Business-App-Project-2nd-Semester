﻿using SignInSignUp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
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

            CustomerDL.GetCustomersFromDatabase();
            ProductDL.ReadProductsFromDatabase();
            OrderDL.ReadOrdersFromDatabase();

            Application.Run(new SignIn());
        }
    }
}
