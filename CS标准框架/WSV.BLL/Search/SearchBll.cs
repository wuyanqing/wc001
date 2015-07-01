using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV;
using WSV.DAL;

namespace WSV.BLL.Search
{
    public class SearchBll
    {
        /// <summary>
        /// 查询全部汇总项目
        /// </summary>
        /// <returns></returns>
        public static DataSet Select_Select()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Search.SearchDal();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select_V_C_Select", "V_C_Select");
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
        /// 修改设置信息
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Update(Model.Search.C_SelectModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Search.SearchDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@As", SqlDbType.VarChar,50, Item.As),
                db.MakeInParam("@Show", SqlDbType.Bit,4, Item.Show),
                db.MakeInParam("@Place", SqlDbType.BigInt,8, Item.Place),
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
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static DataSet SaverInfo(string sql)
        {
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql);
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
        /// 删除数据
        /// </summary>
        /// <param name="ID">D_Saver表ID</param>
        /// <returns>"0101"表示成功，"0"表示失败</returns>
        public static string Delete(long ID)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Search.SearchDal();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                db.MakeInParam("@ID", SqlDbType.BigInt,8,ID),
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
        /// 查询毛皮图片
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Code"></param>
        public static void DataShowImage(ref Model.Weight.StateModel Item, string Code)
        {
            SqlDataReader dr = null;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@Code",SqlDbType.VarChar,50,Code)
            };
            try
            {

                db.GetDataReader(visitor, prams, out dr, "SelectCode");
                if (dr.Read())
                {
                    if (dr["G_Image1"] != System.DBNull.Value)
                        Item.G_Image1 = (byte[])dr["G_Image1"];
                    if (dr["G_Image2"] != System.DBNull.Value)
                        Item.G_Image2 = (byte[])dr["G_Image2"];
                    if (dr["G_Image3"] != System.DBNull.Value)
                        Item.G_Image3 = (byte[])dr["G_Image3"];
                    if (dr["G_Image4"] != System.DBNull.Value)
                        Item.G_Image4 = (byte[])dr["G_Image4"];
                    if (dr["T_Image1"] != System.DBNull.Value)
                        Item.T_Image1 = (byte[])dr["T_Image1"];
                    if (dr["T_Image2"] != System.DBNull.Value)
                        Item.T_Image2 = (byte[])dr["T_Image2"];
                    if (dr["T_Image3"] != System.DBNull.Value)
                        Item.T_Image3 = (byte[])dr["T_Image3"];
                    if (dr["T_Image4"] != System.DBNull.Value)
                        Item.T_Image4 = (byte[])dr["T_Image4"];
                    if (dr["G_Curve"] != System.DBNull.Value)
                        Item.G_Curve = (byte[])dr["G_Curve"];
                    if (dr["T_Curve"] != System.DBNull.Value)
                        Item.T_Curve = (byte[])dr["T_Curve"];
                }
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                dr.Close();
                db.Dispose();
            }
        }
        ///// <summary>
        ///// 查询上衡曲线
        ///// </summary>
        ///// <param name="Item"></param>
        ///// <param name="Code"></param>
        //public static void ShowImage(ref Model.Weight.StateModel Item, string Code)
        //{
        //    SqlDataReader dr = null;
        //    DataBase db = new DataBase();
        //    DataBaseVisitor visitor = new WSV.DAL.Weight.WeightDAL();
        //    SqlParameter[] prams ={
        //        db.MakeInParam("@Code",SqlDbType.VarChar,50,Code)
        //    };
        //    try
        //    {

        //        db.GetDataReader(visitor, prams, out dr, "Select_Curver");
        //        if (dr.Read())
        //        {
        //            Item.G_Curve = (byte[])dr["G_Curve"];
        //            Item.T_Curve = (byte[])dr["T_Curve"];
        //        }
        //    }
        //    catch (Exception ex)
        //    { throw new Exception(ex.Message); }
        //    finally
        //    {
        //        dr.Close();
        //        db.Dispose();
        //    }
        //}
    }
}
