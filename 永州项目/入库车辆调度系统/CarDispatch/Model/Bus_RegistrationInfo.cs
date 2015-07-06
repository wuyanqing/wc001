using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Bus_RegistrationInfo
    {
        private int _id;
        private string _name;
        private string _brandno;
        private string _carcode;
        private string _phone;
        private DateTime _daytime;
        private string _state;
        private string _memo;
        private string _port;
        private string _address_code;
        private string _workstate;


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string brandno
        {
            get { return _brandno; }
            set { _brandno = value; }
        }
        public string carcode
        {
            get { return _carcode; }
            set { _carcode = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime daytime
        {
            get { return _daytime; }
            set { _daytime = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        public string port
        {
            get { return _port; }
            set { _port = value; }
        }
        public string address_code
        {
            get { return _address_code; }
            set { _address_code = value; }
        }
        public string workstate
        {
            get { return _workstate; }
            set { _workstate = value; }
        }
    }
}
