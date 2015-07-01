using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Record
{
    public class DC_BaseVisitor : DataBaseVisitor
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
                    sql = "select ID, Code,Name,Flag,Rank from V_DC_Base";
                    break;
                case "SelectByName":
                    sql = "select Code from V_DC_Base where Name=@Name";
                    break;
                case "Update":
                    sql = "update DC_Base set code=@Code,Name=@Name,AS=@AS,Flag=@Flag,Rank=@Rank where id=@ID";
                    break;
            }
            return sql;
        }
    }
}
