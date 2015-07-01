using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model.Weight
{
    public class TxtModel
    {
        #region 私有变量
        private string _CarCode = "", _Item = "", _Specs = "", _Place = "", _Send = "", _Accept = "", _IdCard = "";
        private string _Carry = "", _Model = "", _Driver = "", _Spare = "", _Type = "", _Card = "", _Name = "", _Plan_Code = "";
        #endregion

        #region 共有变量
        /// <summary>
        /// 车号
        /// </summary>
        public string CarCode { get { return _CarCode; } set { _CarCode = value; } }
        /// <summary>
        /// 货名
        /// </summary>
        public string Item { get { return _Item; } set { _Item = value; } }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specs { get { return _Specs; } set { _Specs = value; } }
        /// <summary>
        /// 库位
        /// </summary>
        public string Place { get { return _Place; } set { _Place = value; } }
        /// <summary>
        /// 发货单位
        /// </summary>
        public string Send { get { return _Send; } set { _Send = value; } }
        /// <summary>
        /// 收货单位
        /// </summary>
        public string Accept { get { return _Accept; } set { _Accept = value; } }
        /// <summary>
        /// 承运单位
        /// </summary>
        public string Carry { get { return _Carry; } set { _Carry = value; } }
        /// <summary>
        /// 车型
        /// </summary>
        public string Model { get { return _Model; } set { _Model = value; } }
        /// <summary>
        /// 司机
        /// </summary>
        public string Driver { get { return _Driver; } set { _Driver = value; } }
        /// <summary>
        /// 备用
        /// </summary>
        public string Spare { get { return _Spare; } set { _Spare = value; } }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Card { get { return _Card; } set { _Card = value; } }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }
        /// <summary>
        /// 货物编号
        /// </summary>
        public string IdCard { get { return _IdCard; } set { _IdCard = value; } }
        /// <summary>
        /// 计划编号
        /// </summary>
        public string Plan_Code { get { return _Plan_Code; } set { _Plan_Code = value; } }
        #endregion
    }
}
