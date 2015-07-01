using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Count
{
    public class D_StatProjectModel
    {
        #region 私有变量
        private long _ID = 0;
        private string _Code, _Name, _Type, _SataType, _Flag, _Month, _Day,_BeginTime, _EndTime;
        #endregion

        #region 公共变量
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// 报表类型
        /// </summary>
        public string SataType { get { return _SataType; } set { _SataType = value; } }
        /// <summary>
        /// 开始日期
        /// </summary>
        public string Flag { get { return _Flag; } set { _Flag = value; } }
        /// </summary>
        /// 开始月份
        /// </summary>
        public string Month { get { return _Month; } set { _Month = value; } }
        /// </summary>
        /// 开始日期
        /// </summary>
        public string Day { get { return _Day; } set { _Day = value; } }
        /// </summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// </summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }
        #endregion
    }
}
