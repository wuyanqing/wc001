using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Plan
{
    public class D_Plan
    {
        private long _ID;
        private string _Plan_Code, _Plan_Type, _Plan_Item, _Plan_Specs, _Plan_Send, _Plan_Accept, _Remark, _Plan_CountWay, _Begin_Time, _End_Time;
        private decimal _Plan_Num, _Plan_SpareNum, _Plan_Money, _Plan_SpareMoney;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Plan_Code
        {
            get { return _Plan_Code; }
            set { _Plan_Code = value; }
        }
        public string Plan_Type
        {
            get { return _Plan_Type; }
            set { _Plan_Type = value; }
        }
        public string Plan_Item
        {
            get { return _Plan_Item; }
            set { _Plan_Item = value; }
        }
        public string Plan_Specs
        {
            get { return _Plan_Specs; }
            set { _Plan_Specs = value; }
        }
        public string Plan_Send
        {
            get { return _Plan_Send; }
            set { _Plan_Send = value; }
        }
        public string Plan_Accept
        {
            get { return _Plan_Accept; }
            set { _Plan_Accept = value; }
        }
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        public string Plan_CountWay
        {
            get { return _Plan_CountWay; }
            set { _Plan_CountWay = value; }
        }
        public decimal Plan_Num
        {
            get { return _Plan_Num; }
            set { _Plan_Num = value; }
        }
        public decimal Plan_SpareNum
        {
            get { return _Plan_SpareNum; }
            set { _Plan_SpareNum = value; }
        }
        public decimal Plan_Money
        {
            get { return _Plan_Money; }
            set { _Plan_Money = value; }
        }
        public decimal Plan_SpareMoney
        {
            get { return _Plan_SpareMoney; }
            set { _Plan_SpareMoney = value; }
        }
        public string Begin_Time
        {
            get { return _Begin_Time; }
            set { _Begin_Time = value; }
        }
        public string End_Time
        {
            get { return _End_Time; }
            set { _End_Time = value; }
        }
    }
}
