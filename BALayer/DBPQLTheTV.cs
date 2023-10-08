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
    public class DBPQLTheTV
    {
        DAL db = null;
        public DBPQLTheTV()
        {
            db = new DAL();
        }
        public DataSet LayToanBoPhieuMoThe()
        {
            return db.ExecuteQueryDataSet("Select * from PhieuMoThe", CommandType.Text, null);
        }
        public bool ThemPhieuMoThe(ref string err, int maDocgia, int maPhieuMoThe, DateTime ngayLap)
        {
            return db.MyExecuteNonQuery("spThemPhieuMoThe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDocgia", maDocgia),
                new SqlParameter("@maPhieuMoThe", maPhieuMoThe),
                new SqlParameter("@ngayLap", ngayLap));
        }
        public bool CapNhatPhieuMoThe(ref string err, int maPhieuMo)
        {
            return db.MyExecuteNonQuery("spCapNhatPhieuMoThe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhieuMo", maPhieuMo));
        }

        /// TheThuVien
        public DataSet LayToanBoTheThuVien()
        {
            return db.ExecuteQueryDataSet("Select * from TheThuVien", CommandType.Text, null);
        }
        public DataSet LayTheThuVien()
        {
            return db.ExecuteQueryDataSet("Select * from viewTheThuVien", CommandType.Text, null);
        }
    }
}
