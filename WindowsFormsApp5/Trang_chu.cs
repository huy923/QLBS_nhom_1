using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp5
{
    public partial class Trang_chu : Form
    {
        QLBS db = new QLBS();
        public Trang_chu()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            nap();
            label3.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }
        private void nap()
        {
            var gvsach = from ls in db.Saches select ls;
            foreach (var item in gvsach)
            {
                dataGridView3.Rows.Add(item.Ten_sach, item.Tac_gia.Ten_tac_gia, item.Linh_vuc1.Linh_Vuc1, item.Loai_sach1.Ten_loai_sach, item.Gia_bia, item.Lan_tai_ban, item.Ten_nha_xuat_ban, item.Nam_xuat_ban);
            }
            var doanhthu = db.HoaDons
                             .Where(sj => DbFunctions.TruncateTime(sj.Ngay_ban) == DbFunctions.TruncateTime(DateTime.Today))
                             .Sum(sj => sj.Tong_tien);
            textBox1.Text = doanhthu.ToString();
            var soluong = db.HoaDons
                            .Where(ji => DbFunctions.TruncateTime(ji.Ngay_ban) == DbFunctions.TruncateTime(DateTime.Today))
                            .Count();
            textBox2.Text = soluong.ToString();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
