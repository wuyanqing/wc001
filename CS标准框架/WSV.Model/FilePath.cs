using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.Model
{
    public class FilePath
    {
        private static string DirPath = System.IO.Directory.GetCurrentDirectory();
        /// <summary>
        /// 配置文件路径
        /// </summary>
        public static string Config { get { return DirPath + @"\Config.dll"; } }
        /// <summary>
        /// Id卡波特率文件路径
        /// </summary>
        public static string BaudRate { get { return DirPath + @"\BaudRate.dll"; } }
        /// <summary>
        /// 读卡器类型文件路径
        /// </summary>
        public static string CardType { get { return DirPath + @"\CardParam.dll"; } }
        /// <summary>
        /// 仪表类型文件路径
        /// </summary>
        public static string Meter { get { return DirPath + @"\Meter.dll"; } }
        /// <summary>
        /// 电子标签波特率文件路径
        /// </summary>
        public static string RfidBaudRate { get { return DirPath + @"\RfidBaudRate.dll"; } }
        /// <summary>
        /// 电子标签通讯类型文件路径
        /// </summary>
        public static string RfidType { get { return DirPath + @"\RfidParam.dll"; } }
        /// <summary>
        /// 语音提示项目文件路径
        /// </summary>
        public static string Voice { get { return DirPath + @"\Voice.dll"; } }
    }
}
