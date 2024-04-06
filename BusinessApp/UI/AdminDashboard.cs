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
    public partial class AdminDashboard : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        public AdminDashboard()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
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
            aHeader.BringToFront();

            aNavbar = new Navbar();
            Controls.Add(aNavbar);
            aNavbar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            aNavbar.Left = 0;
            aNavbar.Top = aHeader.Bottom;
            aNavbar.Width = 187;
            aNavbar.Height = this.ClientSize.Height - aHeader.Bottom;
            aNavbar.BringToFront();

            aNavbar.NavigationRequested += CustomerNavBar_NavigationRequested;
            aNavbar.NavBarCollapsed += aNavbar_NavBarCollapsed;
        }

        private void CustomerNavBar_NavigationRequested(object sender, string formName)
        {
            //switch (formName)
            //{
            //    case "dashboard":
            //        OpenForm(new CustomerDashboard(this.Size, this.Location, customer));
            //        break;
            //    case "orderFood":
            //        OpenForm(new CustomerOrderFood(this.Size, this.Location, customer));
            //        break;
            //    case "bookTable":
            //        OpenForm(new CustomerBookTable(this.Size, this.Location, customer));
            //        break;
            //    case "feedback":
            //        OpenForm(new CustomerFeedback(this.Size, this.Location, customer));
            //        break;
            //    case "settings":
            //        OpenForm(new Settings(this.Size, this.Location, customer));
            //        break;
            //    case "help":
            //        OpenForm(new UI.Help(this.Size, this.Location, customer));
            //        break;
            //    default:
            //        break;
            //}
        }

        private void OpenForm(Form form)
        {
            form.Size = this.Size;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void aNavbar_NavBarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel1.BringToFront();
            }
            else
            {
                panel1.SendToBack();
                aNavbar.BringToFront();
            }
        }

    }
}
