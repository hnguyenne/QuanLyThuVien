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
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.btnCapNhatSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangChu.Location = new System.Drawing.Point(276, 18);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(151, 31);
            this.lblTrangChu.TabIndex = 0;
            this.lblTrangChu.Text = "Trang Chủ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(41, 59);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(134, 59);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(44, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "label2";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(41, 90);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(29, 16);
            this.lblMaSo.TabIndex = 3;
            this.lblMaSo.Text = "Mã:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(134, 90);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(44, 16);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "label4";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(17, 28);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(207, 35);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(20, 28);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(207, 35);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Location = new System.Drawing.Point(17, 76);
            this.btnCapNhatNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(207, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(44, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Location = new System.Drawing.Point(17, 172);
            this.btnTimKiemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(207, 35);
            this.btnTimKiemNV.TabIndex = 9;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(17, 123);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(207, 35);
            this.btnXoaNV.TabIndex = 8;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Controls.Add(this.btnCapNhatSach);
            this.groupBox2.Location = new System.Drawing.Point(376, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(273, 222);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Sách";
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(20, 123);
            this.btnTimKiemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(207, 35);
            this.btnTimKiemSach.TabIndex = 12;
            this.btnTimKiemSach.Text = "Tìm kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // btnCapNhatSach
            // 
            this.btnCapNhatSach.Location = new System.Drawing.Point(20, 76);
            this.btnCapNhatSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatSach.Name = "btnCapNhatSach";
            this.btnCapNhatSach.Size = new System.Drawing.Size(207, 35);
            this.btnCapNhatSach.TabIndex = 10;
            this.btnCapNhatSach.Text = "Cập nhật";
            this.btnCapNhatSach.UseVisualStyleBackColor = true;
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 368);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTrangChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnCapNhatSach;
    }
}