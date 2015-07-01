using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Hardware
{
    public class C_Infrared
    {
        #region 私有变量
        private bool _Enable;
        private int _Infrared1, _Infrared2;
        #endregion

        #region 公共方法
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get { return _Enable; } set { _Enable = value; } }
        /// <summary>
        /// 红外一
        /// </summary>
        public int Infrared1 { get { return _Infrared1; } set { _Infrared1 = value; } }
        /// <summary>
        /// 红外二
        /// </summary>
        public int Infrared2 { get { return _Infrared2; } set { _Infrared2 = value; } }
        #endregion
    }
}
