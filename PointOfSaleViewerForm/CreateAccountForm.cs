using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Account account = new Account(txtUsername.Text, txtPassword.Text);

                GlobalConfig.Connection.CreateAccount(account);

                txtUsername.Text = "";
                txtPassword.Text = "";

                this.Close();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (txtUsername.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a username.", "Username!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a password.", "Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You create an account for Molex Point Of Sale.", "Account Creation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return output;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
