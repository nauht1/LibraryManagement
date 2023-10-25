namespace LibraryManagement
{
    partial class frmCT_PhieuViPham
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.cboMaPhieuMuon = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvCT_PhieuViPham = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(726, 578);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 43);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(726, 29);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 43);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cboMaPhieuMuon
            // 
            this.cboMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaPhieuMuon.FormattingEnabled = true;
            this.cboMaPhieuMuon.ItemHeight = 25;
            this.cboMaPhieuMuon.Location = new System.Drawing.Point(39, 29);
            this.cboMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaPhieuMuon.Name = "cboMaPhieuMuon";
            this.cboMaPhieuMuon.Size = new System.Drawing.Size(187, 33);
            this.cboMaPhieuMuon.TabIndex = 87;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(275, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 43);
            this.btnTimKiem.TabIndex = 88;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvCT_PhieuViPham
            // 
            this.dgvCT_PhieuViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaNhanVien,
            this.LoaiViPham,
            this.NgayLap,
            this.LyDo,
            this.TienPhi});
            this.dgvCT_PhieuViPham.Location = new System.Drawing.Point(39, 112);
            this.dgvCT_PhieuViPham.Name = "dgvCT_PhieuViPham";
            this.dgvCT_PhieuViPham.RowHeadersWidth = 51;
            this.dgvCT_PhieuViPham.RowTemplate.Height = 24;
            this.dgvCT_PhieuViPham.Size = new System.Drawing.Size(807, 428);
            this.dgvCT_PhieuViPham.TabIndex = 89;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // LoaiViPham
            // 
            this.LoaiViPham.DataPropertyName = "LoaiViPham";
            this.LoaiViPham.HeaderText = "Loại vi phạm";
            this.LoaiViPham.MinimumWidth = 6;
            this.LoaiViPham.Name = "LoaiViPham";
            this.LoaiViPham.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // TienPhi
            // 
            this.TienPhi.DataPropertyName = "TienPhi";
            this.TienPhi.HeaderText = "Tiền phí";
            this.TienPhi.MinimumWidth = 6;
            this.TienPhi.Name = "TienPhi";
            this.TienPhi.Width = 125;
            // 
            // frmCT_PhieuViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 634);
            this.Controls.Add(this.dgvCT_PhieuViPham);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboMaPhieuMuon);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDong);
            this.Name = "frmCT_PhieuViPham";
            this.Text = "frmCT_PhieuViPham";
            this.Load += new System.EventHandler(this.frmCT_PhieuViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuViPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cboMaPhieuMuon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvCT_PhieuViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhi;
    }
}