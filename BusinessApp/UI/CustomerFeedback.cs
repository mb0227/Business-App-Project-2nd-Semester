using Guna.UI2.WinForms;
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
using SSC.Properties;
using SignInSignUp.Properties;
using SignInSignUp;

namespace SSC.UI
{
    public partial class CustomerFeedback : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavbar cNavBar;
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
            //pictureBox.Image = UserDBDL.LoadImage(customer.GetUserID());
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
            expressionless.Image = Resource1.expressionless;
        }

        private void expressionless_MouseLeave(object sender, EventArgs e)
        {
            expressionless.Image = Resource1.expressionless_modified;
        }

        private void sad_MouseEnter(object sender, EventArgs e)
        {
            sad.Image =     Resource1.sad1;

        }

        private void sad_MouseLeave(object sender, EventArgs e)
        {
            sad.Image =   Resource1.sad1_modified;
        }

        private void angry_MouseEnter(object sender, EventArgs e)
        {
            angry.Image = Resource1.angry1;
        }

        private void angry_MouseLeave(object sender, EventArgs e)
        {
            angry.Image = Resource1.angry1_modified;
        }

        private void love_MouseEnter(object sender, EventArgs e)
        {
            lovedit.Image =     Resource1.best1;
        }

        private void love_MouseLeave(object sender, EventArgs e)
        {
            lovedit.Image = Resource1.best1_modified;
        }

        private void happy_MouseEnter(object sender, EventArgs e)
        {
            happy.Image = Resource1.happy1;
        }

        private void happy_MouseLeave(object sender, EventArgs e)
        {
            happy.Image = Resource1.happy1_modified;
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;
            cHeader.BringToFront();

            cNavBar = new CustomerNavbar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom;
            cNavBar.Width = 147;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
            cNavBar.BringToFront();

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
            cNavBar.NavBarCollapsed += CNavBar_NavBarCollapsed;
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
                case "settings":
                    OpenForm(new Settings(this.Size, this.Location, customer));
                    break;
                case "help":
                    OpenForm(new UI.Help(this.Size, this.Location, customer));
                    break;
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


        private void CNavBar_NavBarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel4.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void angry_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback("1 Star", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
            ObjectHandler.GetFeedbackDL().SaveReview(f);
            MessageBox.Show("Thanks for review", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sad_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback("2 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
            ObjectHandler.GetFeedbackDL().SaveReview(f);
            MessageBox.Show("Thanks for review", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void expressionless_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback("3 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
            ObjectHandler.GetFeedbackDL().SaveReview(f);
            MessageBox.Show("Thanks for review", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void happy_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback("4 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
            ObjectHandler.GetFeedbackDL().SaveReview(f);
            MessageBox.Show("Thanks for review", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lovedit_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback("5 Stars", ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
            ObjectHandler.GetFeedbackDL().SaveReview(f);
            MessageBox.Show("Thanks for review", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
