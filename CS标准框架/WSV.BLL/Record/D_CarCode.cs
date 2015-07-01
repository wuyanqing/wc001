using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL.Record;
using WSV.Model.Record;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.Record
{
    public class D_CarCode
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_CarCode");
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
        /// 按条件查询数据
        /// </summary>
        /// <param name="used">是否启用</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectByPCode(bool used)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            DataSet ds = new DataSet();
            try
            {
                if (used)     //查询没作废的信息
                {
                    ds = db.ReturnDataSet(visitor, "Select_Use", "D_CarCode");
                }
                else         //查询作废的信息
                {
                    ds = db.ReturnDataSet(visitor, "Select_Used", "D_CarCode");
                }
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
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Update(D_CarCodeModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@CarCode", SqlDbType.VarChar,50, Item.CarCode),
                db.MakeInParam("@Tare", SqlDbType.Float,12, Item.Tare),
                db.MakeInParam("@Driver", SqlDbType.VarChar,50, Item.Driver),
                db.MakeInParam("@ID", SqlDbType.VarChar,50,Item.ID),
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
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Insert(D_CarCodeModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_CarCode")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@CarCode", SqlDbType.VarChar,50, Item.CarCode),
                db.MakeInParam("@Tare", SqlDbType.Float,12, Item.Tare),
                db.MakeInParam("@Driver", SqlDbType.VarChar,50, Item.Driver),    
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
        /// 操作是否作废数据
        /// </summary>
        /// <param name="ID">表ID</param>
        /// <param name="Used">是否启用</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Update_Used(long ID, bool Used)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Used", SqlDbType.Bit,8, Used),
                db.MakeInParam("@ID", SqlDbType.BigInt,50,ID),
            };
            try
            {
                bSuc = db.TransactSql(visitor, "Update_Used", prams, out nEffectRows);
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
        /// 验证编号是否存在
        /// </summary>
        /// <returns>bool</returns>
        public static bool ValiDateCode(string Code)
        {
            bool Flag = false;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
            };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "SelectByCode");
                if (dr.Read())
                {
                    Flag = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Delete(long Id)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_CarCodeVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@ID", SqlDbType.VarChar,50,Id),
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
