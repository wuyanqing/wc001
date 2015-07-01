using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Port
{
    public class PortModel
    {
        private int _Fcustid, _FDeptID, _Fitemid, _FUnitID, _FFManagerID, _FSManagerID, _FDCStockID, _Fbiller;
        private decimal _FQty, _FPrice, _FAmount;
        private DateTime _FDate;
        /// <summary>
        /// 客户
        /// </summary>
        public int Fcustid { get { return _Fcustid; } set { _Fcustid = value; } }
        /// <summary>
        /// 部门
        /// </summary>
        public int FDeptID { get { return _FDeptID; } set { _FDeptID = value; } }
        /// <summary>
        /// 物料
        /// </summary>
        public int Fitemid { get { return _Fitemid; } set { _Fitemid = value; } }
        /// <summary>
        /// 计量单位
        /// </summary>
        public int FUnitID { get { return _FUnitID; } set { _FUnitID = value; } }
        /// <summary>
        /// 收货
        /// </summary>
        public int FFManagerID { get { return _FFManagerID; } set { _FFManagerID = value; } }
        /// <summary>
        /// 保管
        /// </summary>
        public int FSManagerID { get { return _FSManagerID; } set { _FSManagerID = value; } }
        /// <summary>
        /// 仓库
        /// </summary>
        public int FDCStockID { get { return _FDCStockID; } set { _FDCStockID = value; } }
        /// <summary>
        /// 制单人
        /// </summary>
        public int Fbiller { get { return _Fbiller; } set { _Fbiller = value; } }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal FQty { get { return _FQty; } set { _FQty = value; } }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal FPrice { get { return _FPrice; } set { _FPrice = value; } }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal FAmount { get { return _FAmount; } set { _FAmount = value; } }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime FDate { get { return _FDate; } set { _FDate = value; } }
    }
}
