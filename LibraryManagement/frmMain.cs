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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tileTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void tilePhieuMoThe_Click(object sender, EventArgs e)
        {
            frmQLTheThuVien frm = new frmQLTheThuVien();
            frm.ShowDialog();
        }

        private void tileNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void tileDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.ShowDialog();
        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan();
            frm.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
