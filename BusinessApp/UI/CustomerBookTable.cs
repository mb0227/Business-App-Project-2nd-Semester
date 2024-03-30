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
    public partial class CustomerBookTable : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        public CustomerBookTable()
        {
            InitializeComponent();
            InitializeHeader();
            InitializeNavBar();
        }

        private void CustomerBookTable_Load(object sender, EventArgs e)
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

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom; 
            cNavBar.Width = 200; 
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
        }
    }
}
