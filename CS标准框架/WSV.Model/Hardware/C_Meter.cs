using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Hardware
{
    public class C_Meter
    {
        #region 私有变量
        private int _Serial, _BaudRate, _FullBalance, _Digit;
        private float _DetectStart;
        private string _MeterType, _Unit;
        #endregion

        #region 公共方法
        /// <summary>
        /// 仪表串口
        /// </summary>
        public int Serial { get { return _Serial; } set { _Serial= value; } }
        /// <summary>
        /// 仪表类型
        /// </summary>
        public string MeterType { get { return _MeterType; } set { _MeterType= value; } }
        /// <summary>
        /// 波特率
        /// </summary>
        public int BaudRate { get { return _BaudRate; } set { _BaudRate= value; } }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Unit { get { return _Unit; } set { _Unit= value; } }
        /// <summary>
        /// 检测起点
        /// </summary>
        public float DetectStart { get {return _DetectStart; } set {_DetectStart= value; } }
        /// <summary>
        /// 最大秤值
        /// </summary>
        public int FullBalance {get {return _FullBalance; } set { _FullBalance= value; } }
        /// <summary>
        /// 小数位数
        /// </summary>
        public int Digit { get { return _Digit; } set { _Digit= value; } }
        #endregion
    }
}
