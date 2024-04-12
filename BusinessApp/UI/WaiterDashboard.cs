using RMS.BL;
using SSC;
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

namespace SignInSignUp.UI
{
    public partial class WaiterDashboard : Form
    {
        private Waiter waiter;
        DataTable dt = new DataTable(); 
        List<OrderedProduct> Cart = new List<OrderedProduct>();
        int selectedRow;

        public WaiterDashboard()
        {
            InitializeComponent();
        }

        public WaiterDashboard(Size s, Point l, Waiter w)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = l;
            waiter = w;
        }

        private void WaiterDashboard_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillDealComboBox();
            if (menuComboBox.Items.Count > 0)
                menuComboBox.SelectedIndex = 0;
            MakeColumns();
            LoadData();
            pickupBtn.Visible = false;
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

        private void MakeColumns()
        {
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Variant", typeof(string));
            dt.Columns.Add("Category", typeof(string));

            dataGridView1.DataSource = dt;
        }

        private void LoadData()
        {
            dt.Rows.Clear();
            foreach (Product product in ObjectHandler.GetProductDL().GetProductsForCustomers())
            {
                dt.Rows.Add(product.GetProductName(), product.GetPrice(), product.GetQuantity(), product.GetProductCategory());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (menuComboBox.Text != "" && quantitiesComboBox.Text != "")
            {
                Product product = ObjectHandler.GetProductDL().SearchProductByName(menuComboBox.Text);
                if (product != null)
                {
                    Cart.Add(new OrderedProduct(product, quantitiesComboBox.Text));
                }
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete Order?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Cart.Clear();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (Cart.Count > 0)
            {
                if (CheckValidations())
                {
                    Order order = new Order(Cart, Order.OrderStatus.Pending, DateTime.Now, comments.Text, payment.Text);
                    ObjectHandler.GetOrderDL().TakeOrder(order);
                    Cart.Clear();
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            comments.Text = "";
            payment.Text = "";
        }

        private bool CheckValidations()
        {
            comments.Text = comments.Text.Replace(",","");
            payment.Text = payment.Text.Replace(",","");
            if (payment.Text.ToLower()!="cash" && payment.Text.ToLower() != "card")
            {
                errorProvider1.SetError(payment,"Please select card or cash payment");
                return false;
            }
            else
            {
                errorProvider1.SetError(payment, "");
            }

            return true;
        }

        private void FillDealComboBox()
        {
            deals.Items.Clear();
            foreach (Deal deal in ObjectHandler.GetDealDL().GetDeals())
            {
                deals.Items.Add(deal.GetDealName());
            }
        }

        private void orderDealBtn_Click(object sender, EventArgs e)
        {
            if (deals.Text != "")
            {
                Deal deal = ObjectHandler.GetDealDL().GetDeal(deals.Text);
                ObjectHandler.GetOrderDL().OrderDeal(deal);
            }
            else
            {
                MessageBox.Show("Please select a deal first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeControlsVisibility(bool value)
        {
            foreach(Control control in panel1.Controls)
            {
                if(control != dataGridView1)
                    control.Visible = value;
            }
        }

        private void manageBtns_Click(object sender, EventArgs e) //pickupOrder
        {
            pickupBtn.Visible = false;
            ChangeControlsVisibility(true);
            dt.Columns.Clear();
            MakeColumns();
            LoadData();
        }

        private void ChangeColumns()
        {
            if (!dt.Columns.Contains("ID"))
            {
                dt.Columns.Add("ID", typeof(int));
            }

            if (!dt.Columns.Contains("Products"))
            {
                dt.Columns.Add("Products", typeof(string));
            }

            if (!dt.Columns.Contains("Comments"))
            {
                dt.Columns.Add("Comments", typeof(string));
            }
        }

        private void ChangeGridViewData(int status)
        {
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            List<Order> pendingOrders = ObjectHandler.GetOrderDL().GetOrders(status);

            foreach (Order o in pendingOrders)
            {
                dt.Rows.Add(o.GetOrderID(), o.GetProductsString(), o.GetCustomerComments());
            }
        }

        private void deliver_Click(object sender, EventArgs e) //pickup order
        {
           if (dataGridView1.SelectedRows.Count > 0)
           {
                selectedRow = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

                    if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                    {
                        int id = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);

                        ObjectHandler.GetOrderDL().UpdateOrderStatus(id, 2);
                        ChangeGridViewData(1);
                    }
                }
               
           }
           else
           {
               MessageBox.Show("Please select the row of you have prepared.");
                }
        }

        private void deliverBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

                    if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                    {
                        int id = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);

                        ObjectHandler.GetOrderDL().UpdateOrderStatus(id, 3);
                        ChangeGridViewData(2);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select the row of you have prepared.");
            }
        }

        private void pickupOrder_Click(object sender, EventArgs e)
        {
            ChangeControlsVisibility(false);
            pickupBtn.Visible = true;
            deliverBtn.Visible = false;
            dt.Columns.Clear();
            ChangeColumns();
            ChangeGridViewData(1);
        }

        private void deliverOrder_Click(object sender, EventArgs e)
        {
            ChangeControlsVisibility(false);
            pickupBtn.Visible = false;
            deliverBtn.Visible = true;
            dt.Columns.Clear();
            ChangeColumns();
            ChangeGridViewData(2);
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            ManageReservations m = new ManageReservations(this.Size, this.Location, waiter);
            m.Show();
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
