using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using RMS.BL;
using RMS.Utility;
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

namespace RMS.Reports
{
    public partial class ShowReport : Form
    {
        public ShowReport(string reportName, int id)
        {
            InitializeComponent();
            if (reportName == "orderHistory")
            {
                OderHistoryReport(id);
            }
            else if (reportName == "customerDetails")
            {
                CustomerDetailsReport();
            }
            else if (reportName == "employeeDetails")
            {
                EmployeeDetailsReport();
            }
            else if (reportName == "salesReport")
            {
                SalesReport();
            }
        }

        private void ShowReport_Load(object sender, EventArgs e)
        {
        }

        private void SalesReport()
        {
            ReportDocument report = new ReportDocument();
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = "..//..//Reports//Sales.rpt";
            string fpath = Path.Combine(path, reportpath);
            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }

        private void CustomerDetailsReport()
        {
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = "..//..//Reports//CustomerDetails.rpt";
            string fpath = Path.Combine(path, reportpath);
            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }

        private void EmployeeDetailsReport()
        {
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = "..//..//Reports//EmployeeDetails.rpt";
            string fpath = Path.Combine(path, reportpath);
            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }

        private void OderHistoryReport(int id)
        {
            ReportDocument report = new ReportDocument();
            report.Load("..//..//Reports//OrderHistory.rpt");
            using (SqlConnection connection = UtilityFunctions.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("SELECT ProductsOrdered, TotalPrice, OrderDate FROM Orders WHERE CustomerID = 1 AND Status=3 OR Status=5", connection);
                command.Parameters.AddWithValue("@CustomerId", id);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Orders");
                report.SetDataSource(dataSet);
                crystalReportViewer1.ReportSource = report;
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
