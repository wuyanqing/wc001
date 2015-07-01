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
    public partial class Users : Form
    {
        private string My_RunCode = "";//操作日志编号
        private long Id;
        public Users()
        {
            InitializeComponent();
            this.Cmb_Role.DataBindings(RoleBLL.SelectAll(""), "Name", "Code");
        }
        //窗体加载
        private void Users_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Btn_Add.Enabled = false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            Id= 0;
            DataBind();
        }
        //绑定数据
        private void DataBind()
        {
            this.Gv_Users.AutoGenerateColumns = false;
            this.Gv_Users.DataSource = UsersBLL.SelectAll().Tables[0];
        }
        //添加
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.Btn_Add.Enabled =false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            ResetData();
            Id= 0;
        }
        //修改
        private void Gv_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Btn_Edit.Enabled = false;
            this.Btn_Add.Enabled = true;
            this.Btn_Save.Enabled = true;
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewCellCollection Dgc = this.Gv_Users.Rows[i].Cells;
                Id = Convert.ToInt64(Dgc["Col_Id"].Value);
                this.Tb_Code.Text = Dgc["Col_Code"].Value.ToString();
                this.Tb_Name.Text = Dgc["Col_Name"].Value.ToString();
                this.Tb_Uid.Text = Dgc["Col_Uid"].Value.ToString();
                this.Tb_Pwd.Text = Dgc["Col_Pwd"].Value.ToString();
                this.Cmb_Role.SelectedByValue(Dgc["Col_Role"].Value);
                this.Cb_Used.Checked = (bool)Dgc["Col_Used"].Value;
            }
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            D_User UsersItem = new D_User();
            UsersItem.Code = this.Tb_Code.Text.Trim();
            UsersItem.Name = this.Tb_Name.Text.Trim();
            UsersItem.Uid = this.Tb_Uid.Text.Trim();
            UsersItem.Pwd = this.Tb_Pwd.Text.Trim();
            UsersItem.Role = this.Cmb_Role.SelectedValue.ToString();
            UsersItem.Used = this.Cb_Used.Checked;

            if (UsersItem.Code == "" || UsersItem.Name == "" || UsersItem.Uid == "" || UsersItem.Pwd == "")
            {
                Function.MessageWarning("请把数据填写完整！");
                return;
            }
            if (UsersItem.Role == "0")
            {
                Function.MessageWarning("请选择用户角色！");
                return;
            }
            if (!Function.IsRegEx("^[a-zA-Z0-9]{2,12}$", UsersItem.Uid))
            {
                Function.MessageWarning("用户名必须是2-12位的字母或数字！");
                return;
            }
            if (!Function.IsRegEx("^[a-zA-Z0-9]{3,32}$", UsersItem.Pwd))
            {
                Function.MessageWarning("用户密码格式不正确,应是3-12位的字母或数字！");
                return;
            }
            if (Function.CheckKey("D_User", "Code", UsersItem.Code, Id))
            {
                Function.MessageWarning("该编号已存在！");
                return;
            }
            if (Function.CheckKey("D_User", "Uid", UsersItem.Uid, Id))
            {
                Function.MessageWarning("该用户名已存在！");
                return;
            }
            UsersItem.Pwd = BaseClass.Function.Md5(UsersItem.Pwd);
            if (Id== 0)
            {
                if (UsersBLL.Insert(UsersItem))
                {
                    Function.Message("添加成功！");
                    ResetData();
                    DataBind();
                }
            }
            else
            {
                UsersItem.Id = Id;
                if (UsersBLL.Update(UsersItem))
                {
                    Function.Message("修改成功！");
                    DataBind();
                }
            }
        }
        //删除
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Function.MessageYesNo("您确定要删除选中数据！"))
            {
                if (UsersBLL.Del(this.Gv_Users.SelectValues("Col_Id")))
                {
                    Function.Message("删除成功！");
                    DataBind();
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Users_Load(sender, e);
            ResetData();
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //重置数据
        private void ResetData()
        {
            this.Tb_Code.Text ="";
            this.Tb_Name.Text ="";
            this.Tb_Uid.Text ="";
            this.Tb_Pwd.Text = "";
            this.Cmb_Role.SelectedIndex=0;
            this.Cb_Used.Checked =true;
        }
        //关闭
        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}