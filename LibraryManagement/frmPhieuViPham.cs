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
    public partial class frmPhieuViPham : Form
    {
        DataTable dtPhieuViPham = null;
        DataTable dtLoiViPham = null;
        DBPhieuViPham dbPhieuViPham;
        public frmPhieuViPham()
        {
            dbPhieuViPham = new DBPhieuViPham();
            InitializeComponent();
        }

        public void frmPhieuViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtPhieuViPham = new DataTable();
                dtPhieuViPham.Clear();
                dtPhieuViPham = dbPhieuViPham.LayToanBoPhieuViPham().Tables[0];
                dgvPhieuViPham.DataSource = dtPhieuViPham;

                dgvPhieuViPham.AutoResizeColumns();

                dgvPhieuViPham_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }

        }

        private void dgvPhieuViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhieuViPham.CurrentCell.RowIndex;
            txtMaPhieuMuon.Text = dgvPhieuViPham.Rows[r].Cells["MaPhieuMuon"].Value.ToString();
            txtMaPhieu.Text = dgvPhieuViPham.Rows[r].Cells["MaPhieu"].Value.ToString();
            txtMaNhanVien.Text = dgvPhieuViPham.Rows[r].Cells["MaNhanVien"].Value.ToString();

            // DateTime 
            DateTime dateTime = DateTime.Parse(dgvPhieuViPham.Rows[r].Cells["NgayLap"].Value.ToString());
            txtNgayLap.Text = dateTime.ToString(@"MM\/dd\/yyyy");

            txtLyDo.Text = dgvPhieuViPham.Rows[r].Cells["LyDo"].Value.ToString();
            txtTienPhi.Text = dgvPhieuViPham.Rows[r].Cells["TienPhi"].Value.ToString();
            txtLoaiViPham.Text = dgvPhieuViPham.Rows[r].Cells["LoaiViPham"].Value.ToString();
        }

        private void btnCTPhieuViPham_Click(object sender, EventArgs e)
        {
            frmCT_PhieuViPham frm = new frmCT_PhieuViPham();
            frm.Show();
        }

        private void btnTaoPhieuViPham_Click(object sender, EventArgs e)
        {
            frmTaoPhieuViPham frm = new frmTaoPhieuViPham();
            frm.Show();
            this.Close();
        }

    }
}
