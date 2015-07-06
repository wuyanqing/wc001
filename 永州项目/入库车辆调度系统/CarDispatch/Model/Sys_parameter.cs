using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Sys_parameter
    {
        private int _id;
        private string _parameter_name;
        private string _parameter_value;
        private string _memo;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string parameter_name
        {
            get { return _parameter_name; }
            set { _parameter_name = value; }
        }
        public string parameter_value
        {
            get { return _parameter_value; }
            set { _parameter_value = value; }
        }
        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
    }
}
