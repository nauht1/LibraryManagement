using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BALayer
{
    public class DBPhieuMuonTra
    {
        DAL db = null;
        public DBPhieuMuonTra()
        {
            db = new DAL();
        }
        public DataSet LayChiTietPhieuMuon()
        {
            return db.ExecuteQueryDataSet("Select * from viewCTPhieuMuon", CommandType.Text, null);
        }
        public DataSet LayPhieuMuon()
        {
            return db.ExecuteQueryDataSet("Select * from viewPhieuMuon", CommandType.Text, null);
        }
        public bool ThemPhieuMuon(ref string err, int maDocGia, int maNhanVien, DateTime ngayMuon, DateTime ngayHenTra)
        {
            return db.MyExecuteNonQuery("spThemPhieuMuon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDocGia", maDocGia),
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@ngayMuon", ngayMuon),
                new SqlParameter("@ngayHenTra", ngayHenTra));
        }
        public bool ThemChiTietPhieuMuon(ref string err, string maSach)
        {
            return db.MyExecuteNonQuery("spThemChiTietPhieuMuon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maSach", maSach));
        }
        public bool TraSach(ref string err, int maPhieuMuon, string maSach, DateTime ngayTraThuc, string tinhTrangTra)
        {
            return db.MyExecuteNonQuery("spTraSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhieuMuon", maPhieuMuon),
                new SqlParameter("@maSach", maSach),
                new SqlParameter("@ngayTraThuc", ngayTraThuc),
                new SqlParameter("@tinhTrangTra", tinhTrangTra));
        }
        public bool GiaHanPhieuMuon(ref string err, int maPhieuMuon, DateTime giaHan)
        {
            return db.MyExecuteNonQuery("spGiaHanPhieuMuon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhieuMuon", maPhieuMuon),
                new SqlParameter("@giaHan", giaHan));
        }        
    }
}
