using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BaseClass;
using WSV.Model.Hardware;
using WSV.BLL.Hardware;

namespace WSV.Hardware
{
    public partial class RoadSluice : Form
    {
        private string My_RunCode = "";//操作日志编号
        public RoadSluice()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            //初始状态
            this.Cmb_RoadSluice1.Items.Add("初始关", 0);
            this.Cmb_RoadSluice1.Items.Add("初始开", 1);

            this.Cmb_RoadSluice2.Items.Add("初始关", 0);
            this.Cmb_RoadSluice2.Items.Add("初始开", 1);

            //工作方式
            this.Cmb_WorkMode1.Items.Add("自动", 0);
            this.Cmb_WorkMode1.Items.Add("手动", 1);
            this.Cmb_WorkMode1.Items.Add("自动+手动", 2);

            this.Cmb_WorkMode2.Items.Add("自动", 0);
            this.Cmb_WorkMode2.Items.Add("手动", 1);
            this.Cmb_WorkMode2.Items.Add("自动+手动", 2);
        }
        //窗体加载
        private void RoadSluice_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            C_RoadSluice RoadSluiceItem = new C_RoadSluice();
            RoadSluiceBLL.DataShow(RoadSluiceItem);
            this.Cb_Enable.Checked = RoadSluiceItem.Enable;
            this.Cmb_RoadSluice1.SelectedByValue(RoadSluiceItem.RoadSluice1);
            this.Cmb_RoadSluice2.SelectedByValue(RoadSluiceItem.RoadSluice2);
            this.Cmb_WorkMode1.SelectedByValue(RoadSluiceItem.WorkMode1);
            this.Cmb_WorkMode2.SelectedByValue(RoadSluiceItem.WorkMode2);
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            C_RoadSluice RoadSluiceItem = new C_RoadSluice();
            RoadSluiceItem.Enable = this.Cb_Enable.Checked;
            RoadSluiceItem.RoadSluice1 = Convert.ToInt32(this.Cmb_RoadSluice1.SelectedValue);
            RoadSluiceItem.RoadSluice2 = Convert.ToInt32(this.Cmb_RoadSluice2.SelectedValue);
            RoadSluiceItem.WorkMode1 = Convert.ToInt32(this.Cmb_WorkMode1.SelectedValue);
            RoadSluiceItem.WorkMode2 = Convert.ToInt32(this.Cmb_WorkMode2.SelectedValue);
            if (RoadSluiceBLL.Update(RoadSluiceItem))
            {
                Function.Message("修改成功！");
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            RoadSluice_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void RoadSluice_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }

    }
}