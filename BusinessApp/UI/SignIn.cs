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
        private Size savedSize;
        public SignIn()
        {
            InitializeComponent();
        }

        public SignIn(Size size)
        {
            InitializeComponent();
            this.Size = size; 
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
            Homepage home = new Homepage(savedSize);
            home.FormClosing += SignIn_FormClosing;
            home.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private Size GetCurrentScreenSize()
        {
            return Screen.FromControl(this).WorkingArea.Size;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerPage = new CustomerDashboard(savedSize);
            customerPage.FormClosing += SignIn_FormClosing;
            customerPage.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forgotPasswordButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            savedSize = ((Form)sender).Size;
        }
    }
}
