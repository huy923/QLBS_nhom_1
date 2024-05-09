namespace WindowsFormsApp5
{
    partial class sua_sach
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thêmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linh_Vuc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_mua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_bia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lan_tai_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_nha_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_loai_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources.button__2_;
            this.pictureBox5.Location = new System.Drawing.Point(1171, -11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSáchToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.kiểmTraHóaĐơnToolStripMenuItem,
            this.sửaTácGiảToolStripMenuItem,
            this.linhVựcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 23;
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
            this.sửaTácGiảToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sửaTácGiảToolStripMenuItem.Text = "Sửa tác giả";
            // 
            // linhVựcToolStripMenuItem
            // 
            this.linhVựcToolStripMenuItem.Name = "linhVựcToolStripMenuItem";
            this.linhVựcToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.linhVựcToolStripMenuItem.Text = "Lĩnh vực";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.Ten_sach,
            this.Ten_tac_gia,
            this.Linh_Vuc1,
            this.Gia_mua,
            this.Gia_bia,
            this.Lan_tai_ban,
            this.Ten_nha_xuat_ban,
            this.Ten_loai_sach,
            this.Nam_xuat_ban});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 322);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // thêmSáchToolStripMenuItem
            // 
            this.thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            this.thêmSáchToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.thêmSáchToolStripMenuItem.Text = "Thêm sách";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(177, 421);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 30);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaSach.Width = 54;
            // 
            // Ten_sach
            // 
            this.Ten_sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_sach.HeaderText = "Tên sách";
            this.Ten_sach.Name = "Ten_sach";
            this.Ten_sach.ReadOnly = true;
            this.Ten_sach.Width = 77;
            // 
            // Ten_tac_gia
            // 
            this.Ten_tac_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_tac_gia.HeaderText = "Tên tác giả";
            this.Ten_tac_gia.Name = "Ten_tac_gia";
            this.Ten_tac_gia.ReadOnly = true;
            this.Ten_tac_gia.Width = 86;
            // 
            // Linh_Vuc1
            // 
            this.Linh_Vuc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linh_Vuc1.HeaderText = "Lĩnh vực";
            this.Linh_Vuc1.Name = "Linh_Vuc1";
            this.Linh_Vuc1.ReadOnly = true;
            this.Linh_Vuc1.Width = 76;
            // 
            // Gia_mua
            // 
            this.Gia_mua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gia_mua.HeaderText = "Giá mua";
            this.Gia_mua.Name = "Gia_mua";
            this.Gia_mua.ReadOnly = true;
            this.Gia_mua.Width = 71;
            // 
            // Gia_bia
            // 
            this.Gia_bia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gia_bia.HeaderText = "Giá bìa";
            this.Gia_bia.Name = "Gia_bia";
            this.Gia_bia.ReadOnly = true;
            this.Gia_bia.Width = 65;
            // 
            // Lan_tai_ban
            // 
            this.Lan_tai_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lan_tai_ban.HeaderText = "Lần tái bản";
            this.Lan_tai_ban.Name = "Lan_tai_ban";
            this.Lan_tai_ban.ReadOnly = true;
            this.Lan_tai_ban.Width = 85;
            // 
            // Ten_nha_xuat_ban
            // 
            this.Ten_nha_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_nha_xuat_ban.HeaderText = "Tên nhà xuất bản";
            this.Ten_nha_xuat_ban.Name = "Ten_nha_xuat_ban";
            this.Ten_nha_xuat_ban.ReadOnly = true;
            this.Ten_nha_xuat_ban.Width = 90;
            // 
            // Ten_loai_sach
            // 
            this.Ten_loai_sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_loai_sach.HeaderText = "Loại sách";
            this.Ten_loai_sach.Name = "Ten_loai_sach";
            this.Ten_loai_sach.ReadOnly = true;
            this.Ten_loai_sach.Width = 72;
            // 
            // Nam_xuat_ban
            // 
            this.Nam_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nam_xuat_ban.HeaderText = "Năm xuất bản";
            this.Nam_xuat_ban.Name = "Nam_xuat_ban";
            this.Nam_xuat_ban.ReadOnly = true;
            this.Nam_xuat_ban.Width = 74;
            // 
            // sua_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1209, 681);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sua_sach";
            this.Text = "sua_sach";
            this.Load += new System.EventHandler(this.sua_sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhVựcToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_tac_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linh_Vuc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_mua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_bia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lan_tai_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_nha_xuat_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_loai_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_xuat_ban;
    }
}