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

        }
        private void linhvuc_Load(object sender, EventArgs e)
        {
            nap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mydatabase mydatabase = new Mydatabase();
            mydatabase.Delete_linh_vuc(textBox2.Text);
            nap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mydatabase newdata = new Mydatabase();
            newdata.Insert_linh_vuc(textBox1.Text);
            nap();
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
    }
}
