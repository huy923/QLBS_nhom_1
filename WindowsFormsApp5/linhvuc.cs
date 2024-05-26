using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class linhvuc : Form
    {
        public linhvuc()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void nap()
        {
            string cmd = $"SELECT * FROM LINH_VUC";
            Mydatabase newdata = new Mydatabase();
            dataGridView1.DataSource = newdata.GetData(cmd);
            dataGridView1.Columns["Linh_vuc"].HeaderText = "Tên Lĩnh Vực";
        }
        private void linhvuc_Load(object sender, EventArgs e)
        {
            nap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mydatabase mydatabase = new Mydatabase();
            string cmd = $"DELETE FROM LINH_VUC WHERE [LINH_VUC] = '{textBox2.Text}'";
            mydatabase.command(cmd);
            nap();
            textBox2.Text = "";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mydatabase newdata = new Mydatabase();
            string cmd = $"INSERT INTO LINH_VUC (LINH_VUC) VALUES ('{textBox1.Text}')";
            newdata.command(cmd);
            nap();
            textBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string selectedValue = row.Cells[0].Value.ToString(); 
                textBox2.Text = selectedValue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mydatabase newdata = new Mydatabase();
            string cmd = $"UPDATE LINH_VUC SET LINH_VUC = '{textBox2.Text}' WHERE LINH_VUC = '{textBox2.Text}'";
            newdata.command(cmd);
            nap();
            textBox2.Text = "";
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_khach_hang newkhach_hang = new Them_khach_hang();
            newkhach_hang.Show();
            this.Hide();
        }

        private void sửaTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sua_tac_gia sua_Tac_Gia = new Sua_tac_gia();
            sua_Tac_Gia.Show();
            this.Hide();
        }

        private void linhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linhvuc newl = new linhvuc();
            newl.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trang_chu trangchu = new Trang_chu();
            trangchu.Show();
            this.Hide();
        }

        private void thêmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            the_loai_sach theloaisach = new the_loai_sach();
            theloaisach.Show();
            this.Hide();
        }

        private void sửaNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua_nha_suat_ban suanxb = new sua_nha_suat_ban();
            suanxb.Show();
            this.Hide();
        }

        private void sửaKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sua_kho sua_Kho = new Sua_kho();
            sua_Kho.Show();
            this.Hide();
        }

        private void sửaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua_sach suasach = new sua_sach();
            suasach.Show();
            this.Hide();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linhvuc lv = new linhvuc();
            lv.Show();
            this.Hide();
        }
    }
}
