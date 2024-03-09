using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp5
{
    class Mydatabase
    {
        private string connectstring = @"Data Source=DESKTOP-DQ8VDI6\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";
        private SqlConnection con;
        public Mydatabase()
        {
            con = new SqlConnection(connectstring);
        }
        public DataTable GetData(string sSql)
        {
            try
            {
                SqlDataAdapter mydata = new SqlDataAdapter(sSql, connectstring);
                DataTable dt = new DataTable();
                mydata.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}