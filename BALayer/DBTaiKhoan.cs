using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBTaiKhoan
    {
        DAL db = null;
        public DBTaiKhoan()
        {
            db = new DAL();
        }
        public DataSet LayTaiKhoanDangNhap()
        {
            return db.ExecuteQueryDataSet("Select * from TaiKhoanDangNhap", CommandType.Text, null);
        }
        public bool KiemTraTaiKhoan(ref string err, string username, string password)
        {
            string query = "Select COUNT(*) from TaiKhoanDangNhap " +
                            "JOIN dbo.NhanVien " +
                            "ON NhanVien.MaNhanVien = TaiKhoanDangNhap.MaNhanVien " +
                            "WHERE TaiKhoanDangNhap.TenDangNhap = @username " +
                                    "And TaiKhoanDangNhap.MatKhau = @password " +
                                    "AND NhanVien.TrangThai = @status";
            return db.MyExcuteScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@status", 1));
        }
        public int LayMaNhanVien(ref string err, string username)
        {
            string query = "SELECT MaNhanVien FROM TaiKhoanDangNhap WHERE TenDangNhap = @username";
            object result = db.ReturnObjectScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username));

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return -1;
        }
        public string KiemTraQuyen(ref string err, string username)
        {
            string query = "SELECT Quyen FROM TaiKhoanDangNhap WHERE TenDangNhap = @username";

            object result = db.ReturnObjectScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username));
            string quyen = "";
            if (result != null && result != DBNull.Value)
            {
                quyen = Convert.ToString(result);
            }
            return quyen;
        }
        public DataTable LayThongTinDangNhap(int maNhanVien)
        {
            SqlDataAdapter da = db.ReturnDataAdapter($"SELECT * FROM NhanVien Where MaNhanVien = {maNhanVien}");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool DoiMatKhau(ref string err, string username, string matKhauCu, string matKhauMoi)
        {
            return db.MyExecuteNonQuery("spDoiMatKhau", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenDangNhap", username),
                new SqlParameter("@matKhauCu", matKhauCu),
                new SqlParameter("@matKhauMoi", matKhauMoi));
        }
    }
}
