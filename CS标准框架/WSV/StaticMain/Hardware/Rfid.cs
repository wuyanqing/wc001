using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Hardware
{
    public partial class Rfid : Form
    {
        private string My_RunCode = "";//操作日志编号
        public Rfid()
        {
            InitializeComponent();
            this.Icon = WSV.Properties.Resources.logo;
            DataSet ds;
            ds = new DataSet();
            ds.ReadXml(Model.FilePath.RfidType);
            this.Cmb_CardType.DataBindings(ds, "通讯类型", "通讯类型");
            this.Cmb_CardType.Items.RemoveAt(0);
            //仪表串口
            for (int i = 1; i <= 9; i++) { this.Cmb_Serial.Items.Add(i, i); }
            //波特率
            ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.RfidBaudRate);
            this.Cmb_BaudRate.DataBindings(ds, "波特率", "波特率");
            this.Cmb_BaudRate.Items.RemoveAt(0);
            //称重方式
            this.Cmb_WeightType.Items.Add("自动取重+自动保存", 0);
            this.Cmb_WeightType.Items.Add("手动取重+手动保存", 1);
            this.Cmb_WeightType.Items.Add("自动取重+手动保存", 2);
        }

        private void Rfid_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            Model.Hardware.C_Rfid RfidItem = new WSV.Model.Hardware.C_Rfid();
            BLL.Hardware.RfidBll.DataShow(RfidItem);
            this.Cmb_CardType.SelectedByValue(RfidItem.RfidType);
            this.Cb_Enable.Checked = RfidItem.Enable;
            this.Cmb_Serial.SelectedByValue(RfidItem.Serial);
            this.Cmb_BaudRate.SelectedByValue(RfidItem.BaudRate);
            this.Cmb_WeightType.SelectedByValue(RfidItem.WeightType);
        }

        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Rfid_Load(sender, e);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Model.Hardware.C_Rfid RfidItem = new WSV.Model.Hardware.C_Rfid();
            RfidItem.RfidType = this.Cmb_CardType.SelectedValue.ToString();
            RfidItem.Enable = this.Cb_Enable.Checked;
            RfidItem.Serial = Convert.ToInt32(this.Cmb_Serial.SelectedValue);
            RfidItem.BaudRate = Convert.ToInt32(this.Cmb_BaudRate.SelectedValue);
            RfidItem.WeightType = Convert.ToInt32(this.Cmb_WeightType.SelectedValue);
            if (BLL.Hardware.RfidBll.Update(RfidItem))
            {
                BaseClass.Function.Message("修改成功！");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rfid_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}