using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.MyLog
{
    public class DL_Run : DataBaseVisitor
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
                    sql = "select ID,Code,Work,InTime,OutTime,Name from V_DL_Run where DATEDIFF(d,InTime,@Begin)<=0 and DATEDIFF(d,OutTime,@Over)>=0 order by ID desc";
                    break;
                case "SelectOption":
                    sql = "select ID,Code,Work,InTime,OutTime,Name from V_DL_Run where Name=@Name and DATEDIFF(d,InTime,@Begin)<=0 and DATEDIFF(d,OutTime,@Over)>=0 order by ID desc";
                    break;
                case"MaxID":
                    sql = "select max(ID) from DL_Run";
                    break;
                case "Insert":
                    sql = "insert into DL_Run(ID,Code,[Work],InTime,OperCode,TableNum) values(@ID,@Code,@Work,@InTime,@OperCode,@TableNum)";
                    break;
                case "Update":
                    sql = "Update DL_Run set OutTime=@OutTime where Code=@Code";
                    break;
            }
            return sql;
        }
    }
}
