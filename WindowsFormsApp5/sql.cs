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
                SqlDataAdapter mydata = new SqlDataAdapter(sSql, con);
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
        public void Insert_user(string user, string pass)
        {
            try
            {
<<<<<<< HEAD
                SqlCommand cmd = new SqlCommand($"INSERT INTO Tai_khoan ([user], pass) VALUES ('{user}', '{pass}')", con);
=======
                SqlCommand cmd = new SqlCommand($"INSERT INTO TAI_KHOAN ([USER], PASS) VALUES ('{user}', '{pass}')", con);
>>>>>>> huy
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exists. Please choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public void command(string CMD) {
            try
            {
<<<<<<< HEAD
                SqlCommand cmd = new SqlCommand($"UPDATE Tai_khoan SET [user] = '{newuser}', pass = '{newpass}' WHERE [user] = '{user}' AND pass = '{pass}';", con);
=======
                SqlCommand cmd = new SqlCommand(CMD, con);
>>>>>>> huy
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}