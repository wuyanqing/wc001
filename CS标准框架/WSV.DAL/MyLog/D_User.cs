using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.MyLog
{
    public class D_User : DataBaseVisitor
    {
        /// <summary>
        /// 主数据
        /// </summary>
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
                case "Select":
                    sql = "select * from D_User Where ID>1";
                    break;
            }
            return sql;
        }
    }
}
