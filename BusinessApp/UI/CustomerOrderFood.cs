using Guna.UI2.WinForms;
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
using RMS.BL;
using RMS.DL;

namespace SSC.UI
{
    public partial class CustomerOrderFood : Form
    {
        DataTable dataTable = new DataTable();
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        private Customer customer;

        public CustomerOrderFood()
        {
            InitializeComponent();
            InitializeUserControls();
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
            MakeColumns();
            LoadData();
            sortGridView.SelectedIndex = 0;
        }

        public CustomerOrderFood(CustomerHeader header, CustomerNavBar navBar)
        {
            InitializeComponent();
            this.cHeader = header;
            this.cNavBar = navBar;
        }

        private void InitializeUserControls()
        {
            cHeader = new CustomerHeader();
            Controls.Add(cHeader);
            cHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            cHeader.Top = 0;
            cHeader.Left = 0;
            cHeader.Width = this.Width;
            cHeader.BringToFront();

            cNavBar = new CustomerNavBar();
            Controls.Add(cNavBar);
            cNavBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            cNavBar.Left = 0;
            cNavBar.Top = cHeader.Bottom;
            cNavBar.Width = 147;
            cNavBar.Height = this.ClientSize.Height - cHeader.Bottom;
            cNavBar.BringToFront();

            cNavBar.NavigationRequested += CustomerNavBar_NavigationRequested;
            cNavBar.NavBarCollapsed += CNavBar_NavBarCollapsed;
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
                case "help":
                    OpenForm(new UI.Help(this.Size, this.Location, customer));
                    break;
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

        private void CNavBar_NavBarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel3.BringToFront();
            }
            else
            {
                panel3.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void FillComboBox()
        {
            menuComboBox.Items.Clear(); 
            foreach (Product product in ObjectHandler.GetProductDL().GetProducts())
            {
                menuComboBox.Items.Add(product.GetProductName()); 
            }
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = menuComboBox.SelectedItem.ToString();
            Product selectedProductObject = ObjectHandler.GetProductDL().GetProducts().FirstOrDefault(p => p.GetProductName() == selectedProduct);

            if (selectedProductObject != null)
            {
                quantitiesComboBox.Items.Clear();
                //foreach (string quantity in selectedProductObject.GetAvailableQuantities())
                //{
                //    quantitiesComboBox.Items.Add(quantity.Trim());
                //}

                //if (quantitiesComboBox.Items.Count > 0)
                //{
                //    quantitiesComboBox.SelectedIndex = 0; 
                //}
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

        //private bool CheckValidations()
        //{
        //    int value;
        //    int totalItemStock = ProductDBDL.GetProducts().Where(p => p.GetProductName().Equals(menuComboBox.Text)).FirstOrDefault().GetStock();
        //    int selectedQuantity = ExtractFirstIntegerFromString(quantitiesComboBox.Text);
        //    if (!int.TryParse(selectedQuantity.ToString(), out value) || value <= 0 || value >= totalItemStock)
        //    {
        //        errorProvider1.SetError(quantitiesComboBox, $"Please enter a positive quantity greater than 0 and less than {totalItemStock}");
        //        return false;
        //    }

        //    return true;
        //}

        private void MakeColumns()
        {
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Stock", typeof(int));

            menuGridView.DataSource = dataTable;
        }

        private void LoadData()
        {
            //dataTable.Rows.Clear();
            //foreach (Product product in ProductDBDL.GetProducts())
            //{
            //    dataTable.Rows.Add(product.GetProductName(), product.GetPrice(),product.GetStock());
            //    menuGridView.DataSource = dataTable;
            //}
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                menuGridView.DataSource = dataTable;
            }
        }

        private void sortGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortBy = sortGridView.SelectedItem.ToString();
            SortDataGridView(sortBy);
        }

        private void SortDataGridView(string sortBy)
        {
            switch (sortBy)
            {
                case "ProductName":
                    menuGridView.Sort(menuGridView.Columns["ProductName"], ListSortDirection.Ascending);
                    break;
                case "Price":
                    menuGridView.Sort(menuGridView.Columns["Price"], ListSortDirection.Ascending);
                    break;
                case "Stock":
                    menuGridView.Sort(menuGridView.Columns["Stock"], ListSortDirection.Ascending);
                    break;
                default:
                    break;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var filteredRows = dataTable.AsEnumerable()
                                            .Where(row => row.Field<string>("ProductName")
                                                            ?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    menuGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show("No matching products found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menuGridView.DataSource = dataTable;
                }
            }
            else
            {
                menuGridView.DataSource = dataTable;
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (customer.GetCart().Count > 0)
            {
                foreach (OrderedProduct item in customer.GetCart())
                {
                }

                Order order = new Order(OrderDBDL.GetTotalOrders(), customer.GetCart(), Order.OrderStatus.Pending, DateTime.Now, comments.Text, customer.GetUsername());
                OrderDBDL.AddOrder(order);
                OrderDBDL.InsertOrderInDatabase(order);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select an item to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            customer.GetCart().Clear();
            CustomerDBDL.InsertOrderIntoCustomerDatabase(customer);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCart v = new ViewCart(this.Size, this.Location, customer);
            v.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //if (CheckValidations())
            //{
                customer.AddToCart(ObjectHandler.GetProductDL().GetProducts().Where(p => p.GetProductName().Equals(menuComboBox.Text)).FirstOrDefault(), ExtractFirstIntegerFromString(quantitiesComboBox.Text));
                CustomerDBDL.InsertOrderIntoCustomerDatabase(customer);
                ClearTextBoxes();
            //}
        }
    }
}
