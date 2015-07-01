using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class CountDal : DataBaseVisitor
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
                //全部汇总项目
                case "Select":
                    sql = "select Name,Code,DbName from V_C_StatSelect Order By Place asc";
                    break;
                //根据方案编号查询该方案的汇总项目
                case "SelectCode":
                    sql = "select StatCode from D_StatProjectItem where Code = @Code Order By Place asc";
                    break;
                //根据方案编号查询该方案的汇总项目
                case "SelectEidtCode":
                    sql = "select StatCode from D_StatProjectItem where Code = @Code  Order By Place desc";
                    break;
                //类型
                case "Selecttype":
                    sql = "select Code,Name from D_Type";
                    break;
                //查询全部汇总数据字段
                case "Select_V_C_Stat":
                    sql = "select ID,[As],Name,Place,Show,DBName,fun from V_C_Stat Order By Place asc";
                    break;
                //查询fun数据字段
                case "Selectfun":
                    sql = "select Fun,Name from C_Function";
                    break;
                //保存设置
                case "Update":
                    sql = "Update C_Stat set [As]=@As,Show=@Show,Place=@Place,Fun=@Fun where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
