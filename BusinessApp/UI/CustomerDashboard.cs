using SSC.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;
using RMS.DL;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace SSC
{
    public partial class CustomerDashboard : Form
    {
        private CustomerHeader cHeader;
        private CustomerNavbar cNavBar;
        private Customer customer;

        public CustomerDashboard()
        {
            InitializeComponent();
            InitializeUserControls();
        }

        public CustomerDashboard(Size size, Point location, Customer c)
        {
            InitializeComponent();
            customer = c;
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
                guna2PictureBox1.BringToFront();
            }
            else
            {
                panel1.SendToBack();
                cNavBar.BringToFront();
            }
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            //pictureBox.Image = UserDBDL.LoadImage(customer.GetUserID());
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        if (stream.Length > 0) 
                        {
                            try
                            {
                                Image image = Image.FromStream(stream);
                                pictureBox.Image = ResizeImage(image, pictureBox.Width, pictureBox.Height);
                                UserDBDL.UpdateImage(customer.GetUserID(), GetPhoto());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] GetPhoto()
        {
            MemoryStream m = new MemoryStream();
            pictureBox.Image.Save(m, ImageFormat.Jpeg);
            return m.GetBuffer();
        }

        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, width, height);
            }
            return (Image)bmp;
        }
    }
}
