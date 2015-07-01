using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.SysInfo
{
    public partial class Voice : Form
    {
        BLL.PublicFun.IniFile ini = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");
        public Voice()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            DataSet ds;
            //语音提示项目
            ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.Voice);
            this.Lbx_Voice.DataBindings(ds, "语音提示", "语音提示");
            this.Lbx_Voice.Items.RemoveAt(this.Lbx_Voice.Items.Count - 1);
        }

        private void Voice_Load(object sender, EventArgs e)
        {
            this.Btn_Save.Enabled = true;
        }

        private void Lbx_Voice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Btn_Save.Enabled = true;
            this.groupBox2.Text = "选择" + this.Lbx_Voice.SelectedValue.ToString() + "音";
            DataSet ds = new DataSet();
            ds.ReadXml(WSV.Model.FilePath.Voice);
            this.Cklx_Voice.Items.Clear();
            this.Cklx_Voice.DataBindings(ds, this.Lbx_Voice.SelectedValue.ToString(), this.Lbx_Voice.SelectedValue.ToString());
            this.Cklx_Voice.Items.RemoveAt(0);
            string str = ini.IniReadValue("voice", "Sound" + this.Lbx_Voice.SelectedIndex);
            //for (int i = 0; i < this.Cklx_Voice.Items.Count; i++)
            //{
            //    if (this.Cklx_Voice.Items[i].ToString() == str)
            //    {
            if (!string.IsNullOrEmpty(str))
            {
                this.Cklx_Voice.SetItemChecked(Convert.ToInt32(str), true);
            }
            //    }
            //}

        }
        /// <summary>
        /// 单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cklx_Voice_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.Btn_Save.Enabled = true;
            if (Cklx_Voice.CheckedItems.Count > 0)
            { 
                for (int i = 0; i < Cklx_Voice.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this.Cklx_Voice.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                    }
                }
            }
            if (this.Ck_Voice.Checked)
            {
                BaseClass.Function.playSound(System.IO.Directory.GetCurrentDirectory() + "\\voice\\" + this.Cklx_Voice.SelectedText.ToString());
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Cklx_Voice.CheckedItems.Count > 0)
            {
                if (this.Cklx_Voice.SelectedIndex >= 0)
                {
                    ini.IniWriteValue("Voice", "SoundName" + this.Lbx_Voice.SelectedIndex, this.Cklx_Voice.CheckedItems[0].ToString());
                    ini.IniWriteValue("Voice", "Sound" + this.Lbx_Voice.SelectedIndex, this.Cklx_Voice.SelectedIndex);
                }
                this.Btn_Save.Enabled = false;
            }
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            //switch (this.Lbx_Voice.SelectedIndex)
            //{ 
            //    case 0:

            //}
            Btn_Save_Click(sender, e);
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}