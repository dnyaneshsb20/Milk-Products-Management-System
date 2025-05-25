using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkProductsManagement
{
    public partial class ManageProduct : Form
    {
        string strcon = "Data Source=DESKTOP-8V96E3J\\SQLEXPRESS;Initial Catalog=Milk;Integrated Security=True";
        DataTable dt = new DataTable();
        public ManageProduct()
        {
            InitializeComponent();
            gridViewItemAdded.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milkDataSet5.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.milkDataSet5.Category);
            // TODO: This line of code loads data into the 'milkDataSet4.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter1.Fill(this.milkDataSet4.Units);
            // TODO: This line of code loads data into the 'milkDataSet2.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.milkDataSet2.Units);
            // TODO: This line of code loads data into the 'milkDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.milkDataSet1.Category);

            LoadProduct();
            LoadCategory();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadProduct()
        {
            string strcmd = "SELECT        Products.ProductName, Units.UnitName, Category.CategoryName, Products.Price FROM Category INNER JOIN Products ON Category.CategoryID = Products.CategoryID INNER JOIN Units ON Products.UnitID = Units.UnitID ORDER BY Products.ProductName";
            dt = SQLHelper.FillData(strcmd);
            gridViewItemAdded.DataSource = dt;
        }

        private void LoadCategory()
        {
            string strcmd = "SELECT CategoryName, CategoryID FROM Category ORDER BY CategoryName";
            dt = SQLHelper.FillData(strcmd);
            cmbItemCategory.DataSource = dt;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text.Trim() == "" || txtItemPrice.Text.Trim() == "")
                {
                    CommonDialogs.ShowInfoBox("Please Fill Complete Infromation to Add Item!");
                }
                else if (txtItemPrice.Text == "0")
                {
                    CommonDialogs.ShowWarningBox("Price Cannot be Zero!");
                }
                else
                {
                    // Assuming DataGridView name is dataGridViewProducts
                    bool productExists = false;

                    foreach (DataGridViewRow row in gridViewItemAdded.Rows)
                    {
                        if (row.Cells["ProductName"].Value.ToString() == txtItemName.Text &&
                           row.Cells["CategoryName"].Value.ToString() == cmbItemCategory.Text )
                        {
                            productExists = true;
                            break;
                        }
                    }
                    if (productExists == true)
                    {
                        CommonDialogs.ShowWarningBox("Product is Already Exist!");
                    }
                    else
                    {
                        string strcmd = "INSERT INTO Products" +
                                       " (ProductName, UnitID, CategoryID, Price)" +
                                        " VALUES('" + txtItemName.Text + "'," + cmbItemUnit.SelectedValue + "," + cmbItemCategory.SelectedValue + "," + txtItemPrice.Text + ")";
                        SQLHelper.ExecuteNonQuery(strcmd);
                        gridViewItemAdded.Refresh();
                        CommonDialogs.ShowInfoBox("Product Added Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtItemPrice_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the key press event
                e.Handled = true;
            }
        }

        private int ProductID()
        {
            int ProductID;
            string strcmd = "SELECT ProductID FROM Products WHERE ProductName = '" + txtItemName.Text + "'";
            dt = SQLHelper.FillData(strcmd);
            ProductID = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
            return ProductID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemPrice.Text == "0")
                {
                    CommonDialogs.ShowWarningBox("Price Cannot be Zero!");
                }
                else
                {

                    int pid = Convert.ToInt32(lblProductID.Text);
                    string strcmd = "UPDATE Products SET ProductName = '" + txtItemName.Text + "', Price = " + txtItemPrice.Text + ", UnitID = " + cmbItemUnit.SelectedValue + ", CategoryID = " + cmbItemCategory.SelectedValue + " WHERE ProductID = " + pid;
                    SQLHelper.ExecuteNonQuery(strcmd);
                    CommonDialogs.ShowInfoBox("Product Updated Sucessfully");
                    gridViewItemAdded.Refresh();
                    LoadProduct();
                    txtItemName.ResetText();
                    txtItemPrice.ResetText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAddItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int indexRow;
        private void gridViewItemAdded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAddItem.Enabled = false;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridViewItemAdded.Rows[indexRow];
                txtItemName.Text = row.Cells[0].Value.ToString();
                cmbItemUnit.Text = row.Cells[1].Value.ToString();
                cmbItemCategory.Text = row.Cells[2].Value.ToString();
                txtItemPrice.Text = row.Cells[3].Value.ToString();
                lblProductID.Text = ProductID().ToString();
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
                int row = gridViewItemAdded.CurrentCell.RowIndex;
                gridViewItemAdded.Rows.RemoveAt(row);
                string strcmd = "DELETE FROM Products WHERE ProductID = ( SELECT ProductID FROM Products WHERE ProductName = '" + txtItemName.Text + "' )";
                SQLHelper.ExecuteNonQuery(strcmd);
                CommonDialogs.ShowInfoBox("Product Deleted Sucessfully!");
                txtItemName.ResetText();
                txtItemPrice.ResetText();
                gridViewItemAdded.Refresh();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAddItem.Enabled = true;
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

        private void gridViewItemAdded_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
