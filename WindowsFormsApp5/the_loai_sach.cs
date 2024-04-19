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
    public partial class Form1 : Form
    {
        QLBS db = new QLBS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nap();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
        void nap()
        {
            dataGridView1.DataSource = db.Loai_sach.ToList();
            dataGridView1.Columns["Ten_loai_sach"].HeaderText = "Tên loại sách";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loai_sach newloaisach = new Loai_sach();
            newloaisach.Ten_loai_sach = textBox1.Text;
            db.Loai_sach.Add(newloaisach);
            db.SaveChanges();
            nap();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ten = textBox2.Text;
            DataGridViewRow slece = dataGridView1.SelectedRows[0];
            string sua = slece.Cells[0].Value.ToString();
            Loai_sach lsupdate = db.Loai_sach.FirstOrDefault(kc => kc.Ten_loai_sach == sua);
            if (lsupdate != null)
            {
                lsupdate.Ten_loai_sach = textBox2.Text;
                db.SaveChanges();

            }
        }
    }
}
