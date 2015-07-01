using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.MyLog
{
    public class Modify : DataBaseVisitor
    {
        public override string ExecSql(string sqlCommand)
        {
            string sql = "";//返回查询结果集
            if ((sql = CommonSql(sqlCommand)) != "")
                return sql;
            return sql;
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                case "SelMain":
                    sql = "Select Name from LC_Main";
                    break;
            }
            return sql;
        }
    }
}
