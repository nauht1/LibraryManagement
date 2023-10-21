namespace LibraryManagement
{
    partial class frmCTPhieuMuon
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
            this.dgvCTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTinhTrangTra = new System.Windows.Forms.ComboBox();
            this.txtNgayTraThuc = new System.Windows.Forms.TextBox();
            this.txtGiaHan = new System.Windows.Forms.TextBox();
            this.txtHenTra = new System.Windows.Forms.TextBox();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPhieuMuon
            // 
            this.dgvCTPhieuMuon.AllowUserToAddRows = false;
            this.dgvCTPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.dgvCTPhieuMuon.Name = "dgvCTPhieuMuon";
            this.dgvCTPhieuMuon.ReadOnly = true;
            this.dgvCTPhieuMuon.RowHeadersWidth = 43;
            this.dgvCTPhieuMuon.Size = new System.Drawing.Size(896, 508);
            this.dgvCTPhieuMuon.TabIndex = 0;
            this.dgvCTPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuMuon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(939, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboTinhTrangTra);
            this.panel1.Controls.Add(this.txtNgayTraThuc);
            this.panel1.Controls.Add(this.txtGiaHan);
            this.panel1.Controls.Add(this.txtHenTra);
            this.panel1.Controls.Add(this.txtNgayMuon);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.txtMaPhieu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(922, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 335);
            this.panel1.TabIndex = 2;
            // 
            // cboTinhTrangTra
            // 
            this.cboTinhTrangTra.Enabled = false;
            this.cboTinhTrangTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrangTra.FormattingEnabled = true;
            this.cboTinhTrangTra.Items.AddRange(new object[] {
            "BinhThuong",
            "BiHong",
            "Mat"});
            this.cboTinhTrangTra.Location = new System.Drawing.Point(158, 286);
            this.cboTinhTrangTra.Name = "cboTinhTrangTra";
            this.cboTinhTrangTra.Size = new System.Drawing.Size(133, 28);
            this.cboTinhTrangTra.TabIndex = 4;
            // 
            // txtNgayTraThuc
            // 
            this.txtNgayTraThuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayTraThuc.Enabled = false;
            this.txtNgayTraThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTraThuc.Location = new System.Drawing.Point(158, 248);
            this.txtNgayTraThuc.Multiline = true;
            this.txtNgayTraThuc.Name = "txtNgayTraThuc";
            this.txtNgayTraThuc.Size = new System.Drawing.Size(133, 28);
            this.txtNgayTraThuc.TabIndex = 3;
            // 
            // txtGiaHan
            // 
            this.txtGiaHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaHan.Enabled = false;
            this.txtGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaHan.Location = new System.Drawing.Point(158, 210);
            this.txtGiaHan.Multiline = true;
            this.txtGiaHan.Name = "txtGiaHan";
            this.txtGiaHan.Size = new System.Drawing.Size(133, 28);
            this.txtGiaHan.TabIndex = 3;
            // 
            // txtHenTra
            // 
            this.txtHenTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHenTra.Enabled = false;
            this.txtHenTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHenTra.Location = new System.Drawing.Point(158, 172);
            this.txtHenTra.Multiline = true;
            this.txtHenTra.Name = "txtHenTra";
            this.txtHenTra.Size = new System.Drawing.Size(133, 28);
            this.txtHenTra.TabIndex = 3;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayMuon.Enabled = false;
            this.txtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuon.Location = new System.Drawing.Point(158, 134);
            this.txtNgayMuon.Multiline = true;
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(133, 28);
            this.txtNgayMuon.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(158, 96);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(133, 28);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(158, 59);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(133, 28);
            this.txtMaSach.TabIndex = 3;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(158, 22);
            this.txtMaPhieu.Multiline = true;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(133, 28);
            this.txtMaPhieu.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tình trạng trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(16, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày trả thực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gia hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hẹn trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTraSach.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(1127, 478);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(106, 40);
            this.btnTraSach.TabIndex = 4;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.Salmon;
            this.btnGiaHan.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Location = new System.Drawing.Point(1005, 478);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(106, 42);
            this.btnGiaHan.TabIndex = 5;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // frmCTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 532);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCTPhieuMuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCTPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu mượn";
            this.Load += new System.EventHandler(this.frmCTPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayTraThuc;
        private System.Windows.Forms.TextBox txtGiaHan;
        private System.Windows.Forms.TextBox txtHenTra;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.ComboBox cboTinhTrangTra;
        private System.Windows.Forms.Button btnGiaHan;
    }
}