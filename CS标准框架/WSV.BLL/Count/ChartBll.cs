using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.Count
{
    public class ChartBll
    {
        /// <summary>
        /// 汇总柱形图
        /// </summary>
        /// <param name="sql"></param>
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
    }
}
