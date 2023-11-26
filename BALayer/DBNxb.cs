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
    public class DBNxb
    {
        DAL db = null;
        public DBNxb()
        {
            db = new DAL();
        }
        public DataSet LayNXB()
        {
            return db.ExecuteQueryDataSet("Select * from viewNxbHienTai", CommandType.Text, null);
        }
        public DataSet LayToanBoNXB()
        {
            return db.ExecuteQueryDataSet("Select * from NhaXuatBan", CommandType.Text, null);
        }
        public bool ThemNXB(ref string err, string tenNXB, string diaChi)
        {
            return db.MyExecuteNonQuery("spThemNhaXuatBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenNXB", tenNXB),
                new SqlParameter("@diaChi", diaChi));
        }
        public bool CapNhatNXB(ref string err, int maNXB, string tenNXB, string diaChi)
        {
            return db.MyExecuteNonQuery("spCapNhatNhaXuatBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNXB", maNXB),
                new SqlParameter("@tenNXB", tenNXB),
                new SqlParameter("@diaChi", diaChi));
        }
        public bool XoaNXB(ref string err, int maNXB)
        {
            return db.MyExecuteNonQuery("spXoaNhaXuatBan", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maNXB", maNXB));
        }
    }
}
