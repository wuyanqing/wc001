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
    public class DC_Base
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DC_BaseVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "V_DC_Base");
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
        /// 根据名字查询编号
        /// </summary>
        /// <returns></returns>
        public static string SelectByName(string Name)
        {
            string Code = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DC_BaseVisitor();
            SqlDataReader dr = null;
            SqlParameter[] prams ={
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Name),
            };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "SelectByName");
                if (dr.Read())
                {
                    Code = dr["Code"].ToString();
                }
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return Code;
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string Update(DC_BaseModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DC_BaseVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={       
                db.MakeInParam("@Code", SqlDbType.VarChar,50, Item.Code),
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
                db.MakeInParam("@AS", SqlDbType.VarChar,50, Item.AS),
                db.MakeInParam("@Flag", SqlDbType.VarChar,50, Item.Flag),
                db.MakeInParam("@Rank", SqlDbType.VarChar,50, Item.Rank),
                db.MakeInParam("@ID", SqlDbType.VarChar,50, Item.ID),
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
    }
}
