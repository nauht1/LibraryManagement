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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class frmLogin : Form
    {
        public static int maNhanVien;
        public static string username;
        private string password;
        DBTaiKhoan dbTaiKhoan;
        public frmLogin()
        {
            InitializeComponent();
            dbTaiKhoan = new DBTaiKhoan();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool f;
            username = txtUsername.Text;
            password = txtPassword.Text;
            string err = "";
            try
            {
                f = dbTaiKhoan.KiemTraTaiKhoan(ref err, username, password);
                if (f)
                {
                    frmMain frm = new frmMain();
                    maNhanVien = dbTaiKhoan.LayMaNhanVien(ref err, username);
                    if (maNhanVien != -1)
                    {
                        string quyen = dbTaiKhoan.KiemTraQuyen(ref err, username);
                        if (quyen == "NhanVien")
                        {
                            frm.tileNhanVien.Visible = false;
                            frm.tileTaiKhoan.Visible = false;
                        }
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai rồi!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Đăng nhập thất bại!!\n\r" + "Lỗi:" + err);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
