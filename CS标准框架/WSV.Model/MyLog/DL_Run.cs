using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.MyLog
{
    public class DL_Run
    {
        #region 私有变量
        private float _ID;
        private string _Code;
        private string _Work;
        private DateTime _InTime;
        private DateTime _OutTime;
        private string _OperCode;
        private string _TableNum;
        private string _IP;
        private string _Option;
        #endregion
        #region 公共变量
        public float ID { get { return _ID; } set { _ID = value; } }
        public string Code { get { return _Code; } set { _Code = value; } }
        public string Work { get { return _Work; } set { _Work = value; } }
        public DateTime InTime { get { return _InTime; } set { _InTime = value; } }
        public DateTime OutTime { get { return _OutTime; } set { _OutTime = value; } }
        public string OperCode { get { return _OperCode; } set { _OperCode = value; } }
        public string TableNum { get { return _TableNum; } set { _TableNum = value; } }
        public string IP { get { return _IP; } set { _IP = value; } }
        public string Option { get { return _Option; } set { _Option = value; } }
        #endregion
    }
}
