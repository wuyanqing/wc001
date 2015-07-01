using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.MyLog
{
    public class DL_Maintenance
    {
        private long _ID;
        private string _Code, _WorkCode, _SaverCode, _OperCode, _TableNum;
        private DateTime _DT;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string SaverCode
        {
            get { return _SaverCode; }
            set { _SaverCode = value; }
        }
        public string WorkCode
        {
            get { return _WorkCode; }
            set { _WorkCode = value; }
        }
        public string OperCode
        {
            get { return _OperCode; }
            set { _OperCode = value; }
        }
        public string TableNum
        {
            get { return _TableNum; }
            set { _TableNum = value; }
        }
        public DateTime DT
        {
            get { return _DT; }
            set { _DT = value; }
        }
    }
}
