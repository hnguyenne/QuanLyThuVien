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
        }

        private void btnbackTC_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTrangChuNV Home = new frmTrangChuNV(manv);
            Home.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string maDocGia = txtmadocgia.Text.Trim();
            string maSach = txtmasach.Text.Trim();
            string ngayMuon = dtpngaymuon.Value.ToString("yyyy-MM-dd");
            string hanTra = dtphantra.Value.ToString("yyyy-MM-dd");
            string ngayTra = dtpngaytra.Value.ToString("yyyy-MM-dd");
            string tienPhat = txttienphat.Text.Trim();

            if (string.IsNullOrEmpty(maDocGia) || string.IsNullOrEmpty(maSach))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã độc giả và Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsDatabase.OpenConnection();
            string query = @"
                IF EXISTS (SELECT 1 FROM muon WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach)
                    UPDATE muon 
                    SET ngay_muon = @NgayMuon, ngay_het_han = @HanTra, ngay_tra = @NgayTra
                    WHERE ma_doc_gia = @MaDocGia AND ma_sach = @MaSach;
                ELSE
                    INSERT INTO muon (ma_doc_gia, ma_sach, ngay_muon, ngay_het_han, ngay_tra)
                    VALUES (@MaDocGia, @MaSach, @NgayMuon, @HanTra, @NgayTra);";
            SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

            cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
            cmd.Parameters.AddWithValue("@HanTra", hanTra);
            cmd.Parameters.AddWithValue("@NgayTra", ngayTra);

            cmd.ExecuteNonQuery();

            bool daTonTai = false;
            // Duyệt qua ListView để kiểm tra xem bản ghi đã tồn tại chưa
            foreach (ListViewItem item in lvMuonSach.Items)
            {
                if (item.SubItems[0].Text == maDocGia && item.SubItems[1].Text == maSach)
                {
                    // Nếu dữ liệu khác thì cập nhật
                    if (item.SubItems[2].Text != ngayMuon) item.SubItems[2].Text = ngayMuon;
                    if (item.SubItems[3].Text != hanTra) item.SubItems[3].Text = hanTra;
                    if (item.SubItems[4].Text != ngayTra) item.SubItems[4].Text = ngayTra;
                    if (item.SubItems[5].Text != tienPhat) item.SubItems[5].Text = tienPhat;

                    daTonTai = true;
                    break;
                }
            }

            // Nếu chưa tồn tại, thêm mới vào ListView
            if (!daTonTai)
            {
                ListViewItem newItem = new ListViewItem(new string[]
                {
                    maDocGia, maSach, ngayMuon, hanTra, ngayTra, tienPhat
                });

                lvMuonSach.Items.Add(newItem);
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmQLyMuonTra_Load(object sender, EventArgs e)
        {

        }
    }
}
