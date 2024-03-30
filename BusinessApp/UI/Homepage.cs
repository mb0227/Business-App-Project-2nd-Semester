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

        public Homepage(Size size, Point location)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(this.Size,this.Location);
            signIn.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this.Size, this.Location); 
            signUp.Show();
            this.Hide();
        }
    }
}
