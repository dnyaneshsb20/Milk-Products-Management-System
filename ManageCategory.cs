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
    public partial class ManageCategory : Form
    {
        DataTable dt = new DataTable();
        public ManageCategory()
        {
            InitializeComponent();
            gridViewManageCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9);
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milkDataSet10.Category' table. You can move, or remove it, as needed.
            LoadCategory();
            btnUpdateCategory.Enabled = false;
        }

        private void LoadCategory()
        {
            string strcmd = "SELECT CategoryID, CategoryName FROM Category ORDER BY CategoryName";
            dt = SQLHelper.FillData(strcmd);
            gridViewManageCategory.DataSource = dt;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewCategory.Text.Trim() == "")
                {
                    CommonDialogs.ShowWarningBox("New Category Cannot be Empty!");
                }
                else
                {
                    bool categoryExists = false;

                    foreach (DataGridViewRow row in gridViewManageCategory.Rows)
                    {
                        if (row.Cells["CategoryName"].Value.ToString() == txtNewCategory.Text)
                        {
                            categoryExists = true;
                            break;
                        }
                    }
                    if (categoryExists == true)
                    {
                        CommonDialogs.ShowWarningBox("Category is Already Exist!");
                    }
                    else
                    {
                        string strcmd = "INSERT INTO Category (CategoryName) VALUES('" + txtNewCategory.Text + "')";
                        SQLHelper.ExecuteNonQuery(strcmd);
                        CommonDialogs.ShowInfoBox("Category Added Sucessfully!");
                        txtNewCategory.ResetText();
                        LoadCategory();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewCategory.Text.Trim()=="")
                {
                    CommonDialogs.ShowInfoBox("Category Name Cannot be Empty!");
                }
                else
                {
                    bool categoryExists = false;

                    foreach (DataGridViewRow row in gridViewManageCategory.Rows)
                    {
                        if (row.Cells["CategoryName"].Value.ToString() == txtNewCategory.Text)
                        {
                            categoryExists = true;
                            break;
                        }
                    }
                    if (categoryExists == true)
                    {
                        CommonDialogs.ShowWarningBox("Category is already exist.");
                    }
                    else
                    {
                        int cid = Convert.ToInt32(lblCategoryID.Text);
                        string strcmd = "UPDATE Category SET" +
                            " CategoryName = '" + txtNewCategory.Text + "' WHERE(CategoryID = " + cid + ")";
                        SQLHelper.ExecuteNonQuery(strcmd);
                        LoadCategory();
                        txtNewCategory.ResetText();
                        CommonDialogs.ShowInfoBox("Catgeory Updated Sucessfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNewCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewManageCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell is not a header cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Set the font for the cell
                e.CellStyle.Font = new Font("Verdana", 9); // Set font family and size
                                                           // You can adjust font properties as needed
            }
        }
        int indexRow;
        private void gridViewManageCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdateCategory.Enabled = true;
                indexRow = e.RowIndex;
                DataGridViewRow row = gridViewManageCategory.Rows[indexRow];
                lblCategoryID.Text = row.Cells[0].Value.ToString();
                txtNewCategory.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
