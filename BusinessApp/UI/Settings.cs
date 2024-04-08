using Guna.UI2.WinForms;
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
using RMS.DL;

namespace SSC.UI
{
    public partial class Settings : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavBar cNavBar;
        private Customer customer;
        private bool nVisible = false;
        Button markRead = new Button();

        public Settings()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public Settings(Size size, Point location, Customer c)
        {
            InitializeComponent();
            InitializeUserControls();
            this.Size = size;
            this.Location = location;
            customer = c;
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
                    OpenForm(new UI.Help(this.Size, this.Location, customer));
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
                panel1.BringToFront();
            }
            else
            {
                panel1.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            int n =ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID()).Count;
            if (n > 0)
            {
                notiCount.Text = n.ToString();
                notiCount.Visible = true;
            }
        }

        private void MakeBtnVisible(int x,int y)
        {
            markRead.Location = new Point(x, y);
            markRead.Visible = true;
        }

        private void notification_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!nVisible)
            {
                List<string> notifications = ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID());
                int y = 124;
                int labelX = this.Width - 150 - SystemInformation.VerticalScrollBarWidth;
                nVisible = true;
                int labelMaxWidth = panel3.Width - 10; 

                foreach (string notification in notifications)
                {
                    Label label = new Label();
                    label.Text = "- "+ notification;
                    label.ForeColor = Color.Red;
                    label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Anchor = AnchorStyles.None;
                    label.AutoSize = true;
                    label.MaximumSize = new Size(labelMaxWidth, 0); // Set maximum width
                    label.Location = new Point(labelX, y);
                    panel3.Controls.Add(label);
                    y += label.Height + 10;
                    MakeBtnVisible(labelX, y + 10 + (notifications.Count * 30));
                }

                markRead.Text = "Mark Read";
                markRead.BackColor = Color.Transparent;
                markRead.FlatStyle = FlatStyle.Flat;
                markRead.FlatAppearance.BorderSize = 0;
                markRead.Width = 100;
                markRead.Height = 25;
                markRead.ForeColor = Color.White; 
                markRead.Font = new Font("Tahoma", 12, FontStyle.Regular); 
                                                                             

                markRead.Click += MarkRead_Click;

                panel3.Controls.Add(markRead);
            }
            else
            {
                nVisible = false;
                markRead.Visible = false;
                foreach (Control control in panel3.Controls)
                {
                    if (control is Label)
                    {
                        control.Visible=false;
                    }
                }
            }
        }
        private void MarkRead_Click(object sender, EventArgs e)
        {
            List<string> notifications = ObjectHandler.GetNotificationDL().GetNotifications(customer.GetID());
            foreach (string notification in notifications)
            {
                ObjectHandler.GetNotificationDL().MarkAsRead(customer.GetID());
            }
        }
    }
}
