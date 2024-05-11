using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class sua_sach : Form
    {
        QLBS db = new QLBS();
        public sua_sach()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string selectedValue = row.Cells[1].Value.ToString();
                string namSinh = row.Cells[9].Value.ToString();
                textBox1.Text = selectedValue;
                DateTime namuxatban = new DateTime();
                if (DateTime.TryParse(namSinh, out namuxatban))
                {
                    dateTimePicker1.Value = namuxatban;
                }
            }
        }
        void nap()
        {
            dataGridView1.Rows.Clear();
            var query = from ls in db.Saches select ls;
            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.MaSach, item.Ten_sach, item.Tac_gia.Ten_tac_gia, item.Linh_vuc1.Linh_Vuc1, item.Gia_mua, item.Gia_bia, item.Lan_tai_ban, item.Nha_xuat_ban.Ten_nha_xuat_ban, item.Loai_sach1.Ten_loai_sach, item.Nam_xuat_ban);
            }
            var authorQuery = from author in db.Tac_gia select author.Ten_tac_gia;
            tacgia.DataSource = authorQuery.ToArray();
            tacgia.DisplayMember = "Ten_tac_gia";
            var lv = from author in db.Linh_vuc select author.Linh_Vuc1;
            comboBox1.DataSource = lv.ToArray();
            comboBox1.DisplayMember = "Linh_vuc";
            var xb = from author in db.Nha_xuat_ban select author.Ten_nha_xuat_ban;
            comboBox2.DataSource = xb.ToArray();
            comboBox2.DisplayMember = "Ten_nha_xuat_ban";
            var loaisach = from author in db.Loai_sach select author.Ten_loai_sach;
            comboBox3.DataSource = loaisach.ToArray();
            comboBox3.DisplayMember = "Ten_loai_sach";
        }

        private void sua_sach_Load(object sender, EventArgs e)
        {
            nap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tacgia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
