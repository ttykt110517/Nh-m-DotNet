﻿
namespace formhethong
{
    partial class hethong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsnhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhluongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapkhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuatkhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyenlieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsmonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.quảnLýKhoToolStripMenuItem,
            this.mónToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsnhanvienToolStripMenuItem,
            this.tinhluongToolStripMenuItem,
            this.taikhoanToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // dsnhanvienToolStripMenuItem
            // 
            this.dsnhanvienToolStripMenuItem.Name = "dsnhanvienToolStripMenuItem";
            this.dsnhanvienToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dsnhanvienToolStripMenuItem.Text = "Danh sách nhân viên";
            this.dsnhanvienToolStripMenuItem.Click += new System.EventHandler(this.dsnhanvienToolStripMenuItem_Click);
            // 
            // tinhluongToolStripMenuItem
            // 
            this.tinhluongToolStripMenuItem.Name = "tinhluongToolStripMenuItem";
            this.tinhluongToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tinhluongToolStripMenuItem.Text = "Tính lương ";
            this.tinhluongToolStripMenuItem.Click += new System.EventHandler(this.tinhluongToolStripMenuItem_Click);
            // 
            // taikhoanToolStripMenuItem
            // 
            this.taikhoanToolStripMenuItem.Name = "taikhoanToolStripMenuItem";
            this.taikhoanToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.taikhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            this.quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapkhoToolStripMenuItem,
            this.xuatkhoToolStripMenuItem,
            this.nguyenlieuToolStripMenuItem});
            this.quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            this.quảnLýKhoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // nhapkhoToolStripMenuItem
            // 
            this.nhapkhoToolStripMenuItem.Name = "nhapkhoToolStripMenuItem";
            this.nhapkhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhapkhoToolStripMenuItem.Text = "Nhập kho";
            this.nhapkhoToolStripMenuItem.Click += new System.EventHandler(this.nhapkhoToolStripMenuItem_Click);
            // 
            // xuatkhoToolStripMenuItem
            // 
            this.xuatkhoToolStripMenuItem.Name = "xuatkhoToolStripMenuItem";
            this.xuatkhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xuatkhoToolStripMenuItem.Text = "Xuất kho";
            // 
            // nguyenlieuToolStripMenuItem
            // 
            this.nguyenlieuToolStripMenuItem.Name = "nguyenlieuToolStripMenuItem";
            this.nguyenlieuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nguyenlieuToolStripMenuItem.Text = "Nguyên liệu";
            // 
            // mónToolStripMenuItem
            // 
            this.mónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsmonToolStripMenuItem});
            this.mónToolStripMenuItem.Name = "mónToolStripMenuItem";
            this.mónToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mónToolStripMenuItem.Text = "Quản lý menu";
            // 
            // dsmonToolStripMenuItem
            // 
            this.dsmonToolStripMenuItem.Name = "dsmonToolStripMenuItem";
            this.dsmonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dsmonToolStripMenuItem.Text = "Danh sách món";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 431);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "hethong";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsnhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhluongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapkhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatkhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyenlieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsmonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}

