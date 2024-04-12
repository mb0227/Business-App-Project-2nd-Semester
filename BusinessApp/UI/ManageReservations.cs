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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SignInSignUp.UI
{
    public partial class ManageReservations : Form
    {
        private DataTable dt = new DataTable();
        private Waiter waiter;
        int selectedRow;
        public ManageReservations()
        {
            InitializeComponent();
        }

        public ManageReservations(Size s, Point l, Waiter w)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = l;
            waiter = w;
        }

        private void manageBtns_Click(object sender, EventArgs e)
        {
            WaiterDashboard w = new WaiterDashboard(this.Size,this.Location,waiter);
            w.Show();
            this.Hide();
        }

        private void ManageReservations_Load(object sender, EventArgs e)
        {
            ObjectHandler.GetTableDL().UpdateTablesStatus();
            MakeColumns();
            LoadData();
            FillComboBox();
            if(comboBox1.Items.Count>0)
            { comboBox1.SelectedIndex = 0; }
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var table in ObjectHandler.GetTableDL().GetTables())
            {
                string status = table.GetStatus().ToLower(); 
                if (status == "unbooked")
                {
                    comboBox1.Items.Add(table.GetID());
                }
                else
                {
                    continue;
                }
            }
        }

        private bool CheckValidations()
        {
            if (!string.IsNullOrEmpty(comboBox1.Text.ToString()))
            {
                int max = ObjectHandler.GetTableDL().GetTableCapacity(Convert.ToInt32(comboBox1.Text));
                if (!int.TryParse(guna2TextBox1.Text, out int number) || number < 1 || number > max)
                {
                    errorProvider1.SetError(guna2TextBox1, $"Please enter a valid number between 1 and {max}.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(guna2TextBox1, "");
                }
            }
            else
            {
                return false;
            }

            DateTime currentDate = DateTime.Today;

            if (dateTimePicker1.Value < currentDate)
            {
                errorProvider2.SetError(dateTimePicker1, $"Please enter a valid date for reservation.");
                return false;
            }
            else
            {
                errorProvider2.SetError(dateTimePicker1, "");
            }

            return true;
        }

        private void makeReservation_Click(object sender, EventArgs e)
        {
            if(CheckValidations())
            {
                ObjectHandler.GetReservationDL().SaveReservation(new Reservation(dateTimePicker1.Value, Convert.ToInt32(guna2TextBox1.Text),-1, int.Parse(comboBox1.Text)),-1);
                ObjectHandler.GetTableDL().UpdateTable(new RMS.BL.Table(ObjectHandler.GetTableDL().GetTableCapacity(int.Parse(comboBox1.Text)), int.Parse(comboBox1.Text), "Booked"));
                FillComboBox();
                LoadData();
            }
        }

        private void MakeColumns()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("TotalPersons", typeof(int));
            dt.Columns.Add("ReservationsDate", typeof(DateTime));
            dt.Columns.Add("TableID", typeof(int));
            dt.Columns.Add("CustomerID", typeof(int));

            dataGridView1.DataSource = dt;
        }

        private void LoadData()
        {
            dt.Rows.Clear();
            foreach (Reservation r in ObjectHandler.GetReservationDL().GetReservations())
            {
                dt.Rows.Add(r.GetID(), r.GetTotalPersons(), r.GetReservationDate(), r.GetTableID(),r.GetCustomerID());
            }
            dataGridView1.DataSource = dt;
        }

        private void deleteReservation_Click(object sender, EventArgs e)
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
                            int ID = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);

                            ObjectHandler.GetReservationDL().DeleteReservationByID(ID);
                            ObjectHandler.GetTableDL().UpdateTable(new RMS.BL.Table(ObjectHandler.GetTableDL().GetTableCapacity(Convert.ToInt32(selectedDataGridViewRow.Cells["TableID"].Value)), Convert.ToInt32(selectedDataGridViewRow.Cells["TableID"].Value), "Unbooked"));
                            FillComboBox();
                            LoadData();
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
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void pickupOrder_Click(object sender, EventArgs e)
        {
            WaiterDashboard w = new WaiterDashboard(this.Size, this.Location, waiter);
            w.Show();
            this.Hide();
        }

        private void deliverOrder_Click(object sender, EventArgs e)
        {
            WaiterDashboard w = new WaiterDashboard(this.Size, this.Location, waiter);
            w.Show();
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

        private void reservationBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
