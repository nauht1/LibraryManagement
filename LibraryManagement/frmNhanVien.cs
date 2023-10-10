using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using System.Data.SqlClient;
using System.Globalization;

namespace LibraryManagement
{
    public partial class frmNhanVien : Form
    {
        DataTable dtNhanVien = null;
        bool Them;
        DBNhanVien dbNhanVien;
        public frmNhanVien()
        {
            dbNhanVien = new DBNhanVien();
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNhanVien.LayNhanVien().Tables[0];
                dgvNhanVien.DataSource = dtNhanVien;

                dgvNhanVien.AutoResizeColumns();

                txtHoTen.ResetText();
                txtNgaySinh.ResetText();
                txtEmail.ResetText();
                txtSDT.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtHoTen.Enabled = false;
                cboGioiTinh.Enabled = false;
                txtNgaySinh.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvNhanVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[r].Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[r].Cells["HoTen"].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.Rows[r].Cells["GioiTinh"].Value.ToString();

            // DateTime 
            DateTime dateTimeBirth = DateTime.Parse(dgvNhanVien.Rows[r].Cells["NgaySinh"].Value.ToString());
            txtNgaySinh.Text = dateTimeBirth.ToString(@"MM\/dd\/yyyy");


            txtEmail.Text = dgvNhanVien.Rows[r].Cells["Email"].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[r].Cells["SoDienThoai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHoTen.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtNgaySinh.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
            cboGioiTinh.SelectedIndex = -1;

            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtHoTen.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                string strMaNV =
                dgvNhanVien.Rows[r].Cells["MaNhanVien"].Value.ToString();
                if (Int32.Parse(strMaNV) == frmLogin.maNhanVien)
                {
                    MessageBox.Show("Khong the xoa nhan vien nay!");
                    return;
                }
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa nhân viên này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbNhanVien.XoaNhanVien(ref err, Int32.Parse(strMaNV));
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!" + err);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (Them)
            {
                string err = "";
                try
                {
                    f = dbNhanVien.ThemNhanVien(ref err, txtHoTen.Text,
                        cboGioiTinh.SelectedItem.ToString(), DateTime.Parse(txtNgaySinh.Text), txtEmail.Text, txtSDT.Text);
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
            }
            else
            {
                string err = "";
                try
                {
                    f = dbNhanVien.CapNhatNhanVien(ref err, Int32.Parse(txtMaNV.Text), txtHoTen.Text,
                        cboGioiTinh.SelectedItem.ToString(), DateTime.Parse(txtNgaySinh.Text), txtEmail.Text, txtSDT.Text);
                    if (f)
                    {
                        LoadData();
                        MessageBox.Show("Đã cập nhật xong!");
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
            btnReload.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvNhanVien_CellClick(null, null);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtNhanVien.Clear();
            dtNhanVien = dbNhanVien.LayToanBoNhanVien().Tables[0];
            dgvNhanVien.DataSource = dtNhanVien;
        }
    }
}
