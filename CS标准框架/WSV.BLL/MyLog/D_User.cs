using System;
using System.Collections.Generic;
using System.Text;
using WSV.DAL;
using WSV.Model;
using System.Data.SqlClient;
using System.Data;

namespace WSV.BLL.MyLog
{
    public class D_User
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns></returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new WSV.DAL.MyLog.D_User();            
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_User");
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
