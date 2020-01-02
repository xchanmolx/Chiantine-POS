namespace PointOfSaleViewerForm.UI
{
    partial class GenerateBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateBarcode));
            this.lblGenerateBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnGenerateBarcode = new System.Windows.Forms.Button();
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBarcode1 = new System.Windows.Forms.PictureBox();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBoxBarcode2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBarcode3 = new System.Windows.Forms.PictureBox();
            this.txtTitle1 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.txtTitle3 = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBoxCode = new System.Windows.Forms.GroupBox();
            this.btnPrintForCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleForCode = new System.Windows.Forms.TextBox();
            this.pictureBoxForCode = new System.Windows.Forms.PictureBox();
            this.lblAlphaNumeric = new System.Windows.Forms.Label();
            this.txtBarcodeForCode = new System.Windows.Forms.TextBox();
            this.btnGenerateForCode = new System.Windows.Forms.Button();
            this.printPreviewDialogCode = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentCode = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode3)).BeginInit();
            this.groupBoxCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerateBarcode
            // 
            this.lblGenerateBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblGenerateBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGenerateBarcode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateBarcode.ForeColor = System.Drawing.Color.White;
            this.lblGenerateBarcode.Location = new System.Drawing.Point(0, 0);
            this.lblGenerateBarcode.Name = "lblGenerateBarcode";
            this.lblGenerateBarcode.Size = new System.Drawing.Size(782, 40);
            this.lblGenerateBarcode.TabIndex = 26;
            this.lblGenerateBarcode.Text = "Generate Barcode";
            this.lblGenerateBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(12, 98);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(608, 43);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Click += new System.EventHandler(this.txtBarcode_Click);
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 50;
            this.bunifuElipse.TargetControl = this;
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
            this.btnShutdown.Location = new System.Drawing.Point(732, 5);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(37, 31);
            this.btnShutdown.TabIndex = 28;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnGenerateBarcode
            // 
            this.btnGenerateBarcode.BackColor = System.Drawing.Color.White;
            this.btnGenerateBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnGenerateBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerateBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGenerateBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateBarcode.Image")));
            this.btnGenerateBarcode.Location = new System.Drawing.Point(626, 53);
            this.btnGenerateBarcode.Name = "btnGenerateBarcode";
            this.btnGenerateBarcode.Size = new System.Drawing.Size(143, 88);
            this.btnGenerateBarcode.TabIndex = 27;
            this.btnGenerateBarcode.TabStop = false;
            this.btnGenerateBarcode.Text = "&Generate Barcode";
            this.btnGenerateBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnGenerateBarcode.Click += new System.EventHandler(this.btnGenerateBarcode_Click);
            // 
            // timerShutdown
            // 
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // pictureBoxBarcode1
            // 
            this.pictureBoxBarcode1.Location = new System.Drawing.Point(12, 147);
            this.pictureBoxBarcode1.Name = "pictureBoxBarcode1";
            this.pictureBoxBarcode1.Size = new System.Drawing.Size(294, 43);
            this.pictureBoxBarcode1.TabIndex = 29;
            this.pictureBoxBarcode1.TabStop = false;
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.BackColor = System.Drawing.Color.White;
            this.btnPrintBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrintBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnPrintBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBarcode.Image")));
            this.btnPrintBarcode.Location = new System.Drawing.Point(626, 287);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(143, 88);
            this.btnPrintBarcode.TabIndex = 30;
            this.btnPrintBarcode.TabStop = false;
            this.btnPrintBarcode.Text = "&Print Barcode";
            this.btnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintBarcode.UseVisualStyleBackColor = false;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // pictureBoxBarcode2
            // 
            this.pictureBoxBarcode2.Location = new System.Drawing.Point(12, 234);
            this.pictureBoxBarcode2.Name = "pictureBoxBarcode2";
            this.pictureBoxBarcode2.Size = new System.Drawing.Size(294, 43);
            this.pictureBoxBarcode2.TabIndex = 31;
            this.pictureBoxBarcode2.TabStop = false;
            // 
            // pictureBoxBarcode3
            // 
            this.pictureBoxBarcode3.Location = new System.Drawing.Point(12, 332);
            this.pictureBoxBarcode3.Name = "pictureBoxBarcode3";
            this.pictureBoxBarcode3.Size = new System.Drawing.Size(294, 43);
            this.pictureBoxBarcode3.TabIndex = 32;
            this.pictureBoxBarcode3.TabStop = false;
            // 
            // txtTitle1
            // 
            this.txtTitle1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTitle1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTitle1.BackColor = System.Drawing.Color.White;
            this.txtTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle1.Location = new System.Drawing.Point(356, 160);
            this.txtTitle1.Name = "txtTitle1";
            this.txtTitle1.Size = new System.Drawing.Size(264, 30);
            this.txtTitle1.TabIndex = 1;
            this.txtTitle1.Click += new System.EventHandler(this.txtTitle1_Click);
            this.txtTitle1.TextChanged += new System.EventHandler(this.txtTitle1_TextChanged);
            this.txtTitle1.Enter += new System.EventHandler(this.txtTitle1_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(312, 164);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle2
            // 
            this.txtTitle2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTitle2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTitle2.BackColor = System.Drawing.Color.White;
            this.txtTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle2.Location = new System.Drawing.Point(356, 247);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(264, 30);
            this.txtTitle2.TabIndex = 35;
            this.txtTitle2.TabStop = false;
            // 
            // txtTitle3
            // 
            this.txtTitle3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTitle3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTitle3.BackColor = System.Drawing.Color.White;
            this.txtTitle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle3.Location = new System.Drawing.Point(356, 345);
            this.txtTitle3.Name = "txtTitle3";
            this.txtTitle3.Size = new System.Drawing.Size(264, 30);
            this.txtTitle3.TabIndex = 36;
            this.txtTitle3.TabStop = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 75);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(190, 20);
            this.lblLength.TabIndex = 37;
            this.lblLength.Text = "10 alphanumeric characters";
            // 
            // groupBoxCode
            // 
            this.groupBoxCode.Controls.Add(this.btnPrintForCode);
            this.groupBoxCode.Controls.Add(this.label1);
            this.groupBoxCode.Controls.Add(this.txtTitleForCode);
            this.groupBoxCode.Controls.Add(this.pictureBoxForCode);
            this.groupBoxCode.Controls.Add(this.lblAlphaNumeric);
            this.groupBoxCode.Controls.Add(this.txtBarcodeForCode);
            this.groupBoxCode.Controls.Add(this.btnGenerateForCode);
            this.groupBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.groupBoxCode.Location = new System.Drawing.Point(12, 410);
            this.groupBoxCode.Name = "groupBoxCode";
            this.groupBoxCode.Size = new System.Drawing.Size(757, 346);
            this.groupBoxCode.TabIndex = 41;
            this.groupBoxCode.TabStop = false;
            this.groupBoxCode.Text = "Barcode for Code to change password";
            // 
            // btnPrintForCode
            // 
            this.btnPrintForCode.BackColor = System.Drawing.Color.White;
            this.btnPrintForCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintForCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnPrintForCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrintForCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrintForCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintForCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintForCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnPrintForCode.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintForCode.Image")));
            this.btnPrintForCode.Location = new System.Drawing.Point(608, 216);
            this.btnPrintForCode.Name = "btnPrintForCode";
            this.btnPrintForCode.Size = new System.Drawing.Size(143, 88);
            this.btnPrintForCode.TabIndex = 42;
            this.btnPrintForCode.TabStop = false;
            this.btnPrintForCode.Text = "Prin&t Barcode";
            this.btnPrintForCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintForCode.UseVisualStyleBackColor = false;
            this.btnPrintForCode.Click += new System.EventHandler(this.btnPrintForCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Title";
            // 
            // txtTitleForCode
            // 
            this.txtTitleForCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTitleForCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTitleForCode.BackColor = System.Drawing.Color.White;
            this.txtTitleForCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleForCode.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleForCode.Location = new System.Drawing.Point(6, 174);
            this.txtTitleForCode.Name = "txtTitleForCode";
            this.txtTitleForCode.Size = new System.Drawing.Size(264, 30);
            this.txtTitleForCode.TabIndex = 44;
            this.txtTitleForCode.TabStop = false;
            // 
            // pictureBoxForCode
            // 
            this.pictureBoxForCode.Location = new System.Drawing.Point(6, 239);
            this.pictureBoxForCode.Name = "pictureBoxForCode";
            this.pictureBoxForCode.Size = new System.Drawing.Size(596, 65);
            this.pictureBoxForCode.TabIndex = 42;
            this.pictureBoxForCode.TabStop = false;
            // 
            // lblAlphaNumeric
            // 
            this.lblAlphaNumeric.AutoSize = true;
            this.lblAlphaNumeric.ForeColor = System.Drawing.Color.Black;
            this.lblAlphaNumeric.Location = new System.Drawing.Point(6, 71);
            this.lblAlphaNumeric.Name = "lblAlphaNumeric";
            this.lblAlphaNumeric.Size = new System.Drawing.Size(225, 20);
            this.lblAlphaNumeric.TabIndex = 43;
            this.lblAlphaNumeric.Text = "no limit alphanumeric characters";
            // 
            // txtBarcodeForCode
            // 
            this.txtBarcodeForCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBarcodeForCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtBarcodeForCode.BackColor = System.Drawing.Color.White;
            this.txtBarcodeForCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcodeForCode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeForCode.Location = new System.Drawing.Point(6, 94);
            this.txtBarcodeForCode.Name = "txtBarcodeForCode";
            this.txtBarcodeForCode.Size = new System.Drawing.Size(596, 43);
            this.txtBarcodeForCode.TabIndex = 41;
            this.txtBarcodeForCode.TabStop = false;
            // 
            // btnGenerateForCode
            // 
            this.btnGenerateForCode.BackColor = System.Drawing.Color.White;
            this.btnGenerateForCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateForCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnGenerateForCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerateForCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerateForCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateForCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateForCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGenerateForCode.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateForCode.Image")));
            this.btnGenerateForCode.Location = new System.Drawing.Point(608, 49);
            this.btnGenerateForCode.Name = "btnGenerateForCode";
            this.btnGenerateForCode.Size = new System.Drawing.Size(143, 88);
            this.btnGenerateForCode.TabIndex = 42;
            this.btnGenerateForCode.TabStop = false;
            this.btnGenerateForCode.Text = "Generate &Barcode";
            this.btnGenerateForCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateForCode.UseVisualStyleBackColor = false;
            this.btnGenerateForCode.Click += new System.EventHandler(this.btnGenerateForCode_Click);
            // 
            // printPreviewDialogCode
            // 
            this.printPreviewDialogCode.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCode.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCode.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogCode.Document = this.printDocumentCode;
            this.printPreviewDialogCode.Enabled = true;
            this.printPreviewDialogCode.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogCode.Icon")));
            this.printPreviewDialogCode.Name = "printPreviewDialogCode";
            this.printPreviewDialogCode.Visible = false;
            // 
            // printDocumentCode
            // 
            this.printDocumentCode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCode_PrintPage);
            // 
            // GenerateBarcode
            // 
            this.AcceptButton = this.btnGenerateBarcode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(782, 749);
            this.Controls.Add(this.groupBoxCode);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtTitle3);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle1);
            this.Controls.Add(this.pictureBoxBarcode3);
            this.Controls.Add(this.pictureBoxBarcode2);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.pictureBoxBarcode1);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.lblGenerateBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnGenerateBarcode);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenerateBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode3)).EndInit();
            this.groupBoxCode.ResumeLayout(false);
            this.groupBoxCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerateBarcode;
        public System.Windows.Forms.TextBox txtBarcode;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnGenerateBarcode;
        private System.Windows.Forms.Timer timerShutdown;
        private System.Windows.Forms.PictureBox pictureBoxBarcode1;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PictureBox pictureBoxBarcode3;
        private System.Windows.Forms.PictureBox pictureBoxBarcode2;
        public System.Windows.Forms.TextBox txtTitle1;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtTitle3;
        public System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox groupBoxCode;
        private System.Windows.Forms.Label lblAlphaNumeric;
        public System.Windows.Forms.TextBox txtBarcodeForCode;
        private System.Windows.Forms.Button btnGenerateForCode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTitleForCode;
        private System.Windows.Forms.PictureBox pictureBoxForCode;
        private System.Windows.Forms.Button btnPrintForCode;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogCode;
        private System.Drawing.Printing.PrintDocument printDocumentCode;
    }
}