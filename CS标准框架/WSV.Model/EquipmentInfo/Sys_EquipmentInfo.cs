using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.EquipmentInfo
{
    public class Sys_EquipmentInfo
    {
        #region 私有变量
        private DateTime _EquipmentBuyTime, _EquipmentUseTime;
        private bool _IsWarranty, _IsUsed, _Isexist;
        private string _EquipmentCode, _Modelcode, _Specifications, _Functions, _SuppliersCode, _Position, _Effect, _EquipmentLevel;
        #endregion

        #region 公共方法
        /// <summary>
        /// 设备编号
        /// </summary>
        public string EquipmentCode { get { return _EquipmentCode; } set { _EquipmentCode = value; } }
        /// <summary>
        /// 型号编码
        /// </summary>
        public string Modelcode { get { return _Modelcode; } set { _Modelcode = value; } }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specifications { get { return _Specifications; } set { _Specifications = value; } }
        /// <summary>
        /// 功能
        /// </summary>
        public string Functions { get { return _Functions; } set { _Functions = value; } }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string SuppliersCode { get { return _SuppliersCode; } set { _SuppliersCode = value; } }
        /// <summary>
        /// 位置
        /// </summary>
        public string Position { get { return _Position; } set { _Position = value; } }
        /// <summary>
        /// 作用
        /// </summary>
        public string Effect { get { return _Effect; } set { _Effect = value; } }
        /// <summary>
        /// 是否质保期
        /// </summary>
        public bool IsWarranty { get { return _IsWarranty; } set { _IsWarrantyt = value; } }
        /// <summary>
        /// 是否正在使用
        /// </summary>
        public bool IsUsed { get { return _IsUsed; } set { _IsUsed = value; } }
        /// <summary>
        /// 是否本套设备
        /// </summary>
        public bool Isexist { get { return _Isexist; } set { _Isexist = value; } }
        /// <summary>
        /// 设备购买时间
        /// </summary>
        public DateTime EquipmentBuyTime { get { return _EquipmentBuyTime; } set { _EquipmentBuyTime = value; } }
        /// <summary>
        /// 设备启用时间
        /// </summary>
        public DateTime EquipmentUseTime { get { return _EquipmentUseTime; } set { _EquipmentUseTime = value; } }
        /// <summary>
        /// 设备重要等级
        /// </summary>
        public string EquipmentLevel { get { return _EquipmentLevel; } set { _EquipmentLevel = value; } }
        #endregion
    }
}
