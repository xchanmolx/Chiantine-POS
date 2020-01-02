namespace PointOfSaleViewerForm.UI
{
    partial class StoreName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreName));
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblChangeStoreName = new System.Windows.Forms.Label();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtStoreName
            // 
            this.txtStoreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStoreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtStoreName.BackColor = System.Drawing.Color.White;
            this.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreName.Location = new System.Drawing.Point(12, 84);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(416, 43);
            this.txtStoreName.TabIndex = 1;
            // 
            // lblChangeStoreName
            // 
            this.lblChangeStoreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblChangeStoreName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangeStoreName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeStoreName.ForeColor = System.Drawing.Color.White;
            this.lblChangeStoreName.Location = new System.Drawing.Point(0, 0);
            this.lblChangeStoreName.Name = "lblChangeStoreName";
            this.lblChangeStoreName.Size = new System.Drawing.Size(566, 40);
            this.lblChangeStoreName.TabIndex = 22;
            this.lblChangeStoreName.Text = "Change Store Name";
            this.lblChangeStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 50;
            this.bunifuElipse.TargetControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(434, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 80);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "    Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnShutdown.Location = new System.Drawing.Point(510, 4);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(37, 31);
            this.btnShutdown.TabIndex = 24;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // timerShutdown
            // 
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // StoreName
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(566, 139);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblChangeStoreName);
            this.Controls.Add(this.txtStoreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StoreName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblChangeStoreName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Timer timerShutdown;
    }
}