using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkProductsManagement
{
    public partial class Reports : Form
    {
        DataTable dt = new DataTable();
        public Reports()
        {
            InitializeComponent();
            dtpFromDate.MaxDate = DateTime.Today;
            dtpToDate.MaxDate = DateTime.Today;
            gridViewReports.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
        }

        private void LoadReports()
        {
            try
            {
                string strcmd = "SELECT Products.ProductName AS Product_Name," +
                                " Category.CategoryName AS Category_Name, " +
                                " Bills.Dated AS Sells_Date," +
                                " CAST(SUM(Bills.Qty) AS VARCHAR(10)) + ' ' + Units.UnitName" +
                                " AS Quantity," +
                                " 'Rs ' + CAST(Sum(Bills.Price) AS VARCHAR(10)) AS Price" +
                                " FROM Bills" +
                                " INNER JOIN Products ON Bills.ProductID = Products.ProductID" +
                                " INNER JOIN Units ON Bills.UnitID = Units.UnitID" +
                                " INNER JOIN Invoice ON Bills.InvoiceID = Invoice.InvoiceID" +
                                " INNER JOIN Category ON Products.CategoryID = Category.CategoryID" +
                                " WHERE Bills.Dated >= '" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "' AND Bills.Dated <= '" + dtpToDate.Value.ToString("yyyy-MM-dd") + "'" +
                                " GROUP BY Products.ProductName, Category.CategoryName, Bills.Dated, Units.UnitName" +
                                " ORDER BY  Sells_Date, Products.ProductName";
                dt = SQLHelper.FillData(strcmd);
                gridViewReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Text==""||dtpToDate.Text=="")
            {
                CommonDialogs.ShowWarningBox("Select Date to Proceed!");
                return;
            }
            else
            {
                LoadReports();
                gridViewReports.Refresh();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell is not a header cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Set the font for the cell
                e.CellStyle.Font = new Font("Verdana", 9); // Set font family and size
                                                          // You can adjust font properties as needed
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                MessageBox.Show("To date cannot be earlier than From date. Please select a valid date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Revert To date to From date
                dtpToDate.Value = dtpFromDate.Value;
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value < dtpFromDate.Value)
            {
                MessageBox.Show("To date cannot be earlier than From date. Please select a valid date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Revert To date to From date
                dtpToDate.Value = dtpFromDate.Value;
            }
        }
    }
}