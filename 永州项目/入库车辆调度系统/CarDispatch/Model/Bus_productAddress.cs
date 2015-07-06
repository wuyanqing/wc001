using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Bus_productAddress
    {
        private string _address_code;
        private string _address_name;

        public string address_code
        {
            get { return _address_code; }
            set { _address_code = value; }
        }
        public string address_name
        {
            get { return _address_name; }
            set { _address_name = value; }
        }

    }
}
