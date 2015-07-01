using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Search
{
    public partial class Search_Conditions : Form
    {
        /// <summary>
        /// dgv_set行索引
        /// </summary>
        private int index;
        /// <summary>
        /// dgv_set上下移动行所需变量
        /// </summary>
        private string NameValue = "";
        private string AsValue = "";
        private string ShowValue = "";
        private string DBNameValue = "";
        /// <summary>
        /// sql语句
        /// </summary>
        private string sql = "";
        public Search_Conditions()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            this.Cmb_Used.Items.Add("全部", 0);
            this.Cmb_Used.Items.Add("有效", 1);
            this.Cmb_Used.Items.Add("作废", 2);
            this.Cmb_Check.Items.Add("全部", 0);
            this.Cmb_Check.Items.Add("未审核", 1);
            this.Cmb_Check.Items.Add("已审核", 2);
        }

        #region 私有方法
        private void Search_Conditions_Load(object sender, EventArgs e)
        {
            clear();
            BindDGV();
        }
        /// <summary>
        /// 选中的项目上移
        /// </summary>
        private void Btn_Up_Click(object sender, EventArgs e)
        {
            index = this.Dgv_SetInfo.CurrentCell.RowIndex;
            if (index > 0)
            {
                AsValue = this.Dgv_SetInfo.Rows[index - 1].Cells["Col_As"].Value.ToString();
                NameValue = this.Dgv_SetInfo.Rows[index - 1].Cells["Column_Name"].Value.ToString();
                ShowValue = this.Dgv_SetInfo.Rows[index - 1].Cells["Col_Show"].Value.ToString();
                DBNameValue = this.Dgv_SetInfo.Rows[index - 1].Cells["Col_DBName"].Value.ToString();
                this.Dgv_SetInfo.Rows[index - 1].Cells["Col_As"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_As"].Value;
                this.Dgv_SetInfo.Rows[index - 1].Cells["Column_Name"].Value = this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Value;
                this.Dgv_SetInfo.Rows[index - 1].Cells["Col_Show"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_Show"].Value;
                this.Dgv_SetInfo.Rows[index - 1].Cells["Col_DBName"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_DBName"].Value;
                this.Dgv_SetInfo.Rows[index].Cells["Col_As"].Value = AsValue;
                this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Value = NameValue;
                this.Dgv_SetInfo.Rows[index].Cells["Col_Show"].Value = ShowValue;
                this.Dgv_SetInfo.Rows[index].Cells["Col_DBName"].Value = DBNameValue;
                this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Selected = false;
                this.Dgv_SetInfo.Rows[index - 1].Cells["Column_Name"].Selected = true;
                this.Dgv_SetInfo.CurrentCell = Dgv_SetInfo.Rows[index - 1].Cells["Column_Name"];//移动焦点位置
            }
        }
        /// <summary>
        /// 选中的项目下移
        /// </summary>
        private void Btn_Down_Click(object sender, EventArgs e)
        {
            int Countindex;
            Countindex = Dgv_SetInfo.Rows.Count;
            index = this.Dgv_SetInfo.CurrentCell.RowIndex;
            if (index >= 0 && index < Countindex - 1)
            {
                AsValue = this.Dgv_SetInfo.Rows[index + 1].Cells["Col_As"].Value.ToString();
                NameValue = this.Dgv_SetInfo.Rows[index + 1].Cells["Column_Name"].Value.ToString();
                ShowValue = this.Dgv_SetInfo.Rows[index + 1].Cells["Col_Show"].Value.ToString();
                DBNameValue = this.Dgv_SetInfo.Rows[index + 1].Cells["Col_DBName"].Value.ToString();
                this.Dgv_SetInfo.Rows[index + 1].Cells["Col_As"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_As"].Value;
                this.Dgv_SetInfo.Rows[index + 1].Cells["Column_Name"].Value = this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Value;
                this.Dgv_SetInfo.Rows[index + 1].Cells["Col_Show"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_Show"].Value;
                this.Dgv_SetInfo.Rows[index + 1].Cells["Col_DBName"].Value = this.Dgv_SetInfo.Rows[index].Cells["Col_DBName"].Value;
                this.Dgv_SetInfo.Rows[index].Cells["Col_As"].Value = AsValue;
                this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Value = NameValue;
                this.Dgv_SetInfo.Rows[index].Cells["Col_Show"].Value = ShowValue;
                this.Dgv_SetInfo.Rows[index].Cells["Col_DBName"].Value = DBNameValue;
                this.Dgv_SetInfo.Rows[index + 1].Cells["Column_Name"].Selected = false;
                this.Dgv_SetInfo.Rows[index].Cells["Column_Name"].Selected = true;
                this.Dgv_SetInfo.CurrentCell = Dgv_SetInfo.Rows[index + 1].Cells["Column_Name"];//移动焦点位置
            }
        }
        /// <summary>
        /// 确定
        /// </summary>
        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            BuildSql();
            Search.Search_Info searchinfo = new Search_Info();
            searchinfo.Sql = this.sql;
            if (this.Rbt_Date.Checked)
            {
                searchinfo.DateType = this.Rbt_Date.Text;
            }
            else
            {
                searchinfo.DateType = this.Rbt_TempDate.Text;
            }
            searchinfo.Type = this.Cmb_Type.SelectedText.ToString();
            searchinfo.BeginTime = this.Dt_DateBegin.Value.ToShortDateString() + " " + this.Dt_TimeBegin.Value.ToLongTimeString();
            searchinfo.EndTime = this.Dt_DateEnd.Value.ToShortDateString() + " " + this.Dt_TimeEnd.Value.ToLongTimeString();
            this.Close();
            this.Hide();
            //searchinfo.Show();
            if (StaticMain.MainFrm.HaveOpened(searchinfo.Name))
            {
                searchinfo.MdiParent = StaticMain.MainFrm.FrmMain;
                searchinfo.WindowState = FormWindowState.Maximized;
                searchinfo.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                searchinfo.Show();
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 保存设置
        /// </summary>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Model.Search.C_SelectModel SelectItem = new WSV.Model.Search.C_SelectModel();
            for (int i = 0; i < this.Dgv_SetInfo.Rows.Count; i++)
            {
                SelectItem.ID = Convert.ToInt64(this.Dgv_SetInfo.Rows[i].Cells["Col_ID"].Value);
                SelectItem.As = this.Dgv_SetInfo.Rows[i].Cells["Col_As"].Value.ToString();
                SelectItem.Show = Convert.ToBoolean(this.Dgv_SetInfo.Rows[i].Cells["Col_Show"].Value);
                SelectItem.Place = i;
                if (BLL.Search.SearchBll.Update(SelectItem) == "0")
                {
                    MessageBox.Show("保存错误！");
                    return;
                }
            }
            MessageBox.Show("保存成功！");
            BindDGV();
        }
        /// <summary>
        /// 双击数值列弹出选择窗口
        /// </summary>
        private void Dgv_Condition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!string.IsNullOrEmpty(this.Dgv_Condition[0, e.RowIndex].FormattedValue.ToString()) && this.Dgv_Condition.Columns["Col_Value"].Index == e.ColumnIndex)
            //{
            //    string DBName = this.Dgv_Condition[0, e.RowIndex].Value.ToString();
            //    if (BLL.PublicFun.PublicFun.CheckKey("V_DC_Base", "Flag", DBName, 0))
            //    {
            //        WSV.Weight.D_Operate D_Item = new WSV.Weight.D_Operate();
            //        D_Item.flag = DBName;
            //        D_Item.ShowDialog();
            //        this.Dgv_Condition[2, e.RowIndex].Value = D_Item.Sname;
            //    }
            //}
        }
        #endregion

        #region 自定义私有方法
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDGV()
        {
            this.Dgv_SetInfo.DataSource = WSV.BLL.Search.SearchBll.Select_Select().Tables[0];
            for (int i = 0; i < Dgv_SetInfo.Rows.Count; i++)
            {
                Dgv_SetInfo.Rows[i].Cells["Col_Place"].Value = i + 1;
            }
        }
        /// <summary>
        ///  初始化窗体信息
        /// </summary>
        private void clear()
        {
            //添加数据类型   
            this.Dgv_Condition.Rows.Clear();
            Cmb_Type.Items.Clear();
            foreach (DataRow row in WSV.BLL.Count.CountBll.Selecttype().Tables[0].Rows)
            {
                Cmb_Type.Items.Add(row["Name"], row["Code"]);
            }
            Cmb_Type.SelectedIndex = 0;
            this.Dt_DateBegin.Value = DateTime.Today;
            this.Dt_TimeBegin.Value = DateTime.Parse("00:00:00");
            this.Dt_DateEnd.Value = DateTime.Today;
            this.Dt_TimeEnd.Value = DateTime.Parse("23:59:59");
            //添加名称
            Col_Name.DataSource = BLL.Count.CountBll.SelectAll().Tables[0];
            Col_Name.DisplayMember = "Name";
            Col_Name.ValueMember = "DBName";
            //添加比较关系
            Col_Comparison.Items.Clear();
            Col_Comparison.Items.Add("等于");
            Col_Comparison.Items.Add("不等于");
            Col_Comparison.Items.Add("大于");
            Col_Comparison.Items.Add("小于");
            Col_Comparison.Items.Add("大于等于");
            Col_Comparison.Items.Add("小于等于");
            //添加逻辑关系符号
            Col_Logic.Items.Clear();
            Col_Logic.Items.Add("与");
            Col_Logic.Items.Add("或");

            //显示汇总字段
            BindDGV();
        }
        /// <summary>
        /// 获取条件符号
        /// </summary>
        /// <param name="Symbol"> 单元格值</param>
        /// <returns>条件符</returns>
        private static string SelectSymbol(string Symbol)
        {
            //获得符号
            string SymbolName = "";
            switch (Symbol)
            {
                case "等于":
                    SymbolName = "=";
                    break;
                case "不等于":
                    SymbolName = "<>";
                    break;
                case "大于":
                    SymbolName = ">";
                    break;
                case "小于":
                    SymbolName = "<";
                    break;
                case "大于等于":
                    SymbolName = ">=";
                    break;
                case "小于等于":
                    SymbolName = "<=";
                    break;
                case "与":
                    SymbolName = " and ";
                    break;
                case "或":
                    SymbolName = " or ";
                    break;
            }
            return SymbolName;
        }
        /// <summary>
        /// 构建sql语句
        /// </summary>
        private void BuildSql()
        {
            sql = "select ID,";
            for (int i = 0; i < this.Dgv_SetInfo.Rows.Count; i++)
            {
                if ((bool)this.Dgv_SetInfo.Rows[i].Cells["Col_Show"].Value)
                {
                    string DbName = this.Dgv_SetInfo.Rows[i].Cells["Col_DBName"].Value.ToString();
                    string StrName = this.Dgv_SetInfo.Rows[i].Cells["Column_Name"].Value.ToString();
                    sql += "" + DbName + " as " + StrName + ",";
                }
            }
            //sql = sql.TrimEnd(',');
            sql += " State,Used,Verify from V_D_Saver where 1=1";
            if (this.Rbt_Date.Checked)
            {
                sql += " and State=1";
            }
            if (this.Rbt_TempDate.Checked)
            {
                sql += " and State=0";
            }
            sql += " and Type='" + this.Cmb_Type.SelectedText + "'";
            if (this.Cmb_Used.SelectedValue.ToString() != "0")
            {
                sql += " and Used+1='" + this.Cmb_Used.SelectedValue + "'";
            }
            if (this.Cmb_Check.SelectedValue.ToString() != "0")
            {
                sql += " and Verify+1='" + this.Cmb_Check.SelectedValue + "'";
            }
            sql += " and N_Time between '" + this.Dt_DateBegin.Value.ToShortDateString() + " " + this.Dt_TimeBegin.Value.ToLongTimeString() + "'";
            sql += " and '" + this.Dt_DateEnd.Value.ToShortDateString() + " " + this.Dt_TimeEnd.Value.ToLongTimeString() + "'";
            if (this.Dgv_Condition.Rows.Count > 1)
            {
                for (int i = 0; i < this.Dgv_Condition.Rows.Count - 1; i++)
                {
                    string SymLogic = "";
                    if (!string.IsNullOrEmpty(this.Dgv_Condition.Rows[i].Cells["Col_Name"].FormattedValue.ToString()))
                    {
                        string DbName = this.Dgv_Condition.Rows[i].Cells["Col_Name"].Value.ToString();

                        string Symbol = this.Dgv_Condition.Rows[i].Cells["Col_Comparison"].FormattedValue.ToString();
                        string SymValue = this.Dgv_Condition.Rows[i].Cells["Col_Value"].FormattedValue.ToString();
                        if (i == 0)
                        {
                            SymLogic = "与";
                        }
                        if (i > 0)
                        {
                            SymLogic = this.Dgv_Condition.Rows[i - 1].Cells["Col_Logic"].FormattedValue.ToString();
                        }
                        if (!string.IsNullOrEmpty(DbName) && !string.IsNullOrEmpty(Symbol) && !string.IsNullOrEmpty(SymValue) && !string.IsNullOrEmpty(SymLogic))
                        {
                            sql += "" + SelectSymbol(SymLogic) + DbName + SelectSymbol(Symbol) + "'" + SymValue + "'";
                        }
                    }
                }
            }
            return;
        }
        #endregion
    }
}