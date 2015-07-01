using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class BaseInfoDAL:DataBaseVisitor
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
                    sql = "select Id,Company,Address,Tel,PrintTitle from DC_BaseInfo";
                    break;
                case "Update":
                    sql = "update DC_BaseInfo set Company=@Company,Address=@Address,Tel=@Tel,PrintTitle=@PrintTitle where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
