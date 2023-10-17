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
    public partial class frmTheLoai : Form
    {
        DataTable dtTheLoai = null;
        bool Them;
        DBTheLoai dbTheLoai;
        public frmTheLoai()
        {
            dbTheLoai = new DBTheLoai();
            InitializeComponent();
        }
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtTheLoai = new DataTable();
                dtTheLoai.Clear();
                dtTheLoai = dbTheLoai.LayTheLoai().Tables[0];
                dgvTheLoai.DataSource = dtTheLoai;

                dgvTheLoai.AutoResizeColumns();

                txtMaTheLoai.ResetText();
                txtTenTheLoai.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtMaTheLoai.Enabled = false;
                txtTenTheLoai.Enabled = false;



                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvTheLoai_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }

        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTheLoai.CurrentCell.RowIndex;
            txtMaTheLoai.Text = dgvTheLoai.Rows[r].Cells["MaTheLoai"].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.Rows[r].Cells["TenTheLoai"].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtTheLoai.Clear();
            dtTheLoai = dbTheLoai.LayToanBoTheLoai().Tables[0];
            dgvTheLoai.DataSource = dtTheLoai;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtTenTheLoai.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaTheLoai.ResetText();
            txtTenTheLoai.ResetText();

            txtTenTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenTheLoai.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvTheLoai.CurrentCell.RowIndex;
                string strMaTL =
                dgvTheLoai.Rows[r].Cells["MaTheLoai"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa thể loại này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbTheLoai.XoaTheLoai(ref err, Int32.Parse(strMaTL));
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (Them)
            {
                string err = "";
                try
                {
                    f = dbTheLoai.ThemTheLoai(ref err, txtTenTheLoai.Text);
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
                    f = dbTheLoai.CapNhatTheLoai(ref err, Int32.Parse(txtMaTheLoai.Text), txtTenTheLoai.Text);
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
            txtMaTheLoai.Enabled = false;
            txtTenTheLoai.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvTheLoai_CellClick(null, null);
        }
    }
}
