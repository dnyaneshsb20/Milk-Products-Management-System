using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkProductsManagement
{
    public partial class PrintInvoice : Form
    {
        DataTable dt = new DataTable();
        private string billPrefix = "INV-";
        public PrintInvoice()
        {
            InitializeComponent();

        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            griViewPrintedBill.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
            //AdjustDataGridViewHeight();

        }

        public void LoadProducts(int invID)
        {
            try
            {
                string strcmd1 = "SELECT InvoiceNumber FROM Invoice WHERE(InvoiceID = " + invID + ")";
                dt = SQLHelper.FillData(strcmd1);
                string invoiceNumber = dt.Rows[0]["InvoiceNumber"].ToString();
                lblInvoiceNumber.Text = invoiceNumber;
                string strcmd2 = "SELECT Dated FROM Invoice WHERE(InvoiceID = " + invID + ")";
                dt = SQLHelper.FillData(strcmd2);
                string date = dt.Rows[0]["Dated"].ToString();
                lblDate.Text = date.ToString();
                string strcmd3 = "SELECT (Products.ProductName) AS Product_Name, CAST(Bills.Qty AS VARCHAR(20))+' '+" +
                                 " Units.UnitName AS Quantity, Bills.Price" +
                                 " FROM Bills INNER JOIN" +
                                 " Invoice ON Bills.InvoiceID = Invoice.InvoiceID INNER JOIN" +
                                 " Products ON Bills.ProductID = Products.ProductID INNER JOIN" +
                                 " Units ON Products.UnitID = Units.UnitID" +
                                 " WHERE(Bills.InvoiceID = " + invID + ")" +
                                 " ORDER BY Products.ProductName";
                dt = SQLHelper.FillData(strcmd3);
                griViewPrintedBill.DataSource = dt;
                AdjustDataGridViewHeight();
                Total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string discamt1;
        private void Total()
        {
            double total;
            try
            {
                total = 0;
                for (int i = 0; i <= griViewPrintedBill.Rows.Count - 1; i++)
                {
                    total += double.Parse(griViewPrintedBill.Rows[i].Cells[2].Value.ToString());
                }
                lblTotal.Text = "₹" + total.ToString();
                discamt1 = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                string billName = billPrefix + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                printDocument.DocumentName = billName + ".pdf";
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                Panel pnl = pnlBill;
                Bitmap panelBitmap = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(panelBitmap, new Rectangle(0, 0, pnl.Width, pnl.Height));
                g.DrawImage(panelBitmap, e.MarginBounds.Location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void griViewPrintedBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                // Check if the current cell is not a header cell
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Set the font for the cell
                    e.CellStyle.Font = new Font("Verdana", 9); // Set font family and size
                                                               // You can adjust font properties as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDiscount(string txt)
        {
            if (txt.Trim() == "")
            {
                lblTotalPayable.Text = lblTotal.Text;
            }
            else
            {
                lblTotalPayable.Text = "₹" + txt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdjustDataGridViewHeight()
        {
            //Calculate the total height of rows
            int totalRowHeight = 0;
            foreach (DataGridViewRow row in griViewPrintedBill.Rows)
            {
                totalRowHeight += row.Height;
            }

            // Set the height of the DataGridView
            griViewPrintedBill.Height = totalRowHeight + griViewPrintedBill.ColumnHeadersHeight + 2; // Add a small buffer

            //form height
            this.Height = griViewPrintedBill.Bottom + 100; //padding

            //position of labels below the DataGridView
            lblTBMain.Location = new Point(lblTBMain.Left, griViewPrintedBill.Bottom + 10);
            lblTotal.Location = new Point(lblTotal.Left, griViewPrintedBill.Bottom + 10);
            lblTPMain.Location = new Point(lblTPMain.Left, griViewPrintedBill.Bottom + 10);
            lblTotalPayable.Location = new Point(lblTotalPayable.Left, griViewPrintedBill.Bottom + 10);
            //size of the panel
            pnlBill.Height = this.ClientSize.Height + 20; //panel height
            pnlBill.Width = this.ClientSize.Width; //panel width
        }

        private void griViewPrintedBill_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //AdjustDataGridViewHeight();
        }

        private void griViewPrintedBill_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell is not a header cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Set the font for the cell
                e.CellStyle.Font = new Font("Verdana", 9); // Set font family and size
                                                           // You can adjust font properties as needed
            }
        }
    }
}
