using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.SysInfo;

namespace WSV.BLL.SysInfo
{
    public class SystemLoadBLL
    {
         #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(Ini_SystemLodad Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Displaytype = Convert.ToInt32(Ini.IniReadValue("systemload", "Displaytype"));
                    Item.Tranimage = Convert.ToInt32(Ini.IniReadValue("systemload", "Tranimage"));
                    Item.Trantime = Convert.ToInt32(Ini.IniReadValue("systemload", "Trantime"));
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
        public static bool Update(Ini_SystemLodad Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("systemload", "Displaytype", Item.Displaytype);
                    Ini.IniWriteValue("systemload", "Tranimage", Item.Tranimage);
                    Ini.IniWriteValue("systemload", "Trantime", Item.Trantime);
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
