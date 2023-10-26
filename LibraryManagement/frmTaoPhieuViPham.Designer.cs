namespace LibraryManagement
{
    partial class frmTaoPhieuViPham
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
            this.dgvChonThongTin = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChonThongTin
            // 
            this.dgvChonThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaSach,
            this.TinhTrangTra,
            this.NgayTraThuc,
            this.NgayHenTra,
            this.GiaHan});
            this.dgvChonThongTin.Location = new System.Drawing.Point(9, 10);
            this.dgvChonThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChonThongTin.Name = "dgvChonThongTin";
            this.dgvChonThongTin.RowHeadersWidth = 51;
            this.dgvChonThongTin.RowTemplate.Height = 24;
            this.dgvChonThongTin.Size = new System.Drawing.Size(670, 401);
            this.dgvChonThongTin.TabIndex = 0;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.Width = 125;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TinhTrangTra
            // 
            this.TinhTrangTra.DataPropertyName = "TinhTrangTra";
            this.TinhTrangTra.HeaderText = "Tình trạng trả";
            this.TinhTrangTra.MinimumWidth = 6;
            this.TinhTrangTra.Name = "TinhTrangTra";
            this.TinhTrangTra.Width = 125;
            // 
            // NgayTraThuc
            // 
            this.NgayTraThuc.DataPropertyName = "NgayTraThuc";
            this.NgayTraThuc.HeaderText = "Ngày trả thực";
            this.NgayTraThuc.MinimumWidth = 6;
            this.NgayTraThuc.Name = "NgayTraThuc";
            this.NgayTraThuc.Width = 125;
            // 
            // NgayHenTra
            // 
            this.NgayHenTra.DataPropertyName = "NgayHenTra";
            this.NgayHenTra.HeaderText = "Ngày hẹn trả";
            this.NgayHenTra.MinimumWidth = 6;
            this.NgayHenTra.Name = "NgayHenTra";
            this.NgayHenTra.Width = 125;
            // 
            // GiaHan
            // 
            this.GiaHan.DataPropertyName = "GiaHan";
            this.GiaHan.HeaderText = "Gia hạn";
            this.GiaHan.MinimumWidth = 6;
            this.GiaHan.Name = "GiaHan";
            this.GiaHan.Width = 125;
            // 
            // cboMaPhieuMuon
            // 
            this.cboMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPhieuMuon.FormattingEnabled = true;
            this.cboMaPhieuMuon.ItemHeight = 20;
            this.cboMaPhieuMuon.Location = new System.Drawing.Point(838, 82);
            this.cboMaPhieuMuon.Name = "cboMaPhieuMuon";
            this.cboMaPhieuMuon.Size = new System.Drawing.Size(185, 28);
            this.cboMaPhieuMuon.TabIndex = 89;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(838, 18);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(184, 28);
            this.txtMaNhanVien.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 92;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(838, 376);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.TabIndex = 94;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(932, 376);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 35);
            this.btnDong.TabIndex = 95;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(932, 115);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(90, 35);
            this.btnReLoad.TabIndex = 96;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(838, 115);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 35);
            this.btnTimKiem.TabIndex = 98;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTaoPhieuViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 422);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.cboMaPhieuMuon);
            this.Controls.Add(this.dgvChonThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaoPhieuViPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoPhieuViPham";
            this.Load += new System.EventHandler(this.frmTaoPhieuViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChonThongTin;
        private System.Windows.Forms.ComboBox cboMaPhieuMuon;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHenTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHan;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnTimKiem;
    }
}