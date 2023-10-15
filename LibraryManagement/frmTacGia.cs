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
    public partial class frmTacGia : Form
    {
        DataTable dtTacGia = null;
        bool Them;
        DBTacGia dbTacGia;
        public frmTacGia()
        {
            dbTacGia = new DBTacGia();
            InitializeComponent();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtTacGia = new DataTable();
                dtTacGia.Clear();
                dtTacGia = dbTacGia.LayTacGia().Tables[0];
                dgvTacGia.DataSource = dtTacGia;

                dgvTacGia.AutoResizeColumns();

                txtMaTacGia.ResetText();
                txtNgaySinh.ResetText();
                txtQueQuan.ResetText();
                txtTenTacGia.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtMaTacGia.Enabled = false;
                txtTenTacGia.Enabled = false;
                txtNgaySinh.Enabled = false;
                txtQueQuan.Enabled = false;


                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvTacGia_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }

        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTacGia.CurrentCell.RowIndex;
            txtMaTacGia.Text = dgvTacGia.Rows[r].Cells["MaTacGia"].Value.ToString();
            txtTenTacGia.Text = dgvTacGia.Rows[r].Cells["TenTacGia"].Value.ToString();

            // DateTime 
            DateTime dateTimeBirth = DateTime.Parse(dgvTacGia.Rows[r].Cells["NgaySinh"].Value.ToString());
            txtNgaySinh.Text = dateTimeBirth.ToString(@"MM\/dd\/yyyy");

            txtQueQuan.Text = dgvTacGia.Rows[r].Cells["QueQuan"].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtTacGia.Clear();
            dtTacGia = dbTacGia.LayToanBoTacGia().Tables[0];
            dgvTacGia.DataSource = dtTacGia;
        }
         private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtTenTacGia.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaTacGia.ResetText();
            txtNgaySinh.ResetText();
            txtQueQuan.ResetText();
            txtTenTacGia.ResetText();

            txtTenTacGia.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenTacGia.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;

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
                int r = dgvTacGia.CurrentCell.RowIndex;
                string strMaTG =
                dgvTacGia.Rows[r].Cells["MaTacGia"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa tác giả này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbTacGia.XoaTacGia(ref err, Int32.Parse(strMaTG));
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
                    f = dbTacGia.ThemTacGia(ref err, txtTenTacGia.Text,
                        DateTime.Parse(txtNgaySinh.Text), txtQueQuan.Text);
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
                    f = dbTacGia.CapNhatTacGia(ref err, Int32.Parse(txtMaTacGia.Text), txtTenTacGia.Text,
                        DateTime.Parse(txtNgaySinh.Text), txtQueQuan.Text);
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
            txtMaTacGia.Enabled = false;
            txtTenTacGia.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvTacGia_CellClick(null, null);
        }
    }
}
