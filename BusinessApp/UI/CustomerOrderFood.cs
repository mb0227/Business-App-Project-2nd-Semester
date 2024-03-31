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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
            if(menuComboBox.Items.Count>0)
                menuComboBox.SelectedIndex = 0;
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
            string selectedProduct = menuComboBox.SelectedItem.ToString();
            Product selectedProductObject = ProductDL.GetProducts().FirstOrDefault(p => p.GetProductName() == selectedProduct);

            if (selectedProductObject != null)
            {
                //string[] quantitiesAvailable = selectedProductObject.QuantitiesAvailable.Split(',');

                quantitiesComboBox.Items.Clear();
                foreach (string quantity in selectedProductObject.GetAvailableQuantities())
                {
                    quantitiesComboBox.Items.Add(quantity.Trim());
                }

                if (quantitiesComboBox.Items.Count > 0)
                {
                    quantitiesComboBox.SelectedIndex = 0; // Select the first item by default
                }
            }
        }

        private int ExtractFirstIntegerFromString(string input)
        {
            string numberString = string.Empty;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    numberString += c;
                }
                else if (!string.IsNullOrEmpty(numberString))
                {
                    break;
                }
            }

            if (!string.IsNullOrEmpty(numberString))
            {
                return int.Parse(numberString);
            }

            return 0; 
        }

        private void ClearTextBoxes()
        {
            comments.Text = "";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                customer.AddToCart(ProductDL.GetProducts().Where(p => p.GetProductName().Equals(menuComboBox.Text)).FirstOrDefault(), ExtractFirstIntegerFromString(quantitiesComboBox.Text));
                CustomerDL.InsertOrderIntoCustomerDatabase(customer);
                ClearTextBoxes();
            }
        }

        private bool CheckValidations()
        {
            int value;
            int totalItemStock = ProductDL.GetProducts().Where(p => p.GetProductName().Equals(menuComboBox.Text)).FirstOrDefault().GetStock();
            int selectedQuantity = ExtractFirstIntegerFromString(quantitiesComboBox.Text);
            if (!int.TryParse(selectedQuantity.ToString(), out value) || value <= 0 || value >= totalItemStock)
            {
                errorProvider1.SetError(quantitiesComboBox, $"Please enter a positive quantity greater than 0 and less than {totalItemStock}");
                return false;
            }

            return true;
        }

        private void DeductOrderedProductFromStock(string productName, int quantity)
        {
            Product product = ProductDL.GetProducts().Where(p => p.GetProductName().Equals(productName)).FirstOrDefault();
            product.UpdateStock("remove", quantity);
            ProductDL.UpdateProductInDatabase(product);
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if(customer.GetCart().Count>0)
            {
                foreach (OrderedProduct item in customer.GetCart())
                {
                    DeductOrderedProductFromStock(item.GetProduct().GetProductName(), item.GetQuantity());
                }

                Order order = new Order(OrderDL.GetTotalOrders(), customer.GetCart(), Order.OrderStatus.Pending, DateTime.Now,comments.Text , customer.GetName());
                OrderDL.AddOrder(order);
                OrderDL.InsertOrderInDatabase(order);
            }
            else
            {
                MessageBox.Show("Please select an item to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            customer.GetCart().Clear();
            CustomerDL.InsertOrderIntoCustomerDatabase(customer);
        }
    }
}
