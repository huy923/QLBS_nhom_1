namespace WindowsFormsApp5
{
    partial class Trang_chu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trang_chu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNXBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lĩnhVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Ten_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linh_Vuc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_loai_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_bia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lan_tai_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_nha_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.sửaTácGiảToolStripMenuItem,
            this.sửaNXBToolStripMenuItem,
            this.sửaKhoToolStripMenuItem,
            this.sửaSáchToolStripMenuItem,
            this.lĩnhVựcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // thêmTácGiảToolStripMenuItem
            // 
            this.thêmTácGiảToolStripMenuItem.Name = "thêmTácGiảToolStripMenuItem";
            this.thêmTácGiảToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.thêmTácGiảToolStripMenuItem.Text = "Thể loại sách";
            this.thêmTácGiảToolStripMenuItem.Click += new System.EventHandler(this.thêmTácGiảToolStripMenuItem_Click);
            // 
            // sửaTácGiảToolStripMenuItem
            // 
            this.sửaTácGiảToolStripMenuItem.Name = "sửaTácGiảToolStripMenuItem";
            this.sửaTácGiảToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.sửaTácGiảToolStripMenuItem.Text = "Sửa tác giả";
            this.sửaTácGiảToolStripMenuItem.Click += new System.EventHandler(this.sửaTácGiảToolStripMenuItem_Click);
            // 
            // sửaNXBToolStripMenuItem
            // 
            this.sửaNXBToolStripMenuItem.Name = "sửaNXBToolStripMenuItem";
            this.sửaNXBToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.sửaNXBToolStripMenuItem.Text = "Sửa NXB";
            this.sửaNXBToolStripMenuItem.Click += new System.EventHandler(this.sửaNXBToolStripMenuItem_Click);
            // 
            // sửaKhoToolStripMenuItem
            // 
            this.sửaKhoToolStripMenuItem.Name = "sửaKhoToolStripMenuItem";
            this.sửaKhoToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.sửaKhoToolStripMenuItem.Text = "Sửa kho";
            this.sửaKhoToolStripMenuItem.Click += new System.EventHandler(this.sửaKhoToolStripMenuItem_Click);
            // 
            // sửaSáchToolStripMenuItem
            // 
            this.sửaSáchToolStripMenuItem.Name = "sửaSáchToolStripMenuItem";
            this.sửaSáchToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.sửaSáchToolStripMenuItem.Text = "Sửa sách";
            this.sửaSáchToolStripMenuItem.Click += new System.EventHandler(this.sửaSáchToolStripMenuItem_Click);
            // 
            // lĩnhVựcToolStripMenuItem
            // 
            this.lĩnhVựcToolStripMenuItem.Name = "lĩnhVựcToolStripMenuItem";
            this.lĩnhVựcToolStripMenuItem.Size = new System.Drawing.Size(16, 29);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources.button__2_;
            this.pictureBox5.Location = new System.Drawing.Point(1822, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_sach,
            this.Ten_tac_gia,
            this.Linh_Vuc1,
            this.Ten_loai_sach,
            this.Gia_bia,
            this.Lan_tai_ban,
            this.Ten_nha_xuat_ban,
            this.Nam_xuat_ban});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.Location = new System.Drawing.Point(18, 69);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.RowHeadersWidth = 30;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.Size = new System.Drawing.Size(1719, 802);
            this.dataGridView3.TabIndex = 35;
            // 
            // Ten_sach
            // 
            this.Ten_sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_sach.HeaderText = "Tên sách";
            this.Ten_sach.MinimumWidth = 8;
            this.Ten_sach.Name = "Ten_sach";
            this.Ten_sach.ReadOnly = true;
            this.Ten_sach.Width = 136;
            // 
            // Ten_tac_gia
            // 
            this.Ten_tac_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_tac_gia.HeaderText = "Tên tác giả";
            this.Ten_tac_gia.MinimumWidth = 8;
            this.Ten_tac_gia.Name = "Ten_tac_gia";
            this.Ten_tac_gia.ReadOnly = true;
            this.Ten_tac_gia.Width = 125;
            // 
            // Linh_Vuc1
            // 
            this.Linh_Vuc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Linh_Vuc1.HeaderText = "Lĩnh vực";
            this.Linh_Vuc1.MinimumWidth = 8;
            this.Linh_Vuc1.Name = "Linh_Vuc1";
            this.Linh_Vuc1.ReadOnly = true;
            this.Linh_Vuc1.Width = 126;
            // 
            // Ten_loai_sach
            // 
            this.Ten_loai_sach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_loai_sach.HeaderText = "Loại sách";
            this.Ten_loai_sach.MinimumWidth = 8;
            this.Ten_loai_sach.Name = "Ten_loai_sach";
            this.Ten_loai_sach.ReadOnly = true;
            this.Ten_loai_sach.Width = 139;
            // 
            // Gia_bia
            // 
            this.Gia_bia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gia_bia.HeaderText = "Giá bìa";
            this.Gia_bia.MinimumWidth = 8;
            this.Gia_bia.Name = "Gia_bia";
            this.Gia_bia.ReadOnly = true;
            this.Gia_bia.Width = 86;
            // 
            // Lan_tai_ban
            // 
            this.Lan_tai_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lan_tai_ban.HeaderText = "Lần tái bản";
            this.Lan_tai_ban.MinimumWidth = 8;
            this.Lan_tai_ban.Name = "Lan_tai_ban";
            this.Lan_tai_ban.ReadOnly = true;
            this.Lan_tai_ban.Width = 152;
            // 
            // Ten_nha_xuat_ban
            // 
            this.Ten_nha_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_nha_xuat_ban.HeaderText = "Tên nhà xuất bản";
            this.Ten_nha_xuat_ban.MinimumWidth = 8;
            this.Ten_nha_xuat_ban.Name = "Ten_nha_xuat_ban";
            this.Ten_nha_xuat_ban.ReadOnly = true;
            this.Ten_nha_xuat_ban.Width = 176;
            // 
            // Nam_xuat_ban
            // 
            this.Nam_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nam_xuat_ban.HeaderText = "Năm xuất bản";
            this.Nam_xuat_ban.MinimumWidth = 8;
            this.Nam_xuat_ban.Name = "Nam_xuat_ban";
            this.Nam_xuat_ban.ReadOnly = true;
            this.Nam_xuat_ban.Width = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 914);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Doanh thu trong ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 994);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Số lượng sách : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(408, 912);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 36);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(408, 994);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(363, 36);
            this.textBox2.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1114, 914);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "Thứ xxxx, ngày yy, tháng zz, năm tttt";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 1082);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1850, 26);
            this.hScrollBar1.TabIndex = 41;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1850, 69);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(34, 1039);
            this.vScrollBar1.TabIndex = 42;
            // 
            // Trang_chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1884, 1106);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Trang_chu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNXBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lĩnhVựcToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_tac_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linh_Vuc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_loai_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_bia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lan_tai_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_nha_xuat_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_xuat_ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}