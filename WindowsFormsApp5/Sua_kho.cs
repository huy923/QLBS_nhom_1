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
    public partial class Sua_kho : Form
    {
        static QLBS db = new QLBS();
        public Sua_kho()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                numericUpDown1.Value = (int)row.Cells[2].Value;
            }
        }
        void nap()
        {
            dataGridView1.Rows.Clear();
            var query = from ls in db.Khoes select ls;
            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.MaSach, item.Sach.Ten_sach, item.So_luong);
            }
            dataGridView2.Rows.Clear();
            var selectsachs = from ls in db.Saches select ls;
            foreach (var item in selectsachs)
            {
                dataGridView2.Rows.Add(item.MaSach, item.Ten_sach, item.Tac_gia.Ten_tac_gia, item.Linh_vuc1.Linh_Vuc1, item.Gia_mua, item.Gia_bia, item.Lan_tai_ban, item.Nha_xuat_ban.Ten_nha_xuat_ban, item.Loai_sach1.Ten_loai_sach, item.Nam_xuat_ban);
            }
        }
        private void Sua_kho_Load(object sender, EventArgs e)
        {
            nap();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
            }
        }

        private void themsach_Click(object sender, EventArgs e)
        {
            string masach = textBox2.Text;
            int soLuongMoi = (int)numericUpDown2.Value;

            var existingItem = db.Khoes.FirstOrDefault(k => k.MaSach == masach);

            if (existingItem != null)
            {
                DialogResult result = MessageBox.Show("Mã sách đã tồn tại trong kho. Bạn có muốn cập nhật số lượng cho sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    existingItem.So_luong = soLuongMoi;
                    db.SaveChanges();
                }
            }
            else
            {
                Kho newkho = new Kho();
                newkho.MaSach = masach;
                newkho.So_luong = soLuongMoi;
                db.Khoes.Add(newkho);
                db.SaveChanges();
            }

            nap();
            textBox2.Text = "";
        }

        private void xoasach_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string masach = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Kho tonkho = db.Khoes.FirstOrDefault(t => t.MaSach == masach);
                if (tonkho != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tồn kho này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            db.Khoes.Remove(tonkho);
                            db.SaveChanges();
                            nap();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tồn kho cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells[0].Value.ToString();

                Kho sachToEdit = db.Khoes.FirstOrDefault(s => s.MaSach == maSach);

                if (sachToEdit != null)
                {
                    try
                    {
                        sachToEdit.So_luong = (int)numericUpDown1.Value;
                        db.SaveChanges();
                        nap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật số lượng sách: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách để cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.");
            }
        }

        private void thêmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trang_chu trangchu = new Trang_chu();
            trangchu.Show();
            this.Hide();
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
            linhvuc linhvuc = new linhvuc();
            linhvuc.Show();
            this.Hide();
        }

        private void sửaNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua_nha_suat_ban suanxb = new sua_nha_suat_ban();
            suanxb.Show();
            this.Hide();
        }

        private void sửaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua_sach suasach = new sua_sach();
            suasach.Show();
            this.Hide();
        }

        private void thểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            the_loai_sach theloaisach = new the_loai_sach();
            theloaisach.Show();
            this.Hide();
        }
    }
}