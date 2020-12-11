
namespace formhethong
{
    partial class dsphieuluong
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
            this.dgvdspl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbthangluong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdspl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdspl
            // 
            this.dgvdspl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdspl.Location = new System.Drawing.Point(17, 176);
            this.dgvdspl.Margin = new System.Windows.Forms.Padding(5);
            this.dgvdspl.Name = "dgvdspl";
            this.dgvdspl.RowHeadersWidth = 51;
            this.dgvdspl.RowTemplate.Height = 24;
            this.dgvdspl.Size = new System.Drawing.Size(1386, 312);
            this.dgvdspl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(512, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phiếu lương";
            // 
            // cbthangluong
            // 
            this.cbthangluong.FormattingEnabled = true;
            this.cbthangluong.Location = new System.Drawing.Point(184, 124);
            this.cbthangluong.Name = "cbthangluong";
            this.cbthangluong.Size = new System.Drawing.Size(121, 33);
            this.cbthangluong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng lương";
            // 
            // btthem
            // 
            this.btthem.ForeColor = System.Drawing.Color.Crimson;
            this.btthem.Location = new System.Drawing.Point(156, 524);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(98, 41);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.ForeColor = System.Drawing.Color.Crimson;
            this.btsua.Location = new System.Drawing.Point(1162, 524);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(98, 41);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.ForeColor = System.Drawing.Color.Crimson;
            this.btxoa.Location = new System.Drawing.Point(668, 524);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(98, 41);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // dsphieuluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 599);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbthangluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdspl);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dsphieuluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "danhsachluong";
            this.Load += new System.EventHandler(this.danhsachluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdspl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdspl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbthangluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
    }
}