using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Hardware
{
    public class C_RoadSluice
    {
        #region 私有变量
        private bool _Enable;
        private int _RoadSluice1, _RoadSluice2,_WorkMode1,_WorkMode2;
        #endregion

        #region 公共方法
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get { return _Enable; } set { _Enable = value; } }
        /// <summary>
        /// 道闸初始关
        /// </summary>
        public int RoadSluice1 { get { return _RoadSluice1; } set { _RoadSluice1 = value; } }
        /// <summary>
        /// 道闸初始开
        /// </summary>
        public int RoadSluice2 { get { return _RoadSluice2; } set { _RoadSluice2 = value; } }
        /// <summary>
        /// 道闸一工作方式
        /// </summary>
        public int WorkMode1 { get { return _WorkMode1; } set { _WorkMode1= value; } }
        /// <summary>
        /// 道闸二工作方式
        /// </summary>
        public int WorkMode2 { get { return _WorkMode2; } set { _WorkMode2 = value; } }
        #endregion
    }
}
