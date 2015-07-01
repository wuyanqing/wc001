using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class D_StatProjectItemDal : DataBaseVisitor
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
                    //删除
                case "Delete":
                    sql = "Delete from D_StatProjectItem where Code=@Code";
                    break;
                    //添加
                case "Insert":
                    sql = "Insert into D_StatProjectItem (Code,StatCode,Place) values(@Code,@StatCode,@Place)";
                    break;
            }
            return sql;
        }
    }
}
