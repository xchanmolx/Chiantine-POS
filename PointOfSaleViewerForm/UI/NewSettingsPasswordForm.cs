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
    public partial class NewSettingsPasswordForm : Form
    {
        private const string db = "POS";
        PasswordSettingsForm _parent;

        public NewSettingsPasswordForm(PasswordSettingsForm parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (txtNewPassword.Text.Count() != 0)
                {
                    string query = "UPDATE PasswordSettings SET password_changed = '" + txtNewPassword.Text.Trim() + "' WHERE password_no = 1";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    MessageBox.Show("New Password Settings, change successfully!", "New Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _parent.txtPassword.Focus();                    
                }
                else
                {
                    MessageBox.Show("Please input a new password settings!", "New Password Settings!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.txtPassword.Focus();
        }
    }
}
