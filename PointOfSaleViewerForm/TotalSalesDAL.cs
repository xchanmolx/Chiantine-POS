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
    public class TotalSalesDAL
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
                string sql = "SELECT * FROM TotalSales";

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

        #region Insert data in Database
        public bool Insert(TotalSalesBLL totalSales)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "INSERT INTO TotalSales (TotalSales, DatePurchased) VALUES (@TotalSales, @DatePurchased)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TotalSales", totalSales.TotalSales);
                cmd.Parameters.AddWithValue("@DatePurchased", totalSales.DatePurchased);
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
                MessageBox.Show(ex.Message, "Insert data in Database Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(TotalSalesBLL totalSales)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "UPDATE TotalSales SET TotalSales=@TotalSales WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", totalSales.Id);
                cmd.Parameters.AddWithValue("@TotalSales", totalSales.TotalSales);

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

        #region DeleteAllTotalSalesPastDay data from Database
        public bool DeleteAllTotalSalesPastDay()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "DELETE FROM TotalSales WHERE DatePurchased < GETDATE() -1";
                SqlCommand cmd = new SqlCommand(sql, conn);

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

        #region DeleteAllTotalSales data from Database
        public bool DeleteAllTotalSales()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(GlobalConfig.CnnString(db));

            try
            {
                string sql = "DELETE FROM TotalSales WHERE DatePurchased > GETDATE() -1";
                SqlCommand cmd = new SqlCommand(sql, conn);

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
