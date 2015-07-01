using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Weight
{
    public class StateModel
    {
        #region 私有变量
        private string _G_Time = "", _T_Time = "", _N_Time = "", _Updata_Time = "", _Accepter = "";
        private string _G_Oper = "", _T_Oper = "", _Updata_Oper = "", _G_Table = "", _T_Table = "", _WeiWay = "";
        private bool _Used = false, _Verify = false, _State = false;
        private int _Print = 0, _Count = 0;
        private byte[] _G_Image1 = null, _G_Image2 = null, _G_Image3 = null, _G_Image4 = null;
        private byte[] _T_Image1 = null, _T_Image2 = null, _T_Image3 = null, _T_Image4 = null;
        private int _suality1 = 0, _suality2 = 0, _suality3 = 0, _suality4 = 0;
        private byte[] _Image1 = null, _Image2 = null, _Image3 = null, _Image4 = null, _Curve = null, _G_Curve = null, _T_Curve = null;
        #endregion
        #region 共有变量
        /// <summary>
        /// 毛时间
        /// </summary>
        public string G_Time { get { return _G_Time; } set { _G_Time = value; } }
        /// <summary>
        /// 皮时间
        /// </summary>
        public string T_Time { get { return _T_Time; } set { _T_Time = value; } }
        /// <summary>
        /// 净时间
        /// </summary>
        public string N_Time { get { return _N_Time; } set { _N_Time = value; } }
        /// <summary>
        /// 修改时间
        /// </summary>
        public string Updata_Time { get { return _Updata_Time; } set { _Updata_Time = value; } }
        /// <summary>
        /// 毛司磅员
        /// </summary>
        public string G_Oper { get { return _G_Oper; } set { _G_Oper = value; } }
        /// <summary>
        /// 皮司磅员
        /// </summary>
        public string T_Oper { get { return _T_Oper; } set { _T_Oper = value; } }
        /// <summary>
        /// 验收人
        /// </summary>
        public string Accepter { get { return _Accepter; } set { _Accepter = value; } }
        /// <summary>
        /// 修改人
        /// </summary>
        public string Updata_Oper { get { return _Updata_Oper; } set { _Updata_Oper = value; } }
        /// <summary>
        /// 毛磅台号
        /// </summary>
        public string G_Table { get { return _G_Table; } set { _G_Table = value; } }
        /// <summary>
        /// 皮磅台号
        /// </summary>
        public string T_Table { get { return _T_Table; } set { _T_Table = value; } }
        /// <summary>
        /// 称重方式
        /// </summary>
        public string WeiWay { get { return _WeiWay; } set { _WeiWay = value; } }
        /// <summary>
        /// 作废
        /// </summary>
        public bool Used { get { return _Used; } set { _Used = value; } }
        /// <summary>
        /// 审核
        /// </summary>
        public bool Verify { get { return _Verify; } set { _Verify = value; } }
        /// <summary>
        /// 数据状态
        /// </summary>
        public bool State { get { return _State; } set { _State = value; } }
        /// <summary>
        /// 打印次数
        /// </summary>
        public int Print { get { return _Print; } set { _Print = value; } }
        /// <summary>
        /// 车数
        /// </summary>
        public int Count { get { return _Count; } set { _Count = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] G_Image1 { get { return _G_Image1; } set { _G_Image1 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] G_Image2 { get { return _G_Image2; } set { _G_Image2 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] G_Image3 { get { return _G_Image3; } set { _G_Image3 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] G_Image4 { get { return _G_Image4; } set { _G_Image4 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] T_Image1 { get { return _T_Image1; } set { _T_Image1 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] T_Image2 { get { return _T_Image2; } set { _T_Image2 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] T_Image3 { get { return _T_Image3; } set { _T_Image3 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] T_Image4 { get { return _T_Image4; } set { _T_Image4 = value; } }
        /// <summary>
        /// 图片质量
        /// </summary>
        public int imagesuality1 { get { return _suality1; } set { _suality1 = value; } }
        /// <summary>
        /// 图片质量
        /// </summary>
        public int imagesuality2 { get { return _suality2; } set { _suality2 = value; } }
        /// <summary>
        /// 图片质量
        /// </summary>
        public int imagesuality3 { get { return _suality3; } set { _suality3 = value; } }
        /// <summary>
        /// 图片质量
        /// </summary>
        public int imagesuality4 { get { return _suality4; } set { _suality4 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] Image1 { get { return _Image1; } set { _Image1 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] Image2 { get { return _Image2; } set { _Image2 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] Image3 { get { return _Image3; } set { _Image3 = value; } }
        /// <summary>
        /// 监控图片
        /// </summary>
        public byte[] Image4 { get { return _Image4; } set { _Image4 = value; } }
        /// <summary>
        /// 上衡曲线
        /// </summary>
        public byte[] Curve { get { return _Curve; } set { _Curve = value; } }
        /// <summary>
        /// 上衡曲线
        /// </summary>
        public byte[] T_Curve { get { return _T_Curve; } set { _T_Curve = value; } }
        /// <summary>
        /// 上衡曲线
        /// </summary>
        public byte[] G_Curve { get { return _G_Curve; } set { _G_Curve = value; } }
        #endregion
    }
}
