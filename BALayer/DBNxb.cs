using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
