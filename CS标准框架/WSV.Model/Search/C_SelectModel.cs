using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Search
{
    public class C_SelectModel
    {
        private long _ID;
        private int _Place;
        private string _As, _DBName;
        private bool _Show;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string As
        {
            get { return _As; }
            set { _As = value; }
        }
        public string DBName
        {
            get { return _DBName; }
            set { _DBName = value; }
        }
        public bool Show
        {
            get { return _Show; }
            set { _Show = value; }
        }
        public int Place
        {
            get { return _Place; }
            set { _Place = value; }
        }
    }
}
