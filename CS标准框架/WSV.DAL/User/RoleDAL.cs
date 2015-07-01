using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.User
{
    public class RoleDAL:DataBaseVisitor
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
                    sql = "select * from V_D_UserRole";
                    break;
                case "Insert":
                    sql = "insert into D_UserRole(Id,Code,Name,ParentCode) values(@Id,@Code,@Name,@ParentCode)";
                    break;
                case "Update":
                    sql = "update D_UserRole set Name=@Name where Id=@Id";
                    break;
                case "RolePower":
                    sql = "select * from V_DC_RolePower where RoleCode=@RoleCode";
                    break;
                case "CheckRolePower":
                    sql = "select * from V_DC_RolePower where RoleCode=@RoleCode and RuleName=@RuleName";
                    break;
                case "DelRolePower":
                    sql="delete from Dc_RolePower where RoleCode=@RoleCode";
                    break;
                case "AddRolePower":
                    sql = "insert into DC_RolePower(RoleCode,PowerCode) values(@RoleCode,@PowerCode)";
                    break;
            }
            return sql;
        }
    }
}
