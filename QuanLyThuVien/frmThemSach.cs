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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("insert into sach (ten_sach, tac_gia, nxb, nam, the_loai, so_luong_tong, sl_con_lai) values( " +
                    "@QLTVTensach, @QLTVTacgia, @QLTVNhaXB, @QLTVNamXB, @QLTVTheloai, @QLTVSoluong, @QLTVSoluong)", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@QLTVTensach", SqlDbType.NVarChar);
                SqlParameter p2 = new SqlParameter("@QLTVTacgia", SqlDbType.NVarChar);
                SqlParameter p3 = new SqlParameter("@QLTVNhaXB", SqlDbType.NVarChar);
                SqlParameter p4 = new SqlParameter("@QLTVNamXB", SqlDbType.Int);
                SqlParameter p5 = new SqlParameter("@QLTVTheloai", SqlDbType.NVarChar);
                SqlParameter p6 = new SqlParameter("@QLTVSoluong", SqlDbType.Int);

                p1.Value = txtTenSach.Text;
                p2.Value = txtTacGia.Text;
                p3.Value = txtNhaXB.Text;
                p4.Value = int.Parse(txtNamXB.Text);
                p5.Value = txtTheLoai.Text;
                p6.Value = int.Parse(txtSoLuong.Text);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.ExecuteNonQuery();

                clsDatabase.CloseConnection();
                MessageBox.Show("Thêm sách thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sách không thành công", ex.Message);
            }

        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChuAdmin Frm = new frmTrangChuAdmin();
            Frm.Show();
        }
    }
}
