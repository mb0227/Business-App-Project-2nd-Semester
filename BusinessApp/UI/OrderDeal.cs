using RMS.BL;
using SSC.UI;
using SSC;
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
    public partial class OrderDeal : Form
    {
        private Customer customer;
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        DataTable dt = new DataTable();
        int selectedRow;

        public OrderDeal()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        private void OrderDeal_Load(object sender, EventArgs e)
        {
            MakeColumns();
            LoadData();
        }

        public OrderDeal(Size size, Point location, Customer c)
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
                    OpenForm(new SSC.UI.Help(this.Size, this.Location, customer));
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

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    selectedRow = dataGridView1.SelectedRows[0].Index;
                    if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["DealName"].Value != null)
                        {
                            int id = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);
                            Deal deal = ObjectHandler.GetDealDL().GetDeal(id);
                            ObjectHandler.GetOrderDL().OrderDeal(deal, customer.GetID());
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
                MessageBox.Show("Please select a row to order");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomerOrderFood c = new CustomerOrderFood(this.Size, this.Location, customer);
            c.Show();
            this.Hide();
        }
    }
}
