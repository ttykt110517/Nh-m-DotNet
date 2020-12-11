using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formhethong
{
    public partial class dsphieuluong : Form
    {
        public dsphieuluong()
        {
            InitializeComponent();
        }

        private void danhsachluong_Load(object sender, EventArgs e)
        {
            dgvdspl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string sql;
            Connection ketnoi = new Connection();
            ketnoi.openConn();
            sql = "SELECT * from PhieuLuong";
            DataTable dt2 = ketnoi.loadDataTable(sql);
            dgvdspl.DataSource = dt2;
            ketnoi.closeConn();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
