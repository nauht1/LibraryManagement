using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBPhieuViPham
    {
        DAL db = null;
        public DBPhieuViPham()
        {
            db = new DAL();
        }
        public DataSet LayToanBoPhieuViPham()
        {
            return db.ExecuteQueryDataSet("Select * from PhieuViPham", CommandType.Text, null);
        }
        public DataTable LayMaPhieuMuon()
        {
            SqlDataAdapter da = db.ReturnDataAdapter("Select * from PhieuViPham");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet TimKiemCT_PhieuViPham(int maPhieuMuon)
        {
            return db.ExecuteQueryDataSet($"Select * from PhieuViPham WHERE maPhieuMuon = {maPhieuMuon} ", CommandType.Text,null);
        }
        public DataTable LayMaPhieuMuonChuaThem()
        {
            SqlDataAdapter da = db.ReturnDataAdapter("SELECT DISTINCT maPhieuMuon FROM view_LoiVPChuaThem");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet LayLoiViPham()
        {
            return db.ExecuteQueryDataSet("Select * from viewLoiViPham", CommandType.Text, null);
        }
        public DataSet viewLoiViPhamChuaThem()
        {
            return db.ExecuteQueryDataSet("Select * from view_LoiVPChuaThem", CommandType.Text, null);
        }
        public bool ThemPhieuViPham(ref string err, int maPhieuMuon, int maNhanVien, string maSach)
        {
            return db.MyExecuteNonQuery("spThemPhieuViPham", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maPhieuMuon", maPhieuMuon),
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@maSach", maSach));
        }
        public DataSet TimKiemCT_MaPhieuChuaThem(int maPhieuMuon)
        {
            return db.ExecuteQueryDataSet($"Select * from view_LoiVPChuaThem WHERE maPhieuMuon = {maPhieuMuon} ", CommandType.Text, null);
        }
    }
}
