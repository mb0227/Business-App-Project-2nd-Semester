using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class CustomerOrderFood : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        private Customer customer;
        public CustomerOrderFood()
        {
            InitializeComponent();
            InitializeUserControls();
            ProductDL.ReadProductsFromDatabase();
            FillComboBox();
        }

        public CustomerOrderFood(Size size, Point location, Customer c)
        {
            customer = c;
            InitializeComponent();
            InitializeUserControls();
            FillComboBox();
            this.Size = size;
            this.Location = location;
            MessageBox.Show(customer.GetName());
        }

        public CustomerOrderFood(CustomerHeader header, CustomerNavBar navBar)
        {
            InitializeComponent();
            this.cHeader = header;
            this.cNavBar = navBar;
        }

        private void CustomerOrderFood_Load(object sender, EventArgs e)
        {
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;

            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom; 
            cNavBar.Width = 200;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
        }


        private void CustomerNavBar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new CustomerDashboard(this.Size, this.Location, customer));
                    break;
                case "orderFood":
                    OpenForm(new CustomerOrderFood(this.Size, this.Location, customer));
                    break;
                case "bookTable":
                    OpenForm(new CustomerBookTable(this.Size, this.Location, customer));
                    break;
                case "feedback":
                    OpenForm(new CustomerFeedback(this.Size, this.Location, customer));
                    break;
                case "settings":
                    OpenForm(new Settings(this.Size, this.Location, customer));
                    break;
                //case "help":
                //    OpenForm(new Help(this.Size, this.Location, customer));
                //    break;
                default:
                    break;
            }
        }

        private void OpenForm(Form form)
        {
            form.Size = this.Size;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void FillComboBox()
        {
            menuComboBox.Items.Clear(); 
            foreach (Product product in ProductDL.GetProducts())
            {
                menuComboBox.Items.Add(product.GetProductName()); 
            }
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {

            }
        }

        private bool CheckValidations()
        {
            int value;
            int totalItemStock = ProductDL.GetProducts().Where(p => p.GetProductName().Equals(menuComboBox.Text)).FirstOrDefault().GetStock();
            if (!int.TryParse(textBox1.Text, out value) || value <= 0 || value >= totalItemStock)
            {
                errorProvider1.SetError(textBox1, $"Please enter a positive integer greater than 0 and less than {totalItemStock}");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            return true;
        }
    }
}
