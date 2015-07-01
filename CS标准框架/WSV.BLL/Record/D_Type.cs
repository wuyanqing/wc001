using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using WSV;
using WSV.DAL;

namespace WSV.BLL.Record
{
    public class D_Type
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_TypeVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_Type");
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
        public static string Update(Model.Record.D_TypeModel Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Record.D_TypeVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={  
                db.MakeInParam("@Name", SqlDbType.VarChar,50, Item.Name),
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
    }
}
