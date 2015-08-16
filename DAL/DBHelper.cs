using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        //数据库连接
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|//DB//DeadLineDB.accdb; user id='Admin';Jet OLEDB:database password='4e08dd65cda76515';";

        private OleDbConnection conn;
        private OleDbDataAdapter oda = new OleDbDataAdapter();
        //private OleDbCommand cmd;
        private DataSet myds;

        /// <summary>
        /// 得到数据
        /// </summary>
        public DataTable GetDataSet(string sql)
        {
            using (conn = new OleDbConnection(connStr))
            {
                myds = new DataSet();
                oda = new OleDbDataAdapter(sql, conn);
                oda.Fill(myds);
                return myds.Tables[0];
            }
        }

        /// <summary>
        /// 是否执行成功
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ExecuteSql(string sql)
        {
            using (conn = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0 ? true:false;
            }
        }
    }
}
