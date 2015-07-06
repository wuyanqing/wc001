using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class FilePath
    {
        private static string DirPath = System.IO.Directory.GetCurrentDirectory();
        /// <summary>
        /// 配置文件路径
        /// </summary>
        public static string Config { get { return DirPath + @"\Config.dll"; } }
    }
}
