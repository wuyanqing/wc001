using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.BLL.Hardware
{
    public class RfidBll
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(Model.Hardware.C_Rfid Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Enable = Convert.ToBoolean(Ini.IniReadValue("Rfid", "Enable"));
                    Item.Serial = Convert.ToInt32(Ini.IniReadValue("Rfid", "Serial"));
                    Item.BaudRate = Convert.ToInt32(Ini.IniReadValue("Rfid", "BaudRate"));
                    Item.WeightType = Convert.ToInt32(Ini.IniReadValue("Rfid", "WeightType"));
                    Item.RfidType = Ini.IniReadValue("Rfid", "RfidType");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="Item">model</param>
        /// <returns></returns>
        public static bool Update(Model.Hardware.C_Rfid Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("Rfid", "Enable", Item.Enable);
                    Ini.IniWriteValue("Rfid", "Serial", Item.Serial);
                    Ini.IniWriteValue("Rfid", "BaudRate", Item.BaudRate);
                    Ini.IniWriteValue("Rfid", "WeightType", Item.WeightType);
                    Ini.IniWriteValue("Rfid", "RfidType", Item.RfidType);
                }
                Flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Flag;
        }
        #endregion
    }
}
