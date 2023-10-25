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
    public partial class frmTaiKhoan : Form
    {
        DBTaiKhoan dbTaiKhoan = null;
        DataTable dtTaiKhoan = null;
        public frmTaiKhoan()
        {
            dbTaiKhoan = new DBTaiKhoan();
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtTaiKhoan = new DataTable();
            dtTaiKhoan.Clear();
            dtTaiKhoan = dbTaiKhoan.LayTaiKhoanDangNhap().Tables[0];
            dgvTaiKhoan.DataSource = dtTaiKhoan;
            dgvTaiKhoan.AutoResizeColumns();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            int maTaiKhoan = Int32.Parse(dgvTaiKhoan.Rows[r].Cells["MaTaiKhoan"].Value.ToString());
            bool f;
            string err = "";
            try
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn reset pass của account này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    f = dbTaiKhoan.ResetPassword(ref err, maTaiKhoan);
                    if (f)
                    {
                        MessageBox.Show("Reset thành công !!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thất bại!!! " + err);
            }
        }
    }
}
