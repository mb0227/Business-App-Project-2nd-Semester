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
    public partial class NavigationBar : UserControl
    {
        bool sidebarExpand;
        public NavigationBar()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Tick(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //sidebar.MaximumSize = new Size(sidebar.MaximumSize.Width, this.Height);
            //sidebar.MinimumSize = new Size(sidebar.MinimumSize.Width, this.Height);
            sidebarTimer.Start();
        }
    }
}
