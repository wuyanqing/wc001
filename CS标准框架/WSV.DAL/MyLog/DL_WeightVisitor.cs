using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.MyLog
{
    public class DL_WeightVisitor : DataBaseVisitor
    {
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
                    sql = "select ID,Code,Name,Weight,Datetime,TableCode,IP From V_DL_Weight where Datetime between @Begin and @Over order by ID desc";
                    break;
                case "SelectOption":
                    sql = "select ID,Code,Name,Weight,Datetime,TableCode,IP From V_DL_Weight where Name=@Name and Datetime between @Begin and @Over order by ID desc";
                    break;
                case "AddPicture":
                    sql = "Select Image1,Image2,Image3,Image4,Curve from DL_Weight where Code=@Code";
                    break;
                case"AddCurve":
                    sql = "select Curve from DL_Weight where Code=@Code";
                    break;
            }
            return sql;
        }
    }
}
