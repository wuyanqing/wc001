using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.MyLog
{
    public partial class MyOper : Form
    {
        private string Begin = "";
        private string Over = "";
        private string WorkWise = "";
        private string UsedName = "";
        string My_RunCode = "";             //操作日志编号
        public MyOper()
        {
            InitializeComponent();
            BindCmb();
        }
        #region 私有方法
        private void MyOper_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            Clear();
            GetCondition();
            this.gv.DataSource = WSV.BLL.MyLog.Modify.SelectModify(Begin, Over).Tables[0];
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            GetCondition();
            if (WorkWise == "全部" && UsedName == "全部")
            {
                this.gv.DataSource = WSV.BLL.MyLog.Modify.SelectModify(Begin, Over).Tables[0];
            }
            else if (WorkWise == "全部" && UsedName != "全部")
            {
                this.gv.DataSource = WSV.BLL.MyLog.Modify.SelectByUserName(Begin, Over, UsedName).Tables[0];
            }
            else if (WorkWise != "全部" && UsedName == "全部")
            {
                this.gv.DataSource = WSV.BLL.MyLog.Modify.SelectByWorkWise(Begin, Over, WorkWise).Tables[0];
            }
            else
            {
                this.gv.DataSource = WSV.BLL.MyLog.Modify.SelectOption(Begin, Over, WorkWise, UsedName).Tables[0];
            }
          
        }
        /// <summary>
        /// 导出
        /// </summary>
        private void Btn_Export_Click(object sender, EventArgs e)
        {
            BaseClass.ExportExcel export = new WSV.BaseClass.ExportExcel();
            export.Export(this.gv);
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            MyOper_Load(sender, e);
        }
        private void MyOper_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //操作记录
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 自定义私有方法
        /// <summary>
        /// 获得条件
        /// </summary>
        private void GetCondition()
        {
            WorkWise = this.Cmb_WorkWise.Text;
            UsedName = this.Cmb_UsedName.Text;
            Begin = this.Dt_DateBegin.Text.Trim() + " " + this.Dt_TimeBegin.Text.Trim();
            Over = this.Dt_DateEnd.Text.Trim() + " " + this.Dt_TimeEnd.Text.Trim();
        }
        /// <summary>
        /// 初始化窗体
        /// </summary>
        private void Clear()
        {
            this.Dt_DateBegin.Value = DateTime.Today;
            this.Dt_TimeBegin.Value = DateTime.Parse("00:00:00");
            this.Dt_DateEnd.Value = DateTime.Today;
            this.Dt_TimeEnd.Value = DateTime.Parse("23:59:59");
            this.Cmb_WorkWise.SelectedIndex = 0;
            this.Cmb_UsedName.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindCmb()
        {
            this.Cmb_WorkWise.Items.Clear();
            this.Cmb_WorkWise.Items.Add("全部");
            foreach (DataRow row in WSV.BLL.MyLog.Modify.SelectMain().Tables[0].Rows)
            {
                this.Cmb_WorkWise.Items.Add(row["Name"]);
            }
            this.Cmb_WorkWise.SelectedIndex = 0;
            this.Cmb_UsedName.Items.Clear();
            this.Cmb_UsedName.Items.Add("全部");
            foreach (DataRow row in WSV.BLL.MyLog.D_User.SelectAll().Tables[0].Rows)
            {
                this.Cmb_UsedName.Items.Add(row["Name"]);
            }
            this.Cmb_UsedName.SelectedIndex = 0;
        }
        #endregion
    }
}