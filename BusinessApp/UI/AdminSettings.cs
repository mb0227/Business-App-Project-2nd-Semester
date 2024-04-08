using RMS.BL;
using SSC.UI;
using SSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SignInSignUp.UI
{
    public partial class AdminSettings : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        public AdminSettings()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public AdminSettings(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }

        private void InitializeUserControls()
        {
            aHeader = new CustomerHeader();
            Controls.Add(aHeader);
            aHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            aHeader.Top = 0;
            aHeader.Left = 0;
            aHeader.Width = this.Width;
            aHeader.BringToFront();

            aNavbar = new Navbar();
            Controls.Add(aNavbar);
            aNavbar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            aNavbar.Left = 0;
            aNavbar.Top = aHeader.Bottom;
            aNavbar.Width = 178;
            aNavbar.Height = this.ClientSize.Height - aHeader.Bottom;
            aNavbar.BringToFront();

            aNavbar.NavigationRequested += navbar_NavigationRequested;
            aNavbar.NavBarCollapsed += aNavbar_NavbarCollapsed;
        }

        private void navbar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new AdminDashboard(this.Size, this.Location, Admin));
                    break;
                case "manageEmployees":
                    OpenForm(new ManageEmployees(this.Size, this.Location, Admin));
                    break;
                case "manageCustomers":
                    OpenForm(new ManageEmployees(this.Size, this.Location, Admin));
                    break;
                case "sendNotifications":
                    OpenForm(new SendNotifications(this.Size, this.Location, Admin));
                    break;
                case "settings":
                    OpenForm(new AdminSettings(this.Size, this.Location, Admin));
                    break;
                case "addAdmin":
                    OpenForm(new AddAdmin(this.Size, this.Location, Admin));
                    break;
                case "manageTables":
                    OpenForm(new ManageTables(this.Size, this.Location, Admin));
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

        private void aNavbar_NavbarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel2.BringToFront();
                panel1.BringToFront();
            }
            else
            {
                panel2.SendToBack();
                panel1.SendToBack();
                aNavbar.BringToFront();
            }
        }
       
        private void passwordButton_Click(object sender, EventArgs e)
        {
            ChangeButtonsVisibility(false);
            ChangeUpdateControlsVisibility(true);
            label.Text = "Password";
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            ChangeButtonsVisibility(false);
            ChangeUpdateControlsVisibility(true);
            label.Text = "Username";
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
            if(type=="username")
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

                if (ObjectHandler.GetEmployeeDL().UsernameAlreadyExists(tb.Text))
                {
                    errorProvider1.SetError(tb, "Username already exists.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }                
            }
            else if(type=="password")
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (label.Text=="Username")
            {
                if (CheckValidations("username"))
                {
                    ObjectHandler.GetEmployeeDL().UpdateCredentials(tb.Text, "username", Admin.GetEmployeeID());
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
                    tb.UseSystemPasswordChar = true;
                    tb.PasswordChar = '*';
                    ObjectHandler.GetEmployeeDL().UpdateCredentials(tb.Text, "password", Admin.GetUserID());
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage(this.Size, this.Location);
            h.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you delete account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ObjectHandler.GetEmployeeDL().DeleteEmployee(Admin.GetEmployeeID(), "admin", Admin.GetUserID());
                Homepage p = new Homepage(this.Size, this.Location);
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Good Job.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
