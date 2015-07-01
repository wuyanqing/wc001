using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model
{
    /// <summary>
    /// 主页面数据
    /// </summary>
    public class MainModel
    {
        #region 私有变量
        private int I_ID = 0;               //ID号
        private string S_Code = "";          //编号
        private string S_Item = "";          //货名
        private string S_CarCode = "";  //车号
        #endregion

        #region 公共变量
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get { return I_ID; } set { I_ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return S_Code; } set { S_Code = value; } }
        /// <summary>
        /// 货名
        /// </summary>
        public string Item { get { return S_Item; } set { S_Item = value; } }
        /// <summary>
        /// 车号
        /// </summary>
        public string CarCode { get { return S_CarCode; } set { S_CarCode = value; } }
        #endregion

        
    }

}
