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

        public SignIn(Size size)
        {
            InitializeComponent();
            this.Size = size; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                if(UserDL.IsUser(username.Text,password.Text))
                {
                    MessageBox.Show("User is valid.");
                }
                else
                {
                    MessageBox.Show("User is invalid.");
                }
            }
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
            Homepage f = new Homepage(GetCurrentScreenSize());
            f.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private Size GetCurrentScreenSize()
        {
            return Screen.FromControl(this).WorkingArea.Size;
        }
    }
}
