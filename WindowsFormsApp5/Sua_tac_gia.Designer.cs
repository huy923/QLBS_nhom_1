namespace WindowsFormsApp5
{
    partial class Sua_tac_gia
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
            this.ten = new System.Windows.Forms.TextBox();
            this.que = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.them = new System.Windows.Forms.Button();
            this.nam_sinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLBSDataSet = new WindowsFormsApp5.QLBSDataSet();
            this.tacgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tac_giaTableAdapter = new WindowsFormsApp5.QLBSDataSetTableAdapters.Tac_giaTableAdapter();
            this.maTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nammatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_mat = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(228, 150);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(339, 31);
            this.ten.TabIndex = 0;
            // 
            // que
            // 
            this.que.Location = new System.Drawing.Point(228, 207);
            this.que.Name = "que";
            this.que.Size = new System.Drawing.Size(339, 31);
            this.que.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tác giả : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm Mất : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Năm Sinh : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quê quán : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.kiểmTraHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources.button__2_;
            this.pictureBox5.Location = new System.Drawing.Point(1109, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(39, 489);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(109, 60);
            this.them.TabIndex = 12;
            this.them.Text = "Thêm ";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // nam_sinh
            // 
            this.nam_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nam_sinh.Location = new System.Drawing.Point(228, 271);
            this.nam_sinh.Name = "nam_sinh";
            this.nam_sinh.Size = new System.Drawing.Size(339, 31);
            this.nam_sinh.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTGDataGridViewTextBoxColumn,
            this.tentacgiaDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.namsinhDataGridViewTextBoxColumn,
            this.nammatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tacgiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(573, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 402);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // qLBSDataSet
            // 
            this.qLBSDataSet.DataSetName = "QLBSDataSet";
            this.qLBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacgiaBindingSource
            // 
            this.tacgiaBindingSource.DataMember = "Tac_gia";
            this.tacgiaBindingSource.DataSource = this.qLBSDataSet;
            // 
            // tac_giaTableAdapter
            // 
            this.tac_giaTableAdapter.ClearBeforeFill = true;
            // 
            // maTGDataGridViewTextBoxColumn
            // 
            this.maTGDataGridViewTextBoxColumn.DataPropertyName = "MaTG";
            this.maTGDataGridViewTextBoxColumn.HeaderText = "MaTG";
            this.maTGDataGridViewTextBoxColumn.Name = "maTGDataGridViewTextBoxColumn";
            // 
            // tentacgiaDataGridViewTextBoxColumn
            // 
            this.tentacgiaDataGridViewTextBoxColumn.DataPropertyName = "Ten_tac_gia";
            this.tentacgiaDataGridViewTextBoxColumn.HeaderText = "Ten_tac_gia";
            this.tentacgiaDataGridViewTextBoxColumn.Name = "tentacgiaDataGridViewTextBoxColumn";
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Que_quan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Que_quan";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            // 
            // namsinhDataGridViewTextBoxColumn
            // 
            this.namsinhDataGridViewTextBoxColumn.DataPropertyName = "Nam_sinh";
            this.namsinhDataGridViewTextBoxColumn.HeaderText = "Nam_sinh";
            this.namsinhDataGridViewTextBoxColumn.Name = "namsinhDataGridViewTextBoxColumn";
            // 
            // nammatDataGridViewTextBoxColumn
            // 
            this.nammatDataGridViewTextBoxColumn.DataPropertyName = "Nam_mat";
            this.nammatDataGridViewTextBoxColumn.HeaderText = "Nam_mat";
            this.nammatDataGridViewTextBoxColumn.Name = "nammatDataGridViewTextBoxColumn";
            // 
            // nam_mat
            // 
            this.nam_mat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nam_mat.Location = new System.Drawing.Point(228, 344);
            this.nam_mat.Name = "nam_mat";
            this.nam_mat.Size = new System.Drawing.Size(339, 31);
            this.nam_mat.TabIndex = 17;
            // 
            // Sua_tac_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources._1026345;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 657);
            this.Controls.Add(this.nam_mat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nam_sinh);
            this.Controls.Add(this.them);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.que);
            this.Controls.Add(this.ten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Sua_tac_gia";
            this.Text = "Them_tac_gia";
            this.Load += new System.EventHandler(this.Them_tac_gia_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox que;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DateTimePicker nam_sinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLBSDataSet qLBSDataSet;
        private System.Windows.Forms.BindingSource tacgiaBindingSource;
        private QLBSDataSetTableAdapters.Tac_giaTableAdapter tac_giaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nammatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker nam_mat;
    }
}