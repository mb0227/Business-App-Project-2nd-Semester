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
    public partial class Settings : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        public Settings()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void Settings_Load(object sender, EventArgs e)
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

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom;
            cNavBar.Width = 200;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;

            //cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
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

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
