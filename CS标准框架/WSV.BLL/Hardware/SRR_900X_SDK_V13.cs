using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WSV.BLL.Hardware
{
    public class SRR_900X_SDK_V13
    {
        public IntPtr hCom;//串口句柄
        public byte DeviceID;//设备地址
        //const string SDK_PATH = "D:\\SRR_900X_API_1031.dll";
        //const string SDK_PATH = Application.ExecutablePath + "\\SRR_900X_API_1031.dll";
        //函数声明

        #region 打开串口
        [DllImport("SRR_900X_API_1031.dll",
        EntryPoint = "RFID_Open", SetLastError = true,
         CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]//(1)打开串口



        public static extern UInt16 RFID_Open(ref IntPtr hCom, ref Byte com_port, UInt32 Baud);//传出串口句柄，输出
        // Baud=0~6:
        //0:2400;1:4800;2;9600;3:19200;4:38400;5:57600;6:115200 默认57600

        //com_port=0~255，其中FF为广播地址

        ///////////////////////////////////////////////////////////////////////////////
        #endregion


        #region 关闭串口
        //////////////////////////////////////////////////////////////////////////////
        //(2)关闭串口

        [DllImport("SRR_900X_API_1031.dll",
        EntryPoint = "RFID_Close", SetLastError = true,
         CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)] //(2)关闭串口


        public static extern UInt16 RFID_Close(IntPtr hCom, UInt32 address);//传入串口句柄，输入


        //////////////////////////////////////////////////////////////////////////////
        #endregion

        #region 发送读卡命令
        //发送读单卡命令，读到卡后自动把卡号存入设备内部缓冲区
        //apiStatus WINAPI RFID_ISO_SearchUID(HANDLE hCom,UCHAR RAddr,UCHAR* TagCount);
        [DllImport("SRR_900X_API_1031.dll",
       EntryPoint = "RFID_ISO_SearchUID", SetLastError = true,
         CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)] //(2)关闭串口


        public static extern UInt16 RFID_ISO_SearchUID(IntPtr hCom, UInt32 address, ref byte TaGCount);//传入串口句柄，输入,TaGCount为设备内部标签个数



        #endregion

        #region 取卡号
        //从缓冲区直接取卡号
        //apiStatus WINAPI RFID_ISO_SearchUID(HANDLE hCom,UCHAR RAddr,UCHAR* TagCount);
        [DllImport("SRR_900X_API_1031.dll",
      EntryPoint = "RFID_REC_GetTagData", SetLastError = true,
         CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)] //(2)关闭串口


        public static extern UInt16 RFID_REC_GetTagData(IntPtr hCom, UInt32 address, byte TaG_Count_want_to_get, ref  byte Real_Get_Count, ref  byte CardData, ref  byte EveryTagLen, ref  byte ant, Boolean bNeedClr);//传入串口句柄，输入,TaGCount为设备内部标签个数
        //TaG_Count_want_to_get,用户想要取的卡数，一般最多为16个，默认为16即可
        //Real_Get_Count:这次操作实际取上来的卡数
        //CardData：标签号
        //EveryTagLen：每个标签的长度
        //ant：每个标签的天线号，单端口天线号均相同


        #endregion
        ////////////////////////////////////////////////////////

        //RFID_REC_ClrAll(g_hCom,g_RAddr);

        #region 清空设备内部卡号
        //apiStatus WINAPI RFID_ISO_SearchUID(HANDLE hCom,UCHAR RAddr,UCHAR* TagCount);
        [DllImport("SRR_900X_API_1031.dll",
      EntryPoint = "RFID_REC_ClrAll", SetLastError = true,
         CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)] //(2)关闭串口


        public static extern UInt16 RFID_REC_ClrAll(IntPtr hCom, UInt32 address);


        #endregion
        //声明结束
    }
}
