using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmQLMuonTra : Form
    {
        private int maNV = frmLogin.maNhanVien;
        DataTable dtDocGia = null;
        DataTable dtSachMuon = null;
        //bool Them;
        DBDocGia dbDocGia;

        DataTable dtSach = null;
        DBSach dbSach;

        DBPhieuMuonTra dbPhieuMuonTra = null;
        public frmQLMuonTra()
        {
            dbDocGia = new DBDocGia();
            dbSach = new DBSach();
            dbPhieuMuonTra = new DBPhieuMuonTra();
            InitializeComponent();
        }

        private void frmQLMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtDocGia = new DataTable();
                dtDocGia.Clear();
                dtDocGia = dbDocGia.LayDocGia().Tables[0];
                dgvDocGia.DataSource = dtDocGia;

                dgvDocGia.AutoResizeColumns();

                txtHoTen.ResetText();
                txtNgaySinh.ResetText();
                txtCCCD.ResetText();
                txtSDT.ResetText();
                txtDiaChi.ResetText();

                dtSach = new DataTable();
                dtSach.Clear();
                dtSach = dbSach.LayViewSachChoDocGia().Tables[0];
                dgvSach.DataSource = dtSach;

                dgvSach.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgvSachMuon.DataSource == null)
                {
                    dtSachMuon = new DataTable();
                    dtSachMuon.Columns.Add("MaSachM");
                    dtSachMuon.Columns.Add("TenDauSachM");
                    dtSachMuon.Columns.Add("TenNXBM");
                    dtSachMuon.Columns.Add("TenKeSachM");
                    dtSachMuon.Columns.Add("DanhSachTheLoaiM");
                    dgvSachMuon.DataSource = dtSachMuon;
                }
                // Lấy thông tin của dòng đó
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                int rowIndex = -1;
                foreach (DataGridViewRow r in dgvSachMuon.Rows)
                {
                    if (r.Cells["MaSachM"].Value != null && r.Cells["MaSachM"].Value.ToString() == row.Cells["MaSach"].Value.ToString())
                    {
                        rowIndex = r.Index;
                        break;
                    }
                }
                //Chưa tồn tại
                if (rowIndex == -1)
                {
                    DataRow newRow = ((DataTable)dgvSachMuon.DataSource).NewRow();
                    newRow["MaSachM"] = row.Cells["MaSach"].Value;
                    newRow["TenDauSachM"] = row.Cells["TenDauSach"].Value;
                    newRow["TenNXBM"] = row.Cells["TenNXB"].Value;
                    newRow["TenKeSachM"] = row.Cells["TenKeSach"].Value;
                    newRow["DanhSachTheLoaiM"] = row.Cells["DanhSachTheLoai"].Value;
                    ((DataTable)dgvSachMuon.DataSource).Rows.Add(newRow);
                }

                dgvSachMuon.Columns["MaSachM"].HeaderText = "Mã Sách";
                dgvSachMuon.Columns["TenDauSachM"].HeaderText = "Tên đầu sách";
                dgvSachMuon.Columns["TenNXBM"].HeaderText = "NXB";
                dgvSachMuon.Columns["TenKeSachM"].HeaderText = "Kệ sách";
                dgvSachMuon.Columns["DanhSachTheLoaiM"].HeaderText = "Thể loại";

                dgvSachMuon.AutoResizeColumns();

            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;
            txtMaDG.Text = dgvDocGia.Rows[r].Cells["MaDocGia"].Value.ToString();
            txtHoTen.Text = dgvDocGia.Rows[r].Cells["HoTen"].Value.ToString();

            // DateTime 
            DateTime dateTimeBirth = DateTime.Parse(dgvDocGia.Rows[r].Cells["NgaySinh"].Value.ToString());
            txtNgaySinh.Text = dateTimeBirth.ToString(@"MM\/dd\/yyyy");

            txtDiaChi.Text = dgvDocGia.Rows[r].Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dgvDocGia.Rows[r].Cells["SDT"].Value.ToString();
            txtCCCD.Text = dgvDocGia.Rows[r].Cells["CCCD"].Value.ToString();
        }

        private void btnTaoPhieuMuon_Click(object sender, EventArgs e)
        {
            bool f = false;
            bool h = false;
            string err = "";
            try
            {
                if (dtSachMuon != null && dtSachMuon.Rows.Count > 0 && txtMaDG.Text != "")
                {
                    DateTime ngayMuon = DateTime.Today.Date;
                    DateTime ngayHenTra = ngayMuon.AddDays(21);
                    f = dbPhieuMuonTra.ThemPhieuMuon(ref err, Int32.Parse(txtMaDG.Text), maNV, ngayMuon, ngayHenTra);
                    if (f)
                    {
                        foreach (DataGridViewRow row in dgvSachMuon.Rows)
                        {
                            string maSach = row.Cells["MaSachM"].Value.ToString();
                            h = dbPhieuMuonTra.ThemChiTietPhieuMuon(ref err, maSach);
                        }
                        if (h)
                        {
                            MessageBox.Show("Đã thêm xong!");
                            LoadData();

                            dtSachMuon.Clear();
                            dgvSachMuon.DataSource = dtSachMuon;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnCTPhieuMuon_Click(object sender, EventArgs e)
        {
            frmCTPhieuMuon frm = new frmCTPhieuMuon();
            frm.ShowDialog();
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            frmPhieuMuon frm = new frmPhieuMuon();
            frm.ShowDialog();
        }
    }
}
