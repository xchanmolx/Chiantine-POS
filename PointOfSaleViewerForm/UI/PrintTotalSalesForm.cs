using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm
{
    public partial class PrintTotalSalesForm : Form
    {
        List<Product> _list;
        string _totalSales, _date, _store;

        frmMain _parent;

        public PrintTotalSalesForm(List<Product> dataSource, string totalSales, string date, string store, frmMain parent)
        {
            InitializeComponent();
            _list = dataSource;
            _totalSales = totalSales;
            _date = date;
            _store = store;

            _parent = parent;
        }

        private void PrintTotalSalesForm_Load(object sender, EventArgs e)
        {            
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalSales", _totalSales),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateTotalSales", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pStore", _store)
            };
            this.reportViewer2.LocalReport.SetParameters(para);
            this.reportViewer2.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (reportViewer2.PrintDialog() == DialogResult.OK)
            {
                this.Close();
                _parent.txtSearchProductLists.Focus();
            }
        }
    }
}
