using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL.Count;
using WSV.Model.Count;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;
using WSV;

namespace WSV.BLL.Count
{
    public class D_StatProjectBll
    {

        /// <summary>
        /// 查询全部方案
        /// </summary>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_StatProjectDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_StatProject");
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
        /// 根据方案查询需要显示的数据字段信息
        /// </summary>
        public static DataSet SelectByCode(string ProCode)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_StatProjectDal();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
               db.MakeInParam("@ProCode", SqlDbType.VarChar,50, ProCode),
             };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "SelectByCode");
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
        /// 按方案名称查询方案信息
        /// </summary>
        public static void SelectByName(string ProName, ref Model.Count.D_StatProjectModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectDal();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
               db.MakeInParam("@Name", SqlDbType.VarChar,50, ProName),
             };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "SelectByName");
                if (dr.Read())
                {
                    Item.Type = dr["Type"].ToString();
                    Item.SataType = dr["SataType"].ToString();
                    Item.Flag = dr["Flag"].ToString();
                    Item.Month = dr["Month"].ToString();
                    Item.Day = dr["Day"].ToString();
                    Item.BeginTime = dr["BeginTime"].ToString();
                    Item.EndTime = dr["EndTime"].ToString();
                }
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Insert(Model.Count.D_StatProjectModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                 db.MakeInParam("@ID", SqlDbType.VarChar,50, PublicFun.PublicFun.MaxId("D_StatProject")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50,PublicFun.PublicFun.MaxId("D_StatProject")),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Insert", prams, out nEffectRows);
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
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Update(Model.Count.D_StatProjectModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Type", SqlDbType.VarChar,50, Item.Type),
                db.MakeInParam("@SataType", SqlDbType.VarChar,50, Item.SataType),
                db.MakeInParam("@Flag", SqlDbType.VarChar,50, Item.Flag),
                db.MakeInParam("@Month", SqlDbType.VarChar,50, Item.Month),
                db.MakeInParam("@Day", SqlDbType.VarChar,50, Item.Day),
                db.MakeInParam("@BeginTime", SqlDbType.VarChar,50, Item.BeginTime),
                db.MakeInParam("@EndTime", SqlDbType.VarChar,50, Item.EndTime),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
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
        /// 删除方案
        /// </summary>
        /// <param name="Code">方案编号</param>
        /// <returns></returns>
        public static string Delete(string ProCode)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@Code", SqlDbType.VarChar,50, ProCode),
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
    }
}
