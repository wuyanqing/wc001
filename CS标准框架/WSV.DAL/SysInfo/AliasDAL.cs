using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class AliasDAL:DataBaseVisitor
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
                    sql = "select Id,Code,Name,RuleName,DbName,DataType,State from V_C_Alias order by Id";
                    break;
                case "Update":
                    sql = "update C_Alias set Name=@Name,State=@State where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
