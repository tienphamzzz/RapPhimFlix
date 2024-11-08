using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RapPhimFlix.Classes
{
    internal class DataProcesser
    {

        //Open a Connection to DataBase
        string strConnect = "Data Source=DESKTOP-ABL3Q2P\\SQLEXPRESS;Initial Catalog=QLCinema;Integrated Security=True;";
        SqlConnection sqlconnect = null;
        void OpenConnection()
        {
            sqlconnect = new SqlConnection(strConnect);
            if (sqlconnect.State != ConnectionState.Open)
                sqlconnect.Open();
        }
        //Close Connection
        void CloseConnection()
        {
            if (sqlconnect.State != ConnectionState.Closed)
            {
                sqlconnect.Close();
                sqlconnect.Dispose();
            }
        }
        //Read Data from a select statement and return a DataTable.
        public DataTable ReadData(string sqlSelect)
        {
            DataTable data = new DataTable();
            OpenConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlconnect);
            dataAdapter.Fill(data);
            CloseConnection();
            dataAdapter.Dispose();
            return data;
        }



        //Change Data 
        public void ChangeData(string sql)
        {
            OpenConnection();
            SqlCommand commad = new SqlCommand();
            commad.CommandText = sql;
            commad.Connection = sqlconnect;
            commad.ExecuteNonQuery();
            CloseConnection();
            commad.Dispose();
        }


    }
}
