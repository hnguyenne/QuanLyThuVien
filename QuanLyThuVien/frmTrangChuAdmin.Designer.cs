namespace QuanLyThuVien
{
    partial class frmTrangChuAdmin
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnCapNhatSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangChu.Location = new System.Drawing.Point(311, 23);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(179, 37);
            this.lblTrangChu.TabIndex = 0;
            this.lblTrangChu.Text = "Trang Chủ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(46, 74);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(151, 74);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(51, 20);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "label2";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(46, 113);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(35, 20);
            this.lblMaSo.TabIndex = 3;
            this.lblMaSo.Text = "Mã:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(151, 113);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(51, 20);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "label4";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(19, 35);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(233, 44);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(23, 35);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(233, 44);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Location = new System.Drawing.Point(19, 95);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(233, 44);
            this.btnCapNhatNV.TabIndex = 7;
            this.btnCapNhatNV.Text = "Cập nhật thông tin";
            this.btnCapNhatNV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiemNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnCapNhatNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(50, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 278);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnCapNhatSach);
            this.groupBox2.Location = new System.Drawing.Point(423, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 278);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Sách";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(19, 154);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(233, 44);
            this.btnXoaNV.TabIndex = 8;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Location = new System.Drawing.Point(19, 215);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(233, 44);
            this.btnTimKiemNV.TabIndex = 9;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(23, 215);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(233, 44);
            this.btnTimKiemSach.TabIndex = 12;
            this.btnTimKiemSach.Text = "Tìm kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(23, 154);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(233, 44);
            this.btnXoaSach.TabIndex = 11;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSach
            // 
            this.btnCapNhatSach.Location = new System.Drawing.Point(23, 95);
            this.btnCapNhatSach.Name = "btnCapNhatSach";
            this.btnCapNhatSach.Size = new System.Drawing.Size(233, 44);
            this.btnCapNhatSach.TabIndex = 10;
            this.btnCapNhatSach.Text = "Cập nhật";
            this.btnCapNhatSach.UseVisualStyleBackColor = true;
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 460);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTrangChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTrangChuAdmin";
            this.Text = "frmTrangChu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnTimKiemNV;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnCapNhatSach;
    }
}