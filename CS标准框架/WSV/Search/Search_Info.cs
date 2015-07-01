using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Search
{
    public partial class Search_Info : Form
    {
        string My_RunCode = "";             //操作日志编号
        private string _Sql, _DateType, _Type, _BeginTime, _EndTime, DateCode;
        /// <summary>
        /// sql 语句
        /// </summary>
        public string Sql { get { return _Sql; } set { _Sql = value; } }
        /// <summary>
        /// 数据性质
        /// </summary>
        public string DateType { get { return _DateType; } set { _DateType = value; } }
        /// <summary>
        /// 过磅类型
        /// </summary>
        public string Type { get { return _Type; } set { _Type = value; } }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get { return _BeginTime; } set { _BeginTime = value; } }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get { return _EndTime; } set { _EndTime = value; } }

        public Search_Info()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.wucheng;
        }
        private void Search_Info_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Dgv_SearchInfo.DataSource = BLL.Count.CountBll.SaverInfo(this.Sql).Tables[0];
            this.lab_DateType.Text = this.Type + this.DateType;
            this.lab_BeginTime.Text = this.BeginTime;
            this.lab_EndTime.Text = this.EndTime;
            this.lab_ReportCount.Text = this.Dgv_SearchInfo.Rows.Count.ToString();
            this.lab_Explain.Text = "红色字体表示已作废！   绿色字体表示已审核！";
            this.lab_Explain.ForeColor = Color.Red;
            if (this.DateType == "临时数据")
            {
                this.Btn_PrintMend.Enabled = false;
            }
            this.lab_DateType.Left = (this.Size.Width - lab_DateType.Width) / 2;
            if (Model.User.LUser.Id == 1)
            {
                this.Btn_Delete.Visible = true;
            }
            else
            {
                this.Btn_Delete.Visible = false;
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search_Conditions searchWin = new Search_Conditions();
            this.Close();
            searchWin.ShowDialog();
        }
        /// <summary>
        /// 单击DGV选中行
        /// </summary>
        private void Dgv_SearchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //行选择错误
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_SearchInfo.Rows.Count)
            { return; }
            if ((bool)this.Dgv_SearchInfo.Rows[e.RowIndex].Cells["Col_Verify"].Value)
            {
                //反审核
                Btn_UnCheck.Enabled = true;
                //审核
                Btn_IsCheck.Enabled = false;
                //作废
                Btn_IsUsed.Enabled = false;
                //反作废
                Btn_UnUsed.Enabled = false;
                //修改
                Btn_Updata.Enabled = false;
                //删除
                Btn_Delete.Enabled = false;
                //补打
                Btn_PrintMend.Enabled = true;
            }
            else if ((bool)this.Dgv_SearchInfo.Rows[e.RowIndex].Cells["Col_Used"].Value)
            {
                Btn_IsUsed.Enabled = false;
                Btn_UnUsed.Enabled = true;
                Btn_UnCheck.Enabled = false;
                Btn_IsCheck.Enabled = false;
                Btn_Updata.Enabled = false;
                Btn_Delete.Enabled = true;
                Btn_PrintMend.Enabled = false;
            }
            else
            {
                Btn_IsUsed.Enabled = true;
                Btn_UnUsed.Enabled = false;
                Btn_UnCheck.Enabled = false;
                Btn_IsCheck.Enabled = true;
                Btn_Updata.Enabled = true;
                Btn_Delete.Enabled = true;
                Btn_PrintMend.Enabled = true;
            }
            this.DateCode = this.Dgv_SearchInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        /// <summary>
        /// 打印
        /// </summary>
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            //Print.PrintDGV.Print_DataGridView(this.Dgv_SearchInfo, this.lab_DateType.Text, "");
        }
        /// <summary>
        /// 导出
        /// </summary>
        private void Btn_Export_Click(object sender, EventArgs e)
        {
            BaseClass.ExportExcel Export = new WSV.BaseClass.ExportExcel();
            Export.Export(this.Dgv_SearchInfo);
        }
        /// <summary>
        /// 修改
        /// </summary>
        private void Btn_Updata_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_Updata.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要修改的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "1";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            BindDGV();
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要删除的信息！");
                return;
            }
            if (BaseClass.Function.MessageYesNo("确定要删除选中信息？"))
            {
                for (int i = 0; i < this.Dgv_SearchInfo.SelectedRows.Count; i++)
                {
                    BLL.Search.SearchBll.Delete(Convert.ToInt32(this.Dgv_SearchInfo.Rows[i].Cells[0].Value));
                }
                BaseClass.Function.Message("删除成功！");
            }
            BindDGV();
        }
        /// <summary>
        /// 审核
        /// </summary>
        private void Btn_IsCheck_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_IsCheck.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要审核的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "2";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// 反审核
        /// </summary>
        private void Btn_UnCheck_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_UnCheck.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要反审核的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "3";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// 作废
        /// </summary>
        private void Btn_IsUsed_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_IsUsed.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要作废的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "4";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// 反作废
        /// </summary>
        private void Btn_UnUsed_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_UnUsed.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要反作废的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "5";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
            BindDGV();
        }
        /// <summary>
        /// 补打
        /// </summary>
        private void Btn_PrintMend_Click(object sender, EventArgs e)
        {
            if (!BLL.User.RoleBLL.CheckRolePower(this.Btn_PrintMend.Tag.ToString().Trim()))
            {
                BaseClass.Function.MessageWarning("无此权限！");
                return;
            }
            if (this.Dgv_SearchInfo.SelectedRows.Count == 0)
            {
                BaseClass.Function.MessageWarning("请先选择要补打的信息！");
                return;
            }
            //WSV.MyLog.OperData operdata = new WSV.MyLog.OperData();
            //operdata.judgedata = "6";
            //operdata.receivedata = this.DateCode;
            //operdata.ShowDialog();
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Search_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);           //操作记录
        }
        /// <summary>
        /// 标题居中
        /// </summary>
        private void Search_Info_Resize(object sender, EventArgs e)
        {
            this.lab_DateType.Left = (this.Size.Width - lab_DateType.Width) / 2;
        }
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDGV()
        {
            this.Dgv_SearchInfo.DataSource = BLL.Count.CountBll.SaverInfo(this.Sql).Tables[0];
            if (Dgv_SearchInfo.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_SearchInfo.Rows.Count; i++)
                {
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Verify"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Used"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// 鼠标右键菜单
        /// </summary>
        private void Dgv_SearchInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }
        /// <summary>
        /// 第一次显示窗体，dgv数据颜色
        /// </summary>
        private void Search_Info_Shown(object sender, EventArgs e)
        {
            if (Dgv_SearchInfo.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_SearchInfo.Rows.Count; i++)
                {
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Verify"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    if ((bool)Dgv_SearchInfo.Rows[i].Cells["Col_Used"].Value)
                    {
                        Dgv_SearchInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
        /// <summary>
        /// 打开图片窗体
        /// </summary>
        private void Dgv_SearchInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmImage frmIge = new FrmImage();
            if (this.DateType == "临时数据")
            {
                frmIge.Flag = false;
            }
            frmIge.Code = this.DateCode;
            frmIge.ShowDialog();
        }

        private void Btn_Pic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.DateCode))
            {
                BaseClass.Function.MessageWarning("请先选中要查看的信息！");
                return;
            }
            FrmImage frmIge = new FrmImage();
            if (this.DateType == "临时数据")
            {
                frmIge.Flag = false;
            }
            frmIge.Code = this.DateCode;
            frmIge.ShowDialog();
        }
    }
}