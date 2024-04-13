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
using RMS.DL;
using Guna.UI2.WinForms;

namespace RMS.UI
{
    public partial class ViewEmployees : Form
    {
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private Admin Admin;
        DataTable dt = new DataTable();
        int selectedRow;
        public ViewEmployees()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public ViewEmployees(Size size, Point location, Admin admin)
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

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("JoinDate", typeof(DateTime));
            dt.Columns.Add("UserID", typeof(int));

            dataGridView1.DataSource = dt;
            foreach (Employee emp in ObjectHandler.GetEmployeeDL().GetEmployees())
            {
                if (emp.GetEmployeeID() != Admin.GetEmployeeID())
                    dt.Rows.Add(emp.GetEmployeeID(), emp.GetUsername(), emp.GetContact(), emp.GetSalary(), emp.GetGender(), emp.GetJoinDate(), emp.GetUserID());

            }
        }

        private void LoadData()
        {
            foreach (Employee emp in ObjectHandler.GetEmployeeDL().GetEmployees())
            {
                if(emp.GetEmployeeID() != Admin.GetEmployeeID())
                    dt.Rows.Add(emp.GetEmployeeID(), emp.GetUsername(), emp.GetContact(), emp.GetSalary(), emp.GetGender(), emp.GetJoinDate(), emp.GetUserID());
            }
        }

        private void ClearGridView()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
        }

        private void viewChefBtn_Click(object sender, EventArgs e)
        {
            ClearGridView();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("Shift", typeof(string));
            dt.Columns.Add("Specialization", typeof(string));
            dt.Columns.Add("Experience", typeof(string));
            dt.Columns.Add("EmployeeID", typeof(int));

            dataGridView1.DataSource = dt;
            foreach (Chef c in ObjectHandler.GetChefDL().GetChefs())
            {
                dt.Rows.Add(c.GetChefID(), c.GetUsername(), c.GetSalary(), c.GetShift(), c.GetSpecialization(),c.GetExperience(),c.GetEmployeeID());
            }
            backbtn.Visible = true;
            deleteBtn.Visible = false;
        }

        private void viewWaiterBtn_Click(object sender, EventArgs e)
        {
         ClearGridView();

         dt.Columns.Add("ID", typeof(int));
         dt.Columns.Add("Username", typeof(string));
         dt.Columns.Add("Salary", typeof(double));
         dt.Columns.Add("Shift", typeof(string));
         dt.Columns.Add("Area", typeof(string));
         dt.Columns.Add("Language", typeof(string));
         dt.Columns.Add("EmployeeID", typeof(int));

         dataGridView1.DataSource = dt;
         foreach (Waiter w in ObjectHandler.GetWaiterDL().GetWaiters())
         {
             dt.Rows.Add(w.GetWaiterID(), w.GetUsername(), w.GetSalary(), w.GetShift(), w.GetTables(), w.GetLanguage(), w.GetEmployeeID());
         }
         backbtn.Visible = true;
         deleteBtn.Visible = false;
            
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
                    MessageBox.Show("No matching employees found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text.Trim()))
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ClearGridView();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("JoinDate", typeof(DateTime));
            dt.Columns.Add("UserID", typeof(int));
            LoadData();
            backbtn.Visible = false;
            deleteBtn.Visible = true;
        }

        private void viewAdmins_Click(object sender, EventArgs e)
        {
            ClearGridView();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("ToolsUsed", typeof(string));
            dt.Columns.Add("Permissions", typeof(string));
            dt.Columns.Add("EmployeeID", typeof(int));

            dataGridView1.DataSource = dt;
            foreach (Admin a in ObjectHandler.GetAdminDL().GetAdmins()) 
            {
                dt.Rows.Add(a.GetAdminID(), a.GetUsername(), a.GetSalary(), string.Join(";",a.GetToolsUsed()), string.Join(";", a.GetPermissions()), a.GetEmployeeID());
            }
            backbtn.Visible = true;
            deleteBtn.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                        selectedRow = dataGridView1.SelectedRows[0].Index;
                        if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                        {
                            DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];
                            if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["ID"].Value != null)
                            {
                                string role = ObjectHandler.GetEmployeeDL().GetEmployeeRole(id).ToLower();
                                dt.Rows.Clear();
                                ObjectHandler.GetEmployeeDL().DeleteEmployee(id, role, ObjectHandler.GetUserDL().GetUserIDEmp(id));
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
                    MessageBox.Show("Please select a row to delete");
                }
            }
        }
    }
}
