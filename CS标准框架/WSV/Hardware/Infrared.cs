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
    public partial class Infrared : Form
    {
        private string My_RunCode = "";//操作日志编号
        public Infrared()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            //工作模式
            this.Cmb_Infrared1.Items.Add("遮挡报警", 0);
            this.Cmb_Infrared1.Items.Add("不遮挡报警", 1);

            this.Cmb_Infrared2.Items.Add("遮挡报警", 0);
            this.Cmb_Infrared2.Items.Add("不遮挡报警", 1);
        }
        //窗体加载
        private void Infrared_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            C_Infrared InfraredItem = new C_Infrared();
            InfraredBLL.DataShow(InfraredItem);
            this.Cb_Enable.Checked = InfraredItem.Enable;
            this.Cmb_Infrared1.SelectedByValue(InfraredItem.Infrared1);
            this.Cmb_Infrared2.SelectedByValue(InfraredItem.Infrared2);
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            C_Infrared InfraredItem = new C_Infrared();
            InfraredItem.Enable = this.Cb_Enable.Checked;
            InfraredItem.Infrared1 = Convert.ToInt32(this.Cmb_Infrared1.SelectedValue);
            InfraredItem.Infrared2 = Convert.ToInt32(this.Cmb_Infrared2.SelectedValue);
            if (InfraredBLL.Update(InfraredItem))
            {
                Function.Message("修改成功！");
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Infrared_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void Infrared_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}