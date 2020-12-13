using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace formhethong
{
    class Connection
    {
        //properties
        private string strConn = @"Data Source=LAPTOP-3DBTCAC7\SQLEXPRESS02;Initial Catalog=QuanLyQuanMyCay;Integrated Security=True";
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlDataAdapter da { get; set; }
        //constructor
        public Connection()
        {
            conn = new SqlConnection(strConn);
            cmd = null;
            drd = null;
            da = null;
        }
        //Mở kết nối đến nguồn dữ liệu
        public bool openConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Đóng kết nối đến nguồn dữ liệu
        public bool closeConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       

        //Mô hình ngắt kết nối/////
        //Đổ dữ liệu từ CSDL -> DataAdapter -> DataTable
        //(DataSet-Client)
        public DataTable loadDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Cập nhật dữ liệu từ DataTable vào CSDL qua DataAdapter
        //(tương đồng bảng)
        public void UpdateTable(DataTable dt)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
