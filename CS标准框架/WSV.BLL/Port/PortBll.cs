using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.Port
{
    public class PortBll
    {
        /// <summary>
        /// 查询出所有的数据
        /// </summary>
        /// <returns>DataSet</returns>
        public static DataSet SelectAll()
        {
            DataBase db = new DataBase();
            DAL.DataBaseVisitor visitor = new DAL.Port.PortVisitor();
            DataSet ds = new DataSet();
            try
            {
                ds = db.ReturnDataSet(visitor, "Select", "D_Base");
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
        /// 添加数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static string AddData(Model.Port.PortModel port, int Iport)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Port.PortVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            //long id = BLL.PublicFun.PublicFun.MaxId("D_Plan");
            SqlParameter[] prams ={
                //db.MakeInParam("@ID", SqlDbType.BigInt,12, BLL.PublicFun.PublicFun.MaxId("D_Plan")),              
                db.MakeInParam("@fcustid", SqlDbType.Int,4, port.Fcustid),
                db.MakeInParam("@FDeptID", SqlDbType.Int,4, port.FDeptID),
                db.MakeInParam("@fitemid", SqlDbType.Int,4, port.Fitemid),
                db.MakeInParam("@FUnitID", SqlDbType.Int,4, port.FUnitID),
                db.MakeInParam("@FFManagerID", SqlDbType.Int,4, port.FFManagerID),
                db.MakeInParam("@FSManagerID", SqlDbType.Int,4, port.FSManagerID),
                db.MakeInParam("@FDCStockID", SqlDbType.Int,4, port.FDCStockID),
                db.MakeInParam("@fbiller", SqlDbType.Int,4, port.Fbiller),
                db.MakeInParam("@FQty", SqlDbType.Decimal,50, port.FQty),
                db.MakeInParam("@FPrice", SqlDbType.Decimal,50, port.FPrice),
                db.MakeInParam("@FAmount", SqlDbType.Decimal,50, port.FAmount),
                db.MakeInParam("@FDate", SqlDbType.DateTime,50, port.FDate),
            };
            try
            {
                if (Iport == 0)
                    bSuc = db.PortTransactSql1(visitor, "Insert", prams, out nEffectRows);
                if (Iport == 1)
                    bSuc = db.PortTransactSql2(visitor, "Insert", prams, out nEffectRows);
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
