using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Count
{
    public class D_StatProjectItemModel
    {
        #region 私有变量
        private string _Code, _StatCode, _OldStatCode;
        private int _Place;
        #endregion

        #region 公共变量
        /// <summary>
        /// 报表方案编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 汇总字段
        /// </summary>
        public string StatCode { get { return _StatCode; } set { _StatCode = value; } }
        /// <summary>
        ///显示位置
        /// </summary>
        public int Place { get { return _Place; } set { _Place = value; } }
        /// <summary>
        /// 需要修改的汇总字段
        /// </summary>
        public string OldStatCode { get { return _OldStatCode; } set { _OldStatCode = value; } }
        #endregion
    }
}
