using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WSV.DAL.Weight
{
    public class PlanDAL : DataBaseVisitor
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
                case "SelectALL":
                    sql = "select Plan_Code,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept from V_DC_Plan where Plan_Used = 0";
                    break;
                case "selectCode":
                    sql = "select Plan_Code from V_DC_Plan where Plan_Code = @flag and Plan_Used = 0";
                    break;
                case "Plan_SpareNum":
                    sql = "update D_Plan set Plan_SpareNum = @Plan_SpareNum where Plan_Code=@Plan_Code";
                    break;
                case "Plan_SpareMoney":
                    sql = "update D_Plan set Plan_SpareMoney=@Plan_SpareMoney where Plan_Code=@Plan_Code";
                    break;
            }
            return sql;
        }
    }
}
