using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProductsManagement
{
    public class SQLHelper
    {
        public static SqlConnection GetConnection()
        {
            string strCon = "Data Source=DESKTOP-8V96E3J\\SQLEXPRESS;Initial Catalog=Milk;Integrated Security=True";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
        public static void ExecuteNonQuery(string strcmd)
        {
            //insert/update/deletes
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(strcmd, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable FillData(string strcmd)
        {
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataAdapter dtadp = new SqlDataAdapter();
                dtadp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dtadp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
