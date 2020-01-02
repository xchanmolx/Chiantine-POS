namespace PointOfSaleViewerForm.UI
{
    partial class CodeCreateNewPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeCreateNewPasswordForm));
            this.gpbHeader = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.linkForgotCode = new System.Windows.Forms.LinkLabel();
            this.gpbHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHeader
            // 
            this.gpbHeader.BackColor = System.Drawing.Color.Silver;
            this.gpbHeader.Controls.Add(this.lblHeader);
            this.gpbHeader.Location = new System.Drawing.Point(-5, -11);
            this.gpbHeader.Name = "gpbHeader";
            this.gpbHeader.Size = new System.Drawing.Size(434, 80);
            this.gpbHeader.TabIndex = 44;
            this.gpbHeader.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(111, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(213, 47);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "INPUT CODE";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(231, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 45);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEnter.Location = new System.Drawing.Point(75, 201);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(124, 45);
            this.btnEnter.TabIndex = 46;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(158, 126);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(197, 29);
            this.txtCode.TabIndex = 45;
            this.txtCode.UseSystemPasswordChar = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCode.Location = new System.Drawing.Point(106, 134);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 21);
            this.lblCode.TabIndex = 48;
            this.lblCode.Text = "Code";
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 150;
            this.bunifuElipse.TargetControl = this;
            // 
            // linkForgotCode
            // 
            this.linkForgotCode.AutoSize = true;
            this.linkForgotCode.Location = new System.Drawing.Point(265, 158);
            this.linkForgotCode.Name = "linkForgotCode";
            this.linkForgotCode.Size = new System.Drawing.Size(90, 21);
            this.linkForgotCode.TabIndex = 49;
            this.linkForgotCode.TabStop = true;
            this.linkForgotCode.Text = "forgot code";
            this.linkForgotCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotCode_LinkClicked);
            // 
            // CodeCreateNewPasswordForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 325);
            this.Controls.Add(this.linkForgotCode);
            this.Controls.Add(this.gpbHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CodeCreateNewPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Code";
            this.gpbHeader.ResumeLayout(false);
            this.gpbHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.LinkLabel linkForgotCode;
    }
}