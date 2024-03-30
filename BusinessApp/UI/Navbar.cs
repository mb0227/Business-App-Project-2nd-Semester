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
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
            button1.Text = "Dashboard              ";
            button2.Text = " Manage Employees";
            button3.Text = "  Manage Customers";
            button4.Text = "Send Notification   ";
            button5.Text = "Add Admin             ";
            button6.Enabled = false;
            button7.Text = "Settings                ";
            pictureBox1.Image = Properties.Resources.icons8_home_50;
            pictureBox2.Image = Properties.Resources.employee;
            pictureBox3.Image = Properties.Resources.customer;
            pictureBox4.Image = Properties.Resources.notifications;
            pictureBox5.Image = Properties.Resources.admin;
            pictureBox7.Image = Properties.Resources.gear_solid;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
