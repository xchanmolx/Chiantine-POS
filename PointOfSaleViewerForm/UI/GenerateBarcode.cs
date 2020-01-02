using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace PointOfSaleViewerForm.UI
{
    public partial class GenerateBarcode : Form
    {
        PrintDocument pd = new PrintDocument();

        public GenerateBarcode()
        {
            InitializeComponent();
        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Count() != 0)
            {
                string barcode = txtBarcode.Text;
                Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Font oFont = new Font("IDAutomationHC39M", 13);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString("*" + barcode + "*", oFont, black, point);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    pictureBoxBarcode1.Image = bitmap;
                    pictureBoxBarcode1.Height = bitmap.Height;
                    pictureBoxBarcode1.Width = bitmap.Width;

                    pictureBoxBarcode2.Image = bitmap;
                    pictureBoxBarcode2.Height = bitmap.Height;
                    pictureBoxBarcode2.Width = bitmap.Width;

                    pictureBoxBarcode3.Image = bitmap;
                    pictureBoxBarcode3.Height = bitmap.Height;
                    pictureBoxBarcode3.Width = bitmap.Width;                    
                } 
            }
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            try
            {                
                pd.DefaultPageSettings.PaperSize = new PaperSize("Letter", 827, 1169);
                //pd.DefaultPageSettings.Landscape = true;
                pd.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);

                printPreviewDialog.Document = pd;

                //printPreviewDialog.ShowDialog();

                pd.Print();

                pd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing", ex.ToString());
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp1 = new Bitmap(this.pictureBoxBarcode1.Width, this.pictureBoxBarcode1.Height);
            pictureBoxBarcode1.DrawToBitmap(objBmp1, new Rectangle(0, 0, this.pictureBoxBarcode1.Width, this.pictureBoxBarcode1.Height));

            Bitmap objBmp2 = new Bitmap(this.pictureBoxBarcode2.Width, this.pictureBoxBarcode2.Height);
            pictureBoxBarcode2.DrawToBitmap(objBmp2, new Rectangle(0, 0, this.pictureBoxBarcode2.Width, this.pictureBoxBarcode2.Height));

            Bitmap objBmp3 = new Bitmap(this.pictureBoxBarcode3.Width, this.pictureBoxBarcode3.Height);
            pictureBoxBarcode3.DrawToBitmap(objBmp3, new Rectangle(0, 0, this.pictureBoxBarcode3.Width, this.pictureBoxBarcode3.Height));            

            e.Graphics.DrawImage(objBmp1, 3, 30);
            e.Graphics.DrawImage(objBmp2, 273, 30);
            e.Graphics.DrawImage(objBmp3, 549, 30);            

            e.Graphics.DrawString(txtTitle1.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(13, 15));
            e.Graphics.DrawString(txtTitle2.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(289, 15));
            e.Graphics.DrawString(txtTitle3.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(565, 15));
        }

        private void txtTitle1_TextChanged(object sender, EventArgs e)
        {
            txtTitle2.Text = txtTitle1.Text;
            txtTitle3.Text = txtTitle1.Text;
        }

        private void btnGenerateForCode_Click(object sender, EventArgs e)
        {
            if (txtBarcodeForCode.Text.Count() != 0)
            {
                string barcode = txtBarcodeForCode.Text;
                Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    Font oFont = new Font("IDAutomationHC39M", 13);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                    graphics.DrawString("*" + barcode + "*", oFont, black, point);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    pictureBoxForCode.Image = bitmap;
                    pictureBoxForCode.Height = bitmap.Height;
                    pictureBoxForCode.Width = bitmap.Width;                    
                }
            }
        }

        private void btnPrintForCode_Click(object sender, EventArgs e)
        {            
            try
            {
                pd.DefaultPageSettings.PaperSize = new PaperSize("Letter", 827, 1169);
                //pd.DefaultPageSettings.Landscape = true;
                pd.PrintPage += new PrintPageEventHandler(this.printDocumentCode_PrintPage);

                printPreviewDialogCode.Document = pd;

                //printPreviewDialogCode.ShowDialog();

                pd.Print();

                pd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing", ex.ToString());
            }
        }

        private void printDocumentCode_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Barcode for Code to change password
            Bitmap objBmp4 = new Bitmap(this.pictureBoxForCode.Width, this.pictureBoxForCode.Height);
            pictureBoxForCode.DrawToBitmap(objBmp4, new Rectangle(0, 0, this.pictureBoxForCode.Width, this.pictureBoxForCode.Height));

            // Barcode for Code to change password
            e.Graphics.DrawImage(objBmp4, 10, 30);
            e.Graphics.DrawString(txtTitleForCode.Text, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 15));
        }

        #region TextBoxes Enter
        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtBarcode_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtTitle1_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtTitle1_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        #endregion

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
