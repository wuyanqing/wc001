using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Weight
{
    public class CardDAL : DataBaseVisitor
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
                    sql = "select Card,Type,Item,Specs,Place,CarCode,Tare,Send,Accept,Carry,Model,Driver,Spare,State from V_D_Card_Temp";
                    break;
                case"Save_Card":
                    sql = "insert into D_Card(ID,Card,CarCode,Type,Item,Specs,Place,Send,Accept,Carry,Model,Driver,Spare,Tare,State) values (@ID,@Card,@CarCode,@Type,@Item,@Specs,@Place,@Send,@Accept,@Carry,@Model,@Driver,@Spare,@Tare,@State)";
                    break;
                case "SelectCard":
                    sql = "select Type,Item,Specs,Place,CarCode,Tare,Send,Accept,Carry,Model,Driver,Spare,State from V_D_Card_Temp where Card=@Card ";
                    break;
                case "Back_Code":
                    sql = "select Code from V_D_Base where Name=@Name";
                    break;
                case "Update_Card":
                    sql = "update D_Card set CarCode=@CarCode,Type=@Type,Item=@Item,Specs=@Specs,Place=@Place,Send=@Send,Accept=@Accept,Carry=@Carry,Model=@Model,Driver=@Driver,Spare=@Spare,Tare=@Tare,State=@State where Card=@Card";
                    break;
                case "Delete":
                    sql = "delete D_Card where Card=@Card";
                    break;
                case "SelectCard1":
                    sql = "select Type,Code,Item,Specs,Place,Accept,Send,Carry,G_Oper,G_Time,CarCode,Gross from V_D_Saver where Card=@Card and State=0";
                    break;
                case "Delete1":
                    sql = "delete D_Card where Card=@Card and Tare=0";
                    break;
                case "SelectByCard":
                    sql = "select Type,Item,Specs,Place,CarCode,Tare,Send,Accept,Carry,Model,Driver,Spare,State from D_Card where Card=@Card ";
                    break;
            }
            return sql;
        }
    }
}
