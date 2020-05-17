namespace PointOfSaleViewerForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.dgvProductLists = new System.Windows.Forms.DataGridView();
            this.txtSearchProductLists = new System.Windows.Forms.TextBox();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblSKUProduct = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.gpbHeader = new System.Windows.Forms.GroupBox();
            this.pictureBoxCMLogo = new System.Windows.Forms.PictureBox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblPointOfSale = new System.Windows.Forms.Label();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.btnTotalSalesZero = new System.Windows.Forms.Button();
            this.btnLockSettings = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnSalesProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbSettingsProduct = new System.Windows.Forms.GroupBox();
            this.ptcbShortcutOnKeyboard = new System.Windows.Forms.PictureBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gpbSettingsOrderProduct = new System.Windows.Forms.GroupBox();
            this.btnCanceledOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.gpbTotalSales = new System.Windows.Forms.GroupBox();
            this.btnPrintTotalSales = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLists)).BeginInit();
            this.gpbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMLogo)).BeginInit();
            this.gpbSettingsProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShortcutOnKeyboard)).BeginInit();
            this.gpbSettingsOrderProduct.SuspendLayout();
            this.gpbTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrder.Location = new System.Drawing.Point(157, 18);
            this.txtTotalOrder.Multiline = true;
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(240, 50);
            this.txtTotalOrder.TabIndex = 2;
            this.txtTotalOrder.TabStop = false;
            this.txtTotalOrder.Text = "0.00";
            this.txtTotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCash.Location = new System.Drawing.Point(77, 80);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(73, 32);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Cash:";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Enabled = false;
            this.txtCash.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(157, 74);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(240, 50);
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
            this.lblQuantity.Location = new System.Drawing.Point(725, 41);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(88, 28);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(723, 72);
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
            this.btnRemove.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(605, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(192, 65);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "&Remove Order";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrintReceipt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintReceipt.Enabled = false;
            this.btnPrintReceipt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintReceipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Image")));
            this.btnPrintReceipt.Location = new System.Drawing.Point(403, 123);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(394, 58);
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
            this.dgvOrderProductLists.AllowUserToDeleteRows = false;
            this.dgvOrderProductLists.AutoGenerateColumns = false;
            this.dgvOrderProductLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvOrderProductLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dgvOrderProductLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sKUDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvOrderProductLists.DataSource = this.productBindingSource;
            this.dgvOrderProductLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderProductLists.Location = new System.Drawing.Point(11, 121);
            this.dgvOrderProductLists.Name = "dgvOrderProductLists";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProductLists.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderProductLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderProductLists.Size = new System.Drawing.Size(804, 439);
            this.dgvOrderProductLists.TabIndex = 7;
            this.dgvOrderProductLists.TabStop = false;
            this.dgvOrderProductLists.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvOrderProductLists_RowPrePaint);
            // 
            // dgvProductLists
            // 
            this.dgvProductLists.AllowUserToAddRows = false;
            this.dgvProductLists.AllowUserToDeleteRows = false;
            this.dgvProductLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProductLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dgvProductLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductLists.Location = new System.Drawing.Point(821, 425);
            this.dgvProductLists.Name = "dgvProductLists";
            this.dgvProductLists.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductLists.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductLists.RowHeadersVisible = false;
            this.dgvProductLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductLists.Size = new System.Drawing.Size(529, 3);
            this.dgvProductLists.TabIndex = 8;
            this.dgvProductLists.TabStop = false;
            this.dgvProductLists.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductLists_CellFormatting);
            this.dgvProductLists.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProductLists_RowPrePaint);
            this.dgvProductLists.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductLists_RowsAdded);
            this.dgvProductLists.Click += new System.EventHandler(this.dgvProductLists_Click);
            // 
            // txtSearchProductLists
            // 
            this.txtSearchProductLists.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchProductLists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSearchProductLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtSearchProductLists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProductLists.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProductLists.Location = new System.Drawing.Point(12, 72);
            this.txtSearchProductLists.Name = "txtSearchProductLists";
            this.txtSearchProductLists.Size = new System.Drawing.Size(705, 43);
            this.txtSearchProductLists.TabIndex = 0;
            this.txtSearchProductLists.Click += new System.EventHandler(this.txtSearchProductLists_Click);
            this.txtSearchProductLists.TextChanged += new System.EventHandler(this.txtSearchProductLists_TextChanged);
            this.txtSearchProductLists.Enter += new System.EventHandler(this.txtSearchProductLists_Enter);
            this.txtSearchProductLists.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchProductLists_KeyDown);
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTotalOrder.Location = new System.Drawing.Point(6, 25);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(146, 32);
            this.lblTotalOrder.TabIndex = 1;
            this.lblTotalOrder.Text = "Total Order:";
            // 
            // lblSKUProduct
            // 
            this.lblSKUProduct.AutoSize = true;
            this.lblSKUProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKUProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSKUProduct.Location = new System.Drawing.Point(7, 42);
            this.lblSKUProduct.Name = "lblSKUProduct";
            this.lblSKUProduct.Size = new System.Drawing.Size(234, 28);
            this.lblSKUProduct.TabIndex = 1;
            this.lblSKUProduct.Text = "Stock Keeping Unit (SKU)";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Firebrick;
            this.lblChange.Location = new System.Drawing.Point(48, 136);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(104, 32);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(157, 130);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(240, 50);
            this.txtChange.TabIndex = 2;
            this.txtChange.TabStop = false;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbHeader
            // 
            this.gpbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbHeader.Controls.Add(this.pictureBoxCMLogo);
            this.gpbHeader.Controls.Add(this.btnShutdown);
            this.gpbHeader.Controls.Add(this.lblHeader);
            this.gpbHeader.Controls.Add(this.btnMinimize);
            this.gpbHeader.Controls.Add(this.lblPointOfSale);
            this.gpbHeader.Location = new System.Drawing.Point(-4, -3);
            this.gpbHeader.Name = "gpbHeader";
            this.gpbHeader.Size = new System.Drawing.Size(1376, 49);
            this.gpbHeader.TabIndex = 9;
            this.gpbHeader.TabStop = false;
            // 
            // pictureBoxCMLogo
            // 
            this.pictureBoxCMLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCMLogo.Image")));
            this.pictureBoxCMLogo.Location = new System.Drawing.Point(15, 16);
            this.pictureBoxCMLogo.Name = "pictureBoxCMLogo";
            this.pictureBoxCMLogo.Size = new System.Drawing.Size(51, 26);
            this.pictureBoxCMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCMLogo.TabIndex = 20;
            this.pictureBoxCMLogo.TabStop = false;
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(1317, 14);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(37, 31);
            this.btnShutdown.TabIndex = 19;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(438, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(501, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "AMARA\'s Agrivet and General Merchandise";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(1255, 14);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 31);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblPointOfSale
            // 
            this.lblPointOfSale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointOfSale.ForeColor = System.Drawing.Color.White;
            this.lblPointOfSale.Location = new System.Drawing.Point(60, 18);
            this.lblPointOfSale.Name = "lblPointOfSale";
            this.lblPointOfSale.Size = new System.Drawing.Size(106, 24);
            this.lblPointOfSale.TabIndex = 21;
            this.lblPointOfSale.Text = "Point of Sale";
            this.lblPointOfSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnOpenSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnOpenSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOpenSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnOpenSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSettings.Image")));
            this.btnOpenSettings.Location = new System.Drawing.Point(1230, 72);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(120, 80);
            this.btnOpenSettings.TabIndex = 15;
            this.btnOpenSettings.TabStop = false;
            this.btnOpenSettings.Text = "&Settings";
            this.btnOpenSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenSettings.UseVisualStyleBackColor = false;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // btnTotalSalesZero
            // 
            this.btnTotalSalesZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnTotalSalesZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnTotalSalesZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTotalSalesZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTotalSalesZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSalesZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSalesZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnTotalSalesZero.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalSalesZero.Image")));
            this.btnTotalSalesZero.Location = new System.Drawing.Point(968, 169);
            this.btnTotalSalesZero.Name = "btnTotalSalesZero";
            this.btnTotalSalesZero.Size = new System.Drawing.Size(130, 80);
            this.btnTotalSalesZero.TabIndex = 18;
            this.btnTotalSalesZero.TabStop = false;
            this.btnTotalSalesZero.Text = "Total Sales Zero";
            this.btnTotalSalesZero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTotalSalesZero.UseVisualStyleBackColor = false;
            this.btnTotalSalesZero.Visible = false;
            this.btnTotalSalesZero.Click += new System.EventHandler(this.btnTotalSalesZero_Click);
            // 
            // btnLockSettings
            // 
            this.btnLockSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnLockSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnLockSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLockSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLockSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLockSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnLockSettings.Image")));
            this.btnLockSettings.Location = new System.Drawing.Point(842, 72);
            this.btnLockSettings.Name = "btnLockSettings";
            this.btnLockSettings.Size = new System.Drawing.Size(120, 177);
            this.btnLockSettings.TabIndex = 17;
            this.btnLockSettings.TabStop = false;
            this.btnLockSettings.Text = "Loc&k Settings";
            this.btnLockSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLockSettings.UseVisualStyleBackColor = false;
            this.btnLockSettings.Visible = false;
            this.btnLockSettings.Click += new System.EventHandler(this.btnLockSettings_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(1104, 72);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(120, 80);
            this.btnCalculator.TabIndex = 13;
            this.btnCalculator.TabStop = false;
            this.btnCalculator.Text = "Calcula&tor";
            this.btnCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnContact.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.Image")));
            this.btnContact.Location = new System.Drawing.Point(978, 72);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(120, 80);
            this.btnContact.TabIndex = 14;
            this.btnContact.TabStop = false;
            this.btnContact.Text = "Co&ntact";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnSalesProduct
            // 
            this.btnSalesProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnSalesProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnSalesProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalesProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalesProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSalesProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesProduct.Image")));
            this.btnSalesProduct.Location = new System.Drawing.Point(1230, 169);
            this.btnSalesProduct.Name = "btnSalesProduct";
            this.btnSalesProduct.Size = new System.Drawing.Size(120, 80);
            this.btnSalesProduct.TabIndex = 12;
            this.btnSalesProduct.TabStop = false;
            this.btnSalesProduct.Text = "Products";
            this.btnSalesProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalesProduct.UseVisualStyleBackColor = false;
            this.btnSalesProduct.Visible = false;
            this.btnSalesProduct.Click += new System.EventHandler(this.btnSalesProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(1104, 169);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 80);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblProductName.Location = new System.Drawing.Point(6, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 28);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(154, 56);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(367, 29);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Click += new System.EventHandler(this.txtProductName_Click);
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrice.Location = new System.Drawing.Point(90, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 28);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(154, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(367, 43);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
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
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
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
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
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
            this.gpbSettingsProduct.Controls.Add(this.ptcbShortcutOnKeyboard);
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
            this.gpbSettingsProduct.Enabled = false;
            this.gpbSettingsProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbSettingsProduct.Location = new System.Drawing.Point(821, 566);
            this.gpbSettingsProduct.Name = "gpbSettingsProduct";
            this.gpbSettingsProduct.Size = new System.Drawing.Size(527, 190);
            this.gpbSettingsProduct.TabIndex = 10;
            this.gpbSettingsProduct.TabStop = false;
            this.gpbSettingsProduct.Text = "SKU / Product Name / Price / Save Product / Edit / Delete / Cancel";
            // 
            // ptcbShortcutOnKeyboard
            // 
            this.ptcbShortcutOnKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("ptcbShortcutOnKeyboard.Image")));
            this.ptcbShortcutOnKeyboard.Location = new System.Drawing.Point(0, 0);
            this.ptcbShortcutOnKeyboard.Name = "ptcbShortcutOnKeyboard";
            this.ptcbShortcutOnKeyboard.Size = new System.Drawing.Size(527, 190);
            this.ptcbShortcutOnKeyboard.TabIndex = 6;
            this.ptcbShortcutOnKeyboard.TabStop = false;
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSKU.Location = new System.Drawing.Point(154, 23);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(367, 29);
            this.txtSKU.TabIndex = 0;
            this.txtSKU.Click += new System.EventHandler(this.txtSKU_Click);
            this.txtSKU.TextChanged += new System.EventHandler(this.txtSKU_TextChanged);
            this.txtSKU.Enter += new System.EventHandler(this.txtSKU_Enter);
            this.txtSKU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSKU_KeyDown);
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSKU.Location = new System.Drawing.Point(95, 23);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(53, 28);
            this.lblSKU.TabIndex = 7;
            this.lblSKU.Text = "SKU:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
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
            this.gpbSettingsOrderProduct.Controls.Add(this.btnCanceledOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblTotalOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblChange);
            this.gpbSettingsOrderProduct.Controls.Add(this.lblCash);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtTotalOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtChange);
            this.gpbSettingsOrderProduct.Controls.Add(this.txtCash);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnConfirmOrder);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnRemove);
            this.gpbSettingsOrderProduct.Controls.Add(this.btnPrintReceipt);
            this.gpbSettingsOrderProduct.Location = new System.Drawing.Point(12, 566);
            this.gpbSettingsOrderProduct.Name = "gpbSettingsOrderProduct";
            this.gpbSettingsOrderProduct.Size = new System.Drawing.Size(803, 190);
            this.gpbSettingsOrderProduct.TabIndex = 11;
            this.gpbSettingsOrderProduct.TabStop = false;
            // 
            // btnCanceledOrder
            // 
            this.btnCanceledOrder.BackColor = System.Drawing.Color.Red;
            this.btnCanceledOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanceledOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCanceledOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCanceledOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCanceledOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanceledOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceledOrder.ForeColor = System.Drawing.Color.White;
            this.btnCanceledOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCanceledOrder.Image")));
            this.btnCanceledOrder.Location = new System.Drawing.Point(403, 87);
            this.btnCanceledOrder.Name = "btnCanceledOrder";
            this.btnCanceledOrder.Size = new System.Drawing.Size(394, 43);
            this.btnCanceledOrder.TabIndex = 7;
            this.btnCanceledOrder.TabStop = false;
            this.btnCanceledOrder.Text = "Cancel Order";
            this.btnCanceledOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCanceledOrder.UseVisualStyleBackColor = false;
            this.btnCanceledOrder.Click += new System.EventHandler(this.btnCanceledOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmOrder.Image")));
            this.btnConfirmOrder.Location = new System.Drawing.Point(403, 19);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(192, 66);
            this.btnConfirmOrder.TabIndex = 4;
            this.btnConfirmOrder.TabStop = false;
            this.btnConfirmOrder.Text = "Confirm &Order";
            this.btnConfirmOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // timerShutdown
            // 
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // gpbTotalSales
            // 
            this.gpbTotalSales.Controls.Add(this.btnPrintTotalSales);
            this.gpbTotalSales.Controls.Add(this.lblTotalSales);
            this.gpbTotalSales.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.gpbTotalSales.Location = new System.Drawing.Point(821, 255);
            this.gpbTotalSales.Name = "gpbTotalSales";
            this.gpbTotalSales.Size = new System.Drawing.Size(525, 164);
            this.gpbTotalSales.TabIndex = 19;
            this.gpbTotalSales.TabStop = false;
            this.gpbTotalSales.Text = "Total Sales";
            // 
            // btnPrintTotalSales
            // 
            this.btnPrintTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrintTotalSales.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintTotalSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrintTotalSales.Enabled = false;
            this.btnPrintTotalSales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintTotalSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintTotalSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTotalSales.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTotalSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintTotalSales.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTotalSales.Image")));
            this.btnPrintTotalSales.Location = new System.Drawing.Point(3, 100);
            this.btnPrintTotalSales.Name = "btnPrintTotalSales";
            this.btnPrintTotalSales.Size = new System.Drawing.Size(519, 61);
            this.btnPrintTotalSales.TabIndex = 23;
            this.btnPrintTotalSales.TabStop = false;
            this.btnPrintTotalSales.Text = "Print Tota&l Sales";
            this.btnPrintTotalSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintTotalSales.UseVisualStyleBackColor = false;
            this.btnPrintTotalSales.Click += new System.EventHandler(this.btnPrintTotalSales_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSales.Location = new System.Drawing.Point(3, 50);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(519, 47);
            this.lblTotalSales.TabIndex = 22;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalSales.TextChanged += new System.EventHandler(this.lblTotalSales_TextChanged);
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProductsCount.Location = new System.Drawing.Point(817, 539);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(17, 21);
            this.lblProductsCount.TabIndex = 20;
            this.lblProductsCount.Text = "?";
            this.lblProductsCount.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PointOfSaleViewerForm.Product);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.lblProductsCount);
            this.Controls.Add(this.dgvProductLists);
            this.Controls.Add(this.gpbTotalSales);
            this.Controls.Add(this.gpbSettingsOrderProduct);
            this.Controls.Add(this.btnTotalSalesZero);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.btnLockSettings);
            this.Controls.Add(this.gpbSettingsProduct);
            this.Controls.Add(this.gpbHeader);
            this.Controls.Add(this.dgvOrderProductLists);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.lblSKUProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtSearchProductLists);
            this.Controls.Add(this.btnSalesProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMARA\'s Agrivet and General Merchandise [ Point of Sale ]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLists)).EndInit();
            this.gpbHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMLogo)).EndInit();
            this.gpbSettingsProduct.ResumeLayout(false);
            this.gpbSettingsProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShortcutOnKeyboard)).EndInit();
            this.gpbSettingsOrderProduct.ResumeLayout(false);
            this.gpbSettingsOrderProduct.PerformLayout();
            this.gpbTotalSales.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvOrderProductLists;        
        private System.Windows.Forms.DataGridView dgvProductLists;
        public System.Windows.Forms.TextBox txtSearchProductLists;        
        private System.Windows.Forms.Label lblTotalOrder;        
        private System.Windows.Forms.Label lblSKUProduct;        
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
        private System.Windows.Forms.GroupBox gpbSettingsOrderProduct;        
        private System.Windows.Forms.Button btnConfirmOrder;        
        private System.Windows.Forms.Button btnEdit;        
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnContact;        
        private System.Windows.Forms.PictureBox ptcbShortcutOnKeyboard;        
        private System.Windows.Forms.Button btnSalesProduct;        
        private System.Windows.Forms.Button btnOpenSettings;        
        private System.Windows.Forms.Button btnLockSettings;        
        private System.Windows.Forms.Button btnTotalSalesZero;        
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timerShutdown;
        private System.Windows.Forms.PictureBox pictureBoxCMLogo;
        private System.Windows.Forms.Label lblPointOfSale;
        private System.Windows.Forms.GroupBox gpbTotalSales;
        private System.Windows.Forms.Button btnPrintTotalSales;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Button btnCanceledOrder;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

