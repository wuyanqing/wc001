using System;
using System.Collections.Generic;
using System.Text;

namespace delivery
{
    public class RegistrationInfo
    {
        private string  name;//登记人姓名

        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        private string billno;//送货单号

        public string _billno
        {
            get { return billno; }
            set { billno = value; }
        }
        private string carcode;//车牌号

        public string _carcode
        {
            get { return carcode; }
            set { carcode = value; }
        }


        private string phone;//电话

        public string _phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private DateTime daytime;//时间

        public DateTime _daytime
        {
            get { return daytime; }
            set { daytime = value; }
        }

        private string state;//访问类型

        public string _state
        {
            get { return state; }
            set { state = value; }
        }

        private string memo;//备忘录

        public string _memo
        {
            get { return memo; }
            set { memo = value; }
        }

        private string port;//备忘录

        public string _port
        {
            get { return port; }
            set { port = value; }
        }
        private string address;//中烟信息（地址）
        public string _address
        {
            get { return address; }
            set { address = value; }
        }
        private string isSubmit;//是否提交订单
        public string _isSubmit
        {
            get { return isSubmit; }
            set { isSubmit = value; }
        }

        private string iswork;//是否开始卸货
        public string _iswork
        {
            get { return iswork; }
            set { iswork = value; }
        }
    }
}
