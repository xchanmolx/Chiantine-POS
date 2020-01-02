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
    public partial class PasswordSettingsForm : Form
    {
        private const string db = "POS";
        frmMain parent;

        public PasswordSettingsForm(frmMain _parent)
        {
            InitializeComponent();

            parent = _parent;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                string query = "Select * From PasswordSettings Where password_changed = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    parent.Show();
                    parent.LockSettings();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password!", "Verify Password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.txtSearchProductLists.Focus();        
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodeForm frmCode = new CodeForm(this);
            frmCode.Show();
        }
    }
}
