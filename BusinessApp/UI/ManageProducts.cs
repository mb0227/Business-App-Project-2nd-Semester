using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using RMS.BL;
using RMS.DL;
using SignInSignUp.UI;

namespace SSC.UI
{
    public partial class ManageProducts : Form
    {
        DataTable dt = new DataTable();
        Chef chef;

        public ManageProducts()
        {
            InitializeComponent();
        }

        public ManageProducts(Size s, Point l, Chef c)
        {
            this.Size = s;
            this.Location = l;
            chef = c;    
        }

        private bool CheckValidations()
        {
            name.Text = name.Text.Replace(",", "");   
            description.Text = description.Text.Replace(",", "");   
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                errorProvider1.SetError(name, "Product name cannot be empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(name, "");
            }

            if(ObjectHandler.GetProductDL().ProductExists(name.Text))
            {
                errorProvider1.SetError(name, "Product name already exists");
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
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (CheckValidations())
            {
                try
                {
                    Product newProduct = new Product(name.Text, description.Text, comboBox1.Text, 0);
                    ObjectHandler.GetProductDL().SaveProduct(newProduct);
                    ClearTextBoxes();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (CheckValidations())
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                        DialogResult result = MessageBox.Show("Do you want to launch product?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes && ObjectHandler.GetProductDL().HasVariants(id))
                        {
                            ObjectHandler.GetProductDL().UpdateProduct(new Product(id, name.Text, description.Text, comboBox1.Text, 1));
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but add some variants first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ObjectHandler.GetProductDL().UpdateProduct(new Product(id, name.Text, description.Text, comboBox1.Text, 0));
                        }
                        LoadData();
                        ClearTextBoxes();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    ObjectHandler.GetProductDL().DeleteProduct(Convert.ToInt32(id));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var filteredRows = dt.AsEnumerable()
                                     .Where(row => row.Field<string>("Name")
                                                     ?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    DataTable filteredDataTable = dt.Clone();
                    foreach (DataRow row in filteredRows)
                    {
                        filteredDataTable.ImportRow(row);
                    }
                    dataGridView1.DataSource = filteredDataTable;
                }
                else
                {
                    MessageBox.Show("No matching products found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }



        private void manageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders o = new ManageOrders(this.Size, this.Location, chef);
            o.Show();
            this.Hide();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            name.TextChanged += Name_TextChanged;

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Available", typeof(int));

            dataGridView1.DataSource = dt;

            LoadData();
        }

        private void ClearTable()
        {
            dt.Rows.Clear();
        }

        private void LoadData()
        {
            ClearTable();
            foreach (Product p in ObjectHandler.GetProductDL().GetProducts()) //MAKE SURE IF USER EDITS IT HAS VARIANT(COUNT)
            {
                dt.Rows.Add(p.GetProductID(), p.GetProductName(), p.GetProductCategory(), p.GetProductDescription(), p.GetAvailable());
            }
            dataGridView1.DataSource = dt;
        }

        private void makeDealBtn_Click(object sender, EventArgs e)
        {
            MakeDeal d = new MakeDeal(this.Size, this.Location, chef);
            d.Show();
            this.Hide();
        }

        private void manageBtns_Click(object sender, EventArgs e)
        {
            ManageProducts p = new ManageProducts(this.Size, this.Location, chef);
            p.Show();
            this.Hide();
        }
    }
}
