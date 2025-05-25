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
    public partial class ChangePassword : Form
    {

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == "" || txtConfirmPassword.Text.Trim() == "")
            {
                CommonDialogs.ShowInfoBox("Please Fill Complete Infromation to Proceed!");
            }
            else
            {
                if (txtNewPassword.Text!=txtConfirmPassword.Text)
                {
                    CommonDialogs.ShowWarningBox("Password must be Same!");
                }
                else
                {
                    changeUPass();
                    CommonDialogs.ShowSucessfulBox("Password Changed Sucessfully!");
                    txtNewPassword.ResetText();
                    txtConfirmPassword.ResetText();
                }
            }
        }

        private void changeUPass()
        {
            string strcmd = "UPDATE Login SET UPassword =" + txtNewPassword.Text;
            SQLHelper.ExecuteNonQuery(strcmd);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
