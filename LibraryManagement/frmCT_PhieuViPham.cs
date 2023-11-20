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
    public partial class frmCT_PhieuViPham : Form
    {
        DBPhieuViPham dbPhieuViPham = null;
        DataTable dtPhieuViPham = null;
        public frmCT_PhieuViPham()
        {
            dbPhieuViPham = new DBPhieuViPham();
            InitializeComponent();
        }

        private void frmCT_PhieuViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                dtPhieuViPham = dbPhieuViPham.LayMaPhieuMuon();
                cboMaPhieuMuon.DataSource = dtPhieuViPham;
                cboMaPhieuMuon.ValueMember = "MaPhieuMuon";
                cboMaPhieuMuon.DisplayMember = "MaPhieuMuon";

                cboMaPhieuMuon.Text = "";

                dtPhieuViPham = new DataTable();
                dtPhieuViPham.Clear();
                dtPhieuViPham = dbPhieuViPham.LayToanBoPhieuViPham().Tables[0];
                dgvCT_PhieuViPham.DataSource = dtPhieuViPham;

                dgvCT_PhieuViPham.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Thông báo lỗi!!");
            }

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhieuMuon = Convert.ToInt32(cboMaPhieuMuon.Text);

                dtPhieuViPham = new DataTable();
                dtPhieuViPham.Clear();
                dtPhieuViPham = dbPhieuViPham.TimKiemCT_PhieuViPham(maPhieuMuon).Tables[0];
                dgvCT_PhieuViPham.DataSource = dtPhieuViPham;

                dgvCT_PhieuViPham.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phiếu!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
