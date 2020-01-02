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
    public partial class CodeForm : Form
    {
        private const string db = "POS";

        PasswordSettingsForm _passwordSettings;

        public CodeForm(PasswordSettingsForm passwordSettings)
        {
            InitializeComponent();

            _passwordSettings = passwordSettings;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                string query = "Select * From Code Where code_name = '" + txtCode.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    NewSettingsPasswordForm frmNewPassword = new NewSettingsPasswordForm(_passwordSettings);
                    frmNewPassword.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid code!", "Verify Code!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _passwordSettings.txtPassword.Focus();
        }

        private void linkForgotCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Forgot the code? Please call or text at 0916-360-9855. (Chiantine P. Manigos) Thank you!", "Contact Information!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            txtCode.Focus();
        }
    }
}
