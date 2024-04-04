using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Guna.UI2.WinForms;

namespace SSC.UI
{
    public partial class ViewCart : Form
    {
        DataTable dataTable = new DataTable();
        Customer customer;
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        int selectedRow;

        public ViewCart()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public ViewCart(Size size, Point location, Customer c)
        {
            customer = c;
            InitializeComponent();
            InitializeUserControls();
            FillComboBox();
            this.Size = size;
            this.Location = location;
            if (menuComboBox.Items.Count > 0)
                menuComboBox.SelectedIndex = 0;
            MakeColumns();
            LoadData();
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
                    OpenForm(new Help(this.Size, this.Location, customer));
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
                panel1.BringToFront();
            }
            else
            {
                panel1.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void FillComboBox()
        {
            menuComboBox.Items.Clear();
            foreach (Product product in ProductDL.GetProducts())
            {
                menuComboBox.Items.Add(product.GetProductName());
            }
        }

        private void LoadData()
        {
            dataTable.Rows.Clear();
            foreach (OrderedProduct product in customer.GetCart())
            {
                dataTable.Rows.Add(product.GetProduct().GetProductName(), product.GetQuantity().ToString());
                cartGridView.DataSource = dataTable;
            }
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = menuComboBox.SelectedItem.ToString();
            Product selectedProductObject = ProductDL.GetProducts().FirstOrDefault(p => p.GetProductName() == selectedProduct);

            if (selectedProductObject != null)
            {
                quantitiesComboBox.Items.Clear();
                foreach (string quantity in selectedProductObject.GetAvailableQuantities())
                {
                    quantitiesComboBox.Items.Add(quantity.Trim());
                }

                if (quantitiesComboBox.Items.Count > 0)
                {
                    quantitiesComboBox.SelectedIndex = 0; 
                }
            }
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));

            cartGridView.DataSource = dataTable;
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

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                cartGridView.DataSource = dataTable;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var filteredRows = dataTable.AsEnumerable()
                                            .Where(row => row.Field<string>("ProductName")
                                                            ?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    cartGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show("No matching products found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cartGridView.DataSource = dataTable;
                }
            }
            else
            {
                cartGridView.DataSource = dataTable;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (cartGridView.SelectedRows.Count > 0)
            {
                if (CheckValidations())
                {
                    OrderedProduct p = new OrderedProduct(ProductDL.SearchProductByName(menuComboBox.Text), ExtractFirstIntegerFromString(quantitiesComboBox.Text));
                    selectedRow = cartGridView.SelectedRows[0].Index;

                    DataGridViewRow selectedDataGridViewRow = cartGridView.Rows[selectedRow]; //Select current row
                    string productName = selectedDataGridViewRow.Cells["ProductName"].Value.ToString();
                    string quantity = selectedDataGridViewRow.Cells["Quantity"].Value.ToString();

                    Product product = new Product();
                    product.SetProductName(productName);
                    customer.RemoveFromCart(product);

                    dataTable.Rows[selectedRow].SetField("ProductName", p.GetProduct().GetProductName());
                    dataTable.Rows[selectedRow].SetField("Quantity", p.GetQuantity());

                    customer.AddToCart(p.GetProduct(), p.GetQuantity());

                    cartGridView.DataSource = dataTable;
                    CustomerDL.UpdateCustomerInDatabase(customer);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (cartGridView.SelectedRows.Count > 0)
            {
                selectedRow = cartGridView.SelectedRows[0].Index;
                DataGridViewRow rowSelected = cartGridView.SelectedRows[0];
                DataGridViewCell firstCell = rowSelected.Cells[0];
                string cellValue = firstCell.Value.ToString();

                DataGridViewRow selectedDataGridViewRow = cartGridView.Rows[selectedRow]; //Select current row
                string productName = selectedDataGridViewRow.Cells["ProductName"].Value.ToString();
                string quantity = selectedDataGridViewRow.Cells["Quantity"].Value.ToString();

                Product product = new Product();
                product.SetProductName(productName);
                customer.RemoveFromCart(product);

                CustomerDL.UpdateCustomerInDatabase(customer);
                cartGridView.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CustomerOrderFood c = new CustomerOrderFood(this.Size, this.Location, customer);
            c.Show();
            this.Hide();
        }
    }
}
