using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class C_DataFormat
    {
        #region 私有变量
        private int _MoneyMode, _EndNetMode,_CodeRule,_CodeWay;
        #endregion

        #region 公共方法
        /// <summary>
        /// 金额得到方式
        /// </summary>
        public int MoneyMode { get { return _MoneyMode; } set { _MoneyMode= value; } }
        /// <summary>
        /// 结算净重得到方式
        /// </summary>
        public int EndNetMode { get { return _EndNetMode; } set { _EndNetMode= value; } }
        /// <summary>
        /// 序号编码规则
        /// </summary>
        public int CodeRule { get { return _CodeRule; } set { _CodeRule= value; } }
        /// <summary>
        /// 序号生成方式
        /// </summary>
        public int CodeWay { get { return _CodeWay; } set { _CodeWay = value; } }
        #endregion
    }
}
