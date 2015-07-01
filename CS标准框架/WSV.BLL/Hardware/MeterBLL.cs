using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.Hardware;

namespace WSV.BLL.Hardware
{
    public class MeterBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_Meter Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Serial =Convert.ToInt32(Ini.IniReadValue("Meter", "Serial"));
                    Item.MeterType = Ini.IniReadValue("Meter", "MeterType");
                    Item.BaudRate =Convert.ToInt32(Ini.IniReadValue("Meter", "BaudRate"));
                    Item.Unit = Ini.IniReadValue("Meter", "Unit");
                    Item.DetectStart =Convert.ToSingle(Ini.IniReadValue("Meter", "DetectStart"));
                    Item.FullBalance =Convert.ToInt32(Ini.IniReadValue("Meter", "FullBalance"));
                    Item.Digit =Convert.ToInt32(Ini.IniReadValue("Meter","Digit"));
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
        public static bool Update(C_Meter Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("Meter", "Serial", Item.Serial);
                    Ini.IniWriteValue("Meter", "MeterType", Item.MeterType);
                    Ini.IniWriteValue("Meter", "BaudRate", Item.BaudRate);
                    Ini.IniWriteValue("Meter", "Unit", Item.Unit);
                    Ini.IniWriteValue("Meter", "DetectStart", Item.DetectStart);
                    Ini.IniWriteValue("Meter", "FullBalance", Item.FullBalance);
                    Ini.IniWriteValue("Meter", "Digit", Item.Digit);
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
