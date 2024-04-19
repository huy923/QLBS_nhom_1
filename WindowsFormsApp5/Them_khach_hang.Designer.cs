namespace WindowsFormsApp5
{
    partial class Them_khach_hang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.qLBS_hoa_don = new WindowsFormsApp5.QLBS_hoa_don();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new WindowsFormsApp5.QLBS_hoa_donTableAdapters.HoaDonTableAdapter();
            this.hienthihoadon = new System.Windows.Forms.DataGridView();
            this.chitiethaodonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chi_tiet_hao_donTableAdapter = new WindowsFormsApp5.QLBS_hoa_donTableAdapters.Chi_tiet_hao_donTableAdapter();
            this.fKChitiethaodonHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBShoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBS_hoa_don)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthihoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethaodonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChitiethaodonHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBShoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.kiểmTraHóaĐơnToolStripMenuItem,
            this.sửaTácGiảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            // 
            // thêmTácGiảToolStripMenuItem
            // 
            this.thêmTácGiảToolStripMenuItem.Name = "thêmTácGiảToolStripMenuItem";
            this.thêmTácGiảToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.thêmTácGiảToolStripMenuItem.Text = "Thêm tác giả";
            // 
            // kiểmTraHóaĐơnToolStripMenuItem
            // 
            this.kiểmTraHóaĐơnToolStripMenuItem.Name = "kiểmTraHóaĐơnToolStripMenuItem";
            this.kiểmTraHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kiểmTraHóaĐơnToolStripMenuItem.Text = "Kiểm tra hóa đơn";
            // 
            // sửaTácGiảToolStripMenuItem
            // 
            this.sửaTácGiảToolStripMenuItem.Name = "sửaTácGiảToolStripMenuItem";
            this.sửaTácGiảToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.sửaTácGiảToolStripMenuItem.Text = "sửa tác giả";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources.button__2_;
            this.pictureBox5.Location = new System.Drawing.Point(1218, -10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // qLBS_hoa_don
            // 
            this.qLBS_hoa_don.DataSetName = "QLBS_hoa_don";
            this.qLBS_hoa_don.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLBS_hoa_don;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // hienthihoadon
            // 
            this.hienthihoadon.AllowUserToAddRows = false;
            this.hienthihoadon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthihoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hienthihoadon.BackgroundColor = System.Drawing.Color.White;
            this.hienthihoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hienthihoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hienthihoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.Ten_khach_hang,
            this.Ngay_ban,
            this.Tong_tien});
            this.hienthihoadon.Location = new System.Drawing.Point(9, 36);
            this.hienthihoadon.Name = "hienthihoadon";
            this.hienthihoadon.ReadOnly = true;
            this.hienthihoadon.Size = new System.Drawing.Size(1203, 276);
            this.hienthihoadon.TabIndex = 13;
            // 
            // chitiethaodonBindingSource
            // 
            this.chitiethaodonBindingSource.DataMember = "Chi_tiet_hao_don";
            this.chitiethaodonBindingSource.DataSource = this.qLBS_hoa_don;
            // 
            // chi_tiet_hao_donTableAdapter
            // 
            this.chi_tiet_hao_donTableAdapter.ClearBeforeFill = true;
            // 
            // fKChitiethaodonHoaDonBindingSource
            // 
            this.fKChitiethaodonHoaDonBindingSource.DataMember = "FK_Chi_tiet_hao_don_HoaDon";
            this.fKChitiethaodonHoaDonBindingSource.DataSource = this.hoaDonBindingSource;
            // 
            // qLBShoadonBindingSource
            // 
            this.qLBShoadonBindingSource.DataSource = this.qLBS_hoa_don;
            this.qLBShoadonBindingSource.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(365, 566);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 17);
            this.listBox1.TabIndex = 14;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // Ten_khach_hang
            // 
            this.Ten_khach_hang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_khach_hang.HeaderText = "Tên Khách Hàng";
            this.Ten_khach_hang.Name = "Ten_khach_hang";
            this.Ten_khach_hang.ReadOnly = true;
            // 
            // Ngay_ban
            // 
            this.Ngay_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay_ban.HeaderText = "Ngày Bán";
            this.Ngay_ban.Name = "Ngay_ban";
            this.Ngay_ban.ReadOnly = true;
            // 
            // Tong_tien
            // 
            this.Tong_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tong_tien.HeaderText = "Tổng Tiền";
            this.Tong_tien.Name = "Tong_tien";
            this.Tong_tien.ReadOnly = true;
            // 
            // Them_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 729);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hienthihoadon);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Them_khach_hang";
            this.Text = "u";
            this.Load += new System.EventHandler(this.Them_khach_hang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBS_hoa_don)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthihoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethaodonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKChitiethaodonHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBShoadonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaTácGiảToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private QLBS_hoa_don qLBS_hoa_don;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLBS_hoa_donTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridView hienthihoadon;
        private System.Windows.Forms.BindingSource chitiethaodonBindingSource;
        private QLBS_hoa_donTableAdapters.Chi_tiet_hao_donTableAdapter chi_tiet_hao_donTableAdapter;
        private System.Windows.Forms.BindingSource fKChitiethaodonHoaDonBindingSource;
        private System.Windows.Forms.BindingSource qLBShoadonBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_tien;
    }
}