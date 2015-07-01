using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace WSV.BaseClass
{
    public class Function
    {
        #region Md5加密方法
        /// <summary>
        /// Md5加密方法
        /// </summary>
        /// <param name="pwd">需要加密码的字符串</param>
        /// <returns>返加一个加密过的字符串</returns>
        public static string Md5(string pwd)
        {
            ///获取Byte数组
            Byte[] clearBytes = new UnicodeEncoding().GetBytes(pwd);
            ///获取Hash值
            Byte[] hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);

            ///获取加密后的信息
            return BitConverter.ToString(hashedBytes).Replace("-", "");
        }
        #endregion

        #region 检查是否符合正则
        /// <summary>
        /// 检查是否符合正则
        /// </summary>
        /// <param name="RegExValue">正则表达式</param>
        /// <param name="ItemValue">需要验证的字符串</param>
        /// <returns>返回真说明通过验证，否则不符合正则</returns>
        public static bool IsRegEx(string RegExValue,object ItemValue)
        {
            bool Flag = false;
            Regex regex = new Regex(RegExValue);
            if (regex.IsMatch(ItemValue.ToString())) {Flag = true; }
            return Flag;
        }
        #endregion

        #region 根据中文产生助记码
        /// <summary>
        /// 根据中文产生助记码
        /// </summary>
        /// <param name="ChineseStr">中文</param>
        /// <returns>返回助记码</returns>
        public static string VailCode(string ChineseStr)
        {
            byte[] ZW = new byte[2];
            long ChineseStr_int;
            string Capstr = "", ChinaStr = "";
            for (int i = 0; i < ChineseStr.Length; i++)
            {
                ZW = System.Text.Encoding.Default.GetBytes(ChineseStr.Substring(i, 1).ToString());
                if (ZW.Length == 2)
                {
                    int i1 = (short)(ZW[0]);
                    int i2 = (short)(ZW[1]);
                    ChineseStr_int = i1 * 256 + i2;

                    if ((ChineseStr_int >= 45217) && (ChineseStr_int <= 45252))
                    {
                        ChinaStr = "A";
                    }
                    else if ((ChineseStr_int >= 45253) && (ChineseStr_int <= 45760))
                    {
                        ChinaStr = "B";
                    }
                    else if ((ChineseStr_int >= 45761) && (ChineseStr_int <= 46317))
                    {
                        ChinaStr = "C";

                    }
                    else if ((ChineseStr_int >= 46318) && (ChineseStr_int <= 46825))
                    {
                        ChinaStr = "D";
                    }
                    else if ((ChineseStr_int >= 46826) && (ChineseStr_int <= 47009))
                    {
                        ChinaStr = "E";
                    }
                    else if ((ChineseStr_int >= 47010) && (ChineseStr_int <= 47296))
                    {
                        ChinaStr = "F";
                    }
                    else if ((ChineseStr_int >= 47297) && (ChineseStr_int <= 47613))
                    {
                        ChinaStr = "G";
                    }
                    else if ((ChineseStr_int >= 47614) && (ChineseStr_int <= 48118))
                    {

                        ChinaStr = "H";
                    }

                    else if ((ChineseStr_int >= 48119) && (ChineseStr_int <= 49061))
                    {
                        ChinaStr = "J";
                    }
                    else if ((ChineseStr_int >= 49062) && (ChineseStr_int <= 49323))
                    {
                        ChinaStr = "K";
                    }
                    else if ((ChineseStr_int >= 49324) && (ChineseStr_int <= 49895))
                    {
                        ChinaStr = "L";
                    }
                    else if ((ChineseStr_int >= 49896) && (ChineseStr_int <= 50370))
                    {
                        ChinaStr = "M";
                    }

                    else if ((ChineseStr_int >= 50371) && (ChineseStr_int <= 50613))
                    {
                        ChinaStr = "N";

                    }
                    else if ((ChineseStr_int >= 50614) && (ChineseStr_int <= 50621))
                    {
                        ChinaStr = "O";
                    }
                    else if ((ChineseStr_int >= 50622) && (ChineseStr_int <= 50905))
                    {
                        ChinaStr = "P";

                    }
                    else if ((ChineseStr_int >= 50906) && (ChineseStr_int <= 51386))
                    {
                        ChinaStr = "Q";

                    }

                    else if ((ChineseStr_int >= 51387) && (ChineseStr_int <= 51445))
                    {
                        ChinaStr = "R";
                    }
                    else if ((ChineseStr_int >= 51446) && (ChineseStr_int <= 52217))
                    {
                        ChinaStr = "S";
                    }
                    else if ((ChineseStr_int >= 52218) && (ChineseStr_int <= 52697))
                    {
                        ChinaStr = "T";
                    }
                    else if ((ChineseStr_int >= 52698) && (ChineseStr_int <= 52979))
                    {
                        ChinaStr = "W";
                    }
                    else if ((ChineseStr_int >= 52980) && (ChineseStr_int <= 53688))
                    {
                        ChinaStr = "X";
                    }
                    else if ((ChineseStr_int >= 53689) && (ChineseStr_int <= 54480))
                    {
                        ChinaStr = "Y";
                    }
                    else if ((ChineseStr_int >= 54481) && (ChineseStr_int <= 55289))
                    {
                        ChinaStr = "Z";
                    }
                }
                else
                {
                    ChinaStr = ChineseStr.Substring(i, 1);
                }
                Capstr += ChinaStr;
            }
            return Capstr;
        }
        #endregion

        #region 得到年月日
        /// <summary>
       /// 得到年月日
       /// </summary>
       /// <returns></returns>
        public string GetDateCode()
        {
            DateTime now = DateTime.Now;
            return now.Year.ToString() + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0');
        }
        #endregion


        #region 系统提示
        /// <summary>
        /// 系统友好提示
        /// </summary>
        /// <param name="Msg">提示信息</param>
        public static void Message(string Msg)
        {
            Message(Msg, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// 系统警告提示
        /// </summary>
        /// <param name="Msg">提示信息</param>
        public static void MessageWarning(string Msg)
        {
            Message(Msg, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 系统错误提示
        /// </summary>
        /// <param name="Msg">提示信息</param>
        public static void MessageError(string Msg)
        {
            Message(Msg, MessageBoxIcon.Error);
        }
        private static void Message(string Msg, MessageBoxIcon mbi)
        {
            MessageBox.Show(Msg, "系统提示", MessageBoxButtons.OK, mbi, MessageBoxDefaultButton.Button1);
        }
        /// <summary>
        /// 系统是否提示
        /// </summary>
        /// <param name="Msg">提示信息</param>
        public static bool MessageYesNo(string Msg)
        {
            return MessageBox.Show(Msg,"系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }
        #endregion

        #region 检查主键
        /// <summary>
        /// 检查主键
        /// </summary>
        /// <param name="Tab">表名</param>
        /// <param name="key">要检查的字段名</param>
        /// <param name="value">要检查的值</param>
        /// <param name="Id">Id等于0代表添加操作，否则就是修改操作</param>
        public static bool CheckKey(string Tab, string key, string value, long Id)
        {
            return WSV.BLL.PublicFun.PublicFun.CheckKey(Tab, key, value, Id);
        }
        #endregion

        ///   <summary>   
        ///   转换数字金额主函数（包括小数）   
        ///   </summary>   
        ///   <param   name="str">数字字符串</param>   
        ///   <returns>转换成中文大写后的字符串或者出错信息提示字符串</returns>   
        public static string ConvertSum(string str)
        {

            //string str = "1212180.900";
            //if (!IsPositveDecimal(str))
            //    return "输入的不是正数字！";
            char[] ch = new char[1];
            ch[0] = '.';   //小数点   
            string[] splitstr = null;   //定义按小数点分割后的字符串数组   
            splitstr = str.Split(ch[0]);//按小数点分割字符串   
            if (splitstr.Length == 1)   //只有整数部分   
                return ConvertData(str) + "圆整";
            else   //有小数部分   
            {
                string rstr;
                rstr = ConvertData(splitstr[0]) + "圆";//转换整数部分   
                rstr += ConvertXiaoShu(splitstr[1]);//转换小数部分   
                return rstr;

            }

        }
        ///   转换数字（整数）   
        ///   </summary>   
        ///   <param   name="str">需要转换的整数数字字符串</param>   
        ///   <returns>转换成中文大写后的字符串</returns>   
        public static string ConvertData(string str)
        {
            string tmpstr = "";
            string rstr = "";
            int strlen = str.Length;
            if (strlen <= 4)//数字长度小于四位   
            {
                rstr = ConvertDigit(str);

            }
            else
            {

                if (strlen <= 8)//数字长度大于四位，小于八位   
                {
                    tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字   
                    rstr = ConvertDigit(tmpstr);//转换最后四位数字   
                    tmpstr = str.Substring(0, strlen - 4);//截取其余数字   
                    //将两次转换的数字加上萬后相连接   
                    rstr = String.Concat(ConvertDigit(tmpstr) + "萬", rstr);
                    rstr = rstr.Replace("零萬", "萬");
                    rstr = rstr.Replace("零零", "零");

                }
                else
                    if (strlen <= 12)//数字长度大于八位，小于十二位   
                    {
                        tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字   
                        rstr = ConvertDigit(tmpstr);//转换最后四位数字   
                        tmpstr = str.Substring(strlen - 8, 4);//再截取四位数字   
                        rstr = String.Concat(ConvertDigit(tmpstr) + "萬", rstr);
                        tmpstr = str.Substring(0, strlen - 8);
                        rstr = String.Concat(ConvertDigit(tmpstr) + "億", rstr);
                        rstr = rstr.Replace("零億", "億");
                        rstr = rstr.Replace("零萬", "零");
                        rstr = rstr.Replace("零零", "零");
                        rstr = rstr.Replace("零零", "零");
                    }
            }
            strlen = rstr.Length;
            if (strlen >= 2)
            {
                switch (rstr.Substring(strlen - 2, 2))
                {
                    case "佰零": rstr = rstr.Substring(0, strlen - 2) + "佰"; break;
                    case "仟零": rstr = rstr.Substring(0, strlen - 2) + "仟"; break;
                    case "萬零": rstr = rstr.Substring(0, strlen - 2) + "萬"; break;
                    case "億零": rstr = rstr.Substring(0, strlen - 2) + "億"; break;

                }
            }

            return rstr;
        }
        ///   <summary>   
        ///   转换数字（小数部分）   
        ///   </summary>   
        ///   <param   name="str">需要转换的小数部分数字字符串</param>   
        ///   <returns>转换成中文大写后的字符串</returns>   
        public static string ConvertXiaoShu(string str)
        {
            int strlen = str.Length;
            string rstr;
            if (strlen == 1)
            {
                rstr = ConvertChinese(str) + "角";
                return rstr;
            }
            else if (strlen == 2)
            {
                string tmpstr = str.Substring(0, 1);
                rstr = ConvertChinese(tmpstr) + "角";
                tmpstr = str.Substring(1, 1);
                rstr += ConvertChinese(tmpstr) + "分";
                rstr = rstr.Replace("零分", "");
                rstr = rstr.Replace("零角", "");
                return rstr;
            }
            else
            {
                string tmpstr = str.Substring(0, 1);
                rstr = ConvertChinese(tmpstr) + "角";
                tmpstr = str.Substring(1, 1);
                rstr += ConvertChinese(tmpstr) + "分";
                tmpstr = str.Substring(2, 1);
                rstr += ConvertChinese(tmpstr) + "厘";
                rstr = rstr.Replace("零分", "");
                rstr = rstr.Replace("零角", "");
                rstr = rstr.Replace("零厘", "");
                return rstr;
            }


        }
        ///   <summary>   
        ///   转换数字   
        ///   </summary>   
        ///   <param   name="str">转换的字符串（四位以内）</param>   
        ///   <returns></returns>   
        public static string ConvertDigit(string str)
        {
            int strlen = str.Length;
            string rstr = "";
            switch (strlen)
            {
                case 1: rstr = ConvertChinese(str); break;
                case 2: rstr = Convert2Digit(str); break;
                case 3: rstr = Convert3Digit(str); break;
                case 4: rstr = Convert4Digit(str); break;
            }
            rstr = rstr.Replace("拾零", "拾");
            strlen = rstr.Length;

            return rstr;
        }
        ///   <summary>   
        ///   转换四位数字   
        ///   </summary>   
        public static string Convert4Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string str4 = str.Substring(3, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "仟";
            rstring += ConvertChinese(str2) + "佰";
            rstring += ConvertChinese(str3) + "拾";
            rstring += ConvertChinese(str4);
            rstring = rstring.Replace("零仟", "零");
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        ///   <summary>   
        ///   转换三位数字   
        ///   </summary>   
        public static string Convert3Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "佰";
            rstring += ConvertChinese(str2) + "拾";
            rstring += ConvertChinese(str3);
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        ///   <summary>   
        ///   转换二位数字   
        ///   </summary>   
        public static string Convert2Digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string rstring = "";
            rstring += ConvertChinese(str1) + "拾";
            rstring += ConvertChinese(str2);
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        ///   <summary>   
        ///   将一位数字转换成中文大写数字   
        ///   </summary>   
        public static string ConvertChinese(string str)
        {
            //"零壹贰叁肆伍陆柒捌玖拾佰仟萬億圆整角分"   
            string cstr = "";
            switch (str)
            {
                case "0": cstr = "零"; break;
                case "1": cstr = "壹"; break;
                case "2": cstr = "贰"; break;
                case "3": cstr = "叁"; break;
                case "4": cstr = "肆"; break;
                case "5": cstr = "伍"; break;
                case "6": cstr = "陆"; break;
                case "7": cstr = "柒"; break;
                case "8": cstr = "捌"; break;
                case "9": cstr = "玖"; break;
            }
            return (cstr);
        }

        /// <summary>
        /// 重量大写
        /// </summary>
        /// <param name="value">重量值</param>
        /// <param name="dw">重量单位</param>
        /// <returns></returns>
        public static string NetUpper(string value, string dw)
        {
            string retvalue = "";

            int valuelen = value.Length;
            string lstr = "";
            string rstr = "";
            int bz = 0;

            int aa = 0;
            string bb = "";
            string cc = "";

            for (int i = 1; i <= valuelen; i++)
            {
                bz = i;
                if (value.Substring(i - 1, 1) == ".")
                    break;
            }

            if (bz != valuelen)
            {
                lstr = value.Substring(0, bz - 1);
                rstr = value.Substring(valuelen - (valuelen - bz), valuelen - bz);
            }
            else
            {
                bz -= 1;
                lstr = value;
            }
            int zz = lstr.Length;

            for (int j = lstr.Length; j >= 1; j--)
            {
                aa = lstr.Length - j;
                switch (lstr.Substring(j - 1, 1))
                {
                    case "0":
                        bb = "零";
                        break;
                    case "1":
                        bb = "壹";
                        break;
                    case "2":
                        bb = "贰";
                        break;
                    case "3":
                        bb = "叁";
                        break;
                    case "4":
                        bb = "肆";
                        break;
                    case "5":
                        bb = "伍";
                        break;
                    case "6":
                        bb = "陆";
                        break;
                    case "7":
                        bb = "柒";
                        break;
                    case "8":
                        bb = "捌";
                        break;
                    case "9":
                        bb = "玖";
                        break;
                }

                switch (aa)
                {
                    case 0:
                        cc = "";
                        break;
                    case 1:
                        cc = "拾";
                        break;
                    case 2:
                        cc = "佰";
                        break;
                    case 3:
                        cc = "仟";
                        break;
                    case 4:
                        cc = "万";
                        break;
                    case 5:
                        cc = "拾";
                        break;
                    case 6:
                        cc = "佰";
                        break;
                    case 7:
                        cc = "仟";
                        break;
                }
                if (aa != 0)
                {
                    if (bb == "零")
                    {
                        if (retvalue != "")
                        {
                            if (retvalue.Substring(0, 1) != "零")
                                retvalue = bb + retvalue;
                        }
                    }
                    else
                        retvalue = bb + cc + retvalue;
                }
                else
                    if (bb != "零")
                        retvalue = bb + cc + retvalue;
            }

            if (rstr != "")
            {
                retvalue += "点";
                for (int i = 1; i <= rstr.Length; i++)
                {
                    switch (rstr.Substring(i - 1, 1))
                    {
                        case "0":
                            bb = "零";
                            break;
                        case "1":
                            bb = "壹";
                            break;
                        case "2":
                            bb = "贰";
                            break;
                        case "3":
                            bb = "叁";
                            break;
                        case "4":
                            bb = "肆";
                            break;
                        case "5":
                            bb = "伍";
                            break;
                        case "6":
                            bb = "陆";
                            break;
                        case "7":
                            bb = "柒";
                            break;
                        case "8":
                            bb = "捌";
                            break;
                        case "9":
                            bb = "玖";
                            break;
                    }
                    retvalue += bb;
                }
            }

            if (dw == "t")
                retvalue += "吨";
            else
                retvalue += "公斤";
            return retvalue;
        }
        /// <summary>
        /// 声音
        /// </summary>
        /// <param name="path">声音文件路径</param>
        public static void playSound(string path)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = path;
                player.Load();
                player.Play();
            }
            catch { }
        }
    }
}
