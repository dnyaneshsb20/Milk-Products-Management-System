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

namespace MilkProductsManagement
{
    public partial class GenrateBill : Form
    {
        DataTable dt = new DataTable();
        public GenrateBill()
        {
            InitializeComponent();
        }

        private void GenrateBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.productDataSet.Products);
            // TODO: This line of code loads data into the 'milkDataSet6.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.milkDataSet6.Units);
            // TODO: This line of code loads data into the 'milkDataSet3.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.milkDataSet3.Products);
            // TODO: This line of code loads data into the 'milkDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.milkDataSet.Products);

            LoadItem();

            panel2.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtQuantity.Focus();
            cmbItem.SelectedIndex = 0;

            gridViewItem.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
            dtpGenerateBill.MaxDate = DateTime.Today;
        }

        private void LoadItem()
        {
            try
            {
                string strcmd = "SELECT        ProductName, ProductID"+
                                " FROM Products"+
                                " ORDER BY ProductName";
                dt = SQLHelper.FillData(strcmd);
                cmbItem.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected int productID()
        {
            int ProductID;
            string strcmd = "SELECT        ProductID" +
                           " FROM Products " +
                           " WHERE(ProductName='" + this.cmbItem.GetItemText(this.cmbItem.SelectedItem) + "')";
            dt = SQLHelper.FillData(strcmd);
            ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
            return ProductID;
        }

        protected double getPrice()
        {
            string strcmd = "select Price from Products where ProductID=" + cmbItem.SelectedValue.ToString() ;
            dt = SQLHelper.FillData(strcmd);

            double price = Convert.ToDouble(dt.Rows[0]["Price"].ToString());
            price *= Convert.ToDouble(txtQuantity.Text);
            return price;
        }

        private bool IsItemExistInDataGridView(string selectedItem)
        {
            foreach (DataGridViewRow row in gridViewItem.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == selectedItem)
                {
                    return true;
                }
            }
            return false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text.Trim() == "")
                {
                    CommonDialogs.ShowInfoBox("Please Fill Complete Data to Proceed!");
                }
                else
                {
                    int pid = productID();
                    double price = getPrice();

                    // Check if the item already exists in the DataGridView
                    string selectedItem = cmbItem.Text;
                    bool itemExists = IsItemExistInDataGridView(selectedItem);
                    if (itemExists)
                    {
                        MessageBox.Show(cmbItem.Text + " is Already Exist in the Table!");
                        return;
                    }

                    // Item doesn't exist, so add it to the DataGridView
                    gridViewItem.Rows.Add(pid, cmbItem.Text, lblItemUnit.Text, txtQuantity.Text, price);
                    cmbItem.Focus();
                    txtQuantity.ResetText();
                    Total();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void Total()
        {
            double total;
            try
            {
                total = 0;
                for (int i = 0; i <= gridViewItem.Rows.Count - 1; i++)
                {
                    total += double.Parse(gridViewItem.Rows[i].Cells[4].Value.ToString());
                }
                lblTotalBill.Text = total.ToString();

                if (total>=500)
                {
                    lblDiscount.Visible = true;
                    txtDiscount.Visible = true;
                    lblFinalAmount.Visible = true;
                    lblFinalDiscount.Visible = true;
                }
                else
                {
                    lblDiscount.Visible = false;
                    txtDiscount.Visible = false;
                    lblFinalAmount.Visible = false;
                    lblFinalDiscount.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row = gridViewItem.CurrentCell.RowIndex;
                gridViewItem.Rows.RemoveAt(row);
                Total();
                txtQuantity.ResetText();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int indexRow;
        private void gridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridViewItem.Rows[indexRow];
                cmbItem.Text = row.Cells[1].Value.ToString();
                lblItemUnit.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newRow = gridViewItem.Rows[indexRow];
                newRow.Cells[1].Value = cmbItem.Text;
                newRow.Cells[2].Value = lblItemUnit.Text;
                newRow.Cells[3].Value = txtQuantity.Text;
                //This is for to get the updated price of the product
                double price = getPrice();
                newRow.Cells[4].Value = price;
                //This is to recalculate the total of the produut added in the gridview
                Total();
                txtQuantity.ResetText();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string strcmd = "SELECT        Units.UnitName FROM Products INNER JOIN                         Units ON Products.UnitID = Units.UnitID WHERE(Products.ProductID = " + cmbItem.SelectedValue.ToString() + ")";
                dt = SQLHelper.FillData(strcmd);
                if(dt.Rows.Count>0)
                {
                    lblItemUnit.Text = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PrintInvoice pi = new PrintInvoice();
                if (gridViewItem.Rows.Count == 0)
                {
                    CommonDialogs.ShowWarningBox("Please Add Items to Proceed!");
                }
                else if (txtQuantity.Text == "0")
                {
                    CommonDialogs.ShowWarningBox("Quantity Cannot be Zero!");
                }
                else
                {
                    string strDate = dtpGenerateBill.Value.ToString("yyyy-MM-dd");
                    int InvNo = 1;
                    string strcmd = "SELECT MAX(InvoiceNumber) FROM Invoice WHERE(Dated = '" + strDate + "')";
                    dt = SQLHelper.FillData(strcmd);
                    if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    {
                        InvNo = Convert.ToInt32(dt.Rows[0][0]) + 1;
                    }
                    else
                    {
                        InvNo = 1;
                    }

                    strcmd = "INSERT INTO Invoice (InvoiceNumber, Dated) VALUES(" + InvNo + ", '" + strDate + "')";
                    SQLHelper.ExecuteNonQuery(strcmd);

                    strcmd = "SELECT InvoiceID FROM Invoice WHERE(InvoiceNumber = " + InvNo + ") AND(Dated = '" + strDate + "') ";
                    dt = SQLHelper.FillData(strcmd);
                    int InvID = Convert.ToInt32(dt.Rows[0][0].ToString());

                    for (int i = 0; i < gridViewItem.Rows.Count; i++)
                    {
                        //product id
                        string strProductID = gridViewItem.Rows[i].Cells[0].Value.ToString();
                        //unit id
                        strcmd = "select UnitID from Units where UnitName='" + gridViewItem.Rows[i].Cells[2].Value.ToString() + "'";
                        dt = new DataTable();
                        dt = SQLHelper.FillData(strcmd);

                        string strUnitID = dt.Rows[0][0].ToString();
                        //qty
                        float strQty = Convert.ToSingle(gridViewItem.Rows[i].Cells[3].Value);
                        //price
                        float price = Convert.ToSingle(gridViewItem.Rows[i].Cells[4].Value);
                        string strGuid = Guid.NewGuid().ToString();

                        string strcmd1 = "INSERT INTO Bills (ProductID, UnitID, Qty, Dated, " +
                            " Guid, InvoiceID, Price)   VALUES(" + Convert.ToInt32(strProductID) + ", " + Convert.ToInt32(strUnitID) + ", " + strQty + ", '" + strDate + "', '" + strGuid + "', " + InvID + ", " + price + ")";
                        SQLHelper.ExecuteNonQuery(strcmd1);
                    }
                    pi.LoadProducts(InvID);
                    pi.LoadDiscount(lblFinalDiscount.Text);
                    pi.Show();
                    txtDiscount.ResetText();
                    panel2.Enabled = true;
                    txtQuantity.ResetText();
                    gridViewItem.Rows.Clear();
                    Total();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    cmbItem.SelectedIndex = 0;
                    lblTotalBill.Text = "";
                    lblFinalDiscount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter1.FillBy(this.milkDataSet3.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnNewBill_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel2.Enabled = true;
                txtQuantity.ResetText();
                gridViewItem.Rows.Clear();
                Total();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                cmbItem.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gridViewItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell is not a header cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Set the font for the cell
                e.CellStyle.Font = new Font("Verdana", 9); // Set font family and size
                                                          // You can adjust font properties as needed
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (txtDiscount.Text.Trim() == "")
            {
                lblFinalDiscount.Text = lblTotalBill.Text;
            }
            else if (double.TryParse(txtDiscount.Text,out number))
            {
                if (number>15)
                {
                    txtDiscount.Text = "";
                }
                else
                {
                    double amt = Convert.ToDouble(lblTotalBill.Text);
                    amt -= amt * (number/100);
                    amt = Math.Round(amt);
                    lblFinalDiscount.Text = amt.ToString();
                }
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
