using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;

namespace SignInSignUp.UI
{
    public partial class ChefDashboard : Form
    {
        private Chef chef;
        public ChefDashboard()
        {
            InitializeComponent();
        }

        public ChefDashboard(Size s, Point l, Chef c)
        {
            this.Size = s;
            this.Location = l;
            chef = c;
        }

        private void ChefDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
