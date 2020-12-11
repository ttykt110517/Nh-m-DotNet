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
        public dsnhanvien()
        {
            InitializeComponent();
        }

        private void dsnhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string sql;
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            sql = "SELECT * from NhanVien";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dataGridView1.DataSource = dt2;
            ketnoi.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themnhanvien them = new themnhanvien();
            them.MdiParent = this.MdiParent;
            them.Show();
        }
    }
}
