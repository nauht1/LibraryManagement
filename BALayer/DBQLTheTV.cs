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
    public class DBQLTheTV
    {
        DAL db = null;
        public DBQLTheTV()
        {
            db = new DAL();
        }
        public DataSet LayPhieuMoThe()
        {
            return db.ExecuteQueryDataSet("Select * from PhieuMoThe Where TrangThai = 'ChuaCap'", CommandType.Text, null);
        }
        public DataSet LayToanBoPhieuMoThe()
        {
            return db.ExecuteQueryDataSet("Select * from PhieuMoThe", CommandType.Text, null);
        }
        public bool ThemPhieuMoThe(ref string err, int maDocGia, int maNhanVien, DateTime ngayLap)
        {

            return db.MyExecuteNonQuery("spThemPhieuMoThe", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDocGia", maDocGia),
                new SqlParameter("@maNhanVien", maNhanVien),
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
        public bool CapNhatTheThuVien(ref string err, int maThe)
        {
            return db.MyExecuteNonQuery("spCapNhatPhieuMoThe", CommandType.StoredProcedure, ref err,
            new SqlParameter("@maThe", maThe));
        }

        public bool GiaHanTheThuVien(ref string err, int maThe)
        {
            return db.MyExecuteNonQuery("spGiaHanTheThuVien", CommandType.StoredProcedure, ref err,
            new SqlParameter("@maThe", maThe));
        }
    }
}
