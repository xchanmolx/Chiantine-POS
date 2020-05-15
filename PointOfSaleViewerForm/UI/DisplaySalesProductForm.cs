using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSaleViewerForm.UI;
using PointOfSaleViewerForm.DataSet;
using Microsoft.Reporting.WinForms;

namespace PointOfSaleViewerForm
{
    public partial class DisplaySalesProductForm : Form
    {
        private const string db = "POS";

        public DisplaySalesProductForm()
        {
            InitializeComponent();

            dgvSalesProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvSalesProduct.EnableHeadersVisualStyles = false;            
        }

        OrdersBLL sales = new OrdersBLL();
        OrdersDAL dal = new OrdersDAL();
        int id = 1;

        DataTable dt = new DataTable("Orders");
        private async void DisplaySalesProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillTextStoreName();

                if (String.IsNullOrWhiteSpace(txtSearchSalesProduct.Text) && String.IsNullOrWhiteSpace(txtSearchDate.Text))
                {
                    using (SqlConnection cn = new SqlConnection(GlobalConfig.CnnString(db)))
                    {
                        DataTable dt = dal.Select();
                        dgvSalesProduct.DataSource = await Task.Run(() => dt);

                        dgvSalesProduct.Columns[0].Visible = false;
                        dgvSalesProduct.Columns[1].Width = 150; // SKU
                        dgvSalesProduct.Columns[2].Width = 199; // Product Name
                        dgvSalesProduct.Columns[3].Width = 70;  // Price
                        dgvSalesProduct.Columns[4].Width = 70; // Quantity
                        dgvSalesProduct.Columns[5].Width = 100; // Total
                        dgvSalesProduct.Columns[6].Width = 178; // Date Purchased 

                        dgvSalesProduct.Columns[1].HeaderText = "SKU";
                        dgvSalesProduct.Columns[2].HeaderText = "Product Name";
                        dgvSalesProduct.Columns[4].HeaderText = "Qty.";
                        dgvSalesProduct.Columns[6].HeaderText = "Date Purchased";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Run()
        {
            Invoke(new EventHandler(delegate (object sender, EventArgs e)
            {
                
            }), new object[2] { this, null });
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete all?", "Delete All!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(GlobalConfig.CnnString(db)))
                    {

                        if (cn.State == ConnectionState.Closed)
                            cn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Orders", cn))
                        {
                            cmd.ExecuteNonQuery();

                            dgvSalesProduct.DataSource = dt;
                            dt.Clear();
                        }
                    }

                    bunifuMaterialTextboxOverAllTotal.Text = "Overall Total: ₱ 0.00";
                    MessageBox.Show("Deleted All successfully.", "Delete Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DeleteAll Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
            }
            else
            {
                txtSearchSalesProduct.Focus();
            }
        }

        private void dgvSalesProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                dgvSalesProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datagridview Product Lists RowPrePaint Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchSalesProduct_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSalesProduct.DataSource;
            bs.Filter = "SKU  LIKE '%" + txtSearchSalesProduct.Text + "%' AND DatePurchased LIKE '%" + txtSearchDate.Text + "%' ";
            dgvSalesProduct.DataSource = bs;
        }

        private void txtSearchDate_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSalesProduct.DataSource;
            bs.Filter = "SKU  LIKE '%" + txtSearchSalesProduct.Text + "%' AND DatePurchased LIKE '%" + txtSearchDate.Text + "%' ";
            dgvSalesProduct.DataSource = bs;
        }

        private void dgvSalesProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {                
                bunifuMaterialTextboxOverAllTotal.Text = String.Format("Overall Total: ₱ {0:N2}", dgvSalesProduct.Rows.OfType<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["Total"].Value)));
            }

            lblOrderedItems.Text = "Ordered Items: " + dgvSalesProduct.Rows.Count.ToString();
        }

        private void dgvSalesProduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblOrderedItems.Text = "Ordered Items: " + dgvSalesProduct.Rows.Count.ToString();
        }

        private void btnBackToPointOfSale_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void dgvSalesProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var column = dgvSalesProduct.Columns[e.ColumnIndex];
            if (column.Name == "Price")
            {
                var cell = dgvSalesProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (decimal)e.Value;
                if (cell.IsInEditMode)
                {
                    e.Value = value.ToString(); // Display all digits
                }
                else
                {
                    // Display only two digits of decimals without rounding
                    var twoDigitsValue = Math.Truncate(value * 100) / 100;
                    e.Value = twoDigitsValue.ToString("N2");
                }
            }
            else if (column.Name == "Total")
            {
                var cell = dgvSalesProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var value = (decimal)e.Value;
                if (cell.IsInEditMode)
                {
                    e.Value = value.ToString(); // Display all digits
                }
                else
                {
                    // Display only two digits of decimals without rounding
                    var twoDigitsValue = Math.Truncate(value * 100) / 100;
                    e.Value = twoDigitsValue.ToString("N2");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from User UI
                sales.Id = id;
                sales.SKU = txtSKU.Text;
                sales.ProductName = txtProductName.Text;
                sales.Price = Convert.ToDecimal(txtPrice.Text);
                sales.Quantity = Convert.ToInt32(txtQuantity.Text);
                sales.Total = Convert.ToDecimal(txtTotal.Text);
                sales.DatePurchased = Convert.ToDateTime(txtDatePurchased.Text);

                // Updating data into Database
                bool success = dal.Update(sales);

                // If data is updated successfully then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data updated successfully 
                    MessageBox.Show("Product successfully updated!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchSalesProduct.Focus();
                }
                else
                {
                    // Failed to update user 
                    MessageBox.Show("Failed to update Product Information!", "Update Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvSalesProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // Getting User ID from Form
                sales.Id = id;

                bool success = dal.Delete(sales);
                success = true;
                txtSearchSalesProduct.Focus();

                txtSKU.Visible = false;
                txtProductName.Visible = false;
                txtPrice.Visible = false;
                txtQuantity.Visible = false;
                txtTotal.Visible = false;
                txtDatePurchased.Visible = false;

                MessageBox.Show("Product deleted successfully!", "Delete Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresing Data Grid View
                DataTable dt = dal.Select();
                dgvSalesProduct.DataSource = dt;
            }
            else
            {
                txtSKU.Visible = false;
                txtProductName.Visible = false;
                txtPrice.Visible = false;
                txtQuantity.Visible = false;
                txtTotal.Visible = false;
                txtDatePurchased.Visible = false;

                txtSearchSalesProduct.Focus();
            }
        }

        private void dgvSalesProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesProduct.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dgvSalesProduct.CurrentRow.Cells[0].Value.ToString());
                    txtSKU.Text = dgvSalesProduct.CurrentRow.Cells[1].Value.ToString();
                    txtProductName.Text = dgvSalesProduct.CurrentRow.Cells[2].Value.ToString();
                    txtPrice.Text = dgvSalesProduct.CurrentRow.Cells[3].Value.ToString();
                    txtQuantity.Text = dgvSalesProduct.CurrentRow.Cells[4].Value.ToString();
                    txtTotal.Text = dgvSalesProduct.CurrentRow.Cells[5].Value.ToString();
                    txtDatePurchased.Text = dgvSalesProduct.CurrentRow.Cells[6].Value.ToString();

                    txtSKU.Visible = true;
                    txtProductName.Visible = true;
                    txtPrice.Visible = true;
                    txtQuantity.Visible = true;
                    txtTotal.Visible = true;
                    txtDatePurchased.Visible = true;

                    txtSKU.Focus();
                }
                else
                {
                    txtSKU.Visible = false;
                    txtProductName.Visible = false;
                    txtPrice.Visible = false;
                    txtQuantity.Visible = false;
                    txtTotal.Visible = false;
                    txtDatePurchased.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dgvSalesProduct_Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchSalesProduct_Enter(object sender, EventArgs e)
        {
            txtSKU.Visible = false;
            txtProductName.Visible = false;
            txtPrice.Visible = false;
            txtQuantity.Visible = false;
            txtTotal.Visible = false;
            txtDatePurchased.Visible = false;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintAllOrders frm = new frmPrintAllOrders(DateTime.Now.ToString("dddd, MMMM dd, yyyy"), string.Format("{0}", bunifuMaterialTextboxOverAllTotal.Text), string.Format("{0}", txtStoreName.Text));

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print All Orders Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void FillTextStoreName()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                string query = "SELECT store_name FROM StoreName";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        // Admin Name
                        read.Read();
                        txtStoreName.Text = (read.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }            
        }
    }
}
