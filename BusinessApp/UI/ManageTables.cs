using RMS.BL;
using SSC.UI;
using SSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class ManageTables : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        public ManageTables()
        {
            InitializeComponent();
        }

        public ManageTables(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            //InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }
    }
}
