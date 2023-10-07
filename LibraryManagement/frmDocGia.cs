using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using BALayer;
using System.Data.SqlClient;
using System.Globalization;

namespace LibraryManagement
{
    public partial class frmDocGia : Form
    {
        DataTable dtDocGia = null;
        bool Them;
        DBDocGia dbDocGia;
        public frmDocGia()
        {
            dbDocGia = new DBDocGia();
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
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

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtHoTen.Enabled = false;
                txtNgaySinh.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;


                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvDocGia_CellClick(null, null);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Có lỗi!!!", "Thông báo");
                MessageBox.Show(ex.Message);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtCCCD.Enabled = true;


            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaDG.ResetText();
            txtHoTen.ResetText();
            txtNgaySinh.ResetText();
            txtCCCD.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();

            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtCCCD.Enabled = true;
            txtSDT.Enabled = true;

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
                int r = dgvDocGia.CurrentCell.RowIndex;
                string strMaDG =
                dgvDocGia.Rows[r].Cells["MaDocGia"].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa độc giả này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traloi == DialogResult.Yes)
                {
                    bool f = dbDocGia.XoaDocGia(ref err, Int32.Parse(strMaDG));
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
                    f = dbDocGia.ThemDocGia(ref err, txtHoTen.Text,
                        DateTime.Parse(txtNgaySinh.Text), txtDiaChi.Text, txtSDT.Text, txtCCCD.Text);
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
                    f = dbDocGia.CapNhatDocGia(ref err, Int32.Parse(txtMaDG.Text), txtHoTen.Text,
                        DateTime.Parse(txtNgaySinh.Text), txtDiaChi.Text, txtSDT.Text, txtCCCD.Text);
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
            txtDiaChi.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtCCCD.Enabled = false;
            txtSDT.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvDocGia_CellClick(null, null);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dtDocGia.Clear();
            dtDocGia = dbDocGia.LayToanBoDocGia().Tables[0];
            dgvDocGia.DataSource = dtDocGia;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
