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

        public SignUp(Size size,Point location)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
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

        private void SignUp_Leave(object sender, EventArgs e)
        {

        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            Homepage home = new Homepage(this.Size, this.Location);
            home.Show();
            this.Hide();
        }
    }
}
