using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public partial class Homepage : Form
    {
        private Size savedSize; 
        public Homepage()
        {
            InitializeComponent();
        }

        public Homepage(Size size)
        {
            InitializeComponent();
            this.Size = size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
            
        private void signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(savedSize); // Pass the saved size
            signIn.FormClosing += Homepage_FormClosing; // Subscribe to FormClosing event
            signIn.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(savedSize); // Pass the saved size
            signUp.FormClosing += Homepage_FormClosing; 
            signUp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private Size GetCurrentScreenSize()
        {
            return Screen.FromControl(this).WorkingArea.Size;
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            savedSize = ((Form)sender).Size;
        }
    }
}
