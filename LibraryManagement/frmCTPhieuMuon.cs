using BALayer;
using System;
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
    public partial class frmCTPhieuMuon : Form
    {
        DBPhieuMuonTra dbPhieuMuonTra = null;
        DataTable dtCTPhieuMuon = null;
        bool Them;
        public frmCTPhieuMuon()
        {
            dbPhieuMuonTra = new DBPhieuMuonTra();
            InitializeComponent();
        }

        private void frmCTPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtCTPhieuMuon = new DataTable();
            dtCTPhieuMuon.Clear();
            dtCTPhieuMuon = dbPhieuMuonTra.LayChiTietPhieuMuon().Tables[0];
            dgvCTPhieuMuon.DataSource = dtCTPhieuMuon;

            dgvCTPhieuMuon.AutoResizeColumns();
            dgvCTPhieuMuon_CellClick(null, null);
        }

        private void dgvCTPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCTPhieuMuon.CurrentCell.RowIndex;
            txtMaPhieu.Text = dgvCTPhieuMuon.Rows[r].Cells["MaPhieuMuon"].Value.ToString();
            txtMaSach.Text = dgvCTPhieuMuon.Rows[r].Cells["MaSach"].Value.ToString();
            txtHoTen.Text = dgvCTPhieuMuon.Rows[r].Cells["HoTen"].Value.ToString();
            txtNgayMuon.Text = dgvCTPhieuMuon.Rows[r].Cells["NgayMuon"].Value.ToString();
            txtHenTra.Text = dgvCTPhieuMuon.Rows[r].Cells["NgayHenTra"].Value.ToString();
            txtGiaHan.Text = dgvCTPhieuMuon.Rows[r].Cells["GiaHan"].Value.ToString();
            txtNgayTraThuc.Text = dgvCTPhieuMuon.Rows[r].Cells["NgayTraThuc"].Value.ToString();
            cboTinhTrangTra.Text = dgvCTPhieuMuon.Rows[r].Cells["TinhTrangTra"].Value.ToString();
            cboTinhTrangTra.Enabled = false;
            btnGiaHan.Enabled = false;
            btnTraSach.Enabled = false;
            if (txtNgayTraThuc.Text == "")
            {
                cboTinhTrangTra.Enabled = true;
                btnTraSach.Enabled = true;
            }
            if (txtGiaHan.Text == "" && txtNgayTraThuc.Text == "")
            {
                btnGiaHan.Enabled = true;
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            bool f;
            string err = "";
            try
            {
                if (cboTinhTrangTra.Text != "")
                {
                    DateTime ngayTraThuc = DateTime.Today.Date;
                    f = dbPhieuMuonTra.TraSach(ref err, Int32.Parse(txtMaPhieu.Text), txtMaSach.Text, ngayTraThuc, cboTinhTrangTra.Text);
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!\n\r" + "Lỗi: " + err);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng cập nhật tình trạng!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!! " + err);
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            bool f;
            string err = "";
            try
            {
                DateTime ngayHenTra = DateTime.Parse(txtHenTra.Text);
                DateTime giaHan = ngayHenTra.AddDays(7);
                f = dbPhieuMuonTra.GiaHanPhieuMuon(ref err, Int32.Parse(txtMaPhieu.Text), giaHan);
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Thất bại!!\n\r" + "Lỗi: " + err);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!! " + err);
            }
        }
    }
}
