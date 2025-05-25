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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            Form1 f = new Form1();
            f.Show();
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUsername cu = new ChangeUsername();
            cu.MdiParent = this;
            cu.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProduct mp = new ManageProduct();
            mp.MdiParent = this;
            mp.Show();
        }

        private void manageCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ManageCategory mc = new ManageCategory();
            mc.MdiParent = this;
            mc.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.MdiParent = this;
            rp.Show();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenrateBill gb = new GenrateBill();
            gb.MdiParent = this;
            gb.Show();
        }
    }
}
