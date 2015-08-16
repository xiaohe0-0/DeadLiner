using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class DBServer
    {
        public DataTable GetCon(int num)
        {
            string sql = string.Format(@"select * from DeadLine where ID={0}", num);
            DBHelper dbh = new DBHelper();
            return dbh.GetDataSet(sql);
        }

        public DataTable GetCount(string tab)
        {
            string sql = string.Format(@"select count(*) from {0}", tab);
            DBHelper dbh = new DBHelper();
            return dbh.GetDataSet(sql);
        }

        public DataTable GetAllData(string tab)
        {
            string sql = string.Format(@"select * from {0} order by DateItem", tab);
            DBHelper dbh = new DBHelper();
            return dbh.GetDataSet(sql);
        }

        public bool DeleteOneItem(string tab,int userID)
        {
            string sql = string.Format(@"delete from {0} where ID={1}", tab,userID);
            DBHelper dbh = new DBHelper();
            return dbh.ExecuteSql(sql);
        }

        public bool AddOneItem(string remindDate, string remindCon)
        {
            string sql = String.Format(@"insert into DeadLine(DateItem,ContentItem) values('{0}','{1}')", remindDate, remindCon);
            DBHelper dbh = new DBHelper();
            return dbh.ExecuteSql(sql);
        }

        public bool UpdateOneItem(int num,string upDate,string upCon)
        {
            string sql = String.Format(@"Update DeadLine set DateItem='{0}',ContentItem='{1}' where ID={2}", upDate, upCon, num);
            DBHelper dbh = new DBHelper(); 
            return dbh.ExecuteSql(sql);
        }
        
    }
}
