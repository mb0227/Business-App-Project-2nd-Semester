using System;
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
    public partial class ManageEmployees : Form
    {
        private Navbar aNavbar;
        private CustomerHeader aHeader; 
        public ManageEmployees()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
        }

        private void InitializeUserControls()
        {
            aHeader = new CustomerHeader();
            Controls.Add(aHeader);
            aHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            aHeader.Top = 0;
            aHeader.Left = 0;
            aHeader.Width = this.Width;

            aNavbar = new Navbar();
            Controls.Add(aNavbar);
            aNavbar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            aNavbar.Left = 0;
            aNavbar.Top = aHeader.Bottom;
            aNavbar.Width = 200;
            aNavbar.Height = this.ClientSize.Height - aHeader.Bottom;

            //aNavbar.NavigationRequested += CustomerNavBar_NavigationRequested;
        }
    }
}
