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
    public partial class sua_nha_suat_ban : Form
    {
        QLBS db = new QLBS();
        public sua_nha_suat_ban()
        {
            InitializeComponent();
        }
        void nap()
        {
            dataGridView1.Rows.Clear();
            var query = from ls in db.Nha_xuat_ban select ls;
            foreach (var ls in query)
            {
                dataGridView1.Rows.Add(ls.Ten_nha_xuat_ban);
            }
        }
        private void sua_nha_suat_ban_Load(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tennha = textBox1.Text;
            Nha_xuat_ban newnha = new Nha_xuat_ban();
            newnha.Ten_nha_xuat_ban = tennha;
            db.Nha_xuat_ban.Add(newnha);
            db.SaveChanges();
            nap();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenMoi = textBox2.Text;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string tenCu = selectedRow.Cells[0].Value.ToString();
                Nha_xuat_ban CapNhat = db.Nha_xuat_ban.FirstOrDefault(ls => ls.Ten_nha_xuat_ban == tenCu);
                if (CapNhat != null)
                {
                    try
                    {
                        db.Nha_xuat_ban.Remove(CapNhat);
                        db.SaveChanges();
                        Nha_xuat_ban newnha = new Nha_xuat_ban();
                        newnha.Ten_nha_xuat_ban = tenMoi;
                        db.Nha_xuat_ban.Add(newnha);
                        db.SaveChanges();
                        textBox2.Text = "";
                        nap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật nhà xuất bản: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà xuất bản để cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Nha_xuat_ban tgd = db.Nha_xuat_ban.FirstOrDefault(t => t.Ten_nha_xuat_ban == s);
                Sach xemsach = db.Saches.FirstOrDefault(xs => xs.Nha_xuat_ban.ToString() == s);
                if (tgd != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại sách này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (xemsach != null)
                            {
                                DialogResult ans = MessageBox.Show("Nhà xuất bản này hiện đang có trong sách bạn có muốn xóa trong dữ liệu ở trong sách không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                                if (ans == DialogResult.Yes)
                                {
                                    db.Saches.Remove(xemsach);
                                    db.Nha_xuat_ban.Remove(tgd);
                                    db.SaveChanges();
                                    nap();
                                }
                            }
                            else
                            {
                                db.Nha_xuat_ban.Remove(tgd);
                                db.SaveChanges();
                                nap();
                            }

                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà xuât bản cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại nhà xuất bản để xóa!");
            }
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
