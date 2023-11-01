using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class DBDauSach
    {
        DAL db = null;
        public DBDauSach()
        {
            db = new DAL();
        }
        public DataSet LayDauSachChuaCoTheLoai()
        {
            return db.ExecuteQueryDataSet("Select * from ViewDauSachChuaCoTheLoai", CommandType.Text, null);
        }
        public DataSet LayDauSachCoTheLoai()
        {
            return db.ExecuteQueryDataSet("Select * from ViewDauSachCoTheLoai", CommandType.Text, null);
        }
        public DataSet LayDauSach()
        {
            return db.ExecuteQueryDataSet("Select * from DauSach", CommandType.Text, null);
        }
    }
}
