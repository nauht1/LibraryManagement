namespace LibraryManagement
{
    partial class frmQLTheThuVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapThe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhieuMo = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvQLThe = new System.Windows.Forms.DataGridView();
            this.MaPhieuMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTheThuVien = new System.Windows.Forms.DataGridView();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.txtNgayCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheThuVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNgayLap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaDocGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCapThe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaPhieuMo);
            this.panel1.Location = new System.Drawing.Point(812, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 292);
            this.panel1.TabIndex = 18;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(456, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 47);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightGreen;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(456, 59);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 47);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(163, 129);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(285, 34);
            this.txtMaNV.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã NV";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayLap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(163, 181);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayLap.Multiline = true;
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(285, 34);
            this.txtNgayLap.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày lập";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDocGia.Enabled = false;
            this.txtMaDocGia.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Location = new System.Drawing.Point(163, 77);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Multiline = true;
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(285, 34);
            this.txtMaDocGia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã độc giả";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(456, 116);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 47);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangThai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(163, 238);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Multiline = true;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(285, 34);
            this.txtTrangThai.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mở";
            // 
            // btnCapThe
            // 
            this.btnCapThe.BackColor = System.Drawing.Color.LightGreen;
            this.btnCapThe.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapThe.Location = new System.Drawing.Point(456, 172);
            this.btnCapThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapThe.Name = "btnCapThe";
            this.btnCapThe.Size = new System.Drawing.Size(108, 47);
            this.btnCapThe.TabIndex = 12;
            this.btnCapThe.Text = "Cấp thẻ";
            this.btnCapThe.UseVisualStyleBackColor = false;
            this.btnCapThe.Click += new System.EventHandler(this.btnCapThe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng thái";
            // 
            // txtMaPhieuMo
            // 
            this.txtMaPhieuMo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuMo.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMo.Location = new System.Drawing.Point(163, 20);
            this.txtMaPhieuMo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuMo.Multiline = true;
            this.txtMaPhieuMo.Name = "txtMaPhieuMo";
            this.txtMaPhieuMo.Size = new System.Drawing.Size(285, 34);
            this.txtMaPhieuMo.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(469, 66);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 47);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvQLThe
            // 
            this.dgvQLThe.AllowUserToAddRows = false;
            this.dgvQLThe.AllowUserToDeleteRows = false;
            this.dgvQLThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMo,
            this.MaDocGia,
            this.MaNhanVien,
            this.NgayLap,
            this.TrangThai});
            this.dgvQLThe.Location = new System.Drawing.Point(13, 13);
            this.dgvQLThe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQLThe.Name = "dgvQLThe";
            this.dgvQLThe.ReadOnly = true;
            this.dgvQLThe.RowHeadersWidth = 43;
            this.dgvQLThe.Size = new System.Drawing.Size(791, 292);
            this.dgvQLThe.TabIndex = 17;
            this.dgvQLThe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLThe_CellClick);
            // 
            // MaPhieuMo
            // 
            this.MaPhieuMo.DataPropertyName = "MaPhieuMo";
            this.MaPhieuMo.HeaderText = "Mã phiếu mở";
            this.MaPhieuMo.MinimumWidth = 6;
            this.MaPhieuMo.Name = "MaPhieuMo";
            this.MaPhieuMo.ReadOnly = true;
            this.MaPhieuMo.Width = 125;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            this.MaDocGia.Width = 125;
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
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 125;
            // 
            // dgvTheThuVien
            // 
            this.dgvTheThuVien.AllowUserToAddRows = false;
            this.dgvTheThuVien.AllowUserToDeleteRows = false;
            this.dgvTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.MaDG,
            this.MaPM,
            this.NgayCap,
            this.NgayHetHan});
            this.dgvTheThuVien.Location = new System.Drawing.Point(13, 313);
            this.dgvTheThuVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTheThuVien.Name = "dgvTheThuVien";
            this.dgvTheThuVien.ReadOnly = true;
            this.dgvTheThuVien.RowHeadersWidth = 43;
            this.dgvTheThuVien.Size = new System.Drawing.Size(791, 241);
            this.dgvTheThuVien.TabIndex = 20;
            this.dgvTheThuVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheThuVien_CellClick);
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "MaThe";
            this.MaThe.HeaderText = "Mã thẻ";
            this.MaThe.MinimumWidth = 6;
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
            this.MaThe.Width = 125;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDocGia";
            this.MaDG.HeaderText = "Mã độc giả";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.ReadOnly = true;
            this.MaDG.Width = 125;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPhieuMo";
            this.MaPM.HeaderText = "Mã phiếu mở";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.ReadOnly = true;
            this.MaPM.Width = 125;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.MinimumWidth = 6;
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.ReadOnly = true;
            this.NgayCap.Width = 125;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.btnGiaHan);
            this.panel2.Controls.Add(this.txtNgayCap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaDG);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNgayHetHan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMaThe);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Location = new System.Drawing.Point(812, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 241);
            this.panel2.TabIndex = 21;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Cyan;
            this.btnAll.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAll.Location = new System.Drawing.Point(469, 11);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(108, 47);
            this.btnAll.TabIndex = 19;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGiaHan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.Location = new System.Drawing.Point(469, 125);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(108, 47);
            this.btnGiaHan.TabIndex = 18;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayCap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCap.Location = new System.Drawing.Point(168, 134);
            this.txtNgayCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayCap.Multiline = true;
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.Size = new System.Drawing.Size(285, 34);
            this.txtNgayCap.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày cấp";
            // 
            // txtMaDG
            // 
            this.txtMaDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDG.Enabled = false;
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(168, 73);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDG.Multiline = true;
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(285, 34);
            this.txtMaDG.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã độc giả";
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayHetHan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHetHan.Location = new System.Drawing.Point(168, 191);
            this.txtNgayHetHan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayHetHan.Multiline = true;
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(285, 34);
            this.txtNgayHetHan.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã thẻ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày hết hạn";
            // 
            // txtMaThe
            // 
            this.txtMaThe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaThe.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(168, 16);
            this.txtMaThe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThe.Multiline = true;
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(285, 34);
            this.txtMaThe.TabIndex = 3;
            // 
            // frmQLTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTheThuVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQLThe);
            this.Name = "frmQLTheThuVien";
            this.Text = "frmQLTheThuVien";
            this.Load += new System.EventHandler(this.frmQLTheThuVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheThuVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapThe;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPhieuMo;
        private System.Windows.Forms.DataGridView dgvQLThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridView dgvTheThuVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNgayCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnAll;
    }
}