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
    public partial class frmStarter : MetroFramework.Forms.MetroForm
    {
        DBSach dbSach;
        DataTable dtSach = null;
        DataTable dtNXB = null;
        DataTable dtKeSach = null;
        DataTable dtTheLoai = null;
        public frmStarter()
        {
            dbSach = new DBSach();
            InitializeComponent();
        }

        private void frmStarter_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtSach = new DataTable();
                dtSach.Clear();
                dtSach = dbSach.LayViewSachChoDocGia().Tables[0];
                dgvSach.DataSource = dtSach;

                dgvSach.AutoResizeColumns();
                cboTenNXB.Text = "";
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtSach.Clear();
            string tenDauSach = txtTenDauSach.Text;
            string tenNXB = cboTenNXB.Text;
            string tenKeSach = cboTenKeSach.Text;
            string tenTheLoai = cboTenTheLoai.Text;
            SqlDataAdapter daSach = null;
            daSach = (SqlDataAdapter)dbSach.TimKiemSachChoDocGia(tenDauSach, tenNXB, tenKeSach, tenTheLoai);
            daSach.Fill(dtSach);
            dgvSach.DataSource = dtSach;
        }

        private void cboTenNXB_DropDown(object sender, EventArgs e)
        {
            dtNXB = new DataTable();
            dtNXB = dbSach.LayNXB();
            cboTenNXB.DataSource = dtNXB;
            cboTenNXB.ValueMember = "MaNXB";
            cboTenNXB.DisplayMember = "TenNXB";
        }

        private void cboTenKeSach_DropDown(object sender, EventArgs e)
        {
            dtKeSach = new DataTable();
            dtKeSach = dbSach.LayKeSach();
            cboTenKeSach.DataSource = dtKeSach;
            cboTenKeSach.ValueMember = "MaKeSach";
            cboTenKeSach.DisplayMember = "TenKeSach";
        }

        private void cboTenTheLoai_DropDown(object sender, EventArgs e)
        {
            dtTheLoai = new DataTable();
            dtTheLoai = dbSach.LayTheLoai();
            cboTenTheLoai.DataSource = dtTheLoai;
            cboTenTheLoai.ValueMember = "MaTheLoai";
            cboTenTheLoai.DisplayMember = "TenTheLoai";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenDauSach.ResetText();
            cboTenNXB.ResetText();
            cboTenKeSach.ResetText();
            cboTenTheLoai.ResetText();
            LoadData();
        }
    }
}
