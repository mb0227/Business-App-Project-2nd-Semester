using RMS.BL;
using RMS.DL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Web.UI;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace RMS.UI
{
    public partial class ManageTables : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        DataTable dt = new DataTable();
        int selectedRow;
        public ManageTables()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public ManageTables(Size size, Point location, Admin admin)
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
                case "manageCustomers":
                    OpenForm(new ManageCustomers(this.Size, this.Location, Admin));
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
                panel3.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                panel3.SendToBack();
                aNavbar.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void makeTableBtn_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                ClearTable();
                ObjectHandler.GetTableDL().SaveTable(new Table(int.Parse(capacity.Text)));
                capacity.Clear();
                LoadData();
            }
        }

        private bool CheckValidations()
        {
            if (!int.TryParse(capacity.Text, out int number) || number < 1 || number > 15)
            {
                errorProvider1.SetError(capacity, "Please enter a valid number between 1 and 15.");
                return false;
            }
            else
            {
                errorProvider1.SetError(capacity, ""); 
            }
            return true;
        }

        private bool IsBooked()
        {
            if (comboBox1.Text != "Booked" && comboBox1.Text != "Unbooked")
            {
                errorProvider2.SetError(comboBox1, "Please select any status");
                return false;
            }
            else
            {
                errorProvider2.SetError(comboBox1, "");
            }
            return true;
        }

        private void viewTableBtn_Click(object sender, EventArgs e) //update table
        {
            if (CheckValidations() && IsBooked())
            {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value);
                    selectedRow = guna2DataGridView1.SelectedRows[0].Index;
                    if (guna2DataGridView1 != null && selectedRow >= 0 && selectedRow < guna2DataGridView1.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = guna2DataGridView1.Rows[selectedRow];
                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                        {
                            ClearTable();
                            ObjectHandler.GetTableDL().UpdateTable(new Table(int.Parse(capacity.Text), id, comboBox1.Text));
                            LoadData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
        }

        private void ManageTables_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Capacity", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            guna2DataGridView1.DataSource = dt;

            foreach (Table t in ObjectHandler.GetTableDL().GetTables())
            {
                dt.Rows.Add(t.GetID(),t.GetCapacity(),t.GetStatus());
            }
        }

        private void ClearTable()
        {
            dt.Rows.Clear();
        }

        private void LoadData()
        {
            foreach (Table t in ObjectHandler.GetTableDL().GetTables())
            {
                dt.Rows.Add(t.GetID(), t.GetCapacity(),t.GetStatus());
            }
        }

        private void deleteTableBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete table?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               if (guna2DataGridView1.SelectedRows.Count > 0)
               {
                    try
                    {
                        int id = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value);
                        selectedRow = guna2DataGridView1.SelectedRows[0].Index;
                        if (guna2DataGridView1 != null && selectedRow >= 0 && selectedRow < guna2DataGridView1.Rows.Count )
                        {
                            DataGridViewRow selectedDataGridViewRow = guna2DataGridView1.Rows[selectedRow];
                            if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                            {
                                if (ObjectHandler.GetTableDL().GetTableById(Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value)).GetStatus().Trim() == "Unbooked")
                                {
                                    ClearTable();
                                    ObjectHandler.GetTableDL().DeleteTable(Convert.ToInt32(id));
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, the table is currently booked, it can't be deleted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
                    MessageBox.Show("Please select a row to delete");
                }
            }
        }
    }
}
