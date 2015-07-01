using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Plan
{
    public class PlanVisitor : DataBaseVisitor
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
                //查询计划表信息
                case "Select_D_Plan":
                    sql = "select ID,Plan_Code,Plan_Type,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept,Remark,Plan_CountWay,Plan_Num,Plan_SpareNum,Plan_Money,Plan_SpareMoney,Begin_Time,End_Time,Plan_Used from V_DC_Plan";
                    break;
                //查询类型信息
                case "Select_Type":
                    sql = "select Code,Name from D_Type";
                    break;
                //查询该编号的计划信息
                case "Select_V_PlanByCode":
                    sql = "select Plan_Type,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept,Remark,Plan_CountWay,Plan_Num,Plan_SpareNum,Plan_Num,Plan_SpareNum,Plan_Money,Plan_SpareMoney,Begin_Time,End_Time from V_DC_Plan where Plan_Code=@Plan_Code";
                    break;
                //查询该编号的计划信息
                case "Select_D_PlanByCode":
                    sql = "select Plan_Type,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept,Remark,Plan_CountWay,Plan_Num,Plan_SpareNum,Plan_Num,Plan_SpareNum,Plan_Money,Plan_SpareMoney,Begin_Time,End_Time from D_Plan where Plan_Code=@Plan_Code";
                    break;
                //修改信息
                case "Update":
                    sql = "update D_Plan set Plan_Type=@Plan_Type,Plan_Item=@Plan_Item,Plan_Specs=@Plan_Specs,Plan_Send=@Plan_Send,Plan_Accept=@Plan_Accept,Remark=@Remark,Plan_CountWay=@Plan_CountWay,Plan_Num=@Plan_Num,Plan_SpareNum=@Plan_SpareNum,Plan_Money=@Plan_Money,Plan_SpareMoney=@Plan_SpareMoney,Begin_Time=@Begin_Time,End_Time=@End_Time where Plan_Code=@Plan_Code";
                    break;
                //作废修改
                case "Select_CountWay":
                    sql = "select Code,Name from D_CountWay";
                    break;
                //添加信息
                case "Insert":
                    sql = "insert into D_Plan(ID,Plan_Code,Plan_Type,Plan_Item,Plan_Specs,Plan_Send,Plan_Accept,Remark,Plan_CountWay,Plan_Num,Plan_SpareNum,Plan_Money,Plan_SpareMoney,Begin_Time,End_Time) values(@ID,@Plan_Code,@Plan_Type,@Plan_Item,@Plan_Specs,@Plan_Send,@Plan_Accept,@Remark,@Plan_CountWay,@Plan_Num,@Plan_SpareNum,@Plan_Money,@Plan_SpareMoney,@Begin_Time,@End_Time)";
                    break;
                //作废
                case "Used":
                    sql = "update D_Plan set Plan_Used=@Plan_Used where Plan_Code=@Plan_Code";
                    break;
                //删除
                case "Delete":
                    sql = "Delete from D_Plan where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
