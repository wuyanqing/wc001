using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Record
{
    public class D_TypeVisitor : DataBaseVisitor
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
                    sql = "select ID, Code,Name from D_Type";
                    break;
                case "Update":
                    sql = "update D_Type set Name=@Name where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
