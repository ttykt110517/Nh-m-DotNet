
namespace formhethong
{
    partial class dsnhanvien
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
            this.dgvdsnv = new System.Windows.Forms.DataGridView();
            this.btmothemnv = new System.Windows.Forms.Button();
            this.btxoanv = new System.Windows.Forms.Button();
            this.btmosuanv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btlocnv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcalam = new System.Windows.Forms.ComboBox();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.cbquequan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdsnv
            // 
            this.dgvdsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsnv.Location = new System.Drawing.Point(12, 233);
            this.dgvdsnv.Name = "dgvdsnv";
            this.dgvdsnv.ReadOnly = true;
            this.dgvdsnv.RowHeadersWidth = 51;
            this.dgvdsnv.RowTemplate.Height = 24;
            this.dgvdsnv.Size = new System.Drawing.Size(1422, 390);
            this.dgvdsnv.TabIndex = 0;
            this.dgvdsnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsnv_CellClick);
            // 
            // btmothemnv
            // 
            this.btmothemnv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmothemnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btmothemnv.Location = new System.Drawing.Point(236, 642);
            this.btmothemnv.Name = "btmothemnv";
            this.btmothemnv.Size = new System.Drawing.Size(89, 39);
            this.btmothemnv.TabIndex = 1;
            this.btmothemnv.Text = "Thêm";
            this.btmothemnv.UseVisualStyleBackColor = true;
            this.btmothemnv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btxoanv
            // 
            this.btxoanv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btxoanv.Location = new System.Drawing.Point(709, 642);
            this.btxoanv.Name = "btxoanv";
            this.btxoanv.Size = new System.Drawing.Size(94, 39);
            this.btxoanv.TabIndex = 2;
            this.btxoanv.Text = "Xoá";
            this.btxoanv.UseVisualStyleBackColor = true;
            // 
            // btmosuanv
            // 
            this.btmosuanv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmosuanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btmosuanv.Location = new System.Drawing.Point(1105, 642);
            this.btmosuanv.Name = "btmosuanv";
            this.btmosuanv.Size = new System.Drawing.Size(90, 39);
            this.btmosuanv.TabIndex = 3;
            this.btmosuanv.Text = "Sửa";
            this.btmosuanv.UseVisualStyleBackColor = true;
            this.btmosuanv.Click += new System.EventHandler(this.btmosuanv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(574, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // btlocnv
            // 
            this.btlocnv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlocnv.Location = new System.Drawing.Point(1105, 157);
            this.btlocnv.Name = "btlocnv";
            this.btlocnv.Size = new System.Drawing.Size(75, 49);
            this.btlocnv.TabIndex = 6;
            this.btlocnv.Text = "Lọc";
            this.btlocnv.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(549, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(822, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ca làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(280, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chức vụ";
            // 
            // cbcalam
            // 
            this.cbcalam.FormattingEnabled = true;
            this.cbcalam.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2"});
            this.cbcalam.Location = new System.Drawing.Point(906, 63);
            this.cbcalam.Name = "cbcalam";
            this.cbcalam.Size = new System.Drawing.Size(121, 24);
            this.cbcalam.TabIndex = 10;
            // 
            // cbchucvu
            // 
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(375, 63);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(121, 24);
            this.cbchucvu.TabIndex = 11;
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(640, 64);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(121, 24);
            this.cbgioitinh.TabIndex = 12;
            // 
            // cbquequan
            // 
            this.cbquequan.FormattingEnabled = true;
            this.cbquequan.Location = new System.Drawing.Point(109, 63);
            this.cbquequan.Name = "cbquequan";
            this.cbquequan.Size = new System.Drawing.Size(121, 24);
            this.cbquequan.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbquequan);
            this.panel1.Controls.Add(this.cbgioitinh);
            this.panel1.Controls.Add(this.cbchucvu);
            this.panel1.Controls.Add(this.cbcalam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 95);
            this.panel1.TabIndex = 5;
            // 
            // dsnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 706);
            this.Controls.Add(this.btlocnv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmosuanv);
            this.Controls.Add(this.btxoanv);
            this.Controls.Add(this.btmothemnv);
            this.Controls.Add(this.dgvdsnv);
            this.Name = "dsnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.dsnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsnv;
        private System.Windows.Forms.Button btmothemnv;
        private System.Windows.Forms.Button btxoanv;
        private System.Windows.Forms.Button btmosuanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlocnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcalam;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.ComboBox cbquequan;
        private System.Windows.Forms.Panel panel1;
    }
}