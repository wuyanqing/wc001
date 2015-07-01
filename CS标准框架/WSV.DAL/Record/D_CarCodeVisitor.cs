using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Record
{
    public class D_CarCodeVisitor : DataBaseVisitor
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
                //查询没作废的信息
                case "Select_Use":
                    sql = "select ID,Code,CarCode,Tare,Driver from D_CarCode where used=0";
                    break;
                //查询作废的信息
                case "Select_Used":
                    sql = "select ID,Code,CarCode,Tare,Driver from D_CarCode where used=1";
                    break;
                //修改信息
                case "Update":
                    sql = "update D_CarCode set Code=@Code,CarCode=@CarCode,Tare=@Tare,Driver=@Driver where ID=@ID";
                    break;
                //作废修改
                case "Update_Used":
                    sql = "update D_CarCode set used=@used where ID=@ID";
                    break;
                //添加信息
                case "Insert":
                    sql = "insert into D_CarCode (ID,Code,CarCode,Tare,Driver) values(@ID,@Code,@CarCode,@Tare,@Driver)";
                    break;
                //查询存在的编号
                case "SelectByCode":
                    sql = "select Code from D_CarCode where Code=@Code";
                    break;
                //删除
                case "Delete":
                    sql = "Delete from D_CarCode where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
