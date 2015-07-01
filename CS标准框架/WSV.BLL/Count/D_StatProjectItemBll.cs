using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;
using WSV;

namespace WSV.BLL.Count
{
    public class D_StatProjectItemBll
    {
        /// <summary>
        /// 删除汇总项目
        /// </summary>
        /// <param name="Code">方案编号</param>
        /// <returns></returns>
        public static string Delete(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectItemDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Code),
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
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Insert(Model.Count.D_StatProjectItemModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Count.D_StatProjectItemDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@StatCode", SqlDbType.VarChar,50, Item.StatCode),
                db.MakeInParam("@Place", SqlDbType.VarChar,50, Item.Place),  
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
    }
}
