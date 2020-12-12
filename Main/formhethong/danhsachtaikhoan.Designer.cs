
namespace formhethong
{
    partial class danhsachtaikhoan
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
            this.dgvdanhsachtaikhoan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btthemtk = new System.Windows.Forms.Button();
            this.btcapnhattk = new System.Windows.Forms.Button();
            this.btxoatk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdanhsachtaikhoan
            // 
            this.dgvdanhsachtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachtaikhoan.Location = new System.Drawing.Point(12, 85);
            this.dgvdanhsachtaikhoan.Name = "dgvdanhsachtaikhoan";
            this.dgvdanhsachtaikhoan.RowHeadersWidth = 51;
            this.dgvdanhsachtaikhoan.RowTemplate.Height = 24;
            this.dgvdanhsachtaikhoan.Size = new System.Drawing.Size(1140, 208);
            this.dgvdanhsachtaikhoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // btthemtk
            // 
            this.btthemtk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemtk.Location = new System.Drawing.Point(96, 351);
            this.btthemtk.Name = "btthemtk";
            this.btthemtk.Size = new System.Drawing.Size(197, 48);
            this.btthemtk.TabIndex = 2;
            this.btthemtk.Text = "Thêm tài khoản";
            this.btthemtk.UseVisualStyleBackColor = true;
            // 
            // btcapnhattk
            // 
            this.btcapnhattk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcapnhattk.Location = new System.Drawing.Point(834, 351);
            this.btcapnhattk.Name = "btcapnhattk";
            this.btcapnhattk.Size = new System.Drawing.Size(224, 48);
            this.btcapnhattk.TabIndex = 3;
            this.btcapnhattk.Text = "Cập nhật tài khoản";
            this.btcapnhattk.UseVisualStyleBackColor = true;
            // 
            // btxoatk
            // 
            this.btxoatk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoatk.Location = new System.Drawing.Point(553, 351);
            this.btxoatk.Name = "btxoatk";
            this.btxoatk.Size = new System.Drawing.Size(78, 48);
            this.btxoatk.TabIndex = 4;
            this.btxoatk.Text = "Xoá";
            this.btxoatk.UseVisualStyleBackColor = true;
            // 
            // danhsachtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.btxoatk);
            this.Controls.Add(this.btcapnhattk);
            this.Controls.Add(this.btthemtk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdanhsachtaikhoan);
            this.Name = "danhsachtaikhoan";
            this.Text = "danhsachtaikhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdanhsachtaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemtk;
        private System.Windows.Forms.Button btcapnhattk;
        private System.Windows.Forms.Button btxoatk;
    }
}