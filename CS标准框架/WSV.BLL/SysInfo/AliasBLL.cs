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
    public class AliasBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new AliasDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "C_Alias");
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
        public static bool Update(C_Alias Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new AliasDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@State", SqlDbType.Bit,0, Item.State),
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
    }
}
