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

namespace QuanLyThuVien
{
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
            dateNgaySinh.MaxDate = DateTime.Now;

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.Value = DateTime.MinValue;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
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
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand sql = new SqlCommand("INSERT INTO doc_gia (ho_ten, ngay_sinh, so_dien_thoai, diachi, email) " +
                                                    "VALUES (@QLTVHoTen, @QLTVNgaySinh, @QLTVSoDienThoai, @QLTVDiaChi, @QLTVEmail)");
                SqlParameter p1 = new SqlParameter("@QLTVHoTen", SqlDbType.NVarChar);
                p1.Value = txtHoTen.Text;
                SqlParameter p2 = new SqlParameter("@QLTVNgaySinh", SqlDbType.Date);
                p2.Value = dateNgaySinh.Value;
                SqlParameter p3 = new SqlParameter("@QLTVSoDienThoai", SqlDbType.Char);
                p3.Value = sdt;
                SqlParameter p4 = new SqlParameter("@QLTVDiaChi", SqlDbType.NVarChar);
                p4.Value = txtDiaChi.Text;
                SqlParameter p5 = new SqlParameter("@QLTVEmail", SqlDbType.VarChar);
                p5.Value = email;
                sql.Parameters.Add(p1);
                sql.Parameters.Add(p2);
                sql.Parameters.Add(p3);
                sql.Parameters.Add(p4);
                sql.Parameters.Add(p5);
                int rowsAffected = sql.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsDatabase.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsDatabase.CloseConnection( );
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Có lỗi xảy ra" + ex.Message);
                clsDatabase.CloseConnection();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
