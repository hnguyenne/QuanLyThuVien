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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "admin" && txtMatKhau.Text == "admin")
            {
                frmTrangChuAdmin admin = new frmTrangChuAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    clsDatabase.OpenConnection();
                    SqlCommand com = new SqlCommand("select count(*) from nhan_vien where ma_nhan_vien = @QLTVmanv and mat_khau = @QLTVmat_khau", clsDatabase.con);

                    SqlParameter p1 = new SqlParameter("@QLTVmanv", SqlDbType.Int);
                    p1.Value = int.Parse(txtMaNV.Text);
                    SqlParameter p2 = new SqlParameter("@QLTVmat_khau", SqlDbType.VarChar);
                    p2.Value = txtMatKhau.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);

                    int count = (int)com.ExecuteScalar();
                    if (count > 0)
                    {
                        int manv = int.Parse(txtMaNV.Text);
                        frmTrangChuNV nv = new frmTrangChuNV(manv);
                        nv.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Email hoặc mật khẩu không đúng");
                    clsDatabase.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Email hoặc mật khẩu không hợp lệ");
                }
            }
 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtMatKhau.Clear();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
