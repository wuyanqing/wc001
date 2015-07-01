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
    public partial class BaseInfo : Form
    {
        private string My_RunCode = "";//操作日志编号
        BLL.PublicFun.IniFile ini = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");
        public BaseInfo()
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
        private void BaseInfo_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            DC_BaseInfo BaseInfoItem = new DC_BaseInfo();
            DataRow dr =BaseInfoBLL.SelectAll(" where Id=1").Tables[0].Rows[0];
            this.Tb_Company.Text = dr["Company"].ToString();
            this.Tb_Address.Text =dr["Address"].ToString();
            this.Tb_Tel.Text = dr["Tel"].ToString();
            this.Tb_PrintTitle.Text = dr["PrintTitle"].ToString();

            dr = BaseInfoBLL.SelectAll(" where Id=2").Tables[0].Rows[0];
            this.Tb_DCompany.Text = dr["Company"].ToString();
            this.Tb_DAddress.Text = dr["Address"].ToString();
            this.Tb_DTel.Text = dr["Tel"].ToString();
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Tc_BaseInfo.SelectedIndex == 0)
            {
                DC_BaseInfo BaseInfoItem = new DC_BaseInfo();
                BaseInfoItem.Id = 1;
                BaseInfoItem.Company = this.Tb_Company.Text.Trim();
                BaseInfoItem.Address = this.Tb_Address.Text.Trim();
                BaseInfoItem.Tel = this.Tb_Tel.Text.Trim();
                BaseInfoItem.PrintTitle = this.Tb_PrintTitle.Text.Trim();
                if (BaseInfoItem.Company == "")
                {
                    Function.MessageWarning("请把数据填写完整！");
                    return;
                }
                if (BaseInfoBLL.Update(BaseInfoItem))
                {
                    ini.IniWriteValue("Company","Company",BaseClass.Function.VailCode(Tb_Company.Text.Trim()));
                    Function.Message("修改成功！");
                }
            }
            else
            {
                DC_BaseInfo BaseInfoItem = new DC_BaseInfo();
                BaseInfoItem.Id = 2;
                BaseInfoItem.Company = this.Tb_DCompany.Text.Trim();
                BaseInfoItem.Address = this.Tb_DAddress.Text.Trim();
                BaseInfoItem.Tel = this.Tb_DTel.Text.Trim();
                if (BaseInfoItem.Company == "")
                {
                    Function.MessageWarning("请把数据填写完整！");
                    return;
                }
                if (BaseInfoBLL.Update(BaseInfoItem))
                {
                    Function.Message("修改成功！");
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            BaseInfo_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void BaseInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}