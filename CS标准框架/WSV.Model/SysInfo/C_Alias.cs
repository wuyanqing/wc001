using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class C_Alias
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name, _RuleName,_DbName,_DataType;
        private bool _State;
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
        /// 程序中使用的名称
        /// </summary>
        public string RuleName { get { return _RuleName; } set { _RuleName= value; } }
        /// <summary>
        /// 数据库中的名称
        /// </summary>
        public string DBName { get { return _DbName; } set { _DbName= value; } }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get {return _DataType; } set {_DataType= value; } }
        /// <summary>
        /// 是否使用
        /// </summary>
        public bool State { get { return _State; } set { _State= value; } }
        #endregion
    }
}
