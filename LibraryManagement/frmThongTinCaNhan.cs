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
    public partial class frmThongTinCaNhan : Form
    {
        private int maNhanVien = frmLogin.maNhanVien;
        private string username = frmLogin.username;
        DBTaiKhoan dbTaiKhoan;
        DBNhanVien dbNhanVien;
        DataTable dtThongTin = null;
        public frmThongTinCaNhan()
        {
            dbTaiKhoan = new DBTaiKhoan();
            dbNhanVien = new DBNhanVien();
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtThongTin = dbTaiKhoan.LayThongTinDangNhap(maNhanVien);
                DataRow row = dtThongTin.Rows[0];
                txtMaNV.Text = row["MaNhanVien"].ToString();
                txtHoTen.Text = row["HoTen"].ToString();
                txtGioiTinh.Text = row["GioiTinh"].ToString();

                DateTime dateTimeBirth = DateTime.Parse(row["NgaySinh"].ToString());
                txtNgaySinh.Text = dateTimeBirth.ToString(@"MM\/dd\/yyyy");

                txtEmail.Text = row["Email"].ToString();
                txtSDT.Text = row["SoDienThoai"].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtMatKhauCu.PasswordChar = '\0';
                txtMatKhauMoi.PasswordChar = '\0';
                txtXacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
                txtXacNhanMatKhau.PasswordChar = '*';
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            bool f;
            string err = "";
            string newPassword = txtMatKhauMoi.Text;
            if (newPassword.Length >= 6 && newPassword.Length <= 30)
            {
                try
                {
                    if (txtXacNhanMatKhau.Text == txtMatKhauMoi.Text)
                    {
                        f = dbTaiKhoan.DoiMatKhau(ref err, username, txtMatKhauCu.Text, txtMatKhauMoi.Text);
                        if (f)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại");
                            Application.Restart();
                        }
                        else
                        {
                            MessageBox.Show(err + " Đổi mật khẩu thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi rồi!! Lỗi: " + err);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 6 - 30 ký tự");
            }
        }
    }
}
