using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Search
{
    public class SearchDal : DataBaseVisitor
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
                //查询设置的信息
                case "Select_V_C_Select":
                    sql = "select ID,[As],Name,DBName,Place,Show,[Print] from V_C_Select Order By Place asc";
                    break;
                //保存设置
                case "Update":
                    sql = "Update C_Select set [As]=@As,Show=@Show,Place=@Place where ID=@ID";
                    break;
                //删除数据
                case "Delete":
                    sql = "Delete from D_Saver where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
