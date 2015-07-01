using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Control.MyListItem
{
    public class ListItem
    {
        private object _text, _value;
        public object text
        {
            set { _text = value; }
            get { return _text; }
        }
        public object value
        {
            set { _value = value; }
            get { return _value; }
        }
        public ListItem()
        {

        }
        public ListItem(object text, object value)
        {
            this._text = text;
            this._value = value;
        }
    }
}
