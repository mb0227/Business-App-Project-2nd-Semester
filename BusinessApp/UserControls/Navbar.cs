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
    public partial class Navbar : UserControl
    {
        bool sidebarExpand;
        public bool IsNavBarCollapsed { get; private set; }
        public event EventHandler<string> NavigationRequested;
        public event EventHandler<bool> NavBarCollapsed;
        public Navbar()
        {
            InitializeComponent();
            IsNavBarCollapsed = true;
        }

        private void OnNavigationRequested(string formName)
        {
            NavigationRequested?.Invoke(this, formName);
        }

        private void ToggleNavBar()
        {
            IsNavBarCollapsed = !IsNavBarCollapsed;
            NavBarCollapsed?.Invoke(this, IsNavBarCollapsed);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            ToggleNavBar();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                sidebar.Height = this.Height;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("dashboard");
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("manageEmployees");
        }

        private void customerCRUD_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("manageCustomers");
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("sendNotifications");
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("addAdmin");
        }

        private void productsCRUDBtn_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("manageTables");
        }

        private void settingsBtn_Click(object sender, EventArgs e) //Feedback
        {
            OnNavigationRequested("feedback");
        }

        private void guna2Button1_Click(object sender, EventArgs e) //settings
        {
            OnNavigationRequested("settings");
        }
    }
}
