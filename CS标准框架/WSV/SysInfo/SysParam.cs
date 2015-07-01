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
    public partial class SysParam : Form
    {
        private string My_RunCode = "";//操作日志编号
        public SysParam()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;

            Digit(this.Cmb_GrossDigit);
            Round(this.Cmb_GrossRound);
            Digit(this.Cmb_TareDigit);
            Round(this.Cmb_TareRound);
            Digit(this.Cmb_NetDigit);
            Round(this.Cmb_NetRound);
            Digit(this.Cmb_DeductWeightDigit);
            Round(this.Cmb_DeductWeightRound);
            Digit(this.Cmb_DeductRateDigit);
            Round(this.Cmb_DeductRateRound);
            Digit(this.Cmb_EndNetDigit);
            Round(this.Cmb_EndNetRound);
            Digit(this.Cmb_PriceDigit);
            Round(this.Cmb_PriceRound);
            Digit(this.Cmb_MoneyDigit);
            Round(this.Cmb_MoneyRound);
            Digit(this.Cmb_CubeDigit);
            Round(this.Cmb_CubeRound);


            this.Cmb_MoneyMode.Items.Add("净重×单价", 0);
            this.Cmb_MoneyMode.Items.Add("结算净重×单价", 1);
            this.Cmb_MoneyMode.Items.Add("折方×单价", 2);

            this.Cmb_EndNetMode.Items.Add("净重-扣杂-扣重", 0);
            this.Cmb_EndNetMode.Items.Add("净重-扣重", 1);
            this.Cmb_EndNetMode.Items.Add("净重", 2);

            this.Cmb_CodeRule.Items.Add("台号+流水号",0);
            this.Cmb_CodeRule.Items.Add("台号+年+月+流水号", 1);
            this.Cmb_CodeRule.Items.Add("台号+年+月+日+流水号",2);

            this.Cmb_CodeWay.Items.Add("过皮或过毛时生成", 0);
            this.Cmb_CodeWay.Items.Add("得到净重时生成", 1);
        }
        //窗口加载
        private void SysParam_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            C_NumDigit NumDigitItem = new C_NumDigit();
            NumDigitBLL.DataShow(NumDigitItem);
            this.Cmb_GrossDigit.SelectedByValue(NumDigitItem.GrossDigit);
            this.Cmb_GrossRound.SelectedByValue(NumDigitItem.GrossRound);
            this.Cmb_TareDigit.SelectedByValue(NumDigitItem.TareDigit);
            this.Cmb_TareRound.SelectedByValue(NumDigitItem.TareRound);
            this.Cmb_NetDigit.SelectedByValue(NumDigitItem.NetDigit);
            this.Cmb_NetRound.SelectedByValue(NumDigitItem.NetRound);
            this.Cmb_DeductWeightDigit.SelectedByValue(NumDigitItem.DeductWeightDigit);
            this.Cmb_DeductWeightRound.SelectedByValue(NumDigitItem.DeductWeightRound);
            this.Cmb_DeductRateDigit.SelectedByValue(NumDigitItem.DeductRateDigit);
            this.Cmb_DeductRateRound.SelectedByValue(NumDigitItem.DeductRateRound);
            this.Cmb_EndNetDigit.SelectedByValue(NumDigitItem.EndNetDigit);
            this.Cmb_EndNetRound.SelectedByValue(NumDigitItem.EndNetRound);
            this.Cmb_PriceDigit.SelectedByValue(NumDigitItem.PriceDigit);
            this.Cmb_PriceRound.SelectedByValue(NumDigitItem.PriceRound);
            this.Cmb_MoneyDigit.SelectedByValue(NumDigitItem.MoneyDigit);
            this.Cmb_MoneyRound.SelectedByValue(NumDigitItem.MoneyRound);
            this.Cmb_CubeDigit.SelectedByValue(NumDigitItem.CubeDigit);
            this.Cmb_CubeRound.SelectedByValue(NumDigitItem.CubeRound);

            C_DataFormat DataFormatItem = new C_DataFormat();
            DataFormatBLL.DataShow(DataFormatItem);
            this.Cmb_MoneyMode.SelectedByValue(DataFormatItem.MoneyMode);
            this.Cmb_EndNetMode.SelectedByValue(DataFormatItem.EndNetMode);
            this.Cmb_CodeRule.SelectedByValue(DataFormatItem.CodeRule);
            this.Cmb_CodeWay.SelectedByValue(DataFormatItem.CodeWay); 
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Tc_SysPram.SelectedIndex == 0)
            {
                C_DataFormat DataFormatItem = new C_DataFormat();
                DataFormatItem.MoneyMode = Convert.ToInt32(this.Cmb_MoneyMode.SelectedValue);
                DataFormatItem.EndNetMode = Convert.ToInt32(this.Cmb_EndNetMode.SelectedValue);
                DataFormatItem.CodeRule = Convert.ToInt32(this.Cmb_CodeRule.SelectedValue);
                DataFormatItem.CodeWay = Convert.ToInt32(this.Cmb_CodeWay.SelectedValue);
                if (DataFormatBLL.Update(DataFormatItem))
                {
                    Function.Message("修改成功！");
                }
            }
            else
            {
                C_NumDigit NumDigitItem = new C_NumDigit();
                NumDigitItem.GrossDigit = Convert.ToInt32(this.Cmb_GrossDigit.SelectedValue);
                NumDigitItem.GrossRound = Convert.ToInt32(this.Cmb_GrossRound.SelectedValue);
                NumDigitItem.TareDigit = Convert.ToInt32(this.Cmb_TareDigit.SelectedValue);
                NumDigitItem.TareRound = Convert.ToInt32(this.Cmb_TareRound.SelectedValue);
                NumDigitItem.NetDigit = Convert.ToInt32(this.Cmb_NetDigit.SelectedValue);
                NumDigitItem.NetRound = Convert.ToInt32(this.Cmb_NetRound.SelectedValue);
                NumDigitItem.DeductWeightDigit = Convert.ToInt32(this.Cmb_DeductWeightDigit.SelectedValue);
                NumDigitItem.DeductWeightRound = Convert.ToInt32(this.Cmb_DeductWeightRound.SelectedValue);
                NumDigitItem.DeductRateDigit = Convert.ToInt32(this.Cmb_DeductRateDigit.SelectedValue);
                NumDigitItem.DeductRateRound = Convert.ToInt32(this.Cmb_DeductRateRound.SelectedValue);
                NumDigitItem.EndNetDigit = Convert.ToInt32(this.Cmb_EndNetDigit.SelectedValue);
                NumDigitItem.EndNetRound = Convert.ToInt32(this.Cmb_EndNetRound.SelectedValue);
                NumDigitItem.PriceDigit = Convert.ToInt32(this.Cmb_PriceDigit.SelectedValue);
                NumDigitItem.PriceRound = Convert.ToInt32(this.Cmb_PriceRound.SelectedValue);
                NumDigitItem.MoneyDigit = Convert.ToInt32(this.Cmb_MoneyDigit.SelectedValue);
                NumDigitItem.MoneyRound = Convert.ToInt32(this.Cmb_MoneyRound.SelectedValue);
                NumDigitItem.CubeDigit = Convert.ToInt32(this.Cmb_CubeDigit.SelectedValue);
                NumDigitItem.CubeRound = Convert.ToInt32(this.Cmb_CubeRound.SelectedValue);
                if (NumDigitBLL.Update(NumDigitItem))
                {
                    Function.Message("修改成功！");
                }
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            SysParam_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Digit(WSV.Control.MyComboBox.MyComboBox Cmb)
        {
            Cmb.Items.Add("一位小数", 1);
            Cmb.Items.Add("两位小数", 2);
            Cmb.Items.Add("三位小数", 3);
        }
        private void Round(WSV.Control.MyComboBox.MyComboBox Cmb)
        {
            Cmb.Items.Add("四舍五入", 0);
            Cmb.Items.Add("抹除取整", 1);
        }
        //关闭
        private void SysParam_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}