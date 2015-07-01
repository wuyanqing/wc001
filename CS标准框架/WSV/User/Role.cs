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
    public partial class Role : Form
    {
        private string My_RunCode = "";//操作日志编号
        private string ParentCode,Parent;
        public Role()
        {
            InitializeComponent();
        }
        //窗体加载
        private void Role_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            TreeViewBind();
        }
        //绑定数据
        private void DataBind(string Fid)
        {
            string sql = " where ParentCode='" + Fid + "'";
            this.Gv_Role.AutoGenerateColumns = false;
            this.Gv_Role.DataSource = RoleBLL.SelectAll(sql).Tables[0]; 
        }
        //绑定TreeView
        private void TreeViewBind()
        {
            DataSet ds = RoleBLL.SelectAll("");
            ds.Tables[0].Columns["Code"].SetOrdinal(0);
            ds.Tables[0].Columns["Name"].SetOrdinal(1);
            TreeNode Node = new TreeNode();
            Node.Text = "系统角色";
            Node.Tag = 0;
            this.Tv_Role.Binding(ref ds, "ParentCode", Node);
        }
        //选中节点
        private void Tv_Role_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                if (e.Node.Parent.Tag.ToString() != "0") { return; }
            }
            ParentCode = e.Node.Tag.ToString();
            Parent = e.Node.Text;
            DataBind(ParentCode);
        }
        //添加
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Role_Show RoleShowFrm = new Role_Show();
            RoleShowFrm.ParentCode = ParentCode;
            RoleShowFrm.Parent = Parent;
            RoleShowFrm.ShowDialog() ;
            TreeViewBind();
        }
        //修改
        private void Gv_Role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                Role_Show RoleShowFrm = new Role_Show();
                RoleShowFrm.Id = Convert.ToInt32(this.Gv_Role.Rows[i].Cells["Col_Id"].Value);
                RoleShowFrm.ParentCode = ParentCode;
                RoleShowFrm.Parent = Parent;
                RoleShowFrm.ShowDialog();
                TreeViewBind();
            }
        }
        //删除
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Function.MessageYesNo("您确定要删除选中数据！"))
            {
                if (RoleBLL.Del(this.Gv_Role.SelectValues("Col_Id")))
                {
                    Function.Message("删除成功！");
                    TreeViewBind();
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Role_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void Role_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}