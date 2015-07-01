using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.Hardware;

namespace WSV.BLL.Hardware
{
    public class InfraredBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_Infrared Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Enable = Convert.ToBoolean(Ini.IniReadValue("Infrared", "Enable"));
                    Item.Infrared1 = Convert.ToInt32(Ini.IniReadValue("Infrared", "Infrared1"));
                    Item.Infrared2 = Convert.ToInt32(Ini.IniReadValue("Infrared", "Infrared2"));
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
        public static bool Update(C_Infrared Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("Infrared", "Enable", Item.Enable);
                    Ini.IniWriteValue("Infrared", "Infrared1", Item.Infrared1);
                    Ini.IniWriteValue("Infrared", "Infrared2", Item.Infrared2);
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
