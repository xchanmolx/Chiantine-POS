using PointOfSaleViewerForm.BLL;
using PointOfSaleViewerForm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm.UI
{
    public partial class StoreName : Form
    {
        private frmMain _main;

        public StoreName(frmMain main)
        {
            InitializeComponent();

            _main = main;
        }        

        StoreNameBLL storeNameBLL = new StoreNameBLL();
        StoreNameDAL storeNameDAL = new StoreNameDAL();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to update store name?", "Update Store Name!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // Getting data from UI
                storeNameBLL.Id = 1;
                storeNameBLL.StoreName = txtStoreName.Text;

                // Updating data into Database
                bool success = storeNameDAL.Update(storeNameBLL);

                // Update Store Name
                _main.FillLabelStoreName();

                // If the data is successfully updated then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully updated
                    MessageBox.Show("Store Name successfully updated.", "Updated Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Failed to updated data
                    MessageBox.Show("Failed to update new store name information.", "Update Information Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                timerShutdown.Stop();
                Close();
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            timerShutdown.Start();            
        }        
    }
}
