using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSC.UI;

namespace SSC
{
    public partial class CustomerNavbar : UserControl
    {
        bool sidebarExpand;
        public bool IsNavBarCollapsed { get; private set; }
        public event EventHandler<string> NavigationRequested;
        public event EventHandler<bool> NavBarCollapsed;

        public CustomerNavbar()
        {
            InitializeComponent();
            IsNavBarCollapsed = true; 
        }

        private void OnNavigationRequested(string formName)
        {
            NavigationRequested?.Invoke(this, formName);
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

        private void bars_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            ToggleNavBar();
        }

        private void ToggleNavBar()
        {
            IsNavBarCollapsed = !IsNavBarCollapsed; 
            NavBarCollapsed?.Invoke(this, IsNavBarCollapsed); 
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("dashboard");
        }

        private void orderFoodButton_Click_1(object sender, EventArgs e)
        {
            OnNavigationRequested("orderFood");
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("bookTable");
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            OnNavigationRequested("feedback");
        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            OnNavigationRequested("help");
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("settings");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
