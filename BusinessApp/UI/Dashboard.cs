using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSC.UI
{
    public partial class Dashboard : Form
    {
        private NavigationBar cNavBar;
        private CustomerHeader cHeader;
        public Dashboard()
        {
            InitializeComponent();
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;

            cNavBar = new NavigationBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom; // Assuming headerPanel is the name of your header panel
            cNavBar.Width = 110; // Assuming a fixed width for the navigation bar
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
