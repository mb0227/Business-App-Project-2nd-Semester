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
using SignInSignUp.Reports;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace SSC.UI
{
    public partial class Settings : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavbar cNavBar;
        private Customer customer;
        private bool nVisible = false;
        Button markRead = new Button();

        public Settings()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public Settings(Size size, Point location, Customer c)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            customer = c;
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
                case "feedback":
                    OpenForm(new CustomerFeedback(this.Size, this.Location, customer));
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
                panel1.BringToFront();
            }
            else
            {
                panel1.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            int n =ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID()).Count;
            if (n > 0)
            {
                notiCount.Text = n.ToString();
                notiCount.Visible = true;
            }
            if(customer.GetStatus()=="VIP")
            {
                ChangeButtonsText();
            }
            pictureBox.Image = ObjectHandler.GetPhotoDL().LoadImage(customer.GetUserID());
        }

        private void MakeBtnVisible(int x,int y)
        {
            markRead.Location = new Point(x, y);
            markRead.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!nVisible)
            {
                List<string> notifications = ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID());
                int y = 124;
                int labelX = this.Width - 150 - SystemInformation.VerticalScrollBarWidth;
                nVisible = true;
                int labelMaxWidth = panel3.Width - 10; 

                foreach (string notification in notifications)
                {
                    Label label = new Label();
                    label.Text = "- "+ notification;
                    label.ForeColor = Color.Red;
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Anchor = AnchorStyles.None;
                    label.AutoSize = true;
                    label.MaximumSize = new Size(labelMaxWidth, 0); // Set maximum width
                    label.Location = new Point(labelX, y);
                    panel3.Controls.Add(label);
                    y += label.Height + 10;
                    MakeBtnVisible(labelX, y + 10 + (notifications.Count * 30));
                }

                markRead.Text = "Mark Read";
                markRead.BackColor = Color.Transparent;
                markRead.FlatStyle = FlatStyle.Flat;
                markRead.FlatAppearance.BorderSize = 0;
                markRead.Width = 100;
                markRead.Height = 25;
                markRead.ForeColor = Color.Black; 
                markRead.Font = new Font("Tahoma", 12, FontStyle.Regular); 
                                                                             
                markRead.Click += MarkRead_Click;

                panel3.Controls.Add(markRead);
            }
            else
            {
                nVisible = false;
                markRead.Visible = false;
                foreach (Control control in panel3.Controls)
                {
                    if (control is Label)
                    {
                        control.Visible=false;
                    }
                }
            }
        }
        private void MarkRead_Click(object sender, EventArgs e)
        {
            List<string> notifications = ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID());
            foreach (string notification in notifications)
            {
                MessageBox.Show(notification);
                ObjectHandler.GetNotificationDL().MarkAsRead(customer.GetID());
            }
        }

        private void ChangeUpdateControlsVisibility(bool b)
        {
            tb.Visible = b;
            label.Visible = b;
            updateButton.Visible = b;
            backBtn.Visible = b;
        }

        private bool CheckValidations(string type)
        {
            if (type == "username")
            {
                if (string.IsNullOrWhiteSpace(tb.Text.Trim()))
                {
                    errorProvider2.SetError(tb, "Username cannot be empty.");
                    return false;
                }
                else
                {
                    errorProvider2.SetError(tb, "");
                }

                if (ObjectHandler.GetCustomerDL().UsernameAlreadyExists(tb.Text))
                {
                    errorProvider1.SetError(tb, "Username already exists.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }
            }
            else if (type == "password")
            {
                if (string.IsNullOrWhiteSpace(tb.Text.Trim()))
                {
                    errorProvider2.SetError(tb, "Password cannot be empty.");
                    return false;
                }
                else
                {
                    errorProvider2.SetError(tb, "");
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        private void ChangeButtonsVisibility(bool x)
        {
            foreach (Guna2Button b in panel2.Controls.OfType<Guna2Button>())
            {
                b.Visible = x;
            }
        }
        private void passwordButton_Click(object sender, EventArgs e)
        {
            ChangeButtonsVisibility(false);
            ChangeUpdateControlsVisibility(true);
            label.Text = "Password";
            tb.UseSystemPasswordChar = true;
            tb.PasswordChar = '*';
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            ChangeButtonsVisibility(false);
            ChangeUpdateControlsVisibility(true);
            label.Text = "Username";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (label.Text == "Username")
            {
                label.Text = label.Text.Replace(",", "");
                if (CheckValidations("username"))
                {
                    ObjectHandler.GetCustomerDL().UpdateCredentials(tb.Text, "username", customer.GetUserID());
                    MessageBox.Show("Username changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToNormal();
                }
                else
                {
                    MessageBox.Show("Failed to change username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (label.Text == "Password")
            {
                if (CheckValidations("password"))
                {
                    ObjectHandler.GetEmployeeDL().UpdateCredentials(tb.Text, "password", customer.GetUserID());
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToNormal();
                    tb.UseSystemPasswordChar = false;
                }
                else
                {
                    MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackToNormal()
        {
            ChangeButtonsVisibility(true);
            ChangeUpdateControlsVisibility(false);
            tb.Text = "";
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            BackToNormal();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            ShowReport r = new ShowReport("orderHistory", customer.GetID());
            r.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (customer.GetStatus().ToLower() == "regular")
                {
                    ObjectHandler.GetCustomerDL().DeleteCustomer(customer.GetID(), "regular", customer.GetUserID());
                    Homepage p = new Homepage(this.Size, this.Location);
                    p.Show();
                    this.Hide();
                }
                else if(customer.GetStatus().ToLower() == "vip")
                {
                    ObjectHandler.GetCustomerDL().DeleteCustomer(customer.GetID(), "vip", customer.GetUserID());
                    Homepage p = new Homepage(this.Size, this.Location);
                    p.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Good Job.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Homepage h = new Homepage(this.Size, this.Location);
                h.Show();
                this.Hide();
            }
        }

        private void ChangeButtonsText()
        {
            updateToVipBtn.Text = "Upgrade Membership";
            guna2Button1.Text = "View Membership Level";
        }

        private void updateToVipBtn_Click(object sender, EventArgs e)
        {
            if (customer.GetStatus() == "Regular")
            {
                Regular r = ObjectHandler.GetRegularDL().GetRegular(customer.GetID());
                if (r.GetLoyaltyPoints() >= 100)
                {
                    MessageBox.Show("Congrats! You are now a Silver VIP", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    r.PromoteToVip(ObjectHandler.GetVoucherDL().AwardVouchers(3));
                    customer.SetStatus("VIP");
                    ChangeButtonsText();
                    ShowAwardMessage(3);
                }
                else
                {
                    MessageBox.Show("You need at least 100 loyalty points to become a VIP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(customer.GetStatus() == "VIP")
            {
                if (ObjectHandler.GetOrderDL().CountOrders(customer.GetID()) > 30)
                {
                    VIP v = ObjectHandler.GetVipDL().GetVIP(customer.GetID());
                    v.SetMembershipLevel("Diamond");
                    ObjectHandler.GetVipDL().UpdateVIP("Diamond", customer.GetID(), ObjectHandler.GetVoucherDL().AwardVouchers(25));
                    MessageBox.Show("Congrats! You are now a Diamond VIP", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAwardMessage(25);
                }
                else if (ObjectHandler.GetOrderDL().CountOrders(customer.GetID())> 50)
                {
                    VIP v = ObjectHandler.GetVipDL().GetVIP(customer.GetID());
                    v.SetMembershipLevel("Gold");
                    ObjectHandler.GetVipDL().UpdateVIP("Gold", customer.GetID(), ObjectHandler.GetVoucherDL().AwardVouchers(10));
                    MessageBox.Show("Congrats! You are now a Gold VIP", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAwardMessage(10);
                }
                else
                {
                    MessageBox.Show($"You need at least 30 orders for Gold and 50 for Diamond. Current Orders :{ObjectHandler.GetOrderDL().CountOrders(customer.GetID())}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ShowAwardMessage(int vCount)
        {
            MessageBox.Show($"You have been awarded {vCount} vouchers", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (customer.GetStatus() == "Regular")
            {
                Regular r = ObjectHandler.GetRegularDL().GetRegular(customer.GetID());
                MessageBox.Show($"You have {r.GetLoyaltyPoints()} loyalty points.", "Loyalty Points", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(customer.GetStatus() == "VIP")
            {
                VIP v = ObjectHandler.GetVipDL().GetVIP(customer.GetID());
                MessageBox.Show($"You are a {v.GetMembershipLevel()} VIP.", "VIP Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userDetailsButton_Click(object sender, EventArgs e)
        {
        }
    }
}
