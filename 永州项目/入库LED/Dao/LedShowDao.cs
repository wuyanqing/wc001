using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using THOK.Util;

namespace LEDSHOW.Dao
{
    public class LedShowDao : BaseDao
    {
        public DataTable LedShowInfo()
        {
            //string sql = "SELECT D.TobaccoName AS ProductName,D.StorageID AS StorageName,D.Piece AS Content,'出库' AS ACT " +
            //    "FROM BillMaster AS M LEFT JOIN BillDetail AS D ON D.BillID=M.BillID";
            string sql = "SELECT D.StorageID AS StorageName,D.TobaccoName AS ProductName,D.OperatePiece AS Content,S.StateName AS ACT " +
                "FROM BillDetail AS D  " +
                "LEFT JOIN StateType AS S ON S.StateCode = D.ConfirmState " +
                "WHERE OperateCode='2' AND D.ConfirmState<>'3' " +
                "ORDER BY D.ConfirmState DESC";
            return this.ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 根据流水号查询分拣完成的数量等数据
        /// </summary>
        /// <param name="sortNo">完成的流水号</param>
        /// <returns>返回查询到的数据表</returns>
        public DataTable FindOrderInfo(string sortNo)
        {
            string sql = "";
            if (sortNo != "all")
                sql = @"SELECT  sum(task_quantity) as total FROM wcs_task where order_type=1 and create_time> CONVERT(varchar(100), GETDATE(), 23) and state='04'";
            else
                sql = @"SELECT  sum(task_quantity) as total FROM wcs_task where order_type=1 and create_time> CONVERT(varchar(100), GETDATE(), 23)";
            return ExecuteQuery(sql).Tables[0];
        }
        /// <summary>
        /// 查询出当前正在入库记录 入库记录
        /// </summary>
        /// <returns></returns>
        public DataTable FindProductMiss(string sortNo)
        {
             string sql = "";
            if (sortNo != "all")
                sql = @"SELECT top 5 product_name,task_quantity,b.cell_name as cell_name
                           FROM wcs_task a left join wms_cell b on a.origin_cell_code=b.cell_code 
                           where order_type=1 and create_time> CONVERT(varchar(100), GETDATE(), 23) and state='02' 
                           order by id";
            else
                sql = @"SELECT top 5 product_name,task_quantity,b.cell_name as cell_name
                           FROM wcs_task a left join wms_cell b on a.origin_cell_code=b.cell_code 
                           where order_type=1 and create_time> CONVERT(varchar(100), GETDATE(), 23) and state='04' 
                           order by id";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询订单日期和批次号
        /// </summary>
        /// <returns></returns>
        public DataTable FindOrderdate()
        {
            string sql = @"SELECT DISTINCT(order_date) AS ORDERDATE,batch_no as BATCHNO FROM sort_order_allot_master";
            return ExecuteQuery(sql).Tables[0];
        }
    }
}
