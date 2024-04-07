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
using RMS.DL;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace SignInSignUp.UI
{
    public partial class AddAdmin : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        public AddAdmin()
        {
            InitializeComponent();
        }

        public AddAdmin(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            //InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            if (CheckValidations())
            {
                User user = new User(email.Text, password.Text, "Admin");
                ObjectHandler.GetUserDL().SaveUser(user);
                Employee employee = new Employee(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), ObjectHandler.GetUserDL().GetUserID(email.Text));
                ObjectHandler.GetEmployeeDL().SaveEmployee(employee);
                Admin admin = new Admin(username.Text, contact.Text, Convert.ToDouble(salary.Text), dateTime.Value, GetSelectedRadioButton().Text.ToString(), ObjectHandler.GetUserDL().GetUserID(email.Text), splitText(tb1.Text), splitText(tb2.Text), ObjectHandler.GetEmployeeDL().GetEmployeeID(username.Text));
                ObjectHandler.GetAdminDL().SaveAdmin(admin);
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

            if (ObjectHandler.GetUserDL().EmailAlreadyExists(email.Text))
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

            if (ObjectHandler.GetEmployeeDL().UsernameAlreadyExists(username.Text))
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
            return true;
        }

        private List<string> splitText(string input)
        {
            string[] parts = input.Split(',');

            List<string> resultList = new List<string>();

            foreach (string part in parts)
            {
                resultList.Add(part.Trim());
            }
            return resultList;
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

    }
}
