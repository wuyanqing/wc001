using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;                 //INI文本的读写，所在的命名空间

namespace WSV.DAL
{
    public class ConnString
    {
        //服务器地址
        public static string DBServer()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("systemconfig", "servername");
        }
        //sa密码
        public static string Pass()
        {
            SYSBLL ini = new SYSBLL();
            return ini.jiemi(ini.readoptions("systemconfig", "serverpassword"));
        }
        //数据库名
        public static string DBName()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("systemconfig", "database");
        }
        //接口服务器地址1
        public static string PortServer1()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("Portload", "servername1");
        }
        //接口sa密码1
        public static string PortPass1()
        {
            SYSBLL ini = new SYSBLL();
            return ini.jiemi(ini.readoptions("Portload", "serverpassword1"));
        }
        //接口数据库名1
        public static string PortName1()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("Portload", "database1");
        }
        //接口服务器地址2
        public static string PortServer2()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("Portload", "servername2");
        }
        //接口sa密码1
        public static string PortPass2()
        {
            SYSBLL ini = new SYSBLL();
            return ini.jiemi(ini.readoptions("Portload", "serverpassword2"));
        }
        //接口数据库名1
        public static string PortName2()
        {
            SYSBLL ini = new SYSBLL();
            return ini.readoptions("Portload", "database2");
        }
        public static string Conn = "data Source=" + DBServer() + ";database="+DBName()+";user id=sa;pwd=" + Pass();
        public static string Conn1 = "data Source=" + PortServer1() + ";database=" + PortName1() + ";user id=sa;pwd=" + PortPass1();
        public static string Conn2 = "data Source=" + PortServer2() + ";database=" + PortName2() + ";user id=sa;pwd=" + PortPass2(); 
    }

    public class SYSBLL
    {
        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileString
        (
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
        );

        [DllImport("kernel32.dll")]
        private static extern uint WritePrivateProfileString(
            string lpappName,
            string lpKeyName,
            string lpstring,
            string lpFileName
        );

        public string modname(string aa, string bb, int cc)
        {

            int lenaa;
            int i = 1;
            int flag = 0;
            string shuzhi = "";
            lenaa = aa.Length;
            while (i < lenaa)
            {
                string can = aa.Substring(i, 1);
                if (can == bb) flag += 1;
                if (flag == cc)
                {
                    int j = i + 1;
                    while (j < lenaa)
                    {
                        can = aa.Substring(j, 1);
                        if (can == bb)
                        {
                            flag += 1;
                            break;
                        }
                        shuzhi += can;
                        j += 1;
                        i += 1;
                    }
                }
                i += 1;
            }
            return shuzhi;
        }

        public string readoptions(string a1, string a2)           //读取配置文件
        {
            StringBuilder buff = new StringBuilder(256);
            GetPrivateProfileString(a1, a2, "", buff, 256, System.IO.Directory.GetCurrentDirectory() + "\\Config.dll");
            return buff.ToString().Trim();
        }

        public string writeoptions(string w1, string w2, string w3)                 //写入配置文件
        {
            long success = WritePrivateProfileString(w1, w2, w3, System.IO.Directory.GetCurrentDirectory() + "\\Config.dll");
            return success.ToString();
        }

        public string jiami(string jmstr)               //加密块
        {
            string[] sum = new string[40];
            int[] chu = new int[20];
            int[] yu = new int[20];
            int i;
            string ret;
            int sm = jmstr.Length;
            for (i = 0; i <= sm - 1; i++)
            {
                char[] strchar = new char[1];
                strchar = jmstr.Substring(i, 1).ToCharArray(0, 1);
                chu[i] += ((int)strchar[0]) / 19 + 37;
                yu[i] += ((int)strchar[0]) % 19 + 56;
            }

            for (i = 0; i <= sm - 1; i++)
            {
                char zhi = (char)(chu[i] + i);
                sum[i] = zhi.ToString();
            }

            for (i = sm; i <= 2 * sm - 1; i++)
            {
                char zhi = (char)(yu[i - sm] - (i - sm));
                sum[i] = zhi.ToString();
            }

            ret = "";
            for (i = 1; i <= 2 * sm; i++)
            {
                ret += sum[i - 1];
            }
            return ret;
        }

        public string jiemi(string jiemistr)           //解密块
        {
            string[] sum1 = new string[40];
            string[] chu1 = new string[20];
            string[] yu1 = new string[20];
            int[] ch = new int[20];
            int[] yv = new int[20];
            int[] sum2 = new int[20];
            int j; int sm1;
            string ret;
            sm1 = jiemistr.Length;
            for (j = 0; j <= sm1 - 1; j++)
            {
                sum1[j] = jiemistr.Substring(j, 1);
            }

            for (j = 0; j <= sm1 / 2 - 1; j++)
            {
                chu1[j] = sum1[j];
                yu1[j] = sum1[j + sm1 / 2];
            }

            for (j = 0; j <= sm1 / 2 - 1; j++)
            {
                char[] jiezhi = new char[1];
                jiezhi = chu1[j].ToCharArray(0, 1);
                ch[j] = (int)jiezhi[0];

                char[] jieyu = new char[1];
                jieyu = yu1[j].ToCharArray(0, 1);
                yv[j] = (int)jieyu[0];
            }

            for (j = 0; j <= sm1 / 2 - 1; j++)
            {
                ch[j] = ch[j] - 37 - j;
                yv[j] = yv[j] - 56 + j;
            }

            ret = "";
            jiemistr = "";
            for (j = 0; j <= sm1 / 2 - 1; j++)
            {
                sum2[j] = ch[j] * 19 + yv[j];
                ret = ret + ((char)sum2[j]).ToString();
            }
            return ret;
        }
    }
}
