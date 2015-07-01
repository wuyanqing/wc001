using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Record
{
    public class D_CubetyVisitor : DataBaseVisitor
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
                case "Select":
                    sql = "select ID,Code,Cubety from V_D_Cubety";
                    break;
                case "Insert":
                    sql = "Insert into D_Cubety (ID,Code,Cubety)values(@ID,@Code,@Cubety)";
                    break;
                case "Update":
                    sql = "update D_Cubety set code=@Code,Cubety=@Cubety where ID=@ID";
                    break;
                case "BingdItem":
                    sql = "select Code,Name from D_Base where ParentCode='001'";
                    break;
                //删除
                case "Delete":
                    sql = "Delete from D_Cubety where ID=@ID";
                    break;
                case "SelectCubety":
                    sql = "select Cubety from D_Cubety where code=@code";
                    break;
            }
            return sql;
        }
    }
}
