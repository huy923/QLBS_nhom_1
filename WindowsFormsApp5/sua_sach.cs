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

        }
        void nap()
        {
            dataGridView1.Rows.Clear();
            var query = from ls in db.Saches select ls;
            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.MaSach,item.Ten_sach,item.Tac_gia.Ten_tac_gia,item.Linh_vuc1.Linh_Vuc1,item.Gia_mua,item.Gia_bia,item.Lan_tai_ban,item.Nha_xuat_ban.Ten_nha_xuat_ban,item.Loai_sach1.Ten_loai_sach,item.Nam_xuat_ban);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from ls in 
        }

        private void sua_sach_Load(object sender, EventArgs e)
        {
            nap();
        }
    }
}
