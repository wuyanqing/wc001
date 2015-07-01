using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Record
{
    public class DC_BaseModel
    {
        #region 私有变量
        private long _ID = 0, _Rank;
        private string _Code, _Name, _AS, _Flag;
        #endregion

        #region 公共变量
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 别名代号
        /// </summary>
        public string AS { get { return _AS; } set { _AS = value; } }
        /// <summary>
        /// 标志
        /// </summary>
        public string Flag { get { return _Flag; } set { _Flag = value; } }
        /// <summary>
        /// 级别
        /// </summary>
        public long Rank { get { return _Rank; } set { _Rank = value; } }
        #endregion
    }
}
