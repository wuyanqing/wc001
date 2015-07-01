using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL.Record;
using WSV.DAL;

namespace WSV.BLL.Record
{
    public class CubetyBll
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_Cubety");
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
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectCubety(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
             };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "SelectCubety");
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
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Insert(Model.Record.D_CubetyModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Cubety")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Cubety", SqlDbType.Decimal,50, Item.Cubety),
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
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Update(Model.Record.D_CubetyModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@ID", SqlDbType.VarChar,50, Item.ID),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Cubety", SqlDbType.Decimal,50, Item.Cubety),
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
        /// 删除数据
        /// </summary>
        /// <param name="ID">D_Base表ID</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Delete(long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,50,ID),
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
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet BindItem()
        {
            DataBase db = new DataBase();
            DAL.DataBaseVisitor visitor = new DAL.Record.D_CubetyVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "BingdItem", "D_Base");
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
