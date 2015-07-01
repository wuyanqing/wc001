using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Record
{
    public class D_TypeModel
    {
        private long _ID;
        private string _Code, _Name;

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
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
