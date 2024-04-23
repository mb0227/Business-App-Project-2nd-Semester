using System;
using System.Drawing;
using System.Windows.Forms;

namespace RMS.UI
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        public Homepage(Size size, Point location)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this.Size, this.Location);
            signUp.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(this.Size, this.Location);
            signIn.Show();
            this.Hide();
        }
    }
}
