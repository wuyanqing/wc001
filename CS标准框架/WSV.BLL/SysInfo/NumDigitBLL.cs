using System;
using System.Collections.Generic;
using System.Text;
using WSV.Model.SysInfo;

namespace WSV.BLL.SysInfo
{
    public class NumDigitBLL
    {
        #region 显示信息
        /// <summary>
        /// 显示信息
        /// </summary>
        /// <returns>返回数据源</returns>
        public static void DataShow(C_NumDigit Item)
        {
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Item.GrossDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "GrossDigit"));
                    Item.GrossRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "GrossRound"));
                    Item.TareDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "TareDigit"));
                    Item.TareRound= Convert.ToInt32(Ini.IniReadValue("NumDigit", "TareRound"));
                    Item.NetDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "NetDigit"));
                    Item.NetRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "NetRound"));
                    Item.DeductWeightDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "DeductWeightDigit"));
                    Item.DeductWeightRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "DeductWeightRound"));
                    Item.DeductRateDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "DeductRateDigit"));
                    Item.DeductRateRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "DeductRateRound"));
                    Item.EndNetDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "EndNetDigit"));
                    Item.EndNetRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "EndNetRound"));
                    Item.PriceDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "PriceDigit"));
                    Item.PriceRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "PriceRound"));
                    Item.MoneyDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "MoneyDigit"));
                    Item.MoneyRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "MoneyRound"));
                    Item.CubeDigit = Convert.ToInt32(Ini.IniReadValue("NumDigit", "CubeDigit"));
                    Item.CubeRound = Convert.ToInt32(Ini.IniReadValue("NumDigit", "CubeRound"));
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
        public static bool Update(C_NumDigit Item)
        {
            bool Flag = false;
            try
            {
                PublicFun.IniFile Ini = new PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {                 
                    Ini.IniWriteValue("NumDigit", "GrossDigit", Item.GrossDigit);
                    Ini.IniWriteValue("NumDigit", "GrossRound", Item.GrossRound);
                    Ini.IniWriteValue("NumDigit", "TareDigit", Item.TareDigit);
                    Ini.IniWriteValue("NumDigit", "TareRound", Item.TareRound);
                    Ini.IniWriteValue("NumDigit", "NetDigit", Item.NetDigit);
                    Ini.IniWriteValue("NumDigit", "NetRound", Item.NetRound);
                    Ini.IniWriteValue("NumDigit", "DeductWeightDigit", Item.DeductWeightDigit);
                    Ini.IniWriteValue("NumDigit", "DeductWeightRound", Item.DeductWeightRound);
                    Ini.IniWriteValue("NumDigit", "DeductRateDigit", Item.DeductRateDigit);
                    Ini.IniWriteValue("NumDigit", "DeductRateRound", Item.DeductRateRound);
                    Ini.IniWriteValue("NumDigit", "EndNetDigit", Item.EndNetDigit);
                    Ini.IniWriteValue("NumDigit", "EndNetRound", Item.EndNetRound);
                    Ini.IniWriteValue("NumDigit", "PriceDigit", Item.PriceDigit);
                    Ini.IniWriteValue("NumDigit", "PriceRound", Item.PriceRound);
                    Ini.IniWriteValue("NumDigit", "MoneyDigit", Item.MoneyDigit);
                    Ini.IniWriteValue("NumDigit", "MoneyRound", Item.MoneyRound);
                    Ini.IniWriteValue("NumDigit", "CubeDigit", Item.CubeDigit);
                    Ini.IniWriteValue("NumDigit", "CubeRound", Item.CubeRound);
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
