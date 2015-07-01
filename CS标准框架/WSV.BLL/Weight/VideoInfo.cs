using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WSV.BLL.Weight
{
    public partial class VideoInfo
    {
        #region 设置参数
        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="phParentWnd"></param>
        /// <param name="eDispTransType"></param>
        /// <param name="bInitAudDev"></param>
        /// <returns></returns>
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAInitSdk", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAInitSdk(IntPtr phParentWnd, int eDispTransType, bool bInitAudDev);  //初始化系统资源

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUnInitSdk", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern void VCStream_VCAUnInitSdk(); //释放系统资源.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAGetDevNum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern Int32 VCStream_VCAGetDevNum();    //返回系统当中卡号数量

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAOpenDevice", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAOpenDevice(int iCard, IntPtr phPreviewWnd);     //打开指定卡号的设备，分配相应系统资源

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCACloseDevice", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCACloseDevice(int iCard);    //关闭指定卡号的设备，释放相应系统资源

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStartVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStartVideoPreview(int iCard);     //开始视频预览.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStopVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStopVideoPreview(int iCard); //停止视频预览.

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUpdateVideoPreview", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAUpdateVideoPreview(int iCard, IntPtr phPreviewWnd);  //更新视频预览。

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAUpdateOverlayWnd", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAUpdateOverlayWnd(IntPtr phPreviewWnd);   //当overlay窗口句柄改变或尺寸、位置改变时调用

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASaveBitsToBuf", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASaveBitsToBuf(int iCard, byte[] fb, out int Width, out int Height);   //保存快照数据到相应的缓冲区

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASaveAsJpegFile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASaveAsJpegFile(int iCard, String szFileName, int iQuality);  //保存快照为JPEG文件

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAInitVidDev", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAInitVidDev(int iCard);     //初始化视频设备，当视频不显示，只需视频录像或音频处理时、或通过VCAInitSdk()函数已经初始化完成可以不初始化

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidDeviceColor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidDeviceColor(int iCard, int EnCtlType, int DwValue);  //设置视频颜色属性,它将影响视频预览和视频捕获的显示属性

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAGetVidFieldFrq", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAGetVidFieldFrq(int iCard, out int eVidSourceFieldRate);  //得到视频源输入频率，即可得到视频源输入制式

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidFieldFrq", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidFieldFrq(int iCard, int eVidSourceFieldRate);  //设置视频源输入频率( 0HZ / 50HZ / 60HZ )对应( 无信号 / PAL制 / NTSC制 )

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSD", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSD(int iCard, bool bEnableOSD, POINT ptTopLeft, bool bTransparent);

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSDParam", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSDParam(OSDPARAM pOSDParm);

        //捕捉视频
        /// <summary>
        /// 捕捉视频
        /// </summary>
        /// <param name="iCard">卡号</param>
        /// <param name="enCapMode">表示选择流捕捉模式，=0表示捕捉无效；=1表示原始流回调；=2表示Mpeg4流；=3表示XVID的数据流；=4表示WMV9数据流；5；6；7；常用2，3，6</param>
        /// <param name="enMp4Mode">表示MPEG压缩模式，只有其等于CAP_MPEG4_STREAM时enMp4Mode才有效,=0表示存为MPEG文件；=1MPEG数据回调；=2存为MPEG文件并回调.</param>
        /// <param name="lpFileName">文件路径</param>
        /// <returns></returns>
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStartVideoCapture", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStartVideoCapture(int iCard, int enCapMode, int enMp4Mode, string lpFileName);  
         
        [DllImport("Sa7134Capture.dll", EntryPoint = "VCAStopVideoCapture", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCAStopVideoCapture(int iCard);  //停止视频

        [DllImport("Sa7134Capture.dll", EntryPoint = "VCASetVidCapDateTimeOSDParam", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Winapi)]
        public static extern bool VCStream_VCASetVidCapDateTimeOSDParam(int iCard);  //设置视频时间、日期叠加参数.


        #endregion

        public struct OSDPARAM
        {
            public long cfHeight; //字符高度
            public long cfWidth; //字符宽度
            public long cfWeight; //字符粗细
            public long cfSpacing; //字符间距
            public bool cfItalic; //斜体
            public bool cfUnderline; //下划线
            public bool cfStrikeOut; //删除线
            public bool bTransparent; //透明
            public Color cfBkColor; //背景色 
            public Color cfTextColor; //前景色
            //public string cfFaceName; //字体名
            //public byte[] cfFaceName;//{"宋体"}; //字体名
            public char[] cfFaceName;
        }
        public struct POINT
        {
            public int cx;
            public int cy;
        }
    }
}
