using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace formhethong
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void dsnhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsnhanvien ds = new dsnhanvien();
            ds.MdiParent = this;
            ds.Show();
        }

        private void tinhluongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsphieuluong luong = new dsphieuluong();
            luong.MdiParent = this.MdiParent;
            luong.Show();
        }
    }
}
