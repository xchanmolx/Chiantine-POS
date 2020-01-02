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

namespace PointOfSaleViewerForm.UI
{
    public partial class NewCreateAccountPassword : Form
    {
        private const string db = "POS";
        PasswordForm _passwordForm;

        public NewCreateAccountPassword(PasswordForm passwordForm)
        {
            InitializeComponent();

            _passwordForm = passwordForm;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (txtNewPassword.Text.Count() != 0)
                {
                    string query = "UPDATE Passwords SET Password = '" + txtNewPassword.Text.Trim() + "' WHERE PasswordID = 1";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    MessageBox.Show("New Password Create an Account, change successfully!", "New Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _passwordForm.txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Please input a new password on create an account!", "New Password Create an Account!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _passwordForm.txtPassword.Focus();
        }
    }
}
