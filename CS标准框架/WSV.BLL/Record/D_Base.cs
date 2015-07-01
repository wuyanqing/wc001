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
    public class D_Base
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_Base");
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
        /// <param name="PCode">父类编号-DC_Base编号</param>
        /// <param name="used">是否作废</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectByPCode(string PCode, bool used)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
               db.MakeInParam("@ParentCode", SqlDbType.VarChar,50, PCode),
             };
            try
            {
                if (used)     //查询没作废的信息
                {
                    ds = db.ReturnDataSet(visitor, prams, "Select_Use");
                }
                else         //查询作废的信息
                {
                    ds = db.ReturnDataSet(visitor, prams, "Select_Used");
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
        public static string Update(D_BaseModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@CodeID", SqlDbType.VarChar,50, Item.CodeID),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Rem", SqlDbType.VarChar,50, Item.Rem),
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
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Insert(D_BaseModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,50, PublicFun.PublicFun.MaxId("D_Base")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.ParentCode+Item.CodeID),
                db.MakeInParam("@CodeID", SqlDbType.VarChar,50, Item.CodeID),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Rem", SqlDbType.VarChar,50, Item.Rem),
                db.MakeInParam("@ParentCode", SqlDbType.VarChar,50, Item.ParentCode),
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
        /// <param name="Used">是否作废</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Update_Used(long ID, bool Used)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
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
        /// <param name="CodeID">D_Base编号</param>
        /// <param name="ParentCode">父类编号-DC_Base表编号</param>
        /// <returns></returns>
        public static bool ValiDateCode(string CodeID, string ParentCode)
        {
            bool Flag = false;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@CodeID", SqlDbType.VarChar,50, CodeID),
                  db.MakeInParam("@ParentCode", SqlDbType.VarChar,50, ParentCode),
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
        /// <param name="ID">D_Base表ID</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Delete(long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new D_BaseVisitor();
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
    }
}
