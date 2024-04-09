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
    public partial class ManageOrders : Form
    {
        private Chef chef;
        public ManageOrders()
        {
            InitializeComponent();
        }

        public ManageOrders(Size s, Point p, Chef c)
        {
            this.Size = s;
            this.Location = p;
            chef = c;
        }
    }
}
