using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WSV
{
    public partial class MenuMain : Form
    {
        BLL.PublicFun.IniFile inout = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");
        //private MyComm.MyComm myVersion;
        private VideoCom.Video V_Dog;
        private Timer T_Dog;
        public MenuMain()
        {
            InitializeComponent();
            //myVersion = new MyComm.MyComm();
            //V_Dog = new VideoCom.Video();
            //this.Tag = StaticMain.MainFrm.Version;              //版本号
            //this.Controls.Add(this.myVersion);
            //T_Dog = new Timer();
            //T_Dog.Interval = 500;
            //T_Dog.Tick += new EventHandler(T_Dog_Tick);
            //T_Dog.Enabled = true;
            //this.Pander_Plan.Visible = false;
        }
        #region 界面方法
        private void MenuMain_Load(object sender, EventArgs e)
        {
            Pander_Plan.Visible = false;
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\data"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\data");
            }
            if (Model.User.LUser.Id == 1)
                but_Power.Visible = true;
            else
                but_Power.Visible = false;
        }
        //窗体大小改变时
        private void MenuMain_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.ControlBox = false;
            //    this.FormBorderStyle = FormBorderStyle.None;
            //}
            //else
            //{
            //    this.ControlBox = true;
            //    this.FormBorderStyle = FormBorderStyle.Sizable;
            //}
            //this.WindowState = FormWindowState.Maximized;
        }
        //窗体得到焦点时最大化
        private void MenuMain_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //MID改变时，控件随之变
        private void panel_Fill_Resize(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.Controls)
            {
                foreach (System.Windows.Forms.Control Ctl in XP.Controls)
                {
                    if (Ctl is Control.Label.Label)
                    {
                        Control.Label.Label LL = (Control.Label.Label)Ctl;
                        float FL = this.Mid_PanelList.Width * LL.LScale;
                        float FT = this.Mid_PanelList.Height * LL.TScale;
                        LL.Left = (int)FL;
                        LL.Top = (int)FT;
                    }
                }
            }

        }

        private void T_Dog_Tick(object sender, EventArgs e)
        {
            //int i_Dog = this.myVersion.READ_DOG();
            //int V_Dog = this.V_Dog.READ_DOG();
            //string DW = this.V_Dog.Company.ToString();
            //string D_DW = inout.IniReadValue("Company", "Company");
            //if (V_Dog > 0)
            //{
            //    StaticMain.MainFrm.FrmMain.lab_Version.Text = "试用版:" + V_Dog.ToString() + "天";
            //}
            //else if (V_Dog == 0 && DW == D_DW)
            //{
                //StaticMain.MainFrm.FrmMain.lab_Version.Text = "正式版";
            //}
            //else
            //{
            //    StaticMain.MainFrm.FrmMain.lab_Version.ForeColor = Color.Red;
            //    StaticMain.MainFrm.FrmMain.lab_Version.Text = "过期版";
            //    panel_Left.Enabled = false;
            //    panel_Fill.Enabled = false;
            //    panel_Right.Enabled = false;
            //}
            //T_Dog.Interval = 90000;
        }
        #endregion

        #region 左面工具栏私有方法
        //车辆过磅
        private void Pander_Weight_Click(object sender, EventArgs e)
        {
            //foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            //{
            //    if (XP.Name == "Mid_Weight")
            //    {
            //        XP.Visible = true;
            //        Mid_PanelList.Expand(XP);
            //    }
            //    else
            //        XP.Visible = false;
            //}
        }
        //查询
        private void Pander_Search_Click(object sender, EventArgs e)
        {
            //foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            //{
            //    if (XP.Name == "Mid_Search")
            //    {
            //        XP.Visible = true;
            //        Mid_PanelList.Expand(XP);
            //    }
            //    else
            //        XP.Visible = false;
            //}
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_BaseInfo")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //汇总
        private void Pander_Count_Click(object sender, EventArgs e)
        {
            //foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            //{
            //    if (XP.Name == "Mid_Count")
            //    {
            //        XP.Visible = true;
            //        Mid_PanelList.Expand(XP);
            //    }
            //    else
            //        XP.Visible = false;
            //}
        }
        //基础档案
        private void Pander_BaseInfo_Click(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_BaseInfo")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //计划管理
        private void Pander_Plan_Click(object sender, EventArgs e)
        {
            //Pander_Plan.Visible = false;
            //foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            //{
            //    if (XP.Name == "Mid_Plan")
            //    {
            //        XP.Visible = true;
            //        Mid_PanelList.Expand(XP);
            //    }
            //    else
            //        XP.Visible = false;
            //}
        }
        //数据维护
        private void Pander_Defend_Click(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_Defend")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //系统日志
        private void Pander_Log_Click(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_Log")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //用户管理
        private void Pander_User_Click(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_User")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //系统管理
        private void Pander_System_Click(object sender, EventArgs e)
        {
            foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            {
                if (XP.Name == "Mid_System")
                {
                    XP.Visible = true;
                    Mid_PanelList.Expand(XP);
                }
                else
                    XP.Visible = false;
            }
        }
        //设备管理
        private void Pander_HardWare_Click(object sender, EventArgs e)
        {
            //foreach (Windows.Forms.XPanderPanel XP in this.Mid_PanelList.XPanderPanels)
            //{
            //    if (XP.Name == "Mid_HardWare")
            //    {
            //        XP.Visible = true;
            //        Mid_PanelList.Expand(XP);
            //    }
            //    else
            //        XP.Visible = false;
            //}
        }
        #endregion

        #region 界面按钮方法
        //过磅称重
        private void but_RWeight_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_RWeight.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //if (string.IsNullOrEmpty(Model.User.CUser.Name))
            //{
            //    Weight.Acceper AcceperWin = new WSV.Weight.Acceper();
            //    AcceperWin.ShowDialog();
            //}
            //else
            //{
            //    Weight.V_C_Weight Wei = new Weight.V_C_Weight();
            //    if (StaticMain.MainFrm.HaveOpened(Wei.Name))
            //    {
            //        Wei.MdiParent = StaticMain.MainFrm.FrmMain;
            //        Wei.WindowState = FormWindowState.Maximized;
            //        Wei.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //        Wei.Show();
            //    }
            //}
        }

        //数据查询
        private void but_RSearch_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_RSearch.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Search.Search_Conditions SearchFrm = new WSV.Search.Search_Conditions();
            ////SearchFrm.MdiParent = this.MdiParent;
            //SearchFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //SearchFrm.ShowDialog();
        }

        //数据报表
        private void but_RCount_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_RCount.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Count.FrmCount CountFrm = new Count.FrmCount();
            //CountFrm.Flag = 0;
            //CountFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //CountFrm.ShowDialog();
        }
        //图形报表
        private void Btn_VCount_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_VCount.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Count.FrmCount CountFrm = new Count.FrmCount();
            //CountFrm.Flag = 1;
            //CountFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //CountFrm.ShowDialog();
        }
        //当日统计
        private void but_RDayCount_Click(object sender, EventArgs e)
        {

        }

        //档案管理
        private void but_Base_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Base.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Record.Record_BaseInfo BaseInfoFrm = new Record.Record_BaseInfo();
            //if (StaticMain.MainFrm.HaveOpened(BaseInfoFrm.Name))
            //{
            //    BaseInfoFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    BaseInfoFrm.WindowState = FormWindowState.Maximized;
            //    BaseInfoFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    BaseInfoFrm.Show();
            //}
        }
        //类型管理
        private void but_Type_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Type.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Record.TypeInfo TypeInfoFrm = new WSV.Record.TypeInfo();
            //if (StaticMain.MainFrm.HaveOpened(TypeInfoFrm.Name))
            //{
            //    TypeInfoFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    TypeInfoFrm.WindowState = FormWindowState.Maximized;
            //    TypeInfoFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    TypeInfoFrm.Show();
            //}
            //Record.CubetyInfo CubetyInfoFrm = new WSV.Record.CubetyInfo();
            //if (StaticMain.MainFrm.HaveOpened(CubetyInfoFrm.Name))
            //{
            //    CubetyInfoFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    CubetyInfoFrm.WindowState = FormWindowState.Maximized;
            //    CubetyInfoFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    CubetyInfoFrm.Show();
            //}
        }
        //车辆管理
        private void but_CarCode_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_CarCode.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Record.Record_CarCode_Manage CarFrm = new WSV.Record.Record_CarCode_Manage();
            //if (StaticMain.MainFrm.HaveOpened(CarFrm.Name))
            //{
            //    CarFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    CarFrm.WindowState = FormWindowState.Maximized;
            //    CarFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    CarFrm.Show();
            //}
        }
        //卡号管理
        private void but_Card_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Card.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.Weight.CardInfo CardFrm = new WSV.Weight.CardInfo();
            //if (StaticMain.MainFrm.HaveOpened(CardFrm.Name))
            //{
            //    CardFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    CardFrm.WindowState = FormWindowState.Maximized;
            //    CardFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    CardFrm.Show();
            //}
        }
        //计划管理
        private void Btn_Plan_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_Plan.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Plan.PlanInfo PlanWin = new WSV.Plan.PlanInfo();
            //if (StaticMain.MainFrm.HaveOpened(PlanWin.Name))
            //{
            //    PlanWin.MdiParent = StaticMain.MainFrm.FrmMain;
            //    PlanWin.WindowState = FormWindowState.Maximized;
            //    PlanWin.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    PlanWin.Show();
            //}
        }

        //添加数据
        private void but_Add_Click(object sender, EventArgs e)
        {
        //    if (!BLL.User.RoleBLL.CheckRolePower(this.but_Add.Tag.ToString().Trim()))
        //    {
        //        MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //        return;
        //    }
        //    WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
        //    operdata.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
        //    operdata.judgedata = "0";
        //    operdata.ShowDialog();
        }
        //修改数据
        private void but_Edit_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Edit.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //operdata.judgedata = "1";
            //operdata.receivedata = "";
            //operdata.ShowDialog();
        }
        //审核数据
        private void but_Check_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Check.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //operdata.judgedata = "2";
            //operdata.receivedata = "";
            //operdata.ShowDialog();
        }
        //作废数据
        private void but_Used_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Used.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //operdata.judgedata = "4";
            //operdata.receivedata = "";
            //operdata.ShowDialog();
        }
        //磅单补打
        private void but_RPrintMend_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_RPrintMend.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //operdata.judgedata = "6";
            //operdata.receivedata = "";
            //operdata.ShowDialog();
        }

        //操作日志
        private void but_LogDeal_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_LogDeal.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //MyLog.Mylog Mylog = new WSV.MyLog.Mylog();
            //if (StaticMain.MainFrm.HaveOpened(Mylog.Name))
            //{
            //    Mylog.MdiParent = StaticMain.MainFrm.FrmMain;
            //    Mylog.WindowState = FormWindowState.Maximized;
            //    Mylog.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    Mylog.Show();
            //}

        }
        //过磅日志
        private void but_LogWeight_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_LogWeight.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //MyLog.WeightNote WeightNote = new WSV.MyLog.WeightNote();
            //if (StaticMain.MainFrm.HaveOpened(WeightNote.Name))
            //{
            //    WeightNote.MdiParent = StaticMain.MainFrm.FrmMain;
            //    WeightNote.WindowState = FormWindowState.Maximized;
            //    WeightNote.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    WeightNote.Show();
            //}
        }
        //维护日志
        private void but_LogDefend_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_LogDefend.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //MyLog.MyOper MyOper = new WSV.MyLog.MyOper();
            //if (StaticMain.MainFrm.HaveOpened(MyOper.Name))
            //{
            //    MyOper.MdiParent = StaticMain.MainFrm.FrmMain;
            //    MyOper.WindowState = FormWindowState.Maximized;
            //    MyOper.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    MyOper.Show();
            //}

        }


        //用户管理
        private void but_Users_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.but_Users.Tag.ToString().Trim()))
            {
                MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            User.Users UsersFrm = new WSV.User.Users();
            if (StaticMain.MainFrm.HaveOpened(UsersFrm.Name))
            {
                UsersFrm.MdiParent = StaticMain.MainFrm.FrmMain;
                UsersFrm.WindowState = FormWindowState.Maximized;
                UsersFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                UsersFrm.Show();
            }
        }
        //角色管理
        private void but_Role_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.but_Role.Tag.ToString().Trim()))
            {
                MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            User.Role RoleFrm = new WSV.User.Role();
            if (StaticMain.MainFrm.HaveOpened(RoleFrm.Name))
            {
                RoleFrm.MdiParent = this.MdiParent;
                RoleFrm.WindowState = FormWindowState.Maximized;
                RoleFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                RoleFrm.Show();
            }
        }
        //权限管理
        private void but_Power_Click(object sender, EventArgs e)
        {
            if (Model.User.LUser.Id != 1)
                return;
            User.Power PowerFrm = new WSV.User.Power();
            if (StaticMain.MainFrm.HaveOpened(PowerFrm.Name))
            {
                PowerFrm.MdiParent = StaticMain.MainFrm.FrmMain; ;
                PowerFrm.WindowState = FormWindowState.Maximized;
                PowerFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                PowerFrm.Show();
            }
        }


        //磅单管理
        private void but_Bill_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Bill.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.SysInfo.Bill BillFrm = new WSV.SysInfo.Bill();
            //if (StaticMain.MainFrm.HaveOpened(BillFrm.Name))
            //{
            //    BillFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    BillFrm.WindowState = FormWindowState.Maximized;
            //    BillFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    BillFrm.Show();
            //}
        }
        //称重设置
        private void but_WeiParam_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_WeiParam.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}

            //WSV.SysInfo.Weight WeightFrm = new WSV.SysInfo.Weight();
            //if (StaticMain.MainFrm.HaveOpened(WeightFrm.Name))
            //{
            //    WeightFrm.MdiParent = StaticMain.MainFrm.FrmMain;
            //    WeightFrm.WindowState = FormWindowState.Maximized;
            //    WeightFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    WeightFrm.Show();
            //}
        }
        //系统别名
        private void but_AS_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.but_AS.Tag.ToString().Trim()))
            {
                MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            SysInfo.Alias AliasFrm = new WSV.SysInfo.Alias();
            if (StaticMain.MainFrm.HaveOpened(AliasFrm.Name))
            {
                AliasFrm.MdiParent = StaticMain.MainFrm.FrmMain;
                AliasFrm.WindowState = FormWindowState.Maximized;
                AliasFrm.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                AliasFrm.Show();
            }
        }
        //单位设置
        private void but_Info_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Info.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //SysInfo.BaseInfo BaseInfo = new WSV.SysInfo.BaseInfo();
            //BaseInfo.ShowDialog();
        }
        //系统参数
        private void but_Param_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.but_Param.Tag.ToString().Trim()))
            {
                MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            //SysInfo.DataFormat DataFormat = new WSV.SysInfo.DataFormat();
            //DataFormat.ShowDialog();
            SysInfo.SysParam SysParam = new WSV.SysInfo.SysParam();
            SysParam.ShowDialog();

        }
        //数据库管理
        private void but_DB_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.but_DB.Tag.ToString().Trim()))
            {
                MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            System.Diagnostics.Process pro = new System.Diagnostics.Process();
            pro.StartInfo.UseShellExecute = false;
            pro.StartInfo.RedirectStandardError = true;
            pro.StartInfo.RedirectStandardInput = true;
            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\DBsetup.exe";
            //pro.StartInfo.Arguments = Arguments;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            //System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\DBsetup.exe");
        }
        //磅台设置
        private void but_Table_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Table.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //SysInfo.LoadoMeter LoadoMeter = new WSV.SysInfo.LoadoMeter();
            //if (StaticMain.MainFrm.HaveOpened(LoadoMeter.Name))
            //{
            //    LoadoMeter.MdiParent = StaticMain.MainFrm.FrmMain;
            //    LoadoMeter.WindowState = FormWindowState.Maximized;
            //    LoadoMeter.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    LoadoMeter.Show();
            //}
        }
        //磅单设计
        private void but_BillInfo_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_BillInfo.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //SysInfo.BillInfo BillInfo = new WSV.SysInfo.BillInfo();
            //if (StaticMain.MainFrm.HaveOpened(BillInfo.Name))
            //{
            //    BillInfo.MdiParent = StaticMain.MainFrm.FrmMain;
            //    BillInfo.WindowState = FormWindowState.Maximized;
            //    BillInfo.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
            //    BillInfo.Show();
            //}
        }

        //仪表设置
        private void but_Meter_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_Meter.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Hardware.Meter meter = new WSV.Hardware.Meter();
            //meter.ShowDialog();
        }
        //刷卡设置
        private void but_IDCard_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_IDCard.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Hardware.IdCard IdCard = new WSV.Hardware.IdCard();
            //IdCard.ShowDialog();
        }
        private void Btn_Rfid_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_Rfid.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Hardware.Rfid RfidWin = new WSV.Hardware.Rfid();
            //RfidWin.ShowDialog();
        }

        //红外设置
        private void but_HunWai_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_HunWai.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Hardware.Infrared Infrared = new WSV.Hardware.Infrared();
            //Infrared.ShowDialog();

        }
        //道闸设置
        private void but_DaoZha_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.but_DaoZha.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //Hardware.RoadSluice RoadSluice = new WSV.Hardware.RoadSluice();
            //RoadSluice.ShowDialog();
        }
        //视频设置
        private void btn_VideoSet_Click(object sender, EventArgs e)
        {
            //if (!BLL.User.RoleBLL.CheckRolePower(this.btn_VideoSet.Tag.ToString().Trim()))
            //{
            //    MessageBox.Show("无此权限", "称重提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //WSV.Video.Video_set VideoSetWin = new WSV.Video.Video_set();
            //VideoSetWin.ShowDialog();
        }

        //修改口令
        private void but_RePwd_Click(object sender, EventArgs e)
        {
            User.RePwd RePwd = new WSV.User.RePwd();
            RePwd.ShowDialog();
        }
        //换班
        private void but_RRelief_Click(object sender, EventArgs e)
        {
            User.Login Login = new User.Login();
            Login.ShowDialog();
            StaticMain.MainFrm.FrmMain.lab_Operator.Text = Model.User.LUser.Name;
            if (Model.User.LUser.Id == 1)
                but_Power.Visible = true;
            else
                but_Power.Visible = false;
        }
        //锁定
        private void but_RLock_Click(object sender, EventArgs e)
        {
            if (BaseClass.Function.MessageYesNo("确定要锁定？"))
            {
                User.SysLock Lock = new WSV.User.SysLock();
                Lock.ShowDialog();
            }
        }
        //端口测试
        private void but_RPort_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process pro = new System.Diagnostics.Process();
            //pro.StartInfo.UseShellExecute = false;
            //pro.StartInfo.RedirectStandardError = true;
            //pro.StartInfo.RedirectStandardInput = true;
            //pro.StartInfo.RedirectStandardOutput = true;
            //pro.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\COMM.exe";
            ////pro.StartInfo.Arguments = Arguments;
            //pro.StartInfo.CreateNoWindow = true;
            //pro.Start();
        }
        //计算器
        private void but_RComputer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            //System.Diagnostics.Process pro = new System.Diagnostics.Process();
            //pro.StartInfo.UseShellExecute = false;
            //pro.StartInfo.RedirectStandardError = true;
            //pro.StartInfo.RedirectStandardInput = true;
            //pro.StartInfo.RedirectStandardOutput = true;
            //pro.StartInfo.FileName = "calc.exe";
            //pro.StartInfo.Arguments = Arguments;
            //pro.StartInfo.CreateNoWindow = true;
            //pro.Start();  
        }

        #endregion

        private void but_RHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("企业版V11.0说明书.CHM");
            }
            catch
            {
                BaseClass.Function.MessageWarning("找不到指定文件！");
            }
        }

        private void Btn_Voice_Click(object sender, EventArgs e)
        {
            WSV.SysInfo.Voice VoiceWin = new WSV.SysInfo.Voice();
            VoiceWin.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WSV.SysInfo.Port PortWin = new WSV.SysInfo.Port();
            PortWin.ShowDialog();
        }
        #region 自定义私有方法

        #endregion
    }
}