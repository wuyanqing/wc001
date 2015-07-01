using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV;

namespace WSV.Count
{
    public partial class FrmCount_Info : Form
    {
        public FrmCount_Info()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
        }
        string My_RunCode = "";             //操作日志编号
        private string _Sql, _BeginTime, _EndTime, _ReportName, _ReportType, _Byname, _sqlCountInfo;
        /// <summary>
        /// sql 语句
        /// </summary>
        public string Sql { get { return _Sql; } set { _Sql = value; } }
        /// <summary>
        ///  开始时间
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }
        /// <summary>
        /// 报表名称
        /// </summary>
        public string ReportName { get { return _ReportName; } set { _ReportName = value; } }
        /// <summary>
        /// 报表类型
        /// </summary>
        public string ReportType { get { return _ReportType; } set { _ReportType = value; } }
        /// <summary>
        /// 汇总的第一个字段
        /// </summary>
        public string Byname { get { return _Byname; } set { _Byname = value; } }
        /// <summary>
        /// 汇总的条件
        /// </summary>
        public string sqlCountInfo { get { return _sqlCountInfo; } set { _sqlCountInfo = value; } }

        private void FrmCount_Info_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Dgv_CountInfo.DataSource = BLL.Count.CountBll.SaverInfo(Sql).Tables[0];
            this.Dgv_CountInfo[0, this.Dgv_CountInfo.Rows.Count - 1].Value = "合计";
            this.lab_BeginTime.Text = this.BeginTime;
            this.lab_EndTime.Text = this.EndTime;
            int Flag = this.Dgv_CountInfo.Rows.Count - 1;
            this.lab_ReportCount.Text = Flag.ToString();
            this.lab_RepotType.Text = this.ReportType;
            this.lab_ReportName.Text = this.ReportName;
            this.panel5.Left = (this.Size.Width - panel5.Width) / 2;
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 打印
        /// </summary>
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            //Print.PrintDGV.Print_DataGridView(this.Dgv_CountInfo, this.ReportType + this.ReportName, "");
        }
        /// <summary>
        /// 导出
        /// </summary>
        private void Btn_ToExecel_Click(object sender, EventArgs e)
        {
            BaseClass.ExportExcel export = new WSV.BaseClass.ExportExcel();
            export.Export(this.Dgv_CountInfo);
        }
        /// <summary>
        /// 返回汇总过滤
        /// </summary>
        private void Btn_Count_Click(object sender, EventArgs e)
        {
            FrmCount CountWin = new FrmCount();
            this.Close();
            CountWin.ShowDialog();
        }
        /// <summary>
        /// 窗体变大变小
        /// </summary>
        private void FrmCount_Info_Resize(object sender, EventArgs e)
        {
            this.panel5.Left = (this.Size.Width - panel5.Width) / 2;
        }

        private void FrmCount_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //操作记录
        }
        private void Btn_VCount_Click(object sender, EventArgs e)
        {
            Graph GraphWin = new Graph();
            GraphWin.Title = this.ReportType + this.ReportName + "(" + this.BeginTime + "—" + this.EndTime + ")";
            GraphWin.ByName = this.Byname;
            GraphWin.sqlCount = this.sqlCountInfo;
            GraphWin.ShowDialog();
        }
    }
}