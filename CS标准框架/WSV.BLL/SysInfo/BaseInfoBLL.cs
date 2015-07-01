using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.Model.SysInfo;
using WSV.DAL;
using WSV.DAL.SysInfo;

namespace WSV.BLL.SysInfo
{
    public class BaseInfoBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll(string WhereSql)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BaseInfoDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "DC_BaseInfo",WhereSql);
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

        #region 修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Update(DC_BaseInfo Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BaseInfoDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Company", SqlDbType.VarChar,50, Item.Company),
                db.MakeInParam("@Address", SqlDbType.VarChar,50, Item.Address),
                db.MakeInParam("@Tel", SqlDbType.VarChar,50, Item.Tel),
                db.MakeInParam("@PrintTitle", SqlDbType.VarChar,50, Item.PrintTitle),
                db.MakeInParam("@Id", SqlDbType.Int,0,Item.Id)
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
    }
}
