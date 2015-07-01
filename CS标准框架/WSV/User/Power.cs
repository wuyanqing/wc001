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
    public partial class Power : Form
    {
        private string My_RunCode = "";//操作日志编号
        private long Id;
        private string Fid;
        public Power()
        {
            InitializeComponent();
        }
        //窗体加载
        private void Power_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Btn_Add.Enabled = false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            Id = 0;
            TreeViewBind();
        }
        //绑定数据
        private void DataBind(string Fid)
        {
            string sql = " where ParentCode='" + Fid + "'";
            this.Gv_Power.AutoGenerateColumns = false;
            this.Gv_Power.DataSource = PowerBLL.SelectAll(sql).Tables[0];
        }
        //绑定TreeView
        private void TreeViewBind()
        {
            DataSet ds = PowerBLL.SelectAll("");
            ds.Tables[0].Columns["Code"].SetOrdinal(0);
            ds.Tables[0].Columns["Name"].SetOrdinal(1);
            TreeNode Node = new TreeNode();
            Node.Text = "系统权限";
            Node.Tag = 0;
            this.Tv_Power.Binding(ref ds, "ParentCode", Node);
        }
        //选中节点
        private void Tv_Power_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                if (e.Node.Parent.Tag.ToString() != "0") { return; }
            }
            Fid = e.Node.Tag.ToString();
            this.Tb_Parent.Text = e.Node.Text;
            DataBind(Fid);
        }
        //添加
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.Btn_Add.Enabled = false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            Id = 0;
            this.Tb_Code.ReadOnly = false;
            ResetData();
        }
        //修改
        private void Gv_Power_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Btn_Edit.Enabled = false;
            this.Btn_Add.Enabled = true;
            this.Btn_Save.Enabled = true;
            this.Tb_Code.ReadOnly = true;
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewCellCollection Dgc = this.Gv_Power.Rows[i].Cells;
                Id = Convert.ToInt64(Dgc["Col_Id"].Value);
                this.Tb_Code.Text = Dgc["Col_Code"].Value.ToString();
                this.Tb_Name.Text = Dgc["Col_Name"].Value.ToString();
                this.Tb_RuleName.Text = Dgc["Col_RuleName"].Value.ToString();
            }
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            DC_Power PowerItem = new DC_Power();
            PowerItem.Code = this.Tb_Code.Text.Trim();
            PowerItem.Name = this.Tb_Name.Text.Trim();
            PowerItem.RuleName = this.Tb_RuleName.Text.Trim();
            if (PowerItem.Code == "" || PowerItem.Name == "")
            {
                Function.MessageWarning("请把数据填写完整！");
                return;
            }
            if (Id == 0)
            {
                if (Function.CheckKey("DC_Power", "Code", PowerItem.Code,0))
                {
                    Function.MessageWarning("该编号已存在！");
                    return;
                }
                PowerItem.ParentCode = Fid;
                if (PowerBLL.Insert(PowerItem))
                {
                    Function.Message("添加成功！");
                    ResetData();
                    TreeViewBind();
                }
            }
            else
            {
                PowerItem.Id = Id;
                if (PowerBLL.Update(PowerItem))
                {
                    Function.Message("修改成功！");
                    TreeViewBind();
                }
            }
        }
        //删除
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Function.MessageYesNo("您确定要删除选中数据！"))
            {
                if (PowerBLL.Del(this.Gv_Power.SelectValues("Col_Id")))
                {
                    Function.Message("删除成功！");
                    TreeViewBind();
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Power_Load(sender, e);
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
            this.Tb_Code.Text = "";
            this.Tb_Name.Text = "";
            this.Tb_RuleName.Text = "";
        }
        //关闭
        private void Power_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}