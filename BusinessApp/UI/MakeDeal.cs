﻿using RMS.BL;
using SSC.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SignInSignUp.UI
{
    public partial class MakeDeal : Form
    {
        DataTable dt = new DataTable();
        Chef chef;
        List<(string name, string quantity)> items = new List<(string name, string quantity)>();

        public MakeDeal()
        {
            InitializeComponent();
        }

        public MakeDeal(Size s, Point p, Chef c)
        {
            InitializeComponent();
            this.Size=s;
            this.Location=p;
            chef = c;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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


        private void ClearTextBoxes()
        {
            price.Text = "";
            name.Text = "";
        }

        private void MakeColumns()
        {

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("DealName", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Menu", typeof(string));

            dataGridView1.DataSource = dt;
        }

        private void LoadData()
        {
            dt.Rows.Clear();
            foreach (Deal deal in ObjectHandler.GetDealDL().GetDeals())
            {
                dt.Rows.Add(deal.GetID(),deal.GetDealName(), deal.GetPrice(), deal.GetDealString());
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (menuComboBox.Text != "" && quantitiesComboBox.Text != "")
            {
                items.Add((menuComboBox.Text, quantitiesComboBox.Text));
                ShowAddedItems();
            }
        }

        private void ShowAddedItems()
        {
            addedItems.Items.Clear();
            addedItems.Visible = true;
            label6.Visible = true;
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    addedItems.Items.Add(GetString(item));
                }
            }
        }

        public string GetString((string name, string quantity) item)
        {
            StringBuilder itemString = new StringBuilder();
            itemString.Append($"{item.quantity} of {item.name}");
            return itemString.ToString();
        }

        private void makeDealBtn_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                Deal deal = new Deal(name.Text, Convert.ToDouble(price.Text), items);
                ObjectHandler.GetDealDL().SaveDeal(deal);
                ClearTextBoxes();
                LoadData();
                addedItems.Visible = false;
                label6.Visible = false;
                MessageBox.Show("Deal saved", "Success", MessageBoxButtons.OK);
            }
        }

        private bool CheckValidations()
        {
            double Price;
            if (!double.TryParse(price.Text, out Price))
            {
                errorProvider1.SetError(price, "Price must be a numeric value.");
                return false;
            }
            else
            {
                errorProvider1.SetError(price, "");
            }

            if(string.IsNullOrEmpty(name.Text))
            {
                errorProvider2.SetError(name, "There must be a name.");
                return false;
            }
            else
            {
                errorProvider2.SetError(name, "");
            }

            if (items.Count>0)
            {
                errorProvider2.SetError(name, "");
            }
            else
            {
                errorProvider2.SetError(name, "Please add some items first");
                return false;
            }

            return true;
        }

        private void MakeDeal_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if (menuComboBox.Items.Count > 0)
                menuComboBox.SelectedIndex = 0;
            MakeColumns();
            LoadData();
            addedItems.Visible = false;
            label6.Visible = false;
        }

        private void quantitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
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
    }
}