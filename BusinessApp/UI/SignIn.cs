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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using Microsoft.VisualBasic;
using SSC.UI;

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


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to send an email?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Customer customer = CustomerDL.SearchCustomer(username.Text, "username");
                if (customer != null)
                {
                    SendEmail(customer,customer.GetEmail());
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
            randomCode = (rand.Next(999999)).ToString();
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
                string promptValue = Prompt.ShowDialog("Enter Prompt: ", "OTP");
                if (promptValue == randomCode)
                {
                    MessageBox.Show("Done!");
                    string newPassword = Prompt.ShowDialog("Enter new Password: ", "Change Password");

                    customer.SetPassword(newPassword);
                    CustomerDL.UpdateCustomer(customer);

                    CustomerDL.UpdateCustomerInDatabase(customer);
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
    }
}
