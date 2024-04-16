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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sua_tac_gia));
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
            this.tacgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBSDataSet = new WindowsFormsApp5.QLBSDataSet();
            this.tac_giaTableAdapter = new WindowsFormsApp5.QLBSDataSetTableAdapters.Tac_giaTableAdapter();
            this.nam_mat = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maTGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nammatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ten
            // 
            resources.ApplyResources(this.ten, "ten");
            this.ten.Name = "ten";
            // 
            // que
            // 
            resources.ApplyResources(this.que, "que");
            this.que.Name = "que";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.kiểmTraHóaĐơnToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            resources.ApplyResources(this.thêmKháchHàngToolStripMenuItem, "thêmKháchHàngToolStripMenuItem");
            // 
            // thêmTácGiảToolStripMenuItem
            // 
            this.thêmTácGiảToolStripMenuItem.Name = "thêmTácGiảToolStripMenuItem";
            resources.ApplyResources(this.thêmTácGiảToolStripMenuItem, "thêmTácGiảToolStripMenuItem");
            // 
            // kiểmTraHóaĐơnToolStripMenuItem
            // 
            this.kiểmTraHóaĐơnToolStripMenuItem.Name = "kiểmTraHóaĐơnToolStripMenuItem";
            resources.ApplyResources(this.kiểmTraHóaĐơnToolStripMenuItem, "kiểmTraHóaĐơnToolStripMenuItem");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::WindowsFormsApp5.Properties.Resources.button__2_;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.them, "them");
            this.them.Name = "them";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // nam_sinh
            // 
            resources.ApplyResources(this.nam_sinh, "nam_sinh");
            this.nam_sinh.Name = "nam_sinh";
            this.nam_sinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // tacgiaBindingSource
            // 
            this.tacgiaBindingSource.DataMember = "Tac_gia";
            this.tacgiaBindingSource.DataSource = this.qLBSDataSet;
            // 
            // qLBSDataSet
            // 
            this.qLBSDataSet.DataSetName = "QLBSDataSet";
            this.qLBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tac_giaTableAdapter
            // 
            this.tac_giaTableAdapter.ClearBeforeFill = true;
            // 
            // nam_mat
            // 
            resources.ApplyResources(this.nam_mat, "nam_mat");
            this.nam_mat.Name = "nam_mat";
            this.nam_mat.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTGDataGridViewTextBoxColumn,
            this.tentacgiaDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.namsinhDataGridViewTextBoxColumn,
            this.nammatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tacgiaBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maTGDataGridViewTextBoxColumn
            // 
            this.maTGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maTGDataGridViewTextBoxColumn.DataPropertyName = "MaTG";
            resources.ApplyResources(this.maTGDataGridViewTextBoxColumn, "maTGDataGridViewTextBoxColumn");
            this.maTGDataGridViewTextBoxColumn.Name = "maTGDataGridViewTextBoxColumn";
            this.maTGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tentacgiaDataGridViewTextBoxColumn
            // 
            this.tentacgiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tentacgiaDataGridViewTextBoxColumn.DataPropertyName = "Ten_tac_gia";
            resources.ApplyResources(this.tentacgiaDataGridViewTextBoxColumn, "tentacgiaDataGridViewTextBoxColumn");
            this.tentacgiaDataGridViewTextBoxColumn.Name = "tentacgiaDataGridViewTextBoxColumn";
            this.tentacgiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Que_quan";
            resources.ApplyResources(this.quequanDataGridViewTextBoxColumn, "quequanDataGridViewTextBoxColumn");
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            this.quequanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namsinhDataGridViewTextBoxColumn
            // 
            this.namsinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namsinhDataGridViewTextBoxColumn.DataPropertyName = "Nam_sinh";
            resources.ApplyResources(this.namsinhDataGridViewTextBoxColumn, "namsinhDataGridViewTextBoxColumn");
            this.namsinhDataGridViewTextBoxColumn.Name = "namsinhDataGridViewTextBoxColumn";
            this.namsinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nammatDataGridViewTextBoxColumn
            // 
            this.nammatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nammatDataGridViewTextBoxColumn.DataPropertyName = "Nam_mat";
            resources.ApplyResources(this.nammatDataGridViewTextBoxColumn, "nammatDataGridViewTextBoxColumn");
            this.nammatDataGridViewTextBoxColumn.Name = "nammatDataGridViewTextBoxColumn";
            this.nammatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sua_tac_gia
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nam_mat);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sua_tac_gia";
            this.Load += new System.EventHandler(this.Them_tac_gia_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private QLBSDataSet qLBSDataSet;
        private System.Windows.Forms.BindingSource tacgiaBindingSource;
        private QLBSDataSetTableAdapters.Tac_giaTableAdapter tac_giaTableAdapter;
        private System.Windows.Forms.DateTimePicker nam_mat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nammatDataGridViewTextBoxColumn;
    }
}