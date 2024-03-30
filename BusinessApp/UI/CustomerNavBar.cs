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
        public event EventHandler<string> NavigationRequested;
        public CustomerNavBar()
        {
            InitializeComponent();
        }

        private void CustomerNavBar_Load(object sender, EventArgs e)
        {
        }

        private void OnNavigationRequested(string formName)
        {
            NavigationRequested?.Invoke(this, formName);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("dashboard"); 
        }

        private void OrderFoodButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("orderFood"); 
        }

        private void BookTableButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("bookTable"); 
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("feedback");
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("settings");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            OnNavigationRequested("help");
        }
    }
}
