using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Count
{
    public class D_StatProjectDal : DataBaseVisitor
    {
        // <summary>
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
                //查询全部方案
                case "Select":
                    sql = "select Name,Code from D_StatProject";
                    break;
                //根据方案查找对应的数据字段
                case "SelectByCode":
                    sql = "select Code,place from V_C_Stat where ProCode=@ProCode";
                    break;
                //根据方案找全部的对应信息
                case "SelectByName":
                    sql = "select Type,SataType,Flag,Month,Day,BeginTime,EndTime from D_StatProject where Name=@Name";
                    break;
                //添加新方案
                case "Insert":
                    sql = "Insert into D_StatProject (ID,Code,Name) values(@ID,@Code,@Name)  ";
                    break;
                //修改方案
                case "Update":
                    sql = "update D_StatProject set Type=@Type,SataType=@SataType,Flag=@Flag,Month=@Month,Day=@Day,BeginTime=@BeginTime,EndTime=@EndTime where Code=@Code";
                    break;
                    break;
                //删除方案
                case "Delete":
                    sql = "Delete from D_StatProject where Code=@Code";
                    break;
            }
            return sql;
        }
    }
}
