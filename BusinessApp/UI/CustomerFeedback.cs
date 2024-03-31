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
    public partial class CustomerFeedback : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        private Customer customer;

        public CustomerFeedback()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public CustomerFeedback(Size size, Point location, Customer c)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            customer = c;
        }

        private void CustomerFeedback_Load(object sender, EventArgs e)
        {
            expressionless.MouseEnter += expressionless_MouseEnter;
            expressionless.MouseLeave += expressionless_MouseLeave;
            sad.MouseEnter += sad_MouseEnter;
            sad.MouseLeave += sad_MouseLeave;
            angry.MouseEnter += angry_MouseEnter;
            angry.MouseLeave += angry_MouseLeave;
            lovedit.MouseEnter += love_MouseEnter;
            lovedit.MouseLeave += love_MouseLeave;
            happy.MouseEnter += happy_MouseEnter;
            happy.MouseLeave += happy_MouseLeave;
        }

        private void expressionless_MouseEnter(object sender, EventArgs e)
        {
            expressionless.Image = Properties.Resources.expressionless;
        }

        private void expressionless_MouseLeave(object sender, EventArgs e)
        {
            expressionless.Image = Properties.Resources.expressionless_modified;
        }

        private void sad_MouseEnter(object sender, EventArgs e)
        {
            sad.Image = Properties.Resources.sad1;
        }

        private void sad_MouseLeave(object sender, EventArgs e)
        {
            sad.Image = Properties.Resources.sad1_modified;
        }

        private void angry_MouseEnter(object sender, EventArgs e)
        {
            angry.Image = Properties.Resources.angry1;
        }

        private void angry_MouseLeave(object sender, EventArgs e)
        {
            angry.Image = Properties.Resources.angry1_modified;
        }

        private void love_MouseEnter(object sender, EventArgs e)
        {
            lovedit.Image = Properties.Resources.best1;
        }

        private void love_MouseLeave(object sender, EventArgs e)
        {
            lovedit.Image = Properties.Resources.best1_modified;
        }

        private void happy_MouseEnter(object sender, EventArgs e)
        {
            happy.Image = Properties.Resources.happy1;
        }

        private void happy_MouseLeave(object sender, EventArgs e)
        {
            happy.Image = Properties.Resources.happy1_modified;
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

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
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
                //case "help":
                //    OpenForm(new Help(this.Size, this.Location, customer));
                //    break;
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
       
    }
}
