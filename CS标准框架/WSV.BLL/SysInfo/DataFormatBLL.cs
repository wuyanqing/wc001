using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.SysInfo;

namespace WSV.BLL.SysInfo
{
    public class DataFormatBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_DataFormat Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.MoneyMode = Convert.ToInt32(Ini.IniReadValue("DataFormat", "MoneyMode"));
                    Item.EndNetMode = Convert.ToInt32(Ini.IniReadValue("DataFormat", "EndNetMode"));
                    Item.CodeRule = Convert.ToInt32(Ini.IniReadValue("DataFormat", "CodeRule"));
                    Item.CodeWay = Convert.ToInt32(Ini.IniReadValue("DataFormat", "CodeWay"));
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
        public static bool Update(C_DataFormat Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("DataFormat", "MoneyMode", Item.MoneyMode);
                    Ini.IniWriteValue("DataFormat", "EndNetMode", Item.EndNetMode);
                    Ini.IniWriteValue("DataFormat", "CodeRule", Item.CodeRule);
                    Ini.IniWriteValue("DataFormat", "CodeWay", Item.CodeWay);
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
