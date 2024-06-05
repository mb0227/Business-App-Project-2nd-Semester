using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.Utility;
using System.Data.SqlClient;

namespace RMS.UI
{
    public partial class ManageOrders : Form
    {
        private Chef chef;
        int selectedRow;
        DataTable dt=new DataTable();
        public ManageOrders()
        {
            InitializeComponent();
        }

        public ManageOrders(Size s, Point p, Chef c)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = p;
            chef = c;
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            MakeColumns();
            LoadData();
        }

        private void MakeColumns()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Products", typeof(string));
            dt.Columns.Add("Comments", typeof(string));

            dgv.DataSource = dt;
        }

        private void ClearData()
        {
            dt.Rows.Clear();
        }

        private void LoadData()
        {
            List<Order> pendingOrders = ObjectHandler.GetOrderDL().GetOrders(0);
            foreach (Order o in pendingOrders)
            {
                dt.Rows.Add(o.GetOrderID(), UtilityFunctions.GetDealString(o.GetProductsString()), o.GetCustomerComments());
            }
        }

        private void notifyBtn_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                try
                {
                    selectedRow = dgv.SelectedRows[0].Index;

                    if (dgv != null && selectedRow >= 0 && selectedRow < dgv.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = dgv.Rows[selectedRow];

                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                        {
                            int id = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);

                            ObjectHandler.GetOrderDL().UpdateOrderStatus(id, 1);
                            ClearData();
                            LoadData();
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
                MessageBox.Show("Please select the row of you have prepared.");
            }
        }

        private void manageBtns_Click(object sender, EventArgs e)
        {
            ManageProducts p = new ManageProducts(this.Size, this.Location, chef);
            p.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
