using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;
using WSV.DAL.SysInfo;

namespace WSV.BLL.SysInfo
{
    public class BillInfoBLL
    {
        #region 构造出磅单的查询语句
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static string BillInfoSql(string Code)
        {
            string retSql = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BillInfoDAL();
            SqlDataReader myread;
            try
            {
                db.GetDataReader(visitor, null, out myread, "BillInfoSql");
                while(myread.Read())
                {
                    retSql += "," + myread["DBName"].ToString().Trim()+" as " + myread["Name"].ToString().Trim();
                }
                myread.Close();
                retSql= retSql.Substring(1);
                retSql = "Select " + retSql + " From V_D_Saver_D Where Code='"+Code.Trim()+"'";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return retSql;
        }
        #endregion

        #region 得到列名
        /// <summary>
        /// 得到列名
        /// </summary>
        public static DataSet BillInfoColName()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BillInfoDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "BillInfoColName", "A");
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

        #region 得到打印的DS
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>返回数据源</returns>
        public static DataSet BillPrint(string Code,string TableName)
        {
            string retSql = "";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BillInfoDAL();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(BillInfoSql(Code), TableName);
                //在程序中表示的名字给Capion
                int i=0;
                foreach (DataRow row in BillInfoColName().Tables[0].Rows)
                {
                    ds.Tables[TableName].Columns[i].Caption = row[0].ToString().Trim();
                    i++;
                }
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

        #region 根据类型得到打印的文件和标题
        /// <summary>
        /// 根据类型得到打印的文件和标题
        /// </summary>
        /// <returns></returns>
        public static DataSet PrintParam(string Type)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new BillInfoDAL();
            SqlParameter[] prams ={
                db.MakeInParam("@TypeName", SqlDbType.VarChar,50,Type)
            };
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor,prams, "PrintParam");
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
    }
}
