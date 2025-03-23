namespace QuanLyThuVien
{
    partial class frmTrangChuNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTrangChu = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQLMuonTra = new System.Windows.Forms.Button();
            this.lblMNV = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.lblLayMNV = new System.Windows.Forms.Label();
            this.lblLayHoTenNV = new System.Windows.Forms.Label();
            this.lvDSSach = new System.Windows.Forms.ListView();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangChu.Location = new System.Drawing.Point(41, 32);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(156, 32);
            this.lblTrangChu.TabIndex = 1;
            this.lblTrangChu.Text = "Trang Chủ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(443, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 44);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Quản lý sách";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnQLMuonTra
            // 
            this.btnQLMuonTra.Location = new System.Drawing.Point(617, 31);
            this.btnQLMuonTra.Name = "btnQLMuonTra";
            this.btnQLMuonTra.Size = new System.Drawing.Size(158, 44);
            this.btnQLMuonTra.TabIndex = 9;
            this.btnQLMuonTra.Text = "Quản Lý Mượn Trả";
            this.btnQLMuonTra.UseVisualStyleBackColor = true;
            this.btnQLMuonTra.Click += new System.EventHandler(this.btnQLMuonTra_Click);
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.Location = new System.Drawing.Point(44, 106);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(94, 16);
            this.lblMNV.TabIndex = 10;
            this.lblMNV.Text = "Mã Nhân Viên:";
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(44, 148);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(120, 16);
            this.lblHoTenNV.TabIndex = 11;
            this.lblHoTenNV.Text = "Họ Tên Nhân Viên:";
            // 
            // lblLayMNV
            // 
            this.lblLayMNV.AutoSize = true;
            this.lblLayMNV.Location = new System.Drawing.Point(215, 106);
            this.lblLayMNV.Name = "lblLayMNV";
            this.lblLayMNV.Size = new System.Drawing.Size(44, 16);
            this.lblLayMNV.TabIndex = 12;
            this.lblLayMNV.Text = "label4";
            // 
            // lblLayHoTenNV
            // 
            this.lblLayHoTenNV.AutoSize = true;
            this.lblLayHoTenNV.Location = new System.Drawing.Point(215, 148);
            this.lblLayHoTenNV.Name = "lblLayHoTenNV";
            this.lblLayHoTenNV.Size = new System.Drawing.Size(44, 16);
            this.lblLayHoTenNV.TabIndex = 13;
            this.lblLayHoTenNV.Text = "label5";
            // 
            // lvDSSach
            // 
            this.lvDSSach.HideSelection = false;
            this.lvDSSach.Location = new System.Drawing.Point(38, 170);
            this.lvDSSach.Name = "lvDSSach";
            this.lvDSSach.Size = new System.Drawing.Size(750, 268);
            this.lvDSSach.TabIndex = 14;
            this.lvDSSach.UseCompatibleStateImageBehavior = false;
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(266, 31);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(151, 44);
            this.btnThemDocGia.TabIndex = 15;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // frmTrangChuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemDocGia);
            this.Controls.Add(this.lvDSSach);
            this.Controls.Add(this.lblLayHoTenNV);
            this.Controls.Add(this.lblLayMNV);
            this.Controls.Add(this.lblHoTenNV);
            this.Controls.Add(this.lblMNV);
            this.Controls.Add(this.btnQLMuonTra);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblTrangChu);
            this.Name = "frmTrangChuNV";
            this.Text = "frmTrangChuNV";
            this.Load += new System.EventHandler(this.frmTrangChuNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQLMuonTra;
        private System.Windows.Forms.Label lblMNV;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.Label lblLayMNV;
        private System.Windows.Forms.Label lblLayHoTenNV;
        private System.Windows.Forms.ListView lvDSSach;
        private System.Windows.Forms.Button btnThemDocGia;
    }
}