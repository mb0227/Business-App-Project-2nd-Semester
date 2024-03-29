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
    public partial class CustomerOrderFood : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;

        public CustomerOrderFood()
        {
            InitializeComponent();
            InitializeHeader();
            InitializeNavBar();
        }

        private void CustomerOrderFood_Load(object sender, EventArgs e)
        {
        }

        private void InitializeHeader()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;
        }

        private void InitializeNavBar()
        {
            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            // Set location and size of the navigation bar
            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom; // Assuming headerPanel is the name of your header panel
            cNavBar.Width = 200; // Assuming a fixed width for the navigation bar
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
