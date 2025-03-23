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
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
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
            this.lblTrangChu.Size = new System.Drawing.Size(240, 31);
            this.lblTrangChu.TabIndex = 0;
            this.lblTrangChu.Text = "Trang Chủ Admin";
            this.lblTrangChu.Click += new System.EventHandler(this.lblTrangChu_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(17, 44);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(207, 35);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(20, 44);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(207, 35);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(44, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(17, 110);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(207, 35);
            this.btnXoaNV.TabIndex = 8;
            this.btnXoaNV.Text = "Quản lý nhân viên";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Location = new System.Drawing.Point(376, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(273, 199);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Sách";
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(20, 110);
            this.btnTimKiemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(207, 35);
            this.btnTimKiemSach.TabIndex = 12;
            this.btnTimKiemSach.Text = "Quản lý sách";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // frmTrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 362);
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
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnTimKiemSach;
    }
}