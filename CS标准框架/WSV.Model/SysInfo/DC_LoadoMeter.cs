using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class DC_LoadoMeter
    {
        #region 私有变量
        private long _ID;
        private string _TableNum, _Name, _Ip,_Port,_Remark;
        #endregion

        #region 公共方法
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 磅台号
        /// </summary>
        public string TableNum { get { return _TableNum; } set { _TableNum= value; } }
        /// <summary>
        /// 磅台名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 机器IP
        /// </summary>
        public string Ip { get { return _Ip; } set { _Ip= value; } }
        /// <summary>
        /// 端口号
        /// </summary>
        public string Port { get { return _Port; } set { _Port = value; } }
        /// <summary>
        ///备注
        /// </summary>
        public string Remark{ get { return _Remark; } set { _Remark= value; } }
        #endregion
    }
}
