using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDSHOW
{
    //节目区域结构
    public struct User_PartInfo
    {
        public long iX;             //窗口的起点X
        public long iY;             //窗口的起点Y
        public long iWidth;         //窗体的宽度
        public long iHeight;        //窗体的高度
        public long iFrameMode;     //边框的样式
        public long FrameColo;      //边框颜色
    }

    //字体设置
    public struct User_FontSet
    {
        public string strFontName;          //strFontName as string    '字体的名称
        public long iFontSize;              //iFontSize As Long        '字体的大小
        public long bFontBold;              //bFontBold As Long        '字体是否加粗
        public long bFontItaic;             //bFontItaic As Long       '字体是否是斜体
        public long bFontUnderline;         //bFontUnderline As Long   '字体是否带下划线
        public long colorFont;              //colorFont As Long        '字体的颜色
        public long iAlignStyle;            //iAlignStyle As Long      '对齐方式
        //                         '0－ 左对齐
        //                         '1－居中
        //                         '2－右对齐
        public long iVAlignerStyle;         //iVAlignerStyle As Long   '上下对齐方式
        //                         '0-顶对齐
        //                         '1-上下居中
        //                         '2-底对齐
        public long iRowSpace;              //iRowSpace As Long        '行间距
    }

    //'动作方式设置
    public struct User_MoveSet
    {
        public long iActionType;           //iActionType As Long      '节目变换方式
        public long iActionSpeed;          //iActionSpeed As Long     '节目的播放速度
        public long bClear;                //bClear As Long           '是否需要清除背景
        public long iHoldTime;             //iHoldTime As Long        '在屏幕上停留的时间
        public long iClearSpeed;           //iClearSpeed As Long      '清除显示屏的速度
        public long iClearActionType;      //iClearActionType As Long '节目清除的变换方式
        public long iFrameTime;            //iFrameTime As Long
    }


    //'“图文框”
    public struct User_Bmp
    {
        public User_PartInfo PartInfo;     //PartInfo As User_PartInfo   '分区信息
    }

    //'“单行文本框”
    public struct User_SingleText
    {
        public string chContent;           //chContent As String         '显示内容
        public User_PartInfo PartInfo;     //PartInfo As User_PartInfo   '分区信息
        public long BkColor;               //BkColor As Long          '背景颜色
        public User_FontSet FontInfo;      //FontInfo As User_FontSet    '字体设置
        public User_MoveSet MoveSet;       //MoveSet As User_MoveSet     '动作方式设置
    }

    //'“文本框”
    public struct User_Text
    {
        public string chContent;           //    chContent As String         '显示内容
        public string PartInfo;            //    PartInfo As User_PartInfo   '分区信息
        public long BkColor;               //    BkColor As Long          '背景颜色
        public User_FontSet FontInfo;      //    FontInfo As User_FontSet    '字体设置
        public User_MoveSet MoveSet;       //    MoveSet As User_MoveSet     '动作方式设置
    }

    //'“RTF文件”
    public struct User_RTF
    {
        public string strFileName;         //    strFileName As String        'RTF文件名
        public User_PartInfo PartInfo;     //    PartInfo As User_PartInfo    '分区信息
        public User_MoveSet MoveSet;       //    MoveSet As User_MoveSet      '动作方式设置
    }

    // '“计时窗口”
    public struct User_Timer
    {
        public User_PartInfo PartInfo;     //    PartInfo As User_PartInfo   '分区信息
        public long BkColor;               //    BkColor As Long          '背景颜色
        public User_FontSet FontInfo;      //    FontInfo As User_FontSet    '字体设置
        public long ReachTimeYear;         //    ReachTimeYear As Long    '到达年
        public long ReachTimeMonth;        //    ReachTimeMonth As Long   '到达月
        public long ReachTimeDay;          //    ReachTimeDay As Long     '到达日
        public long ReachTimeHour;         //    ReachTimeHour As Long    '到达时
        public long ReachTimeMinute;       //    ReachTimeMinute As Long  '到达分
        public long ReachTimeSecond;       //    ReachTimeSecond As Long  '到达秒
        public long bDay;                  //    bDay As Long             '是否显示天 0－不显示 1－显示
        public long bHour;                 //    bHour As Long            '是否显示小时
        public long bMin;                  //    bMin As Long             '是否显示分钟
        public long bSec;                  //    bSec As Long             '是否显示秒
        public long bMulOrSingleLine;      //    bMulOrSingleLine As Long '单行还是多行
        public string chTitle;             //    chTitle As String           '添加显示文字
    }


    //'“温度窗口”
    public struct User_Temperature
    {
        public User_PartInfo PartInfo;     //    PartInfo As User_PartInfo   '分区信息
        public long BkColor;               //    BkColor As Long          '背景颜色
        public User_FontSet FontInfo;      //    FontInfo As User_FontSet    '字体设置
        public string chTitle;             //    chTitle As String           '标题
        public long iDisplayType;          //    iDisplayType As Long     '显示格式：0－度 1－C
    }

    //'“日期时间窗口”
    public struct User_DateTime
    {
        public User_PartInfo PartInfo;     //    PartInfo As User_PartInfo   '分区信息
        public long BkColor;               //    BkColor As Long          '背景颜色
        public User_FontSet FontInfo;      //    FontInfo As User_FontSet    '字体设置
        public long iDisplayType;          //    iDisplayType As Long     '显示风格
        public string chTitle;             //    chTitle As String           '添加显示文字
        public long bYearDisType;          //    bYearDisType As Long     '年份位数0 －4；1－2位
        public long bMulorSingleLine;      //    bMulOrSingleLine As Long '单行还是多行
        public long bYear;                 //    bYear As Long
        public long bMouth;                //    bMouth As Long
        public long bDay;                  //    bDay As Long
        public long bWeek;                 //    bWeek As Long
        public long bHour;                 //    bHour As Long
        public long bMin;                  //    bMin As Long
        public long bSec;                  //    bSec As Long
    }
}
