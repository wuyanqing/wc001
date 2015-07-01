using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.User
{
    public class CUser
    {
        #region 私有变量
        private static long _ID;
        private static string _Code, _Uid, _Name, _Role, _TableNum, _TableName, _Ip, _Port;
        #endregion

        #region 公共方法
        /// <summary>
        /// ID
        /// </summary>
        public static long Id { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public static string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 用户名
        /// </summary>
        public static string Uid { get { return _Uid; } set { _Uid = value; } }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public static string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 角色编号
        /// </summary>
        public static string Role { get { return _Role; } set { _Role = value; } }
        /// <summary>
        /// 磅台号
        /// </summary>
        public static string TableNum { get { return _TableNum; } set { _TableNum = value; } }
        /// <summary>
        /// 磅台名称
        /// </summary>
        public static string TableName { get { return _TableName; } set { _TableName = value; } }
        /// <summary>
        /// 机器IP
        /// </summary>
        public static string Ip { get { return _Ip; } set { _Ip = value; } }
        /// <summary>
        /// 端口号
        /// </summary>
        public static string Port { get { return _Port; } set { _Port = value; } }
        #endregion
    }
}
