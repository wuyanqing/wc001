using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.SysInfo
{
    public partial class Port : Form
    {
        BLL.PublicFun.IniFile ini = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");
        Model.Weight.WeightModel Values = new WSV.Model.Weight.WeightModel();
        public Port()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            com_Accept.DataBindings(BLL.Port.PortBll.SelectAll(), "Name", "Code");
        }

        private void Port_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ini.IniReadValue("Portload", "Accept1")))
            {
                com_Accept.SelectedByValue(ini.IniReadValue("Portload", "Accept1"));
                //Txt_Accept.Text = BLL.PublicFun.PublicFun.GetKey("Name", "", "Code", Txt_Accept.Tag.ToString().Trim(), 0);
                TxT_Saver.Text = ini.IniReadValue("Portload", "servername1");
                TxT_database.Text = ini.IniReadValue("Portload", "database1");
                //TxT_Password.Text = ini.IniReadValue("Portload", "serverpassword1");
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (com_Accept.SelectedIndex == 0)
            {
                BaseClass.Function.MessageWarning("请选择收货部门！");
                return;
            }
            ini.IniWriteValue("Portload", "Accept1", com_Accept.SelectedValue.ToString());
            ini.IniWriteValue("Portload", "servername1", TxT_Saver.Text.Trim());
            ini.IniWriteValue("Portload", "database1", TxT_database.Text.Trim());
            ini.IniWriteValue("Portload", "serverpassword1", WSV.BaseClass.Function.Md5(TxT_Password.Text.Trim()));
        }

        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            //Txt_Accept.Text = "";
            com_Accept.SelectedIndex = 0;
            Txt_Accept.Tag = "";
            TxT_database.Text = "";
            TxT_Password.Text = "";
            TxT_Saver.Text = "";
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 收货单位事件
        /// <summary>
        /// 收货单位事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            //WSV.Weight.D_Operate D_Accept = new WSV.Weight.D_Operate();
            //D_Accept.flag = "Accept";
            //D_Accept.ShowDialog();
            //this.Txt_Accept.Text = D_Accept.Sname;
            //Txt_Accept.Tag = D_Accept.SCode;
            ////Values.Txt.Accept = Txt_Accept.Tag.ToString();
        }
        private void Txt_Accept_DoubleClick(object sender, EventArgs e)
        {
            //WSV.Weight.D_Operate D_Accept = new WSV.Weight.D_Operate();
            //D_Accept.flag = "Accept";
            //D_Accept.ShowDialog();
            //this.Txt_Accept.Text = D_Accept.Sname;
            //Txt_Accept.Tag = D_Accept.SCode;
            ////Values.Txt.Accept = Txt_Accept.Tag.ToString();
        }
        private void Txt_Accept_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    //selectname = BLL.Weight.WeightBLL.SelectName("Accept", Txt_Accept.Text, Values);
            //    if (BLL.Weight.WeightBLL.SelectName("Accept", Txt_Accept.Text, Values))
            //    {
            //        Txt_Accept.Text = Values.Txt.Name;
            //        Txt_Accept.Tag = Values.Txt.IdCard;
            //    }
            //    else
            //    {
            //        WSV.Weight.D_Operate D_Accept = new WSV.Weight.D_Operate();
            //        D_Accept.flag = "Accept";
            //        D_Accept.Sflag = Txt_Accept.Text;
            //        D_Accept.ShowDialog();
            //        Txt_Accept.Text = D_Accept.Sname;
            //        Txt_Accept.Tag = D_Accept.SCode;
            //    }
            //}
        }
        private void Txt_Accept_Leave(object sender, EventArgs e)
        {
            ////selectname = BLL.Weight.WeightBLL.SelectName("Accept", Txt_Accept.Text, Values);
            //if (BLL.Weight.WeightBLL.SelectName("Accept", Txt_Accept.Text, Values))
            //{
            //    Txt_Accept.Text = Values.Txt.Name;
            //    Txt_Accept.Tag = Values.Txt.IdCard;
            //}
            //else if (Txt_Accept.Text != "")
            //{
            //    WSV.Weight.D_Operate D_Accept = new WSV.Weight.D_Operate();
            //    D_Accept.flag = "Accept";
            //    D_Accept.Sflag = Txt_Accept.Text;
            //    //D_Accept.ShowDialog();
            //    Txt_Accept.Text = D_Accept.Sname;
            //    Txt_Accept.Tag = D_Accept.SCode;
            //}
        }
        #endregion
    }
}