using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmQuanLySach : Form
    {
        DBSach dbSach = null;
        DataTable dtSach = null;

        private List<string> selectedMaSachList = new List<string>();

        public frmQuanLySach()
        {
            dbSach = new DBSach();
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtSach = dbSach.LayKeSach();
                cboTenKeSach.DataSource = dtSach;
                cboTenKeSach.ValueMember = "TenKeSach";
                cboTenKeSach.DisplayMember = "TenKeSach";

                cboTenKeSach.Text = "";

                dtSach = dbSach.LayKeSach();
                cboChuyen.DataSource = dtSach;
                cboChuyen.ValueMember = "TenKeSach";
                cboChuyen.DisplayMember = "TenKeSach";

                cboChuyen.Text = "";

                dtSach = new DataTable();
                dtSach.Clear();
                dtSach = dbSach.LayToanBoSach().Tables[0];
                dgvSach.DataSource = dtSach;

                dgvSach.AutoResizeColumns();

                cboChuyen.Enabled = false;
                btnXacNhan.Enabled = false;


            }
            catch
            {
                MessageBox.Show("Thông báo lỗi!!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenKeSach = cboTenKeSach.Text;

            dtSach = new DataTable();
            dtSach.Clear();
            SqlDataAdapter daSach = null;
            daSach = (SqlDataAdapter)dbSach.SachTrenKe(tenKeSach);
            daSach.Fill(dtSach);
            dgvSach.DataSource = dtSach;

            dgvSach.AutoResizeColumns();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
            cboChuyen.Enabled = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboChuyen.Text = "";

            btnXacNhan.Enabled = false;
            cboChuyen.Enabled = false;

            dgvMaSach.DataSource = null;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboChuyen.Text != "")
                {
                    string err = "";
                    bool f = false;

                    foreach (DataGridViewRow row in dgvMaSach.Rows)
                    {
                        if (row.Cells["MaSachChuyen"].Value != null)
                        {
                            string maSach = row.Cells["MaSachChuyen"].Value.ToString();

                            f = dbSach.ChuyenViTriSach(ref err, maSach, cboChuyen.Text);
                        }

                    }

                    if (f)
                    {
                        MessageBox.Show("Đã chuyển thành công!!!");

                        LoadData();
                        dgvMaSach.DataSource = null;

                    }
                    else
                    {
                        MessageBox.Show("Không chuyển được!\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Không chuyển được. Lỗi rồi!");
                }
            }
            catch
            {
                MessageBox.Show("Không chuyển được. Lỗi rồi!!!");
            }
        }
        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cboChuyen.Enabled)
            {
                if (dgvSach.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (dgvMaSach.DataSource == null)
                    {
                        dtSach = new DataTable();
                        dtSach.Columns.Add("MaSachChuyen");
                        dgvMaSach.DataSource = dtSach;
                    }
                    // Lấy thông tin của dòng đó
                    DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                    string maSach = row.Cells["MaSach"].Value.ToString();
                    string trangThai = row.Cells["TrangThai"].Value.ToString();
                    if (trangThai != "Dang muon")
                    {
                        int rowIndex = -1;
                        foreach (DataGridViewRow r in dgvMaSach.Rows)
                        {

                            if (r.Cells["MaSachChuyen"].Value != null && r.Cells["MaSachChuyen"].Value.ToString() == row.Cells["MaSach"].Value.ToString())
                            {
                                rowIndex = r.Index;
                                break;
                            }

                        }
                        //Chưa tồn tại
                        if (rowIndex == -1)
                        {
                            DataRow newRow = ((DataTable)dgvMaSach.DataSource).NewRow();
                            newRow["MaSachChuyen"] = row.Cells["MaSach"].Value;
                            ((DataTable)dgvMaSach.DataSource).Rows.Add(newRow);
                        }

                        dgvMaSach.Columns["MaSachChuyen"].HeaderText = "Mã Sách";
                        dgvMaSach.AutoResizeColumns();
                    }
                    else
                    {
                        MessageBox.Show("Sách có Mã Sách " + maSach + " không thể chuyển vì Trạng Thái không phù hợp.");
                    }
                }
            }

        }
    }
}
