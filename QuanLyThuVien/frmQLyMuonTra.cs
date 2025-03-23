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
    public partial class frmQLyMuonTra : Form
    {
        int manv;
        public frmQLyMuonTra(int Manv)
        {
            InitializeComponent();
            this.manv = Manv;
        }

        private void btnbackTC_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChuNV Home = new frmTrangChuNV(manv);
            Home.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmadocgia.Text.Trim(), out int maDocGia) ||
                !int.TryParse(txtmasach.Text.Trim(), out int maSach))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Mã độc giả và Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
            string ngayMuon = dtpngaymuon.Value.ToString("yyyy-MM-dd");
            string hanTra = dtphantra.Value.ToString("yyyy-MM-dd");
            object ngayTra = DBNull.Value;

            clsDatabase.OpenConnection();
            string check = @"select sl_con_lai from sach where ma_sach=@MaSach";
            SqlCommand comck = new SqlCommand(check, clsDatabase.con);
            comck.Parameters.AddWithValue("@MaSach", maSach);

            int slConLai = Convert.ToInt32(comck.ExecuteScalar());
            if (slConLai == 0 )
            {
                MessageBox.Show("Sách không có sẵn!");
                clsDatabase.CloseConnection();
                return;
            }

            string query = @"
                IF EXISTS (SELECT 1 FROM muon WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach)
                    UPDATE muon 
                    SET ngay_muon = @NgayMuon, ngay_het_han = @HanTra, ngay_tra = @NgayTra
                    WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach;
                ELSE
                    update sach set sl_con_lai = sl_con_lai - 1 where ma_sach = @MaSach;
                    INSERT INTO muon (ma_doc_gia, ma_sach, ngay_muon, ngay_het_han, ngay_tra, ma_nhan_vien)
                    VALUES (@MaDocGia, @MaSach, @NgayMuon, @HanTra, @NgayTra, @MaNhanVien);";
                    
            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

            cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
            cmd.Parameters.AddWithValue("@HanTra", hanTra);
            cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);

            cmd.ExecuteNonQuery();

            bool daTonTai = false;
            // Duyệt qua ListView để kiểm tra xem bản ghi đã tồn tại chưa
            foreach (ListViewItem item in lvMuonSach.Items)
            {
                if (item.SubItems[0].Text == maDocGia.ToString() && item.SubItems[1].Text == maSach.ToString())
                {
                    // Nếu dữ liệu khác thì cập nhật
                    if (item.SubItems[2].Text != ngayMuon) item.SubItems[2].Text = ngayMuon;
                    if (item.SubItems[3].Text != hanTra) item.SubItems[3].Text = hanTra;

                    daTonTai = true;
                    break;
                }
            }

            // Nếu chưa tồn tại, thêm mới vào ListView
            if (!daTonTai)
            {
                ListViewItem newItem = new ListViewItem(new string[]
                {
                    maDocGia.ToString(), maSach.ToString(), ngayMuon, hanTra, ngayTra.ToString()
                });

                lvMuonSach.Items.Add(newItem);
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQLyMuonTra_Load(object sender, EventArgs e)
        {
            lvMuonSach.View = View.Details;
            lvMuonSach.Columns.Clear();
            lvMuonSach.Columns.Add("Mã Độc Giả", 100);
            lvMuonSach.Columns.Add("Mã Sách", 100);
            lvMuonSach.Columns.Add("Ngày Mượn", 120);
            lvMuonSach.Columns.Add("Hạn Trả", 120);
            lvMuonSach.Columns.Add("Ngày Trả", 120);
            clsDatabase.OpenConnection();
            string query = @"select * from muon where ngay_tra is null";

            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);
            SqlDataReader reader = cmd.ExecuteReader();

            lvMuonSach.Items.Clear(); // Xóa dữ liệu cũ trước khi nạp mới

            while (reader.Read())
            {
                string maDocGia = reader["ma_doc_gia"].ToString();
                string maSach = reader["ma_sach"].ToString();
                string ngayMuon = Convert.ToDateTime(reader["ngay_muon"]).ToString("yyyy-MM-dd");
                string hanTra = Convert.ToDateTime(reader["ngay_het_han"]).ToString("yyyy-MM-dd");
                string ngayTra = reader["ngay_tra"] == DBNull.Value ? "" : Convert.ToDateTime(reader["ngay_tra"]).ToString("yyyy-MM-dd");

                ListViewItem item = new ListViewItem(new string[] { maDocGia, maSach, ngayMuon, hanTra, ngayTra });
                lvMuonSach.Items.Add(item);
            }
            clsDatabase.CloseConnection();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtmadocgia.Clear();
            txtmasach.Clear();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmadocgia.Text.Trim(), out int maDocGia) ||
                !int.TryParse(txtmasach.Text.Trim(), out int maSach))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Mã độc giả và Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ngayTra = dtpngaytra.Value.ToString("yyyy-MM-dd");


            clsDatabase.OpenConnection();

            string checkQuery = "SELECT COUNT(*) FROM muon WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach AND ngay_tra IS NULL or ngay_tra = ''";
            SqlCommand checkCmd = new SqlCommand(checkQuery, clsDatabase.con);
            checkCmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
            checkCmd.Parameters.AddWithValue("@MaSach", maSach);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy bản ghi mượn sách này hoặc sách đã được trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clsDatabase.CloseConnection();
                return;
            }

            string updateQuery = "UPDATE muon SET ngay_tra = @NgayTra WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach AND ngay_tra IS NULL or ngay_tra=''";
            SqlCommand updateCmd = new SqlCommand(updateQuery, clsDatabase.con);
            updateCmd.Parameters.AddWithValue("@NgayTra", ngayTra);
            updateCmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
            updateCmd.Parameters.AddWithValue("@MaSach", maSach);
            updateCmd.ExecuteNonQuery();

            string updateSachQuery = "UPDATE sach SET sl_con_lai = sl_con_lai + 1 WHERE ma_sach = @MaSach";
            SqlCommand updateSachCmd = new SqlCommand(updateSachQuery, clsDatabase.con);
            updateSachCmd.Parameters.AddWithValue("@MaSach", maSach);
            updateSachCmd.ExecuteNonQuery();

            foreach (ListViewItem item in lvMuonSach.Items)
            {
                if (item.SubItems[0].Text == maDocGia.ToString() && item.SubItems[1].Text == maSach.ToString())
                {
                    item.SubItems[4].Text = ngayTra; // Cập nhật ngày trả trong ListView
                    break;
                }
            }

            MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clsDatabase.CloseConnection();
        }
    }
}
