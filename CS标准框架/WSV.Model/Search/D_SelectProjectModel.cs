using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Search
{
    public class D_SelectProjectModel
    {
        #region 私有变量
        private long _ID = 0;
        private string  _Code,_Name, _Type, _State,_Used;
        private bool _Verify;
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
        /// 方案名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// 数据库
        /// </summary>
        public string State { get { return _State; } set { _State = value; } }
        /// <summary>
        /// 状态
        /// </summary>
        public string Used { get { return _Used ; } set {_Used  = value; } }
        /// <summary>
        ///审核
        /// </summary>
        public bool Verify  { get { return _Verify ; } set { _Verify =true ; } }
        #endregion
    }
}
