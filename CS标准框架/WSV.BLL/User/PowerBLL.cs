using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.Model.User;
using WSV.DAL;
using WSV.DAL.User;

namespace WSV.BLL.User
{
    public class PowerBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll(string WhereSql)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new PowerDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "DC_Power",WhereSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        #endregion

        #region 添加数据
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Insert(DC_Power Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new PowerDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Id", SqlDbType.BigInt,0,PublicFun.PublicFun.MaxId("DC_Power")),
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@ParentCode", SqlDbType.VarChar,50, Item.ParentCode),
                db.MakeInParam("@RuleName", SqlDbType.VarChar,50, Item.RuleName)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "Insert", prams, out N);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Update(DC_Power Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new PowerDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@RuleName", SqlDbType.VarChar,50, Item.RuleName),
                db.MakeInParam("@Id", SqlDbType.BigInt,0,Item.Id)
            };
            try
            {
                ReFlag = db.TransactSql(visitor, "Update", prams, out N);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            if (ReFlag && N > 0)
            {
                Flag = true;
            }
            return Flag;
        }
        #endregion

        #region 删除数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Del(string Id)
        {
            DataBase db = new DataBase();
            bool Flag = false;
            try
            {
                if (db.TransactSql("delete from DC_Power where id in(" + Id + ")"))
                {
                    Flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Flag;
        }
        #endregion
    }
}
