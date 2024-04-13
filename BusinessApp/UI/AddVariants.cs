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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using SSC.UI;
using SSC;

namespace RMS.UI
{
    public partial class AddVariants : Form
    {
        Chef chef;

        public AddVariants()
        {
            InitializeComponent();            
        }

        private void AddVariants_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            FillComboBox();
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void ClearTextBoxes()
        {
            quantityText.Text = "";
            priceTB.Text = "";
        }

        private void FillComboBox()
        {
            foreach(Product p in ObjectHandler.GetProductDL().GetProducts())
            {
                comboBox1.Items.Add(p.GetProductName());
            }
        }

        public AddVariants(Size s, Point l, Chef c)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = l;
            chef = c;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                int id = ObjectHandler.GetProductDL().GetProductID(comboBox1.Text);
                if(id != -1)
                {
                    ObjectHandler.GetProductDL().SaveVariant(new ProductVariant(quantityText.Text, double.Parse(priceTB.Text)), id);
                    ClearTextBoxes();
                }
            }
        }
        
        private bool CheckValidations()
        {
            quantityText.Text = quantityText.Text.Replace(",", "");
            double p;
            if (!double.TryParse(priceTB.Text, out p) || p <= 0 || p > 9999999.99)
            {
                errorProvider1.SetError(priceTB, "Please enter a valid positive price.");
                return false;
            }
            else
            {
                errorProvider1.SetError(priceTB, "");
            }

            if (string.IsNullOrEmpty(quantityText.Text))
            {
                errorProvider2.SetError(quantityText, "Quantity cannot be empty.");
                return false;
            }
            else
            {
                errorProvider2.SetError(quantityText, "");
            }

            return true;
        }

        private void manageBtns_Click(object sender, EventArgs e)
        {
            ManageProducts p = new ManageProducts(this.Size, this.Location, chef);
            p.Show();
            this.Hide();
        }

        private void manageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders o = new ManageOrders(this.Size, this.Location, chef);
            o.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Homepage h = new Homepage(this.Size, this.Location);
                h.Show();
                this.Hide();
            }
        }
    }
}
