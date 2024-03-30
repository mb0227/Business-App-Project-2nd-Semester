using SignInSignUp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public partial class CustomerDashboard : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;

        public CustomerDashboard()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public CustomerDashboard(Size size, Point location)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
            InitializeUserControls();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;

            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            // Set location and size of the navigation bar
            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom; // Assuming headerPanel is the name of your header panel
            cNavBar.Width = 200; // Assuming a fixed width for the navigation bar
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
        }

        private void CustomerNavBar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new CustomerDashboard());
                    break;
                case "orderFood":
                    OpenForm(new CustomerOrderFood());
                    break;
                case "bookTable":
                    OpenForm(new CustomerBookTable());
                    break; 
            }
        }

        private void OpenForm(Form form)
        {
            form.Size = this.Size;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
