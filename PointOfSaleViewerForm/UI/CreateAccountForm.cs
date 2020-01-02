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
        LoginForm _login;

        public CreateAccountForm(LoginForm login)
        {
            InitializeComponent();

            _login = login;
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

                _login.txtUsername.Focus();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (txtUsername.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a username.", "Username!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a password.", "Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else
            {
                MessageBox.Show("You create an account for CM Point Of Sale.", "Account Creation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return output;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
