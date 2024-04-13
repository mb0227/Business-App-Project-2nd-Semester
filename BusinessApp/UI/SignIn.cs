using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Microsoft.VisualBasic;
using SSC.UI;
using RMS.BL;
using RMS.DL;
using SignInSignUp.UI;
using System.Configuration;
using Guna.UI2.WinForms;



namespace SSC
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
            if (string.IsNullOrWhiteSpace(email.Text.Trim()))
            {
                errorProvider1.SetError(email, "Username cannot be empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(email, "");
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to send an email?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ObjectHandler.GetUserDL().EmailAlreadyExists(email.Text))
                {
                    Customer customer = ObjectHandler.GetCustomerDL().ForgotPassword(ObjectHandler.GetUserDL().GetUserID(email.Text));
                    SendEmail(customer, email.Text);
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email sending cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }             
        }

        private void SendEmail(Customer customer, string to)
        {
            string from, pass, messageBody,randomCode;
            Random rand = new Random();
            randomCode = rand.Next(100000, 999999).ToString();
            MailMessage message = new MailMessage();
            from = "omerakram913@gmail.com";
            pass = "qbqi lbmi tftk nytm";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email sent successfully!");
                string promptValue = Prompt.ShowDialog("Enter OTP: ", "OTP");
                if (promptValue == randomCode)
                {
                    MessageBox.Show("Done!");
                    string newPassword = Prompt.ShowDialog("Enter new Password: ", "Change Password");
                    ObjectHandler.GetCustomerDL().UpdateCredentials(newPassword,"password",customer.GetUserID());
                }
                else
                {
                    MessageBox.Show("Wrong OTP!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (CheckValidations())
            {
                string role = ObjectHandler.GetUserDL().SearchUserForRole(email.Text, password.Text);
                if (role != "")
                {
                    int userID = ObjectHandler.GetUserDL().GetUserID(email.Text);
                    if (role == "Customer" && userID != -1) //Search customer by id
                    {
                        Customer customer = ObjectHandler.GetCustomerDL().SearchCustomerById(userID);
                        CustomerDashboard c = new CustomerDashboard(this.Size, this.Location, customer);
                        c.Show();
                        this.Hide();
                    }
                    else if (role == "Chef" && userID != -1)
                    {
                        Chef chef = ObjectHandler.GetEmployeeDL().SearchChefById(userID);
                        ChefDashboard c = new ChefDashboard(this.Size, this.Location, chef);
                        c.Show();
                        this.Hide();
                    }
                    else if (role == "Waiter" && userID != -1)
                    {
                        Waiter waiter = ObjectHandler.GetEmployeeDL().SearchWaiterById(userID);
                        WaiterDashboard w = new WaiterDashboard(this.Size, this.Location, waiter);
                        w.Show();
                        this.Hide();
                    }
                    else if (role == "Admin" && userID != -1)
                    {
                        Admin admin = ObjectHandler.GetEmployeeDL().SearchAdminById(userID);
                        if (admin != null)
                        {
                            AdminDashboard a = new AdminDashboard(this.Size, this.Location, admin);
                            a.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage(this.Size, this.Location);
            home.Show();
            this.Hide();
        }
    }
}
