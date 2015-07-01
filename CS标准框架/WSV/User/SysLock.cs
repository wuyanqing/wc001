using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.Model.User;
using WSV.BLL.User;
using WSV.BaseClass;

namespace WSV.User
{
    public partial class SysLock : Form
    {
        public SysLock()
        {
            InitializeComponent();
        }

        private void but_NoLock_Click(object sender, EventArgs e)
        {
            string Pwd = Function.Md5(this.txt_Pwd.Text.Trim());
            if (UsersBLL.CheckPwd(Pwd))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.txt_Pwd.Text = "";
                this.txt_Pwd.Focus();
                Function.MessageWarning("密码不正确！");
            }
        }

        private void txt_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                but_NoLock_Click(sender, e);
        }
    }
}