using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BaseClass;
using WSV.Model.SysInfo;
using WSV.BLL.SysInfo;

namespace WSV.SysInfo
{
    public partial class Alias : Form
    {
        private string My_RunCode = "";//操作日志编号
        public Alias()
        {
            InitializeComponent();
        }
        //窗体加载
        private void Alias_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            DataBind();
        }
        //绑定数据
        private void DataBind()
        {
            this.Gv_Alias.AutoGenerateColumns = false;
            this.Gv_Alias.DataSource = AliasBLL.SelectAll().Tables[0];
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            C_Alias AliasItem;
            DataGridViewRowCollection dgr = this.Gv_Alias.Rows;
            DataGridViewCellCollection Dgc;
            this.Gv_Alias.EndEdit();
            for (int i = 0; i < dgr.Count; i++)
            {
                AliasItem = new C_Alias();
                Dgc = this.Gv_Alias.Rows[i].Cells;
                AliasItem.Id = Convert.ToInt64(Dgc["Col_Id"].Value);
                AliasItem.Name =Dgc["Col_Name"].FormattedValue.ToString().Trim();
                AliasItem.State=(bool)Dgc["Col_State"].Value;
                if (AliasItem.Name == "")
                {
                    Function.MessageWarning("名称不允许为空！");
                    return;
                }
                if (!AliasBLL.Update(AliasItem)) { Flag = false; return; }
            }
            if (Flag)
            {
                Function.Message("修改成功！");
                DataBind();
            }

        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Alias_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void Alias_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}