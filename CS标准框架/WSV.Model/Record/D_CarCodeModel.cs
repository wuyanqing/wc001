using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Record
{
    public class D_CarCodeModel
    {
        private long _ID;
        private float _Tare;
        private string _Code, _CarCode, _Driver;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public float Tare
        {
            get { return _Tare; }
            set { _Tare = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string CarCode
        {
            get { return _CarCode; }
            set { _CarCode = value; }
        }
        public string Driver
        {
            get { return _Driver; }
            set { _Driver = value; }
        }
    }
}
