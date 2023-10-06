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
    public class DBDocGia
    {
        DAL db = null;
        public DBDocGia()
        {
            db = new DAL();
        }
        public DataSet LayDocGia()
        {
            return db.ExecuteQueryDataSet("Select * from viewDocGiaHienTai", CommandType.Text, null);
        }
        public DataSet LayToanBoDocGia()
        {
            return db.ExecuteQueryDataSet("Select * from DocGia", CommandType.Text, null);
        }
        public bool ThemDocGia(ref string err, string hoTen,
    DateTime ngaySinh, string diaChi, string soDienThoai, string CCCD)
        {
            return db.MyExecuteNonQuery("spThemDocGia", CommandType.StoredProcedure, ref err,
            new SqlParameter("@hoTen", hoTen),
            new SqlParameter("@ngaySinh", ngaySinh),
            new SqlParameter("@diaChi", diaChi),
            new SqlParameter("@soDienThoai", soDienThoai),
            new SqlParameter("@cccd", CCCD));
        }
        public bool CapNhatDocGia(ref string err,int maDocGia, string hoTen,
    DateTime ngaySinh, string diaChi, string soDienThoai, string CCCD)
        {
            return db.MyExecuteNonQuery("spCapNhatDocGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDocGia", maDocGia),
            new SqlParameter("@hoTen", hoTen),
            new SqlParameter("@ngaySinh", ngaySinh),
            new SqlParameter("@diaChi", diaChi),
            new SqlParameter("@soDienThoai", soDienThoai),
            new SqlParameter("@cccd", CCCD));
        }
        public bool XoaDocGia(ref string err, int maDocGia)
        {
            return db.MyExecuteNonQuery("spXoaDocGia", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maDocGia", maDocGia));
        }
    }
}

