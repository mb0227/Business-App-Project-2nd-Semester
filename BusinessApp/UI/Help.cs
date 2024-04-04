using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSC;

namespace SSC.UI
{
    public partial class Help : Form
    {
        private Customer customer;
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;

        public Help()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public Help(Size size, Point location, Customer c)
        {
            customer = c;
            InitializeComponent();
            this.Size = size;
            this.Location = location;
            InitializeUserControls();
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;
            cHeader.BringToFront();

            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom;
            cNavBar.Width = 147;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
            cNavBar.BringToFront();

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
            cNavBar.NavBarCollapsed += CNavBar_NavBarCollapsed;
        }

        private void CustomerNavBar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new CustomerDashboard(this.Size, this.Location, customer));
                    break;
                case "orderFood":
                    OpenForm(new CustomerOrderFood(this.Size, this.Location, customer));
                    break;
                case "bookTable":
                    OpenForm(new CustomerBookTable(this.Size, this.Location, customer));
                    break;
                case "feedback":
                    OpenForm(new CustomerFeedback(this.Size, this.Location, customer));
                    break;
                case "settings":
                    OpenForm(new Settings(this.Size, this.Location, customer));
                    break;
                case "help":
                    OpenForm(new UI.Help(this.Size, this.Location, customer));
                    break;
                default:
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


        private void CNavBar_NavBarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel4.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = "+923344207165";

            Process.Start("tel:" + phoneNumber);
        }
    }
}
