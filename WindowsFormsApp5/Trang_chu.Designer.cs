﻿namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trang_chu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sửaTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKháchHàngToolStripMenuItem,
            this.thêmTácGiảToolStripMenuItem,
            this.kiểmTraHóaĐơnToolStripMenuItem,
            this.sửaTácGiảToolStripMenuItem,
            this.linhVựcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sửaTácGiảToolStripMenuItem
            // 
            this.sửaTácGiảToolStripMenuItem.Name = "sửaTácGiảToolStripMenuItem";
            this.sửaTácGiảToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sửaTácGiảToolStripMenuItem.Text = "Sửa tác giả";
            this.sửaTácGiảToolStripMenuItem.Click += new System.EventHandler(this.sửaTácGiảToolStripMenuItem_Click);
            // 
            // linhVựcToolStripMenuItem
            // 
            this.linhVựcToolStripMenuItem.Name = "linhVựcToolStripMenuItem";
            this.linhVựcToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.linhVựcToolStripMenuItem.Text = "Lĩnh vực";
            this.linhVựcToolStripMenuItem.Click += new System.EventHandler(this.linhVựcToolStripMenuItem_Click);
            // 
            // Trang_chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Trang_chu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhVựcToolStripMenuItem;
    }
}