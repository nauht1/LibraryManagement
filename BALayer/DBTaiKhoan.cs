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
        public bool KiemTraiKhoan(ref string err, string username, string password)
        {
            string query = "Select Count(*) from TaiKhoanDangNhap Where TenDangNhap = @username And MatKhau = @password";
            return db.MyExcuteScalar(query, CommandType.Text, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password));
        }
    }
}
