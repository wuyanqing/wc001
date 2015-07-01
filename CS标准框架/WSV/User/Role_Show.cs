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
    public partial class Role_Show : Form
    {
        private long _Id;
        private string _ParentCode,_Parent;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Parent
        {
            get { return _Parent; }
            set { _Parent = value; }
        }
        public string ParentCode
        {
            get { return _ParentCode; }
            set { _ParentCode = value; }
        }
        public Role_Show()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
        //加载窗体
        private void Role_Show_Load(object sender, EventArgs e)
        {
            this.Tb_Parent.Text = Parent;
            if (Id > 0)
            {
                this.Tb_Code.ReadOnly = true;
                DataRow dr = RoleBLL.SelectAll(" where Id=" + Id).Tables[0].Rows[0];
                this.Tb_Code.Text = dr["Code"].ToString();
                this.Tb_Name.Text = dr["Name"].ToString();
                TreeViewBind(RoleBLL.RolePower(dr["Code"].ToString()));
            }
            else
            {
                TreeViewBind("");
            }
        }
        //绑定TreeView
        private void TreeViewBind(string SelectNodesValue)
        {
            DataSet ds = PowerBLL.SelectAll("");
            ds.Tables[0].Columns["Code"].SetOrdinal(0);
            ds.Tables[0].Columns["Name"].SetOrdinal(1);
            TreeNode Node = new TreeNode();
            Node.Text = "系统权限";
            Node.Tag = 0;
            this.Tv_Power.SelectNodesValue = SelectNodesValue;
            this.Tv_Power.CheckBoxes = true;
            this.Tv_Power.Binding(ref ds, "ParentCode", Node);
            this.Tv_Power.ExpandAll();
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            D_UserRole RoleItem = new D_UserRole();
            RoleItem.Code = this.Tb_Code.Text.Trim();
            RoleItem.Name = this.Tb_Name.Text.Trim();
            RoleItem.RolePower = this.Tv_Power.SelectValues;
            if (RoleItem.Code == "" || RoleItem.Name == "")
            {
                Function.MessageWarning("请把数据填写完整！");
                return;
            }
            if (Id == 0)
            {
                if (Function.CheckKey("D_UserRole", "Code", RoleItem.Code, 0))
                {
                    Function.MessageWarning("该编号已存在！");
                    return;
                }
                RoleItem.ParentCode = ParentCode;
                if (RoleBLL.Insert(RoleItem))
                {
                    Function.Message("添加成功！"); 
                    ResetData();
                    TreeViewBind("");
                }
            }
            else
            {
                RoleItem.Id = Id;
                if (RoleBLL.Update(RoleItem)) 
                {
                    Function.Message("修改成功！");
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Role_Show_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //重置数据
        private void ResetData()
        {
            this.Tb_Code.Text = "";
            this.Tb_Name.Text = "";
        }
    }
}