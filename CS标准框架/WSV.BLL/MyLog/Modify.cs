using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WSV.BLL.MyLog
{
    public class Modify
    {
        /// <summary>
        /// 带参数的数据查询
        /// </summary>
        /// <param name="Begin">开始时间</param>
        /// <param name="Over">结束时间</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectModify(string Begin, string Over)
        {
            string sql1 = Sql() + " where DT between '" + Begin + "' and '" + Over + "' order by ID desc";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.Modify();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql1);
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        public static DataSet SelectMain()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.Modify();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "SelMain", "LC_Main");
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
        /// <param name="Name">操作方式</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectByWorkWise(string Begin, string Over, string Name)
        {
            string sql2 = Sql() + " where WorkName='" + Name + "' and DT between '" + Begin + "' and '" + Over + "' order by ID desc";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.Modify();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql2);
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
        public static DataSet SelectByUserName(string Begin, string Over, string Name)
        {
            string sql3 = Sql() + " where UserName='" + Name + "' and DT between '" + Begin + "' and '" + Over + "' order by ID desc";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.Modify();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql3);
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
        /// <param name="WorkName">操作方式</param>
        /// <param name="UserName">操作员姓名</param>
        /// <returns>DataSet</returns>
        public static DataSet SelectOption(string Begin, string Over, string WorkName, string UserName)
        {
            string sql4 = Sql() + " where WorkName='" + WorkName + "' and UserName='" + UserName + "'  and DT between '" + Begin + "' and '" + Over + "' order by ID desc";
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.Modify();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(sql4);
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return ds;
        }
        public static DataSet GetName()
        {
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            string sql = "select Name,DBName from V_C_Alias";
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
        public static string Sql()
        {
            string sql = "";
            DataTable dt = new DataTable();
            dt = GetName().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string Name = dt.Rows[i]["Name"].ToString();
                string DBName = dt.Rows[i]["DBName"].ToString();
                sql += DBName + " as " + Name + ",";
            }
            sql = "Select " + sql + "ID,WorkCode,WorkName,DT,UserName,Code,CarCode,G_Oper,T_Oper,[Name],G_Table,T_Table from V_L_Modify";
            return sql;
        }
    }
}
