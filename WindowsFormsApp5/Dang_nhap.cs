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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace WindowsFormsApp5
{
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Dang_ky form1 = new Dang_ky();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtuser.Text;
            string pass = txtpass.Text;
            try
            {
                Mydatabase database = new Mydatabase();
                string querry = $"SELECT * FROM Tai_khoan WHERE [user] = '{name}' AND pass = '{pass}'";
                DataTable ta = database.GetData(querry);
                if (ta.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Text = "";
                    txtpass.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
