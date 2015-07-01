using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.SysInfo
{
    public class WeightDAL:DataBaseVisitor
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
                    sql = "select Id,Code,[Name],[Save],Show,[Time],X,Y from V_C_Weight order by Id";
                    break;
                case "Update":
                    sql = "update C_Weight set [Save]=@Save,Show=@Show,[Time]=@Time where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
