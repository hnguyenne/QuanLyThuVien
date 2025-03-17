using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmTrangChuAdmin : Form
    {
        public frmTrangChuAdmin()
        {
            InitializeComponent();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            frmTimSach timSach = new frmTimSach();
            timSach.Show();
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien frmXoaNhanVien = new frmXoaNhanVien();
            frmXoaNhanVien.Show();
            this.Hide();
        }
    }
}
