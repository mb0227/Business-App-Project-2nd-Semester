using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInSignUp.UI;

namespace SignInSignUp
{
    public partial class CustomerNavBar : UserControl
    {
        public CustomerNavBar()
        {
            InitializeComponent();
        }

        private void CustomerNavBar_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }

        private void OrderFoodButton_Click(object sender, EventArgs e)
        {
            CustomerOrderFood customerOrderFood = new CustomerOrderFood();
            customerOrderFood.Show();
            this.Hide();
        }

        private void BookTableButton_Click(object sender, EventArgs e)
        {

        }
    }
}
