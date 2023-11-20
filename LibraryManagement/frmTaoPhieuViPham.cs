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
    public partial class frmTaoPhieuViPham : Form
    {
        private int maNV = frmLogin.maNhanVien;
        DataTable dtPhieuViPham = null;
        DBPhieuViPham dbPhieuViPham;
        public frmTaoPhieuViPham()
        {
            dbPhieuViPham = new DBPhieuViPham();
            InitializeComponent();
        }

        private void frmTaoPhieuViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {

                txtMaNhanVien.Text = maNV.ToString();
                txtMaNhanVien.Enabled = false;


                dtPhieuViPham = dbPhieuViPham.LayMaPhieuMuonChuaThem();
                cboMaPhieuMuon.DataSource = dtPhieuViPham;
                cboMaPhieuMuon.ValueMember = "MaPhieuMuon";
                cboMaPhieuMuon.DisplayMember = "MaPhieuMuon";

                cboMaPhieuMuon.Text = "";

                dtPhieuViPham = new DataTable();
                dtPhieuViPham.Clear();
                dtPhieuViPham = dbPhieuViPham.viewLoiViPhamChuaThem().Tables[0];
                dgvChonThongTin.DataSource = dtPhieuViPham;

                dgvChonThongTin.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPhieuViPham frm = new frmPhieuViPham();
            frm.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool h = false;
            string err = "";
            try
            {
                foreach (DataGridViewRow row in dgvChonThongTin.Rows)
                {
                    if (row.Cells["MaSach"].Value != null)
                    {
                        //MessageBox.Show(row.Cells["MaSach"].Value.ToString());
                        string maSach = row.Cells["MaSach"].Value.ToString();
                        h = dbPhieuViPham.ThemPhieuViPham(ref err, Convert.ToInt32(cboMaPhieuMuon.Text), maNV, maSach);
                    }
                }

                if (h)
                {
                    MessageBox.Show("Đã thêm xong!");
                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                int maPhieuMuon = Convert.ToInt32(cboMaPhieuMuon.Text);

                // Lọc và tạo một DataView từ DataTable hiện tại
                DataView dv = new DataView(dtPhieuViPham);
                dv.RowFilter = $"MaPhieuMuon = {maPhieuMuon}";

                // Sử dụng DataView để cập nhật DataGridView
                dgvChonThongTin.DataSource = dv.ToTable();

                // Tự động điều chỉnh kích thước cột
                dgvChonThongTin.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn thông tin!");
            }
        }
    }
}
