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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class frmNhapSach : Form
    {
        private int maNV = frmLogin.maNhanVien;
        DBTacGia dbTacGia = null;
        DBNxb dbNxb = null;
        DBPhieuNhap dbPhieuNhap = null;
        DataTable dtTacGia = null;
        DataTable dtNxb = null;
        DataTable dtPhieuNhap = null;
        DataTable dtCT_PhieuNhap = null;
        decimal tongTien = 0;
        private BindingList<DataItem> dataList = new BindingList<DataItem>();
        public frmNhapSach()
        {
            dbTacGia = new DBTacGia();
            dbNxb = new DBNxb();
            dbPhieuNhap = new DBPhieuNhap();
            InitializeComponent();
            dgvCT_PhieuNhap.DataSource = dataList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDauSach = txtMaDauSach.Text;
            string tenDauSach = txtTenDauSach.Text;
            string maSach = txtMaSach.Text;
            string donGiaTxt = txtDonGia.Text;
            int soDau, soCuoi;

            if (!string.IsNullOrEmpty(maDauSach) && !string.IsNullOrEmpty(tenDauSach) 
                && !string.IsNullOrEmpty(cboTacGia.Text) && !string.IsNullOrEmpty(cboNXB.Text) && !string.IsNullOrEmpty(donGiaTxt))
            {
                    
                int maTacGia = (int)cboTacGia.SelectedValue;
                int maNxb = (int)cboNXB.SelectedValue;
                decimal donGia = Decimal.Parse(donGiaTxt);
                try
                {
                    if (!string.IsNullOrEmpty(maSach))
                    {
                        string[] maSachArr = maSach.Split(',');
                        for (int i = 0; i < maSachArr.Length; i++)
                        {
                            maSachArr[i] = maSachArr[i].Trim();
                        }
                        foreach (string ms in maSachArr)
                        {
                            DataItem newItem = new DataItem(maDauSach, tenDauSach, ms, maTacGia, maNxb, donGia);
                            dataList.Add(newItem);

                            tongTien += donGia;
                            txtTongTien.Text = tongTien.ToString();
                        }
                    }

                    if (int.TryParse(txtSoDau.Text, out soDau) && int.TryParse(txtSoCuoi.Text, out soCuoi))
                    {
                        Console.WriteLine(soDau.ToString(), soCuoi.ToString());
                        if (soDau > 0 && soDau < soCuoi)
                        {
                            for (int u = soDau; u <= soCuoi; u++)
                            {
                                string newMaSach;
                                if (u >= 10)
                                {
                                    newMaSach = $"{maDauSach}-{u}";

                                }
                                else
                                    newMaSach = $"{maDauSach}-0{u}";
                                DataItem newItem = new DataItem(maDauSach, tenDauSach, newMaSach, maTacGia, maNxb, donGia);
                                dataList.Add(newItem);

                                tongTien += donGia;
                                txtTongTien.Text = tongTien.ToString();
                            }
                        }
                    }    
                    txtSoDau.Text = string.Empty;
                    txtSoCuoi.Text = string.Empty;
                    txtMaDauSach.Text = string.Empty;
                    txtTenDauSach.Text = string.Empty;
                    txtMaSach.Text = string.Empty;
                    cboTacGia.SelectedIndex = -1;
                    cboNXB.SelectedIndex = -1;
                    txtDonGia.Text = string.Empty;
                }
                catch
                {
                    MessageBox.Show("Lỗi!!");
                }
            }

        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            dgvCT_PhieuNhap.AutoResizeColumns();
        }
        private void cboTacGia_DropDown(object sender, EventArgs e)
        {
            dtTacGia = dbTacGia.LayTacGia().Tables[0];
            cboTacGia.DataSource = dtTacGia;
            cboTacGia.ValueMember = "MaTacGia";
            cboTacGia.DisplayMember = "TenTacGia";
        }

        private void cboNXB_DropDown(object sender, EventArgs e)
        {
            dtNxb = dbNxb.LayNXB().Tables[0];
            cboNXB.DataSource = dtNxb;
            cboNXB.ValueMember = "MaNXB";
            cboNXB.DisplayMember = "TenNXB";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataList.Clear();
            txtTongTien.ResetText();
            txtTongTien.Text = "0";
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            string err = "";
            bool f = false;
            bool h = false; 
            if (dgvCT_PhieuNhap.Rows.Count > 0)
            {
                try
                {
                    f = dbPhieuNhap.TaoPhieuNhap(ref err, maNV, DateTime.Today.Date, tongTien);
                    if (f)
                    {
                        foreach (DataGridViewRow row in dgvCT_PhieuNhap.Rows)
                        {
                            string maDauSach = row.Cells["MaDauSach"].Value.ToString();
                            string tenDauSach = row.Cells["TenDauSach"].Value.ToString();
                            string maSach = row.Cells["MaSach"].Value.ToString();
                            int maTacGia = Int32.Parse(row.Cells["MaTacGia"].Value.ToString());
                            int maNxb = Int32.Parse(row.Cells["MaNXB"].Value.ToString());
                            decimal donGia = Decimal.Parse(row.Cells["DonGia"].Value.ToString());

                            h = dbPhieuNhap.ThemChiTietPhieuNhap(ref err, maDauSach, tenDauSach, maSach, maTacGia, maNxb, donGia);
                        }
                        if (h)
                        {
                            MessageBox.Show("Tạo phiếu nhập thành công !!");
                            dataList.Clear();
                            txtTongTien.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi rồi !! " + err + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin!!");
            }
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmXemPhieuNhap frm = new frmXemPhieuNhap();
            dtPhieuNhap = new DataTable();
            dtPhieuNhap = dbPhieuNhap.LayPhieuNhap().Tables[0];
            frm.dgvPhieuNhap.DataSource = dtPhieuNhap;
            frm.dgvPhieuNhap.AutoResizeColumns();
            frm.ShowDialog();
        }

        private void btnCTPhieuNhap_Click(object sender, EventArgs e)
        {
            frmXemPhieuNhap frm = new frmXemPhieuNhap();
            dtCT_PhieuNhap = new DataTable();
            dtCT_PhieuNhap = dbPhieuNhap.LayCTPhieuNhap().Tables[0];
            frm.dgvPhieuNhap.DataSource = dtCT_PhieuNhap;
            frm.dgvPhieuNhap.AutoResizeColumns();
            frm.ShowDialog();
        }

        private void cbMethodCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMethodCheck.Checked == true)
            {
                txtSoDau.Enabled = false;
                txtSoCuoi.Enabled = false;
                txtMaSach.Enabled = true;
            }
            else
            {
                txtSoDau.Enabled = true;
                txtSoCuoi.Enabled = true;
                txtMaSach.Enabled = false;
            }
        }
    }
    public class DataItem
    {
        public string maDauSach { get; set; }
        public string tenDauSach { get; set; }
        public string maSach { get; set; }
        public int maTacGia { get; set; }
        public int maNxb { get; set; }
        public decimal donGia { get; set; }
        public DataItem(string maDauSach, string tenDauSach, string maSach, int maTacGia, int maNxb, decimal donGia)
        {
            this.maDauSach = maDauSach;
            this.tenDauSach = tenDauSach;
            this.maSach = maSach;
            this.maTacGia = maTacGia;
            this.maNxb = maNxb;
            this.donGia = donGia;
        }
    }
}
