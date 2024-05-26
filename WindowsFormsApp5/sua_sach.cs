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
            var authorQuery = from author in db.Tac_gia select author;
            tacgia.DataSource = authorQuery.ToList();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string GetNextMaSach()
        {
            
            var lastSach = db.Saches.OrderByDescending(s => s.MaSach).FirstOrDefault();
            if (lastSach != null)
            {
                int lastNumber = int.Parse(lastSach.MaSach.Substring(2));
                return "MS" + (++lastNumber).ToString("D2");
            }
            else
            {
                return "MS01"; 
            }
        }
        private void them_Click(object sender, EventArgs e)
        {
            Sach new_sach = new Sach();
            string masach = GetNextMaSach();
            new_sach.MaSach = masach;
            new_sach.Ten_sach = textBox1.Text;
            new_sach.Nam_xuat_ban = dateTimePicker1.Value;
            var authorQuery = (from author in db.Tac_gia
                               where author.Ten_tac_gia == tacgia.Text
                               select author.MaTG).FirstOrDefault();

            if (authorQuery != null)
            {
                new_sach.MaTG = authorQuery.ToString();
            }
            if (comboBox1.SelectedValue != null )
            {
                new_sach.Linh_vuc = comboBox1.SelectedValue.ToString();
            }
            new_sach.Gia_mua = numericUpDowngiamua.Value;
            new_sach.Gia_bia = numericUpDowngiabia.Value;
            new_sach.Lan_tai_ban = (int)numericUpDowntaiban.Value;
            if (comboBox2.SelectedValue != null)
            {
                new_sach.Ten_nha_xuat_ban = comboBox2.SelectedValue.ToString();
            }
            if (comboBox3.SelectedValue != null)
            {
                new_sach.Loai_sach = comboBox3.SelectedValue.ToString();
            }
            db.Saches.Add(new_sach);
            db.SaveChanges();
            nap();
            numericUpDowngiamua.Value = 1000;
            numericUpDowngiabia.Value = 1000;
            numericUpDowntaiban.Value = 0;
            dateTimePicker1.Text = "12-5-2024";
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string masach = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Sach tgd = db.Saches.FirstOrDefault(t => t.MaSach == masach);
                if (tgd != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại sách này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            db.Saches.Remove(tgd);
                            db.SaveChanges();
                            nap();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa!");
            }
        }

        private void suasach_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells[0].Value.ToString(); 

                Sach sachToEdit = db.Saches.FirstOrDefault(s => s.MaSach == maSach);

                if (sachToEdit != null)
                {
                    sachToEdit.Ten_sach = textBox1.Text;
                    sachToEdit.Nam_xuat_ban = dateTimePicker1.Value;

                    if (tacgia.SelectedItem != null && tacgia.SelectedItem is Tac_gia selectedAuthor)
                    {
                        sachToEdit.MaTG = selectedAuthor.MaTG;
                    }

                    if (comboBox1.SelectedItem != null)
                    {
                        sachToEdit.Linh_vuc = comboBox1.SelectedItem.ToString();
                    }

                    if (comboBox2.SelectedItem != null)
                    {
                        sachToEdit.Ten_nha_xuat_ban = comboBox2.SelectedItem.ToString();
                    }

                    if (comboBox3.SelectedItem != null)
                    {
                        sachToEdit.Loai_sach = comboBox3.SelectedItem.ToString();
                    }
                    sachToEdit.Gia_mua = numericUpDowngiamua.Value;
                    sachToEdit.Gia_bia = numericUpDowngiabia.Value;
                    sachToEdit.Lan_tai_ban = (int)numericUpDowntaiban.Value;
                    db.SaveChanges();
                    nap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách cần sửa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để sửa!");
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
