using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    public class RegistrationInfo
    {
        private int id;//登记人姓名

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;//登记人姓名

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
        private string workstate;//工作状态
        public string _workstate
        {
            get { return workstate; }
            set { workstate = value; }
        }
    }
}