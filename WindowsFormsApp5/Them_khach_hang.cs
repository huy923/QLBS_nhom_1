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
        void nap()
        {
            comboBox1.DataSource = db.Tai_khoan.ToList();
            comboBox1.ValueMember = "user";
            comboBox1.DisplayMember = "pass";
        }
        public Them_khach_hang()
        {
            InitializeComponent();
        }

        private void Them_khach_hang_Load(object sender, EventArgs e)
        {
            nap();
        }
    }
}
