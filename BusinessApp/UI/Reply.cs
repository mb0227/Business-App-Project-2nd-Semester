using RMS.BL;
using RMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.UI
{
    public partial class Reply : Form
    {
        private Admin Admin;
        private CustomerHeader aHeader;
        private Navbar aNavbar;
        private int CustomerID;
        public Reply()
        {
            InitializeComponent();
        }
        
        public Reply(Size size, Point location, Admin admin, int customerID)
        {
            InitializeComponent();
            this.Size = size;
            this.Location = location;
            Admin = admin;
            CustomerID = customerID;
            InitializeUserControls();
        }

        private void Reply_Load(object sender, EventArgs e)
        {
            DisplayMessages();
        }

        private void DisplayMessages()
        {
            List<RMS.BL.Message> Messages = ObjectHandler.GetMessageDL().ReceiveMessages(Admin.GetEmployeeID()*-1, "SELECT * FROM Messages WHERE ReceiverID = @ID OR SenderID=@ID ORDER BY Timestamp ASC");
            {
                foreach (var msg in Messages)
                {
                    if (msg.GetMessageText() == "")
                        continue;
                    string decryptedMessage = Encryption.Decrypt(msg.GetMessageText());
                    Label label = new Label();
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.AutoSize = true;
                    string time = msg.GetTime().ToString("HH:mm");
                    label.Margin = new Padding(0, 5, 0, 0);
                    if (msg.GetSenderID() == CustomerID)
                    {
                        label.Text = "Customer: " + decryptedMessage + " " + time;
                        label.ForeColor = Color.GreenYellow;
                    }
                    if (msg.GetSenderID()*-1 == Admin.GetEmployeeID() && msg.GetReceiverID() == CustomerID)
                    {
                        label.Text = "You: " + decryptedMessage + " " + time;
                        label.ForeColor = Color.BlanchedAlmond;
                    }
                    msgPanel.Controls.Add(label);
                }
            }
            msgPanel.VerticalScroll.Value = msgPanel.VerticalScroll.Maximum;
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
                msgPanel.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                msgPanel.SendToBack();
                aNavbar.BringToFront();
            }
        }

        private void RefreshPanel()
        {
            foreach (Control control in msgPanel.Controls)
            {
                if (control is Label label)
                {
                    label.Text = "";
                }
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msgTB.Text))
            {
                RMS.BL.Message message = new RMS.BL.Message(ObjectHandler.GetMessageDL().GetAvailableEmployee() * -1, CustomerID, Encryption.Encrypt(msgTB.Text));
                ObjectHandler.GetMessageDL().SendMessage(message);
                msgTB.Text = "";
                RefreshPanel();
                DisplayMessages();
            }
            else
            {
                MessageBox.Show("Please enter a message to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
