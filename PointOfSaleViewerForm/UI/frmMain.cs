using Dapper;
using Microsoft.Reporting.WinForms;
using PointOfSaleViewerForm.DAL;
using PointOfSaleViewerForm.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm
{
    public partial class frmMain : Form
    {
        private const string db = "POS";
        int productId = 0;
        decimal totalOrder = 0M;
        decimal totalSales = 0M;
        decimal cash = 0M;

        decimal discount = 0M;
        decimal discountNumber = 0M;

        public frmMain()
        {
            InitializeComponent();            

            dgvProductLists.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvProductLists.EnableHeadersVisualStyles = false;

            dgvOrderProductLists.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvOrderProductLists.EnableHeadersVisualStyles = false;

            dal.DeleteAllTotalSalesPastDay();
        }

        public string LabelText
        {
            get
            {
                return this.lblStoreName.Text;
            }
            set
            {
                this.lblStoreName.Text = value;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                dal.DeleteAllTotalSalesPastDay();

                Clear();

                FillDataGridView();

                FillLabelStoreName();

                productBindingSource.DataSource = new List<Product>(); // Init empty list               

                SqlConnection con = new SqlConnection(GlobalConfig.CnnString(db));
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TotalSales FROM TotalSales", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblTotalSales.Text = reader.GetString(0);
                }

                totalSales += Convert.ToDecimal(lblTotalSales.Text);

                con.Close();

                lblDate.Text = DateTime.Now.ToString("ddddd, MMMM dd, yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form Load Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillDataGridView()
        {          
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@txtSearch", txtSearchProductLists.Text.Trim());

                List<Product> products = connection.Query<Product>("spProduct_GetAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Product>();

                //dgvProductLists.DataSource = products;
                
                dgvProductLists.DataSource = products.Where(item => item.SKU == txtSearchProductLists.Text).Take(20).ToList<Product>();

                dgvProductLists.Columns[0].Visible = false;
                dgvProductLists.Columns[1].Width = 140;     // SKU
                dgvProductLists.Columns[2].Width = 250;     // Product Name
                dgvProductLists.Columns[3].Width = 95;     // Price
                dgvProductLists.Columns[4].Visible = false; // Quantity
                dgvProductLists.Columns[5].Visible = false; // Total
                dgvProductLists.Columns[6].Visible = false; // Discount
                dgvProductLists.Columns[7].Visible = false; // Date

                dgvOrderProductLists.Columns[0].Visible = false; // Id
                dgvOrderProductLists.Columns[1].Width = 150;     // SKU
                dgvOrderProductLists.Columns[2].Width = 310;     // Product Name
                dgvOrderProductLists.Columns[3].Width = 100;     // Price
                dgvOrderProductLists.Columns[4].Width = 80;      // Quantity
                dgvOrderProductLists.Columns[5].Width = 120;     // Total
                dgvOrderProductLists.Columns[6].Visible = false; // Discount
                dgvOrderProductLists.Columns[7].Visible = false; // Date


                dgvProductLists.Columns[1].HeaderText = "SKU";
                dgvProductLists.Columns[2].HeaderText = "Product Name";
                dgvOrderProductLists.Columns[1].HeaderText = "SKU";
                dgvOrderProductLists.Columns[2].HeaderText = "Product Name";
            }
        }
        
        public void SearchSKU()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@txtSearch", txtSKU.Text.Trim());

                List<Product> products = connection.Query<Product>("spProduct_GetAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Product>();

                //dgvProductLists.DataSource = products;

                dgvProductLists.DataSource = products.Where(item => item.SKU == txtSKU.Text).Take(20).ToList<Product>();
            }
        }

        public void FillLabelStoreName()
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
                        lblStoreName.Text = (read.GetValue(0).ToString());
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

        private void btnTotalSalesZero_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want Total Sales back to zero?", "Total Sales back to zero!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dal.DeleteAllTotalSales();
                    totalSales = 0m;
                    lblTotalSales.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btnTotalSalesZero_Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                totalOrder -= ((obj.Price * obj.Quantity) - obj.Discount);
                txtTotalOrder.Text = string.Format("{0:n}", totalOrder);

                decimal.TryParse(lblDiscountedNumber.Text, out discountNumber);

                discountNumber -= obj.Discount;
                lblDiscountedNumber.Text = string.Format("{0}", discountNumber);

                productBindingSource.RemoveCurrent();
                txtSearchProductLists.Focus();

                discount = 0;
            }
            else // if (obj == null)
            {
                MessageBox.Show("Select on order list to remove an item.", "Remove Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchProductLists.Focus();
            }
        }

        private void btnCanceledOrder_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Product obj = productBindingSource.Current as Product;
                if (obj != null)
                {
                    productBindingSource.Clear();

                    txtTotalOrder.Text = "0.00";
                    totalOrder = 0M;
                    discountNumber = 0M;
                    lblDiscountedNumber.Text = string.Format("{0}", discountNumber);

                    txtSearchProductLists.Focus();
                }
                else // if (obj == null)
                {
                    MessageBox.Show("Make sure you have an order product/s.", "Cancel Order Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchProductLists.Focus();
                } 
            }
            else
            {
                txtSearchProductLists.Focus();
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtCash.Text) < Convert.ToDecimal(txtTotalOrder.Text))
                {
                    MessageBox.Show("Cash not less than to the total order.", "Print Receipt Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCash.Text = "";
                }
                else
                {
                    using (PrintReceiptForm frm = new PrintReceiptForm(productBindingSource.DataSource as List<Product>, string.Format("{0:n}", totalOrder), string.Format("{0:n}", txtCash.Text), string.Format("{0:n}", Convert.ToDecimal(txtCash.Text) - totalOrder), DateTime.Now.ToString("MM/dd/yyyy"), string.Format("{0}", lblStoreName.Text), this, string.Format("{0}", lblDiscountedNumber.Text)))
                    {
                        frm.ShowDialog();
                    }
                    txtCash.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid amount or money, not include a letter or word.", "Print Receipt Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCash.Text = "";
            }
            txtCash.Focus();
        }

        private void btnPrintTotalSales_Click(object sender, EventArgs e)
        {
            using (PrintTotalSalesForm frm = new PrintTotalSalesForm(productBindingSource.DataSource as List<Product>, string.Format("{0:n}", lblTotalSales.Text), DateTime.Now.ToString("MM/dd/yyyy"), string.Format("{0}", lblStoreName.Text), this))
            {
                frm.ShowDialog();
            }
            txtSearchProductLists.Focus();
        }

        private bool ValidateSaveForm()
        {
            bool output = true;

            decimal priceNumber = 0;
            bool priceValidNumber = decimal.TryParse(txtPrice.Text, out priceNumber);

            if (!priceValidNumber)
            {
                output = false;
                MessageBox.Show("Enter a valid amount or price and not include a letter or word.", "Price Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Text = "0.00";
            }
            else if (priceNumber <= 0)
            {
                output = false;
                MessageBox.Show("Price or amount not below zero and not include a letter or word.", "Price Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtProductName.Text.Length == 0)
            {                         
                output = false;
                MessageBox.Show("Enter name of the product.", "Product Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Text = "0.00";
            }
            txtProductName.Focus();
            return output;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateSaveForm())
            {
                Product obj = new Product();
                
                obj.SKU = txtSKU.Text.Trim();
                obj.ProductName = txtProductName.Text.Trim();
                obj.Price = decimal.Parse(txtPrice.Text.Trim());

                SqlConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));
                SqlCommand cmd = new SqlCommand("spSalesProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Insert");                
                cmd.Parameters.AddWithValue("@SKU", obj.SKU);
                cmd.Parameters.AddWithValue("@ProductName", obj.ProductName);
                cmd.Parameters.AddWithValue("@Price", obj.Price);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                Clear();
                FillDataGridView();

                MessageBox.Show("Saved successfully.", "Save Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Product!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    Product obj = new Product();
                    obj.Id = productId;

                    SqlConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));
                    SqlCommand cmd = new SqlCommand("spSalesProduct", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Delete");
                    cmd.Parameters.AddWithValue("@ID", obj.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    FillDataGridView();

                    txtSKU.Text = "";
                    txtProductName.Text = "";
                    txtPrice.Text = "0.00";

                    txtSKU.Focus();

                    MessageBox.Show("Deleted successfully.", "Delete Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));
                SqlCommand cmd = new SqlCommand("spSalesProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Update");
                cmd.Parameters.AddWithValue("@ID", productId);
                cmd.Parameters.AddWithValue("@SKU", txtSKU.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                FillDataGridView();

                txtSKU.Text = "";
                txtProductName.Text = "";
                txtPrice.Text = "0.00";

                txtSKU.Focus();

                btnSave.Enabled = false;

                MessageBox.Show("Updated successfully.", "Update Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();            
        }

        TotalSalesBLL sales = new TotalSalesBLL();
        TotalSalesDAL dal = new TotalSalesDAL();        

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                if (dgvOrderProductLists.RowCount != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Confirmed order?", "Customer Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        totalSales += totalOrder;

                        lblTotalSales.Text = string.Format("{0:n}", totalSales);

                        // To Database TotalSales Table - Insert
                        sales.TotalSales = lblTotalSales.Text;
                        sales.DatePurchased = DateTime.Now;
                        dal.Insert(sales);                        

                        dgvProductLists.Enabled = false;
                        btnAddProduct.Enabled = false;
                        txtSearchProductLists.Enabled = false;
                        txtQuantity.Enabled = false;
                        txtDiscount.Enabled = false;

                        btnPrintReceipt.Enabled = true;

                        txtCash.TabStop = true;

                        txtCash.Enabled = true;
                        txtCash.Focus();

                        btnRemove.Enabled = false;
                        btnConfirmOrder.Enabled = false;
                        btnCanceledOrder.Enabled = false;

                        // disabled button when confirm order
                        btnMinimize.Enabled = false;
                        btnShutdown.Enabled = false;
                        btnCalculator.Enabled = false;
                        btnContact.Enabled = false;
                        btnOpenSettings.Enabled = false;
                        btnPrintTotalSales.Enabled = false;
                    }
                    else
                    {
                        txtSearchProductLists.Focus();

                        txtCash.Enabled = false;
                    }
                }        
            }
            else
            {
                MessageBox.Show("Make sure you have an order product/s.", "Confirm Order Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchProductLists.Focus();
            }      
        }

        private void dgvProductLists_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvProductLists.CurrentRow.Index != -1)
                {
                    productId = Convert.ToInt32(dgvProductLists.CurrentRow.Cells[0].Value.ToString());
                    txtSKU.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                    txtProductName.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                    txtPrice.Text = dgvProductLists.CurrentRow.Cells[3].Value.ToString();
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnCancel.Enabled = true;

                    txtSKU.Focus();
                    btnSave.Enabled = false;

                    ptcbShortcutOnKeyboard.Hide();
                    gpbSettingsProduct.Enabled = true;

                    txtSKU.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "dgvProductLists_Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchProductLists_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                FillDataGridView();

                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductLists.CurrentRow.Index != -1)
                    {
                        txtSKU.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[3].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(txtSKU.Text) && !string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        Product obj = new Product() { SKU = txtSKU.Text, ProductName = txtProductName.Text, Price = Math.Round(Convert.ToDecimal(txtPrice.Text), 2), Quantity = Convert.ToInt32(txtQuantity.Text) };
                        List<Product> objList = productBindingSource.DataSource as List<Product>;

                        int quantity = 1;
                        int.TryParse(txtQuantity.Text, out quantity);

                        if (quantity == 0)
                        {
                            MessageBox.Show("Quantity not equal to zero and not include a letter or word.", "Quantity Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtQuantity.Text = "1";
                            return;
                        }

                        if (obj != null)
                        {
                            var existingProduct = objList.Where(x => x.SKU == obj.SKU).SingleOrDefault();
                            if (existingProduct != null)
                            {

                                existingProduct.Quantity += quantity;

                                productBindingSource.Insert(0, new Product());
                                productBindingSource.RemoveAt(0);
                            }
                            else
                            {
                                productBindingSource.Insert(0, new Product() { SKU = obj.SKU, ProductName = obj.ProductName, Price = Math.Round(obj.Price, 2) , Quantity = quantity });
                            }

                            totalOrder += obj.Price * obj.Quantity;
                            productBindingSource.MoveFirst();
                            txtSKU.Text = string.Empty;
                            txtProductName.Text = string.Empty;
                            txtPrice.Text = "0.00";
                            txtTotalOrder.Text = string.Format("{0:n}", totalOrder);

                            txtQuantity.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Search Product Lists KeyDown Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "1";
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                FillDataGridView();

                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductLists.CurrentRow.Index != -1)
                    {
                        txtSKU.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[3].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(txtSKU.Text) && !string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        Product obj = new Product() { SKU = txtSKU.Text, ProductName = txtProductName.Text, Price = Math.Round(Convert.ToDecimal(txtPrice.Text), 2), Quantity = Convert.ToInt32(txtQuantity.Text) };
                        List<Product> objList = productBindingSource.DataSource as List<Product>;

                        int quantity = 1;
                        int.TryParse(txtQuantity.Text, out quantity);

                        if (obj == null)
                        {
                            MessageBox.Show("Not in a list on that product.", "Product Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (obj != null)
                        {
                            var existingProduct = objList.Where(x => x.SKU == obj.SKU).SingleOrDefault();
                            if (existingProduct != null)
                            {

                                existingProduct.Quantity += quantity;

                                productBindingSource.Insert(0, new Product());
                                productBindingSource.RemoveAt(0);
                            }
                            else
                            {
                                productBindingSource.Insert(0, new Product() { SKU = obj.SKU, ProductName = obj.ProductName, Price = Math.Round(obj.Price, 2), Quantity = quantity });
                            }

                            totalOrder += obj.Price * obj.Quantity;
                            productBindingSource.MoveFirst();
                            txtSKU.Text = string.Empty;
                            txtProductName.Text = string.Empty;
                            txtPrice.Text = string.Empty;
                            txtTotalOrder.Text = string.Format("{0:n}", totalOrder);

                            txtSearchProductLists.Focus();

                            txtQuantity.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Quantity KeyDown Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "1";
                txtSearchProductLists.Focus();
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                FillDataGridView();

                if (e.KeyCode == Keys.Enter)
                {
                    // Display Discount
                    decimal.TryParse(lblDiscountedNumber.Text, out discountNumber);

                    discount = Convert.ToDecimal(txtDiscount.Text);
                    discountNumber += discount;
                    lblDiscountedNumber.Text = Convert.ToString(discountNumber);              

                    if (dgvProductLists.CurrentRow.Index != -1)
                    {
                        txtSKU.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[3].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(txtSKU.Text) && !string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        Product obj = new Product() { SKU = txtSKU.Text, ProductName = txtProductName.Text, Price = Math.Round(Convert.ToDecimal(txtPrice.Text), 2), Discount = Convert.ToDecimal(txtDiscount.Text) };
                        List<Product> objList = productBindingSource.DataSource as List<Product>;

                        decimal discount = 0;
                        decimal.TryParse(txtDiscount.Text, out discount);

                        int quantity = 0;
                        int.TryParse(txtQuantity.Text, out quantity);

                        if (obj == null)
                        {
                            MessageBox.Show("Not in a list on that product.", "Product Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (obj != null)
                        {
                            var existingProduct = objList.Where(x => x.SKU == obj.SKU).SingleOrDefault();
                            if (existingProduct != null)
                            {

                                existingProduct.Discount += discount;

                                productBindingSource.Insert(0, new Product());
                                productBindingSource.RemoveAt(0);
                            }
                            else
                            {
                                productBindingSource.Insert(0, new Product() { SKU = obj.SKU, ProductName = obj.ProductName, Price = Math.Round(obj.Price, 2), Discount = obj.Discount });
                            }

                            totalOrder += obj.Total;
                            productBindingSource.MoveFirst();
                            txtSKU.Text = string.Empty;
                            txtProductName.Text = string.Empty;
                            txtPrice.Text = string.Empty;
                            txtTotalOrder.Text = string.Format("{0:n}", totalOrder);                            

                            txtSearchProductLists.Focus();

                            txtDiscount.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Discount KeyDown Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Text = "0";
                txtSearchProductLists.Focus();
            }
        }

        private void dgvProductLists_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var column = dgvProductLists.Columns[e.ColumnIndex];
            if (column.Name == "Price")
            {
                var cell = dgvProductLists.Rows[e.RowIndex].Cells[e.ColumnIndex];
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

        private void Clear()
        {
            txtSKU.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "0.00";
            productId = 0;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSKU.Focus();

            this.AcceptButton = this.btnSave;
        }

        private void dgvProductLists_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                dgvProductLists.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datagridview Product Lists RowPrePaint Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductLists_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvProductLists.Rows)
                {
                    if (row.Index >= 0)
                    {
                        lblProductsCount.Text = String.Format("Products Count: {0}", row.Index + 1); 
                    }
                    else if(row.Index < 0)
                    {
                        lblProductsCount.Text = "Products Count: 0";
                    }
                }
            }
        }




        private void dgvOrderProductLists_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvOrderProductLists.CurrentRow.Index != -1)
            {
                dgvOrderProductLists.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {            
            txtSearchProductLists.TabStop = false;
            txtQuantity.TabStop = false;
            txtDiscount.TabStop = false;  

            txtSKU.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "0.00";
            productId = 0;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSKU.Focus();

            this.AcceptButton = this.btnSave;

            btnCancel.Enabled = true;

            txtCash.Enabled = false;
            btnConfirmOrder.Enabled = false;
            btnRemove.Enabled = false;
            btnCanceledOrder.Enabled = false;
            btnPrintReceipt.Enabled = false;            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please call or text at 0916-360-9855, if you have found a problem about the application. Thank you! ( Chiantine P. Manigos )", "Contact Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSearchProductLists.Focus();
        }

        private void btnStoreName_Click(object sender, EventArgs e)
        {
            StoreName frmStoreName = new StoreName(this);
            frmStoreName.Show();

            frmStoreName.FormClosed += FormClosed;            
        }

        new void FormClosed(object sender, FormClosedEventArgs e)
        {
            txtSearchProductLists.Focus();
        }

        private void txtSKU_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchSKU();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "txtSKU_TextChanged Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void txtSearchProductLists_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "txtSearchProductLists_TextChanged Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchProductLists_Enter(object sender, EventArgs e)
        {          
            ptcbShortcutOnKeyboard.Show();
            gpbSettingsProduct.Enabled = false;
            txtSearchProductLists.TabStop = true;
            txtQuantity.TabStop = true;
            txtDiscount.TabStop = true;

            btnConfirmOrder.Enabled = true;
            btnRemove.Enabled = true;
            btnCanceledOrder.Enabled = true;
            dgvProductLists.Enabled = true;
            btnAddProduct.Enabled = true;

            txtCash.Enabled = false;

            this.AcceptButton = null;

            ((TextBox)sender).SelectAll();

            this.dgvProductLists.Size = new Size(529, 3);
            lblProductsCount.Visible = false;

            btnOpenSettings.Show();
            btnLockSettings.Visible = false;
            btnTotalSalesZero.Visible = false;
            btnAddProduct.Visible = false;
            btnSalesProduct.Visible = false;
            btnStoreName.Visible = false;
            btnGenerateBarcode.Visible = false;
            dgvProductLists.RowHeadersVisible = false;
        }

        private void txtSearchProductLists_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtProductName_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtCash_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtCash_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(txtCash.Text, out cash);

            cash -= totalOrder;

            txtChange.Text = string.Format("{0:n}", cash);
        }        

        private void lblTotalSales_TextChanged(object sender, EventArgs e)
        {
            btnPrintTotalSales.Enabled = true;
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Convert.ToDecimal(txtCash.Text) < Convert.ToDecimal(txtTotalOrder.Text))
                    {
                        MessageBox.Show("Cash not less than to the total order.", "Cash Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCash.Text = "";
                    }
                    else
                    {
                        // enable button when TextBox Cash enter
                        btnMinimize.Enabled = true;
                        btnShutdown.Enabled = true;
                        btnCalculator.Enabled = true;
                        btnContact.Enabled = true;
                        btnOpenSettings.Enabled = true;
                        btnPrintTotalSales.Enabled = true;

                        using (SqlConnection con = new SqlConnection(GlobalConfig.CnnString(db)))
                        {
                            for (int i = 0; i < dgvOrderProductLists.Rows.Count; i++)
                            {
                                SqlCommand cmd = new SqlCommand(@"INSERT INTO Orders (SKU, ProductName, Price, Quantity, Total, DatePurchased) VALUES(@SKU, @ProductName, @Price, @Quantity, @Total, @DatePurchased)", con);

                                con.Open();
                                cmd.Parameters.AddWithValue("@SKU", dgvOrderProductLists.Rows[i].Cells[1].Value.ToString());
                                cmd.Parameters.AddWithValue("@ProductName", dgvOrderProductLists.Rows[i].Cells[2].Value.ToString());
                                cmd.Parameters.AddWithValue("@Price", dgvOrderProductLists.Rows[i].Cells[3].Value.ToString());
                                cmd.Parameters.AddWithValue("@Quantity", dgvOrderProductLists.Rows[i].Cells[4].Value.ToString());
                                cmd.Parameters.AddWithValue("@Total", dgvOrderProductLists.Rows[i].Cells[5].Value.ToString());
                                cmd.Parameters.AddWithValue("@DatePurchased", DateTime.Now.ToString("MM-dd-yyyy hh:mm tt"));
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }

                        productBindingSource.DataSource = null;
                        txtTotalOrder.Text = "0.00";
                        txtCash.Text = "0";
                        txtChange.Text = "0.00";

                        productBindingSource.DataSource = new List<Product>();

                        totalOrder = 0M;

                        txtSearchProductLists.Enabled = true;
                        txtQuantity.Enabled = true;
                        txtDiscount.Enabled = true;

                        btnPrintReceipt.Enabled = false;

                        discount = 0;
                        lblDiscountedNumber.Text = Convert.ToString(discount);

                        txtSearchProductLists.Focus();
                    }
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid amount or money, not include a letter or word.", "Cash Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCash.Text = "";
            }
        }

        private void txtSKU_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtSKU_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnSalesProduct_Click(object sender, EventArgs e)
        {
            DisplaySalesProductForm frm = new DisplaySalesProductForm();
            frm.Show();
            this.Hide();
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            PasswordSettingsForm frm = new PasswordSettingsForm(this);
            frm.Show();
        }

        private void btnLockSettings_Click(object sender, EventArgs e)
        {
            this.dgvProductLists.Size = new Size(529, 3);
            lblProductsCount.Visible = false;

            txtSearchProductLists.TabStop = true;
            txtQuantity.TabStop = true;
            txtDiscount.TabStop = true;

            btnOpenSettings.Show();
            btnLockSettings.Visible = false;
            btnTotalSalesZero.Visible = false;
            btnAddProduct.Visible = false;
            btnSalesProduct.Visible = false;
            btnStoreName.Visible = false;
            btnGenerateBarcode.Visible = false;
            dgvProductLists.RowHeadersVisible = false;

            ptcbShortcutOnKeyboard.Show();
            txtSearchProductLists.Focus();

            gpbTotalSales.Show();
        }

        public void LockSettings()
        {
            this.dgvProductLists.Size = new Size(529, 86);
            lblProductsCount.Visible = true;

            dgvProductLists.RowHeadersVisible = true;
            btnLockSettings.Visible = true;
            btnTotalSalesZero.Visible = true;
            btnAddProduct.Visible = true;
            btnSalesProduct.Visible = true;
            btnStoreName.Visible = true;
            btnGenerateBarcode.Visible = true;

            ptcbShortcutOnKeyboard.Hide();

            gpbSettingsProduct.Enabled = true;

            txtSKU.Focus();

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtSearchProductLists.Text = "";
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            GenerateBarcode frmGenerateBarcode = new GenerateBarcode();
            frmGenerateBarcode.Show();

            frmGenerateBarcode.FormClosed += FormClosed;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.Start("calc.exe");
                p.WaitForInputIdle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculatro error while opening!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtSearchProductLists.Focus();
        }

        private void dgvOrderProductLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderProductLists.CurrentRow.Index != -1)
            {
                txtSearchProductLists.Text = dgvOrderProductLists.CurrentRow.Cells[1].Value.ToString();
            }
            txtSearchProductLists.Focus();
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtSKU_KeyDown(object sender, KeyEventArgs e)
        {
            SearchSKU();

            if (e.KeyCode == Keys.Enter)
            {
                txtSKU_Enter(sender, e);
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (Regex.IsMatch(
                 txtCash.Text,
                 "^\\d*\\.\\d{2}$")) e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            txtSearchProductLists.Focus();
            this.WindowState = FormWindowState.Minimized;            
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                timerShutdown.Stop();
                Application.Exit();
            }
        }

        private void dgvOrderProductLists_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblPurchasedItems.Text = "Purchased Items: " + dgvOrderProductLists.Rows.Count.ToString();
        }

        private void dgvOrderProductLists_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblPurchasedItems.Text = "Purchased Items: " + dgvOrderProductLists.Rows.Count.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gpbTotalSales.Visible = true;
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            gpbTotalSales.Visible = false;
            btnHide.Visible = false;
            btnShow.Visible = true;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                timerShutdown.Start();
            }
        }
    }
}
