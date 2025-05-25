using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkProductsManagement
{
    public static class CommonDialogs
    {
        public static void ShowInfoBox(string str)
        {
            MessageBox.Show(str, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWarningBox(string str)
        {
            MessageBox.Show(str, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowErrorBox(string str)
        {
            MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowConfirmationBox(string str)
        {
            MessageBox.Show(str, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static void ShowSucessfulBox(string str)
        {
            MessageBox.Show(str, "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void InvalidDateSelection(string str)
        {
            MessageBox.Show(str, "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
