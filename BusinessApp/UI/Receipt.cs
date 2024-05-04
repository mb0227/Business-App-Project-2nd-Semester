using RMS.BL;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using RMS.Utility;


namespace RMS.UI
{
    public partial class Receipt : Form
    {
        private Waiter waiter;
        private DataTable dt = new DataTable();
        private int selectedRow = -1;
        public Receipt()
        {
            InitializeComponent();
        }
        public Receipt(Size s, Point l, Waiter w)
        {
            InitializeComponent();
            this.Size = s;
            this.Location = l;
            waiter = w;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            MakeColumns();
            LoadData();
        }

        private void MakeColumns()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Order", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("PaymentMethod", typeof(string));
            dataGridView1.DataSource = dt;
        }

        private void LoadData()
        {
            dt.Rows.Clear();
            foreach (Order order in ObjectHandler.GetOrderDL().GetOrders(3))
            {
                if (order.GetStatus() != Order.OrderStatus.Paid)
                {
                    dt.Rows.Add(order.GetOrderID(),order.GetProductsString(), order.GetTotalPrice(), order.GetPaymentMethod());
                }
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1 != null && selectedRow >= 0 && selectedRow < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

                    if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["Order"].Value != null)
                    {
                        int id = Convert.ToInt32(selectedDataGridViewRow.Cells["ID"].Value);
                        string order = Convert.ToString(selectedDataGridViewRow.Cells["Order"].Value);
                        double price = Convert.ToDouble(selectedDataGridViewRow.Cells["Price"].Value);
                        string paymentMethod = Convert.ToString(selectedDataGridViewRow.Cells["PaymentMethod"].Value);
                        if (CheckValidations(price))
                        {
                            ObjectHandler.GetOrderDL().UpdateOrderStatus(id, 5);
                            print();
                            LoadData();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select any Order to print receipt of","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckValidations(double price)
        {
            double p;
            if (!double.TryParse(paid.Text, out p) || p < price)
            {
                errorProvider1.SetError(paid, $"Please enter a valid price greater than or equal to {price}.");
                return false;
            }
            else
            {
                errorProvider1.SetError(paid, "");
            }
            return true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Homepage home = new Homepage(this.Size, this.Location);
                home.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow selectedDataGridViewRow = dataGridView1.Rows[selectedRow];

            if (selectedDataGridViewRow != null && selectedDataGridViewRow.Cells["Order"].Value != null)
            {
                string order = Convert.ToString(selectedDataGridViewRow.Cells["Order"].Value);
                double price = Convert.ToDouble(selectedDataGridViewRow.Cells["Price"].Value);
                Graphics graphics = e.Graphics;
                Font font = new Font("Courier New", 10);
                float fontHeight = font.GetHeight();
                int startX = 50;
                int startY = 55;
                int Offset = 40;

                int requiredHeight = Offset; 
                int requiredWidth = Offset; 

                e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", requiredWidth, requiredHeight);

                graphics.DrawString("Receipt", new Font("Courier New", 14),
                                    new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Order:" + order,
                         new Font("Courier New", 14),
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Order Date :" + DateTime.Now.ToShortDateString(),
                         new Font("Courier New", 12),
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                String underLine = "------------------------------------------";
                graphics.DrawString(underLine, new Font("Courier New", 10),
                         new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + 20;
                String Grosstotal = "Total Amount to Pay = " + price;

                Offset = Offset + 20;
                underLine = "------------------------------------------";
                graphics.DrawString(underLine, new Font("Courier New", 10),
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

                graphics.DrawString("Total: " + Grosstotal, new Font("Courier New", 10),
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;
                graphics.DrawString("Paid: " + paid.Text, new Font("Courier New", 10),
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

                double change =  Convert.ToDouble(paid.Text)-price;
                graphics.DrawString("Change: "+change, new Font("Courier New", 10),
                         new SolidBrush(Color.Black), startX, startY + Offset);

            }
        }

        public void print()
        {
            PrintDialog pd = new PrintDialog();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);

            PaperSize psize = new PaperSize("Custom", 100, 200);

            pd.Document = printDocument1;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            printDocument1.DefaultPageSettings.PaperSize.Height = 820;

            printDocument1.DefaultPageSettings.PaperSize.Width = 520;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = printDocument1;
                pp.PrintPreviewControl.Zoom = 0.8;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WaiterDashboard w = new WaiterDashboard(this.Size, this.Location, waiter);
            w.Show();
            this.Hide();
        }
    }
}
