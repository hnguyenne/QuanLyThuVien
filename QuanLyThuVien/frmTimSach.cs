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
    public partial class frmTimSach : Form
    {
        private Form previousForm;
        public frmTimSach(Form previousForm)
        {
            InitializeComponent();
            LoadData();
            this.previousForm = previousForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            int maSach;
            maSach = int.Parse(txtTimSach.Text);

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from sach where " +
                    "ma_sach = @QLTVMasach", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@QLTVMasach", SqlDbType.Int);
                p1.Value = maSach;

                cmd.Parameters.Add(p1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgv_sach.DataSource = dataTable;

                clsDatabase.CloseConnection();
            } catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm sách ", ex.Message);
            }
        }

        private void btnTimSachTxt_Click(object sender, EventArgs e)
        {
            string searchTxt;
            searchTxt = txtTimSach.Text;

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from sach where " +
                    "ten_sach like '%' + @QLTVSearchTxt + '%' or " +
                    "tac_gia like '%' + @QLTVSearchTxt + '%' or " +
                    "nxb like '%' + @QLTVSearchTxt + '%' or " +
                    "the_loai like '%' + @QLTVSearchTxt + '%'", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@QLTVSearchTxt", SqlDbType.NVarChar);
                p1.Value = searchTxt;

                cmd.Parameters.Add(p1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgv_sach.DataSource = dataTable;

                dtgv_sach.Columns["ma_sach"].HeaderText = "Mã sách";
                dtgv_sach.Columns["ten_sach"].HeaderText = "Tên sách";
                dtgv_sach.Columns["tac_gia"].HeaderText = "Tác giả";
                dtgv_sach.Columns["nxb"].HeaderText = "NXB";
                dtgv_sach.Columns["nam"].HeaderText = "Năm xuất bản";

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm sách ", ex.Message);
            }
        }

        private void btnTimSachNamXB_Click(object sender, EventArgs e)
        {
            int namxb;
            namxb = int.Parse(txtTimSach.Text);

            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from sach where " +
                    "nam = @QLTVNam", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@QLTVNam", SqlDbType.Int);
                p1.Value = namxb;

                cmd.Parameters.Add(p1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgv_sach.DataSource = dataTable;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm sách ", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgv_sach.SelectedRows)
                {
                    int masach = int.Parse(row.Cells["ma_sach"].Value.ToString());

                    clsDatabase.OpenConnection();
                    SqlCommand cmd = new SqlCommand("delete from sach where ma_sach = @QLTVMasach", clsDatabase.con);

                    SqlParameter p1 = new SqlParameter("@QLTVMasach", SqlDbType.Int);
                    p1.Value = masach;
                    cmd.Parameters.Add(p1);

                    cmd.ExecuteNonQuery();
                    clsDatabase.CloseConnection();
                    dtgv_sach.Rows.RemoveAt(row.Index);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa sách", ex.Message);
            } 
        }

        private void LoadData()
        {
            try
            {
                clsDatabase.OpenConnection();  // Ensure connection is open
                string query = "SELECT * FROM sach";
                SqlDataAdapter da = new SqlDataAdapter(query, clsDatabase.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgv_sach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sách: " + ex.Message);
            }
            finally
            {
                clsDatabase.CloseConnection(); // Ensure connection is closed
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgv_sach.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Vui lòng chọn một quyển sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsDatabase.OpenConnection();

                foreach (DataGridViewRow row in dtgv_sach.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    int maSach = Convert.ToInt32(row.Cells["ma_sach"].Value);
                    string tenSach = row.Cells["ten_sach"].Value?.ToString().Trim();
                    string tacGia = row.Cells["tac_gia"].Value?.ToString().Trim();
                    string theLoai = row.Cells["the_loai"].Value?.ToString().Trim();
                    string nhaxb = row.Cells["nxb"].Value?.ToString().Trim();
                    int namXuatBan, soLuongTong, soLuongConLai;

                    if (!int.TryParse(row.Cells["nam"].Value?.ToString(), out namXuatBan) ||
                        !int.TryParse(row.Cells["so_luong_tong"].Value?.ToString(), out soLuongTong) ||
                        !int.TryParse(row.Cells["sl_con_lai"].Value?.ToString(), out soLuongConLai))
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng năm xuất bản và số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue; // Skip to next row
                    }

                    string sql = @"UPDATE sach 
                           SET ten_sach = @TenSach, 
                               tac_gia = @TacGia, 
                               the_loai = @TheLoai, 
                               nxb = @NhaXB, 
                               nam = @NamXuatBan, 
                               so_luong_tong = @SoLuongTong, 
                               sl_con_lai = @SoLuongConLai  
                           WHERE ma_sach = @MaSach";

                    using (SqlCommand cmd = new SqlCommand(sql, clsDatabase.con))
                    {
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@TacGia", tacGia);
                        cmd.Parameters.AddWithValue("@TheLoai", theLoai);
                        cmd.Parameters.AddWithValue("@NhaXB", nhaxb);
                        cmd.Parameters.AddWithValue("@NamXuatBan", namXuatBan);
                        cmd.Parameters.AddWithValue("@SoLuongTong", soLuongTong);
                        cmd.Parameters.AddWithValue("@SoLuongConLai", soLuongConLai);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Cập nhật sách có mã {maSach} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Không có thay đổi nào với sách mã {maSach}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clsDatabase.CloseConnection(); // Ensure the database connection is closed
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            previousForm.Show();
        }

        private void frmTimSach_Load(object sender, EventArgs e)
        {

        }
    }
}
