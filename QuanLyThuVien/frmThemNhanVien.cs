using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLyThuVien
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải ít nhất 8 kí tự!");
                return;
            }
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Insert into nhan_vien(ho_ten, so_dien_thoai,email, mat_khau) values" +
                    "(@QLTVHoTen, @QLTVSDT, @QLTVEmail, @QLTVMK)", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@QLTVHoTen", SqlDbType.NVarChar);
                p1.Value = txtHoTen.Text;
                SqlParameter p2 = new SqlParameter("@QLTVSDT", SqlDbType.Char);
                p2.Value = txtSDT.Text;
                SqlParameter p3 = new SqlParameter("@QLTVEmail", SqlDbType.VarChar);
                p3.Value = txtEmail.Text;
                SqlParameter p4 = new SqlParameter("@QLTVMK", SqlDbType.VarChar);
                p4.Value = txtMK.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsDatabase.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsDatabase.CloseConnection();
                }
            } catch (Exception ex) 
            {
                MessageBox.Show("Có lỗi xảy ra" + ex.Message);
                clsDatabase.CloseConnection();
            }
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmTrangChuAdmin frmTrangChuAdmin= new frmTrangChuAdmin();
            frmTrangChuAdmin.Show();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtMK.Clear();
            txtSDT.Clear();
            txtHoTen.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
