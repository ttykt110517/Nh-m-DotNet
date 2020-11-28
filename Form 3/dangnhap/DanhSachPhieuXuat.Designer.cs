namespace dangnhap
{
    partial class DanhSachPhieuXuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTroiLaiQLNguyenLieu = new System.Windows.Forms.Button();
            this.btCapNhatPhieuXuat = new System.Windows.Forms.Button();
            this.btXoaPhieuXuat = new System.Windows.Forms.Button();
            this.btThemPhieuXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Nguyên Liệu Xuất";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTroiLaiQLNguyenLieu);
            this.panel2.Controls.Add(this.btCapNhatPhieuXuat);
            this.panel2.Controls.Add(this.btXoaPhieuXuat);
            this.panel2.Controls.Add(this.btThemPhieuXuat);
            this.panel2.Location = new System.Drawing.Point(12, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 57);
            this.panel2.TabIndex = 16;
            // 
            // btTroiLaiQLNguyenLieu
            // 
            this.btTroiLaiQLNguyenLieu.Location = new System.Drawing.Point(660, 15);
            this.btTroiLaiQLNguyenLieu.Name = "btTroiLaiQLNguyenLieu";
            this.btTroiLaiQLNguyenLieu.Size = new System.Drawing.Size(81, 30);
            this.btTroiLaiQLNguyenLieu.TabIndex = 7;
            this.btTroiLaiQLNguyenLieu.Text = "&Trở Về";
            this.btTroiLaiQLNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btCapNhatPhieuXuat
            // 
            this.btCapNhatPhieuXuat.Location = new System.Drawing.Point(518, 16);
            this.btCapNhatPhieuXuat.Name = "btCapNhatPhieuXuat";
            this.btCapNhatPhieuXuat.Size = new System.Drawing.Size(91, 29);
            this.btCapNhatPhieuXuat.TabIndex = 6;
            this.btCapNhatPhieuXuat.Text = "&Cập Nhật";
            this.btCapNhatPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // btXoaPhieuXuat
            // 
            this.btXoaPhieuXuat.Location = new System.Drawing.Point(178, 12);
            this.btXoaPhieuXuat.Name = "btXoaPhieuXuat";
            this.btXoaPhieuXuat.Size = new System.Drawing.Size(93, 31);
            this.btXoaPhieuXuat.TabIndex = 5;
            this.btXoaPhieuXuat.Text = "&Xóa";
            this.btXoaPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // btThemPhieuXuat
            // 
            this.btThemPhieuXuat.Location = new System.Drawing.Point(34, 13);
            this.btThemPhieuXuat.Name = "btThemPhieuXuat";
            this.btThemPhieuXuat.Size = new System.Drawing.Size(91, 30);
            this.btThemPhieuXuat.TabIndex = 4;
            this.btThemPhieuXuat.Text = "&Thêm";
            this.btThemPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // DanhSachPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "DanhSachPhieuXuat";
            this.Text = "Danh Sách Phiếu Xuất";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTroiLaiQLNguyenLieu;
        private System.Windows.Forms.Button btCapNhatPhieuXuat;
        private System.Windows.Forms.Button btXoaPhieuXuat;
        private System.Windows.Forms.Button btThemPhieuXuat;
    }
}