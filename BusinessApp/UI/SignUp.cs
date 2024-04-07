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
using RMS.BL;
using RMS.DL;
using SSC.UI;

namespace SSC
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public SignUp(Size size,Point location)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
        }

        private bool CheckValidations()
        {
            if (string.IsNullOrWhiteSpace(username.Text.Trim()))
            {
                errorProvider1.SetError(username, "Username cannot be empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(username, "");
            }

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(email.Text, pattern))
            {
                errorProvider2.SetError(email, "Please enter a valid email address.");
                return false;
            }
            else
            {
                errorProvider2.SetError(email, "");
            }

            string contactPattern = @"^0\d{10}$";
            if (!Regex.IsMatch(phoneNo.Text, contactPattern))
            {
                errorProvider3.SetError(phoneNo, "Please enter a valid phone number.");
                return false;
            }
            else
            {
                errorProvider3.SetError(phoneNo, "");
            }

            if (!IsRadioButtonSelected(groupBox1))
            {
                MessageBox.Show("Please select a radio button.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(password.Text.Trim()))
            {
                errorProvider4.SetError(password, "Password cannot be empty.");
                return false;
            }
            else
            {
                errorProvider4.SetError(password, "");
            }

            if (!password.Text.Trim().Equals(password2.Text.Trim()))
            {
                errorProvider4.SetError(password, "Password do not match.");
                return false;
            }

            // Check if email already exists
            if (ObjectHandler.GetUserDL().EmailAlreadyExists(email.Text))
            {
                errorProvider2.SetError(email, "Email already exists.");
                return false;
            }
            else
            {
                errorProvider2.SetError(email, "");
            }

            if (ObjectHandler.GetCustomerDL().UsernameAlreadyExists(username.Text))
            {
                errorProvider1.SetError(username, "Username already exists.");
                return false;
            }
            else
            {
                errorProvider2.SetError(username, "");
            }

            return true;
        }

        private bool IsRadioButtonSelected(GroupBox groupBox)
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


        private void Home_Click_1(object sender, EventArgs e)
        {
            Homepage home = new Homepage(this.Size, this.Location);
            home.Show();
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                User user = new User(email.Text, password.Text, "Customer");
                ObjectHandler.GetUserDL().SaveUser(user);
                Customer customer = new Customer(username.Text, phoneNo.Text, "Regular", GetSelectedRadioButton().Text.ToString());
                customer.SetUserID(ObjectHandler.GetUserDL().GetUserID(email.Text));
                ObjectHandler.GetCustomerDL().SaveCustomer(customer);
                Regular regular = new Regular(username.Text, phoneNo.Text, "Regular", GetSelectedRadioButton().Text.ToString(), 0, ObjectHandler.GetCustomerDL().GetCustomerID(customer.GetUsername()));
                ObjectHandler.GetRegularDL().StoreRegularInDB(regular);
                MessageBox.Show("Signed Up successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else
            //{
            //    MessageBox.Show("Invalid User.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            //}
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

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            if (!password.UseSystemPasswordChar)
            {
                password.UseSystemPasswordChar = true;
            }
            else if (password.UseSystemPasswordChar)
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            if (!password2.UseSystemPasswordChar)
            {
                password2.UseSystemPasswordChar = true;
            }
            else if (password2.UseSystemPasswordChar)
            {
                password2.UseSystemPasswordChar = false;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
