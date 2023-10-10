using BALayer;
using DBLayer;
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
    public partial class frmChonDocGia : Form
    {
        DataTable dtDocGia = null;
        DBDocGia dbDocGia;
        public static string maDocGia;
        private frmQLTheThuVien parentForm;
        public frmChonDocGia()
        {
            dbDocGia = new DBDocGia();
            InitializeComponent();
        }
        public frmChonDocGia(frmQLTheThuVien parent)
        {
            dbDocGia = new DBDocGia();
            InitializeComponent();
            parentForm = parent; // Lưu trữ tham chiếu đến form cha
        }

        private void frmChonDocGia_Load(object sender, EventArgs e)
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

                dgvDocGia_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;
            maDocGia = dgvDocGia.Rows[r].Cells["MaDocGia"].Value.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            parentForm.ChonMaDocGia(maDocGia);
            this.Close();
        }
    }
}
