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
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_khach_hang newkhach_hang = new Them_khach_hang();
            newkhach_hang.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sửaTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sua_tac_gia tacgia = new Sua_tac_gia();
            tacgia.Show();
            this.Hide();
        }
    }
}
