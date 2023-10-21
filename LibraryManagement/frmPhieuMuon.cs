using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmPhieuMuon : Form
    {
        DBPhieuMuonTra dbPhieuMuon = null;
        DataTable dtPhieuMuon = null;
        public frmPhieuMuon()
        {
            dbPhieuMuon = new DBPhieuMuonTra();
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtPhieuMuon = new DataTable();
            dtPhieuMuon.Clear();
            dtPhieuMuon = dbPhieuMuon.LayPhieuMuon().Tables[0];
            dgvPhieuMuon.DataSource = dtPhieuMuon;

            dgvPhieuMuon.AutoResizeColumns();
            dgvPhieuMuon_CellClick(null, null);
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhieuMuon.CurrentCell.RowIndex;
            txtMaPhieu.Text = dgvPhieuMuon.Rows[r].Cells["MaPhieuMuon"].Value.ToString();
            txtHoTen.Text = dgvPhieuMuon.Rows[r].Cells["HoTen"].Value.ToString();
            txtNgayMuon.Text = dgvPhieuMuon.Rows[r].Cells["NgayMuon"].Value.ToString();
            txtHenTra.Text = dgvPhieuMuon.Rows[r].Cells["NgayHenTra"].Value.ToString();
            txtGiaHan.Text = dgvPhieuMuon.Rows[r].Cells["GiaHan"].Value.ToString();
            
        }
    }
}
