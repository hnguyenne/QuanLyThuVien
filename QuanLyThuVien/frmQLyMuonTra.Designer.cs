namespace QuanLyThuVien
{
    partial class frmQLyMuonTra
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
            this.btnbackTC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtphantra = new System.Windows.Forms.DateTimePicker();
            this.dtpngaymuon = new System.Windows.Forms.DateTimePicker();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.lblhantra = new System.Windows.Forms.Label();
            this.lblngaytra = new System.Windows.Forms.Label();
            this.lblngaymuon = new System.Windows.Forms.Label();
            this.lblmasach = new System.Windows.Forms.Label();
            this.lablmadocgia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMuonSach = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbackTC
            // 
            this.btnbackTC.Location = new System.Drawing.Point(27, 24);
            this.btnbackTC.Name = "btnbackTC";
            this.btnbackTC.Size = new System.Drawing.Size(128, 36);
            this.btnbackTC.TabIndex = 5;
            this.btnbackTC.Text = "Quay về";
            this.btnbackTC.UseVisualStyleBackColor = true;
            this.btnbackTC.Click += new System.EventHandler(this.btnbackTC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Mượn - Trả Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraSach);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.dtpngaytra);
            this.groupBox1.Controls.Add(this.dtphantra);
            this.groupBox1.Controls.Add(this.dtpngaymuon);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.txtmasach);
            this.groupBox1.Controls.Add(this.txtmadocgia);
            this.groupBox1.Controls.Add(this.lblhantra);
            this.groupBox1.Controls.Add(this.lblngaytra);
            this.groupBox1.Controls.Add(this.lblngaymuon);
            this.groupBox1.Controls.Add(this.lblmasach);
            this.groupBox1.Controls.Add(this.lablmadocgia);
            this.groupBox1.Location = new System.Drawing.Point(27, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.Location = new System.Drawing.Point(103, 190);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(101, 35);
            this.btnTraSach.TabIndex = 16;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(460, 190);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 35);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Location = new System.Drawing.Point(362, 132);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(272, 22);
            this.dtpngaytra.TabIndex = 14;
            // 
            // dtphantra
            // 
            this.dtphantra.Location = new System.Drawing.Point(362, 87);
            this.dtphantra.Name = "dtphantra";
            this.dtphantra.Size = new System.Drawing.Size(272, 22);
            this.dtphantra.TabIndex = 13;
            // 
            // dtpngaymuon
            // 
            this.dtpngaymuon.Location = new System.Drawing.Point(362, 42);
            this.dtpngaymuon.Name = "dtpngaymuon";
            this.dtpngaymuon.Size = new System.Drawing.Size(272, 22);
            this.dtpngaymuon.TabIndex = 12;
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(293, 190);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 35);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(103, 87);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(122, 22);
            this.txtmasach.TabIndex = 7;
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Location = new System.Drawing.Point(103, 42);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(122, 22);
            this.txtmadocgia.TabIndex = 6;
            // 
            // lblhantra
            // 
            this.lblhantra.AutoSize = true;
            this.lblhantra.Location = new System.Drawing.Point(269, 93);
            this.lblhantra.Name = "lblhantra";
            this.lblhantra.Size = new System.Drawing.Size(50, 16);
            this.lblhantra.TabIndex = 4;
            this.lblhantra.Text = "Hạn trả";
            // 
            // lblngaytra
            // 
            this.lblngaytra.AutoSize = true;
            this.lblngaytra.Location = new System.Drawing.Point(269, 136);
            this.lblngaytra.Name = "lblngaytra";
            this.lblngaytra.Size = new System.Drawing.Size(58, 16);
            this.lblngaytra.TabIndex = 3;
            this.lblngaytra.Text = "Ngày trả";
            // 
            // lblngaymuon
            // 
            this.lblngaymuon.AutoSize = true;
            this.lblngaymuon.Location = new System.Drawing.Point(268, 46);
            this.lblngaymuon.Name = "lblngaymuon";
            this.lblngaymuon.Size = new System.Drawing.Size(79, 16);
            this.lblngaymuon.TabIndex = 2;
            this.lblngaymuon.Text = " Ngày mượn";
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(18, 93);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(58, 16);
            this.lblmasach.TabIndex = 1;
            this.lblmasach.Text = "Mã sách";
            // 
            // lablmadocgia
            // 
            this.lablmadocgia.AutoSize = true;
            this.lablmadocgia.Location = new System.Drawing.Point(18, 48);
            this.lablmadocgia.Name = "lablmadocgia";
            this.lablmadocgia.Size = new System.Drawing.Size(74, 16);
            this.lablmadocgia.TabIndex = 0;
            this.lablmadocgia.Text = "Mã độc giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMuonSach);
            this.groupBox2.Location = new System.Drawing.Point(22, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 332);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mượn - trả";
            // 
            // lvMuonSach
            // 
            this.lvMuonSach.HideSelection = false;
            this.lvMuonSach.Location = new System.Drawing.Point(6, 32);
            this.lvMuonSach.Name = "lvMuonSach";
            this.lvMuonSach.Size = new System.Drawing.Size(735, 281);
            this.lvMuonSach.TabIndex = 0;
            this.lvMuonSach.UseCompatibleStateImageBehavior = false;
            // 
            // frmQLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbackTC);
            this.Name = "frmQLyMuonTra";
            this.Text = "Quản lý mượn trả sách";
            this.Load += new System.EventHandler(this.frmQLyMuonTra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.DateTimePicker dtphantra;
        private System.Windows.Forms.DateTimePicker dtpngaymuon;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.Label lblhantra;
        private System.Windows.Forms.Label lblngaytra;
        private System.Windows.Forms.Label lblngaymuon;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.Label lablmadocgia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMuonSach;
        private System.Windows.Forms.Button btnTraSach;
    }
}