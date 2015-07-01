using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using System.Data.SqlClient;
using System.Data;

namespace WSV.DAL.MyLog
{
    public class OperData : DataBaseVisitor
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
                case "AddData":
                    sql = "insert into D_Saver(ID,Code,CarCode,Item,Specs,Place,Send,Accept,Carry,Model,Driver,Spare,Type,Card,Plan_Code,G_Table,T_Table,G_Oper,T_Oper,Gross,Tare,Net,EndNet,Impurity,ImpurityRate,DeductWei,DeductRate,Cube,Cubety,InhereWei,DifferWei,Price,[Money],State,G_Time,T_Time,N_Time) " +
                          "values(@ID,@Code,@CarCode,@Item,@Specs,@Place,@Send,@Accept,@Carry,@Model,@Driver,@Spare,@Type,@Card,@Plan_Code,@G_Table,@T_Table,@G_Oper,@T_Oper,@Gross,@Tare,@Net,@EndNet,@Impurity,@ImpurityRate,@DeductWei,@DeductRate,@Cube,@Cubety,@InhereWei,@DifferWei,@Price,@Money,@State,@G_Time,@T_Time,@N_Time)";
                    break;
                case "AddMaintenance":
                    sql = "insert into DL_Maintenance(ID,TableNum,SaverCode,WorkCode,OperCode) values(@ID,@TableNum,@SaverCode,@WorkCode,@OperCode)";
                    break;
                //case "AlterMaintenance":
                //    sql = "insert into DL_Maintenance(ID,SaverCode,WorkCode,DT,OperCode) values(@ID,@SaverCode,@WorkCode,@DT,@OperCode)";
                //    break;
                case "Modify":
                    sql = "insert into L_Modify(ID,Code,CarCode,Item,Specs,Place,Send,Accept,Carry,Model,Driver,Spare,Type,Card,Plan_Code,G_Table,T_Table,G_Oper,T_Oper,Gross,Tare,Net,EndNet,Impurity,ImpurityRate,DeductWei,DeductRate,Cube,Cubety,InhereWei,DifferWei,Price,[Money]) " +
                          "values(@ID,@Code,@CarCode,@Item,@Specs,@Place,@Send,@Accept,@Carry,@Model,@Driver,@Spare,@Type,@Card,@Plan_Code,@G_Table,@T_Table,@G_Oper,@T_Oper,@Gross,@Tare,@Net,@EndNet,@Impurity,@ImpurityRate,@DeductWei,@DeductRate,@Cube,@Cubety,@InhereWei,@DifferWei,@Price,@Money)";
                    break;
                case "UpdateData":
                    sql = "update D_Saver set CarCode=@CarCode,Item=@Item,Specs=@Specs,Place=@Place,Send=@Send,Accept=@Accept,Carry=@Carry,Model=@Model,Driver=@Driver,Spare=@Spare,Type=@Type,Card=@Card,Plan_Code=@Plan_Code,G_Table=@G_Table,T_Table=@T_Table,G_Oper=@G_Oper,T_Oper=@T_Oper,Gross=@Gross,Tare=@Tare,Net=@Net,EndNet=@EndNet,Impurity=@Impurity,ImpurityRate=@ImpurityRate,DeductWei=@DeductWei,DeductRate=@DeductRate,Cube=@Cube,Cubety=@Cubety,InhereWei=@InhereWei,DifferWei=@DifferWei,Price=@Price,[Money]=@Money,Updata_Time=@Updata_Time,Updata_Oper=@Updata_Oper,State=@State where Code=@Code";
                    break;
                // 根据编号查主表视图数据
                case "SelectCode":
                    sql = "select Code,CarCode,Item,Specs,Place,Send,Accept,Carry,Model,Driver,Spare,Type,Card,Plan_Code,G_Oper,Gross,Tare,Net,EndNet,Impurity,ImpurityRate,DeductWei,DeductRate,Cube,Cubety,InhereWei,DifferWei,Price,Money,Verify,used from V_D_Saver where Code=@Code";
                    break;
                //根据编号查主表数据
                case "SelectByCode":
                    sql = "select Code,CarCode,Item,Specs,Place,Send,Accept,Carry,Model,Driver,Spare,Type,Card,Plan_Code,G_Oper,T_Oper,G_Table,T_Table,Gross,Tare,Net,EndNet,Impurity,ImpurityRate,DeductWei,DeductRate,Cube,InhereWei,DifferWei,Price,Money,Verify,used from D_Saver where Code=@Code";
                    break;
                case "OnCheck":
                    sql = "update D_Saver set Verify=1 where Code=@Code";
                    break;
                case "UnCheck":
                    sql = "update D_Saver set Verify=0 where Code=@Code";
                    break;
                case "OnUsed":
                    sql = "update D_Saver set Used=1 where Code=@Code";
                    break;
                case "UnUsed":
                    sql = "update D_Saver set Used=0 where Code=@Code";
                    break;
                case "SelType":
                    sql = "select Code,Name from D_Type";
                    break;
                case "Delete":
                    sql = "delete from DL_Maintenance where ID=@ID";
                    break;
                case "Delete_Modify":
                    sql = "delete from L_Modify where ID=@ID";
                    break;
            }
            return sql;
        }
    }
}
