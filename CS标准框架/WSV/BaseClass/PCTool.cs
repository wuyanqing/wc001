using System;
using System.Management; 
using System.IO; 
using System.Runtime.InteropServices; 
using System.Security.Cryptography; 
using System.Text; 
using Microsoft.Win32; 

namespace WSV.BaseClass
{
    public class PCTool 
    { 
        ///   <summary>  
        ///   获取cpu序列号      
        ///   </summary>  
        ///   <returns> string </returns>  
        public static string GetCpuInfo() 
        { 
            string cpuInfo = " "; 
            ManagementClass cimobject = new ManagementClass("Win32_Processor"); 
            ManagementObjectCollection moc = cimobject.GetInstances(); 
            foreach (ManagementObject mo in moc) 
            { 
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString(); 
            } 
            return cpuInfo.ToString(); 
        } 

        ///   <summary>  
        ///   获取硬盘ID      
        ///   </summary>  
        ///   <returns> string </returns>  
        public static string GetHDid() 
        { 
            string HDid = " "; 
            ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive"); 
            ManagementObjectCollection moc1 = cimobject1.GetInstances(); 
            foreach (ManagementObject mo in moc1) 
            { 
                HDid = (string)mo.Properties["Model"].Value; 
            } 
            return HDid.ToString(); 
        } 

        /// <summary> 
        /// 获取网卡Mac地址 
        /// </summary> 
        /// <returns></returns> 
        public static string GetMacAddress() 
        { 
            System.Management.ManagementObjectSearcher mos =  
                new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration"); 

            foreach (ManagementObject m in mos.Get()) 
            { 
                if ((bool)m["IPEnabled"]) 
                { 
                    return m["MACAddress"].ToString(); 
                } 
            } 
            return ""; 
        } 

        /// <summary> 
        /// 获取IP地址 
        /// </summary> 
        /// <returns></returns> 
        public static string GetIPAddress() 
        { 
            string st = ""; 
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"); 
            ManagementObjectCollection moc = mc.GetInstances(); 
            foreach (ManagementObject mo in moc) 
            { 
                if ((bool)mo["IPEnabled"] == true) 
                { 
                    //st=mo["IpAddress"].ToString();  
                    System.Array ar; 
                    ar = (System.Array)(mo.Properties["IpAddress"].Value); 
                    st = ar.GetValue(0).ToString(); 
                    break; 
                } 
            } 
            return st; 
        } 

        /// <summary> 
        /// 获取用户名 
        /// </summary> 
        /// <returns></returns> 
        public static string GetUserName() 
        { 
            try 
            { 
                string st = ""; 
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem"); 
                ManagementObjectCollection moc = mc.GetInstances(); 
                foreach (ManagementObject mo in moc) 
                { 

                    st = mo["UserName"].ToString(); 

                } 
                moc = null; 
                mc = null; 
                return st; 
            } 
            catch 
            { 
                return "unknow"; 
            } 
            finally 
            { 
            }  
        } 

        /// <summary> 
        /// 获取系统类型 
        /// </summary> 
        /// <returns></returns> 
        public static string GetSystemType() 
        { 
            try 
            { 
                string st = ""; 
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem"); 
                ManagementObjectCollection moc = mc.GetInstances(); 
                foreach (ManagementObject mo in moc) 
                { 

                    st = mo["SystemType"].ToString(); 

                } 
                moc = null; 
                mc = null; 
                return st; 
            } 
            catch 
            { 
                return "unknow"; 
            } 
            finally 
            { 
            }  

        } 

        /// <summary> 
        /// 物理内存 
        /// </summary> 
        /// <returns></returns> 
        public static string GetTotalPhysicalMemory() 
        { 
            try 
            { 

                string st = ""; 
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem"); 
                ManagementObjectCollection moc = mc.GetInstances(); 
                foreach (ManagementObject mo in moc) 
                { 

                    st = mo["TotalPhysicalMemory"].ToString(); 

                } 
                moc = null; 
                mc = null; 
                return st; 
            } 
            catch 
            { 
                return "unknow"; 
            } 
            finally 
            { 
            }  

        } 

        /// <summary> 
        /// 获得机器名 
        /// </summary> 
        /// <returns></returns> 
        public static string GetComputerName() 
        { 
            try 
            { 
                return System.Environment.GetEnvironmentVariable("ComputerName"); 
            } 
            catch 
            { 
                return "unknow"; 
            } 
            finally 
            { 
            } 

        } 

        #region 关机 

        [StructLayout(LayoutKind.Sequential, Pack = 1)] 

        internal struct TokPriv1Luid 
        { 
            public int Count; 

            public long Luid; 

            public int Attr; 
        } 

        [DllImport("kernel32.dll", ExactSpelling = true)] 

        internal static extern IntPtr GetCurrentProcess(); 

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)] 

        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok); 

        [DllImport("advapi32.dll", SetLastError = true)] 

        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid); 

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)] 

        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, 

            ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen); 

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)] 

        internal static extern bool ExitWindowsEx(int flg, int rea); 

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002; 

        internal const int TOKEN_QUERY = 0x00000008; 

        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020; 

        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege"; 

        internal const int EWX_LOGOFF = 0x00000000; 

        internal const int EWX_SHUTDOWN = 0x00000001; 

        internal const int EWX_REBOOT = 0x00000002; 

        internal const int EWX_FORCE = 0x00000004; 

        internal const int EWX_POWEROFF = 0x00000008; 
        /// <summary> 
        /// 关机命令 
        /// </summary> 
        /// <param name="flg">具体参数</param> 
        private static void DoExitWin(int flg) 
        { 
            bool ok; 

            TokPriv1Luid tp; 

            IntPtr hproc = GetCurrentProcess(); 

            IntPtr htok = IntPtr.Zero; 

            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok); 

            tp.Count = 1; 

            tp.Luid = 0; 

            tp.Attr = SE_PRIVILEGE_ENABLED; 

            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid); 

            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero); 

            ok = ExitWindowsEx(flg, 0); 
        } 

        /// <summary> 
        /// 关机 
        /// </summary> 
        public static void ShutdownPC() 
        { 
            DoExitWin(EWX_SHUTDOWN); 

        } 

        /// <summary> 
        /// 注销 
        /// </summary> 
        public static void LogOff() 
        { 
            DoExitWin(EWX_LOGOFF); 

        } 

        /// <summary> 
        /// 重启 
        /// </summary> 
        public static void ReBoot() 
        { 
            DoExitWin(EWX_REBOOT); 

        } 

        /// <summary> 
        /// 关机 
        /// </summary> 
        public static void PowerOff() 
        { 
            DoExitWin(EWX_POWEROFF); 

        } 

        /// <summary> 
        /// 强制关机 
        /// </summary> 
        public static void Force() 
        { 
            DoExitWin(EWX_FORCE); 

        } 

        #endregion 
    } 

}
