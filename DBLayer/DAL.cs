using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DAL
    {
        string sqlStringConnection = "Data Source=DESKTOP-SCFTBIO\\KHAI;" +
            "Initial Catalog=QLThuVien;Integrated Security=True";
            
            //"Data Source = DESKTOP-ACER\\THUAN; " +
            //"Initial Catalog = QLThuVien; " +
            //"User ID = sa; " +
            //"Password = 281003";

        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DAL()
        {
            conn = new SqlConnection(sqlStringConnection);
            comm = conn.CreateCommand();
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(sqlStringConnection);
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public SqlDataAdapter ReturnDataAdapter(string comm)
        {
            return new SqlDataAdapter(comm, conn);
        }
        public bool MyExcuteScalar(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                int count = (int)comm.ExecuteScalar();
                if (count > 0)
                    f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public object ReturnObjectScalar(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            object obj = null;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                obj = comm.ExecuteScalar();
                return obj;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }
    }
}
