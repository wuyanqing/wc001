using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Hardware
{
    public class C_IdCard
    {
        #region 私有变量
        private bool _Enable;
        private int _Serial, _BaudRate,_WeightType;
        private string _CardType;
        #endregion

        #region 公共方法
        /// <summary>
        /// 是否启用ID卡
        /// </summary>
        public bool Enable { get { return _Enable; } set { _Enable = value; }}
        /// <summary>
        /// 仪表串口
        /// </summary>
        public int Serial { get { return _Serial; } set { _Serial = value; }}
        /// <summary>
        /// 波特率
        /// </summary>
        public int BaudRate { get { return _BaudRate; } set { _BaudRate = value; }}
        /// <summary>
        /// 取重方式
        /// </summary>
        public int WeightType { get { return _WeightType; } set { _WeightType= value; } }
        /// <summary>
        /// 读卡器类型
        /// </summary>
        public string CardType { get { return _CardType; } set { _CardType = value; } }
        #endregion
    }
}
