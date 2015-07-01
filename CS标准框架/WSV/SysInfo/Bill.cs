using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WSV.BaseClass;
using WSV.Model.SysInfo;
using WSV.BLL.SysInfo;

namespace WSV.SysInfo
{
    public partial class Bill : Form
    {
        private string My_RunCode = "";//操作日志编号
        private long Id;
        BLL.PublicFun.IniFile Ini = new WSV.BLL.PublicFun.IniFile(Application.StartupPath + "\\Config.dll");
        public Bill()
        {
            InitializeComponent();
            this.Cmb_BillName.Items.Add("请选择", "");
            DirectoryInfo mydir = new DirectoryInfo(Application.StartupPath + @"\Bill");
            FileInfo[] Files = mydir.GetFiles("*.fr3");
            for (int i = 0; i < Files.Length; i++)
            {
                this.Cmb_BillName.Items.Add(Files[i].Name.Substring(0, Files[i].Name.Length - 4));
            }
        }
        //窗体加载
        private void Bill_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            DataBind();
        }
        //绑定数据
        private void DataBind()
        {
            this.Gv_Bill.AutoGenerateColumns = false;
            this.Gv_Bill.DataSource = BillBLL.SelectAll().Tables[0];
        }
        //显示修改数据
        private void Gv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewCellCollection Dgc = this.Gv_Bill.Rows[i].Cells;
                Id = Convert.ToInt64(Dgc["Col_Id"].Value);
                this.Tb_Code.Text = Dgc["Col_Code"].Value.ToString();
                this.Tb_Name.Text = Dgc["Col_Name"].Value.ToString();
                this.Cmb_BillName.SelectedByValue(Dgc["Col_BillName"].Value);
                this.Tb_PrintTitle.Text = Dgc["Col_PrintTitle"].Value.ToString();
                this.Txt_PrintMend.Text = Ini.IniReadValue("Bill", "PrintMend");
                this.Cb_Preview.Checked = (bool)Dgc["Col_Preview"].Value;
            }
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            D_Bill BillItem = new D_Bill();
            BillItem.Id = Id;
            BillItem.BillName = this.Cmb_BillName.SelectedValue.ToString();
            BillItem.PrintTitle = this.Tb_PrintTitle.Text.Trim();
            Ini.IniWriteValue("Bill", "PrintMend", this.Txt_PrintMend.Text.Trim());
            BillItem.Preview = this.Cb_Preview.Checked;
            if (BillItem.BillName == "" || BillItem.PrintTitle == "")
            {
                Function.MessageWarning("请把数据填写完整！");
                return;
            }
            if (BillBLL.Update(BillItem))
            {
                Function.Message("修改成功！");
                DataBind();
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Bill_Load(sender, e);
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //关闭
        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}