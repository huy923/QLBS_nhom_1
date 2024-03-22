using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp5
{
    public partial class Trang_chu : Form
    {
        public Trang_chu()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            show_dada();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_dada()
        {
            try
            {
                Mydatabase data = new Mydatabase();
                string cmd = $"SELECT * FROM Tai_khoan";
                DataTable dt = data.GetData(cmd);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
