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
    
    public partial class dsnhanvien : Form
    {
        public static string str = "";
        public dsnhanvien()
        {
            InitializeComponent();
        }

        private void dsnhanvien_Load(object sender, EventArgs e)
        {
            dgvdsnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string sql;
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            sql = "SELECT * from NhanVien";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dgvdsnv.DataSource = dt2;
            ketnoi.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themnhanvien them = new themnhanvien();
            them.MdiParent = this.MdiParent;
            them.Show();
        }

        private void btmosuanv_Click(object sender, EventArgs e)
        {
            suanhanvien sua = new suanhanvien();
            sua.MdiParent = this.MdiParent;
            sua.Show();
        }

        private void dgvdsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvdsnv.CurrentRow.Index;
            str = dgvdsnv.Rows[i].Cells[0].Value.ToString();
        }
    }
}
