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

namespace WindowsFormsApp5
{
    public partial class Sua_tac_gia : Form
    {
        private Them_khach_hang themkhachhang;
        private Sua_tac_gia suatacgia;
        private linhvuc linhvuc;
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
            new_tac_Gia.Nam_sinh = nam_sinh.Value;
            new_tac_Gia.Nam_mat = nam_mat.Value;
            string maTacGia = "TG" + (++tacGiaCount).ToString("D2");
            new_tac_Gia.MaTG = maTacGia;

            db.Tac_gia.Add(new_tac_Gia);
            db.SaveChanges();
            this.tac_giaTableAdapter.Fill(this.qLBSDataSet.Tac_gia);
        }

        private void Them_tac_gia_Load(object sender, EventArgs e)
        {
            this.tac_giaTableAdapter.Fill(this.qLBSDataSet.Tac_gia);
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
                nam_sinh.Value = namSinhDate;
            }
            DateTime namMatDate = new DateTime();
            if (DateTime.TryParse(namMat, out namMatDate))
            {
                nam_mat.Value = namMatDate;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string tenTacGia = ten.Text;
                string quenQuan = que.Text;
                DateTime namSinh = nam_sinh.Value;
                DateTime namMat = nam_mat.Value;
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
                    this.tac_giaTableAdapter.Fill(this.qLBSDataSet.Tac_gia);
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
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
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

        private void thêmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linhvuc linhvuc = new linhvuc();
            linhvuc.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trang_chu trangchu = new Trang_chu();
            trangchu.Show();
            this.Hide();
        }
    }
}
