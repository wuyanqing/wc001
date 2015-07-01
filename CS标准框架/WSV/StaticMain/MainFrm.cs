using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace WSV.StaticMain
{
    public static class MainFrm
    {
        public const string Version = "VideoWeight";       //版本
        public static Main FrmMain;

        //判断子窗体是否打开
        public static bool HaveOpened(string SonName)
        {
            //查看窗口是否已经被打开
            bool bReturn = true;
            for (int i = 0; i < FrmMain.MdiChildren.Length; i++)
            {
                if (FrmMain.MdiChildren[i].Name == SonName)
                {
                    FrmMain.MdiChildren[i].BringToFront();
                    bReturn = false;
                    break;
                }
            }
            return bReturn;
        }


        //替换子窗体ICO
        public static void Child_Activated(object sender, EventArgs e)
        {

            ((Form)sender).Icon = Properties.Resources.wucheng;

        }
    }
}
