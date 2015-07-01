using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.SysInfo
{
    public class Ini_SystemLodad
    {
        private int _Displaytype, _Tranimage, _Trantime;
        
        public int Displaytype
        {
            get { return _Displaytype; }
            set { _Displaytype = value; }
        }
        public int Tranimage
        {
            get { return _Tranimage; }
            set { _Tranimage = value; }
        }
        public int Trantime
        {
            get { return _Trantime; }
            set { _Trantime = value; }
        }
    }
}
