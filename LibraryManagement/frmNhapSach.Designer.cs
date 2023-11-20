namespace LibraryManagement
{
    partial class frmNhapSach
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
            this.dgvCT_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoCuoi = new System.Windows.Forms.TextBox();
            this.txtSoDau = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenDauSach = new System.Windows.Forms.TextBox();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnCTPhieuNhap = new System.Windows.Forms.Button();
            this.cbMethodCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCT_PhieuNhap
            // 
            this.dgvCT_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.MaSach,
            this.MaTacGia,
            this.MaNXB,
            this.DonGia});
            this.dgvCT_PhieuNhap.Location = new System.Drawing.Point(12, 12);
            this.dgvCT_PhieuNhap.Name = "dgvCT_PhieuNhap";
            this.dgvCT_PhieuNhap.RowHeadersWidth = 43;
            this.dgvCT_PhieuNhap.Size = new System.Drawing.Size(589, 340);
            this.dgvCT_PhieuNhap.TabIndex = 0;
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "maDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.Width = 105;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "tenDauSach";
            this.TenDauSach.HeaderText = "Tên DS";
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.Width = 105;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "maSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 105;
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "maTacGia";
            this.MaTacGia.HeaderText = "Tác giả";
            this.MaTacGia.Name = "MaTacGia";
            this.MaTacGia.Width = 105;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "maNxb";
            this.MaNXB.HeaderText = "NXB";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Width = 105;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đầu sách";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbMethodCheck);
            this.panel1.Controls.Add(this.txtSoCuoi);
            this.panel1.Controls.Add(this.txtSoDau);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.cboNXB);
            this.panel1.Controls.Add(this.cboTacGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.txtTenDauSach);
            this.panel1.Controls.Add(this.txtMaDauSach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(619, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 381);
            this.panel1.TabIndex = 2;
            // 
            // txtSoCuoi
            // 
            this.txtSoCuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoCuoi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCuoi.Location = new System.Drawing.Point(248, 220);
            this.txtSoCuoi.Multiline = true;
            this.txtSoCuoi.Name = "txtSoCuoi";
            this.txtSoCuoi.Size = new System.Drawing.Size(83, 23);
            this.txtSoCuoi.TabIndex = 16;
            // 
            // txtSoDau
            // 
            this.txtSoDau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDau.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDau.Location = new System.Drawing.Point(112, 220);
            this.txtSoDau.Multiline = true;
            this.txtSoDau.Name = "txtSoDau";
            this.txtSoDau.Size = new System.Drawing.Size(83, 23);
            this.txtSoDau.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "đến:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Từ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(124, 335);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(207, 34);
            this.txtDonGia.TabIndex = 11;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // cboNXB
            // 
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(124, 292);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(207, 27);
            this.cboNXB.TabIndex = 10;
            this.cboNXB.DropDown += new System.EventHandler(this.cboNXB_DropDown);
            // 
            // cboTacGia
            // 
            this.cboTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTacGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(124, 259);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(207, 27);
            this.cboTacGia.TabIndex = 9;
            this.cboTacGia.DropDown += new System.EventHandler(this.cboTacGia_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "NXB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tác giả";
            // 
            // txtMaSach
            // 
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(124, 119);
            this.txtMaSach.Multiline = true;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(207, 60);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDauSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDauSach.Location = new System.Drawing.Point(124, 72);
            this.txtTenDauSach.Multiline = true;
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.Size = new System.Drawing.Size(207, 34);
            this.txtTenDauSach.TabIndex = 5;
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDauSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDauSach.Location = new System.Drawing.Point(124, 21);
            this.txtMaDauSach.Multiline = true;
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.Size = new System.Drawing.Size(207, 33);
            this.txtMaDauSach.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đầu sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(633, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.GreenYellow;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(700, 411);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(455, 365);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(146, 26);
            this.txtTongTien.TabIndex = 13;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(619, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.BackColor = System.Drawing.Color.Khaki;
            this.btnTaoPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(808, 411);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(169, 35);
            this.btnTaoPhieuNhap.TabIndex = 15;
            this.btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhap.Location = new System.Drawing.Point(12, 411);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(140, 35);
            this.btnPhieuNhap.TabIndex = 16;
            this.btnPhieuNhap.Text = "Phiếu nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnCTPhieuNhap
            // 
            this.btnCTPhieuNhap.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCTPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTPhieuNhap.Location = new System.Drawing.Point(168, 411);
            this.btnCTPhieuNhap.Name = "btnCTPhieuNhap";
            this.btnCTPhieuNhap.Size = new System.Drawing.Size(140, 35);
            this.btnCTPhieuNhap.TabIndex = 17;
            this.btnCTPhieuNhap.Text = "CT Phiếu nhập";
            this.btnCTPhieuNhap.UseVisualStyleBackColor = false;
            this.btnCTPhieuNhap.Click += new System.EventHandler(this.btnCTPhieuNhap_Click);
            // 
            // cbMethodCheck
            // 
            this.cbMethodCheck.AutoSize = true;
            this.cbMethodCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethodCheck.Location = new System.Drawing.Point(242, 185);
            this.cbMethodCheck.Name = "cbMethodCheck";
            this.cbMethodCheck.Size = new System.Drawing.Size(89, 22);
            this.cbMethodCheck.TabIndex = 17;
            this.cbMethodCheck.Text = "Thủ công";
            this.cbMethodCheck.UseVisualStyleBackColor = true;
            this.cbMethodCheck.CheckedChanged += new System.EventHandler(this.cbMethodCheck_CheckedChanged);
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 462);
            this.Controls.Add(this.btnCTPhieuNhap);
            this.Controls.Add(this.btnPhieuNhap);
            this.Controls.Add(this.btnTaoPhieuNhap);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCT_PhieuNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCT_PhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenDauSach;
        private System.Windows.Forms.TextBox txtMaDauSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTaoPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnCTPhieuNhap;
        private System.Windows.Forms.TextBox txtSoCuoi;
        private System.Windows.Forms.TextBox txtSoDau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbMethodCheck;
    }
}