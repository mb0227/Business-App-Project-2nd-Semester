using RMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class WaiterDashboard : Form
    {
        private Waiter waiter;
        public WaiterDashboard()
        {
            InitializeComponent();
        }

        public WaiterDashboard(Size s, Point l, Waiter w)
        {
            this.Size = s;
            this.Location = l;
            waiter = w;
        }
    }
}
