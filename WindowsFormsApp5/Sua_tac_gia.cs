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
            //this.tac_giaTableAdapter.Update
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
