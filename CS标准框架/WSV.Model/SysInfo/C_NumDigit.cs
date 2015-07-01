using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class C_NumDigit
    {
        #region 私有变量
        private int _GrossDigit, _GrossRound, _TareDigit, _TareRound, _NetDigit, _NetRound, _DeductWeightDigit, _DeductWeightRound, _DeductRateDigit, _DeductRateRound, _EndNetDigit, _EndNetRound, _PriceDigit, _PriceRound, _MoneyDigit, _MoneyRound,_CubeDigit, _CubeRound;
        #endregion

        #region 公共方法
        /// <summary>
        /// 毛重精确位数
        /// </summary>
        public int GrossDigit { get { return _GrossDigit; } set { _GrossDigit= value; }}
        /// <summary>
        /// 毛重取数方式
        /// </summary>
        public int GrossRound{ get { return _GrossRound; } set { _GrossRound= value; }}
        /// <summary>
        /// 皮重精确位数
        /// </summary>
        public int TareDigit {get { return _TareDigit; } set {_TareDigit= value; }}
        /// <summary>
        /// 皮重取数方式
        /// </summary>
        public int TareRound {get { return _TareRound; } set { _TareRound= value; }}
        /// <summary>
        /// 净重精确位数
        /// </summary>
        public int NetDigit {get { return _NetDigit; } set { _NetDigit= value; } }
        /// <summary>
        /// 净重取数方式
        /// </summary>
        public int NetRound{get { return _NetRound; } set { _NetRound= value; } }
        /// <summary>
        /// 扣重精确位数
        /// </summary>
        public int DeductWeightDigit { get { return _DeductWeightDigit; } set { _DeductWeightDigit= value; } }
        /// <summary>
        /// 扣重取数方式
        /// </summary>
        public int DeductWeightRound { get { return _DeductWeightRound; } set { _DeductWeightRound= value; } }
        /// <summary>
        /// 扣率精确位数
        /// </summary>
        public int DeductRateDigit { get { return _DeductRateDigit; } set { _DeductRateDigit = value; } }
        /// <summary>
        /// 扣率取数方式
        /// </summary>
        public int DeductRateRound { get { return _DeductRateRound; } set { _DeductRateRound= value; } }
        /// <summary>
        /// 结算净重精确位数
        /// </summary>
        public int EndNetDigit { get { return _EndNetDigit; } set { _EndNetDigit= value; } }
        /// <summary>
        /// 结算净重取数方式
        /// </summary>
        public int EndNetRound { get { return _EndNetRound; } set { _EndNetRound= value; } }
        /// <summary>
        /// 单价精确位数
        /// </summary>
        public int PriceDigit { get { return _PriceDigit; } set { _PriceDigit= value; } }
        /// <summary>
        /// 单价取数方式
        /// </summary>
        public int PriceRound { get { return _PriceRound; } set { _PriceRound= value; } }
        /// <summary>
        /// 金额精确位数
        /// </summary>
        public int MoneyDigit { get { return _MoneyDigit; } set { _MoneyDigit= value; } }
        /// <summary>
        /// 金额取数方式
        /// </summary>
        public int MoneyRound { get { return _MoneyRound; } set { _MoneyRound= value; } }
        /// <summary>
        /// 折方精确位数
        /// </summary>
        public int CubeDigit { get { return _CubeDigit; } set { _CubeDigit = value; } }
        /// <summary>
        /// 折方取数方式
        /// </summary>
        public int CubeRound { get { return _CubeRound; } set { _CubeRound = value; } }
        #endregion
    }
}
