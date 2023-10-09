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
    public partial class frmQLTheThuVien : Form
    {
        private int maNV = frmLogin.maNhanVien;
        DataTable dtPhieuMoThe = null;
        DataTable dtTheThuVien = null;
        

        DBQLTheTV dbQLTheTV;
        public frmQLTheThuVien()
        {
            dbQLTheTV = new DBQLTheTV();
            InitializeComponent();
        }

        private void frmQLTheThuVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                /// DataTable PhieuMoThe
                dtPhieuMoThe = new DataTable();
                dtPhieuMoThe.Clear();
                dtPhieuMoThe = dbQLTheTV.LayPhieuMoThe().Tables[0];
                dgvQLThe.DataSource = dtPhieuMoThe;

                dgvQLThe.AutoResizeColumns();

                /// txt
                txtMaPhieuMo.Enabled = false;
                txtMaDocGia.Enabled = false;
                txtMaNV.Enabled = false;
                txtNgayLap.Enabled = false;
                txtTrangThai.Enabled = false;

                txtMaPhieuMo.ResetText();
                txtMaDocGia.ResetText();
                txtMaNV.ResetText();
                txtNgayLap.ResetText();
                txtTrangThai.ResetText();

                /// btn
                btnCapThe.Enabled = true;
                btnReload.Enabled = true;
                btnThem.Enabled = true;

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;




                /// DataTable TheThuVien
                dtTheThuVien = new DataTable();
                dtTheThuVien.Clear();
                dtTheThuVien = dbQLTheTV.LayTheThuVien().Tables[0];
                dgvTheThuVien.DataSource = dtTheThuVien;

                dgvQLThe.AutoResizeColumns();

                dgvQLThe_CellClick(null, null);
                dgvTheThuVien_CellClick(null, null);

                /// txt
                txtMaThe.Enabled = false;
                txtMaDG.Enabled = false;
                txtNgayCap.Enabled = false;
                txtNgayHetHan.Enabled = false;

                txtMaThe.ResetText();
                txtMaDG.ResetText();
                txtNgayCap.ResetText();
                txtNgayHetHan.ResetText();

                /// btn
                btnAll.Enabled = true;
                btnReload.Enabled = true;
                btnGiaHan.Enabled = true;



            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }

        }

        private void dgvQLThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r1 = dgvQLThe.CurrentCell.RowIndex;
            txtMaPhieuMo.Text = dgvQLThe.Rows[r1].Cells["MaPhieuMo"].Value.ToString();
            txtMaDocGia.Text = dgvQLThe.Rows[r1].Cells["MaDocGia"].Value.ToString();
            txtMaNV.Text = dgvQLThe.Rows[r1].Cells["MaNhanVien"].Value.ToString();

            // DateTime 
            DateTime dateTimeBirth = DateTime.Parse(dgvQLThe.Rows[r1].Cells["NgayLap"].Value.ToString());
            txtNgayLap.Text = dateTimeBirth.ToString(@"MM\/dd\/yyyy");

            txtTrangThai.Text = dgvQLThe.Rows[r1].Cells["TrangThai"].Value.ToString();

            if (txtTrangThai.Text == "DaCap")
            {
                int r2 = dgvTheThuVien.CurrentCell.RowIndex;

                txtMaThe.Text = dgvTheThuVien.Rows[r2].Cells["MaThe"].Value.ToString();
                txtMaDG.Text = dgvTheThuVien.Rows[r2].Cells["MaDG"].Value.ToString();

                // DateTime 
                DateTime dateTimeNgayCap = DateTime.Parse(dgvTheThuVien.Rows[r2].Cells["NgayCap"].Value.ToString());
                txtNgayCap.Text = dateTimeNgayCap.ToString(@"MM\/dd\/yyyy");

                DateTime dateTimeNgayHetHan = DateTime.Parse(dgvTheThuVien.Rows[r2].Cells["NgayHetHan"].Value.ToString());
                txtNgayHetHan.Text = dateTimeNgayHetHan.ToString(@"MM\/dd\/yyyy");
            }
            else
            {
                txtMaThe.ResetText();
                txtMaDG.ResetText();
                txtNgayCap.ResetText();
                txtNgayHetHan.ResetText();
            }

        }

        private void dgvTheThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r2 = dgvTheThuVien.CurrentCell.RowIndex;

            txtMaThe.Text = dgvTheThuVien.Rows[r2].Cells["MaThe"].Value.ToString();
            txtMaDG.Text = dgvTheThuVien.Rows[r2].Cells["MaDG"].Value.ToString();

            // DateTime 
            DateTime dateTimeNgayCap = DateTime.Parse(dgvTheThuVien.Rows[r2].Cells["NgayCap"].Value.ToString());
            txtNgayCap.Text = dateTimeNgayCap.ToString(@"MM\/dd\/yyyy");

            DateTime dateTimeNgayHetHan = DateTime.Parse(dgvTheThuVien.Rows[r2].Cells["NgayHetHan"].Value.ToString());
            txtNgayHetHan.Text = dateTimeNgayHetHan.ToString(@"MM\/dd\/yyyy");

            txtMaPhieuMo.ResetText();
            txtMaDocGia.ResetText();
            txtMaNV.ResetText();
            txtNgayLap.ResetText();
            txtTrangThai.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaDocGia.ResetText();
            txtMaPhieuMo.ResetText();
            txtMaNV.ResetText();
            txtTrangThai.ResetText();

            txtMaDocGia.Enabled = true;
            txtNgayLap.Enabled = true;

            txtMaNV.Text = maNV.ToString();
            txtNgayLap.Text = DateTime.Now.ToString(@"MM\/dd\/yyyy");

            btnThem.Enabled = false;

            btnReload.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaDocGia.Focus();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            LoadData();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            try
            {
                f = dbQLTheTV.ThemPhieuMoThe(ref err, Int32.Parse(txtMaDocGia.Text), Int32.Parse(txtMaNV.Text), DateTime.Parse(txtNgayLap.Text));
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }

            btnReload.Enabled = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dtTheThuVien.Clear();
            dtTheThuVien = dbQLTheTV.LayToanBoTheThuVien().Tables[0];
            dgvTheThuVien.DataSource = dtTheThuVien;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapThe_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            try
            {
                f = dbQLTheTV.CapNhatPhieuMoThe(ref err, Int32.Parse(txtMaPhieuMo.Text));
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Đã Cấp thẻ cho độc giả!");
                }
                else
                {
                    MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            bool f = false;
            string err = "";
            try
            {
                f = dbQLTheTV.GiaHanTheThuVien(ref err, Int32.Parse(txtMaThe.Text));
                if (f)
                {
                    LoadData();
                    MessageBox.Show("Đã gia hạn thành công!");
                }
                else
                {
                    MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được. Lỗi rồi!");
            }
        }
    }
}
