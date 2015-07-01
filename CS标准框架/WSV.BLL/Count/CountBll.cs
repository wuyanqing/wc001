using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL.Count;
using WSV.Model.Count;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.Count
{
    public class CountBll
    {
        /// <summary>
        /// 查询全部汇总项目
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "V_C_StatSelect");
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
        /// 查询方案对应的汇总项目
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectCode(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
               db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
             };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "SelectCode");
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
        /// 编辑方案对应的汇总项目
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectEidtCode(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
               db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
             };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "SelectEidtCode");
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
        /// 查询数据格式
        /// </summary>
        /// <param name="ProCode"></param>
        public static DataSet Selectfun()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Selectfun", "C_Function");
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
        /// 查询数据类型
        /// </summary>
        public static DataSet Selecttype()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Selecttype", "D_Type");
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
        /// 查询汇总数据字段信息
        /// </summary>
        /// <returns></returns>
        public static DataSet Select_V_C_Stat()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new CountDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select_V_C_Stat", "V_C_Stat");
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
        /// 修改设置信息
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Update(Model.Count.C_StatModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.CountDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@As", SqlDbType.VarChar,50, Item.As),
                db.MakeInParam("@Show", SqlDbType.Bit,4, Item.Show),
                db.MakeInParam("@Place", SqlDbType.BigInt,8, Item.Place),
                db.MakeInParam("@Fun", SqlDbType.VarChar,50, Item.Fun),
                db.MakeInParam("@ID", SqlDbType.BigInt,50, Item.ID),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Update", prams, out nEffectRows);
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
        /// 汇总
        /// </summary>
        /// <returns></returns>
        public static DataSet SaverInfo(string sql)
        {
            DataBase db = new DataBase();
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
    }
}