using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.DAL.Weight;
using WSV.Model.Weight;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WSV.BLL.Weight
{
    public class WeightBLL
    {
        public SqlDataReader oddr = null;
        BLL.PublicFun.IniFile inout = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");

        #region 添加称重类型（采购，出售，调拨）
        /// <summary>
        /// 添加类型
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectType()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WeightDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelectType", "D_Type");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 生成称重要用到的SQL字符串
        /// <summary>
        /// 生成SQL字符串
        /// </summary>
        /// <returns></returns>
        public static string W_Char()
        {
            string field = "";
            DataBase db = new DataBase();
            SqlDataReader oddr = null;
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Flag", SqlDbType.VarChar,50," ")
            };
            db.GetDataReader(visitor, prams, out oddr, "GridViewName");
            while (oddr.Read())
            {
                field += ",[" + oddr["DBName"] + "]";
            }
            if (!string.IsNullOrEmpty(field)) { field = field.Substring(1); }
            return field;
        }
        #endregion

        #region 显示 V_C_Weight 临时数据
        /// <summary>
        /// 显示临时数据
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectALL()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelectALL", "V_D_Saver_Temp");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 显示 D_Operate 数据
        /// <summary>
        /// 数据操作
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <returns></returns>
        public static DataSet Data_Operate(string s_Pr)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Flag", SqlDbType.VarChar,50,s_Pr)
            };
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "D_Operate", "V_D_Base");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 显示 D_Operate 数据重载
        /// <summary>
        /// 数据操作
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <returns></returns>
        public static DataSet Data_Operate(string s_Pr, int PortId2)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Flag", SqlDbType.VarChar,50,s_Pr),
                 db.MakeInParam("@PortId2", SqlDbType.Int,12,PortId2)
            };
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "D_OperateFlag", "V_D_Base");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region D_Operate 添加新数据
        /// <summary>
        /// 添加新数据
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <returns></returns>
        public static string Data_Add(string s_Pr)
        {
            string CodeA = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Flag", SqlDbType.VarChar,50,s_Pr)
            };
            SqlDataReader dr = null;
            try
            {
                db.GetDataReader(visitor, prams, out dr, "D_Add");
                if (dr.Read())
                {
                    CodeA = dr["Code"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return CodeA;
        }
        #endregion

        #region 保存事件
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="retselectflag"></param>
        /// <param name="values"></param>
        public static void Save_Data(string Sql, bool retselectflag, WeightModel values)
        {
            //保存事件
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            if (retselectflag == false)
            {
                if (Sql == "InsertSaverM")
                {
                    SqlParameter[] prams ={
                        db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Saver")),               
                        db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                          db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                        db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                        db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                        db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                        db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                        db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                        db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                        db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry), 
                        db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                        db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                        db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                        db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                        db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                        db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                        db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                          db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                    };
                    try
                    {
                        db.TransactSql(visitor, Sql, prams);
                    }
                    catch (Exception err)
                    {
                        db.Dispose();
                        MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        db.Dispose();
                    }
                }
                else if (Sql == "InsertSaverP")
                {
                    SqlParameter[] prams ={
                         db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Saver")),               
                         db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                          db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                         db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                         db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                         db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                         db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                         db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                         db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                         db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry),              
                         db.MakeInParam("@Tare", SqlDbType.Decimal,50, values.Float.Tare),
                         db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                         db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                         db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                         db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                         db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                         db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                         db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                         db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                         db.MakeInParam("@T_Time",SqlDbType.VarChar,50,values.StateFun.T_Time),
                         db.MakeInParam("@T_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                          db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                    };
                    try
                    {
                        db.TransactSql(visitor, Sql, prams);
                    }
                    catch (Exception err)
                    {
                        db.Dispose();
                        MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        db.Dispose();
                    }
                }
            }
            else if (retselectflag == true)
            {
                if (Sql == "UpdateSaverP")
                {
                    SqlParameter[] prams ={
                         db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                         db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                         db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                         db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                         db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                         db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry),              
                         db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                         db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                         db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                         db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                         db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                         db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                         db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                         db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Tare", SqlDbType.Decimal,50, values.Float.Tare),
                        db.MakeInParam("@T_Time",SqlDbType.VarChar,50,values.StateFun.T_Time),
                        db.MakeInParam("@Net",SqlDbType.Decimal,50,values.Float.Net),
                        db.MakeInParam("@EndNet",SqlDbType.Decimal,50,values.Float.EndNet),
                        db.MakeInParam("@N_Time",SqlDbType.VarChar,50,values.StateFun.N_Time),
                        db.MakeInParam("@Price",SqlDbType.Decimal,50,values.Float.Price),
                        db.MakeInParam("@Money",SqlDbType.Decimal,50,values.Float.Money),
                        db.MakeInParam("@DeductWei",SqlDbType.Decimal,50,values.Float.DeductWei),
                        db.MakeInParam("@DeductRate",SqlDbType.Decimal,50,values.Float.DeductRate),
                        db.MakeInParam("@Impurity",SqlDbType.Decimal,50,values.Float.Impurity),
                        db.MakeInParam("@ImpurityRate",SqlDbType.Decimal,50,values.Float.ImpurityRate),
                        db.MakeInParam("@T_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                          db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@CarCode",SqlDbType.VarChar,50,values.Txt.CarCode),
                        db.MakeInParam("@Code",SqlDbType.VarChar,50,values.Code),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                        //db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code)
                    };
                    try
                    {
                        db.TransactSql(visitor, Sql, prams);
                    }
                    catch (Exception err)
                    {
                        db.Dispose();
                        MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        db.Dispose();
                    }
                }
                else if (Sql == "UpdateSaverM")
                {
                    SqlParameter[] prams ={  
                         db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                         db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                         db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                         db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                         db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                         db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry),              
                         db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                         db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                        db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                         db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                        db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                        db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                         db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                         db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@Net",SqlDbType.Decimal,50,values.Float.Net),
                        db.MakeInParam("@EndNet",SqlDbType.Decimal,50,values.Float.EndNet),
                        db.MakeInParam("@N_Time",SqlDbType.VarChar,50,values.StateFun.N_Time),
                        db.MakeInParam("@Price",SqlDbType.Decimal,50,values.Float.Price),
                        db.MakeInParam("@Money",SqlDbType.Decimal,50,values.Float.Money),
                        db.MakeInParam("@DeductWei",SqlDbType.Decimal,50,values.Float.DeductWei),
                        db.MakeInParam("@DeductRate",SqlDbType.Decimal,50,values.Float.DeductRate),
                        db.MakeInParam("@Impurity",SqlDbType.Decimal,50,values.Float.Impurity),
                        db.MakeInParam("@ImpurityRate",SqlDbType.Decimal,50,values.Float.ImpurityRate),
                        //db.MakeInParam("@T_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                        db.MakeInParam("@CarCode",SqlDbType.VarChar,50,values.Txt.CarCode),
                        db.MakeInParam("@Code",SqlDbType.VarChar,50,values.Code),
                        db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                          db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                    };
                    try
                    {
                        db.TransactSql(visitor, Sql, prams);
                    }
                    catch (Exception err)
                    {
                        db.Dispose();
                        MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        db.Dispose();
                    }
                }
            }
        }
        #endregion

        #region 保存事件重载
        /// <summary>
        /// 保存事件重载
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="values"></param>
        public static void Save_Data(string Sql, WeightModel values)
        {
            //保存事件
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            if (Sql == "yucun")
            {
                SqlParameter[] prams ={
                        db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Saver")),               
                        db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                      db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                        db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                        db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                        db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                        db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                        db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                        db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                        db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                        db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry), 
                        db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                        db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                        db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                        db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                        db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                        db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                        db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@Tare", SqlDbType.Decimal,50, values.Float.Tare),
                        db.MakeInParam("@T_Time",SqlDbType.VarChar,50,values.StateFun.T_Time),
                        db.MakeInParam("@Net",SqlDbType.Decimal,50,values.Float.Net),
                        db.MakeInParam("@EndNet",SqlDbType.Decimal,50,values.Float.EndNet),
                        db.MakeInParam("@N_Time",SqlDbType.VarChar,50,values.StateFun.N_Time),
                        db.MakeInParam("@Price",SqlDbType.Decimal,50,values.Float.Price),
                        db.MakeInParam("@Money",SqlDbType.Decimal,50,values.Float.Money),
                        db.MakeInParam("@DeductWei",SqlDbType.Decimal,50,values.Float.DeductWei),
                        db.MakeInParam("@DeductRate",SqlDbType.Decimal,50,values.Float.DeductRate),
                        db.MakeInParam("@Impurity",SqlDbType.Decimal,50,values.Float.Impurity),
                        db.MakeInParam("@ImpurityRate",SqlDbType.Decimal,50,values.Float.ImpurityRate),
                        db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                      db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@State",SqlDbType.Bit,1,1),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                    };
                try
                {
                    db.TransactSql(visitor, Sql, prams);
                }
                catch (Exception err)
                {
                    db.Dispose();
                    MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.Dispose();
                }
            }
            else if (Sql == "IdCard")
            {
                SqlParameter[] prams ={
                        db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Saver")),               
                        db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                        db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                        db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                        db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                        db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                        db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                        db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                        db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                        db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                        db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry), 
                        db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                        db.MakeInParam("@Cube", SqlDbType.Decimal,50, values.Float.Cube),
                        db.MakeInParam("@Cubety", SqlDbType.Decimal,50, values.Float.Cubety),
                        db.MakeInParam("@InhereWei", SqlDbType.Decimal,50, values.Float.InhereWei),
                        db.MakeInParam("@DifferWei", SqlDbType.Decimal,50, values.Float.DifferWei),
                        db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                        db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@Tare", SqlDbType.Decimal,50, values.Float.Tare),
                        db.MakeInParam("@T_Time",SqlDbType.VarChar,50,values.StateFun.T_Time),
                        db.MakeInParam("@Net",SqlDbType.Decimal,50,values.Float.Net),
                        db.MakeInParam("@EndNet",SqlDbType.Decimal,50,values.Float.EndNet),
                        db.MakeInParam("@N_Time",SqlDbType.VarChar,50,values.StateFun.N_Time),
                        db.MakeInParam("@Price",SqlDbType.Decimal,50,values.Float.Price),
                        db.MakeInParam("@Money",SqlDbType.Decimal,50,values.Float.Money),
                        db.MakeInParam("@DeductWei",SqlDbType.Decimal,50,values.Float.DeductWei),
                        db.MakeInParam("@DeductRate",SqlDbType.Decimal,50,values.Float.DeductRate),
                        db.MakeInParam("@Impurity",SqlDbType.Decimal,50,values.Float.Impurity),
                        db.MakeInParam("@ImpurityRate",SqlDbType.Decimal,50,values.Float.ImpurityRate),
                        db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
                      db.MakeInParam("@Accepter",SqlDbType.VarChar,50,WSV.Model.User.CUser.Code),
                        db.MakeInParam("@State",SqlDbType.Bit,1,1),
                        db.MakeInParam("@Plan_Code",SqlDbType.VarChar,50,values.Txt.Plan_Code)
                    };
                try
                {
                    db.TransactSql(visitor, Sql, prams);
                }
                catch (Exception err)
                {
                    db.Dispose();
                    MessageBox.Show("数据不全！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.Dispose();
                }
            }
        }
        #endregion

        #region 保存图片
        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="retselectflag"></param>
        /// <param name="Values"></param>
        public static void Save_Video(string Sql, bool retselectflag, WeightModel Values)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams = new SqlParameter[5];
            if (!retselectflag)
            {
                if (Sql == "insertM")
                {
                    prams[0] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, Values.Code);
                    if (Values.StateFun.G_Image1 != null)
                        prams[1] = db.MakeInParam("@G_Image1", SqlDbType.Binary, Values.StateFun.G_Image1.Length, Values.StateFun.G_Image1);
                    else
                        prams[1] = db.MakeInParam("@G_Image1", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image2 != null)
                        prams[2] = db.MakeInParam("@G_Image2", SqlDbType.Binary, Values.StateFun.G_Image2.Length, Values.StateFun.G_Image2);
                    else
                        prams[2] = db.MakeInParam("@G_Image2", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image3 != null)
                        prams[3] = db.MakeInParam("@G_Image3", SqlDbType.Binary, Values.StateFun.G_Image3.Length, Values.StateFun.G_Image3);
                    else
                        prams[3] = db.MakeInParam("@G_Image3", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image4 != null)
                        prams[4] = db.MakeInParam("@G_Image4", SqlDbType.Binary, Values.StateFun.G_Image4.Length, Values.StateFun.G_Image4);
                    else
                        prams[4] = db.MakeInParam("@G_Image4", SqlDbType.Binary, 0, DBNull.Value);
                }
                else if (Sql == "insertP")
                {
                    prams[0] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, Values.Code);
                    if (Values.StateFun.T_Image1 != null)
                        prams[1] = db.MakeInParam("@T_Image1", SqlDbType.Binary, Values.StateFun.T_Image1.Length, Values.StateFun.T_Image1);
                    else
                        prams[1] = db.MakeInParam("@T_Image1", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image2 != null)
                        prams[2] = db.MakeInParam("@T_Image2", SqlDbType.Binary, Values.StateFun.T_Image2.Length, Values.StateFun.T_Image2);
                    else
                        prams[2] = db.MakeInParam("@T_Image2", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image3 != null)
                        prams[3] = db.MakeInParam("@T_Image3", SqlDbType.Binary, Values.StateFun.T_Image3.Length, Values.StateFun.T_Image3);
                    else
                        prams[3] = db.MakeInParam("@T_Image3", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image4 != null)
                        prams[4] = db.MakeInParam("@T_Image4", SqlDbType.Binary, Values.StateFun.T_Image4.Length, Values.StateFun.T_Image4);
                    else
                        prams[4] = db.MakeInParam("@T_Image4", SqlDbType.Binary, 0, DBNull.Value);
                }
            }
            else
            {
                if (Sql == "updateM")
                {
                    prams[0] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, Values.Code);
                    if (Values.StateFun.G_Image1 != null)
                        prams[1] = db.MakeInParam("@G_Image1", SqlDbType.Binary, Values.StateFun.G_Image1.Length, Values.StateFun.G_Image1);
                    else
                        prams[1] = db.MakeInParam("@G_Image1", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image2 != null)
                        prams[2] = db.MakeInParam("@G_Image2", SqlDbType.Binary, Values.StateFun.G_Image2.Length, Values.StateFun.G_Image2);
                    else
                        prams[2] = db.MakeInParam("@G_Image2", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image3 != null)
                        prams[3] = db.MakeInParam("@G_Image3", SqlDbType.Binary, Values.StateFun.G_Image3.Length, Values.StateFun.G_Image3);
                    else
                        prams[3] = db.MakeInParam("@G_Image3", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.G_Image4 != null)
                        prams[4] = db.MakeInParam("@G_Image4", SqlDbType.Binary, Values.StateFun.G_Image4.Length, Values.StateFun.G_Image4);
                    else
                        prams[4] = db.MakeInParam("@G_Image4", SqlDbType.Binary, 0, DBNull.Value);
                }
                else if (Sql == "updateP")
                {
                    prams[0] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, Values.Code);
                    if (Values.StateFun.T_Image1 != null)
                        prams[1] = db.MakeInParam("@T_Image1", SqlDbType.Binary, Values.StateFun.T_Image1.Length, Values.StateFun.T_Image1);
                    else
                        prams[1] = db.MakeInParam("@T_Image1", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image2 != null)
                        prams[2] = db.MakeInParam("@T_Image2", SqlDbType.Binary, Values.StateFun.T_Image2.Length, Values.StateFun.T_Image2);
                    else
                        prams[2] = db.MakeInParam("@T_Image2", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image3 != null)
                        prams[3] = db.MakeInParam("@T_Image3", SqlDbType.Binary, Values.StateFun.T_Image3.Length, Values.StateFun.T_Image3);
                    else
                        prams[3] = db.MakeInParam("@T_Image3", SqlDbType.Binary, 0, DBNull.Value);

                    if (Values.StateFun.T_Image4 != null)
                        prams[4] = db.MakeInParam("@T_Image4", SqlDbType.Binary, Values.StateFun.T_Image4.Length, Values.StateFun.T_Image4);
                    else
                        prams[4] = db.MakeInParam("@T_Image4", SqlDbType.Binary, 0, DBNull.Value);
                }
            }
            try
            {
                db.TransactSql(visitor, Sql, prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show("错误：" + err.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                db.Dispose();
            }
        }
        #endregion

        #region 查询车号，并返回与车号相应的视图值
        /// <summary>
        /// 查询车号，并返回当前值
        /// </summary>
        /// <param name="CarCode"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool SelectCarCode(string CarCode, WeightModel Item)
        {
            bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@CarCode",SqlDbType.VarChar ,50,CarCode )
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectCarCode");
                if (getReader.Read())
                {
                    Item.Txt.Type = getReader["Type"].ToString();
                    Item.Code = getReader["Code"].ToString();
                    Item.Txt.Item = getReader["Item"].ToString();
                    Item.Txt.Specs = getReader["Specs"].ToString();
                    Item.Txt.Place = getReader["Place"].ToString();
                    Item.Txt.Accept = getReader["Accept"].ToString();
                    Item.Txt.Send = getReader["Send"].ToString();
                    Item.Txt.Carry = getReader["Carry"].ToString();
                    Item.StateFun.G_Oper = getReader["G_Oper"].ToString();
                    Item.StateFun.T_Oper = getReader["T_Oper"].ToString();
                    Item.StateFun.G_Time = getReader["G_Time"].ToString();
                    Item.StateFun.T_Time = getReader["T_Time"].ToString();
                    Item.Txt.Driver = getReader["Driver"].ToString();
                    Item.Txt.Model = getReader["Model"].ToString();
                    Item.Txt.Spare = getReader["Spare"].ToString();
                    Item.Txt.Plan_Code = getReader["Plan_Code"].ToString();
                    Item.Float.Cube = Convert.ToDecimal(getReader["Cube"].ToString());
                    Item.Float.Cubety = Convert.ToDecimal(getReader["Cubety"].ToString());
                    Item.Float.InhereWei = Convert.ToDecimal(getReader["InhereWei"].ToString());
                    Item.Float.DifferWei = Convert.ToDecimal(getReader["DifferWei"].ToString());
                    Item.Float.Gross = Convert.ToDecimal(getReader["Gross"].ToString());
                    Item.Float.Tare = Convert.ToDecimal(getReader["Tare"].ToString());
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 查询车号，并返回与车号相应的表值
        /// <summary>
        /// 查询车号，并返回当前值
        /// </summary>
        /// <param name="CarCode"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool SelectByCarCode(string CarCode, WeightModel Item)
        {
            bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@CarCode",SqlDbType.VarChar ,50,CarCode )
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectByCarCode");
                if (getReader.Read())
                {
                    Item.Txt.Item = getReader["Item"].ToString();
                    Item.Txt.Specs = getReader["Specs"].ToString();
                    Item.Txt.Place = getReader["Place"].ToString();
                    Item.Txt.Accept = getReader["Accept"].ToString();
                    Item.Txt.Send = getReader["Send"].ToString();
                    Item.Txt.Carry = getReader["Carry"].ToString();
                    Item.Txt.Driver = getReader["Driver"].ToString();
                    Item.Txt.Model = getReader["Model"].ToString();
                    Item.Txt.Spare = getReader["Spare"].ToString();
                    Item.Float.Cubety = Convert.ToDecimal(getReader["Cubety"].ToString());
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 添加 V_C_Weight 字段，按钮，文本框，名称
        /// <summary>
        /// 添加字段，按钮，文本框，名称
        /// </summary>
        /// <param name="item"></param>
        /// <param name="label1"></param>
        /// <param name="textbox1"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        /// DataGridViewColumnHeaderCell
        public string element(string item, Label label1, TextBox textbox1, Button button)
        {
            DataBase db = new DataBase();
            string sql = "select Name from C_Alias where DBName='" + item + "' and State=1";
            db.GetDataReader(out oddr, sql);

            if (oddr.Read())
            {
                label1.Text = oddr["Name"].ToString();
            }
            else
            {
                label1.Visible = false;
                textbox1.Visible = false;
                button.Visible = false;
            }
            oddr.Close();
            return sql;
        }
        public string element(string item, Label label1, TextBox textbox1, Label label2)
        {
            DataBase db = new DataBase();
            string sql = "select Name from C_Alias where DBName='" + item + "' and State=1";
            db.GetDataReader(out oddr, sql);

            if (oddr.Read())
            {
                label1.Text = oddr["Name"].ToString();
            }
            else
            {
                label1.Visible = false;
                textbox1.Visible = false;
                label2.Visible = false;
            }
            oddr.Close();
            return sql;
        }
        public string element(string item, Label label1, TextBox textbox1, PictureBox PictureBox1)
        {
            DataBase db = new DataBase();
            string sql = "select Name from C_Alias where DBName='" + item + "' and State=1";
            db.GetDataReader(out oddr, sql);

            if (oddr.Read())
            {
                label1.Text = oddr["Name"].ToString();
            }
            else
            {
                label1.Visible = false;
                textbox1.Visible = false;
                PictureBox1.Visible = false;
            }
            oddr.Close();
            return sql;
        }
        #endregion

        #region 添加 V_C_Weight 字段，按钮，文本框，名称重载1
        /// <summary>
        /// 添加字段，按钮，文本框，名称重载
        /// </summary>
        /// <param name="item"></param>
        /// <param name="label1"></param>
        /// <param name="textbox1"></param>
        /// <param name="button"></param>
        public string element(string item, Label label1, TextBox textbox1)
        {
            DataBase db = new DataBase();
            string sql = "select Name from C_Alias where DBName='" + item + "' and State = 1";
            db.GetDataReader(out oddr, sql);
            if (oddr.Read())
            {
                label1.Text = oddr["Name"].ToString();
            }
            else
            {
                label1.Visible = false;
                textbox1.Visible = false;
            }
            oddr.Close();
            return sql;
        }
        #endregion

        #region 添加 D_Operate 数据库标题文本
        /// <summary>
        /// 添加数据库标题文本
        /// </summary>
        /// <param name="item"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public string element(string item, DataGridViewTextBoxColumn header)
        {
            DataBase db = new DataBase();
            string sql = "select Name from C_Alias where RuleName='" + item + "' and State = 1";
            db.GetDataReader(out oddr, sql);

            if (oddr.Read())
            {
                header.HeaderText = oddr["Name"].ToString();
            }
            else
            {
                header.Visible = false;
            }
            oddr.Close();
            return sql;
        }
        #endregion

        #region 添加 V_C_Weight 数据库标题文本
        /// <summary>
        /// 添加数据库标题文本
        /// </summary>
        /// <param name="item"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public string ColElement(string HeaderName)
        {
            DataBase db = new DataBase();
            string Ret = "";
            string sql = "select Name from C_Alias where RuleName='" + HeaderName + "' and State = 1";
            db.GetDataReader(out oddr, sql);

            if (oddr.Read())
            {
                Ret = oddr["Name"].ToString();
            }
            oddr.Close();
            return Ret;
        }
        #endregion

        #region 获得当前称重序号
        /// <summary>
        /// 获得当前称重序号
        /// </summary>
        /// <returns></returns>
        public string CodeFun()
        {
            if (string.IsNullOrEmpty(Model.User.LUser.TableNum))
            {
                return "";
            }
            string s_CodeRule = inout.IniReadValue("DataFormat", "CodeRule");
            string _Code;
            string s_TabNnm = Model.User.LUser.TableNum;
            int _Len = 14;
            if (s_CodeRule == "1")
            {
                string s_D = DateTime.Now.ToString("yyyyMM");
                s_TabNnm += s_D;
            }
            else if (s_CodeRule == "2")
            {
                string s_D = DateTime.Now.ToString("yyyyMMdd");
                s_TabNnm += s_D;
            }
            int _TableLen = s_TabNnm.Length;
            _Code = MaxCode("D_Saver", s_TabNnm);
            if (string.IsNullOrEmpty(_Code))
            {
                _Code = "1";
                _Code = _Code.PadLeft(_Len - _TableLen, '0');
            }
            else
            {
                string s_Max = _Code.Substring(_TableLen, _Len - _TableLen);
                long l_Max = long.Parse(s_Max) + 1;
                _Code = l_Max.ToString().PadLeft(_Len - _TableLen, '0');
            }
            _Code = s_TabNnm + _Code;
            return _Code;
        }
        #endregion

        #region 查询最大序号
        /// <summary>
        /// 查询最大序号
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Table"></param>
        /// <returns></returns>
        public static string MaxCode(string TableName, string Table)
        {
            DataBase db = new DataBase();
            string _MaxCode = "";
            SqlDataReader dr = null;
            string sql = "select max(Code) as Code from " + TableName + " where Code like '" + Table + "%'";
            db.GetDataReader(out dr, sql);
            if (dr.Read())
            {
                _MaxCode = dr["Code"].ToString();
            }
            return _MaxCode;
        }
        #endregion

        #region 显示图片重载
        public static string MaxCode()
        {

            DataBase db = new DataBase();
            string _MaxCode = "";
            SqlDataReader dr = null;
            string sql = "select max(Code) as Code from V_D_Saver_Temp";
            db.GetDataReader(out dr, sql);
            if (dr.Read())
            {
                _MaxCode = dr["Code"].ToString();
            }
            db.Dispose();
            return _MaxCode;
        }
        public static string SelectWeight(string MaxCode)
        {
            DataBase db = new DataBase();
            SqlDataReader dr = null;
            string flag = "";
            string sql = "select Tare,Gross from V_D_Saver_Temp where Code=" + MaxCode;
            db.GetDataReader(out dr, sql);
            if (dr.Read())
            {
                //string et = dr["Tare"].ToString();
                if (Convert.ToDecimal(dr["Tare"].ToString()) > 0)
                {
                    flag = "T";
                }
                else if (Convert.ToDecimal(dr["Gross"].ToString()) > 0)
                {
                    flag = "G";
                }
            }
            db.Dispose();
            return flag;
        }
        public static string ShowImage(WeightModel values)
        {
            DataBase db = new DataBase();
            SqlDataReader dr = null;
            string _MaxCode = MaxCode();
            string flag = SelectWeight(_MaxCode);
            string sql = "select G_Image1,G_Image2,G_Image3,G_Image4,T_Image1,T_Image2,T_Image3,T_Image4 from D_Saver_Image where Code=" + _MaxCode;
            db.GetDataReader(out dr, sql);
            try
            {
                if (dr.Read())
                {
                    if (flag == "G")
                    {
                        if (dr["G_Image1"] != System.DBNull.Value)
                            values.StateFun.G_Image1 = (byte[])dr["G_Image1"];
                        if (dr["G_Image2"] != System.DBNull.Value)
                            values.StateFun.G_Image2 = (byte[])dr["G_Image2"];
                        if (dr["G_Image3"] != System.DBNull.Value)
                            values.StateFun.G_Image3 = (byte[])dr["G_Image3"];
                        if (dr["G_Image4"] != System.DBNull.Value)
                            values.StateFun.G_Image4 = (byte[])dr["G_Image4"];
                    }
                    else if (flag == "T")
                    {
                        if (dr["T_Image1"] != System.DBNull.Value)
                            values.StateFun.T_Image1 = (byte[])dr["T_Image1"];
                        if (dr["T_Image2"] != System.DBNull.Value)
                            values.StateFun.T_Image2 = (byte[])dr["T_Image2"];
                        if (dr["T_Image3"] != System.DBNull.Value)
                            values.StateFun.T_Image3 = (byte[])dr["T_Image3"];
                        if (dr["T_Image4"] != System.DBNull.Value)
                            values.StateFun.T_Image4 = (byte[])dr["T_Image4"];
                    }
                }
            }
            catch (Exception err)
            {
                db.Dispose();
                return null;
                MessageBox.Show("错误：没有图片！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.Dispose();
            return flag;
        }
        #endregion

        #region  刷新时是否保留字段
        /// <summary>
        /// 刷新时是否保留字段
        /// </summary>
        /// <param name="S_Pr"></param>
        /// <returns></returns>
        public bool retretainflag(string S_Pr)   //得到是否保留字段
        {

            bool retvalue = false;
            SqlDataReader getReader = null;
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            DataBase db = new DataBase();
            SqlParameter[] prams ={
                db.MakeInParam ("@name",SqlDbType.VarChar,50,S_Pr.Substring(4))
            };
            DataSet ds = new DataSet();
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "Retain");
                if (getReader.Read())
                {
                    if (getReader[0].ToString() == "True")
                        retvalue = true;
                    else if (getReader[0].ToString() == "False")
                        retvalue = false;
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                throw err;
                return false;
            }
            finally
            {
                if (getReader != null) getReader.Close();
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 添加 D_Operate 标题栏名称
        /// <summary>
        /// 添加 D_Operate 标题栏名称
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <returns></returns>
        public static string Add_Name(string s_Pr)
        {
            string NameA = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Flag", SqlDbType.VarChar,50,s_Pr)
            };
            SqlDataReader dr = null;
            try
            {
                db.GetDataReader(visitor, prams, out dr, "Add_Name");
                if (dr.Read())
                {
                    NameA = dr["Name"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return NameA;
        }
        #endregion

        #region  添加数据时模糊查询
        /// <summary>
        /// 添加数据时模糊查询
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <param name="s_pr1"></param>
        /// <returns></returns>
        public static DataSet SelectData(string s_Pr, string s_pr1)
        {
            DataBase db = new DataBase();
            string sql = "select Code,Name from V_D_Base where  Flag='" + s_Pr + "' and Rem+Name+Code like '%" + s_pr1 + "%'";
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
        #endregion

        #region  添加数据时模糊查询
        /// <summary>
        /// 添加数据时模糊查询
        /// </summary>
        /// <param name="s_Pr"></param>
        /// <param name="s_pr1"></param>
        /// <returns></returns>
        public static DataSet SelectData(string s_Pr, string s_pr1, int PortId2)
        {
            DataBase db = new DataBase();
            string sql = "select Code,Name from V_D_Base where  Flag='" + s_Pr + "' and PortId2='" + PortId2 + "' and Rem+Name+Code like '%" + s_pr1 + "%'";
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
        #endregion

        #region 称重界面文本框模糊查询
        /// <summary>
        /// 称重界面文本框模糊查询
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="flag1"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool SelectName(string flag, string flag1, WeightModel Item)
        {
            bool retvalue = true;
            if (flag1 == "")
            {
                return false;
            }
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@flag",SqlDbType.VarChar ,50,flag ),
                db.MakeInParam("@flag1",SqlDbType.VarChar,50,flag1)
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectName");
                if (getReader.Read())
                {
                    Item.Txt.IdCard = getReader["Code"].ToString();
                    Item.Txt.Name = getReader["Name"].ToString();
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 称重界面文本框模糊查询
        /// <summary>
        /// 称重界面文本框模糊查询
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="flag1"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool selectByFlag(string flag, string flag1,int PortId2, WeightModel Item)
        {
            bool retvalue = true;
            if (flag1 == "")
            {
                return false;
            }
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@flag",SqlDbType.VarChar ,50,flag ),
                db.MakeInParam("@flag1",SqlDbType.VarChar,50,flag1),
                db.MakeInParam("@PortId2",SqlDbType.Int,50,PortId2)
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectByFlag");
                if (getReader.Read())
                {
                    Item.Txt.IdCard = getReader["Code"].ToString();
                    Item.Txt.Name = getReader["Name"].ToString();
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 查询车号表，是否保存当前车号
        /// <summary>
        /// 查询车号表，是否保存当前车号
        /// </summary>
        /// <param name="CarCode"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool SelectCarCode1(string CarCode, WeightModel Item)
        {
            bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam ("@CarCode",SqlDbType.VarChar ,50,CarCode )
            };

            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "selectCarCode1");
                if (getReader.Read())
                {
                    Item.Txt.CarCode = getReader["CarCode"].ToString();
                    Item.Txt.Driver = getReader["Driver"].ToString();
                    Item.Float.Tare = Convert.ToDecimal(getReader["Tare"].ToString());
                }
                else
                {
                    retvalue = false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 查询当前卡号
        /// <summary>
        /// 查询当前卡号
        /// </summary>
        /// <param name="Card"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        public static bool SelectCard(string Card, WeightModel Item)
        {
            bool retvalues = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WeightDAL();
            SqlParameter[] prams ={
                 db.MakeInParam("@Card",SqlDbType.VarChar,50,Card)
            };
            SqlDataReader getread = null;
            db.GetDataReader(visitor, prams, out getread, "SelectCard");
            try
            {
                if (getread.Read())
                {
                    Item.Txt.Type = getread["Type"].ToString();
                    Item.Txt.Item = getread["Item"].ToString();
                    Item.Txt.Specs = getread["Specs"].ToString();
                    Item.Txt.Place = getread["Place"].ToString();
                    Item.Txt.Send = getread["Send"].ToString();
                    Item.Txt.Accept = getread["Accept"].ToString();
                    Item.Txt.Carry = getread["Carry"].ToString();
                    Item.Txt.Model = getread["Model"].ToString();
                    Item.Txt.Driver = getread["Driver"].ToString();
                    Item.Txt.Spare = getread["Spare"].ToString();
                    Item.Txt.CarCode = getread["CarCode"].ToString();
                    Item.Float.Tare = Convert.ToDecimal(getread["Tare"].ToString());
                }
                else
                {
                    return retvalues = false;
                }
                getread.Close();
            }
            catch (Exception e)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalues;
        }
        #endregion

        #region 查询卡号当前状态
        /// <summary>
        /// 查询卡号当前状态
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool SelectState(string a)
        {
            bool retvalue;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Card",SqlDbType.VarChar,50,a)
            };
            SqlDataReader getreader = null;
            db.GetDataReader(visitor, prams, out getreader, "SelectState");
            try
            {
                if (getreader.Read())
                {
                    retvalue = Convert.ToBoolean(getreader["State"]);
                }
                else
                {
                    return retvalue = false;
                }
                getreader.Close();
            }
            catch (Exception e)
            {
                db.Dispose();
                MessageBox.Show("没有此卡号！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion

        #region 过磅日志
        /// <summary>
        /// 过磅日志
        /// </summary>
        /// <param name="values">命名空间</param>
        /// <param name="Weight">重量</param>
        /// <param name="Time">过磅时间</param>
        public void WeightLog(WeightModel values, float Weight, string Time)
        {
            bool Enable = bool.Parse(inout.IniReadValue("IdCard", "Enable"));
            string Ip = WSV.Model.User.LUser.Ip;
            string TableNum = WSV.Model.User.LUser.TableNum;
            long OperCode = WSV.Model.User.LUser.Id;
            string Code = WeightLog();
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams = new SqlParameter[12];
            prams[0] = db.MakeInParam("@ID", SqlDbType.BigInt, 50, values.ID);
            prams[1] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, Code);
            prams[2] = db.MakeInParam("@OperCode", SqlDbType.VarChar, 50, OperCode);
            prams[3] = db.MakeInParam("@Weight", SqlDbType.VarChar, 50, Weight);
            prams[4] = db.MakeInParam("@Time", SqlDbType.VarChar, 50, Time);
            prams[5] = db.MakeInParam("@Ip", SqlDbType.VarChar, 50, Ip);
            prams[6] = db.MakeInParam("@TableNum", SqlDbType.VarChar, 50, TableNum);
            if (values.StateFun.Image1 != null)
                prams[7] = db.MakeInParam("@Image1", SqlDbType.Binary, values.StateFun.Image1.Length, values.StateFun.Image1);
            else
                prams[7] = db.MakeInParam("@Image1", SqlDbType.Binary, 0, DBNull.Value);
            if (values.StateFun.Image2 != null)
                prams[8] = db.MakeInParam("@Image2", SqlDbType.Binary, values.StateFun.Image2.Length, values.StateFun.Image2);
            else
                prams[8] = db.MakeInParam("@Image2", SqlDbType.Binary, 0, DBNull.Value);
            if (values.StateFun.Image3 != null)
                prams[9] = db.MakeInParam("@Image3", SqlDbType.Binary, values.StateFun.Image3.Length, values.StateFun.Image3);
            else
                prams[9] = db.MakeInParam("@Image3", SqlDbType.Binary, 0, DBNull.Value);
            if (values.StateFun.Image4 != null)
                prams[10] = db.MakeInParam("@Image4", SqlDbType.Binary, values.StateFun.Image4.Length, values.StateFun.Image4);
            else
                prams[10] = db.MakeInParam("@Image4", SqlDbType.Binary, 0, DBNull.Value);
            if (values.StateFun.Curve != null)
                prams[11] = db.MakeInParam("@Curve", SqlDbType.Binary, values.StateFun.Curve.Length, values.StateFun.Curve);
            else
                prams[11] = db.MakeInParam("@Curve", SqlDbType.Binary, 0, DBNull.Value);
            try
            {
                db.TransactSql(visitor, "WeightLog", prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show(err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                db.Dispose();
            }
        }
        #endregion

        #region 过磅记录序号
        /// <summary>
        /// 过磅记录序号
        /// </summary>
        /// <returns></returns>
        public string WeightLog()
        {
            string _Code;
            string s_D = DateTime.Now.ToString("yyyyMMdd");
            _Code = MaxCode("DL_Weight", s_D);
            if (string.IsNullOrEmpty(_Code))
            {
                _Code = "1";
                _Code = _Code.PadLeft(4, '0');
            }
            else
            {
                string s_Max = _Code.Substring(8, 4);
                long l_Max = long.Parse(s_Max) + 1;
                _Code = l_Max.ToString().PadLeft(4, '0');
            }
            _Code = s_D + _Code;
            return _Code;

        }
        #endregion

        #region 设置视频
        /// <summary>
        /// 设置视频
        /// </summary>
        /// <param name="card"></param>
        /// <param name="table"></param>
        /// <param name="Values"></param>
        public static void setvideo(int card, string table, Model.Weight.WeightModel Values)
        {
            SqlDataReader getReader = null;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams = new SqlParameter[2];
            try
            {
                prams[0] = db.MakeInParam("@VIDEO_name", SqlDbType.VarChar, 50, card.ToString());
                prams[1] = db.MakeInParam("@VIDEO_table", SqlDbType.VarChar, 50, table);
                db.GetDataReader(visitor, prams, out getReader, "retvideo");
                if (getReader.Read())
                {
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 0, int.Parse(getReader["VIDEO_Brightness"].ToString()));
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 1, int.Parse(getReader["VIDEO_Contrast"].ToString()));
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 3, int.Parse(getReader["VIDEO_Hue"].ToString()));
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 2, int.Parse(getReader["VIDEO_Saturation"].ToString()));
                    switch (card)
                    {
                        case 0:
                            Values.StateFun.imagesuality1 = int.Parse(getReader["VIDEO_Suality"].ToString());
                            break;
                        case 1:
                            Values.StateFun.imagesuality2 = int.Parse(getReader["VIDEO_Suality"].ToString());
                            break;
                        case 2:
                            Values.StateFun.imagesuality3 = int.Parse(getReader["VIDEO_Suality"].ToString());
                            break;
                        case 3:
                            Values.StateFun.imagesuality4 = int.Parse(getReader["VIDEO_Suality"].ToString());
                            break;
                    }
                }
                else
                {
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 0, 80);
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 1, 44);
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 2, 40);
                    BLL.Weight.VideoInfo.VCStream_VCASetVidDeviceColor(card, 3, 0);
                    switch (card)
                    {
                        case 0:
                            Values.StateFun.imagesuality1 = 80;
                            break;
                        case 1:
                            Values.StateFun.imagesuality2 = 80;
                            break;
                        case 2:
                            Values.StateFun.imagesuality3 = 80;
                            break;
                        case 3:
                            Values.StateFun.imagesuality4 = 80;
                            break;
                    }
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误！" + err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

            }
        }
        #endregion

        #region 显示图片
        /// <summary>
        /// 显示图片
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool SelectImage(string Code, WeightModel values, string flag)
        {
            bool retvalues = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Code",SqlDbType.VarChar,50,Code)
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "SelectCode");
                if (getReader.Read())
                {
                    if (flag == "M")
                    {
                        if (getReader["G_Image1"] != System.DBNull.Value)
                            values.StateFun.G_Image1 = (byte[])getReader["G_Image1"];
                        if (getReader["G_Image2"] != System.DBNull.Value)
                            values.StateFun.G_Image2 = (byte[])getReader["G_Image2"];
                        if (getReader["G_Image3"] != System.DBNull.Value)
                            values.StateFun.G_Image3 = (byte[])getReader["G_Image3"];
                        if (getReader["G_Image4"] != System.DBNull.Value)
                            values.StateFun.G_Image4 = (byte[])getReader["G_Image4"];
                        if (getReader["G_Curve"] != System.DBNull.Value)
                            values.StateFun.G_Curve = (byte[])getReader["G_Curve"];
                    }
                    else if (flag == "P")
                    {
                        if (getReader["T_Image1"] != System.DBNull.Value)
                            values.StateFun.T_Image1 = (byte[])getReader["T_Image1"];
                        if (getReader["T_Image1"] != System.DBNull.Value)
                            values.StateFun.T_Image2 = (byte[])getReader["T_Image2"];
                        if (getReader["T_Image1"] != System.DBNull.Value)
                            values.StateFun.T_Image3 = (byte[])getReader["T_Image3"];
                        if (getReader["T_Image1"] != System.DBNull.Value)
                            values.StateFun.T_Image4 = (byte[])getReader["T_Image4"];
                        if (getReader["T_Curve"] != System.DBNull.Value)
                            values.StateFun.T_Curve = (byte[])getReader["T_Curve"];
                    }
                }
                else
                {
                    return false;
                }
                getReader.Close();
            }
            catch (Exception err)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalues;
        }
        #endregion

        #region 保存曲线图
        /// <summary>
        /// 保存曲线图
        /// </summary>
        /// <param name="CurveFlag"></param>
        /// <param name="CurveCode"></param>
        /// <param name="values"></param>
        public static void Save_Curve(string CurveFlag, string CurveCode, WeightModel values)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams = new SqlParameter[2];
            prams[0] = db.MakeInParam("@Code", SqlDbType.VarChar, 50, CurveCode);
            if (values.StateFun.Curve != null)
                prams[1] = db.MakeInParam("@Curve", SqlDbType.Binary, values.StateFun.Curve.Length, values.StateFun.Curve);
            else
                prams[1] = db.MakeInParam("@Curve", SqlDbType.Binary, 0, DBNull.Value);
            try
            {
                db.TransactSql(visitor, CurveFlag, prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show("错误：" + err.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                db.Dispose();
            }
        }
        #endregion

        public static void SaveCard(string sql, WeightModel values)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            if (sql == "one")
            {
                SqlParameter[] prams ={
                        db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Saver")),               
                        db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                        db.MakeInParam("@Card",SqlDbType.VarChar,50,values.Txt.Card),
                        db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                        db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                        db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                        db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                        db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                        db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                        db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                        db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry), 
                        db.MakeInParam("@Model", SqlDbType.VarChar,50,values.Txt.Model),
                        db.MakeInParam("@Driver", SqlDbType.VarChar,50, values.Txt.Driver),
                        db.MakeInParam("@Spare", SqlDbType.VarChar,50, values.Txt.Spare),
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,WSV.Model.User.LUser.Code),
            };
                try
                {
                    db.TransactSql(visitor, sql, prams);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (sql == "two")
            {
                SqlParameter[] prams ={     
                        db.MakeInParam("@Code", SqlDbType.VarChar,50, values.Code),
                        db.MakeInParam("@CarCode", SqlDbType.VarChar,50, values.Txt.CarCode),
                        db.MakeInParam("@Type", SqlDbType.VarChar,50, values.Txt.Type),
                        db.MakeInParam("@Item", SqlDbType.VarChar,50, values.Txt.Item),
                        db.MakeInParam("@Specs", SqlDbType.VarChar,50, values.Txt.Specs),
                        db.MakeInParam("@Place", SqlDbType.VarChar,50, values.Txt.Place),
                        db.MakeInParam("@Send", SqlDbType.VarChar,50, values.Txt.Send),
                        db.MakeInParam("@Accept", SqlDbType.VarChar,50, values.Txt.Accept),
                        db.MakeInParam("@Carry", SqlDbType.VarChar,50, values.Txt.Carry), 
                        db.MakeInParam("@Gross", SqlDbType.Decimal,50, values.Float.Gross),
                        db.MakeInParam("@G_Time",SqlDbType.VarChar,50,values.StateFun.G_Time),
                        db.MakeInParam("@Tare", SqlDbType.Decimal,50, values.Float.Tare),
                        db.MakeInParam("@T_Time",SqlDbType.VarChar,50,values.StateFun.T_Time),
                        db.MakeInParam("@Net",SqlDbType.Decimal,50,values.Float.Net),
                        db.MakeInParam("@N_Time",SqlDbType.VarChar,50,values.StateFun.N_Time),
                        //db.MakeInParam("@G_Oper",SqlDbType.VarChar,50,values.StateFun.G_Oper),
                        db.MakeInParam("@T_Oper",SqlDbType.VarChar,50,values.StateFun.T_Oper),
                        db.MakeInParam("@State",SqlDbType.Bit,1,1)
            };
                try
                {
                    db.TransactSql(visitor, sql, prams);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // 主表查询临时数据
        public static bool SelectCard1(string Card, WeightModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.CardDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Card",SqlDbType.VarChar,50,Card)
            };
            SqlDataReader getReader = null;
            try
            {
                db.GetDataReader(visitor, prams, out getReader, "SelectCard1");
                if (getReader.Read())
                {
                    // Item.Txt.Card = getReader["Card"].ToString();
                    Item.Txt.Type = getReader["Type"].ToString();
                    Item.Code = getReader["Code"].ToString();
                    Item.Txt.CarCode = getReader["CarCode"].ToString();
                    Item.Txt.Item = getReader["Item"].ToString();
                    Item.Txt.Specs = getReader["Specs"].ToString();
                    Item.Txt.Place = getReader["Place"].ToString();
                    Item.Txt.Accept = getReader["Accept"].ToString();
                    Item.Txt.Send = getReader["Send"].ToString();
                    Item.Txt.Carry = getReader["Carry"].ToString();
                    Item.StateFun.G_Oper = getReader["G_Oper"].ToString();
                    Item.StateFun.G_Time = getReader["G_Time"].ToString();
                    Item.Float.Gross = Convert.ToDecimal(getReader["Gross"].ToString());
                }
                else
                {
                    return false;
                }
            }
            catch (Exception er)
            {
                db.Dispose();
                MessageBox.Show("数据错误，请检查所存数据！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }
        //删除卡号
        public static void Delete(string S_Pr)
        {
            //bool retvalue = true;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CardDAL();
            SqlParameter[] prams =
                {
                    db.MakeInParam("@Card",SqlDbType.VarChar,50,S_Pr)
                };
            try
            {
                db.TransactSql(visitor, "Delete1", prams);
            }
            catch (Exception err)
            {
                db.Dispose();
                MessageBox.Show(err.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            finally
            {
                db.Dispose();
            }
            //  return retvalue;
        }
    }
}