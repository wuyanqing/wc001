using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class BillInfoDAL : DataBaseVisitor
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
                case "BillInfoSql":
                    sql = "Select DBName,[Name] From V_C_Bill ";
                    break;
                case "BillInfoColName":
                    sql = "Select RuleName From V_C_Bill";
                    break;
                case "PrintParam":
                    sql = "select BillName,PrintTitle,Preview from V_Bill where Name=@TypeName";
                    break;
            }
            return sql;
        }
    }
}
