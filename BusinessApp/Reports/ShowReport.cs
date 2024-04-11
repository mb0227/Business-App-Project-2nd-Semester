using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using RMS.BL;
using SSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp.Reports
{
    public partial class ShowReport : Form
    {
        public ShowReport(int id)
        {
            InitializeComponent();
            ReportDocument report = new ReportDocument();
            report.Load("..//..//Reports//OrderHistory.rpt");
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("SELECT ProductsOrdered, TotalPrice, OrderDate FROM Orders WHERE CustomerID = @CustomerId AND Status=@Status", connection);
                command.Parameters.AddWithValue("@CustomerId", id);
                command.Parameters.AddWithValue("@Status", 3);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Orders");
                report.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = report;
            }
        }

        private void ShowReport_Load(object sender, EventArgs e)
        {
        }

        private void UserDetailsReport()
        {
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = "..//..//Reports//UserDetails.rpt";
            string fpath = Path.Combine(path, reportpath);

            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
