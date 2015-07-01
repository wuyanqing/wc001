using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class LoadoMeterDAL:DataBaseVisitor
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
                    sql = "select Id,TableNum,[Name],Ip,Port,Remark from DC_LoadoMeter";
                    break;
                case "Insert":
                    sql = "insert into DC_LoadoMeter(Id,TableNum,[Name],Ip,Port,Remark) values(@Id,@TableNum,@Name,@Ip,@Port,@Remark)";
                    break;
                case "Update":
                    sql = "update DC_LoadoMeter set [Name]=@Name,Ip=@Ip,Port=@Port,Remark=@Remark where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
