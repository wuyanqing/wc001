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
    public partial class Meter : Form
    {
        private string My_RunCode = "";//操作日志编号
        public Meter()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            //仪表串口
            for (int i = 1; i <= 9; i++){this.Cmb_Serial.Items.Add(i);}
            DataSet ds;
            //仪表类型
            ds=new DataSet();
            ds.ReadXml(WSV.Model.FilePath.Meter);
            this.Cmb_MeterType.DataBindings(ds, "仪表类型", "仪表类型");
            this.Cmb_MeterType.Items.RemoveAt(0);
            //波特率
            ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.BaudRate);
            this.Cmb_BaudRate.DataBindings(ds, "波特率", "波特率");
            this.Cmb_BaudRate.Items.RemoveAt(0);
            //计量单位 
            this.Cmb_Unit.Items.Add("吨", "t");
            this.Cmb_Unit.Items.Add("千克", "Kg");
        }
        //窗体加载
        private void Meter_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            C_Meter MeterItem=new C_Meter();
            MeterBLL.DataShow(MeterItem);
            this.Cmb_Serial.SelectedByValue(MeterItem.Serial);
            this.Cmb_MeterType.SelectedByValue(MeterItem.MeterType);
            this.Cmb_BaudRate.SelectedByValue(MeterItem.BaudRate);
            this.Cmb_Unit.SelectedByValue(MeterItem.Unit);
            this.Tb_DetectStart.Text = MeterItem.DetectStart.ToString();
            this.Tb_FullBalance.Text = MeterItem.FullBalance.ToString();
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!Function.IsRegEx(@"^\d+(\.\d+)?$", this.Tb_DetectStart.Text.Trim()))
            {
                Function.MessageWarning("检测起点类型不正确！");
                return;
            }
            if (!Function.IsRegEx(@"^[1-9]\d*$|^0$", this.Tb_FullBalance.Text.Trim()))
            {
                Function.MessageWarning("最大秤值类型不正确！");
                return;
            }
            C_Meter MeterItem = new C_Meter();
            MeterItem.Serial = Convert.ToInt32(this.Cmb_Serial.SelectedValue);
            MeterItem.MeterType = this.Cmb_MeterType.SelectedValue.ToString();
            MeterItem.BaudRate =Convert.ToInt32(this.Cmb_BaudRate.SelectedValue);
            MeterItem.Unit = this.Cmb_Unit.SelectedValue.ToString();
            MeterItem.DetectStart =Convert.ToSingle(this.Tb_DetectStart.Text.Trim());
            MeterItem.FullBalance =Convert.ToInt32(this.Tb_FullBalance.Text.Trim());
            if (MeterItem.Unit == "t"){MeterItem.Digit = 3; }
            else{MeterItem.Digit = 0;}
            if (MeterBLL.Update(MeterItem))
            {
                Function.Message("修改成功！");
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Meter_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void Meter_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}