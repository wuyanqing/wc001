using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Record
{
    public class D_CubetyModel
    {
        private long _ID;
        private string _Code;
        private decimal _Cubety;

        /// <summary>
        /// ID
        /// </summary>
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 折方系数
        /// </summary>
        public decimal Cubety { get { return _Cubety; } set { _Cubety = value; } }
    }
}
