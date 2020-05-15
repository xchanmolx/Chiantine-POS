using Microsoft.Reporting.WinForms;
using PointOfSaleViewerForm.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm.UI
{
    public partial class frmPrintAllOrders : Form
    {
        private const string db = "POS";

        string _date, _overallTotal, _title;

        public frmPrintAllOrders(string date, string overallTotal, string title)
        {
            InitializeComponent();

            _date = date;
            _overallTotal = overallTotal;
            _title = title;
        }

        private void frmPrintAllOrders_Load(object sender, EventArgs e)
        {
            TextBox sku = Application.OpenForms["DisplaySalesProductForm"].Controls["txtSearchSalesProduct"] as TextBox;
            TextBox datePurchased = Application.OpenForms["DisplaySalesProductForm"].Controls["txtSearchDate"] as TextBox;
            sku.Text = sku.Text;
            datePurchased.Text = datePurchased.Text;

            dsPrintAllOrders dsPAO = new dsPrintAllOrders();
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Orders WHERE SKU LIKE '%" + sku.Text + "%' AND DatePurchased LIKE '%" + datePurchased.Text + "%' ", conn);
            sda.Fill(dsPAO, dsPAO.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("dsPrintAllOrders", dsPAO.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintAllOrders.LocalReport.DataSources.Clear();
            this.reportViewerPrintAllOrders.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintAllOrders.LocalReport.Refresh();

            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("pDate", _date),
                new ReportParameter("pOverallTotal", _overallTotal),
                new ReportParameter("pTitle", _title)
            };
            this.reportViewerPrintAllOrders.LocalReport.SetParameters(para);
            this.reportViewerPrintAllOrders.RefreshReport();
        }
    }
}
