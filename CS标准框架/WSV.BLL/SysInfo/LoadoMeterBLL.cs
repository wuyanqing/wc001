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
    public class LoadoMeterBLL
    {
        #region 查询出所有的数据
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet SelectAll(string WhereSql)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new LoadoMeterDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "DC_LoadoMeter", WhereSql);
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
        public static bool Insert(DC_LoadoMeter Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new LoadoMeterDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Id", SqlDbType.BigInt,0,PublicFun.PublicFun.MaxId("DC_LoadoMeter")),
                db.MakeInParam("@TableNum", SqlDbType.VarChar,50, Item.TableNum),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Ip", SqlDbType.VarChar,50, Item.Ip),
                db.MakeInParam("@Port", SqlDbType.VarChar,50, Item.Port),
                db.MakeInParam("@Remark", SqlDbType.VarChar,255, Item.Remark)
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
        public static bool Update(DC_LoadoMeter Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new LoadoMeterDAL();
            bool Flag = false, ReFlag = false;
            int N = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@Ip", SqlDbType.VarChar,50, Item.Ip),
                db.MakeInParam("@Port", SqlDbType.VarChar,50, Item.Port),
                db.MakeInParam("@Remark", SqlDbType.VarChar,255, Item.Remark),
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
                if (db.TransactSql("delete from DC_LoadoMeter where id in(" + Id + ")"))
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

        #region 设为本机
        /// <summary>
        /// 设为本机
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool SetLocal(DC_LoadoMeter Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("LoadoMeter", "TableNum", Item.TableNum);
                }
                Flag = true;
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
