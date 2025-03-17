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
    public partial class frmXoaNhanVien : Form
    {
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }

        private void frmXoaNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand sql = new SqlCommand("Select ma_nhan_vien, ho_ten, so_dien_thoai, email from nhan_vien", clsDatabase.con);
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvNhanVien.DataSource = dataTable;

                dtgvNhanVien.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
                dtgvNhanVien.Columns["ho_ten"].HeaderText = "Họ và tên";
                dtgvNhanVien.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
                dtgvNhanVien.Columns["email"].HeaderText = "Email";
                dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex) {
                MessageBox.Show("Đã xảy ra lỗi" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChuAdmin admin = new frmTrangChuAdmin();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            }
            int maNV = Convert.ToInt32(dtgvNhanVien.SelectedRows[0].Cells[0].Value);
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand sql = new SqlCommand("Delete from nhan_vien where ma_nhan_vien = @QLTVMaNV", clsDatabase.con);
                SqlParameter p = new SqlParameter("@QLTVMaNV", SqlDbType.Int);
                p.Value = maNV;
                sql.Parameters.Add(p);
                int rowsAffected = sql.ExecuteNonQuery();
                clsDatabase.CloseConnection();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa nhân viên " + maNV + " thành công");
                    frmXoaNhanVien_Load(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string key = txtTim.Text;
            clsDatabase.OpenConnection();
            SqlCommand sql = new SqlCommand();
            if (key != "" && cboTim.SelectedIndex == 0)
            {
                sql = new SqlCommand("Select ma_nhan_vien, ho_ten, so_dien_thoai, email from nhan_vien where ma_nhan_vien = @QLTVMaNV", clsDatabase.con);
                SqlParameter p1 = new SqlParameter("@QLTVMaNV", SqlDbType.Int);
                p1.Value = Convert.ToInt32(key);
                sql.Parameters.Add(p1);
                
            }
            else if (key != "" && cboTim.SelectedIndex == 1)
            {
                sql = new SqlCommand("Select ma_nhan_vien, ho_ten, so_dien_thoai, email from nhan_vien where ho_ten Like '%' + @QLTVMaNV + '%'", clsDatabase.con);
                SqlParameter p2 = new SqlParameter("@QLTVMaNV", SqlDbType.NVarChar);
                p2.Value = key;
                sql.Parameters.Add(p2);
            }
            else { sql = new SqlCommand("Select ma_nhan_vien, ho_ten, so_dien_thoai, email from nhan_vien", clsDatabase.con); }
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgvNhanVien.DataSource = dataTable;
            dtgvNhanVien.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns["ho_ten"].HeaderText = "Họ và tên";
            dtgvNhanVien.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
            dtgvNhanVien.Columns["email"].HeaderText = "Email";
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clsDatabase.CloseConnection();
        }
    }
}
