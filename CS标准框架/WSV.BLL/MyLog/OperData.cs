using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.Model;
//using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WSV.BLL.MyLog
{
    public class OperData
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string AddData(WSV.Model.Weight.WeightModel Weight)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.Int,4, BLL.PublicFun.PublicFun.MaxId("D_Saver")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Weight.Code),
                db.MakeInParam("@CarCode", SqlDbType.VarChar,50, Weight.Txt.CarCode),
                db.MakeInParam("@Item", SqlDbType.VarChar,50, Weight.Txt.Item),
                db.MakeInParam("@Specs", SqlDbType.VarChar,50, Weight.Txt.Specs),
                db.MakeInParam("@Place", SqlDbType.VarChar,50, Weight.Txt.Place),
                db.MakeInParam("@Send", SqlDbType.VarChar,50, Weight.Txt.Send),
                db.MakeInParam("@Accept", SqlDbType.VarChar,50, Weight.Txt.Accept),
                db.MakeInParam("@Carry", SqlDbType.VarChar,50, Weight.Txt.Carry),
                db.MakeInParam("@Model", SqlDbType.VarChar,50, Weight.Txt.Model),
                db.MakeInParam("@Driver", SqlDbType.VarChar,50, Weight.Txt.Driver),
                db.MakeInParam("@Spare", SqlDbType.VarChar,50, Weight.Txt.Spare),
                db.MakeInParam("@Type", SqlDbType.VarChar,50, Weight.Txt.Type),
                db.MakeInParam("@Card", SqlDbType.VarChar,50, Weight.Txt.Card),
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Weight.Txt.Plan_Code),
                db.MakeInParam("@G_Table", SqlDbType.VarChar,50, Weight.StateFun.G_Table),
                db.MakeInParam("@T_Table", SqlDbType.VarChar,50, Weight.StateFun.T_Table),
                db.MakeInParam("@G_Oper", SqlDbType.VarChar,50, Weight.StateFun.G_Oper),
                db.MakeInParam("@T_Oper", SqlDbType.VarChar,50, Weight.StateFun.T_Oper),
                db.MakeInParam("@Gross", SqlDbType.Decimal, 10, Weight.Float.Gross),
                db.MakeInParam("@Tare", SqlDbType.Decimal, 10, Weight.Float.Tare),
                db.MakeInParam("@Net", SqlDbType.Decimal, 10, Weight.Float.Net),
                db.MakeInParam("@EndNet", SqlDbType.Decimal, 10, Weight.Float.EndNet),
                db.MakeInParam("@Impurity", SqlDbType.Decimal, 10, Weight.Float.Impurity),
                db.MakeInParam("@ImpurityRate", SqlDbType.Decimal, 10, Weight.Float.ImpurityRate),
                db.MakeInParam("@DeductWei", SqlDbType.Decimal, 10, Weight.Float.DeductWei),
                db.MakeInParam("@DeductRate", SqlDbType.Decimal, 10, Weight.Float.DeductRate),
                db.MakeInParam("@Cube", SqlDbType.Decimal, 10, Weight.Float.Cube),
                db.MakeInParam("@Cubety", SqlDbType.Decimal, 10, Weight.Float.Cubety),
                db.MakeInParam("@InhereWei", SqlDbType.Decimal, 10, Weight.Float.InhereWei),
                db.MakeInParam("@DifferWei", SqlDbType.Decimal, 10, Weight.Float.DifferWei),
                db.MakeInParam("@Price", SqlDbType.Decimal, 10, Weight.Float.Price),
                db.MakeInParam("@Money", SqlDbType.Decimal, 10, Weight.Float.Money),
                db.MakeInParam("@State", SqlDbType.Decimal, 10, Weight.StateFun.State),
                db.MakeInParam("@G_Time", SqlDbType.VarChar, 50, Weight.StateFun.G_Time),
                db.MakeInParam("@T_Time", SqlDbType.VarChar, 50, Weight.StateFun.T_Time),
                db.MakeInParam("@N_Time", SqlDbType.VarChar, 50, Weight.StateFun.N_Time),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "AddData", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        public static string AddMaintenance(Model.MyLog.DL_Maintenance DL_MainItem)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.Float,50, DL_MainItem.ID),
                db.MakeInParam("@TableNum", SqlDbType.VarChar,50,DL_MainItem.TableNum),
                db.MakeInParam("@SaverCode", SqlDbType.VarChar,50, DL_MainItem.SaverCode), 
                db.MakeInParam("@WorkCode", SqlDbType.VarChar,50, DL_MainItem.WorkCode),                
                db.MakeInParam("@OperCode", SqlDbType.VarChar,50, DL_MainItem.OperCode),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "AddMaintenance", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 修改主数据
        /// </summary>
        /// <param name="Weight">model</param>
        /// <returns></returns>
        public static string UpdateData(WSV.Model.Weight.WeightModel Weight)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@CarCode", SqlDbType.VarChar,50, Weight.Txt.CarCode),
                db.MakeInParam("@Item", SqlDbType.VarChar,50, Weight.Txt.Item),
                db.MakeInParam("@Specs", SqlDbType.VarChar,50, Weight.Txt.Specs),
                db.MakeInParam("@Place", SqlDbType.VarChar,50, Weight.Txt.Place),
                db.MakeInParam("@Send", SqlDbType.VarChar,50, Weight.Txt.Send),
                db.MakeInParam("@Accept", SqlDbType.VarChar,50, Weight.Txt.Accept),
                db.MakeInParam("@Carry", SqlDbType.VarChar,50, Weight.Txt.Carry),
                db.MakeInParam("@Model", SqlDbType.VarChar,50, Weight.Txt.Model),
                db.MakeInParam("@Driver", SqlDbType.VarChar,50, Weight.Txt.Driver),
                db.MakeInParam("@Spare", SqlDbType.VarChar,50, Weight.Txt.Spare),
                db.MakeInParam("@Type", SqlDbType.VarChar,50, Weight.Txt.Type),
                db.MakeInParam("@Card", SqlDbType.VarChar,50, Weight.Txt.Card),
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Weight.Txt.Plan_Code),
                db.MakeInParam("@G_Table", SqlDbType.VarChar,50, Weight.StateFun.G_Table),
                db.MakeInParam("@T_Table", SqlDbType.VarChar,50, Weight.StateFun.T_Table),
                db.MakeInParam("@G_Oper", SqlDbType.VarChar,50, Weight.StateFun.G_Oper),
                db.MakeInParam("@T_Oper", SqlDbType.VarChar,50, Weight.StateFun.T_Oper),
                db.MakeInParam("@Gross", SqlDbType.Decimal, 10, Weight.Float.Gross),
                db.MakeInParam("@Tare", SqlDbType.Decimal, 10, Weight.Float.Tare),
                db.MakeInParam("@Net", SqlDbType.Decimal, 10, Weight.Float.Net),
                db.MakeInParam("@EndNet", SqlDbType.Decimal, 10, Weight.Float.EndNet),
                db.MakeInParam("@Impurity", SqlDbType.Decimal, 10, Weight.Float.Impurity),
                db.MakeInParam("@ImpurityRate", SqlDbType.Decimal, 10, Weight.Float.ImpurityRate),
                db.MakeInParam("@DeductWei", SqlDbType.Decimal, 10, Weight.Float.DeductWei),
                db.MakeInParam("@DeductRate", SqlDbType.Decimal, 10, Weight.Float.DeductRate),
                db.MakeInParam("@Cube", SqlDbType.Decimal, 10, Weight.Float.Cube),
                db.MakeInParam("@Cubety", SqlDbType.Decimal, 10, Weight.Float.Cubety),
                db.MakeInParam("@InhereWei", SqlDbType.Decimal, 10, Weight.Float.InhereWei),
                db.MakeInParam("@DifferWei", SqlDbType.Decimal, 10, Weight.Float.DifferWei),
                db.MakeInParam("@Price", SqlDbType.Decimal, 10, Weight.Float.Price),
                db.MakeInParam("@Money", SqlDbType.Decimal, 10, Weight.Float.Money),
                db.MakeInParam("@State", SqlDbType.Bit, 10, Weight.StateFun.State),
                //db.MakeInParam("@G_Time", SqlDbType.VarChar, 50, Weight.StateFun.G_Time),
                //db.MakeInParam("@T_Time", SqlDbType.VarChar, 50, Weight.StateFun.T_Time),
                //db.MakeInParam("@N_Time", SqlDbType.VarChar, 50, Weight.StateFun.N_Time),
                 db.MakeInParam("@Updata_Time", SqlDbType.VarChar, 50, Weight.StateFun.Updata_Time),
                 db.MakeInParam("@Updata_Oper", SqlDbType.VarChar, 50, Weight.StateFun.Updata_Oper),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Weight.Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "UpdateData", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        //public static string AlterMaintenance(long ID, string SaverCode, string OperCode)
        //{
        //    DataBase db = new DataBase();
        //    DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
        //    bool bSuc = false;
        //    int nEffectRows = 0;
        //    SqlParameter[] prams ={
        //        db.MakeInParam("@ID", SqlDbType.Float,50, ID),
        //        db.MakeInParam("@SaverCode", SqlDbType.VarChar,50, SaverCode),
        //        db.MakeInParam("@WorkCode", SqlDbType.Decimal,8, 2),                
        //        db.MakeInParam("@DT", SqlDbType.VarChar,50, DateTime.Now.ToString()),
        //        db.MakeInParam("@OperCode", SqlDbType.VarChar,50, OperCode),
        //    };
        //    try
        //    {
        //        bSuc = db.TransactSql(visitor, "AlterMaintenance", prams, out nEffectRows);
        //    }
        //    catch (Exception ex) { throw new Exception(ex.Message); }
        //    finally
        //    {
        //        db.Dispose();
        //    }
        //    if (bSuc && nEffectRows > 0)
        //        return "0101";
        //    else
        //        return "0";
        //}
        /// <summary>
        /// 添加操作日志数据
        /// </summary>
        /// <param name="Weight">model</param>
        /// <returns></returns>
        public static string Modify(WSV.Model.Weight.WeightModel Weight, long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,60, ID),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Weight.Code),
                db.MakeInParam("@CarCode", SqlDbType.VarChar,50, Weight.Txt.CarCode),
                db.MakeInParam("@Item", SqlDbType.VarChar,50, Weight.Txt.Item),
                db.MakeInParam("@Specs", SqlDbType.VarChar,50, Weight.Txt.Specs),
                db.MakeInParam("@Place", SqlDbType.VarChar,50, Weight.Txt.Place),
                db.MakeInParam("@Send", SqlDbType.VarChar,50, Weight.Txt.Send),
                db.MakeInParam("@Accept", SqlDbType.VarChar,50, Weight.Txt.Accept),
                db.MakeInParam("@Carry", SqlDbType.VarChar,50, Weight.Txt.Carry),
                db.MakeInParam("@Model", SqlDbType.VarChar,50, Weight.Txt.Model),
                db.MakeInParam("@Driver", SqlDbType.VarChar,50, Weight.Txt.Driver),
                db.MakeInParam("@Spare", SqlDbType.VarChar,50, Weight.Txt.Spare),
                db.MakeInParam("@Type", SqlDbType.VarChar,50, Weight.Txt.Type),
                db.MakeInParam("@Card", SqlDbType.VarChar,50, Weight.Txt.Card),
                db.MakeInParam("@Plan_Code", SqlDbType.VarChar,50, Weight.Txt.Plan_Code),
                db.MakeInParam("@G_Table", SqlDbType.VarChar,50, Weight.StateFun.G_Table),
                db.MakeInParam("@T_Table", SqlDbType.VarChar,50, Weight.StateFun.T_Table),
                db.MakeInParam("@G_Oper", SqlDbType.VarChar,50, Weight.StateFun.G_Oper),
                db.MakeInParam("@T_Oper", SqlDbType.VarChar,50, Weight.StateFun.T_Oper),
                db.MakeInParam("@Gross", SqlDbType.Decimal, 10, Weight.Float.Gross),
                db.MakeInParam("@Tare", SqlDbType.Decimal, 10, Weight.Float.Tare),
                db.MakeInParam("@Net", SqlDbType.Decimal, 10, Weight.Float.Net),
                db.MakeInParam("@EndNet", SqlDbType.Decimal, 10, Weight.Float.EndNet),
                db.MakeInParam("@Impurity", SqlDbType.Decimal, 10, Weight.Float.Impurity),
                db.MakeInParam("@ImpurityRate", SqlDbType.Decimal, 10, Weight.Float.ImpurityRate),
                db.MakeInParam("@DeductWei", SqlDbType.Decimal, 10, Weight.Float.DeductWei),
                db.MakeInParam("@DeductRate", SqlDbType.Decimal, 10, Weight.Float.DeductRate),
                db.MakeInParam("@Cube", SqlDbType.Decimal, 10, Weight.Float.Cube),
                db.MakeInParam("@Cubety", SqlDbType.Decimal, 10, Weight.Float.Cubety),
                db.MakeInParam("@InhereWei", SqlDbType.Decimal, 10, Weight.Float.InhereWei),
                db.MakeInParam("@DifferWei", SqlDbType.Decimal, 10, Weight.Float.DifferWei),
                db.MakeInParam("@Price", SqlDbType.Decimal, 10, Weight.Float.Price),
                db.MakeInParam("@Money", SqlDbType.Decimal, 10, Weight.Float.Money),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Modify", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 读取主表视图数据
        /// </summary>
        /// <param name="Weight">model</param>
        public static void CodeChange(ref WSV.Model.Weight.WeightModel Weight)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            SqlDataReader oddr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Weight.Code),
            };
            try
            {
                db.GetDataReader(visitor, prams, out oddr, "SelectCode");
                if (oddr.Read())
                {
                    Weight.StateFun.Verify = Convert.ToBoolean(oddr["Verify"]);
                    Weight.StateFun.Used = Convert.ToBoolean(oddr["Used"]);
                    Weight.Txt.CarCode = oddr["CarCode"].ToString();
                    Weight.Txt.Item = oddr["Item"].ToString();
                    Weight.Txt.Specs = oddr["Specs"].ToString();
                    Weight.Txt.Place = oddr["Place"].ToString();
                    Weight.Txt.Send = oddr["Send"].ToString();
                    Weight.Txt.Accept = oddr["Accept"].ToString();
                    Weight.Txt.Carry = oddr["Carry"].ToString();
                    Weight.Txt.Model = oddr["Model"].ToString();
                    Weight.Txt.Driver = oddr["Driver"].ToString();
                    Weight.Txt.Spare = oddr["Spare"].ToString();
                    Weight.Txt.Card = oddr["Card"].ToString();
                    Weight.Txt.Type = oddr["Type"].ToString();
                    Weight.Txt.Plan_Code = oddr["Plan_Code"].ToString();
                    Weight.Float.Gross = Convert.ToDecimal(oddr["Gross"]);
                    Weight.Float.Tare = Convert.ToDecimal(oddr["Tare"]);
                    Weight.Float.Net = Convert.ToDecimal(oddr["Net"]);
                    Weight.Float.EndNet = Convert.ToDecimal(oddr["EndNet"]);
                    Weight.Float.Impurity = Convert.ToDecimal(oddr["Impurity"]);
                    Weight.Float.ImpurityRate = Convert.ToDecimal(oddr["ImpurityRate"]);
                    Weight.Float.DeductWei = Convert.ToDecimal(oddr["DeductWei"]);
                    Weight.Float.DeductRate = Convert.ToDecimal(oddr["DeductRate"]);
                    Weight.Float.Cube = Convert.ToDecimal(oddr["Cube"]);
                    Weight.Float.Cubety = Convert.ToDecimal(oddr["Cubety"]);
                    Weight.Float.InhereWei = Convert.ToDecimal(oddr["InhereWei"]);
                    Weight.Float.DifferWei = Convert.ToDecimal(oddr["DifferWei"]);
                    Weight.Float.Price = Convert.ToDecimal(oddr["Price"]);
                    Weight.Float.Money = Convert.ToDecimal(oddr["Money"]);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                oddr.Close();
                db.Dispose();
            }
        }
        /// <summary>
        /// 读取主表数据库数据
        /// </summary>
        /// <param name="Weight">model</param>
        public static void GetDate(ref WSV.Model.Weight.WeightModel Weight)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            SqlDataReader oddr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Weight.Code),
            };
            try
            {
                db.GetDataReader(visitor, prams, out oddr, "SelectByCode");
                if (oddr.Read())
                {
                    Weight.StateFun.Verify = Convert.ToBoolean(oddr["Verify"]);
                    Weight.StateFun.Used = Convert.ToBoolean(oddr["Used"]);
                    Weight.Txt.CarCode = oddr["CarCode"].ToString();
                    Weight.Txt.Item = oddr["Item"].ToString();
                    Weight.Txt.Specs = oddr["Specs"].ToString();
                    Weight.Txt.Place = oddr["Place"].ToString();
                    Weight.Txt.Send = oddr["Send"].ToString();
                    Weight.Txt.Accept = oddr["Accept"].ToString();
                    Weight.Txt.Carry = oddr["Carry"].ToString();
                    Weight.Txt.Model = oddr["Model"].ToString();
                    Weight.Txt.Driver = oddr["Driver"].ToString();
                    Weight.Txt.Spare = oddr["Spare"].ToString();
                    Weight.Txt.Card = oddr["Card"].ToString();
                    Weight.Txt.Plan_Code = oddr["Plan_Code"].ToString();
                    Weight.Txt.Type = oddr["Type"].ToString();
                    Weight.StateFun.G_Oper = oddr["G_Oper"].ToString();
                    Weight.StateFun.T_Oper = oddr["T_Oper"].ToString();
                    Weight.StateFun.G_Table = oddr["G_Table"].ToString();
                    Weight.StateFun.T_Table = oddr["T_Table"].ToString();
                    Weight.Float.Gross = Convert.ToDecimal(oddr["Gross"]);
                    Weight.Float.Tare = Convert.ToDecimal(oddr["Tare"]);
                    Weight.Float.Net = Convert.ToDecimal(oddr["Net"]);
                    Weight.Float.EndNet = Convert.ToDecimal(oddr["EndNet"]);
                    Weight.Float.Impurity = Convert.ToDecimal(oddr["Impurity"]);
                    Weight.Float.ImpurityRate = Convert.ToDecimal(oddr["ImpurityRate"]);
                    Weight.Float.DeductWei = Convert.ToDecimal(oddr["DeductWei"]);
                    Weight.Float.DeductRate = Convert.ToDecimal(oddr["DeductRate"]);
                    Weight.Float.Cube = Convert.ToDecimal(oddr["Cube"]);
                    Weight.Float.InhereWei = Convert.ToDecimal(oddr["InhereWei"]);
                    Weight.Float.DifferWei = Convert.ToDecimal(oddr["DifferWei"]);
                    Weight.Float.Price = Convert.ToDecimal(oddr["Price"]);
                    Weight.Float.Money = Convert.ToDecimal(oddr["Money"]);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                oddr.Close();
                db.Dispose();
            }
        }
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        public static string UpdateCheck(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "OnCheck", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 反审核
        /// </summary>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        public static string UnCheck(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "UnCheck", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 作废
        /// </summary>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        public static string OnUsed(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "OnUsed", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 反作废
        /// </summary>
        /// <param name="Code">编号</param>
        /// <returns></returns>
        public static string UnUsed(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "UnUsed", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 查询类型表
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectType()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelType", "D_Type");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        public static DataSet SelectDBName()
        {
            DataBase db = new DataBase();
            string sql = "select DBName from C_Alias where State = 1";
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql);
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="ID">表ID</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Delete(long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.VarChar,50,ID),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Delete", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string DeleteModify(long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.OperData();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.VarChar,50,ID),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Delete_Modify", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
    }
}
