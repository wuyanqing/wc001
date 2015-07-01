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
    public partial class IdCard : Form
    {
        private string My_RunCode = "";//操作日志编号
        public IdCard()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            DataSet ds;
            //读卡器类型
            ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.CardType);
            this.Cmb_CardType.DataBindings(ds, "读卡器类型","读卡器类型");
            this.Cmb_CardType.Items.RemoveAt(0);
            //仪表串口
            for (int i = 1; i <= 9; i++) {this.Cmb_Serial.Items.Add(i, i); }
            //波特率
            ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.BaudRate);
            this.Cmb_BaudRate.DataBindings(ds, "波特率", "波特率");
            this.Cmb_BaudRate.Items.RemoveAt(0);
            //称重方式
            this.Cmb_WeightType.Items.Add("自动取重+自动保存", 0);
            this.Cmb_WeightType.Items.Add("手动取重+手动保存", 1);
            this.Cmb_WeightType.Items.Add("自动取重+手动保存", 2);
        }
        //窗体加载
        private void Card_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            C_IdCard CardItem = new C_IdCard();
            IdCardBLL.DataShow(CardItem);
            this.Cmb_CardType.SelectedByValue(CardItem.CardType);
            this.Cb_Enable.Checked = CardItem.Enable;
            this.Cmb_Serial.SelectedByValue(CardItem.Serial);
            this.Cmb_BaudRate.SelectedByValue(CardItem.BaudRate);
            this.Cmb_WeightType.SelectedByValue(CardItem.WeightType);
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            C_IdCard CardItem = new C_IdCard();
            CardItem.CardType = this.Cmb_CardType.SelectedValue.ToString();
            CardItem.Enable = this.Cb_Enable.Checked;
            CardItem.Serial = Convert.ToInt32(this.Cmb_Serial.SelectedValue);
            CardItem.BaudRate = Convert.ToInt32(this.Cmb_BaudRate.SelectedValue);
            CardItem.WeightType = Convert.ToInt32(this.Cmb_WeightType.SelectedValue);
            if (IdCardBLL.Update(CardItem))
            {
                Function.Message("修改成功！");
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Card_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void IdCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}