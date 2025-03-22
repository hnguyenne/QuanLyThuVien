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
    public partial class frmTrangChuNV : Form
    {
        int manv;
        String tennv;
        public frmTrangChuNV(int Manv)
        {
            InitializeComponent();
            manv = Manv;
        }

        private void frmTrangChuNV_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select ho_ten from nhan_vien where ma_nhan_vien = @QLTVManv", clsDatabase.con);

                SqlParameter p0 = new SqlParameter("@QLTVManv", SqlDbType.Char);
                p0.Value = manv;
                cmd.Parameters.Add(p0);

                tennv = Convert.ToString(cmd.ExecuteScalar());
                clsDatabase.CloseConnection();

                lblLayMNV.Text = manv.ToString();
                lblLayHoTenNV.Text = tennv;
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra khi truy xuất thông tin nhân viên");
            }

            // Cấu hình ListView
            lvDSSach.View = View.Details;
            lvDSSach.FullRowSelect = true;
            lvDSSach.Columns.Clear();
            lvDSSach.Columns.Add("Mã Sách", 80);
            lvDSSach.Columns.Add("Tên Sách", 150);
            lvDSSach.Columns.Add("Tác Giả", 150);
            lvDSSach.Columns.Add("Thể Loại", 100);
            lvDSSach.Columns.Add("Năm Xuất Bản", 100);
            lvDSSach.Columns.Add("Số Lượng Tổng", 100);
            lvDSSach.Columns.Add("Số Lượng Còn", 100);

            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT ma_sach, ten_sach, tac_gia, the_loai, nxb, so_luong_tong,sl_con_lai  FROM sach";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Tạo hàng mới
                    ListViewItem item = new ListViewItem(reader["ma_sach"].ToString());
                    item.SubItems.Add(reader["ten_sach"].ToString());
                    item.SubItems.Add(reader["tac_gia"].ToString());
                    item.SubItems.Add(reader["the_loai"].ToString());
                    item.SubItems.Add(reader["nxb"].ToString());
                    item.SubItems.Add(reader["so_luong_tong"].ToString());
                    item.SubItems.Add(reader["sl_con_lai"].ToString());

                    // Thêm hàng vào ListView
                    lvDSSach.Items.Add(item);
                }

                reader.Close();
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimSach timSach = new frmTimSach(this);
            this.Hide();
            timSach.Show();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {

        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {
            frmQLyMuonTra muontra = new frmQLyMuonTra(manv);
            muontra.Show();
            this.Hide();
        }
    }
}
