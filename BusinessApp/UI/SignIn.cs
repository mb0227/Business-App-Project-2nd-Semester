using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SignInSignUp
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public SignIn(Size size, Point location)
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

            if (string.IsNullOrWhiteSpace(password.Text.Trim()))
            {
                errorProvider2.SetError(password, "Password cannot be empty.");
                return false;
            }
            else
            {
                errorProvider2.SetError(password, "");
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage(this.Size,this.Location);
            home.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            if(CustomerDL.SearchCustomerForSignUp(username.Text, password.Text) != null)
            {
                CustomerDashboard customerPage = new CustomerDashboard(this.Size, this.Location, CustomerDL.SearchCustomerForSignUp(username.Text, password.Text));
                customerPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }


        private void forgotPasswordButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
        }
    }
}
