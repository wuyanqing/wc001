using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class C_Weight
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name;
        private int _Time, _X, _Y;
        private bool _Save, _Show;
        #endregion

        #region 公共方法
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 别名
        /// </summary>
        public string Name { get { return _Name; } set { _Name= value; } }
        /// <summary>
        /// 是否保留
        /// </summary>
        public bool Save { get { return _Save; } set { _Save= value; } }
        /// <summary>
        /// 是否必选
        /// </summary>
        public bool Show { get { return _Show; } set { _Show = value; } }
        /// <summary>
        /// 第几次使用
        /// </summary>
        public int Time{ get { return _Time; } set { _Time= value; } }
        /// <summary>
        /// X坐标
        /// </summary>
        public int X{ get { return _X; } set {_X= value; } }
        /// <summary>
        /// Y坐标
        /// </summary>
        public int Y { get { return _Y; } set { _Y = value; } }
        #endregion
    }
}
