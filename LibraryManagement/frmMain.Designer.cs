﻿namespace LibraryManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tilePhieuNhap = new MetroFramework.Controls.MetroTile();
            this.tileTaiKhoan = new MetroFramework.Controls.MetroTile();
            this.tileTacGia = new MetroFramework.Controls.MetroTile();
            this.tileKeSach = new MetroFramework.Controls.MetroTile();
            this.tileTheThuVien = new MetroFramework.Controls.MetroTile();
            this.tilePhieuViPham = new MetroFramework.Controls.MetroTile();
            this.tileNhanVien = new MetroFramework.Controls.MetroTile();
            this.tileDocGia = new MetroFramework.Controls.MetroTile();
            this.tileDauSach = new MetroFramework.Controls.MetroTile();
            this.tileMuonTraSach = new MetroFramework.Controls.MetroTile();
            this.tileTheLoai = new MetroFramework.Controls.MetroTile();
            this.tileQLSach = new MetroFramework.Controls.MetroTile();
            this.tileNXB = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Controls.Add(this.tileTaiKhoan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 574);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 455);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(69, 502);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(177, 43);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.Location = new System.Drawing.Point(69, 455);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(177, 43);
            this.btnThongTin.TabIndex = 10;
            this.btnThongTin.Text = "  Thông tin cá nhân";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "KT LIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading Semibold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(349, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "WELCOME TO KT LIB";
            // 
            // tilePhieuNhap
            // 
            this.tilePhieuNhap.BackColor = System.Drawing.Color.SteelBlue;
            this.tilePhieuNhap.CustomBackground = true;
            this.tilePhieuNhap.CustomForeColor = true;
            this.tilePhieuNhap.ForeColor = System.Drawing.Color.White;
            this.tilePhieuNhap.Location = new System.Drawing.Point(412, 262);
            this.tilePhieuNhap.Name = "tilePhieuNhap";
            this.tilePhieuNhap.Size = new System.Drawing.Size(140, 140);
            this.tilePhieuNhap.TabIndex = 79;
            this.tilePhieuNhap.Text = "Quản lý phiếu nhập";
            this.tilePhieuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePhieuNhap.TileImage = ((System.Drawing.Image)(resources.GetObject("tilePhieuNhap.TileImage")));
            this.tilePhieuNhap.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePhieuNhap.UseTileImage = true;
            this.tilePhieuNhap.Click += new System.EventHandler(this.tilePhieuNhap_Click);
            // 
            // tileTaiKhoan
            // 
            this.tileTaiKhoan.BackColor = System.Drawing.Color.SteelBlue;
            this.tileTaiKhoan.CustomBackground = true;
            this.tileTaiKhoan.CustomForeColor = true;
            this.tileTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.tileTaiKhoan.Location = new System.Drawing.Point(26, 366);
            this.tileTaiKhoan.Name = "tileTaiKhoan";
            this.tileTaiKhoan.Size = new System.Drawing.Size(217, 58);
            this.tileTaiKhoan.TabIndex = 78;
            this.tileTaiKhoan.Text = "Quản lý tài khoản";
            this.tileTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileTaiKhoan.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTaiKhoan.TileImage")));
            this.tileTaiKhoan.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tileTaiKhoan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileTaiKhoan.UseTileImage = true;
            this.tileTaiKhoan.Click += new System.EventHandler(this.tileTaiKhoan_Click);
            // 
            // tileTacGia
            // 
            this.tileTacGia.BackColor = System.Drawing.Color.SteelBlue;
            this.tileTacGia.CustomBackground = true;
            this.tileTacGia.CustomForeColor = true;
            this.tileTacGia.ForeColor = System.Drawing.Color.White;
            this.tileTacGia.Location = new System.Drawing.Point(412, 408);
            this.tileTacGia.Name = "tileTacGia";
            this.tileTacGia.Size = new System.Drawing.Size(140, 140);
            this.tileTacGia.TabIndex = 75;
            this.tileTacGia.Text = "Quản lý tác giả";
            this.tileTacGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileTacGia.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTacGia.TileImage")));
            this.tileTacGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTacGia.UseTileImage = true;
            this.tileTacGia.Click += new System.EventHandler(this.tileTacGia_Click);
            // 
            // tileKeSach
            // 
            this.tileKeSach.BackColor = System.Drawing.Color.SteelBlue;
            this.tileKeSach.CustomBackground = true;
            this.tileKeSach.CustomForeColor = true;
            this.tileKeSach.ForeColor = System.Drawing.Color.White;
            this.tileKeSach.Location = new System.Drawing.Point(266, 262);
            this.tileKeSach.Name = "tileKeSach";
            this.tileKeSach.Size = new System.Drawing.Size(140, 140);
            this.tileKeSach.TabIndex = 76;
            this.tileKeSach.Text = "Quản lý kệ sách";
            this.tileKeSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileKeSach.TileImage = ((System.Drawing.Image)(resources.GetObject("tileKeSach.TileImage")));
            this.tileKeSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileKeSach.UseTileImage = true;
            this.tileKeSach.Click += new System.EventHandler(this.tileKeSach_Click);
            // 
            // tileTheThuVien
            // 
            this.tileTheThuVien.BackColor = System.Drawing.Color.SteelBlue;
            this.tileTheThuVien.CustomBackground = true;
            this.tileTheThuVien.CustomForeColor = true;
            this.tileTheThuVien.ForeColor = System.Drawing.Color.White;
            this.tileTheThuVien.Location = new System.Drawing.Point(704, 262);
            this.tileTheThuVien.Name = "tileTheThuVien";
            this.tileTheThuVien.Size = new System.Drawing.Size(140, 140);
            this.tileTheThuVien.TabIndex = 74;
            this.tileTheThuVien.Text = "Quản lý thẻ thư viện";
            this.tileTheThuVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileTheThuVien.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTheThuVien.TileImage")));
            this.tileTheThuVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTheThuVien.UseTileImage = true;
            this.tileTheThuVien.Click += new System.EventHandler(this.tilePhieuMoThe_Click);
            // 
            // tilePhieuViPham
            // 
            this.tilePhieuViPham.BackColor = System.Drawing.Color.SteelBlue;
            this.tilePhieuViPham.CustomBackground = true;
            this.tilePhieuViPham.CustomForeColor = true;
            this.tilePhieuViPham.ForeColor = System.Drawing.Color.White;
            this.tilePhieuViPham.Location = new System.Drawing.Point(558, 262);
            this.tilePhieuViPham.Name = "tilePhieuViPham";
            this.tilePhieuViPham.Size = new System.Drawing.Size(140, 140);
            this.tilePhieuViPham.TabIndex = 73;
            this.tilePhieuViPham.Text = "Phiếu vi phạm";
            this.tilePhieuViPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePhieuViPham.TileImage = ((System.Drawing.Image)(resources.GetObject("tilePhieuViPham.TileImage")));
            this.tilePhieuViPham.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePhieuViPham.UseTileImage = true;
            this.tilePhieuViPham.Click += new System.EventHandler(this.tilePhieuViPham_Click);
            // 
            // tileNhanVien
            // 
            this.tileNhanVien.BackColor = System.Drawing.Color.SteelBlue;
            this.tileNhanVien.CustomBackground = true;
            this.tileNhanVien.CustomForeColor = true;
            this.tileNhanVien.ForeColor = System.Drawing.Color.White;
            this.tileNhanVien.Location = new System.Drawing.Point(704, 408);
            this.tileNhanVien.Name = "tileNhanVien";
            this.tileNhanVien.Size = new System.Drawing.Size(140, 139);
            this.tileNhanVien.TabIndex = 72;
            this.tileNhanVien.Text = "Quản lý nhân viên";
            this.tileNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileNhanVien.TileImage = ((System.Drawing.Image)(resources.GetObject("tileNhanVien.TileImage")));
            this.tileNhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNhanVien.UseTileImage = true;
            this.tileNhanVien.Click += new System.EventHandler(this.tileNhanVien_Click);
            // 
            // tileDocGia
            // 
            this.tileDocGia.BackColor = System.Drawing.Color.SteelBlue;
            this.tileDocGia.CustomBackground = true;
            this.tileDocGia.CustomForeColor = true;
            this.tileDocGia.ForeColor = System.Drawing.Color.White;
            this.tileDocGia.Location = new System.Drawing.Point(266, 408);
            this.tileDocGia.Name = "tileDocGia";
            this.tileDocGia.Size = new System.Drawing.Size(140, 140);
            this.tileDocGia.TabIndex = 71;
            this.tileDocGia.Text = "Quản lý độc giả";
            this.tileDocGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDocGia.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDocGia.TileImage")));
            this.tileDocGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDocGia.UseTileImage = true;
            this.tileDocGia.Click += new System.EventHandler(this.tileDocGia_Click);
            // 
            // tileDauSach
            // 
            this.tileDauSach.BackColor = System.Drawing.Color.SteelBlue;
            this.tileDauSach.CustomBackground = true;
            this.tileDauSach.CustomForeColor = true;
            this.tileDauSach.ForeColor = System.Drawing.Color.White;
            this.tileDauSach.Location = new System.Drawing.Point(412, 116);
            this.tileDauSach.Name = "tileDauSach";
            this.tileDauSach.Size = new System.Drawing.Size(140, 140);
            this.tileDauSach.TabIndex = 70;
            this.tileDauSach.Text = "Quản lý đầu sách";
            this.tileDauSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDauSach.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDauSach.TileImage")));
            this.tileDauSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDauSach.UseTileImage = true;
            this.tileDauSach.Click += new System.EventHandler(this.tileDauSach_Click);
            // 
            // tileMuonTraSach
            // 
            this.tileMuonTraSach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tileMuonTraSach.BackColor = System.Drawing.Color.SteelBlue;
            this.tileMuonTraSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileMuonTraSach.CustomBackground = true;
            this.tileMuonTraSach.CustomForeColor = true;
            this.tileMuonTraSach.ForeColor = System.Drawing.Color.White;
            this.tileMuonTraSach.Location = new System.Drawing.Point(266, 116);
            this.tileMuonTraSach.Name = "tileMuonTraSach";
            this.tileMuonTraSach.Size = new System.Drawing.Size(140, 140);
            this.tileMuonTraSach.TabIndex = 69;
            this.tileMuonTraSach.Text = "Quản lý mượn / trả";
            this.tileMuonTraSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileMuonTraSach.TileImage = ((System.Drawing.Image)(resources.GetObject("tileMuonTraSach.TileImage")));
            this.tileMuonTraSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMuonTraSach.UseTileImage = true;
            this.tileMuonTraSach.Click += new System.EventHandler(this.tileMuonTraSach_Click);
            // 
            // tileTheLoai
            // 
            this.tileTheLoai.BackColor = System.Drawing.Color.SteelBlue;
            this.tileTheLoai.CustomBackground = true;
            this.tileTheLoai.CustomForeColor = true;
            this.tileTheLoai.ForeColor = System.Drawing.Color.White;
            this.tileTheLoai.Location = new System.Drawing.Point(704, 116);
            this.tileTheLoai.Name = "tileTheLoai";
            this.tileTheLoai.Size = new System.Drawing.Size(140, 140);
            this.tileTheLoai.TabIndex = 80;
            this.tileTheLoai.Text = "Quản lý thể loại";
            this.tileTheLoai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileTheLoai.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTheLoai.TileImage")));
            this.tileTheLoai.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTheLoai.UseTileImage = true;
            this.tileTheLoai.Click += new System.EventHandler(this.tileTheLoai_Click);
            // 
            // tileQLSach
            // 
            this.tileQLSach.BackColor = System.Drawing.Color.SteelBlue;
            this.tileQLSach.CustomBackground = true;
            this.tileQLSach.CustomForeColor = true;
            this.tileQLSach.ForeColor = System.Drawing.Color.White;
            this.tileQLSach.Location = new System.Drawing.Point(558, 117);
            this.tileQLSach.Name = "tileQLSach";
            this.tileQLSach.Size = new System.Drawing.Size(140, 139);
            this.tileQLSach.TabIndex = 81;
            this.tileQLSach.Text = "Quản lý sách";
            this.tileQLSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileQLSach.TileImage = ((System.Drawing.Image)(resources.GetObject("tileQLSach.TileImage")));
            this.tileQLSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileQLSach.UseTileImage = true;
            this.tileQLSach.Click += new System.EventHandler(this.tileQLSach_Click);
            // 
            // tileNXB
            // 
            this.tileNXB.BackColor = System.Drawing.Color.SteelBlue;
            this.tileNXB.CustomBackground = true;
            this.tileNXB.CustomForeColor = true;
            this.tileNXB.ForeColor = System.Drawing.Color.White;
            this.tileNXB.Location = new System.Drawing.Point(558, 408);
            this.tileNXB.Name = "tileNXB";
            this.tileNXB.Size = new System.Drawing.Size(140, 140);
            this.tileNXB.TabIndex = 82;
            this.tileNXB.Text = "Quản lý NXB";
            this.tileNXB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileNXB.TileImage = ((System.Drawing.Image)(resources.GetObject("tileNXB.TileImage")));
            this.tileNXB.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNXB.UseTileImage = true;
            this.tileNXB.Click += new System.EventHandler(this.tileNXB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 568);
            this.Controls.Add(this.tileNXB);
            this.Controls.Add(this.tileQLSach);
            this.Controls.Add(this.tileTheLoai);
            this.Controls.Add(this.tilePhieuNhap);
            this.Controls.Add(this.tileTacGia);
            this.Controls.Add(this.tileKeSach);
            this.Controls.Add(this.tileTheThuVien);
            this.Controls.Add(this.tilePhieuViPham);
            this.Controls.Add(this.tileNhanVien);
            this.Controls.Add(this.tileDocGia);
            this.Controls.Add(this.tileDauSach);
            this.Controls.Add(this.tileMuonTraSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTile tileTaiKhoan;
        public MetroFramework.Controls.MetroTile tileNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnDangXuat;
        public MetroFramework.Controls.MetroTile tilePhieuNhap;
        public MetroFramework.Controls.MetroTile tileTacGia;
        public MetroFramework.Controls.MetroTile tileKeSach;
        public MetroFramework.Controls.MetroTile tileTheThuVien;
        public MetroFramework.Controls.MetroTile tilePhieuViPham;
        public MetroFramework.Controls.MetroTile tileDocGia;
        public MetroFramework.Controls.MetroTile tileDauSach;
        public MetroFramework.Controls.MetroTile tileMuonTraSach;
        public MetroFramework.Controls.MetroTile tileTheLoai;
        public MetroFramework.Controls.MetroTile tileQLSach;
        public MetroFramework.Controls.MetroTile tileNXB;
    }
}