﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.DL;

namespace SSC.UI
{
    public partial class ManageCustomers : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        public ManageCustomers()
        {
            InitializeComponent();
        }

        public ManageCustomers(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            //InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }
    }
}
