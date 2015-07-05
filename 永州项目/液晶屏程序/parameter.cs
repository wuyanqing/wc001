using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class parameter
    {
        private int id;//登记人姓名

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        private string parameter_name;//登记人姓名

        public string _parameter_name
        {
            get { return parameter_name; }
            set { parameter_name = value; }
        }
        private string parameter_value;//送货单号

        public string _parameter_value
        {
            get { return parameter_value; }
            set { parameter_value = value; }
        }
        private string memo;//车牌号

        public string _memo
        {
            get { return memo; }
            set { memo = value; }
        }
    }
}
