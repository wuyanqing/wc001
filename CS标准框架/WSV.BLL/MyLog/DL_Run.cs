using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.Model;
using System.Data.SqlClient;
using System.Data;

namespace WSV.BLL.MyLog
{
    public class DL_Run
    {
        /// <summary>
        /// 带参数的数据查询
        /// </summary>
        /// <param name="Begin">开始时间</param>
        /// <param name="Over">结束时间</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll(string Begin, string Over)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_Run();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
                db.MakeInParam("@Begin", SqlDbType.Char,50, Begin),
                db.MakeInParam("@Over", SqlDbType.Char,50, Over),
            };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "Select");
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
        /// 带参数的数据查询
        /// </summary>
        /// <param name="Begin">开始时间</param>
        /// <param name="Over">结束时间</param>
        /// <param name="Name">操作员姓名</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectOption(string Begin, string Over, string Name)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_Run();
            DataSet ds = new DataSet();
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.Char,50, Name),
                db.MakeInParam("@Begin", SqlDbType.Char,50, Begin),
                db.MakeInParam("@Over", SqlDbType.Char,50, Over),
            };
            try
            {
                ds = db.ReturnDataSet(visitor, prams, "SelectOption");
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }

        #region 插入操作记录
        /// <summary>
        /// 插入一条操作记录，并返回他的编号
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static string Insert(string Content)
        {
            string ret_Code = MaxID().ToString();
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_Run();
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,8, long.Parse(ret_Code)),
                db.MakeInParam("@Code", SqlDbType.VarChar,50,ret_Code),
                db.MakeInParam("@Work", SqlDbType.VarChar,50, Content),
                db.MakeInParam("@InTime", SqlDbType.DateTime,8, DateTime.Now),
                db.MakeInParam("@OperCode", SqlDbType.VarChar,50, Model.User.LUser.Code),
                db.MakeInParam("@TableNum", SqlDbType.VarChar,50, Model.User.LUser.TableNum)
            };
            try
            {
                db.TransactSql(visitor, "Insert", prams);
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ret_Code;
        }
        #endregion

        #region 修改操作记录
        /// <summary>
        /// 插入一条操作记录，并返回他的编号
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static bool Update(string Code)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_Run();
            SqlParameter[] prams ={
                db.MakeInParam("@Code", SqlDbType.VarChar,50,Code),
                db.MakeInParam("@OutTime", SqlDbType.DateTime,8, DateTime.Now),
            };
            try
            {
                db.TransactSql(visitor, "Update", prams);
                return true;
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); return false; }
            finally
            {
                db.Dispose();
            }
            
        }
        #endregion

        #region 最大ID
        /// <summary>
        /// 最大ID
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static long MaxID()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_Run();
            long ret_V = 0;
            try
            {
                SqlDataReader dr;
                db.GetDataReader(visitor,null,out dr, "MaxID");
                if (dr.Read())
                {
                    if(dr[0] !=null)
                    ret_V = long.Parse(dr[0].ToString());
                }
                ret_V += 1;
                //ds = db.ReturnDataSet(visitor, prams, "Select");
            }
            catch (Exception ex)
            { return 0; throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ret_V;
        }
        #endregion
    }
}
