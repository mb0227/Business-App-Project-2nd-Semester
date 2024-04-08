﻿using Guna.UI2.WinForms;
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
                if (ObjectHandler.GetProductDL().HasVariants(product.GetProductID()))
                {
                    menuComboBox.Items.Add(product.GetProductName());
                }
            }
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

        private void ClearTextBoxes()
        {
            comments.Text = "";
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Variant", typeof(string));
            dataTable.Columns.Add("Category", typeof(string));

            menuGridView.DataSource = dataTable;
        }

        private void LoadData()
        {
            dataTable.Rows.Clear();
            foreach (Product product in ObjectHandler.GetProductDL().GetProductsForCustomers())
            {
                dataTable.Rows.Add(product.GetProductName(),product.GetPrice(), product.GetQuantity(), product.GetProductCategory());
            }
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
                case "Variants":
                    menuGridView.Sort(menuGridView.Columns["Variants"], ListSortDirection.Ascending);
                    break;
                case "Category":
                    menuGridView.Sort(menuGridView.Columns["Category"], ListSortDirection.Ascending);
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
                if (customer.GetStatus() == "Regular")
                {
                    Order order = new Order(customer.GetCart(), Order.OrderStatus.Pending, DateTime.Now, comments.Text, "Cash on Delivery", customer.GetID());
                    ObjectHandler.GetOrderDL().SaveOrder(order);
                    customer.GetCart().Clear();
                    ObjectHandler.GetCustomerDL().SaveCart(customer);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            customer.GetCart().Clear();
            ObjectHandler.GetCustomerDL().SaveCart(customer);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewCart v = new ViewCart(this.Size, this.Location, customer);
            v.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (menuComboBox.Text !="" && quantitiesComboBox.Text!="")
            {
                customer.AddToCart(ObjectHandler.GetProductDL().SearchProductByName(menuComboBox.Text), quantitiesComboBox.Text);
                ObjectHandler.GetCustomerDL().SaveCart(customer);
                ClearTextBoxes();
            }                     
        }

        private void CustomerOrderFood_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if (menuComboBox.Items.Count > 0)
                menuComboBox.SelectedIndex = 0;
            sortGridView.SelectedIndex = 0;
            MakeColumns();
            LoadData();
        }
    }
}
