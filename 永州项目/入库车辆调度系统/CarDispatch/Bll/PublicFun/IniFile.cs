﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Bll.PublicFun
{    
    public class IniFile
    {
        public string Path;
        /**/
        ////声明读写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public IniFile(string inifile)
        {
            Path = inifile;
        }
        //写入INI文件指定
        public void IniWriteValue(string Section, string Key, object Value)
        {
            WritePrivateProfileString(Section, Key, Value.ToString(), this.Path);
        }
        //读取INI文件指定 
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.Path);
            return temp.ToString();
        }
        public bool ExistIniFile()
        {
            return File.Exists(this.Path);
        }
    }
}
