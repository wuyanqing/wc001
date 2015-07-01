using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class DC_BaseInfo
    {
        #region 私有变量
        private int _Id;
        private string _Company, _Address, _Tel, _PrintTitle="";
        #endregion

        #region 公共方法
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get { return _Id; } set { _Id= value; } }
        /// <summary>
        ///单位名称
        /// </summary>
        public string Company { get { return _Company; } set { _Company = value; } }
        /// <summary>
        ///单位地址
        /// </summary>
        public string Address { get { return _Address; } set { _Address = value; } }
        /// <summary>
        ///联系电话
        /// </summary>
        public string Tel { get { return _Tel; } set { _Tel = value; } }
        /// <summary>
        ///打印标题
        /// </summary>
        public string PrintTitle { get { return _PrintTitle; } set { _PrintTitle = value; } }
        #endregion
    }
}
