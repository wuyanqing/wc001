using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;
using WSV;

namespace WSV.BLL.MyLog
{
    public class DL_Weight
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
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_WeightVisitor();
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
            DataBaseVisitor visitor = new WSV.DAL.MyLog.DL_WeightVisitor();
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
        #region 添加图片
        public static bool Addpicture(string Code, WSV.Model.Weight.WeightModel value)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.MyLog.DL_WeightVisitor();
            bool retvalue = true;
            SqlParameter[] prams ={
                db.MakeInParam("@Code",SqlDbType.VarChar,50,Code)
            };
            SqlDataReader Reader = null;
            try
            {
                db.GetDataReader(visitor, prams, out Reader, "AddPicture");
                if (Reader.Read())
                {
                    value.StateFun.Image1 = (byte[])Reader["Image1"];
                    value.StateFun.Image2 = (byte[])Reader["Image2"];
                    value.StateFun.Image3 = (byte[])Reader["Image3"];
                    value.StateFun.Image4 = (byte[])Reader["Image4"];

                }
                else
                {
                    retvalue = false;
                }
            }
            catch (Exception e)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        public static bool AddCurve(string Code, WSV.Model.Weight.WeightModel value)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.MyLog.DL_WeightVisitor();
            bool retvalue = true;
            SqlParameter[] prams ={
                db.MakeInParam("@Code",SqlDbType.VarChar,50,Code)
            };
            SqlDataReader Reader = null;
            try
            {
                db.GetDataReader(visitor, prams, out Reader, "AddCurve");
                if (Reader.Read())
                {
                    value.StateFun.Curve = (byte[])Reader["Curve"];
                }
                else
                {
                    retvalue = false;
                }
            }
            catch (Exception e)
            {
                db.Dispose();
                return false;
            }
            finally
            {
                db.Dispose();
            }
            return retvalue;
        }
        #endregion
    }
}
