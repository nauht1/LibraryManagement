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
    public partial class frmQLNXB : Form
    {
        DataTable dtNXB = null;
        bool Them;
        DBNxb dbNXB;
        public frmQLNXB()
        {
            dbNXB = new DBNxb();
            InitializeComponent();
        }

        private void frmQLNXB_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtNXB = new DataTable();
                dtNXB.Clear();
                dtNXB = dbNXB.LayNXB().Tables[0];
                dgvNXB.DataSource = dtNXB;

                dgvNXB.AutoResizeColumns();

                txtMaNXB.ResetText();
                txtTenNXB.ResetText();
                txtDiaChi.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtMaNXB.Enabled = false;
                txtTenNXB.Enabled = false;
                txtDiaChi.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                dgvNXB_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNXB.CurrentCell.RowIndex;
            txtMaNXB.Text = dgvNXB.Rows[r].Cells["MaNXB"].Value.ToString();
            txtTenNXB.Text = dgvNXB.Rows[r].Cells["TenNXB"].Value.ToString();
            txtDiaChi.Text = dgvNXB.Rows[r].Cells["DiaChi"].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNXB.ResetText();
            txtTenNXB.ResetText();
            txtDiaChi.ResetText();

            txtTenNXB.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
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
                    f = dbNXB.ThemNXB(ref err, txtTenNXB.Text, txtDiaChi.Text);
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
                    f = dbNXB.CapNhatNXB(ref err, Int32.Parse(txtMaNXB.Text), txtTenNXB.Text, txtDiaChi.Text);
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
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvNXB_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNXB.CurrentCell.RowIndex;
                string strMaNXB =
                dgvNXB.Rows[r].Cells["MaNXB"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa thể loại này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbNXB.XoaNXB(ref err, Int32.Parse(strMaNXB));
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
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtNXB.Clear();
            dtNXB = dbNXB.LayToanBoNXB().Tables[0];
            dgvNXB.DataSource = dtNXB;
        }
    }
}
