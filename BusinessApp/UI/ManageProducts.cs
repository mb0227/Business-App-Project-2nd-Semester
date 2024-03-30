﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SignInSignUp.UI
{
    public partial class ManageProducts : Form
    {
        DataTable dataTable = new DataTable();
        int selectedRow;
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        public ManageProducts()
        {
            InitializeComponent();
            InitializeUserControls();
            if(comboBox1.Items.Count>0)
                comboBox1.SelectedIndex = 0;
            ProductDL.ReadProductsFromDatabase();
            MakeColumns();
            name.TextChanged += Name_TextChanged;
            LoadData();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {            
        }

        private void MakeColumns()
        {
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("ProductCategory", typeof(string));
            dataTable.Columns.Add("ProductDescription", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Stock", typeof(int));

            dataGridView1.DataSource = dataTable;
        }

        private void InitializeUserControls()
        {
            aHeader = new CustomerHeader();
            Controls.Add(aHeader);
            aHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            aHeader.Top = 0;
            aHeader.Left = 0;
            aHeader.Width = this.Width;

            aNavbar = new Navbar();
            Controls.Add(aNavbar);
            aNavbar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            aNavbar.Left = 0;
            aNavbar.Top = aHeader.Bottom;
            aNavbar.Width = 200;
            aNavbar.Height = this.ClientSize.Height - aHeader.Bottom;

            //aNavbar.NavigationRequested += CustomerNavBar_NavigationRequested;
        }

        private void LoadData()
        {
            dataTable.Rows.Clear();
            foreach (Product product in ProductDL.GetProducts())
            {
                dataTable.Rows.Add(product.GetProductName(), product.GetProductCategory(), product.GetProductDescription(), product.GetPrice(), product.GetStock());
                dataGridView1.DataSource = dataTable;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (CheckValidations())
            {
                try
                {
                    Product newProduct = new Product(name.Text, description.Text, comboBox1.Text, int.Parse(price.Text), int.Parse(stock.Text));
                    ProductDL.AddProduct(newProduct);
                    ProductDL.InsertProductsIntoDatabase(newProduct);
                    ClearTextBoxes();
                    LoadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CheckValidations()
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                errorProvider1.SetError(name, "Product name cannot be empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(name, "");
            }

            if (string.IsNullOrWhiteSpace(description.Text.Trim()))
            {
                errorProvider2.SetError(description, "Product Description cannot be empty.");
                return false;
            }
            else
            {
                errorProvider2.SetError(description, "");
            }

            int value;
            if (!int.TryParse(price.Text, out value) || value <= 0 || value >= 50000)
            {
                errorProvider3.SetError(price, "Please enter a positive integer greater than 0 and less than 50,000.");
                return false;
            }
            else
            {
                errorProvider3.SetError(price, "");
            }

            if (!int.TryParse(stock.Text, out value) || value <= 0 || value >= 10000)
            {
                errorProvider4.SetError(stock, "Please enter a positive integer greater than 0 and less than 10,000.");
                return false;
            }
            else
            {
                errorProvider4.SetError(stock, "");
            }

            if (comboBox1.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void ClearTextBoxes()
        {
            name.Text = "";
            description.Text = "";
            price.Text = "";
            stock.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (CheckValidations())
                {
                    Product p = new Product(name.Text, description.Text, comboBox1.Text, int.Parse(price.Text), int.Parse(stock.Text));
                    selectedRow = dataGridView1.SelectedRows[0].Index;
                    dataTable.Rows[selectedRow].SetField("ProductName", p.GetProductName());
                    dataTable.Rows[selectedRow].SetField("ProductCategory", p.GetProductCategory());
                    dataTable.Rows[selectedRow].SetField("ProductDescription", p.GetProductDescription());
                    dataTable.Rows[selectedRow].SetField("Price", p.GetPrice());
                    dataTable.Rows[selectedRow].SetField("Stock", p.GetStock());
                    dataGridView1.DataSource = dataTable;
                    ProductDL.UpdateProductInDatabase(p);
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow rowSelected = dataGridView1.SelectedRows[0];
                DataGridViewCell firstCell = rowSelected.Cells[0]; 
                string cellValue = firstCell.Value.ToString();
                ProductDL.DeleteProductFromDatabase(ProductDL.SearchProductByName(cellValue));
                dataGridView1.Rows.RemoveAt(selectedRow);
                selectedRow = -1;
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var filteredRows = dataTable.AsEnumerable()
                                            .Where(row => row.Field<string>("ProductName")
                                                            ?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                                            .CopyToDataTable();

                if (filteredRows.Rows.Count > 0)
                {
                    dataGridView1.DataSource = filteredRows;
                }
                else
                {
                    MessageBox.Show("No matching products found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
