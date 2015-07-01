using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Record
{
    public class D_BaseModel
    {
        #region 私有变量
        private long _ID = 0, _Rank;
        private string _CodeID, _Name, _Rem, _ParentCode;
        #endregion

        #region 公共变量
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string CodeID { get { return _CodeID; } set { _CodeID = value; } }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 简码
        /// </summary>
        public string Rem { get { return _Rem; } set { _Rem = value; } }
        /// <summary>
        /// 父类编号
        /// </summary>
        public string ParentCode { get { return _ParentCode; } set { _ParentCode = value; } }
        /// <summary>
        /// 级别
        /// </summary>
        public long Rank { get { return _Rank; } set { _Rank = value; } }
        #endregion
    }
}
