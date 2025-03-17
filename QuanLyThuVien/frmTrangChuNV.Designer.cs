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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQLySach = new System.Windows.Forms.Button();
            this.btnQLyMuonTra = new System.Windows.Forms.Button();
            this.lblMSNV = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.lstvDSTimKiem = new System.Windows.Forms.ListView();
            this.lblLayMSNV = new System.Windows.Forms.Label();
            this.lblLayHoTenNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangChu.Location = new System.Drawing.Point(12, 22);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(156, 32);
            this.lblTrangChu.TabIndex = 0;
            this.lblTrangChu.Text = "Trang Chủ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(211, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(203, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(420, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnQLySach
            // 
            this.btnQLySach.Location = new System.Drawing.Point(520, 18);
            this.btnQLySach.Name = "btnQLySach";
            this.btnQLySach.Size = new System.Drawing.Size(130, 37);
            this.btnQLySach.TabIndex = 3;
            this.btnQLySach.Text = "Quản Lý Sách";
            this.btnQLySach.UseVisualStyleBackColor = true;
            // 
            // btnQLyMuonTra
            // 
            this.btnQLyMuonTra.Location = new System.Drawing.Point(661, 18);
            this.btnQLyMuonTra.Name = "btnQLyMuonTra";
            this.btnQLyMuonTra.Size = new System.Drawing.Size(131, 37);
            this.btnQLyMuonTra.TabIndex = 4;
            this.btnQLyMuonTra.Text = "Quản Lý Mượn Trả";
            this.btnQLyMuonTra.UseVisualStyleBackColor = true;
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(38, 90);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(49, 16);
            this.lblMSNV.TabIndex = 5;
            this.lblMSNV.Text = "MSNV:";
            // 
            // lblHoTenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(38, 136);
            this.lblHoTenNV.Name = "lblHoTenNV";
            this.lblHoTenNV.Size = new System.Drawing.Size(120, 16);
            this.lblHoTenNV.TabIndex = 7;
            this.lblHoTenNV.Text = "Họ Tên Nhân Viên:";
            // 
            // lstvDSTimKiem
            // 
            this.lstvDSTimKiem.HideSelection = false;
            this.lstvDSTimKiem.Location = new System.Drawing.Point(41, 184);
            this.lstvDSTimKiem.Name = "lstvDSTimKiem";
            this.lstvDSTimKiem.Size = new System.Drawing.Size(727, 269);
            this.lstvDSTimKiem.TabIndex = 9;
            this.lstvDSTimKiem.UseCompatibleStateImageBehavior = false;
            // 
            // lblLayMSNV
            // 
            this.lblLayMSNV.AutoSize = true;
            this.lblLayMSNV.Location = new System.Drawing.Point(93, 90);
            this.lblLayMSNV.Name = "lblLayMSNV";
            this.lblLayMSNV.Size = new System.Drawing.Size(44, 16);
            this.lblLayMSNV.TabIndex = 10;
            this.lblLayMSNV.Text = "label1";
            // 
            // lblLayHoTenNV
            // 
            this.lblLayHoTenNV.AutoSize = true;
            this.lblLayHoTenNV.Location = new System.Drawing.Point(164, 136);
            this.lblLayHoTenNV.Name = "lblLayHoTenNV";
            this.lblLayHoTenNV.Size = new System.Drawing.Size(44, 16);
            this.lblLayHoTenNV.TabIndex = 11;
            this.lblLayHoTenNV.Text = "label2";
            // 
            // frmTrangChuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.lblLayHoTenNV);
            this.Controls.Add(this.lblLayMSNV);
            this.Controls.Add(this.lstvDSTimKiem);
            this.Controls.Add(this.lblHoTenNV);
            this.Controls.Add(this.lblMSNV);
            this.Controls.Add(this.btnQLyMuonTra);
            this.Controls.Add(this.btnQLySach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTrangChu);
            this.Name = "frmTrangChuNV";
            this.Text = "frmTrangChuNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQLySach;
        private System.Windows.Forms.Button btnQLyMuonTra;
        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.Label lblHoTenNV;
        private System.Windows.Forms.ListView lstvDSTimKiem;
        private System.Windows.Forms.Label lblLayMSNV;
        private System.Windows.Forms.Label lblLayHoTenNV;
    }
}