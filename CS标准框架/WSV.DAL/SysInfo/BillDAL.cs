using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class BillDAL:DataBaseVisitor
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
                    sql = "select Id,Code,Name,BillName,PrintTitle,Preview from V_Bill order by Id";
                    break;
                case "Update":
                    sql = "update D_Bill set BillName=@BillName,PrintTitle=@PrintTitle,Preview=@Preview where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
