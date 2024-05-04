using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BL;
using RMS.DL;
using RMS.Utility;

namespace RMS.UI
{
    public partial class Help : Form
    {
        private Customer customer;
        private CustomerHeader cHeader;
        private CustomerNavbar cNavBar;

        public Help()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public Help(Size size, Point location, Customer c)
        {
            customer = c;
            InitializeComponent();
            this.Size = size;
            this.Location = location;
            InitializeUserControls();
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

            cNavBar = new CustomerNavbar();
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
                panel4.BringToFront();
            }
            else
            {
                panel4.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msgTB.Text))
            {
                msgTB.Text = msgTB.Text.Replace(",", "");
                string encryptedMessage = Encryption.Encrypt(msgTB.Text);
                int receiverID;
                if(ObjectHandler.GetMessageDL().HasChat(customer.GetID()))
                {
                    receiverID = ObjectHandler.GetMessageDL().GetReceiverID(customer.GetID());
                }
                else
                {
                    receiverID = ObjectHandler.GetMessageDL().GetAvailableEmployee() * -1;
                }
                RMS.BL.Message message = new RMS.BL.Message(customer.GetID(), receiverID , encryptedMessage);
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

        private void Help_Load(object sender, EventArgs e)
        {
            DisplayMessages();
            pictureBox.Image = ObjectHandler.GetPhotoDL().LoadImage(customer.GetUserID());
        }

        private void DisplayMessages()
        {
            List<RMS.BL.Message> Messages = ObjectHandler.GetMessageDL().ReceiveMessages(customer.GetID(), $"SELECT * FROM Messages WHERE ReceiverID = @ID OR SenderID={customer.GetID()} ORDER BY Timestamp ASC");
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
                    if (msg.GetSenderID() != customer.GetID())
                    {
                        label.Text = "Admin: " + decryptedMessage + " " + time;
                        label.ForeColor = Color.GreenYellow;
                    }
                    else
                    {
                        label.Text = "You: " + decryptedMessage + " " + time;
                        label.ForeColor = Color.BlanchedAlmond;
                    }
                    msgPanel.Controls.Add(label);
                }
            }
            msgPanel.VerticalScroll.Value = msgPanel.VerticalScroll.Maximum;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Contact = "+923344207165";
            Process.Start("tel:" + Contact);
        }

        private void msgTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private bool IsMessageTextDisplayed(string messageText)
        {
            foreach (Control control in msgPanel.Controls)
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
            Label label = new Label();
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.AutoSize = true;
            string time = msg.GetTime().ToString("HH:mm");
            label.Margin = new Padding(0, 5, 0, 0);
            if (msg.GetSenderID() != customer.GetID())
            {
                label.Text = "Admin: " + decryptedMessage + " " + time;
                label.ForeColor = Color.GreenYellow;
            }
            else
            {
                label.Text = "You: " + decryptedMessage + " " + time;
                label.ForeColor = Color.BlanchedAlmond;
            }
            msgPanel.Controls.Add(label);
            msgPanel.VerticalScroll.Value = msgPanel.VerticalScroll.Maximum;
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            RMS.BL.Message message = ObjectHandler.GetMessageDL().GetNewMessage(customer.GetID());
            if (message != null && !IsMessageTextDisplayed(message.GetMessageText()))
            {
                DisplayNewMessage(message);
            }
            msgPanel.VerticalScroll.Value = msgPanel.VerticalScroll.Maximum;
        }
    }
}
