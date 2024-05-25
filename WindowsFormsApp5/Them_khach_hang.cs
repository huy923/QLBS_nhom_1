using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Them_khach_hang : Form
    {
        QLBS db = new QLBS();
        public Them_khach_hang()
        {
            InitializeComponent();
        }
        private void Them_khach_hang_Load(object sender, EventArgs e)
        {
            nap();
        }
        private void nap()
        {
            hienthihoadon.Rows.Clear();
            dataGridView1.Rows.Clear();
            dataGridView3.Rows.Clear();
            textBox3.Text = "";
            var query = from hoadon in db.HoaDons
                        select hoadon;
            foreach (var item in query)
            {
                hienthihoadon.Rows.Add(item.MaHoaDon, item.Ten_khach_hang, item.Ngay_ban.Value.ToString("dd-MM-yyyy"), item.Tong_tien);
            }
            var cthd = from hoadon in db.Chi_tiet_hoa_don select hoadon;
            foreach (var item in cthd)
            {
                dataGridView1.Rows.Add(item.Ma_hoa_don, item.MaSach, item.Sach.Ten_sach, item.So_luong, (int)item.Gia_tien.Value,(int)item.Thanh_tien.Value);
            }
            var gvsach = from ls in db.Saches select ls;
            foreach (var item in gvsach)
            {
                dataGridView3.Rows.Add(item.MaSach, item.Ten_sach, (int)item.Gia_bia.Value, item.Tac_gia.Ten_tac_gia, item.Linh_vuc1.Linh_Vuc1, item.Lan_tai_ban, item.Nha_xuat_ban.Ten_nha_xuat_ban, item.Loai_sach1.Ten_loai_sach, item.Nam_xuat_ban);
            }
            textBox3.Text = GenerateNewMaHoaDon();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hienthihoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = hienthihoadon.Rows[e.RowIndex];
            string mahd = selectedRow.Cells[0].Value.ToString();
            string TenKhachHang = selectedRow.Cells[1].Value.ToString();
            string ngaycu = selectedRow.Cells[2].Value.ToString();
            textBox1.Text = TenKhachHang ?? "";
            DateTime ngaylap = new DateTime();
            if (DateTime.TryParse(ngaycu, out ngaylap))
            {
                dateTimePicker1.Value = ngaylap;
            }
            var chiTietHoaDon = db.Chi_tiet_hoa_don.Where(l => l.Ma_hoa_don == mahd).ToList();
            int totalQuantity = chiTietHoaDon.Sum(ct => ct.So_luong ?? 0);
            numericUpDown2.Value = totalQuantity > 0 ? totalQuantity : 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hienthihoadon.SelectedRows.Count > 0)
            {
                string mahd = hienthihoadon.SelectedRows[0].Cells[0].Value.ToString();
                HoaDon tgd = db.HoaDons.FirstOrDefault(t => t.MaHoaDon == mahd);
                Chi_tiet_hoa_don ct = db.Chi_tiet_hoa_don.FirstOrDefault(k => k.Ma_hoa_don == mahd);
                if (tgd != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            db.HoaDons.Remove(tgd);
                            if (ct != null)
                            {
                                db.Chi_tiet_hoa_don.Remove(ct);
                            }
                            db.SaveChanges();
                            nap();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hienthihoadon.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = hienthihoadon.SelectedRows[0];
                var maHoaDon = selectedRow.Cells[0].Value.ToString();
                HoaDon hoaDon = db.HoaDons.FirstOrDefault(s => s.MaHoaDon == maHoaDon);
                if (hoaDon != null)
                {
                    try
                    {
                        var chiTietHoaDons = db.Chi_tiet_hoa_don.Where(ct => ct.Ma_hoa_don == maHoaDon).ToList();
                        if (chiTietHoaDons.Count == 0)
                        {
                            MessageBox.Show("Không có chi tiết hóa đơn nào để cập nhật!", "Thông báo");
                            return;
                        }
                        hoaDon.Ngay_ban = dateTimePicker2.Value;
                        hoaDon.Ten_khach_hang = textBox1.Text;
                        Chi_tiet_hoa_don ctedit = db.Chi_tiet_hoa_don.FirstOrDefault(ct => ct.Ma_hoa_don == maHoaDon);
                        ctedit.So_luong = (int)numericUpDown2.Value;
                        ctedit.Gia_tien = ctedit.Sach.Gia_bia.Value * numericUpDown2.Value;
                        db.SaveChanges();
                        nap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cần sửa!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa!", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nhập tên khách hàng", "Thông báo");
                return;
            }

            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];
                string maSach = selectedRow.Cells[0].Value.ToString();
                int soLuongMoi = (int)numericUpDown1.Value;
                var khoSach = db.Khoes.FirstOrDefault(k => k.MaSach == maSach);
                if (khoSach == null)
                {
                    MessageBox.Show("Không còn sách '" + selectedRow.Cells[1].Value.ToString() + "' trong kho", "Thông báo");
                    return;
                }

                int soLuongHienTai = (int)khoSach.So_luong;
                int soLuongConLai = soLuongHienTai - soLuongMoi;

                if (soLuongConLai >= 0)
                {
                    int giaSach = Convert.ToInt32(selectedRow.Cells[2].Value);
                    int tongTien = giaSach * soLuongMoi;

                    DateTime ngayLap = dateTimePicker2.Value;
                    string maHoaDon = textBox3.Text;
                    HoaDon hoaDon = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);
                    if (hoaDon == null)
                    {
                        hoaDon = new HoaDon
                        {
                            MaHoaDon = maHoaDon,
                            Ten_khach_hang = textBox2.Text,
                            Ngay_ban = ngayLap,
                            Tong_tien = tongTien
                        };
                        db.HoaDons.Add(hoaDon);
                    }
                    else
                    {
                        hoaDon.Tong_tien += tongTien;
                    }

                    Chi_tiet_hoa_don chiTietHD = new Chi_tiet_hoa_don
                    {
                        Ma_hoa_don = maHoaDon,
                        MaSach = maSach,
                        So_luong = soLuongMoi,
                        Gia_tien = giaSach,
                        Thanh_tien = tongTien
                    };
                    db.Chi_tiet_hoa_don.Add(chiTietHD);
                    khoSach.So_luong = soLuongConLai;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Không còn sách '" + selectedRow.Cells["TenSachColumn"].Value.ToString() + "' trong kho", "Thông báo"); // Thay "TenSachColumn" bằng tên cột chứa tên sách
                }
                nap();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong bảng.", "Thông báo");
            }
        }


        private string GenerateNewMaHoaDon()
        {
            var lastHoaDon = db.HoaDons.OrderByDescending(hd => hd.MaHoaDon).FirstOrDefault();

            int newNumber = 1;

            if (lastHoaDon != null)
            {
                string lastMaHoaDon = lastHoaDon.MaHoaDon;
                string numberPart = lastMaHoaDon.Substring(2);
                newNumber = int.Parse(numberPart) + 1;
            }

            return "HD" + newNumber.ToString("D2");
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

        private void sửaTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sua_tac_gia sua_Tac_Gia = new Sua_tac_gia();
            sua_Tac_Gia.Show();
            this.Hide();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sửaKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sua_kho sua_Kho = new Sua_kho();
            sua_Kho.Show();
            this.Hide();
        }
    }
}
