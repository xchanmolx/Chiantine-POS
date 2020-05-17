namespace PointOfSaleViewerForm
{
    partial class DisplaySalesProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySalesProductForm));
            this.dgvSalesProduct = new System.Windows.Forms.DataGridView();
            this.txtSearchSalesProduct = new System.Windows.Forms.TextBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxOverAllTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBackToPointOfSale = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDatePurchased = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMonthDayYear = new System.Windows.Forms.Label();
            this.txtSKU = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.txtStoreName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblOrderedItems = new System.Windows.Forms.Label();
            this.lblLongPaper = new System.Windows.Forms.Label();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.lblSearchDatePurchased = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesProduct
            // 
            this.dgvSalesProduct.AllowUserToAddRows = false;
            this.dgvSalesProduct.AllowUserToDeleteRows = false;
            this.dgvSalesProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSalesProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dgvSalesProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSalesProduct.Location = new System.Drawing.Point(41, 96);
            this.dgvSalesProduct.Name = "dgvSalesProduct";
            this.dgvSalesProduct.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesProduct.Size = new System.Drawing.Size(811, 584);
            this.dgvSalesProduct.TabIndex = 10;
            this.dgvSalesProduct.TabStop = false;
            this.dgvSalesProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSalesProduct_CellFormatting);
            this.dgvSalesProduct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSalesProduct_RowPrePaint);
            this.dgvSalesProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSalesProduct_RowsAdded);
            this.dgvSalesProduct.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSalesProduct_RowsRemoved);
            this.dgvSalesProduct.Click += new System.EventHandler(this.dgvSalesProduct_Click);
            // 
            // txtSearchSalesProduct
            // 
            this.txtSearchSalesProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchSalesProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSearchSalesProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtSearchSalesProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSalesProduct.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSalesProduct.Location = new System.Drawing.Point(41, 34);
            this.txtSearchSalesProduct.Name = "txtSearchSalesProduct";
            this.txtSearchSalesProduct.Size = new System.Drawing.Size(400, 43);
            this.txtSearchSalesProduct.TabIndex = 9;
            this.txtSearchSalesProduct.TextChanged += new System.EventHandler(this.txtSearchSalesProduct_TextChanged);
            this.txtSearchSalesProduct.Enter += new System.EventHandler(this.txtSearchSalesProduct_Enter);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(1104, 334);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(197, 64);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.TabStop = false;
            this.btnDeleteAll.Text = "Delete &All";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSearch.Location = new System.Drawing.Point(36, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(112, 28);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search SKU";
            // 
            // bunifuMaterialTextboxOverAllTotal
            // 
            this.bunifuMaterialTextboxOverAllTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextboxOverAllTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxOverAllTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxOverAllTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxOverAllTotal.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxOverAllTotal.HintText = "";
            this.bunifuMaterialTextboxOverAllTotal.isPassword = false;
            this.bunifuMaterialTextboxOverAllTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxOverAllTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextboxOverAllTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxOverAllTotal.LineThickness = 5;
            this.bunifuMaterialTextboxOverAllTotal.Location = new System.Drawing.Point(859, 618);
            this.bunifuMaterialTextboxOverAllTotal.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxOverAllTotal.Name = "bunifuMaterialTextboxOverAllTotal";
            this.bunifuMaterialTextboxOverAllTotal.Size = new System.Drawing.Size(493, 62);
            this.bunifuMaterialTextboxOverAllTotal.TabIndex = 16;
            this.bunifuMaterialTextboxOverAllTotal.TabStop = false;
            this.bunifuMaterialTextboxOverAllTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBackToPointOfSale
            // 
            this.btnBackToPointOfSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnBackToPointOfSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToPointOfSale.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackToPointOfSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBackToPointOfSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackToPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToPointOfSale.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToPointOfSale.ForeColor = System.Drawing.Color.Black;
            this.btnBackToPointOfSale.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToPointOfSale.Image")));
            this.btnBackToPointOfSale.Location = new System.Drawing.Point(858, 96);
            this.btnBackToPointOfSale.Name = "btnBackToPointOfSale";
            this.btnBackToPointOfSale.Size = new System.Drawing.Size(494, 113);
            this.btnBackToPointOfSale.TabIndex = 17;
            this.btnBackToPointOfSale.TabStop = false;
            this.btnBackToPointOfSale.Text = "Point of &Sale";
            this.btnBackToPointOfSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackToPointOfSale.UseVisualStyleBackColor = false;
            this.btnBackToPointOfSale.Click += new System.EventHandler(this.btnBackToPointOfSale_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1104, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 70);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(903, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 60);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.HintForeColor = System.Drawing.Color.Empty;
            this.txtProductName.HintText = "Product Name";
            this.txtProductName.isPassword = false;
            this.txtProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductName.LineThickness = 3;
            this.txtProductName.Location = new System.Drawing.Point(885, 443);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(416, 33);
            this.txtProductName.TabIndex = 20;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductName.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "Price";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(885, 505);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(158, 33);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.HintText = "Quantity";
            this.txtQuantity.isPassword = false;
            this.txtQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineThickness = 3;
            this.txtQuantity.Location = new System.Drawing.Point(1058, 505);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 33);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "Total";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotal.LineThickness = 3;
            this.txtTotal.Location = new System.Drawing.Point(1143, 505);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 33);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.Visible = false;
            // 
            // txtDatePurchased
            // 
            this.txtDatePurchased.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatePurchased.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDatePurchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatePurchased.HintForeColor = System.Drawing.Color.Empty;
            this.txtDatePurchased.HintText = "Date Purchased";
            this.txtDatePurchased.isPassword = false;
            this.txtDatePurchased.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDatePurchased.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDatePurchased.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDatePurchased.LineThickness = 3;
            this.txtDatePurchased.Location = new System.Drawing.Point(885, 573);
            this.txtDatePurchased.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatePurchased.Name = "txtDatePurchased";
            this.txtDatePurchased.Size = new System.Drawing.Size(416, 33);
            this.txtDatePurchased.TabIndex = 24;
            this.txtDatePurchased.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDatePurchased.Visible = false;
            // 
            // lblMonthDayYear
            // 
            this.lblMonthDayYear.AutoSize = true;
            this.lblMonthDayYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthDayYear.Location = new System.Drawing.Point(676, 78);
            this.lblMonthDayYear.Name = "lblMonthDayYear";
            this.lblMonthDayYear.Size = new System.Drawing.Size(103, 17);
            this.lblMonthDayYear.TabIndex = 25;
            this.lblMonthDayYear.Text = "Month-Day-Year";
            // 
            // txtSKU
            // 
            this.txtSKU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSKU.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSKU.HintForeColor = System.Drawing.Color.Empty;
            this.txtSKU.HintText = "Stock Keeping Unit";
            this.txtSKU.isPassword = false;
            this.txtSKU.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSKU.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSKU.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSKU.LineThickness = 3;
            this.txtSKU.Location = new System.Drawing.Point(885, 402);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(416, 33);
            this.txtSKU.TabIndex = 26;
            this.txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSKU.Visible = false;
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(1315, 13);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(37, 31);
            this.btnShutdown.TabIndex = 27;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrintAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Image")));
            this.btnPrintAll.Location = new System.Drawing.Point(885, 334);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(213, 64);
            this.btnPrintAll.TabIndex = 28;
            this.btnPrintAll.TabStop = false;
            this.btnPrintAll.Text = "&Print by Search";
            this.btnPrintAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintAll.UseVisualStyleBackColor = false;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // txtStoreName
            // 
            this.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStoreName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStoreName.HintForeColor = System.Drawing.Color.Empty;
            this.txtStoreName.HintText = "Store Name";
            this.txtStoreName.isPassword = false;
            this.txtStoreName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStoreName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStoreName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtStoreName.LineThickness = 3;
            this.txtStoreName.Location = new System.Drawing.Point(41, 687);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(169, 33);
            this.txtStoreName.TabIndex = 29;
            this.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreName.Visible = false;
            // 
            // lblOrderedItems
            // 
            this.lblOrderedItems.AutoSize = true;
            this.lblOrderedItems.ForeColor = System.Drawing.Color.Black;
            this.lblOrderedItems.Location = new System.Drawing.Point(675, 687);
            this.lblOrderedItems.Name = "lblOrderedItems";
            this.lblOrderedItems.Size = new System.Drawing.Size(126, 21);
            this.lblOrderedItems.TabIndex = 30;
            this.lblOrderedItems.Text = "Ordered Items: 0";
            this.lblOrderedItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLongPaper
            // 
            this.lblLongPaper.AutoSize = true;
            this.lblLongPaper.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongPaper.Location = new System.Drawing.Point(952, 378);
            this.lblLongPaper.Name = "lblLongPaper";
            this.lblLongPaper.Size = new System.Drawing.Size(119, 17);
            this.lblLongPaper.TabIndex = 31;
            this.lblLongPaper.Text = "8.5 x 13 inch paper";
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txtSearchDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDate.Location = new System.Drawing.Point(452, 34);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(400, 43);
            this.txtSearchDate.TabIndex = 32;
            this.txtSearchDate.TextChanged += new System.EventHandler(this.txtSearchDate_TextChanged);
            // 
            // lblSearchDatePurchased
            // 
            this.lblSearchDatePurchased.AutoSize = true;
            this.lblSearchDatePurchased.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDatePurchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSearchDatePurchased.Location = new System.Drawing.Point(447, 3);
            this.lblSearchDatePurchased.Name = "lblSearchDatePurchased";
            this.lblSearchDatePurchased.Size = new System.Drawing.Size(210, 28);
            this.lblSearchDatePurchased.TabIndex = 33;
            this.lblSearchDatePurchased.Text = "Search Date Purchased";
            // 
            // DisplaySalesProductForm
            // 
            this.AcceptButton = this.btnBackToPointOfSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(1365, 708);
            this.Controls.Add(this.lblSearchDatePurchased);
            this.Controls.Add(this.txtSearchDate);
            this.Controls.Add(this.lblLongPaper);
            this.Controls.Add(this.lblOrderedItems);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtDatePurchased);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBackToPointOfSale);
            this.Controls.Add(this.bunifuMaterialTextboxOverAllTotal);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.dgvSalesProduct);
            this.Controls.Add(this.txtSearchSalesProduct);
            this.Controls.Add(this.lblMonthDayYear);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplaySalesProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplaySalesProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesProduct;
        private System.Windows.Forms.TextBox txtSearchSalesProduct;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxOverAllTotal;
        private System.Windows.Forms.Button btnBackToPointOfSale;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDatePurchased;
        private System.Windows.Forms.Label lblMonthDayYear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSKU;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnPrintAll;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStoreName;
        private System.Windows.Forms.Label lblOrderedItems;
        private System.Windows.Forms.Label lblLongPaper;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.Label lblSearchDatePurchased;
    }
}