using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.User
{
    public class D_UserRole
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name, _ParentCode,_RolePower;
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
        /// 角色编号
        /// </summary>
        public string RolePower { get { return _RolePower; } set { _RolePower = value; } }
        #endregion
    }
}
