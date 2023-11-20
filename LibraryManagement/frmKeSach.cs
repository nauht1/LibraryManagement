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
    public partial class frmKeSach : Form
    {
        bool Them;
        DBKeSach dbKeSach = null;
        DataTable dtKeSach = null;
        public frmKeSach()
        {
            dbKeSach = new DBKeSach();
            InitializeComponent();
        }

        private void frmKeSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtKeSach = new DataTable();
                dtKeSach.Clear();
                dtKeSach = dbKeSach.LayThongTinKeSach().Tables[0];
                dgvKeSach.DataSource = dtKeSach;
                dgvKeSach.AutoResizeColumns();

                txtMaKe.ResetText();
                txtTenKe.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtTenKe.Enabled = false;
                txtMaKe.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnAll.Enabled = true;
                btnReload.Enabled = true;
                dgvKeSach_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void dgvKeSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKeSach.CurrentCell.RowIndex;
            txtMaKe.Text = dgvKeSach.Rows[r].Cells["MaKeSach"].Value.ToString();
            txtTenKe.Text = dgvKeSach.Rows[r].Cells["TenKeSach"].Value.ToString();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dtKeSach.Clear();
            dtKeSach = dbKeSach.LayToanBoKeSach().Tables[0];
            dgvKeSach.DataSource = dtKeSach;
            dgvKeSach.AutoResizeColumns();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKeSach.CurrentCell.RowIndex;

                if (dgvKeSach.Rows[r].Cells["MaKeSach"].Value.ToString() == "0")
                {
                    MessageBox.Show("Không thể xóa kệ 0!!!!");
                    return;
                }
                int maKe = Int32.Parse(dgvKeSach.Rows[r].Cells["MaKeSach"].Value.ToString());

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa kệ sách này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbKeSach.XoaKeSach(ref err, maKe);

                    if (f)
                    {
                        MessageBox.Show("Đã xóa xong!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtTenKe.Enabled = true;

            txtMaKe.ResetText();
            txtTenKe.ResetText();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnAll.Enabled = false;
            btnSua.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenKe.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReload.Enabled = false;
            btnAll.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (Them)
            {
                string err = "";
                try
                {
                    f = dbKeSach.ThemKeSach(ref err, txtTenKe.Text);
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
                    f = dbKeSach.CapNhatKeSach(ref err, Int32.Parse(txtMaKe.Text), txtTenKe.Text);
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
            txtMaKe.Enabled = false;
            txtTenKe.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnAll.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvKeSach_CellClick(null, null);
        }
    }
}
