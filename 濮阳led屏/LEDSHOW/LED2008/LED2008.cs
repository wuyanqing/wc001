using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Drawing;

namespace LEDSHOW
{
    class LED2008:IDisposable 
    {
        //****************参数说明******************/           
        //'通讯方式常量
        public const int DEVICE_TYPE_COM = 0;//Public Const DEVICE_TYPE_COM = 0     '串口通讯
        public const int DEVICE_TYPE_NET = 1;//Public Const DEVICE_TYPE_NET = 1     '网络通讯

        //'串行通讯速度常量
        public const int SBR_9600 = 9600;//Public Const SBR_9600 = 9600
        public const int SBR_19200 = 19200;//Public Const SBR_19200 = 19200
        public const int SBR_57600 = 57600;//Public Const SBR_57600 = 57600
        public const int SBR_115200 = 115200;//Public Const SBR_115200 = 115200

        //'EQ3002/2008控制卡类型
        public const int EQ3002_I = 0;//Public Const EQ3002_I = 0
        public const int EQ3002_II = 1;//Public Const EQ3002_II = 1
        public const int EQ3002_III = 2;//Public Const EQ3002_III = 2
        public const int EQ2008_I = 3;//Public Const EQ2008_I = 3
        public const int EQ2008_II = 3; //Public Const EQ2008_II = 3

        //'颜色常量
        public const long RED = 0x0000FF;//Public Const RED = &HFF00FF
        public const long GREEN = 0x00FF00; //Public Const GREEN = &HFFFF00
        public const long YELLOW = 0x00FFFF;//Public Const YELLOW = &HFFFFFF

        //'返回值常量
        public const int EQ_FALSE = 0;//Public Const EQ_FALSE = 0
        public const int EQ_TRUE = 1;//Public Const EQ_TRUE = 1

        //'/***************************************/

        /// <summary>
        /// 开机
        /// </summary>
        /// <param name="CardNum"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_OpenScreen(
            int CardNum
        );
        /// <summary>
        /// 关机
        /// </summary>
        /// <param name="CardNum"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_CloseScreen(
            int CardNum
        );
        /// <summary>
        /// 添加节目
        /// </summary>
        /// <param name="CardNum">控制卡地址</param>
        /// <param name="bWaitToEnd"></param>
        /// <param name="iPlayTime">播放时间</param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern long User_AddProgram(
            long CardNum,
            long bWaitToEnd,
            long iPlayTime
        );
        /// <summary>
        /// 删除节目
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="iProgramIndex"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_DelProgram(
            long CardNum,
            long iProgramIndex
        );
        /// <summary>
        /// 删除所有节目
        /// </summary>
        /// <param name="CardNum"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_DelAllProgram(
            long CardNum
        );
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="CardNum"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_SendToScreen(
            long CardNum
        );

        /// <summary>
        /// 添加图文区
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="pBmp"></param>
        /// <param name="iProgramIndex"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern long User_AddBmpZone(
            long CardNum,
            User_Bmp pBmp,
            long iProgramIndex
        );
        /// <summary>
        /// 向图文区添加图片
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="iBmpPartNum"></param>
        /// <param name="hBitmap"></param>
        /// <param name="pMoveSet"></param>
        /// <param name="iProgramIndex"></param>
        /// <returns></returns>
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_AddBmp(
            long CardNum,
            long iBmpPartNum,
            long hBitmap,
            User_MoveSet pMoveSet,
            long iProgramIndex
        );
        public bool IsRealtimeConnect = true;
        //（1）、建立连接
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_RealtimeConnect(int CardNum);
        //（2）、发送数据
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_RealtimeSendData(int CardNum, int x, int y, int iWidth, int iHeight, long hBitmap);
        //（3、）断开连接
        [DllImport("EQ2008_Dll.dll")]
        public static extern bool User_RealtimeDisConnect(int CardNum);

        private bool _IsOpenScreen = false;
        private int _CardNum = 0;
        private static Hashtable  led2008list = new Hashtable();
        public int CardNum
        {
            get { return _CardNum; }
        }

        public static LED2008 Create(int CardNum)
        {
            if (!led2008list.ContainsKey(CardNum))
            {
                led2008list[CardNum] = new LED2008() { _CardNum = CardNum };
            }
            return (LED2008)led2008list[CardNum];
        }
        public bool IsOpenScreen
        {
            get
            {
                return _IsOpenScreen;
            }
        }
        //delegate bool User_OpenScreen(int CardNum);
        public bool OpenScreen()
        {
            ////1. 动态加载C++ Dll
            //int hModule = NativeMethod.LoadLibrary(@".\EQ2008_Dll.dll");
            //if (hModule == 0) return false ;

            ////2. 读取函数指针
            //IntPtr intPtr = NativeMethod.GetProcAddress(hModule, "User_OpenScreen");

            ////3. 将函数指针封装成委托
            //User_OpenScreen _User_OpenScreen = (User_OpenScreen)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(User_OpenScreen));
            if (IsRealtimeConnect)
            {
                _IsOpenScreen = User_OpenScreen(CardNum);
                User_RealtimeConnect(CardNum);
            }
            else
            {
                _IsOpenScreen = User_OpenScreen(CardNum);
            }
            ////4.放。DLL
            ////NativeMethod.FreeLibrary(hModule);
            return _IsOpenScreen;
        }
        public void SendToLed(Bitmap bit)
        {
            IntPtr hBitmap = bit.GetHbitmap();
            if (IsOpenScreen)
            {

                do
                {
                    if (IsRealtimeConnect)
                    {                        
                        //发送！！！
                        if (User_RealtimeSendData(CardNum, 0, 0, bit.Width, bit.Height, hBitmap.ToInt64()))
                        {
                            break;
                        }
                    }
                    else
                    {

                        //准备新的节目
                        User_DelAllProgram(CardNum);
                        long ProgramIndex = User_AddProgram(CardNum, EQ_TRUE, 10);

                        //准备新的图片区
                        User_PartInfo partinfo = new User_PartInfo() { iX = 0, iY = 0, iHeight = bit.Height , iWidth = bit.Width, iFrameMode = 0, FrameColo = GREEN };
                        User_Bmp bmp = new User_Bmp() { PartInfo = partinfo };
                        long BmpZoneIndex = User_AddBmpZone(CardNum, bmp, ProgramIndex);

                        //准备移动方式
                        User_MoveSet moveset = new User_MoveSet() { iActionType = 1, iActionSpeed = 30, bClear = EQ_TRUE, iHoldTime = 20, iClearSpeed = 10, iClearActionType = 1, iFrameTime = 10 };
                        //添加新图片
                        if (User_AddBmp(CardNum, BmpZoneIndex, hBitmap.ToInt64(), moveset, ProgramIndex))
                        {
                            //发送！！！
                            if (User_SendToScreen(CardNum))
                            {
                                break;
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(2000);
                } while (true);
            }
        }

        #region IDisposable 成员

        public void Dispose()
        {
            if (IsOpenScreen)
            {
                if (IsRealtimeConnect)
                {
                    User_RealtimeDisConnect(CardNum);
                    User_CloseScreen(CardNum);
                }
                else
                {
                    User_CloseScreen(CardNum);
                }                
            }
        }

        #endregion
    }
}
