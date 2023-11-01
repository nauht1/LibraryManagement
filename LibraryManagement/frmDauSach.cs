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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LibraryManagement
{
    public partial class frmDauSach : Form
    {
        DataTable dtDauSach = null;
        bool Them;
        DBDauSach dbDauSach;

        DataTable dtTheLoai = null;
        DBTheLoai dbTheLoai;

        public frmDauSach()
        {
            dbDauSach = new DBDauSach();
            dbTheLoai = new DBTheLoai();
            InitializeComponent();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            dtTheLoai = new DataTable();
            dtTheLoai.Clear();
            dtTheLoai = dbTheLoai.LayTheLoai().Tables[0];

            foreach (DataRow row in dtTheLoai.Rows)
            {
                clbTheLoai.Items.Add(row["TenTheLoai"].ToString());
            }
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtTheLoai = new DataTable();
                dtTheLoai.Clear();
                dtTheLoai = dbTheLoai.LayTheLoai().Tables[0];

                for (int i = 0; i < clbTheLoai.Items.Count; i++)
                {
                    clbTheLoai.SetItemChecked(i, false);
                }


                dtDauSach = new DataTable();
                dtDauSach.Clear();
                dtDauSach = dbDauSach.LayDauSachChuaCoTheLoai().Tables[0];
                dgvDauSach.DataSource = dtDauSach.DefaultView.ToTable(false,"MaDauSach","TenDauSach");
                dgvDauSach.AutoResizeColumns();

                txtMaDauSach.ResetText();
                txtTenDauSach.ResetText();

                txtMaDauSach.Enabled = false;
                txtTenDauSach.Enabled = false;

                
            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                for (int i = 0; i < clbTheLoai.Items.Count; i++)
                {
                    if (clbTheLoai.GetItemChecked(i))
                    {
                        string selectedItem = clbTheLoai.Items[i].ToString();
                        int maTheLoai = 0;
                        foreach (DataRow row in dtTheLoai.Rows)
                        {
                            string tenTheLoai = row["TenTheLoai"].ToString();
                            if (selectedItem == tenTheLoai)
                            {
                                maTheLoai = Convert.ToInt32(row["MaTheLoai"]);
                                break;
                            }
                        }
                        Them = dbTheLoai.ThemCT_TheLoai(ref err, txtMaDauSach.Text, maTheLoai );
                        if (Them==false)
                        {
                            MessageBox.Show("Thất bại!!\n\r" + "Lỗi:" + err);
                        }
                    }
                }
                if(Them)
                {
                    MessageBox.Show("Đã thêm thành công!!!");
                    LoadData();
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi!!!", "Thông báo");
            }
        }

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < clbTheLoai.Items.Count; i++)
            {
                clbTheLoai.SetItemChecked(i, false);
            }

            int r = dgvDauSach.CurrentCell.RowIndex;
            txtMaDauSach.Text = dgvDauSach.Rows[r].Cells["MaDauSach"].Value.ToString();
            txtTenDauSach.Text = dgvDauSach.Rows[r].Cells["TenDauSach"].Value.ToString();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewDauSach frm = new frmViewDauSach();
            this.Hide();
            frm.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
