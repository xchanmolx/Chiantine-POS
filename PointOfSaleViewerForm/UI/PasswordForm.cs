using PointOfSaleViewerForm.UI;
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
    public partial class PasswordForm : Form
    {
        private const string db = "POS";

        LoginForm _login;

        public PasswordForm(LoginForm login)
        {
            InitializeComponent();

            _login = login;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                string query = "Select * From Passwords Where Password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    CreateAccountForm frm = new CreateAccountForm(_login);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Check your password!", "Password Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            _login.txtUsername.Focus();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodeCreateNewPasswordForm createNewPassword = new CodeCreateNewPasswordForm(this);
            createNewPassword.Show();
        }
    }
}
