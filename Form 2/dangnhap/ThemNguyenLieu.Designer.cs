namespace dangnhap
{
    partial class ThemNguyenLieu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThoatPhieu = new System.Windows.Forms.Button();
            this.btCapNhatPhieu = new System.Windows.Forms.Button();
            this.btXoaPhieuNhap = new System.Windows.Forms.Button();
            this.btThemPhieuNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 53);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(263, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Nguyên Liệu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btThoatPhieu);
            this.panel2.Controls.Add(this.btCapNhatPhieu);
            this.panel2.Controls.Add(this.btXoaPhieuNhap);
            this.panel2.Controls.Add(this.btThemPhieuNhap);
            this.panel2.Location = new System.Drawing.Point(12, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 57);
            this.panel2.TabIndex = 15;
            // 
            // btThoatPhieu
            // 
            this.btThoatPhieu.Location = new System.Drawing.Point(660, 15);
            this.btThoatPhieu.Name = "btThoatPhieu";
            this.btThoatPhieu.Size = new System.Drawing.Size(81, 30);
            this.btThoatPhieu.TabIndex = 7;
            this.btThoatPhieu.Text = "&Thoát";
            this.btThoatPhieu.UseVisualStyleBackColor = true;
            // 
            // btCapNhatPhieu
            // 
            this.btCapNhatPhieu.Location = new System.Drawing.Point(518, 16);
            this.btCapNhatPhieu.Name = "btCapNhatPhieu";
            this.btCapNhatPhieu.Size = new System.Drawing.Size(91, 29);
            this.btCapNhatPhieu.TabIndex = 6;
            this.btCapNhatPhieu.Text = "&Cập Nhật";
            this.btCapNhatPhieu.UseVisualStyleBackColor = true;
            // 
            // btXoaPhieuNhap
            // 
            this.btXoaPhieuNhap.Location = new System.Drawing.Point(178, 12);
            this.btXoaPhieuNhap.Name = "btXoaPhieuNhap";
            this.btXoaPhieuNhap.Size = new System.Drawing.Size(93, 31);
            this.btXoaPhieuNhap.TabIndex = 5;
            this.btXoaPhieuNhap.Text = "&Xóa";
            this.btXoaPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btThemPhieuNhap
            // 
            this.btThemPhieuNhap.Location = new System.Drawing.Point(34, 13);
            this.btThemPhieuNhap.Name = "btThemPhieuNhap";
            this.btThemPhieuNhap.Size = new System.Drawing.Size(91, 30);
            this.btThemPhieuNhap.TabIndex = 4;
            this.btThemPhieuNhap.Text = "&Thêm";
            this.btThemPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // ThemNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThemNguyenLieu";
            this.Text = "ThemNguyenLieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThoatPhieu;
        private System.Windows.Forms.Button btCapNhatPhieu;
        private System.Windows.Forms.Button btXoaPhieuNhap;
        private System.Windows.Forms.Button btThemPhieuNhap;
    }
}