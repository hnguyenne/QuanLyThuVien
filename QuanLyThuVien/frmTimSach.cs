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
        public frmTimSach()
        {
            InitializeComponent();
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
    }
}
