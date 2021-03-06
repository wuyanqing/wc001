﻿using System;
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
                sql = @"select count(distinct customer_code) CUSTOMERNUM, count(distinct deliver_line_code) ROUTENUM,
                         (select isnull(sum(quantity),0) from sort_order_allot_master where finish_time <= getdate() and status='02' ) quantity
                         from sort_order_allot_master where finish_time <= getdate()";
            else
                sql = @"select count(distinct customer_code) CUSTOMERNUM, count(distinct deliver_line_code) ROUTENUM,
                         (select isnull(sum(quantity),0) from sort_order_allot_master) quantity
                         from sort_order_allot_master";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询分拣效率
        /// </summary>
        /// <returns>返回一个整数效率</returns>
        public int FindSortingAverage()
        {
            string sql = @"select datediff(hour,min([finish_time]),getdate()) FROM sort_order_allot_master where status='02'";
            return Convert.ToInt32(ExecuteQuery(sql).Tables[0].Rows[0][0]);
        }

        /// <summary>
        /// 查询正在分拣的线路订单信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCurrentRoute()
        {
            string sql = @"SELECT deliver_line_name as ROUTENAME FROM [sort_db].[dbo].[sort_order_allot_master] where status='02' and pack_no=(select MAX(pack_no) from [sort_db].[dbo].[sorting] where status='1')";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询出当前正在分拣的线路的总数量
        /// </summary>
        /// <returns></returns>
        public int FindCurrentRouteQuantity()
        {
            string sql = @"SELECT SUM(QUANTITY)+SUM(QUANTITY1) ROUTETOTALQUANTITY FROM AS_SC_PALLETMASTER WHERE ROUTECODE=(SELECT ROUTECODE  FROM AS_SC_PALLETMASTER 
			                WHERE STATUS=1 AND SORTNO=(SELECT MAX(SORTNO) FROM AS_SC_PALLETMASTER WHERE STATUS=1 ))";
            return Convert.ToInt32(ExecuteQuery(sql).Tables[0].Rows[0][0]);
        }

        /// <summary>
        /// 查询出当前正在分拣的线路的已分拣数量
        /// </summary>
        /// <returns></returns>
        //        public int FindCurrentRouteCompleteQuantity()
        //        {
        //            string sql = @"SELECT ISNULL(SUM(QUANTITY)+SUM(QUANTITY1),0) AS ROUTECOMPLETEQUANTITY 
        //		                            FROM AS_SC_PALLETMASTER 
        //		                            WHERE ROUTECODE=(SELECT ROUTECODE  FROM AS_SC_PALLETMASTER 
        //		                            WHERE STATUS=1 AND SORTNO=(SELECT MAX(SORTNO) FROM AS_SC_PALLETMASTER WHERE STATUS=1 ))
        //                            AND ISNULL(CONVERT(CHAR, FINISHEDTIME),NULL) <>'NULL' AND ISNULL(CONVERT(CHAR, FINISHEDTIME1),NULL) <>'NULL'";
        //            return Convert.ToInt32(ExecuteQuery(sql).Tables[0].Rows[0][0]);
        //        }

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
