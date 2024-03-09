using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    internal class sql
    {
        string connectstring = @"Data Source=DESKTOP-DQ8VDI6\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
    }
    
}
