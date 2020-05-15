namespace PointOfSaleViewerForm
{
    partial class PointOfSaleViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSaleViewerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.dgvOrderProductLists = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvProductLists = new System.Windows.Forms.DataGridView();
            this.txtSearchProductLists = new System.Windows.Forms.TextBox();
            this.lblOrderLists = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.gpbHeader = new System.Windows.Forms.GroupBox();
            this.btnTotalSalesZero = new System.Windows.Forms.Button();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.btnLockSettings = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.pctrLock = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSalesProduct = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbSettingsProduct = new System.Windows.Forms.GroupBox();
            this.ptcbShortcutOnKeyboard = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gpbSettingsOrderProduct = new System.Windows.Forms.GroupBox();
            this.gpbTotalSales = new System.Windows.Forms.GroupBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnPrintTotalSales = new System.Windows.Forms.Button();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn871 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn872 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn873 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn874 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn875 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn876 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLists)).BeginInit();
            this.gpbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLock)).BeginInit();
            this.gpbSettingsProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShortcutOnKeyboard)).BeginInit();
            this.gpbSettingsOrderProduct.SuspendLayout();
            this.gpbTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrder.Location = new System.Drawing.Point(132, 19);
            this.txtTotalOrder.Multiline = true;
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(180, 50);
            this.txtTotalOrder.TabIndex = 2;
            this.txtTotalOrder.TabStop = false;
            this.txtTotalOrder.Text = "0.00";
            this.txtTotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCash.Location = new System.Drawing.Point(69, 96);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(57, 28);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Cash:";
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Enabled = false;
            this.txtCash.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(132, 75);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(180, 50);
            this.txtCash.TabIndex = 6;
            this.txtCash.TabStop = false;
            this.txtCash.Text = "0.00";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.Click += new System.EventHandler(this.txtCash_Click);
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.Enter += new System.EventHandler(this.txtCash_Enter);
            this.txtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblQuantity.Location = new System.Drawing.Point(451, 41);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 28);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(449, 72);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(92, 43);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(449, 14);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 60);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintReceipt.Enabled = false;
            this.btnPrintReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Image")));
            this.btnPrintReceipt.Location = new System.Drawing.Point(310, 74);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(247, 50);
            this.btnPrintReceipt.TabIndex = 5;
            this.btnPrintReceipt.TabStop = false;
            this.btnPrintReceipt.Text = "&Print Receipt";
            this.btnPrintReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // dgvOrderProductLists
            // 
            this.dgvOrderProductLists.AllowUserToAddRows = false;
            this.dgvOrderProductLists.AutoGenerateColumns = false;
            this.dgvOrderProductLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvOrderProductLists.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProductLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn871,
            this.sKUDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn872,
            this.dataGridViewTextBoxColumn873,
            this.dataGridViewTextBoxColumn874,
            this.dataGridViewTextBoxColumn875,
            this.dataGridViewTextBoxColumn876});
            this.dgvOrderProductLists.DataSource = this.productBindingSource;
            this.dgvOrderProductLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderProductLists.Location = new System.Drawing.Point(560, 72);
            this.dgvOrderProductLists.Name = "dgvOrderProductLists";
            this.dgvOrderProductLists.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProductLists.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderProductLists.Size = new System.Drawing.Size(785, 424);
            this.dgvOrderProductLists.TabIndex = 7;
            this.dgvOrderProductLists.TabStop = false;
            this.dgvOrderProductLists.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvOrderProductLists_RowPrePaint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(586, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvProductLists
            // 
            this.dgvProductLists.AllowUserToAddRows = false;
            this.dgvProductLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProductLists.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductLists.Location = new System.Drawing.Point(12, 125);
            this.dgvProductLists.Name = "dgvProductLists";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductLists.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductLists.RowHeadersVisible = false;
            this.dgvProductLists.Size = new System.Drawing.Size(529, 371);
            this.dgvProductLists.TabIndex = 8;
            this.dgvProductLists.TabStop = false;
            this.dgvProductLists.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductLists_CellFormatting);
            this.dgvProductLists.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProductLists_RowPrePaint);
            this.dgvProductLists.Click += new System.EventHandler(this.dgvProductLists_Click);
            // 
            // txtSearchProductLists
            // 
            this.txtSearchProductLists.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchProductLists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSearchProductLists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProductLists.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductLists.Location = new System.Drawing.Point(12, 72);
            this.txtSearchProductLists.Name = "txtSearchProductLists";
            this.txtSearchProductLists.Size = new System.Drawing.Size(431, 43);
            this.txtSearchProductLists.TabIndex = 0;
            this.txtSearchProductLists.Click += new System.EventHandler(this.txtSearchProductLists_Click);
            this.txtSearchProductLists.TextChanged += new System.EventHandler(this.txtSearchProductLists_TextChanged);
            this.txtSearchProductLists.Enter += new System.EventHandler(this.txtSearchProductLists_Enter);
            this.txtSearchProductLists.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchProductLists_KeyDown);
            // 
            // lblOrderLists
            // 
            this.lblOrderLists.AutoSize = true;
            this.lblOrderLists.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblOrderLists.Location = new System.Drawing.Point(556, 41);
            this.lblOrderLists.Name = "lblOrderLists";
            this.lblOrderLists.Size = new System.Drawing.Size(105, 28);
            this.lblOrderLists.TabIndex = 1;
            this.lblOrderLists.Text = "Order Lists";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTotalOrder.Location = new System.Drawing.Point(10, 39);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(114, 28);
            this.lblTotalOrder.TabIndex = 1;
            this.lblTotalOrder.Text = "Total Order:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(6, 28);
            this.txtTotalSales.Multiline = true;
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(181, 73);
            this.txtTotalSales.TabIndex = 2;
            this.txtTotalSales.TabStop = false;
            this.txtTotalSales.Text = "0.00";
            this.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalSales.TextChanged += new System.EventHandler(this.txtTotalSales_TextChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSearchProduct.Location = new System.Drawing.Point(7, 42);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(144, 28);
            this.lblSearchProduct.TabIndex = 1;
            this.lblSearchProduct.Text = "Search Product";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblChange.Location = new System.Drawing.Point(44, 151);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(82, 28);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.Control;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(132, 131);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(180, 50);
            this.txtChange.TabIndex = 2;
            this.txtChange.TabStop = false;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbHeader
            // 
            this.gpbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbHeader.Controls.Add(this.btnTotalSalesZero);
            this.gpbHeader.Controls.Add(this.btnOpenSettings);
            this.gpbHeader.Controls.Add(this.btnLockSettings);
            this.gpbHeader.Controls.Add(this.lblHeader);
            this.gpbHeader.Controls.Add(this.btnCalculator);
            this.gpbHeader.Controls.Add(this.btnContact);
            this.gpbHeader.Controls.Add(this.btnAddProduct);
            this.gpbHeader.Controls.Add(this.btnSalesProduct);
            this.gpbHeader.Controls.Add(this.pctrLock);
            this.gpbHeader.Location = new System.Drawing.Point(-4, -19);
            this.gpbHeader.Name = "gpbHeader";
            this.gpbHeader.Size = new System.Drawing.Size(1376, 64);
            this.gpbHeader.TabIndex = 9;
            this.gpbHeader.TabStop = false;
            // 
            // btnTotalSalesZero
            // 
            this.btnTotalSalesZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnTotalSalesZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnTotalSalesZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTotalSalesZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTotalSalesZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSalesZero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSalesZero.ForeColor = System.Drawing.Color.White;
            this.btnTotalSalesZero.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalSalesZero.Image")));
            this.btnTotalSalesZero.Location = new System.Drawing.Point(153, 22);
            this.btnTotalSalesZero.Name = "btnTotalSalesZero";
            this.btnTotalSalesZero.Size = new System.Drawing.Size(123, 37);
            this.btnTotalSalesZero.TabIndex = 18;
            this.btnTotalSalesZero.TabStop = false;
            this.btnTotalSalesZero.Text = "Total Sales Zero";
            this.btnTotalSalesZero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotalSalesZero.UseVisualStyleBackColor = false;
            this.btnTotalSalesZero.Visible = false;
            this.btnTotalSalesZero.Click += new System.EventHandler(this.btnTotalSalesZero_Click);
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnOpenSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnOpenSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpenSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSettings.ForeColor = System.Drawing.Color.White;
            this.btnOpenSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSettings.Image")));
            this.btnOpenSettings.Location = new System.Drawing.Point(1011, 22);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(118, 37);
            this.btnOpenSettings.TabIndex = 15;
            this.btnOpenSettings.TabStop = false;
            this.btnOpenSettings.Text = "&A. Settings";
            this.btnOpenSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenSettings.UseVisualStyleBackColor = false;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // btnLockSettings
            // 
            this.btnLockSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLockSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLockSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLockSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLockSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockSettings.ForeColor = System.Drawing.Color.White;
            this.btnLockSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnLockSettings.Image")));
            this.btnLockSettings.Location = new System.Drawing.Point(29, 22);
            this.btnLockSettings.Name = "btnLockSettings";
            this.btnLockSettings.Size = new System.Drawing.Size(118, 37);
            this.btnLockSettings.TabIndex = 17;
            this.btnLockSettings.TabStop = false;
            this.btnLockSettings.Text = "&Lock Settings";
            this.btnLockSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLockSettings.UseVisualStyleBackColor = false;
            this.btnLockSettings.Visible = false;
            this.btnLockSettings.Click += new System.EventHandler(this.btnLockSettings_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeader.Location = new System.Drawing.Point(299, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(501, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "AMARA\'s Agrivet and General Merchandise";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(1264, 20);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(99, 41);
            this.btnCalculator.TabIndex = 13;
            this.btnCalculator.TabStop = false;
            this.btnCalculator.Text = "Calcula&tor";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.Location = new System.Drawing.Point(1176, 20);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(90, 41);
            this.btnContact.TabIndex = 14;
            this.btnContact.TabStop = false;
            this.btnContact.Text = "Co&ntact";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // pctrLock
            // 
            this.pctrLock.Location = new System.Drawing.Point(970, 20);
            this.pctrLock.Name = "pctrLock";
            this.pctrLock.Size = new System.Drawing.Size(193, 41);
            this.pctrLock.TabIndex = 12;
            this.pctrLock.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(967, 20);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(111, 41);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSalesProduct
            // 
            this.btnSalesProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSalesProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSalesProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalesProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalesProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesProduct.ForeColor = System.Drawing.Color.White;
            this.btnSalesProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesProduct.Image")));
            this.btnSalesProduct.Location = new System.Drawing.Point(1080, 20);
            this.btnSalesProduct.Name = "btnSalesProduct";
            this.btnSalesProduct.Size = new System.Drawing.Size(83, 41);
            this.btnSalesProduct.TabIndex = 12;
            this.btnSalesProduct.TabStop = false;
            this.btnSalesProduct.Text = "Product";
            this.btnSalesProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesProduct.UseVisualStyleBackColor = false;
            this.btnSalesProduct.Click += new System.EventHandler(this.btnSalesProduct_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblProductName.Location = new System.Drawing.Point(6, 57);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 28);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(154, 56);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(367, 29);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Click += new System.EventHandler(this.txtProductName_Click);
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrice.Location = new System.Drawing.Point(90, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 28);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(154, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(367, 43);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(65, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(170, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(418, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gpbSettingsProduct
            // 
            this.gpbSettingsProduct.Controls.Add(this.txtPrice);
            this.gpbSettingsProduct.Controls.Add(this.txtSKU);
            this.gpbSettingsProduct.Controls.Add(this.lblSKU);
            this.gpbSettingsProduct.Controls.Add(this.btnSave);
            this.gpbSettingsProduct.Controls.Add(this.btnDelete);
            this.gpbSettingsProduct.Controls.Add(this.btnEdit);
            this.gpbSettingsProduct.Controls.Add(this.btnCancel);
            this.gpbSettingsProduct.Controls.Add(this.lblProductName);
            this.gpbSettingsProduct.Controls.Add(this.txtProductName);
            this.gpbSettingsProduct.Controls.Add(this.lblPrice);
            this.gpbSettingsProduct.Controls.Add(this.ptcbShortcutOnKeyboard);
            this.gpbSettingsProduct.Enabled = false;
            this.gpbSettingsProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbSettingsProduct.Location = new System.Drawing.Point(14, 502);
            this.gpbSettingsProduct.Name = "gpbSettingsProduct";
            this.gpbSettingsProduct.Size = new System.Drawing.Size(527, 190);
            this.gpbSettingsProduct.TabIndex = 10;
            this.gpbSettingsProduct.TabStop = false;
            this.gpbSettingsProduct.Text = "Product Name / Price / Save Product / Edit / Delete / Cancel";
            // 
            // ptcbShortcutOnKeyboard
            // 
            this.ptcbShortcutOnKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("ptcbShortcutOnKeyboard.Image")));
            this.ptcbShortcutOnKeyboard.Location = new System.Drawing.Point(0, 0);
            this.ptcbShortcutOnKeyboard.Name = "ptcbShortcutOnKeyboard";
            this.ptcbShortcutOnKeyboard.Size = new System.Drawing.Size(527, 192);
            this.ptcbShortcutOnKeyboard.TabIndex = 6;
            this.ptcbShortcutOnKeyboard.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(294, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 45);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Update";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gpbSettingsOrderProduct
            // 
            this.gpbSettingsOrderProduct.Controls.Add(this.gpbTotalSales);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblTotalOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblChange);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblCash);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtTotalOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnExit);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtChange);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtCash);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnConfirmOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnRemove);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnPrintTotalSales);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnPrintReceipt);
            this.gpbSettingsOrderProduct.Location = new System.Drawing.Point(561, 502);
            this.gpbSettingsOrderProduct.Name = "gpbSettingsOrderProduct";
            this.gpbSettingsOrderProduct.Size = new System.Drawing.Size(785, 190);
            this.gpbSettingsOrderProduct.TabIndex = 11;
            this.gpbSettingsOrderProduct.TabStop = false;
            // 
            // gpbTotalSales
            // 
            this.gpbTotalSales.Controls.Add(this.txtTotalSales);
            this.gpbTotalSales.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbTotalSales.Location = new System.Drawing.Point(586, 17);
            this.gpbTotalSales.Name = "gpbTotalSales";
            this.gpbTotalSales.Size = new System.Drawing.Size(193, 107);
            this.gpbTotalSales.TabIndex = 12;
            this.gpbTotalSales.TabStop = false;
            this.gpbTotalSales.Text = "Total Sales";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmOrder.Image")));
            this.btnConfirmOrder.Location = new System.Drawing.Point(316, 14);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(127, 60);
            this.btnConfirmOrder.TabIndex = 4;
            this.btnConfirmOrder.TabStop = false;
            this.btnConfirmOrder.Text = "Confirm &Order";
            this.btnConfirmOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnPrintTotalSales
            // 
            this.btnPrintTotalSales.BackColor = System.Drawing.Color.White;
            this.btnPrintTotalSales.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintTotalSales.Enabled = false;
            this.btnPrintTotalSales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintTotalSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintTotalSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTotalSales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTotalSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintTotalSales.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTotalSales.Image")));
            this.btnPrintTotalSales.Location = new System.Drawing.Point(310, 123);
            this.btnPrintTotalSales.Name = "btnPrintTotalSales";
            this.btnPrintTotalSales.Size = new System.Drawing.Size(297, 61);
            this.btnPrintTotalSales.TabIndex = 5;
            this.btnPrintTotalSales.TabStop = false;
            this.btnPrintTotalSales.Text = "Print Total &Sales";
            this.btnPrintTotalSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintTotalSales.UseVisualStyleBackColor = false;
            this.btnPrintTotalSales.Click += new System.EventHandler(this.btnPrintTotalSales_Click);
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSKU.Location = new System.Drawing.Point(95, 24);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(53, 28);
            this.lblSKU.TabIndex = 7;
            this.lblSKU.Text = "SKU:";
            // 
            // txtSKU
            // 
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSKU.Location = new System.Drawing.Point(154, 23);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(367, 29);
            this.txtSKU.TabIndex = 8;
            // 
            // productBindingSource
            // 
            // 
            // dataGridViewTextBoxColumn871
            // 
            this.dataGridViewTextBoxColumn871.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn871.HeaderText = "Id";
            this.dataGridViewTextBoxColumn871.Name = "dataGridViewTextBoxColumn871";
            this.dataGridViewTextBoxColumn871.ReadOnly = true;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn872
            // 
            this.dataGridViewTextBoxColumn872.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn872.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn872.Name = "dataGridViewTextBoxColumn872";
            this.dataGridViewTextBoxColumn872.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn873
            // 
            this.dataGridViewTextBoxColumn873.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn873.HeaderText = "Price";
            this.dataGridViewTextBoxColumn873.Name = "dataGridViewTextBoxColumn873";
            this.dataGridViewTextBoxColumn873.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn874
            // 
            this.dataGridViewTextBoxColumn874.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn874.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn874.Name = "dataGridViewTextBoxColumn874";
            this.dataGridViewTextBoxColumn874.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn875
            // 
            this.dataGridViewTextBoxColumn875.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn875.HeaderText = "Total";
            this.dataGridViewTextBoxColumn875.Name = "dataGridViewTextBoxColumn875";
            this.dataGridViewTextBoxColumn875.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn876
            // 
            this.dataGridViewTextBoxColumn876.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn876.HeaderText = "Date";
            this.dataGridViewTextBoxColumn876.Name = "dataGridViewTextBoxColumn876";
            this.dataGridViewTextBoxColumn876.ReadOnly = true;
            // 
            // PointOfSaleViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1361, 704);
            this.Controls.Add(this.gpbSettingsOrderProduct);
            this.Controls.Add(this.gpbSettingsProduct);
            this.Controls.Add(this.gpbHeader);
            this.Controls.Add(this.dgvProductLists);
            this.Controls.Add(this.dgvOrderProductLists);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.lblOrderLists);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtSearchProductLists);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PointOfSaleViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMARA\'s Agrivet and General Merchandise [ Point of Sale ]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PointOfSaleViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLists)).EndInit();
            this.gpbHeader.ResumeLayout(false);
            this.gpbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLock)).EndInit();
            this.gpbSettingsProduct.ResumeLayout(false);
            this.gpbSettingsProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShortcutOnKeyboard)).EndInit();
            this.gpbSettingsOrderProduct.ResumeLayout(false);
            this.gpbSettingsOrderProduct.PerformLayout();
            this.gpbTotalSales.ResumeLayout(false);
            this.gpbTotalSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dgvOrderProductLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridView dgvProductLists;
        private System.Windows.Forms.TextBox txtSearchProductLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.Label lblOrderLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.GroupBox gpbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gpbSettingsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn150;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn151;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn152;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn153;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn154;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn155;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn156;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn157;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn158;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn159;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn160;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn161;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn162;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn163;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn164;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn165;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn166;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn167;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn168;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn169;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn170;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn171;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn172;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn173;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn174;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn175;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn176;
        private System.Windows.Forms.GroupBox gpbSettingsOrderProduct;
        private System.Windows.Forms.GroupBox gpbTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn177;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn178;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn179;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn180;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn184;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn185;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn186;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn187;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn188;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn189;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn191;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn192;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn193;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn194;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn195;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn196;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn199;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn200;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn201;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn202;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn203;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn204;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn205;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn206;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn207;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn208;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn209;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn210;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn211;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn212;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn213;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn214;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn215;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn216;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn217;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn218;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn219;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn220;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn221;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn222;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn223;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn224;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn225;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn226;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn227;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn228;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn229;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn230;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn231;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn232;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn233;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn234;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn235;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn236;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn237;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn238;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn239;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn240;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn241;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn242;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn243;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn244;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn245;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn246;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn247;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn248;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn249;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn250;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn251;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn252;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn253;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn254;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn255;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn256;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn257;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn258;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn259;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn260;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn261;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn262;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn263;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn264;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn265;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn266;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn267;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn268;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn269;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn270;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn271;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn272;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn273;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn274;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn275;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn276;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn277;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn278;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn279;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn280;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn281;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn282;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn283;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn284;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn285;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn286;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn287;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn288;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn289;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn290;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn291;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn292;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn293;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn294;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn295;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn296;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn297;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn298;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn299;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn300;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn301;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn302;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn303;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn304;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn305;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn306;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn307;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn308;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn309;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn310;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn311;
        private System.Windows.Forms.Button btnPrintTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn312;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn313;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn314;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn315;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn316;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn317;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn318;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn319;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn320;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn321;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn322;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn323;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn324;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn325;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn326;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn327;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn328;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn329;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn330;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn331;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn332;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn333;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn334;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn335;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn336;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn337;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn338;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn339;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn340;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn341;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn342;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn343;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn344;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn345;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn346;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn347;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn348;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn349;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn350;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn351;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn352;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn353;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn354;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn355;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn356;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn357;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn358;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn359;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn360;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn361;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn362;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn363;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn364;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn365;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn366;
        private System.Windows.Forms.PictureBox ptcbShortcutOnKeyboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn367;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn368;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn369;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn370;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn371;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn372;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn373;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn374;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn375;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn376;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn377;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn378;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn379;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn380;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn381;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn382;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn383;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn384;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn385;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn386;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn387;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn388;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn389;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn390;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn391;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn392;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn393;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn394;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn395;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn396;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn397;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn398;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn399;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn400;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn401;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn402;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn403;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn404;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn405;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn406;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn407;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn408;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn409;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn410;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn411;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn412;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn413;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn414;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn415;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn416;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn417;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn418;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn419;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn420;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn421;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn422;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn423;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn424;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn425;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn426;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn427;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn428;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn429;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn430;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn431;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn432;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn433;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn434;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn435;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn436;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn437;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn438;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn439;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn440;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn441;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn442;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn443;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn444;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn445;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn446;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn447;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn448;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn449;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn450;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn451;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn452;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn453;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn454;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn455;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn456;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn457;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn458;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn459;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn460;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn461;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn462;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn463;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn464;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn465;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn466;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn467;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn468;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn469;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn470;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn471;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn472;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn473;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn474;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn475;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn476;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn477;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn478;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn479;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn480;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn481;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn482;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn483;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn484;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn485;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn486;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn487;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn488;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn489;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn490;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn491;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn492;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn493;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn494;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn495;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn496;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn497;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn498;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn499;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn500;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn501;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn502;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn503;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn504;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn505;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn506;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn507;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn508;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn509;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn510;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn511;
        private System.Windows.Forms.Button btnSalesProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn512;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn513;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn514;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn515;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn516;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn517;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn518;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn519;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn520;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn521;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn522;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn523;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn524;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn525;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn526;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn527;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn528;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn529;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn530;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn531;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn532;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn533;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn534;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn535;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn536;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn537;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn538;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn539;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn540;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn541;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn542;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn543;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn544;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn545;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn546;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn547;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn548;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn549;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn550;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn551;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn552;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn553;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn554;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn555;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn556;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn557;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn558;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn559;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn560;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn561;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn562;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn563;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn564;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn565;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn566;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn567;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn568;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn569;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn570;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn571;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn572;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn573;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn574;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn575;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn576;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn577;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn578;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn579;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn580;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn581;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn582;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn583;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn584;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn585;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn586;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn587;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn588;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn589;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn590;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn591;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn592;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn593;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn594;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn595;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn596;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn597;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn598;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn599;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn600;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn601;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn602;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn603;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn604;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn605;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn606;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn607;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn608;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn609;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn610;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn611;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn612;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn613;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn614;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn615;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn616;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn617;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn618;
        private System.Windows.Forms.Button btnOpenSettings;
        private System.Windows.Forms.PictureBox pctrLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn619;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn620;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn621;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn622;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn623;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn624;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn625;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn626;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn627;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn628;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn629;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn630;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn631;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn632;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn633;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn634;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn635;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn636;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn637;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn638;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn639;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn640;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn641;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn642;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn643;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn644;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn645;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn646;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn647;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn648;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn649;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn650;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn651;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn652;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn653;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn654;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn655;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn656;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn657;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn658;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn659;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn660;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn661;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn662;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn663;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn664;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn665;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn666;
        private System.Windows.Forms.Button btnLockSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn667;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn668;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn669;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn670;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn671;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn672;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn673;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn674;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn675;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn676;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn677;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn678;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn679;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn680;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn681;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn682;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn683;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn684;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn685;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn686;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn687;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn688;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn689;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn690;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn691;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn692;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn693;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn694;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn695;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn696;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn697;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn698;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn699;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn700;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn701;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn702;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn703;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn704;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn705;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn706;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn707;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn708;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn709;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn710;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn711;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn712;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn713;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn714;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn715;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn716;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn717;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn718;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn719;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn720;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn721;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn722;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn723;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn724;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn725;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn726;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn727;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn728;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn729;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn730;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn731;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn732;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn733;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn734;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn735;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn736;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn737;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn738;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn739;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn740;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn741;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn742;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn743;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn744;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn745;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn746;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn747;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn748;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn749;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn750;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn751;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn752;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn753;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn754;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn755;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn756;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn757;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn758;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn759;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn760;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn761;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn762;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn763;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn764;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn765;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn766;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn767;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn768;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn769;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn770;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn771;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn772;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn773;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn774;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn775;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn776;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn777;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn778;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn779;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn780;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn781;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn782;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn783;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn784;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn785;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn786;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn787;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn788;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn789;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn790;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn791;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn792;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn793;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn794;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn795;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn796;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn797;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn798;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn799;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn800;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn801;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn802;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn803;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn804;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn805;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn806;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn807;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn808;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn809;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn810;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn811;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn812;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn813;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn814;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn815;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn816;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn817;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn818;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn819;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn820;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn821;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn822;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn823;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn824;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn825;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn826;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn827;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn828;
        private System.Windows.Forms.Button btnTotalSalesZero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn829;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn830;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn831;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn832;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn833;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn834;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn835;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn836;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn837;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn838;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn839;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn840;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn841;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn842;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn843;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn844;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn845;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn846;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn847;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn848;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn849;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn850;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn851;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn852;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn853;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn854;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn855;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn856;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn857;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn858;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn859;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn860;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn861;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn862;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn863;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn864;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn865;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn866;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn867;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn868;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn869;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn870;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn871;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn872;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn873;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn874;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn875;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn876;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}

