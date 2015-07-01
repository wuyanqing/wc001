using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BaseClass;
using WSV.Model.User;
using WSV.BLL.User;

namespace WSV.User
{
    public partial class RePwd : Form
    {
        private string My_RunCode = "";//操作日志编号
        public RePwd()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
        //窗口加载
        private void RePwd_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            D_User UsersItem = new D_User();
            UsersItem.Id = LUser.Id;
            UsersItem.OldPwd = this.Tb_OldPwd.Text.Trim().Replace("'", "");
            UsersItem.Pwd = this.Tb_Pwd.Text.Trim().Replace("'", "");
            UsersItem.CheckPwd = this.Tb_CheckPwd.Text.Trim().Replace("'", "");
            if (UsersItem.OldPwd == "" || UsersItem.Pwd == "" || UsersItem.CheckPwd == "")
            {
                Function.MessageWarning("请把信息填写完整！");
                return;
            }
            if (!UsersBLL.CheckPwd(Function.Md5(UsersItem.OldPwd)))
            {
                Function.MessageWarning("原始密码不正确！");
                return;
            }
            if (!Function.IsRegEx("^[a-zA-Z0-9]{3,32}$", UsersItem.Pwd))
            {
                Function.MessageWarning("用户密码格式不正确,应是3-12位的字母或数字！");
                return;
            }
            if (UsersItem.Pwd != UsersItem.CheckPwd)
            {
                Function.MessageWarning("两次输入密码不一致！");
                return;
            }
            UsersItem.Pwd = Function.Md5(UsersItem.Pwd);
            if (UsersBLL.RePwd(UsersItem)) { Function.Message("密码修改成功！"); this.Close(); }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            RePwd_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void RePwd_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}