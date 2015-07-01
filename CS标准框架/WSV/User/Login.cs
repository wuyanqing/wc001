using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using WSV.BaseClass;
using WSV.Model.User;
using WSV.BLL.User;

namespace WSV.User
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private Thread demoThread = null;
        delegate void SetTextCallback(bool v);
        private SetTextCallback setTextCallBack;
        private void Login_Load(object sender, EventArgs e)
        {
            BLL.PublicFun.IniFile Ini = new BLL.PublicFun.IniFile(WSV.Model.FilePath.Config);
            if (Ini.ExistIniFile())
            {
                Tb_Uid.Text = Ini.IniReadValue("systemload", "username");
            }
            lab_Mess.Text = "服务器连接中......";
            this.demoThread = new Thread(new ThreadStart(this.ThreadProcUnsafe));
            setTextCallBack = new SetTextCallback(SetText);
            this.demoThread.Start();
        }
        //回车登陆
        private void Tb_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Btn_Login_Click(sender, e);
        }
        //登陆
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            D_User UsersItem = new D_User();
            UsersItem.Uid = this.Tb_Uid.Text.Trim();
            UsersItem.Pwd = this.Tb_Pwd.Text.Trim();
            if (UsersItem.Uid == "" || UsersItem.Pwd == "")
            {
                Function.MessageWarning("用户名和密码不允许为空！");
                return;
            }
            UsersItem.Pwd = Function.Md5(UsersItem.Pwd);
            if (UsersBLL.UserLogin(UsersItem))
            {
                BLL.PublicFun.IniFile Ini = new BLL.PublicFun.IniFile(WSV.Model.FilePath.Config);
                if (Ini.ExistIniFile())
                {
                    Ini.IniWriteValue("systemload", "username", Tb_Uid.Text);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Function.MessageWarning("用户名或密码不正确！");
            }
        }
        //退出
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //检查数据连接
        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        
        private void ThreadProcUnsafe()
        {
            this.Invoke(setTextCallBack, new object[] { UsersBLL.CheckDb() });
        }

        private void SetText(bool v)
        {
            if (!v)
            {
                lab_Mess.Text = "服务器连接失败，请检测服务器连接！";
                Application.DoEvents();
                Thread.Sleep(2000);
                this.Close();
                System.Diagnostics.Process.Start(Application.StartupPath + @"\DBsetup.exe");
                
            }
            else
            {
                lab_Mess.Text = "服务器连接成功，请登陆！";
                this.Tb_Uid.Enabled = true;
                this.Tb_Pwd.Enabled = true;
                this.Btn_Login.Enabled = true;
                this.Btn_Exit.Enabled = true;
            }
            //lab_Mess.Text += v;
        }
    }
}