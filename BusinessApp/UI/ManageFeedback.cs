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
    public partial class ManageFeedback : Form
    {
        private Admin Admin;
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        DataTable dt = new DataTable();
        int selectedRow;
        public ManageFeedback()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public ManageFeedback(Size size, Point location, Admin admin)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
            Admin = admin;
            InitializeUserControls();
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

        private void ManageFeedback_Load(object sender, EventArgs e)
        {
        }

        private void viewReviews_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("Ratings", typeof(string));

            foreach (var item in ObjectHandler.GetFeedbackDL().GetReviews())
            {
                dt.Rows.Add(item.GetCustomerID(), item.GetReview());
            }
            dgv.DataSource=dt;
        }

        private void viewMsgs_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();

            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("Message", typeof(string));

            foreach (var item in ObjectHandler.GetMessageDL().ReceiveMessages(Admin.GetEmployeeID()*-1, "SELECT * FROM Messages WHERE ReceiverID = @ID ORDER BY Timestamp ASC"))
            {
                dt.Rows.Add(item.GetSenderID(), item.GetMessageText());
            }
            dgv.DataSource = dt;
            ChangeVisibility(false, true);
        }

       private void ChangeVisibility(bool before, bool after)
        {
            viewReviews.Visible = before;
            viewMsgs.Visible = before;
            tb.Visible = after;
            reply.Visible = after;
            back.Visible = after;
        }

        private void reply_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                try
                {
                    selectedRow = dgv.SelectedRows[0].Index;

                    if (dgv != null && selectedRow >= 0 && selectedRow < dgv.Rows.Count)
                    {
                        DataGridViewRow selectedDataGridViewRow = dgv.Rows[selectedRow];

                        if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["CustomerID"].Value != null)
                        {
                            reply.Text = reply.Text.Replace(",", "");
                            if (!string.IsNullOrEmpty(reply.Text))
                            {
                                RMS.BL.Message message = new RMS.BL.Message(ObjectHandler.GetMessageDL().GetAvailableEmployee() * -1, Convert.ToInt32(selectedDataGridViewRow.Cells["CustomerID"].Value),tb.Text);
                                ObjectHandler.GetMessageDL().SendMessage(message);
                                reply.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Please enter a message to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to reply to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            ChangeVisibility(true, false);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
