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

namespace SignInSignUp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public SignUp(Size size)
        {
            InitializeComponent();
            this.Size = size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(CheckValidations())
            //{
            //    User newUser = new User(username.Text, textBox3.Text, textBox2.Text);
            //    if (UserDL.AddUser(newUser))
            //    {
            //        MessageBox.Show("User added successfully.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("User not added.");
            //    }
            //}
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

            //if (string.IsNullOrWhiteSpace(textBox3.Text.Trim()))
            //{
            //    errorProvider2.SetError(textBox3, "Password cannot be empty.");
            //    return false;
            //}
            //else
            //{
            //    errorProvider2.SetError(textBox3, "");
            //}

            string user1 = "admin";
            string user2 = "customer";
            if ((!Regex.IsMatch(textBox2.Text, user1)) && (!Regex.IsMatch(textBox2.Text, user2)))
            {
                errorProvider3.SetError(textBox2, "Role not correct.");
                return false;
            }
            else
            {
                errorProvider3.SetError(textBox2, "");
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private Size GetCurrentScreenSize()
        {
            return Screen.FromControl(this).WorkingArea.Size;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
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

        private void pictureBox10_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Homepage f = new Homepage(GetCurrentScreenSize());
            f.Show();
            this.Hide();
        }
    }
}
