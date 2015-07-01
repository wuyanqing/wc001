using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Record
{
    public class D_BaseVisitor : DataBaseVisitor
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
                    sql = "select ID,CodeID,Name,Rem from D_Base where ParentCode=@ParentCode and used=1";
                    break;
                //查询作废的信息
                case "Select_Used":
                    sql = "select ID,CodeID,Name,Rem from D_Base where ParentCode=@ParentCode and used=0";
                    break;
                //修改信息
                case "Update":
                    sql = "update D_Base set CodeID=@CodeID,Name=@Name,Rem=@Rem where ID=@ID";
                    break;
                //作废修改
                case "Update_Used":
                    sql = "update D_Base set used=@used where ID=@ID";
                    break;
                //添加信息
                case "Insert":
                    sql = "insert into D_Base (ID,Code,CodeID,Name,Rem,ParentCode) values(@ID,@Code,@CodeID,@Name,@Rem,@ParentCode)";
                    break;
                //查询存在的编号
                case "SelectByCode":
                    sql = "select CodeID from D_Base where CodeID=@CodeID and ParentCode=@ParentCode";
                    break;
                //删除
                case "Delete":
                    sql = "Delete from D_Base where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
