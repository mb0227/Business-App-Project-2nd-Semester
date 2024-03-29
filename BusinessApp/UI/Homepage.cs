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
       
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(GetCurrentScreenSize());
            signIn.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(GetCurrentScreenSize());
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
    }
}
