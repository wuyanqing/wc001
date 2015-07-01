using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.User
{
    public class D_User
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name, _Uid, _OldPwd, _Pwd, _CheckPwd, _Role;
        private bool _Used;
        #endregion

        #region 公共方法
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code= value; } }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Uid { get { return _Uid; } set { _Uid = value; } }
        /// <summary>
        /// 原始密码
        /// </summary>
        public string OldPwd{get { return _OldPwd; }set { _OldPwd = value; }}
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get { return _Pwd; } set { _Pwd = value; } }
        /// <summary>
        /// 确认密码
        /// </summary>
        public string CheckPwd { get { return _CheckPwd; } set { _CheckPwd = value; } }
        /// <summary>
        /// 角色编号
        /// </summary>
        public string Role { get { return _Role; } set { _Role = value; } }
        /// <summary>
        /// 状态
        /// </summary>
        public bool Used { get { return _Used; } set { _Used = value; } }
        #endregion
    }
}
