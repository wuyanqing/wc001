using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using WSV;


namespace WSV.Model.Weight
{
    public class WeightModel
    {
        #region 私有变量
        private long _ID;
        private string _Code = "";
        private TxtModel _Txt=new TxtModel();
        private NumModel _Float=new NumModel();
        private StateModel _StateFun = new StateModel();
       // private static long Add;
        #endregion
        #region 共有变量
        public long ID { get { return _ID; } set { _ID = value; } }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get { return _Code; } set { _Code = value; } }
        /// <summary>
        /// 字段型
        /// </summary>
        public TxtModel Txt { get { return _Txt; } set { _Txt = value; } }
        /// <summary>
        /// 数值型
        /// </summary>
        public NumModel Float { get { return _Float; } set { _Float = value; } }
        /// <summary>
        /// 状态
        /// </summary>
        public StateModel StateFun { get { return _StateFun; } set { _StateFun = value; } }
        #endregion
      
      
    }
}
