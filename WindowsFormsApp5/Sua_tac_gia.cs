using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Metadata.Edm;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Sua_tac_gia : Form
    {
        QLBS db = new QLBS();
        private int tacGiaCount = 0;

        public Sua_tac_gia()
        {
            InitializeComponent();
            tacGiaCount = db.Tac_gia.Count();
        }

        private void them_Click(object sender, EventArgs e)
        {
            Tac_gia new_tac_Gia = new Tac_gia();

            new_tac_Gia.Ten_tac_gia = ten.Text;
            new_tac_Gia.Que_quan = que.Text;
            new_tac_Gia.Nam_sinh = dateTimeNamsinh.Value;
            new_tac_Gia.Nam_mat = dateTimeNamsinnammat.Value;
            string maTacGia = "TG" + (++tacGiaCount).ToString("D2");
            new_tac_Gia.MaTG = maTacGia;
            db.Tac_gia.Add(new_tac_Gia);
            db.SaveChanges();
            nap();
        }
        private void nap()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaTG", "Mã TG");
            dataGridView1.Columns.Add("Ten_tac_gia", "Tên Tác Giả");
            dataGridView1.Columns.Add("Que_quan", "Quê Quán");
            dataGridView1.Columns.Add("Nam_sinh", "Năm Sinh");
            dataGridView1.Columns.Add("Nam_mat", "Năm Mất");
            var query = from ls in db.Tac_gia
                        select new
                        {
                            ls.MaTG,
                            ls.Ten_tac_gia,
                            ls.Que_quan,
                            ls.Nam_sinh,
                            ls.Nam_mat
                        };

            foreach (var ls in query)
            {
                dataGridView1.Rows.Add(ls.MaTG, ls.Ten_tac_gia, ls.Que_quan, ls.Nam_sinh, ls.Nam_mat);
            }
        }
        private void Them_tac_gia_Load(object sender, EventArgs e)
        {
            nap();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string tenTacGia = selectedRow.Cells[1].Value?.ToString();
            string quenha = selectedRow.Cells[2].Value?.ToString();
            string namSinh = selectedRow.Cells[3].Value?.ToString();
            string namMat = selectedRow.Cells[4].Value?.ToString();
            ten.Text = tenTacGia ?? "";
            que.Text = quenha ?? "";
            DateTime namSinhDate = new DateTime();
            if (DateTime.TryParse(namSinh, out namSinhDate))
            {
                dateTimeNamsinh.Value = namSinhDate;
            }
            DateTime namMatDate = new DateTime();
            if (DateTime.TryParse(namMat, out namMatDate))
            {
                dateTimeNamsinnammat.Value = namMatDate;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenTacGia = ten.Text;
                string quenQuan = que.Text;
                DateTime namSinh = dateTimeNamsinh.Value;
                DateTime namMat = dateTimeNamsinnammat.Value;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string tacGiaID = selectedRow.Cells[0].Value.ToString(); 
                Tac_gia tacGiaToUpdate = db.Tac_gia.FirstOrDefault(tg => tg.MaTG == tacGiaID);
                if (tacGiaToUpdate != null)
                {
                    tacGiaToUpdate.Ten_tac_gia = tenTacGia;
                    tacGiaToUpdate.Que_quan = quenQuan;
                    tacGiaToUpdate.Nam_sinh = namSinh;
                    tacGiaToUpdate.Nam_mat = namMat;
                    db.SaveChanges();
                    nap();
                    MessageBox.Show("Đã cập nhật thông tin tác giả thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tác giả cần sửa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác giả để sửa!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tacGiaID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Tac_gia tacGiaToDelete = db.Tac_gia.FirstOrDefault(tg => tg.MaTG == tacGiaID);
                if (tacGiaToDelete != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.Tac_gia.Remove(tacGiaToDelete);
                        db.SaveChanges();
                        nap();
                        MessageBox.Show("Đã xóa tác giả thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tác giả cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác giả để xóa!");
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
