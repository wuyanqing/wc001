using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.User
{
    public class UsersDAL:DataBaseVisitor
    {
        /// <summary>
        /// 主数据
        /// </summary>
        public override string ExecSql(string sqlCommand)
        {
            return CommonSql(sqlCommand);//返回查询结果集
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                case "Select":
                    sql = "select * from V_D_User where id>2";
                    break;
                case "Insert":
                    sql="insert into D_User(Id,Code,Name,Uid,Pwd,Role,Used) values(@Id,@Code,@Name,@Uid,@Pwd,@Role,@Used)";
                    break;
                case "Update":
                    sql="update D_User set Code=@Code,Name=@Name,Uid=@Uid,Pwd=@Pwd,Role=@Role,Used=@Used where Id=@Id";
                    break;
                case "UserLogin":
                    sql = "select * from V_D_User where Uid=@Uid and Pwd=@Pwd and Used=1";
                    break;
                case "UserLock":
                    sql = "select * from V_D_User where Uid=@Uid and Pwd=@Pwd and Used=1";
                    break;
                case "RePwd":
                    sql = "update D_User set Pwd=@Pwd where Id=@Id";
                    break;
            }
            return sql;
        }
    }
}
