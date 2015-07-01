using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.Hardware;

namespace WSV.BLL.Hardware
{
    public class RoadSluiceBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_RoadSluice Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.Enable = Convert.ToBoolean(Ini.IniReadValue("RoadSluice", "Enable"));
                    Item.RoadSluice1 = Convert.ToInt32(Ini.IniReadValue("RoadSluice", "RoadSluice1"));
                    Item.RoadSluice2 = Convert.ToInt32(Ini.IniReadValue("RoadSluice", "RoadSluice2"));
                    Item.WorkMode1 = Convert.ToInt32(Ini.IniReadValue("RoadSluice", "WorkMode1"));
                    Item.WorkMode2 = Convert.ToInt32(Ini.IniReadValue("RoadSluice", "WorkMode2"));
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
        public static bool Update(C_RoadSluice Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("RoadSluice", "Enable", Item.Enable);
                    Ini.IniWriteValue("RoadSluice", "RoadSluice1", Item.RoadSluice1);
                    Ini.IniWriteValue("RoadSluice", "RoadSluice2", Item.RoadSluice2);
                    Ini.IniWriteValue("RoadSluice", "WorkMode1", Item.WorkMode1);
                    Ini.IniWriteValue("RoadSluice", "WorkMode2", Item.WorkMode2);
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
