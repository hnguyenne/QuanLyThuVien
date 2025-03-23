namespace QuanLyThuVien
{
    partial class frmTimSach
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
            this.dtgv_sach = new System.Windows.Forms.DataGridView();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimSachMa = new System.Windows.Forms.Button();
            this.btnTimSachNamXB = new System.Windows.Forms.Button();
            this.btnTimSachTxt = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_sach
            // 
            this.dtgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sach.Location = new System.Drawing.Point(42, 179);
            this.dtgv_sach.Name = "dtgv_sach";
            this.dtgv_sach.RowHeadersWidth = 51;
            this.dtgv_sach.RowTemplate.Height = 24;
            this.dtgv_sach.Size = new System.Drawing.Size(713, 252);
            this.dtgv_sach.TabIndex = 0;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSach.Location = new System.Drawing.Point(316, 82);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(439, 27);
            this.txtTimSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập thông tin sách bạn muốn tìm";
            // 
            // btnTimSachMa
            // 
            this.btnTimSachMa.Location = new System.Drawing.Point(42, 118);
            this.btnTimSachMa.Name = "btnTimSachMa";
            this.btnTimSachMa.Size = new System.Drawing.Size(193, 33);
            this.btnTimSachMa.TabIndex = 4;
            this.btnTimSachMa.Text = "Tìm kiếm theo mã sách";
            this.btnTimSachMa.UseVisualStyleBackColor = true;
            this.btnTimSachMa.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // btnTimSachNamXB
            // 
            this.btnTimSachNamXB.Location = new System.Drawing.Point(241, 118);
            this.btnTimSachNamXB.Name = "btnTimSachNamXB";
            this.btnTimSachNamXB.Size = new System.Drawing.Size(182, 33);
            this.btnTimSachNamXB.TabIndex = 5;
            this.btnTimSachNamXB.Text = "Tìm kiếm theo năm xb";
            this.btnTimSachNamXB.UseVisualStyleBackColor = true;
            this.btnTimSachNamXB.Click += new System.EventHandler(this.btnTimSachNamXB_Click);
            // 
            // btnTimSachTxt
            // 
            this.btnTimSachTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSachTxt.Location = new System.Drawing.Point(447, 118);
            this.btnTimSachTxt.Name = "btnTimSachTxt";
            this.btnTimSachTxt.Size = new System.Drawing.Size(308, 33);
            this.btnTimSachTxt.TabIndex = 6;
            this.btnTimSachTxt.Text = "Tìm kiếm theo tên, tác giả, thể loại hoặc nhà xb";
            this.btnTimSachTxt.UseVisualStyleBackColor = true;
            this.btnTimSachTxt.Click += new System.EventHandler(this.btnTimSachTxt_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.Location = new System.Drawing.Point(316, 468);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(136, 45);
            this.btnXoaSach.TabIndex = 7;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(531, 468);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(136, 45);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(109, 468);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnTimSachTxt);
            this.Controls.Add(this.btnTimSachNamXB);
            this.Controls.Add(this.btnTimSachMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.dtgv_sach);
            this.Name = "frmTimSach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmTimSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_sach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimSachMa;
        private System.Windows.Forms.Button btnTimSachNamXB;
        private System.Windows.Forms.Button btnTimSachTxt;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnBack;
    }
}