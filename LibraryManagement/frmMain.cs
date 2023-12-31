﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tileTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void tilePhieuMoThe_Click(object sender, EventArgs e)
        {
            frmQLTheThuVien frm = new frmQLTheThuVien();
            frm.Show();
        }

        private void tileNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void tileDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.Show();
        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan();
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void tileTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frm = new frmTacGia();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tileTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai frm = new frmTheLoai();
            frm.ShowDialog();
        }

        private void tileMuonTraSach_Click(object sender, EventArgs e)
        {
            frmQLMuonTra frm = new frmQLMuonTra();
            frm.ShowDialog();
        }

        private void tilePhieuViPham_Click(object sender, EventArgs e)
        {
            frmPhieuViPham frm = new frmPhieuViPham();
            frm.Show();
        }

        private void tileKeSach_Click(object sender, EventArgs e)
        {
            frmKeSach frm = new frmKeSach();
            frm.Show();
        }

        private void tileDauSach_Click(object sender, EventArgs e)
        {
            frmDauSach frm = new frmDauSach();
            frm.Show();
        }

        private void tilePhieuNhap_Click(object sender, EventArgs e)
        {
            frmNhapSach frm = new frmNhapSach();
            frm.Show();
        }

        private void tileQLSach_Click(object sender, EventArgs e)
        {
            frmQuanLySach frm = new frmQuanLySach();   
            frm.Show();
        }

        private void tileNXB_Click(object sender, EventArgs e)
        {
            frmQLNXB frm = new frmQLNXB();
            frm.Show();
        }
    }
}
