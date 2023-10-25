namespace LibraryManagement
{
    partial class frmPhieuViPham
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCTPhieuViPham = new System.Windows.Forms.Button();
            this.btnTaoPhieuViPham = new System.Windows.Forms.Button();
            this.txtTienPhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiViPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuViPham = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(948, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCTPhieuViPham);
            this.panel1.Controls.Add(this.btnTaoPhieuViPham);
            this.panel1.Controls.Add(this.txtTienPhi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLyDo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNgayLap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLoaiViPham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPhieuMuon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaPhieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(925, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 521);
            this.panel1.TabIndex = 18;
            // 
            // btnCTPhieuViPham
            // 
            this.btnCTPhieuViPham.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCTPhieuViPham.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTPhieuViPham.Location = new System.Drawing.Point(20, 468);
            this.btnCTPhieuViPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnCTPhieuViPham.Name = "btnCTPhieuViPham";
            this.btnCTPhieuViPham.Size = new System.Drawing.Size(234, 47);
            this.btnCTPhieuViPham.TabIndex = 34;
            this.btnCTPhieuViPham.Text = "CT phiếu";
            this.btnCTPhieuViPham.UseVisualStyleBackColor = false;
            this.btnCTPhieuViPham.Click += new System.EventHandler(this.btnCTPhieuViPham_Click);
            // 
            // btnTaoPhieuViPham
            // 
            this.btnTaoPhieuViPham.BackColor = System.Drawing.Color.Gold;
            this.btnTaoPhieuViPham.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuViPham.Location = new System.Drawing.Point(354, 468);
            this.btnTaoPhieuViPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoPhieuViPham.Name = "btnTaoPhieuViPham";
            this.btnTaoPhieuViPham.Size = new System.Drawing.Size(248, 47);
            this.btnTaoPhieuViPham.TabIndex = 33;
            this.btnTaoPhieuViPham.Text = "Tạo phiếu vi phạm";
            this.btnTaoPhieuViPham.UseVisualStyleBackColor = false;
            this.btnTaoPhieuViPham.Click += new System.EventHandler(this.btnTaoPhieuViPham_Click);
            // 
            // txtTienPhi
            // 
            this.txtTienPhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienPhi.Enabled = false;
            this.txtTienPhi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhi.Location = new System.Drawing.Point(195, 372);
            this.txtTienPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienPhi.Name = "txtTienPhi";
            this.txtTienPhi.Size = new System.Drawing.Size(285, 32);
            this.txtTienPhi.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tiền phí";
            // 
            // txtLyDo
            // 
            this.txtLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLyDo.Enabled = false;
            this.txtLyDo.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(195, 321);
            this.txtLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(285, 32);
            this.txtLyDo.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lý do";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(195, 264);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(285, 32);
            this.txtNgayLap.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày Lập";
            // 
            // txtLoaiViPham
            // 
            this.txtLoaiViPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiViPham.Enabled = false;
            this.txtLoaiViPham.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiViPham.Location = new System.Drawing.Point(195, 208);
            this.txtLoaiViPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiViPham.Name = "txtLoaiViPham";
            this.txtLoaiViPham.Size = new System.Drawing.Size(285, 32);
            this.txtLoaiViPham.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Loại vi phạm";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(195, 148);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(285, 32);
            this.txtMaNhanVien.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuMuon.Enabled = false;
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(195, 86);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(285, 32);
            this.txtMaPhieuMuon.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(195, 31);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(285, 32);
            this.txtMaPhieu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã phiếu";
            // 
            // dgvPhieuViPham
            // 
            this.dgvPhieuViPham.AllowUserToAddRows = false;
            this.dgvPhieuViPham.AllowUserToDeleteRows = false;
            this.dgvPhieuViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaPhieuMuon,
            this.MaNhanVien,
            this.LoaiViPham,
            this.NgayLap,
            this.LyDo,
            this.TienPhi});
            this.dgvPhieuViPham.Location = new System.Drawing.Point(13, 13);
            this.dgvPhieuViPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuViPham.Name = "dgvPhieuViPham";
            this.dgvPhieuViPham.ReadOnly = true;
            this.dgvPhieuViPham.RowHeadersWidth = 43;
            this.dgvPhieuViPham.Size = new System.Drawing.Size(904, 534);
            this.dgvPhieuViPham.TabIndex = 17;
            this.dgvPhieuViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuViPham_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu ";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Width = 125;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.MinimumWidth = 6;
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.ReadOnly = true;
            this.MaPhieuMuon.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // LoaiViPham
            // 
            this.LoaiViPham.DataPropertyName = "LoaiViPham";
            this.LoaiViPham.HeaderText = "Loại vi phạm";
            this.LoaiViPham.MinimumWidth = 6;
            this.LoaiViPham.Name = "LoaiViPham";
            this.LoaiViPham.ReadOnly = true;
            this.LoaiViPham.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            this.LyDo.Width = 125;
            // 
            // TienPhi
            // 
            this.TienPhi.DataPropertyName = "TienPhi";
            this.TienPhi.HeaderText = "Tiền phí";
            this.TienPhi.MinimumWidth = 6;
            this.TienPhi.Name = "TienPhi";
            this.TienPhi.ReadOnly = true;
            this.TienPhi.Width = 125;
            // 
            // frmPhieuViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhieuViPham);
            this.Name = "frmPhieuViPham";
            this.Text = "Phieu Vi Pham";
            this.Load += new System.EventHandler(this.frmPhieuViPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhi;
        private System.Windows.Forms.TextBox txtLoaiViPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienPhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCTPhieuViPham;
        private System.Windows.Forms.Button btnTaoPhieuViPham;
    }
}