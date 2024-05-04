using System;
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
using RMS.Utility;


namespace RMS.UI
{
    public partial class ManageCustomers : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        DataTable dt = new DataTable();
        private int selectedRow ;
        public ManageCustomers()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public ManageCustomers(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            Admin = admin;
        }

        private void InitializeUserControls()
        {
            aHeader = new CustomerHeader();
            Controls.Add(aHeader);
            aHeader.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            aHeader.Top = 0;
            aHeader.Left = 0;
            aHeader.Width = this.Width;
            aHeader.BringToFront();

            aNavbar = new Navbar();
            Controls.Add(aNavbar);
            aNavbar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            aNavbar.Left = 0;
            aNavbar.Top = aHeader.Bottom;
            aNavbar.Width = 178;
            aNavbar.Height = this.ClientSize.Height - aHeader.Bottom;
            aNavbar.BringToFront();

            aNavbar.NavigationRequested += navbar_NavigationRequested;
            aNavbar.NavBarCollapsed += aNavbar_NavbarCollapsed;
        }

        private void navbar_NavigationRequested(object sender, string formName)
        {
            switch (formName)
            {
                case "dashboard":
                    OpenForm(new AdminDashboard(this.Size, this.Location, Admin));
                    break;
                case "manageEmployees":
                    OpenForm(new ManageEmployees(this.Size, this.Location, Admin));
                    break;
                case "sendNotifications":
                    OpenForm(new SendNotifications(this.Size, this.Location, Admin));
                    break;
                case "settings":
                    OpenForm(new AdminSettings(this.Size, this.Location, Admin));
                    break;
                case "addAdmin":
                    OpenForm(new AddAdmin(this.Size, this.Location, Admin));
                    break;
                case "manageTables":
                    OpenForm(new ManageTables(this.Size, this.Location, Admin));
                    break;
                case "feedback":
                    OpenForm(new ManageFeedback(this.Size, this.Location, Admin));
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

        private void aNavbar_NavbarCollapsed(object sender, bool collapsed)
        {
            if (collapsed)
            {
                panel4.BringToFront();
                panel1.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                panel1.SendToBack();
                aNavbar.BringToFront();
            }
        }
        private void menuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var filteredRows = dt.AsEnumerable()
                                     .Where(row => row.Field<string>("Username")
                                                     ?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    dataGridView1.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show("No matching customers found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Cart", typeof(string));
            dt.Columns.Add("UserID", typeof(int));

            dataGridView1.DataSource = dt;
            foreach (Customer c in ObjectHandler.GetCustomerDL().GetCustomers())
            {
                dt.Rows.Add(c.GetID(), c.GetUsername(), c.GetContact(), c.GetStatus(), c.GetGender(), UtilityFunctions.GetCartString(c.GetCart()), c.GetUserID());
            }
        }

        private void LoadData()
        {
            foreach (Customer c in ObjectHandler.GetCustomerDL().GetCustomers())
            {
                dt.Rows.Add(c.GetID(), c.GetUsername(), c.GetContact(), c.GetStatus(), c.GetGender(), UtilityFunctions.GetCartString(c.GetCart()), c.GetUserID());
            }
        }

        private void viewRegBtn_Click(object sender, EventArgs e)
        {
            ClearGridView();

            dt.Columns.Add("RegularID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("LoyaltyPoints", typeof(int));
            dt.Columns.Add("CustomerID", typeof(int));

            foreach (Regular r in ObjectHandler.GetRegularDL().GetRegulars())
            {
                dt.Rows.Add(r.GetRegularID(), r.GetUsername(), r.GetLoyaltyPoints(), r.GetCustomerID());
            }
            dataGridView1.DataSource = dt;

            backbtn.Visible = true;
            deleteBtn.Visible = false;
        }

        private void viewVIPBtn_Click(object sender, EventArgs e)
        {
            ClearGridView();

            dt.Columns.Add("RegularID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("MembershipLevel", typeof(string));
            dt.Columns.Add("CustomerID", typeof(int));
            foreach (VIP v in ObjectHandler.GetVipDL().GetVIPs())
            {
                dt.Rows.Add(v.GetVipID(), v.GetUsername(), v.GetMembershipLevel(), v.GetCustomerID());
            }
            dataGridView1.DataSource = dt;
            backbtn.Visible = true;
            deleteBtn.Visible = false;
        }

        private void ClearGridView()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ClearGridView();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Cart", typeof(string));
            dt.Columns.Add("UserID", typeof(int));
            LoadData();
            backbtn.Visible = false;
            deleteBtn.Visible = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        selectedRow = dataGridView1.SelectedRows[0].Index;

                        if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                        {
                            DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

                            if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                            {
                                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                                string status = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString().ToLower();
                                dt.Rows.Clear();
                                ObjectHandler.GetCustomerDL().DeleteCustomer(Convert.ToInt32(id), status, ObjectHandler.GetUserDL().GetUserID(id));
                                LoadData();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }

            }
        }
    }
}
