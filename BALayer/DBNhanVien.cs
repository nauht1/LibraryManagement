using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace BALayer
{
    public class DBNhanVien
    {
        DAL db = null;
        public DBNhanVien()
        {
            db = new DAL();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("Select * from viewNhanVienHienThoi", CommandType.Text, null);
        }
        public DataSet LayToanBoNhanVien()
        {
            return db.ExecuteQueryDataSet("Select * from NhanVien", CommandType.Text, null);
        }
        public bool ThemNhanVien(ref string err, string hoTen, string gioiTinh, 
            DateTime ngaySinh, string email, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@email", email),
                new SqlParameter("@sdt", soDienThoai));
        }
        public bool CapNhatNhanVien(ref string err, int maNhanVien, string hoTen, string gioiTinh,
            DateTime ngaySinh, string email, string soDienThoai)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@email", email),
                new SqlParameter("@sdt", soDienThoai));
        }
        public bool XoaNhanVien(ref string err, int maNhanVien)
        {
            return db.MyExecuteNonQuery("spXoaNhanVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maNhanVien", maNhanVien));
        }
    }
}
