using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.User
{
    public class PowerDAL:DataBaseVisitor
    {
        /// <summary>
        /// 主数据
        /// </summary>
        public override string ExecSql(string sqlCommand)
        {
            return CommonSql(sqlCommand);//返回查询结果集
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                case "Select":
                    sql = "select Id,Code,Name,ParentCode,RuleName from V_DC_Power";
                    break;
                case "Insert":
                    sql = "insert into DC_Power(Id,Code,Name,ParentCode,RuleName) values(@Id,@Code,@Name,@ParentCode,@RuleName)";
                    break;
                case "Update":
                    sql = "update DC_Power set Name=@Name,RuleName=@RuleName where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
