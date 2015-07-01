using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BLL.Record;

namespace WSV.Record
{
    public partial class BaseIsUsed : Form
    {
        public BaseIsUsed()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
        }
        #region 私有变量
        private bool used = false;
        private long ID;
        private string _Code;
        string My_RunCode = "";             //操作日志编号
        #endregion

        #region 私有属性
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        #endregion

        #region 私有方法
        private void BaseIsUsed_Load(object sender, EventArgs e)
        {
            BindDGV(Code, used);
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
        }
        private void Dgv_baseUsedInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //行选择错误
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_baseUsedInfo.Rows.Count)
            { return; }
            bool value = (bool)Dgv_baseUsedInfo.Rows[e.RowIndex].Cells["Col_Check"].FormattedValue;
            Dgv_baseUsedInfo.Rows[e.RowIndex].Cells["Col_Check"].Value = !value;
        }
        /// <summary>
        /// 全选
        /// </summary>
        private void Btn_SelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Dgv_baseUsedInfo.Rows.Count; i++)
            {
                Dgv_baseUsedInfo.Rows[i].Cells["Col_Check"].Value = true;
            }
        }
        /// <summary>
        /// 反作废
        /// </summary>
        private void Btn_NoUsed_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            for (int i = 0; i < this.Dgv_baseUsedInfo.Rows.Count; i++)
            {
                if ((bool)this.Dgv_baseUsedInfo.Rows[i].Cells["Col_Check"].FormattedValue)
                {
                    if ((bool)this.Dgv_baseUsedInfo.Rows[i].Cells["Col_Check"].Value)
                    {
                        this.ID = Convert.ToInt64(this.Dgv_baseUsedInfo.Rows[i].Cells["Col_Id"].Value);
                        D_Base.Update_Used(this.ID, Flag);
                    }
                }
            }
            BindDGV(Code, used);
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            BindDGV(Code, used);
        }
        /// <summary>
        /// 关闭窗体后
        /// </summary>
        private void BaseIsUsed_FormClosed(object sender, FormClosedEventArgs e)
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
        /// 绑定DGV
        /// </summary>
        private void BindDGV(string Pid, bool used)
        {
            this.Dgv_baseUsedInfo.DataSource = WSV.BLL.Record.D_Base.SelectByPCode(Pid, used).Tables[0];
        }
        #endregion    
    }
}