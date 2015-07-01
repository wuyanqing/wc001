using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            StaticMain.MainFrm.FrmMain = this;
        }

        string My_RunCode = "";             //操作日志编号
        #region 私有方法
        //窗体Load时
        private void Main_Load(object sender, EventArgs e)
        {
            Initialize();
            MenuMain M_Main = new MenuMain();
            if (StaticMain.MainFrm.HaveOpened(M_Main.Name))
            {
                M_Main.MdiParent = this;
                M_Main.WindowState = FormWindowState.Maximized;
                M_Main.Show();
            }
            Model.SysInfo.DC_BaseInfo BaseInfoItem = new Model.SysInfo.DC_BaseInfo();
            DataRow dr = BLL.SysInfo.BaseInfoBLL.SelectAll(" where Id=1").Tables[0].Rows[0];
            this.Menu_System.Text = dr["Company"].ToString() + "设备信息管理专用系统";
            //插入操作记录
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
        }
        //窗体关闭前提示
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出设备信息管理系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        //当窗体大小改变时,窗体的大小最小为800*600
        private void Main_Resize(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            if (this.Size.Width < 800)
                this.Size = new Size(800, this.Size.Height);
            if (this.Size.Height < 600)
                this.Size = new Size(this.Width, 600);
        }
        //是否锁定
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.L)
            {
                if (BaseClass.Function.MessageYesNo("确定要锁定？"))
                {
                    User.SysLock Lock = new WSV.User.SysLock();
                    Lock.ShowDialog();
                }
            }
        }
        //状态栏中的时间
        private void t_Time_Tick(object sender, EventArgs e)
        {
            this.lab_Time.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region 自定义私有方法
        ////判断子窗体是否打开
        //public static bool HaveOpened(Form ParentForm, string SonName)
        //{
        //    //查看窗口是否已经被打开
        //    bool bReturn = true;
        //    for (int i = 0; i < ParentForm.MdiChildren.Length; i++)
        //    {
        //        if (ParentForm.MdiChildren[i].Name == SonName)
        //        {
        //            ParentForm.MdiChildren[i].BringToFront();
        //            bReturn = false;
        //            break;
        //        }
        //    }
        //    return bReturn;
        //}
        ////判断子窗体是否打开
        //public static bool HaveOpened(string SonName)
        //{
        //    //查看窗口是否已经被打开
        //    bool bReturn = true;
        //    for (int i = 0; i < StaticMain.MainFrm.FrmMain.MdiChildren.Length; i++)
        //    {
        //        if (StaticMain.MainFrm.FrmMain.MdiChildren[i].Name == SonName)
        //        {
        //            StaticMain.MainFrm.FrmMain.MdiChildren[i].BringToFront();
        //            bReturn = false;
        //            break;
        //        }
        //    }
        //    return bReturn;
        //}

        //初始
        private void Initialize()
        {
            DataRow dr = BLL.SysInfo.BaseInfoBLL.SelectAll(" where Id=1").Tables[0].Rows[0];
            lab_Client.Text = dr["Company"].ToString() + " " + dr["Tel"].ToString();

            dr = BLL.SysInfo.BaseInfoBLL.SelectAll(" where Id=2").Tables[0].Rows[0];
            lab_SoftWare.Text = dr["Company"].ToString() + " " + dr["Tel"].ToString();

            lab_Operator.Text = Model.User.LUser.Name;

            if (string.IsNullOrEmpty(Model.User.LUser.TableNum))
            {
                BaseClass.Function.MessageWarning("请为系统设置台号！");
                return;
            }
            this.lab_TableName.Text = Model.User.LUser.TableName;
        }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //操作记录
        }
    }
}