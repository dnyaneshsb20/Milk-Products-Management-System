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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = getUname();
                string pass = getUPass();

                if (!(txtName.Text.Trim() == ""))
                {
                    if (txtName.Text == uname)
                    {
                        if (!(txtPass.Text.Trim() == ""))
                        {
                            if (txtPass.Text == pass)
                            {
                                this.Hide();
                                Main m = new Main();
                                m.Show();
                            }
                            else
                            {
                                CommonDialogs.ShowErrorBox("Enter Correct Password!");
                            }
                        }
                        else
                        {
                            CommonDialogs.ShowWarningBox("Enter Password!");
                        }
                    }
                    else
                    {
                        CommonDialogs.ShowErrorBox("Enter Correct Username!");
                    }
                }
                else
                {
                    CommonDialogs.ShowWarningBox("Enter Username!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getUname()
        {
            string strcmd = "SELECT UName FROM Login where UName='" + txtName.Text + "'";
            dt = SQLHelper.FillData(strcmd);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "";
        }

        private string getUPass()
        {
            string strcmd = "SELECT UPassword FROM Login where UPassword ='" + txtPass.Text + "'";
            dt = SQLHelper.FillData(strcmd);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                !Regex.IsMatch(e.KeyChar.ToString(), @"@#$%&"))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                !Regex.IsMatch(e.KeyChar.ToString(), @"@#$%&"))
            {
                e.Handled = true; // Suppress the key press
            }
        }
    }
}
