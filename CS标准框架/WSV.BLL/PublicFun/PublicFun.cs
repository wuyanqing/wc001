using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.PublicFun
{
    /// <summary>
    /// 公共方法类
    /// </summary>
    public class PublicFun
    {
        /// <summary>
        /// 得到最大ID
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <returns>返回最大的ID号</returns>
        public static long MaxId(string TableName)
        {
            DataBase db = new DataBase();
            long _MaxId = 0;
            SqlDataReader dr = null;
            string sql = "select max(ID) from " + TableName;
            try
            {
                db.GetDataReader(out dr, sql);
                if (dr.Read())
                {
                    if (dr[0].ToString() == "")
                        _MaxId = 0;
                    else
                        _MaxId = Convert.ToInt64(dr[0].ToString());
                }
                _MaxId += 1;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            return _MaxId;
        }

        #region 检查主键
        /// <summary>
        /// 检查主键
        /// </summary>
        /// <param name="Tab">表名</param>
        /// <param name="key">要检查的字段名</param>
        /// <param name="value">要检查的值</param>
        /// <param name="Id">Id等于0代表添加操作，否则就是修改操作</param>
        public static bool CheckKey(string Tab, string key, string value, long Id)
        {
            bool Flag = false;
            DataBase db = new DataBase();
            SqlDataReader dr = null;
            try
            {
                if (Id == 0)
                {
                    db.GetDataReader(out dr, "select * from " + Tab + " where " + key + "='" + value + "'");
                    if (dr.Read()) { Flag = true; }
                }
                else
                {
                    db.GetDataReader(out dr, "select * from " + Tab + " where Id<>" + Id + " and " + key + "='" + value + "'");
                    if (dr.Read()) { Flag = true; }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                db.Dispose();
            }
            return Flag;
        }
        #endregion
        #region  数据库备份与恢复--系统设置
        /// <summary>
        /// 备份数据库
        /// </summary>
        /// <param name="bakUpName"></param>
        public static bool BackUp(string bakUpName)
        {
            bool Flag = true;
            DataBase db = new DataBase();
            try
            {
                db.TransactSql("BACKUP DATABASE WSV TO DISK ='" + bakUpName + "'");
            }
            catch (Exception ex)
            {
                Flag = false;
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        /// <summary>
        /// 恢复数据库
        /// </summary>
        /// <param name="reStoreName"></param>
        public static bool ReStore(string reStoreName)
        {
            bool Flag = true;
            DataBase db = new DataBase();
            try
            {
                db.TransactSql("use master RESTORE DATABASE WSV from disk='" + reStoreName + "'");
            }
            catch (Exception ex)
            {
                Flag = false;
                throw ex;
            }
            finally
            {
                db.Dispose();
            }
            return Flag;
        }
        #endregion
        /// <summary>
        /// 根据字段获得字段
        /// </summary>
        /// <param name="GetName">要得到的字段名</param>
        /// <param name="Tab">表名</param>
        /// <param name="key">条件的字段名</param>
        /// <param name="value">条件的值</param>
        /// <param name="Id">Id等于0代表添加操作，否则就是修改操作</param>
        public static string GetKey(string GetName, string Tab, string key, string value, long Id)
        {
            string Sname = "";
            DataBase db = new DataBase();
            SqlDataReader dr = null;
            try
            {
                if (Id == 0)
                {
                    db.GetDataReader(out dr, "select " + GetName + " from " + Tab + " where " + key + "='" + value + "'");
                    if (dr.Read()) { Sname = dr[GetName].ToString(); }
                }
                else
                {
                    db.GetDataReader(out dr, "select " + GetName + " from " + Tab + " where Id<>" + Id + " and " + key + "='" + value + "'");
                    if (dr.Read()) { Sname = dr[GetName].ToString(); }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                db.Dispose();
            }
            return Sname;
        }
        #region 净重
        public static decimal NetFun(decimal gross, decimal tare)
        {
            decimal Net = gross - tare;
            return Net;
        }
        #endregion

        #region 结算净重
        public static decimal EndNetFun(int Pro, decimal Net, decimal DeductWei, decimal Impurity)
        {
            decimal EndNet = 0;
            switch (Pro)
            {
                case 0:
                    EndNet = Net - DeductWei - Impurity;
                    break;
                case 1:
                    EndNet = Net - DeductWei;
                    break;
                case 2:
                    EndNet = Net;
                    break;
            }
            return EndNet;
        }
        #endregion

        #region 金额
        public static decimal MoneyFun(int Pro, decimal Net, decimal EndNet, decimal Price, decimal Cube)
        {
            decimal Money = 0;
            switch (Pro)
            {
                case 0:
                    Money = Net * Price;
                    break;
                case 1:
                    Money = EndNet * Price;
                    break;
                case 2:
                    Money = Cube * Price;
                    break;
            }
            return Money;
        }
        #endregion

        #region 扣重，扣杂
        public static decimal Wei(decimal Net, decimal Rate)
        {
            decimal Wei = Net * Rate / 100;
            return Wei;
        }
        #endregion

        #region 扣率，扣杂率
        public static decimal Rate(decimal Net, decimal Wei)
        {
            if (Net != 0)
            {
                decimal Rate = Wei / Net * 100;
                return Convert.ToDecimal(Math.Round(Rate, 10, MidpointRounding.AwayFromZero));
            }
            else
            {
                return 0;
            }

        }
        #endregion

        #region 小数位数与取数方式地方法
        /// <summary>
        /// 小数位数与取数方式地方法
        /// </summary>
        /// <param name="Num">需要转换的数值</param>
        /// <param name="Digit">要求保留的小数位数</param>
        /// <param name="Round">保留小数的方式</param>
        /// <returns></returns>
        public static decimal NumDig(decimal Num, int Digit, int Round)
        {
            long a = 1;
            for (int i = 1; i <= Digit; i++)
            {
                a = a * 10;
            }
            try
            {
                if (Round == 0)
                {
                    return Convert.ToDecimal(Math.Round(Num, Digit, MidpointRounding.AwayFromZero));
                }
                else
                {
                    Num = Num * a;
                    decimal c = Math.Truncate(Num);
                    return c / a;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
