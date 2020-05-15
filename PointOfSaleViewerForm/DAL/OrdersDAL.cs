using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleViewerForm
{
    public class OrdersDAL
    {
        private const string db = "POS";

        #region Select data from Database
        public DataTable Select()
        {
            // Static method to connect Database
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            // To hold the data from Database
            DataTable dt = new DataTable();
            try
            {
                // SQL Query to get data from Database
                string sql = "SELECT * FROM Orders ORDER BY Id DESC";

                // For executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting data from Database
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                // Database connection open
                conn.Open();

                // Fill data in our DataTable
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                // Throw message if any error occurs
                MessageBox.Show(ex.Message, "Select data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Closing connection
                conn.Close();
            }

            // Return the value in DataTable
            return dt;
        }
        #endregion

        #region Update data in Database
        public bool Update(OrdersBLL sales)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "UPDATE Orders SET SKU=@SKU, ProductName=@ProductName, Price=@Price, Quantity=@Quantity, Total=@Total, DatePurchased=@DatePurchased WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SKU", sales.SKU);
                cmd.Parameters.AddWithValue("@ProductName", sales.ProductName);
                cmd.Parameters.AddWithValue("@Price", sales.Price);
                cmd.Parameters.AddWithValue("@Quantity", sales.Quantity);
                cmd.Parameters.AddWithValue("@Total", sales.Total);
                cmd.Parameters.AddWithValue("@DatePurchased", sales.DatePurchased);
                cmd.Parameters.AddWithValue("@Id", sales.Id);

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

        #region Delete data from Database
        public bool Delete(OrdersBLL sales)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "DELETE FROM Orders WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", sales.Id);

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
                MessageBox.Show(ex.Message, "Delete data from Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
