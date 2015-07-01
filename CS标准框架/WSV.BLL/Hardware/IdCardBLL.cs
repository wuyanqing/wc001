using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.Hardware;

namespace WSV.BLL.Hardware
{
    public class IdCardBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_IdCard Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Enable =Convert.ToBoolean(Ini.IniReadValue("IdCard", "Enable"));
                    Item.Serial = Convert.ToInt32(Ini.IniReadValue("IdCard", "Serial"));
                    Item.BaudRate = Convert.ToInt32(Ini.IniReadValue("IdCard", "BaudRate"));
                    Item.WeightType = Convert.ToInt32(Ini.IniReadValue("IdCard", "WeightType"));
                    Item.CardType =Ini.IniReadValue("IdCard", "CardType");
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
        public static bool Update(C_IdCard Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("IdCard", "Enable", Item.Enable);
                    Ini.IniWriteValue("IdCard", "Serial", Item.Serial);
                    Ini.IniWriteValue("IdCard", "BaudRate", Item.BaudRate);
                    Ini.IniWriteValue("IdCard", "WeightType", Item.WeightType);
                    Ini.IniWriteValue("IdCard", "CardType", Item.CardType);
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
