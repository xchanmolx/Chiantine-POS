using Dapper;
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

namespace PointOfSaleViewerForm
{
    public partial class PointOfSaleViewerForm : Form
    {
        private const string db = "POS";
        int productId = 0;
        decimal totalOrder = 0M;
        decimal totalSales = 0M;
        decimal cash = 0M;

        public PointOfSaleViewerForm()
        {
            InitializeComponent();

            dgvProductLists.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvProductLists.EnableHeadersVisualStyles = false;

            dgvOrderProductLists.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvOrderProductLists.EnableHeadersVisualStyles = false;

            dal.DeleteAllTotalSalesPastDay();
        }

        private void FillDataGridView()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@txtSearch", txtSearchProductLists.Text.Trim());

                List<Product> products = connection.Query<Product>("spProduct_GetAllOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Product>();

                dgvProductLists.DataSource = products;

                dgvProductLists.Columns[0].Visible = false;
                dgvProductLists.Columns[1].Width = 120;     // SKU
                dgvProductLists.Columns[2].Width = 305;     // Product Name
                dgvProductLists.Columns[3].Width = 100;     // Price
                dgvProductLists.Columns[4].Visible = false; // Quantity
                dgvProductLists.Columns[5].Visible = false; // Total
                dgvProductLists.Columns[6].Visible = false; // Date

                dgvOrderProductLists.Columns[0].Visible = false; // Id
                dgvOrderProductLists.Columns[1].Width = 120;     // SKU
                dgvOrderProductLists.Columns[2].Width = 322;     // Product Name
                dgvOrderProductLists.Columns[3].Width = 100;     // Price
                dgvOrderProductLists.Columns[4].Width = 80;      // Quantity
                dgvOrderProductLists.Columns[5].Width = 120;     // Total
                dgvOrderProductLists.Columns[6].Visible = false; // Date


                dgvProductLists.Columns[1].HeaderText = "SKU";
                dgvOrderProductLists.Columns[1].HeaderText = "SKU";
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
                    txtTotalSales.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btnTotalSalesZero_Click Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PointOfSaleViewerForm_Load(object sender, EventArgs e)
        {
            try
            {
                dal.DeleteAllTotalSalesPastDay();

                Clear();
                FillDataGridView();

                productBindingSource.DataSource = new List<Product>(); // Init empty list               

                SqlConnection con = new SqlConnection(GlobalConfig.CnnString(db));
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TotalSales FROM TotalSales", con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    txtTotalSales.Text = reader.GetString(0);
                }

                totalSales += Convert.ToDecimal(txtTotalSales.Text);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form Load Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                totalOrder -= obj.Price * obj.Quantity;
                txtTotalOrder.Text = string.Format("{0:n}", totalOrder);

                productBindingSource.RemoveCurrent();
            }
            else // if (obj == null)
            {
                MessageBox.Show("Select on order list to remove an item.", "Remove Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            using (PrintReceiptForm frm = new PrintReceiptForm(productBindingSource.DataSource as List<Product>, string.Format("{0:n}", totalOrder), string.Format("{0:n}", txtCash.Text), string.Format("{0:n}", Convert.ToDecimal(txtCash.Text) - totalOrder), DateTime.Now.ToString("MM/dd/yyyy")))
            {
                frm.ShowDialog();
            }        
            txtCash.Focus();
        }

        private void btnPrintTotalSales_Click(object sender, EventArgs e)
        {
            using (PrintTotalSalesForm frm = new PrintTotalSalesForm(productBindingSource.DataSource as List<Product>, string.Format("{0:n}", txtTotalSales.Text), DateTime.Now.ToString("MM/dd/yyyy")))
            {
                frm.ShowDialog();
            }
            txtCash.Focus();
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

                obj.Id = productId;
                obj.SKU = txtSKU.Text.Trim();
                obj.ProductName = txtProductName.Text.Trim();
                obj.Price = decimal.Parse(txtPrice.Text.Trim());

                SqlConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db));
                SqlCommand cmd = new SqlCommand("spSalesProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Insert");
                cmd.Parameters.AddWithValue("@ID", obj.Id);
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

                    Clear();
                    FillDataGridView();

                    btnSave.Enabled = false;
                    ptcbShortcutOnKeyboard.Show();
                    txtSearchProductLists.Focus();

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
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                Clear();
                FillDataGridView();

                btnSave.Enabled = false;
                ptcbShortcutOnKeyboard.Show();
                txtSearchProductLists.Focus();

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
        int id = 1;

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderProductLists.RowCount != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Confirmed order?", "Customer Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    totalSales += totalOrder;

                    txtTotalSales.Text = string.Format("{0:n}", totalSales);

                    // To Database TotalSales Table - Insert
                    sales.TotalSales = txtTotalSales.Text;
                    sales.DatePurchased = DateTime.Now;
                    dal.Insert(sales);

                    //// To Database TotalSales Table - Update
                    //sales.Id = id;
                    //sales.TotalSales = txtTotalSales.Text;
                    //dal.Update(sales);

                    dgvProductLists.Enabled = false;
                    btnAddProduct.Enabled = false;                    
                    txtSearchProductLists.Enabled = false;
                    txtQuantity.Enabled = false;

                    btnPrintReceipt.Enabled = true;

                    txtCash.TabStop = true;

                    txtCash.Enabled = true;
                    txtCash.Focus();

                    btnRemove.Enabled = false;
                    btnConfirmOrder.Enabled = false;
                }
                else
                {
                    txtSearchProductLists.Focus();

                    txtCash.Enabled = false;
                }
            }
        }

        private void dgvProductLists_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductLists.Columns[1].ValueType == dgvProductLists.SelectedCells[0].ValueType)
                {
                    txtSearchProductLists.Text = dgvProductLists.SelectedCells[0].Value.ToString();
                    txtSearchProductLists.Focus();
                }
                else if (dgvProductLists.Columns[2].ValueType == dgvProductLists.SelectedCells[0].ValueType)
                {
                    MessageBox.Show("Sorry, not allowed to edit.", "Unauthorized!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dgvProductLists.CurrentRow.Index != -1)
                    {
                        productId = Convert.ToInt32(dgvProductLists.CurrentRow.Cells[0].Value.ToString());
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtProductName.Focus();
                        btnSave.Enabled = false;

                        ptcbShortcutOnKeyboard.Hide();
                        gpbSettingsProduct.Enabled = true;

                        txtProductName.Focus();
                    }
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
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        Product obj = new Product() { ProductName = txtProductName.Text, Price = Math.Round(Convert.ToDecimal(txtPrice.Text), 2), Quantity = Convert.ToInt32(txtQuantity.Text) };
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
                            var existingProduct = objList.Where(x => x.ProductName == obj.ProductName).SingleOrDefault();
                            if (existingProduct != null)
                            {

                                existingProduct.Quantity += quantity;

                                productBindingSource.Insert(0, new Product());
                                productBindingSource.RemoveAt(0);
                            }
                            else
                            {
                                productBindingSource.Insert(0, new Product() { ProductName = obj.ProductName, Price = Math.Round(obj.Price, 2) , Quantity = quantity });
                            }

                            totalOrder += obj.Price * obj.Quantity;
                            productBindingSource.MoveFirst();
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
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductLists.CurrentRow.Index != -1)
                    {
                        txtProductName.Text = dgvProductLists.CurrentRow.Cells[1].Value.ToString();
                        txtPrice.Text = dgvProductLists.CurrentRow.Cells[2].Value.ToString();
                    }

                    if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        Product obj = new Product() { ProductName = txtProductName.Text, Price = Math.Round(Convert.ToDecimal(txtPrice.Text), 2), Quantity = Convert.ToInt32(txtQuantity.Text) };
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
                            var existingProduct = objList.Where(x => x.ProductName == obj.ProductName).SingleOrDefault();
                            if (existingProduct != null)
                            {

                                existingProduct.Quantity += quantity;

                                productBindingSource.Insert(0, new Product());
                                productBindingSource.RemoveAt(0);
                            }
                            else
                            {
                                productBindingSource.Insert(0, new Product() { ProductName = obj.ProductName, Price = Math.Round(obj.Price, 2), Quantity = quantity });
                            }

                            totalOrder += obj.Price * obj.Quantity;
                            productBindingSource.MoveFirst();
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
            txtProductName.Text = "";
            txtPrice.Text = "0.00";
            productId = 0;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSKU.Focus();
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

        private void dgvOrderProductLists_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvOrderProductLists.CurrentRow.Index != -1)
            {
                dgvOrderProductLists.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ptcbShortcutOnKeyboard.Hide();
            gpbSettingsProduct.Enabled = true;
            txtSKU.Focus();
            txtSearchProductLists.TabStop = false;
            txtQuantity.TabStop = false;

            txtProductName.Text = "";
            txtPrice.Text = "0.00";

            txtCash.Enabled = false;
            btnConfirmOrder.Enabled = false;
            btnRemove.Enabled = false;
            btnPrintReceipt.Enabled = false;
            dgvOrderProductLists.Enabled = false;

            this.AcceptButton = this.btnSave;
            this.btnSave.Enabled = true;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please call or text at 0916-360-9855, if you have found a problem about the application. Thank you! ( Chiantine P. Manigos )", "Contact Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
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

            btnConfirmOrder.Enabled = true;
            btnRemove.Enabled = true;
            dgvProductLists.Enabled = true;
            btnAddProduct.Enabled = true;

            txtCash.Enabled = false;

            this.AcceptButton = null;

            ((TextBox)sender).SelectAll();
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

        private bool ValidateCashForm()
        {
            bool output = true;

            bool cashValidNumber = decimal.TryParse(txtCash.Text, out cash);

            if (!cashValidNumber)
            {
                output = false;
                MessageBox.Show("Enter a valid amount or money, not include a letter or word.", "Cash Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCash.Text = "0.00";
            }

            return output;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(txtCash.Text, out cash);

            cash -= totalOrder;

            txtChange.Text = string.Format("{0:n}", cash);
        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {
            btnPrintTotalSales.Enabled = true;
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection con = new SqlConnection(GlobalConfig.CnnString(db)))
                {
                    for (int i = 0; i < dgvOrderProductLists.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO Orders (ProductName, Price, Quantity, Total, DatePurchased) VALUES(@ProductName, @Price, @Quantity, @Total, @DatePurchased)", con);

                        con.Open();
                        cmd.Parameters.AddWithValue("@ProductName", dgvOrderProductLists.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@Price", dgvOrderProductLists.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", dgvOrderProductLists.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@Total", dgvOrderProductLists.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@DatePurchased", DateTime.Now.ToString("MM-dd-yyyy hh:mm tt"));
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    //dgvOrderProductLists.Rows.Clear();
                }

                if (ValidateCashForm())
                {
                    if (Convert.ToDecimal(txtCash.Text) < Convert.ToDecimal(txtTotalOrder.Text))
                    {
                        MessageBox.Show("Cash not less than to the total order.", "Cash Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCash.Text = "0.00";
                    }
                    else
                    {
                        productBindingSource.DataSource = null;
                        txtTotalOrder.Text = "0.00";
                        txtCash.Text = "0.00";
                        txtChange.Text = "0.00";

                        productBindingSource.DataSource = new List<Product>();

                        totalOrder = 0M;

                        txtSearchProductLists.Enabled = true;
                        txtQuantity.Enabled = true;

                        btnPrintReceipt.Enabled = false;

                        txtSearchProductLists.Focus();
                    } 
                }
            }     
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
            btnOpenSettings.Show();
            pctrLock.Show();
            btnLockSettings.Visible = false;
            btnTotalSalesZero.Visible = false;
            dgvProductLists.RowHeadersVisible = false;
        }

        public void LockSettings()
        {
            btnOpenSettings.Hide();
            pctrLock.Hide();
            dgvProductLists.RowHeadersVisible = true;
            btnLockSettings.Visible = true;
            btnTotalSalesZero.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            else
            {
                txtSearchProductLists.Focus();
            }
        }
    }
}
