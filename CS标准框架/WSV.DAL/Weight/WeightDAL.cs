using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace WSV.DAL.Weight
{
    public class WeightDAL : DataBaseVisitor
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
                case "SelectALL"://显示临时数据
                    sql = "select Code,CarCode,Item,Specs,Place,Send,Accept,Carry,InhereWei,DifferWei," +
                    "Model,Driver,Spare,Gross,Tare,Type,G_Oper,T_Oper,G_Time,T_Time,Plan_Code,Card,Cubety from V_D_Saver where State=0 and Used=0 order by Code desc";
                    break;
                case "D_Operate"://显示D_Operate数据
                    sql = "select Code,Name from V_D_Base where flag=@Flag";
                    break;
                case "D_OperateFlag"://显示D_OperateItem数据
                    sql = "select Code,Name from V_D_Base where flag=@Flag and PortId2=@PortId2";
                    break;
                case "D_Add"://给D_Operate 添加新数据
                    sql = "select Code from V_DC_Base where flag=@Flag";
                    break;
                case "SelectType"://添加类型
                    sql = "select Name,Code from D_Type";
                    break;
                case "Retain"://刷新时是否保留数据
                    sql = "select [Save] from V_C_Weight where RuleName = @name";
                    break;
                case "GridViewName"://生成称重字符串
                    sql = "select DBName from V_C_Weight where State = 1";
                    break;
                case "Add_Name"://给D_Operate 标题添加名称
                    sql = "select Name from C_Alias where DBName=@Flag";
                    break;
                case "InsertSaverM"://添加毛重数据
                    sql = "insert into D_Saver( ID,Code,Card,CarCode,Item,Specs,Place,Send," +
                        " Accept,Carry,Model,Cube,InhereWei,DifferWei,Driver,Spare,Gross,Type,G_Time ,G_Oper,Plan_Code,Cubety,Accepter) " +
                        " values( @ID,@Code,@Card,@CarCode,@Item,@Specs,@Place,@Send," +
                        " @Accept,@Carry,@Model,@Cube,@InhereWei,@DifferWei,@Driver,@Spare,@Gross,@Type,@G_Time,@G_Oper,@Plan_Code,@Cubety,@Accepter) ";
                    break;
                case "InsertSaverP"://添加皮重数据
                    sql = " Insert Into D_Saver(ID,Code,Card,CarCode,Item,Specs,Place,Send," +
                        " Accept,Carry,Tare,Type,Model,Cube,InhereWei,DifferWei,Driver,Spare,T_Time,T_Oper ,Plan_Code,Cubety,Accepter) " +
                        " values( @ID,@Code,@Card,@CarCode,@Item,@Specs,@Place,@Send,@Accept," +
                        " @Carry,@Tare,@Type,@Model,@Cube,@InhereWei,@DifferWei,@Driver,@Spare,@T_Time,@T_Oper ,@Plan_Code,@Cubety,@Accepter)";
                    break;
                case "UpdateSaverP"://修改皮重
                    sql = "update D_Saver set Item=@Item,Specs=@Specs,Place=@Place,Send=@Send,Accept=@Accept,Carry=@Carry,Type=@Type,Model=@Model,Driver=@Driver,Spare=@Spare," +
                        "Cube=@Cube,InhereWei=@InhereWei,DifferWei=@DifferWei,Tare=@Tare,T_Time=@T_Time,Net=@Net,EndNet=@EndNet,N_Time=@N_Time," +
                        "Price=@Price,[Money]=@Money,DeductWei=@DeductWei,DeductRate=@DeductRate,Impurity=@Impurity," +
                        "ImpurityRate=@ImpurityRate,T_Oper=@T_Oper,State=1,Plan_Code=@Plan_Code,Cubety=@Cubety,Accepter=@Accepter where CarCode = @CarCode and Code=@Code and Used=0";
                    break;
                case "UpdateSaverM"://修改毛重
                    sql = "update D_Saver set Item=@Item,Specs=@Specs,Place=@Place,Send=@Send,Accept=@Accept,Carry=@Carry,Type=@Type,Model=@Model,Driver=@Driver,Spare=@Spare," +
                    "Cube=@Cube,InhereWei=@InhereWei,DifferWei=@DifferWei,Gross=@Gross,G_Time=@G_Time,Net=@Net,EndNet=@EndNet,N_Time=@N_Time," +
                        "Price=@Price,[Money]=@Money,DeductWei=@DeductWei,DeductRate=@DeductRate,Impurity=@Impurity," +
                        "ImpurityRate=@ImpurityRate,G_Oper=@G_Oper,State=1,Plan_Code=@Plan_Code,Cubety=@Cubety,Accepter=@Accepter where CarCode=@CarCode and Code=@Code and Used=0";
                    break;
                case "selectCarCode"://查询车号
                    sql = "select Code,Item,Specs,Place,Send,Accept,Carry," +
                        "Model,Cube,InhereWei,DifferWei,Driver,Spare,Gross,Tare,Type,G_Oper,T_Oper,G_Time," +
                        "T_Time,Plan_Code,Cubety from V_D_Saver_Temp where CarCode= @CarCode and State= 0 and Used=0";
                    break;
                case "selectByCarCode"://查询车号
                    sql = "select Item,Specs,Place,Send,Accept,Carry," +
                        "Model,Driver,Spare,Cubety from D_Saver where CarCode= @CarCode and State= 0 and used=0";
                    break;
                case "selectCarCode1"://查询车号表
                    sql = "select CarCode,Driver,Tare from D_CarCode where CarCode=@CarCode and Used=1";
                    break;
                case "yucun"://车号表预存皮重
                    sql = "insert into D_Saver (ID,Code,Card,CarCode,Type,Item,Specs,Place,Send,Accept,Carry,Model,Cube,InhereWei,DifferWei," +
                        "Driver,Spare,Gross,G_Time,Tare,T_Time,Net,EndNet,N_Time,Price,[Money],DeductWei," +
                        "DeductRate,Impurity,ImpurityRate,G_Oper,State,Plan_Code,Cubety,Accepter) values(@ID,@Code,@Card,@CarCode,@Type,@Item," +
                        "@Specs,@Place,@Send,@Accept,@Carry,@Model,@Cube,@InhereWei,@DifferWei,@Driver,@Spare,@Gross,@G_Time,@Tare," +
                        "@T_Time,@Net,@EndNet,@N_Time,@Price,@Money,@DeductWei,@DeductRate," +
                        "@Impurity,@ImpurityRate,@G_Oper,@State,@Plan_Code,@Cubety,@Accepter)";
                    break;
                case "SelectCard"://查询卡号
                    sql = "select Type,Item,Specs,Place,CarCode,Tare,Send,Accept,Carry,Model,Driver,Spare from V_D_Card_Temp where Card=@Card and State=1";
                    break;
                case "selectName"://查询编号，货物名称
                    sql = "select Code,Name from V_D_Base where  Flag=@flag and Rem=@flag1 or Name=@flag1 or Code=@flag1";
                    break;
                case "IdCard"://刷卡预存皮重
                    sql = "insert into D_Saver (ID,Code,Card,CarCode,Type,Item,Specs,Place,Send,Accept,Carry,Model,Cube,InhereWei,DifferWei," +
                        "Driver,Spare,Gross,G_Time,Tare,T_Time,Net,EndNet,N_Time,Price,[Money],DeductWei," +
                        "DeductRate,Impurity,ImpurityRate,G_Oper,State,Plan_Code,Cubety,Accepter) values(@ID,@Code,@Card,@CarCode,@Type,@Item," +
                        "@Specs,@Place,@Send,@Accept,@Carry,@Model,@Cube,@InhereWei,@DifferWei,@Driver,@Spare,@Gross,@G_Time,@Tare," +
                        "@T_Time,@Net,@EndNet,@N_Time,@Price,@Money,@DeductWei,@DeductRate," +
                        "@Impurity,@ImpurityRate,@G_Oper,@State,@Plan_Code,@Cubety,@Accepter)";
                    break;
                case "SelectState"://查询当前卡号启用状态
                    sql = "select State from V_D_Card_Temp where Card=@Card";
                    break;
                case "WeightLog":
                    sql = "insert into DL_Weight(ID,Code,Weight,Datetime,OperCode,TableCode,IP,Image1,Image2,Image3,Image4,Curve)" +
                        "values(@ID,@Code,@Weight,@Time,@OperCode,@TableNum,@Ip,@Image1,@Image2,@Image3,@Image4,@Curve)";
                    break;
                case "insertM":
                    sql = "insert into D_Saver_Image(Code,G_Image1,G_Image2,G_Image3,G_Image4)values(@Code,@G_Image1,@G_Image2,@G_Image3,@G_Image4)";
                    break;
                case "insertP":
                    sql = "insert into D_Saver_Image(Code,T_Image1,T_Image2,T_Image3,T_Image4)values(@Code,@T_Image1,@T_Image2,@T_Image3,@T_Image4)";
                    break;
                case "updateM":
                    sql = "update D_Saver_Image set G_Image1=@G_Image1,G_Image2=@G_Image2,G_Image3=@G_Image3,G_Image4=@G_Image4 where Code=@Code";
                    break;
                case "updateP":
                    sql = "update D_Saver_Image set T_Image1=@T_Image1,T_Image2=@T_Image2,T_Image3=@T_Image3,T_Image4=@T_Image4 where Code=@Code";
                    break;
                case "retvideo":
                    sql = "select VIDEO_Brightness,VIDEO_Contrast,VIDEO_Hue,VIDEO_Saturation,VIDEO_Suality from D_Video where VIDEO_name=@VIDEO_name and VIDEO_table=@VIDEO_table";
                    break;
                case "SelectCode":
                    sql = "select G_Image1,G_Image2,G_Image3,G_Image4,T_Image1,T_Image2,T_Image3,T_Image4,G_Curve,T_Curve from D_Saver_Image where Code=@Code";
                    break;
                case "G_Curve":
                    sql = "update D_Saver_Image set G_Curve =@Curve where Code = @Code";
                    break;
                case "T_Curve":
                    sql = "update D_Saver_Image set T_Curve = @Curve where Code = @Code";
                    break;
                case "one":
                    sql = "insert into D_Saver (ID,Code,Item,CarCode,Card,Specs,Place,Accept,Send,Carry,Model,Driver,Spare,Type,G_Oper,Gross,G_Time,Cubety) values(@ID,@Code,@Item,@CarCode,@Card,@Specs,@Place,@Accept,@Send,@Carry,@Model,@Driver,@Spare,@Type,@G_Oper,@Gross,@G_Time,@Cubety)";
                    break;
                case "two":
                    sql = "update D_Saver set G_Time=@G_Time,Gross=@Gross,T_Oper=@T_Oper,T_Time=@T_Time,Tare=@Tare,Net=@Net,N_Time=@N_Time, State=@State,Item=@Item,Type=@Type,Accept=@Accept,Send=@Send,Carry=@Carry,Place=@Place,CarCode=@CarCode,Specs=@Specs,Cubety=@Cubety where Code=@Code and Used=0";
                    break;
                case "selectByFlag"://查询物料编号，名称
                    sql = "select Code,Name from V_D_Base where  Flag=@flag and PortId2=@PortId2 and Rem=@flag1 or Name=@flag1 or Code=@flag1";
                    break;
            }
            return sql;
        }
    }
}
