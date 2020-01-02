using PointOfSaleViewerForm.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm.DAL
{
    public class StoreNameDAL
    {
        private const string db = "POS";

        #region Update data in Database
        public bool Update(StoreNameBLL storeName)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "UPDATE StoreName SET store_name=@Store_Name WHERE store_no=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Store_Name", storeName.StoreName);
                cmd.Parameters.AddWithValue("@Id", storeName.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Query successful
                    isSuccess = true;
                }
                else
                {
                    // Query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Update data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
    }
}
