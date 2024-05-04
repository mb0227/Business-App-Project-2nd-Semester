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
using System.Xml.Linq;
using RMS.Utility;
using Guna.UI2.WinForms;
using RMS.BL;
using RMS.DL;

namespace RMS.UI
{
    public partial class ViewCart : Form
    {
        DataTable dataTable = new DataTable();
        Customer customer;
        private CustomerHeader cHeader;
        private CustomerNavbar cNavBar;
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
            this.Size = size;
            this.Location = location;            
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

            cNavBar = new CustomerNavbar();
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
            foreach (Product product in ObjectHandler.GetProductDL().GetProductsForCustomers())
            {
                if (ObjectHandler.GetProductDL().HasVariants(product.GetProductID()))
                {
                    menuComboBox.Items.Add(product.GetProductName());
                }
            }
        }

        private void LoadData()
        {
            dataTable.Rows.Clear();
            foreach (OrderedProduct product in customer.GetCart())
            {
                dataTable.Rows.Add(product.GetProduct().GetProductName(), product.GetQuantity());
            }
            cartGridView.DataSource = dataTable;
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = menuComboBox.SelectedItem.ToString();
            Product selectedProductObject = ObjectHandler.GetProductDL().SearchProductByName(selectedProduct);

            if (selectedProductObject != null)
            {
                quantitiesComboBox.Items.Clear();
                foreach (string quantity in ObjectHandler.GetProductDL().GetQuantities(selectedProductObject.GetProductID()))
                {
                    quantitiesComboBox.Items.Add(quantity);
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
            dataTable.Columns.Add("Quantity", typeof(string));

            cartGridView.DataSource = dataTable;
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
                if (menuComboBox.Text != "" && quantitiesComboBox.Text != "")
                {
                    OrderedProduct p = new OrderedProduct(ObjectHandler.GetProductDL().SearchProductByName(menuComboBox.Text), quantitiesComboBox.Text);
                    selectedRow = cartGridView.SelectedRows[0].Index;

                    if (cartGridView != null && selectedRow >= 0 && selectedRow < cartGridView.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = cartGridView.Rows[selectedRow];

                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ProductName"].Value != null)
                        {
                            string productName = selectedDataGridViewRow.Cells["ProductName"].Value.ToString();

                            Product product = new Product();
                            product.SetProductName(productName);
                            customer.RemoveFromCart(product);

                            dataTable.Rows[selectedRow].SetField("ProductName", p.GetProduct().GetProductName());
                            dataTable.Rows[selectedRow].SetField("Quantity", p.GetQuantity());

                            customer.AddToCart(p.GetProduct(), p.GetQuantity());
                            cartGridView.DataSource = dataTable;
                            ObjectHandler.GetCustomerDL().UpdateCart(customer);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (cartGridView.SelectedRows.Count > 0)
            {
                try
                {
                    selectedRow = cartGridView.SelectedRows[0].Index;

                    if (cartGridView != null && selectedRow >= 0 && selectedRow < cartGridView.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = cartGridView.Rows[selectedRow];

                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ProductName"].Value != null)
                        {
                            string productName = selectedDataGridViewRow.Cells["ProductName"].Value.ToString();

                            Product product = new Product();
                            product.SetProductName(productName);
                            customer.RemoveFromCart(product);

                            ObjectHandler.GetCustomerDL().UpdateCart(customer);
                            cartGridView.Rows.RemoveAt(selectedRow);
                            selectedRow = -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CustomerOrderFood c = new CustomerOrderFood(this.Size, this.Location, customer);
            c.Show();
            this.Hide();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if (menuComboBox.Items.Count > 0)
                menuComboBox.SelectedIndex = 0;
            MakeColumns();
            LoadData();
        }
    }
}
