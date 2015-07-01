using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Port
{
    public class PortVisitor : DataBaseVisitor
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
                    sql = "select Code,Name from D_Base where ParentCode='005'";
                    break;
                case "Insert":
                    sql = "execute insertWG @fcustid,@FDeptID,@FDate,@fitemid,@FUnitID,@FFManagerID ,@FSManagerID,@FDCStockID,@FQty,@FPrice,@FAmount,@fbiller";
                    break;
                case "Update":
                    sql = "update DC_Base set code=@Code,Name=@Name,AS=@AS,Flag=@Flag,Rank=@Rank where id=@ID";
                    break;
                case "BingdItem":
                    sql = "select Code,Name from D_Base where ParentCode='001'";
                    break;
            }
            return sql;
        }
    }
}
