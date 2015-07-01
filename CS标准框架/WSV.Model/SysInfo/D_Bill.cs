using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class D_Bill
    {
        #region 私有变量
        private long _ID;
        private string _Code, _Name, _BillName, _PrintTitle;
        private bool _Preview;
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
        /// 磅单名称
        /// </summary>
        public string BillName { get { return _BillName; } set { _BillName= value; } }
        /// <summary>
        /// 打印标题
        /// </summary>
        public string PrintTitle { get { return _PrintTitle; } set { _PrintTitle= value; } }
        /// <summary>
        /// 是否预览
        /// </summary>
        public bool Preview { get { return _Preview; } set { _Preview= value; } }
        #endregion
    }
}
