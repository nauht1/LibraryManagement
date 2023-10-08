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
    public class DBTheThuVien
    {
        DAL db = null;
        public DBTheThuVien()
        {
            db = new DAL();
        }
        public DataSet LayToanBoTheThuVien()
        {
            return db.ExecuteQueryDataSet("Select * from TheThuVien", CommandType.Text, null);
        }

    }
}
