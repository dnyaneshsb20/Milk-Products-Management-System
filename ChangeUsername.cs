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
    public partial class ChangeUsername : Form
    {

        public ChangeUsername()
        {
            InitializeComponent();
        }

        private void btnChnageUserName_Click(object sender, EventArgs e)
        {
            if (txtNewUserName.Text.Trim() == "" || txtConfirmUserName.Text.Trim() == "")
            {
                CommonDialogs.ShowInfoBox("Please Fill Complete Infromation to Proceed!");
            }
            else
            {
                if (txtNewUserName.Text!=txtConfirmUserName.Text)
                {
                    CommonDialogs.ShowWarningBox("Username must be Same!");
                }
                else
                {
                    changeUName();
                    CommonDialogs.ShowSucessfulBox("Username Changed Sucessfully");
                    txtNewUserName.ResetText();
                    txtConfirmUserName.ResetText();
                }
            }
        }

        private void  changeUName()
        {
            string strcmd= "UPDATE Login SET UName =" + txtNewUserName.Text;
            SQLHelper.ExecuteNonQuery(strcmd);
        }

        private void ChangeUsername_Load(object sender, EventArgs e)
        {
            txtNewUserName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
