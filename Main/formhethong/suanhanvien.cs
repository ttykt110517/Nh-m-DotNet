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
    public partial class suanhanvien : Form
    {
        public suanhanvien()
        {
            InitializeComponent();
        }

        private void btsuanv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dsnhanvien.str);
        }
    }
}
