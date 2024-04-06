using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using RMS.BL;
using RMS.DL;
using SignInSignUp.UI;

namespace SSC.UI
{
    public partial class ManageEmployees : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        IUserDBDL userDL = new UserDL();
        IEmployeeDBDL employeeDL = new EmployeeDL();
        public ManageEmployees()
        {
            InitializeComponent();
        }

        public ManageEmployees(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
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
                panel4.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                aNavbar.BringToFront();
            }
        }

        private void employeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employeeType.Text=="Waiter")
            {
                label9.Text = "Schedule";
                label10.Text = "Tables";
                label11.Text = "Language";
                SetVisible();
            }
            else if(employeeType.Text=="Chef")
            {
                label9.Text = "Schedule";
                label10.Text = "Specialize";
                label11.Text = "Experience";
                SetVisible();
            }
            else
            {
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
            }
        }

        private void SetVisible()
        {
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (CheckValidations())
            {
                User user = new User(email.Text, password.Text, employeeType.Text);
                userDL.StoreUserInDB(user);
                Employee employee = new Employee(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), UserDL.GetUserID(email.Text, password.Text));
                employeeDL.StoreEmployeeInDB(employee);
                if (employeeType.Text == "Waiter")
                {
                    Waiter waiter = new Waiter(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), UserDL.GetUserID(email.Text, password.Text), tb1.Text, tb2.Text, tb3.Text, EmployeeDL.GetEmployeeID(username.Text));
                    WaiterDL.StoreWaiterInDB(waiter);
                }
                else if (employeeType.Text == "Chef")
                {
                    Chef chef = new Chef(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), UserDL.GetUserID(email.Text, password.Text), tb1.Text, tb2.Text, tb3.Text, EmployeeDL.GetEmployeeID(username.Text));
                    ChefDL.StoreChefInDB(chef);
                }
            }
        }

        private bool CheckValidations()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(email.Text, pattern))
            {
                errorProvider1.SetError(email, "Email pattern is Invalid.");
                return false;
            }
            else
            {
                errorProvider1.SetError(email, "");
            }

            if (UserDL.EmailAlreadyExists(email.Text))
            {
                errorProvider2.SetError(email, "Email already exists.");
                return false;
            }
            else
            {
                errorProvider2.SetError(email, "");
            }

            if (string.IsNullOrWhiteSpace(password.Text.Trim()))
            {
                errorProvider2.SetError(password, "Password cannot be empty.");
                return false;
            }
            else
            {
                errorProvider2.SetError(password, "");
            }

            if (string.IsNullOrWhiteSpace(username.Text.Trim()))
            {
                errorProvider3.SetError(username, "Username cannot be empty.");
                return false;
            }
            else
            {
                errorProvider3.SetError(username, "");
            }

            if(EmployeeDL.UsernameAlreadyExists(username.Text))
            {
                errorProvider3.SetError(username, "Username already exists.");
                return false;
            }
            else
            {
                errorProvider3.SetError(username, "");
            }


            string contactPattern = @"^0\d{10}$";
            if (!Regex.IsMatch(contact.Text, contactPattern))
            {
                errorProvider4.SetError(contact, "Please enter a valid phone number.");
                return false;
            }
            else
            {
                errorProvider4.SetError(contact, "");
            }

            int number;
            bool isValid = int.TryParse(salary.Text, out number);

            if (!isValid)
            {
                errorProvider5.SetError(salary, "Please enter a valid salary.");
            }
            else
            {
                errorProvider5.SetError(salary, "");
            }

            if (!IsRadioButtonSelected(groupBox1))
            {
                MessageBox.Show("Please select a radio button.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(employeeType.Text!="Chef" && employeeType.Text!="Waiter")
            {
                MessageBox.Show("Please select a Employee Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb1.Text.Trim()))
            {
                errorProvider6.SetError(tb1, "Field cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb2.Text.Trim()))
            {
                errorProvider7.SetError(tb2, "Field cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb3.Text.Trim()))
            {
                errorProvider8.SetError(tb3, "Field cannot be empty.");
                return false;
            }

            return true;

        }

        private bool IsRadioButtonSelected(Guna2GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private RadioButton GetSelectedRadioButton()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton;
                }
            }
            return null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
