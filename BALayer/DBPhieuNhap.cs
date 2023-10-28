using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class DBPhieuNhap
    {
        DAL db = null;
        public DBPhieuNhap()
        {
            db = new DAL();
        }
        public DataSet LayPhieuNhap()
        {
            return db.ExecuteQueryDataSet("Select * from PhieuNhap", CommandType.Text, null);
        }
        public DataSet LayCTPhieuNhap()
        {
            return db.ExecuteQueryDataSet("Select * from CT_PhieuNhap", CommandType.Text, null);
        }
        public bool TaoPhieuNhap(ref string err, int maNV, DateTime ngayNhap, decimal tongTien)
        {
            return db.MyExecuteNonQuery("spThemPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNhanVien", maNV),
                new SqlParameter("@ngayNhap", ngayNhap),
                new SqlParameter("@tongTien", tongTien));
        }
        public bool ThemChiTietPhieuNhap(ref string err, string maDauSach, string tenDauSach, string maSach, 
                                            int maTacGia, int maNXB, decimal donGia)
        {
            return db.MyExecuteNonQuery("spThemChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDauSach", maDauSach),
                new SqlParameter("@tenDauSach", tenDauSach),
                new SqlParameter("@maSach", maSach),
                new SqlParameter("@maTacGia", maTacGia),
                new SqlParameter("@maNXB", maNXB),
                new SqlParameter("@donGia", donGia));
        }

    }
}
