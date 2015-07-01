using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.User
{
    public class DC_Power
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name, _ParentCode,_RuleName,_Rank;
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
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 父类编号
        /// </summary>
        public string ParentCode { get { return _ParentCode; } set { _ParentCode = value; } }
        /// <summary>
        /// 模块名称
        /// </summary>
        public string RuleName { get { return _RuleName; } set { _RuleName= value; } }
        /// <summary>
        /// 级别
        /// </summary>
        public string Rank { get { return _Rank; } set { _Rank = value; } }
        #endregion
    }
}
