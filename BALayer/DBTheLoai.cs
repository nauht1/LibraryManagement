using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBTheLoai
    {
        DAL db = null;
        public DBTheLoai()
        {
            db = new DAL();
        }
        public DataSet LayTheLoai()
        {
            return db.ExecuteQueryDataSet("Select * from viewTheLoaiHienTai", CommandType.Text, null);
        }
        public DataSet LayToanBoTheLoai()
        {
            return db.ExecuteQueryDataSet("Select * from TheLoai", CommandType.Text, null);
        }
        public bool ThemTheLoai(ref string err, string tenTheLoai)
        {
            return db.MyExecuteNonQuery("spThemTheLoai", CommandType.StoredProcedure, ref err,
            new SqlParameter("@tenTheLoai", tenTheLoai));
        }
        public bool CapNhatTheLoai(ref string err, int maTheLoai, string tenTheLoai)
        {
            return db.MyExecuteNonQuery("spCapNhatTheLoai", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maTheLoai", maTheLoai),
            new SqlParameter("@tenTheLoai", tenTheLoai));
        }
        public bool XoaTheLoai(ref string err, int maTheLoai)
        {
            return db.MyExecuteNonQuery("spXoaTheLoai", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maTheLoai", maTheLoai));
        }

        public bool ThemCT_TheLoai(ref string err, string maDauSach, int maTheLoai)
        {
            return db.MyExecuteNonQuery("spThemCT_TheLoai", CommandType.StoredProcedure, ref err,
            new SqlParameter("@maDauSach", maDauSach),
            new SqlParameter("@maTheLoai", maTheLoai));
        }

    }
}
