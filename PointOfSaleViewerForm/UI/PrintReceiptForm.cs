using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSaleViewerForm.UI;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace PointOfSaleViewerForm
{
    public partial class PrintReceiptForm : Form
    {
        List<Product> _list;
        string _total, _cash, _change, _date, _store, _discount;

        frmMain _parent;    

        public PrintReceiptForm(List<Product> dataSource,string total, string cash, string change, string date, string store, frmMain parent, string discount)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
            _store = store;

            _parent = parent;
            _discount = discount;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {           
            ProductBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),
                new Microsoft.Reporting.WinForms.ReportParameter("pStore",_store),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiscount",_discount)
            };
            this.reportViewer.LocalReport.SetParameters(para);            
            this.reportViewer.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (reportViewer.PrintDialog() == DialogResult.OK)
            {
                this.Close();
                _parent.txtCash.Focus();
            }
        }
    }
}
