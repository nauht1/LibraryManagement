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
    public class DBKeSach
    {
        DAL db = null;
        public DBKeSach()
        {
            db = new DAL();
        }
        public DataSet LayThongTinKeSach()
        {
            return db.ExecuteQueryDataSet("Select * from viewKeSach", CommandType.Text, null);
        }
        public DataSet LayToanBoKeSach()
        {
            return db.ExecuteQueryDataSet("Select * from KeSach", CommandType.Text, null);
        }
        public bool ThemKeSach(ref string err, string tenKeSach)
        {
            return db.MyExecuteNonQuery("spThemKeSach", CommandType.StoredProcedure, ref err,
            new SqlParameter("@tenKeSach", tenKeSach));
        }
        public bool CapNhatKeSach(ref string err, int maKeSach, string tenKeSach)
        {
            return db.MyExecuteNonQuery("spCapNhatKeSach", CommandType.StoredProcedure, ref err,
            new SqlParameter("@maKeSach", maKeSach),
            new SqlParameter("@tenKeSach", tenKeSach));
        }
        public bool XoaKeSach(ref string err, int maKeSach)
        {
            return db.MyExecuteNonQuery("spXoaKeSach", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maKeSach", maKeSach));
        }
    }
}
