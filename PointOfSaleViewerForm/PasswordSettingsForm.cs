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
    public partial class PasswordSettingsForm : Form
    {
        frmMain parent;

        public PasswordSettingsForm(frmMain _parent)
        {
            InitializeComponent();
            parent = _parent;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPassword.Text, "Baste&Samara", true) == 0)
            {
                parent.Show();
                parent.LockSettings();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid password!", "Verify Password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.txtSearchProductLists.Focus();        
        }
    }
}
