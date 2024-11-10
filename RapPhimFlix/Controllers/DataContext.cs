using RapPhimFlix.Appsetting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimFlix.Controllers
{
    public class DataContext
    {
        private readonly string strConnect = AppSetting.ConnectionString;
        private SqlConnection sqlConncect = null;

        private void OpenConnection()
        {
            sqlConncect = new SqlConnection(strConnect);
            if (sqlConncect.State != ConnectionState.Open)
                sqlConncect.Open();
        }
        private void CloseConnection()
        {
            if (sqlConncect.State != ConnectionState.Closed)
            {
                sqlConncect.Close();
                sqlConncect.Dispose();
            }
        }

        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            if (sql != null && sql != "")
            {
                OpenConnection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlConncect);
                dataAdapter.Fill(dt);
                CloseConnection();
                dataAdapter.Dispose();
            }
            return dt;
        }

        public bool ChangeData(string sql)
        {
            if (sql == null || sql == "") return false;
            OpenConnection();
            SqlCommand sqlcmm = new SqlCommand();
            sqlcmm.Connection = sqlConncect;
            sqlcmm.CommandText = sql;
            sqlcmm.ExecuteNonQuery();
            CloseConnection();
            sqlcmm.Dispose();
            return true;
        }
    }
}
