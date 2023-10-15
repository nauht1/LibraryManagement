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
    public class DBTacGia
    {
        DAL db = null;
        public DBTacGia()
        {
            db = new DAL();
        }
        public DataSet LayTacGia()
        {
            return db.ExecuteQueryDataSet("Select * from viewTacGiaHienTai", CommandType.Text, null);
        }
        public DataSet LayToanBoTacGia()
        {
            return db.ExecuteQueryDataSet("Select * from TacGia", CommandType.Text, null);
        }
        public bool ThemTacGia(ref string err, string tenTacGia,
    DateTime ngaySinh, string queQuan)
        {
            return db.MyExecuteNonQuery("spThemTacGia", CommandType.StoredProcedure, ref err,
            new SqlParameter("@tenTacGia", tenTacGia),
            new SqlParameter("@ngaySinh", ngaySinh),
            new SqlParameter("@queQuan", queQuan));
        }
        public bool CapNhatTacGia(ref string err, int maTacGia, string tenTacGia,
    DateTime ngaySinh, string queQuan)
        {
            return db.MyExecuteNonQuery("spCapNhatTacGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maTacGia", maTacGia),
            new SqlParameter("@tenTacGia", tenTacGia),
            new SqlParameter("@ngaySinh", ngaySinh),
            new SqlParameter("@queQuan", queQuan));
        }
        public bool XoaTacGia(ref string err, int maTacGia)
        {
            return db.MyExecuteNonQuery("spXoaTacGia", CommandType.StoredProcedure,
                ref err, new SqlParameter("@maTacGia", maTacGia));
        }
    }
}
