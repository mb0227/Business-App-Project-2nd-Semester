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
using SSC;
using SSC.UI;

namespace RMS.UI
{
    public partial class ChefDashboard : Form
    {
        private Chef chef;
        public ChefDashboard()
        {
            InitializeComponent();
        }


        public ChefDashboard(Size s, Point l, Chef c)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = l;
            chef = c;
        }

        private void manageBtns_Click(object sender, EventArgs e)
        {
            ManageProducts P = new ManageProducts(this.Size, this.Location, chef);
            P.Show();
            this.Hide();
        }

        private void manageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders= new ManageOrders(this.Size, this.Location, chef);
            manageOrders.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);   
            if (result == DialogResult.Yes)
            {
                Homepage h = new Homepage(this.Size, this.Location);
                h.Show();
                this.Hide();
            }
        }
    }
}
