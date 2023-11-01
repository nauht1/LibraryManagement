using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LibraryManagement
{
    public partial class frmViewDauSach : Form
    {
        DataTable dtDauSach = null;
        DBDauSach dbDauSach;

        public frmViewDauSach()
        {
            dbDauSach = new DBDauSach();
            InitializeComponent();
        }

        private void frmViewDauSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {

                dtDauSach = new DataTable();
                dtDauSach.Clear();
                dtDauSach = dbDauSach.LayDauSachCoTheLoai().Tables[0];
                dgvDauSach.DataSource = dtDauSach.DefaultView;
                dgvDauSach.AutoResizeColumns();

            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmDauSach frm  = new frmDauSach();
            this.Close();
            frm.Show();
        }

    }
}
