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
            hienthihoadon.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
            hienthihoadon.Columns.Add("Ten_khach_hang", "Tên Khách Hàng");  
            hienthihoadon.Columns.Add("Ngay_ban", "Ngày Bán");
            hienthihoadon.Columns.Add("Tong_tien", "Tổng Tiền");
            var query = from hoadon in db.HoaDons
                        select hoadon;


            foreach (var item in query)
            {
                hienthihoadon.Rows.Add(item.MaHoaDon, item.Ten_khach_hang, item.Ngay_ban.Value.ToString("dd-MM-yyyy"), item.Tong_tien);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
