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
        string _totalSales, _date;
        public PrintTotalSalesForm(List<Product> dataSource, string totalSales, string date)
        {
            InitializeComponent();
            _list = dataSource;
            _totalSales = totalSales;
            _date = date;
        }

        private void PrintTotalSalesForm_Load(object sender, EventArgs e)
        {            
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalSales", _totalSales),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateTotalSales", _date)
            };
            this.reportViewer2.LocalReport.SetParameters(para);
            this.reportViewer2.RefreshReport();
        }
    }
}
