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
using RMS.Utility;


namespace RMS.UI
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


       private void ChangeVisibility(bool before, bool after)
        {
            viewReviews.Visible = before;
            viewCustomers.Visible = before;
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
                            int customerID = Convert.ToInt32(selectedDataGridViewRow.Cells["CustomerID"].Value);    
                            Reply reply = new Reply(this.Size, this.Location, Admin, customerID);
                            reply.Show();
                            this.Hide();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            RMS.BL.Message message = ObjectHandler.GetMessageDL().GetNewMessage(Admin.GetAdminID());
            if (message != null && !IsMessageTextDisplayed(message.GetMessageText()))
            {
                DisplayNewMessage(message);
            }
        }

        private bool IsMessageTextDisplayed(string messageText)
        {
            foreach (Control control in dgv.Controls)
            {
                if (control is Label label && label.Text.Contains(messageText))
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayNewMessage(RMS.BL.Message msg)
        {
            string decryptedMessage = Encryption.Decrypt(msg.GetMessageText());
            dt.Rows.Add(msg.GetSenderID(), decryptedMessage);
        }

        private void viewCustomers_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();

            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("Message", typeof(string));

            foreach (var item in ObjectHandler.GetMessageDL().GetCustomersNames(Admin.GetEmployeeID()))
            {
                dt.Rows.Add(item.GetID(), item.GetUsername());
            }

            dgv.DataSource = dt;
            ChangeVisibility(false, true);
        }
    }
}
