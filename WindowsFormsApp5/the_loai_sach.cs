﻿using System;
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
    public partial class the_loai_sach : Form
    {
        QLBS db = new QLBS();
        public the_loai_sach()
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
            dataGridView1.Rows.Clear();
            var query = from ls in db.Loai_sach select ls;
            foreach (var item in query)
            {
                dataGridView1.Rows.Add(item.Ten_loai_sach);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenLoaiSach = textBox1.Text;
            Loai_sach newLoaiSach = new Loai_sach();
            newLoaiSach.Ten_loai_sach = tenLoaiSach;
            db.Loai_sach.Add(newLoaiSach);
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
                Loai_sach loaiSachCanCapNhat = db.Loai_sach.FirstOrDefault(ls => ls.Ten_loai_sach == tenCu);
                if (loaiSachCanCapNhat != null)
                {
                    try
                    {
                        db.Loai_sach.Remove(loaiSachCanCapNhat);
                        db.SaveChanges();
                        Loai_sach newLoaiSach = new Loai_sach();
                        newLoaiSach.Ten_loai_sach = tenMoi;
                        db.Loai_sach.Add(newLoaiSach);
                        db.SaveChanges();
                        textBox2.Text = "";
                        nap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật loại sách: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sách để cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tl = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Loai_sach tgd = db.Loai_sach.FirstOrDefault(t => t.Ten_loai_sach == tl);
                if (tgd != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại sách này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            db.Loai_sach.Remove(tgd);
                            db.SaveChanges();
                            nap();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sách cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một loại sách để xóa!");
            }
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