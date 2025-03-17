namespace QuanLyThuVien
{
    partial class frmXoaNhanVien
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
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cboTim = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(93, 147);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.Size = new System.Drawing.Size(616, 243);
            this.dtgvNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quay về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(177, 408);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa nhân viên";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(93, 96);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(267, 22);
            this.txtTim.TabIndex = 4;
            // 
            // cboTim
            // 
            this.cboTim.FormattingEnabled = true;
            this.cboTim.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cboTim.Location = new System.Drawing.Point(403, 94);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(121, 24);
            this.cboTim.TabIndex = 5;
            this.cboTim.Text = "Tìm kiếm bằng";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(582, 94);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 24);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmXoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvNhanVien);
            this.Name = "frmXoaNhanVien";
            this.Text = "Xóa bỏ nhân viên";
            this.Load += new System.EventHandler(this.frmXoaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cboTim;
        private System.Windows.Forms.Button btnTim;
    }
}