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
    public partial class FrmCount : Form
    {
        #region 私有变量
        private int _Flag;
        public int Flag { get { return _Flag; } set { _Flag = value; } }
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
        private string FunValue = "";
        private string DBNameValue = "";
        /// <summary>
        /// Cklb上下移动
        /// </summary>
        private int Cklbindex;
        private string CklbValue;
        /// <summary>
        /// 方案名称
        /// </summary>
        private string Planname = "";
        /// <summary>
        /// 方案编号
        /// </summary>
        private string ProCode = "";
        /// <summary>
        /// sql语句
        /// </summary>
        private string sql = "";
        private string sqlCondition = "";
        /// <summary>
        /// 报表开始时间
        /// </summary>
        private string Begintime = "";
        /// <summary>
        /// 报表结束时间
        /// </summary>
        private string Endtime = "";
        /// <summary>
        /// 声明方案表Model
        /// </summary>
        Model.Count.D_StatProjectModel D_StatProjectItem;
        /// <summary>
        /// 声明方案详表Model
        /// </summary>
        Model.Count.D_StatProjectItemModel Item;
        #endregion

        public FrmCount()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
            this.com_Check.Items.Add("全部", 2);
            this.com_Check.Items.Add("未审核", 0);
            this.com_Check.Items.Add("已审核", 1);
            this.com_Check.SelectedIndex = 0;
        }

        #region 私有方法
        private void FrmCount_Load(object sender, EventArgs e)
        {
            //初始化窗体控件信息
            this.Btn_Add.Text = "新建";
            clear();
            BindLv();
            BindChlb();
        }
        /// <summary>
        /// 确定
        /// </summary>
        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            BuildSql();
            if (!string.IsNullOrEmpty(this.sql))
            {
                if (Flag == 0)
                {
                    Count.FrmCount_Info frmcount_info = new FrmCount_Info();
                    frmcount_info.Sql = this.sql;
                    frmcount_info.ReportName = this.Tb_SataType.SelectedTab.Text.Trim();
                    frmcount_info.BeginTime = this.Begintime;
                    frmcount_info.EndTime = this.Endtime;
                    frmcount_info.ReportType = this.CB_Type.SelectedText.ToString();
                    frmcount_info.sqlCountInfo = this.sqlCondition;
                    frmcount_info.Byname = BLL.PublicFun.PublicFun.GetKey("DBName", "V_C_StatSelect", "Name", this.CkLb_Name.CheckedItems[0].ToString(), 0);
                    this.Close();
                    if (StaticMain.MainFrm.HaveOpened(frmcount_info.Name))
                    {
                        frmcount_info.MdiParent = StaticMain.MainFrm.FrmMain;
                        frmcount_info.WindowState = FormWindowState.Maximized;
                        frmcount_info.Activated += new EventHandler(StaticMain.MainFrm.Child_Activated);
                        frmcount_info.Show();
                    }
                }
                else
                {
                    Graph GraphWin = new Graph();
                    GraphWin.sqlCount = this.sqlCondition;
                    GraphWin.Title = this.CB_Type.SelectedText.ToString() + this.Tb_SataType.SelectedTab.Text.Trim() + "(" + this.Begintime + "—" + this.Endtime + ")";
                    GraphWin.ByName = BLL.PublicFun.PublicFun.GetKey("DBName", "V_C_StatSelect", "Name", this.CkLb_Name.CheckedItems[0].ToString(), 0);
                    GraphWin.ShowDialog();
                }
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 单击listView中的项目,选择方案并获得方案的详细信息
        /// </summary>
        private void Lv_Planname_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.Lv_Planname.Items)
            {
                if (item.Selected)
                {
                    if (this.Planname == item.Text)
                    {
                        return;
                    }
                    else
                    {
                        this.Planname = item.Text;
                        item.BackColor = Color.Blue;
                        if (this.Btn_Add.Text == "保存")
                        {
                            this.Btn_Add.Text = "新建";
                        }
                    }
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
            CkLb_Name.Items.Clear();
            ProCode = BLL.PublicFun.PublicFun.GetKey("Code", "D_StatProject", "Name", Planname, 0);
            foreach (DataRow row in WSV.BLL.Count.CountBll.SelectCode(ProCode).Tables[0].Rows)
            {
                string strName = BLL.PublicFun.PublicFun.GetKey("Name", "V_C_StatSelect", "Code", row["StatCode"].ToString(), 0);
                CkLb_Name.Items.Add(strName, true);
            }
            if (this.CkLb_Name.Items.Count == 0)
            {
                clear();
                BindChlb();
            }
            D_StatProjectItem = new WSV.Model.Count.D_StatProjectModel();
            BLL.Count.D_StatProjectBll.SelectByName(Planname, ref D_StatProjectItem);
            if (!string.IsNullOrEmpty(D_StatProjectItem.Type))
            {
                this.CB_Type.SelectedByValue(D_StatProjectItem.Type);
            }
            foreach (TabPage tp in this.Tb_SataType.TabPages)
            {
                if (tp.Text == D_StatProjectItem.SataType)
                {
                    this.Tb_SataType.SelectTab(tp);
                }
            }
            switch (this.Tb_SataType.SelectedTab.Text)
            {
                case "日报表":
                    this.cmb_Day.Text = D_StatProjectItem.Flag;
                    this.TP_Day_BeginTime.Text = D_StatProjectItem.BeginTime;
                    this.TP_Day_EndTime.Text = D_StatProjectItem.EndTime;
                    break;
                case "月报表":
                    this.cmb_Moth.Text = D_StatProjectItem.Flag;
                    this.cmb_Moth_BeginDay.Text = D_StatProjectItem.Day;
                    this.cmb_Moth_EndDay.Text = D_StatProjectItem.Day;
                    this.Tp_Month_Begin.Text = D_StatProjectItem.BeginTime;
                    this.Tp_Month_End.Text = D_StatProjectItem.EndTime;
                    break;
                case "季报表":
                    this.Quarterly_Name.Text = D_StatProjectItem.Flag;
                    break;
                case "年报表":
                    cmb_Year.Text = D_StatProjectItem.Flag;
                    cmb_Year_BeginMoth.Text = D_StatProjectItem.Month;
                    cmb_Year_EndMoth.Text = D_StatProjectItem.Month;
                    cmb_Year_BeginDay.Text = D_StatProjectItem.Day;
                    cmb_Year_EndDay.Text = D_StatProjectItem.Day;
                    this.Tp_Year_Begin.Text = D_StatProjectItem.BeginTime;
                    this.Tp_Year_End.Text = D_StatProjectItem.EndTime;
                    break;
            }
            BindDGV();
        }
        /// <summary>
        /// listview选择项改变发生
        /// </summary>
        private void Lv_Planname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.Btn_Add.Text == "保存")
            //{
            //    this.Btn_Add.Text = "新建";
            //}
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (this.Lv_Planname.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要编辑的方案");
            }
            else
            {
                if (BaseClass.Function.MessageYesNo("确定要删除该方案吗？"))
                {
                    if (BLL.Count.D_StatProjectBll.Delete(this.ProCode) == "0101" && BLL.Count.D_StatProjectItemBll.Delete(this.ProCode) == "0101")
                    {

                        this.Lv_Planname.Items.RemoveByKey(Planname);
                        MessageBox.Show("删除成功！");
                    }
                }
                Btn_Refresh_Click(sender, e);
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Planname = "";
            ProCode = "";
            FrmCount_Load(sender, e);
        }
        /// <summary>
        /// 汇总项目上移
        /// </summary>
        private void Btn_Up_Click(object sender, EventArgs e)
        {
            Cklbindex = this.CkLb_Name.SelectedIndex;
            if (Cklbindex > 0)
            {
                bool flag = this.CkLb_Name.GetItemChecked(Cklbindex - 1);
                CklbValue = this.CkLb_Name.Items[Cklbindex - 1].ToString();
                this.CkLb_Name.Items[Cklbindex - 1] = this.CkLb_Name.Items[Cklbindex];
                this.CkLb_Name.Items[Cklbindex] = CklbValue;
                this.CkLb_Name.SelectedItem = this.CkLb_Name.Items[Cklbindex];
                this.CkLb_Name.SetSelected(Cklbindex - 1, true);
                this.CkLb_Name.SetItemChecked(Cklbindex - 1, true);
                if (!flag)
                {
                    this.CkLb_Name.SetItemChecked(Cklbindex, false);
                }
            }
        }
        /// <summary>
        /// 汇总项目下移
        /// </summary>
        private void Btn_Down_Click(object sender, EventArgs e)
        {
            Cklbindex = this.CkLb_Name.SelectedIndex;
            if (Cklbindex >= 0 && Cklbindex < CkLb_Name.Items.Count - 1)
            {
                bool flag = this.CkLb_Name.GetItemChecked(Cklbindex + 1);
                CklbValue = this.CkLb_Name.Items[Cklbindex + 1].ToString();
                this.CkLb_Name.Items[Cklbindex + 1] = this.CkLb_Name.Items[Cklbindex];
                this.CkLb_Name.Items[Cklbindex] = CklbValue;
                this.CkLb_Name.SelectedItem = this.CkLb_Name.Items[Cklbindex];
                this.CkLb_Name.SetSelected(Cklbindex + 1, true);
                this.CkLb_Name.SetItemChecked(Cklbindex + 1, true);
                if (!flag)
                {
                    this.CkLb_Name.SetItemChecked(Cklbindex, false);
                }
            }
        }
        /// <summary>
        /// 日报表
        /// </summary>
        private void DP_Day_ValueChanged(object sender, EventArgs e)
        {
            lab_Day_EndDate.Text = DP_Day_Day.Value.ToShortDateString();
        }
        /// <summary>
        /// 月报表-按选择的时间来绑定天数
        /// </summary>
        private void DP_Moth_Day_ValueChanged(object sender, EventArgs e)
        {
            int dt = DateTime.Parse(DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString() + "-1").AddMonths(1).AddDays(-1).Day;
            if (cmb_Moth_EndDay.Items.Count != dt)
            {
                cmb_Moth_EndDay.Items.Clear();
                for (int i = 1; i <= dt; i++)
                {
                    cmb_Moth_EndDay.Items.Add(i);
                }
            }
            cmb_Moth_EndDay.SelectedIndex = 0;
            MonthShow();
        }
        /// <summary>
        /// 月报表-按选择的 本月/上月 绑定天数 
        /// </summary>
        private void cmb_Moth_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthShow();
        }
        /// <summary>
        /// 年报表
        /// </summary>
        private void DP_Year_Day_ValueChanged(object sender, EventArgs e)
        {
            YearEndDayShow();
            YearShow();
        }
        /// <summary>
        /// 年报表-按选择的 本年/上年 绑定天数 
        /// </summary>
        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearShow();
        }
        /// <summary>
        /// 年报表-按选择的 开始月 绑定天数 
        /// </summary>
        private void cmb_Year_BeginMoth_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearShow();
        }
        /// <summary>
        /// 年报表-按选择的 结束月 绑定天数 
        /// </summary>
        private void cmb_Year_EndMoth_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearEndDayShow();
        }
        /// <summary>
        /// 季报表
        /// </summary>
        private void dateTime_Quarterly_ValueChanged(object sender, EventArgs e)
        {
            QuarterShow();
        }
        /// <summary>
        /// 选中的项目上移
        /// </summary>
        private void Btn_On_Click(object sender, EventArgs e)
        {
            index = this.Dgv_Set.CurrentCell.RowIndex;
            if (index > 0)
            {
                AsValue = this.Dgv_Set.Rows[index - 1].Cells["Col_As"].Value.ToString();
                NameValue = this.Dgv_Set.Rows[index - 1].Cells["Column_Name"].Value.ToString();
                ShowValue = this.Dgv_Set.Rows[index - 1].Cells["Col_Show"].Value.ToString();
                FunValue = this.Dgv_Set.Rows[index - 1].Cells["Col_fun"].Value.ToString();
                DBNameValue = this.Dgv_Set.Rows[index - 1].Cells["Col_DBName"].Value.ToString();
                this.Dgv_Set.Rows[index - 1].Cells["Col_As"].Value = this.Dgv_Set.Rows[index].Cells["Col_As"].Value;
                this.Dgv_Set.Rows[index - 1].Cells["Column_Name"].Value = this.Dgv_Set.Rows[index].Cells["Column_Name"].Value;
                this.Dgv_Set.Rows[index - 1].Cells["Col_Show"].Value = this.Dgv_Set.Rows[index].Cells["Col_Show"].Value;
                this.Dgv_Set.Rows[index - 1].Cells["Col_fun"].Value = this.Dgv_Set.Rows[index].Cells["Col_fun"].Value;
                this.Dgv_Set.Rows[index - 1].Cells["Col_DBName"].Value = this.Dgv_Set.Rows[index].Cells["Col_DBName"].Value;
                this.Dgv_Set.Rows[index].Cells["Col_As"].Value = AsValue;
                this.Dgv_Set.Rows[index].Cells["Column_Name"].Value = NameValue;
                this.Dgv_Set.Rows[index].Cells["Col_Show"].Value = ShowValue;
                this.Dgv_Set.Rows[index].Cells["Col_fun"].Value = FunValue;
                this.Dgv_Set.Rows[index].Cells["Col_DBName"].Value = DBNameValue;
                this.Dgv_Set.Rows[index].Cells["Column_Name"].Selected = false;
                this.Dgv_Set.Rows[index - 1].Cells["Column_Name"].Selected = true;
                this.Dgv_Set.CurrentCell = Dgv_Set.Rows[index - 1].Cells["Column_Name"];//移动焦点位置
            }
        }
        /// <summary>
        /// 选中的项目下移
        /// </summary>
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            index = this.Dgv_Set.CurrentCell.RowIndex;
            if (index >= 0 && index < Dgv_Set.Rows.Count - 1)
            {
                AsValue = this.Dgv_Set.Rows[index + 1].Cells["Col_As"].Value.ToString();
                NameValue = this.Dgv_Set.Rows[index + 1].Cells["Column_Name"].Value.ToString();
                ShowValue = this.Dgv_Set.Rows[index + 1].Cells["Col_Show"].Value.ToString();
                FunValue = this.Dgv_Set.Rows[index + 1].Cells["Col_fun"].Value.ToString();
                DBNameValue = this.Dgv_Set.Rows[index + 1].Cells["Col_DBName"].Value.ToString();
                this.Dgv_Set.Rows[index + 1].Cells["Col_As"].Value = this.Dgv_Set.Rows[index].Cells["Col_As"].Value;
                this.Dgv_Set.Rows[index + 1].Cells["Column_Name"].Value = this.Dgv_Set.Rows[index].Cells["Column_Name"].Value;
                this.Dgv_Set.Rows[index + 1].Cells["Col_Show"].Value = this.Dgv_Set.Rows[index].Cells["Col_Show"].Value;
                this.Dgv_Set.Rows[index + 1].Cells["Col_fun"].Value = this.Dgv_Set.Rows[index].Cells["Col_fun"].Value;
                this.Dgv_Set.Rows[index + 1].Cells["Col_DBName"].Value = this.Dgv_Set.Rows[index].Cells["Col_DBName"].Value;
                this.Dgv_Set.Rows[index].Cells["Col_As"].Value = AsValue;
                this.Dgv_Set.Rows[index].Cells["Column_Name"].Value = NameValue;
                this.Dgv_Set.Rows[index].Cells["Col_Show"].Value = ShowValue;
                this.Dgv_Set.Rows[index].Cells["Col_fun"].Value = FunValue;
                this.Dgv_Set.Rows[index].Cells["Col_DBName"].Value = DBNameValue;
                this.Dgv_Set.Rows[index + 1].Cells["Column_Name"].Selected = false;
                this.Dgv_Set.Rows[index].Cells["Column_Name"].Selected = true;
                this.Dgv_Set.CurrentCell = Dgv_Set.Rows[index + 1].Cells["Column_Name"];//移动焦点位置
            }
        }
        /// <summary>
        /// 添加/保存方案
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            D_StatProjectItem = new WSV.Model.Count.D_StatProjectModel();
            if (this.Btn_Add.Text == "新建")
            {
                ProjectName_Add ProjectNameAddWin = new ProjectName_Add();
                ProjectNameAddWin.ShowDialog();
                if (!string.IsNullOrEmpty(ProjectNameAddWin.ProName))
                {
                    D_StatProjectItem.Name = ProjectNameAddWin.ProName;
                    if (BLL.Count.D_StatProjectBll.Insert(D_StatProjectItem) == "0101")
                    {
                        this.Btn_Add.Text = "保存";
                        clear();
                        BindChlb();
                        BindLv();
                        foreach (ListViewItem item in this.Lv_Planname.Items)
                        {
                            if (item.Text == D_StatProjectItem.Name)
                            {
                                this.Planname = item.Text;
                                ProCode = BLL.PublicFun.PublicFun.GetKey("Code", "D_StatProject", "Name", Planname, 0);
                                item.BackColor = Color.Blue;
                            }
                        }
                    }
                }
            }
            else
            {
                Item = new WSV.Model.Count.D_StatProjectItemModel();
                Item.Code = this.ProCode;
                if (BLL.PublicFun.PublicFun.CheckKey("D_StatProjectItem", "Code", Item.Code, 0))
                {
                    if (BLL.Count.D_StatProjectItemBll.Delete(Item.Code) == "0")
                    {
                        return;
                    }
                }
                for (int i = 0; i < this.CkLb_Name.CheckedItems.Count; i++)
                {
                    string str = this.CkLb_Name.CheckedItems[i].ToString();
                    Item.StatCode = BLL.PublicFun.PublicFun.GetKey("Code", "V_C_StatSelect", "Name", str, 0);
                    Item.Place = i;
                    if (BLL.Count.D_StatProjectItemBll.Insert(Item) == "0")
                    {
                        return;
                    }
                }
                TabPageItem();
                if (BLL.Count.D_StatProjectBll.Update(D_StatProjectItem) == "0101")
                {
                    this.Btn_Add.Text = "新建";
                    MessageBox.Show("保存成功！");
                    Lv_Planname_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// 编辑方案
        /// </summary>
        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (this.Lv_Planname.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要编辑的方案");
            }
            else
            {
                //clear();
                BindChlb();
                if (this.Btn_Add.Text == "新建")
                {
                    this.Btn_Add.Text = "保存";
                }
                Item = new WSV.Model.Count.D_StatProjectItemModel();
                BindChlb();
                foreach (DataRow row in WSV.BLL.Count.CountBll.SelectEidtCode(ProCode).Tables[0].Rows)
                {
                    string TempName = BLL.PublicFun.PublicFun.GetKey("Name", "V_C_StatSelect", "Code", row["StatCode"].ToString(), 0);
                    CkLb_Name.Items.Remove(TempName);
                    CkLb_Name.Items.Insert(0, TempName);
                    CkLb_Name.SetItemChecked(0, true);
                }
            }
        }
        /// <summary>
        /// 保存设置
        /// </summary>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Model.Count.C_StatModel StatItem = new WSV.Model.Count.C_StatModel();
            for (int i = 0; i < this.Dgv_Set.Rows.Count; i++)
            {
                StatItem.As = this.Dgv_Set.Rows[i].Cells["Col_As"].Value.ToString();
                StatItem.ID = Convert.ToInt64(this.Dgv_Set.Rows[i].Cells["Col_ID"].Value);
                StatItem.Show = Convert.ToBoolean(this.Dgv_Set.Rows[i].Cells["Col_Show"].Value);
                StatItem.Place = i;
                StatItem.Fun = this.Dgv_Set.Rows[i].Cells["Col_fun"].Value.ToString();
                if (BLL.Count.CountBll.Update(StatItem) == "0")
                {
                    MessageBox.Show("保存错误！");
                    return;
                }
            }
            MessageBox.Show("保存成功！");
            BindDGV();
        }
        /// <summary>
        /// 车数的fun不能选择
        /// </summary>
        private void Dgv_Set_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            for (int i = 0; i < this.Dgv_Set.Rows.Count; i++)
            {
                if (e.Control is DataGridViewComboBoxEditingControl && this.Dgv_Set.Rows[i].Cells["Col_DBName"].Value.ToString() == "Count")
                {
                    this.Dgv_Set.Rows[i].Cells["Col_fun"].ReadOnly = true;
                }
            }
        }
        /// <summary>
        /// 双击数值列弹出选择窗口
        /// </summary>
        private void gv_Obj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!string.IsNullOrEmpty(this.gv_Obj[0, e.RowIndex].FormattedValue.ToString()) && this.gv_Obj.Columns["Col_Value"].Index == e.ColumnIndex)
            //{
            //    string DBName = this.gv_Obj[0, e.RowIndex].Value.ToString();
            //    if (BLL.PublicFun.PublicFun.CheckKey("V_DC_Base", "Flag", DBName, 0))
            //    {
            //        WSV.Weight.D_Operate D_Item = new WSV.Weight.D_Operate();
            //        D_Item.flag = DBName;
            //        D_Item.ShowDialog();
            //        this.gv_Obj[2, e.RowIndex].Value = D_Item.Sname;
            //    }
            //}
        }
        #endregion

        #region 自定义私有方法
        /// <summary>
        /// 绑定listview
        /// </summary>
        private void BindLv()
        {
            //添加方案名称
            Lv_Planname.Clear();
            this.Lv_Planname.SmallImageList = this.IgL_Ico;                 // 设置图像集
            this.Lv_Planname.View = View.LargeIcon;
            foreach (DataRow row in WSV.BLL.Count.D_StatProjectBll.SelectAll().Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem(row["Name"].ToString().Trim(), 0);       // 此处i为你图像集的索引号
                Lv_Planname.Items.Add(lvi);
            }
        }
        /// <summary>
        /// 绑定checkedlistbox
        /// </summary>
        private void BindChlb()
        {
            //添加汇总项目 
            CkLb_Name.Items.Clear();
            foreach (DataRow row in WSV.BLL.Count.CountBll.SelectAll().Tables[0].Rows)
            {
                CkLb_Name.Items.Add(row["Name"], false);
            }
        }
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDGV()
        {
            Col_fun.DataSource = BLL.Count.CountBll.Selectfun().Tables[0];
            Col_fun.DisplayMember = "Name";
            Col_fun.ValueMember = "Fun";
            this.Dgv_Set.DataSource = WSV.BLL.Count.CountBll.Select_V_C_Stat().Tables[0];
            for (int i = 0; i < Dgv_Set.Rows.Count; i++)
            {
                Dgv_Set.Rows[i].Cells["Col_Place"].Value = i + 1;
            }
        }
        /// <summary>
        /// 月报表
        /// </summary>
        private void MonthShow()
        {
            int daydt = DateTime.Parse(DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString() + "-1").AddMonths(1).AddDays(-1).Day;
            if (cmb_Moth.Text == "本月")
            {
                if (cmb_Moth_BeginDay.Items.Count != daydt)
                {
                    cmb_Moth_BeginDay.Items.Clear();
                    for (int i = 1; i <= daydt; i++)
                    {
                        cmb_Moth_BeginDay.Items.Add(i);
                    }
                }
            }
            else
            {
                int Lastdaydt = DateTime.Parse(DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString() + "-1").AddDays(-1).Day;
                if (cmb_Moth_BeginDay.Items.Count != Lastdaydt)
                {
                    cmb_Moth_BeginDay.Items.Clear();
                    for (int i = 1; i <= Lastdaydt; i++)
                    {
                        cmb_Moth_BeginDay.Items.Add(i);
                    }
                }
            }
            cmb_Moth_BeginDay.SelectedIndex = 0;
            lab_Month_EndDate.Text = DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString();
        }
        /// <summary>
        /// 季报表
        /// </summary>
        private void QuarterShow()
        {
            switch (dateTime_Quarterly.Value.Month)
            {
                case 1:
                case 2:
                case 3:
                    Quarterly_Name.Text = "第一季度";
                    this.lab_DateBegin.Text = this.dateTime_Quarterly.Value.Year + "-1-1 00:00:00";
                    this.lab_DateEnd.Text = dateTime_Quarterly.Value.Year + "-3-31 23:59:59";
                    break;
                case 4:
                case 5:
                case 6:
                    Quarterly_Name.Text = "第二季度";
                    this.lab_DateBegin.Text = this.dateTime_Quarterly.Value.Year + "-4-1 00:00:00";
                    this.lab_DateEnd.Text = dateTime_Quarterly.Value.Year + "-6-30 23:59:59";
                    break;
                case 7:
                case 8:
                case 9:
                    Quarterly_Name.Text = "第三季度";
                    this.lab_DateBegin.Text = this.dateTime_Quarterly.Value.Year + "-7-1 00:00:00";
                    this.lab_DateEnd.Text = dateTime_Quarterly.Value.Year + "-9-30 23:59:59";
                    break;
                case 10:
                case 11:
                case 12:
                    Quarterly_Name.Text = "第四季度";
                    this.lab_DateBegin.Text = this.dateTime_Quarterly.Value.Year + "-10-1 00:00:00";
                    this.lab_DateEnd.Text = dateTime_Quarterly.Value.Year + "-12-31 23:59:59";
                    break;
            }
        }
        /// <summary>
        /// 年报表
        /// </summary>
        private void YearShow()
        {
            int Getdt = DateTime.Parse(DP_Year_Day.Value.Year.ToString() + "-" + cmb_Year_BeginMoth.Text + "-1").AddMonths(1).AddDays(-1).Day;
            if (cmb_Year.Text == "本年")
            {
                if (cmb_Year_BeginDay.Items.Count != Getdt)
                {
                    cmb_Year_BeginDay.Items.Clear();
                    for (int i = 1; i <= Getdt; i++)
                    {
                        cmb_Year_BeginDay.Items.Add(i);
                    }
                }
            }
            else
            {
                int GetLastdt = DateTime.Parse(DP_Year_Day.Value.AddYears(-1).Year.ToString() + "-" + cmb_Year_BeginMoth.Text.ToString() + "-1").AddMonths(1).AddDays(-1).Day;
                if (cmb_Year_BeginDay.Items.Count != GetLastdt)
                {
                    cmb_Year_BeginDay.Items.Clear();
                    for (int i = 1; i <= GetLastdt; i++)
                    {
                        cmb_Year_BeginDay.Items.Add(i);
                    }
                }
            }
            cmb_Year_BeginDay.SelectedIndex = 0;
            lab_YearEndDate.Text = DP_Year_Day.Value.Year.ToString();
        }
        /// <summary>
        /// 年报表的结束天数绑定
        /// </summary>
        private void YearEndDayShow()
        {
            int GetDaydt = DateTime.Parse(DP_Year_Day.Value.Year.ToString() + "-" + cmb_Year_EndMoth.Text + "-1").AddMonths(1).AddDays(-1).Day;
            if (cmb_Year_EndDay.Items.Count != GetDaydt)
            {
                if (cmb_Year_EndDay.Items.Count != GetDaydt)
                {
                    cmb_Year_EndDay.Items.Clear();
                    for (int i = 1; i <= GetDaydt; i++)
                    {
                        cmb_Year_EndDay.Items.Add(i);
                    }
                }
            }
            cmb_Year_EndDay.SelectedIndex = 0;
        }
        /// <summary>
        /// 报表选项卡信息获取
        /// </summary>
        private void TabPageItem()
        {
            D_StatProjectItem.Code = this.ProCode;
            D_StatProjectItem.Type = this.CB_Type.SelectedValue.ToString();
            D_StatProjectItem.SataType = this.Tb_SataType.SelectedTab.Text;
            switch (this.Tb_SataType.SelectedTab.Text)
            {
                case "日报表":
                    D_StatProjectItem.Flag = this.cmb_Day.Text;
                    D_StatProjectItem.Month = "";
                    D_StatProjectItem.Day = "";
                    D_StatProjectItem.BeginTime = this.TP_Day_BeginTime.Value.ToLongTimeString();
                    D_StatProjectItem.EndTime = this.TP_Day_EndTime.Value.ToLongTimeString();
                    break;
                case "月报表":
                    D_StatProjectItem.Flag = this.cmb_Moth.Text;
                    D_StatProjectItem.Month = "";
                    D_StatProjectItem.Day = this.cmb_Moth_BeginDay.Text;
                    D_StatProjectItem.BeginTime = this.Tp_Month_Begin.Value.ToLongTimeString();
                    D_StatProjectItem.EndTime = this.Tp_Month_End.Value.ToLongTimeString();
                    break;
                case "季报表":
                    D_StatProjectItem.Flag = this.Quarterly_Name.Text;
                    D_StatProjectItem.Month = "";
                    D_StatProjectItem.Day = "";
                    D_StatProjectItem.BeginTime = "";
                    D_StatProjectItem.EndTime = "";
                    break;
                case "年报表":
                    D_StatProjectItem.Flag = cmb_Year.Text;
                    D_StatProjectItem.Month = cmb_Year_BeginMoth.Text;
                    D_StatProjectItem.Day = cmb_Year_BeginDay.Text;
                    D_StatProjectItem.BeginTime = this.Tp_Year_Begin.Value.ToLongTimeString();
                    D_StatProjectItem.EndTime = this.Tp_Year_End.Value.ToLongTimeString();
                    break;
            }
        }
        /// <summary>
        /// 初始化条件信息   
        /// </summary>
        private void clear()
        {
            //添加数据类型   
            this.gv_Obj.Rows.Clear();
            CB_Type.Items.Clear();
            foreach (DataRow row in WSV.BLL.Count.CountBll.Selecttype().Tables[0].Rows)
            {
                CB_Type.Items.Add(row["Name"], row["Code"]);
            }
            CB_Type.SelectedIndex = 0;
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

            //初始化选项卡
            TabPageStat();
            cmb_Day.SelectedIndex = 0;
            DP_Day_Day.Value = DateTime.Now;
            cmb_Moth.SelectedIndex = 0;
            DP_Moth_Day.Value = DateTime.Now;
            TP_Day_BeginTime.Value = DateTime.Parse("00:00:00");
            TP_Day_EndTime.Value = DateTime.Parse("23:59:59");
            MonthShow();
            Tp_Month_Begin.Value = DateTime.Parse("00:00:00");
            Tp_Month_End.Value = DateTime.Parse("23:59:59");
            QuarterShow();
            cmb_Year_BeginMoth.SelectedIndex = 0;
            cmb_Year_EndMoth.SelectedIndex = 0;
            cmb_Year.SelectedIndex = 0;
            DP_Year_Day.Value = DateTime.Now;
            YearShow();
            YearEndDayShow();
            Tp_Year_Begin.Value = DateTime.Parse("00:00:00");
            Tp_Year_End.Value = DateTime.Parse("23:59:59");
        }//初始化窗体信息
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
        /// 选项卡初始化
        /// </summary>
        private void TabPageStat()
        {
            //this.Tb_SataType.SelectTab(0);
            //this.Tc.SelectTab(0);
        }
        /// <summary>
        /// 构建sql语句
        /// </summary>
        private void BuildSql()
        {
            string sql_1 = "";
            string sql_2 = "";
            string sql1 = "";
            string sql2 = "";
            string sql3 = "";
            string sql4 = "";
            string sql5 = "";
            string ByName = "";
            if (this.CkLb_Name.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择汇总项目！");
                return;
            }
            for (int i = 0; i < this.CkLb_Name.CheckedItems.Count; i++)
            {
                ByName = this.CkLb_Name.CheckedItems[0].ToString();
                string strName = this.CkLb_Name.CheckedItems[i].ToString();
                string DBName = BLL.PublicFun.PublicFun.GetKey("DBName", "V_C_StatSelect", "Name", strName, 0);
                sql1 += "" + DBName + ",";
                sql2 += "[" + DBName + "] as " + strName + ",";
                sql4 += "' ',";
            }
            for (int i = 0; i < this.Dgv_Set.Rows.Count; i++)
            {
                if ((bool)this.Dgv_Set.Rows[i].Cells["Col_Show"].Value)
                {
                    string Sfun = "";
                    string DbName = this.Dgv_Set.Rows[i].Cells["Col_DBName"].Value.ToString();
                    string StrName = this.Dgv_Set.Rows[i].Cells["Column_Name"].Value.ToString();
                    if (DbName == "Count")
                    {
                        DbName = "*";
                        Sfun = "Count";
                    }
                    else
                    {
                        Sfun = this.Dgv_Set.Rows[i].Cells["Col_fun"].Value.ToString();
                    }
                    sql2 += "" + Sfun + "(" + DbName + ") as " + StrName + ",";
                    //sql4 += "" + Sfun + "(" + DbName + ") as " + StrName + ",";
                    //sql3 += "" + Sfun + "(" + DbName + ") as " + DbName + ",";
                    if (DbName == "*")
                    {
                        sql3 += "Count(*) as c,";
                        sql4 += "Sum(c),";
                    }
                    else
                    {
                        sql3 += "" + Sfun + "(" + DbName + ") as " + DbName + ",";
                        sql4 += "" + Sfun + "(" + DbName + ") as " + StrName + ",";
                    }
                }
            }
            sql2 = sql2.TrimEnd(',');
            sql3 = sql3.TrimEnd(',');
            sql4 = sql4.TrimEnd(',');
            sql5 = " from V_D_Saver where 1=1 and Used=0 and State=1";
            sqlCondition = " where 1=1 and Used=0 and State=1";
            if (this.com_Check.SelectedIndex == 1 || this.com_Check.SelectedIndex == 2)
            {
                sql5 += " and Verify='" + this.com_Check.SelectedValue + "'";
                sqlCondition += " and Verify='" + this.com_Check.SelectedValue + "'";
            }
            sql5 += " and Type='" + this.CB_Type.SelectedText + "'";
            sqlCondition += " and Type='" + this.CB_Type.SelectedText + "'";
            switch (this.Tb_SataType.SelectedTab.Text)
            {
                case "日报表":
                    if (cmb_Day.Text == "当日")
                    {
                        this.Begintime = this.DP_Day_Day.Value.ToShortDateString() + " " + this.TP_Day_BeginTime.Value.ToLongTimeString();
                    }
                    else
                    {
                        this.Begintime = this.DP_Day_Day.Value.AddDays(-1).ToShortDateString() + " " + this.TP_Day_BeginTime.Value.ToLongTimeString();
                    }
                    this.Endtime = this.DP_Day_Day.Value.ToShortDateString() + " " + this.TP_Day_EndTime.Value.ToLongTimeString();
                    break;
                case "月报表":
                    if (cmb_Moth.Text == "本月")
                    {
                        this.Begintime = DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString() + "-" + this.cmb_Moth_BeginDay.Text + " " + this.Tp_Month_Begin.Value.ToLongTimeString();
                    }
                    else
                    {
                        this.Begintime = DP_Moth_Day.Value.AddMonths(-1).Year.ToString() + "-" + DP_Moth_Day.Value.AddMonths(-1).Month.ToString() + "-" + this.cmb_Moth_BeginDay.Text + " " + this.Tp_Month_Begin.Value.ToLongTimeString();
                    }
                    this.Endtime = DP_Moth_Day.Value.Year.ToString() + "-" + DP_Moth_Day.Value.Month.ToString() + "-" + this.cmb_Moth_EndDay.Text + " " + this.Tp_Month_End.Value.ToLongTimeString();
                    break;
                case "季报表":
                    switch (dateTime_Quarterly.Value.Month)
                    {
                        case 1:
                        case 2:
                        case 3:
                            this.Begintime = this.dateTime_Quarterly.Value.Year + "-1-1 00:00:00";
                            this.Endtime = dateTime_Quarterly.Value.Year + "-3-31 23:59:59";
                            break;
                        case 4:
                        case 5:
                        case 6:
                            this.Begintime = this.dateTime_Quarterly.Value.Year + "-4-1 00:00:00";
                            this.Endtime = dateTime_Quarterly.Value.Year + "-6-30 23:59:59";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            this.Begintime = this.dateTime_Quarterly.Value.Year + "-7-1 00:00:00";
                            this.Endtime = dateTime_Quarterly.Value.Year + "-9-30 23:59:59";
                            break;
                        case 10:
                        case 11:
                        case 12:
                            this.Begintime = this.dateTime_Quarterly.Value.Year + "-10-1 00:00:00";
                            this.Endtime = dateTime_Quarterly.Value.Year + "-12-31 23:59:59";
                            break;
                    }
                    break;
                case "年报表":
                    if (cmb_Year.Text == "本年")
                    {
                        this.Begintime = DP_Year_Day.Value.Year + "-" + cmb_Year_BeginMoth.Text + "-" + cmb_Year_BeginDay.Text + " " + Tp_Year_Begin.Value.ToLongTimeString();
                    }
                    else
                    {
                        this.Begintime = DP_Year_Day.Value.AddYears(-1).Year + "-" + cmb_Year_BeginMoth.Text + "-" + cmb_Year_BeginDay.Text + " " + Tp_Year_Begin.Value.ToLongTimeString();
                    }
                    this.Endtime = DP_Moth_Day.Value.Year + "-" + cmb_Year_EndMoth.Text + "-" + cmb_Year_EndDay.Text + " " + Tp_Year_End.Value.ToLongTimeString();
                    break;
            }
            sql5 += " and N_Time between'" + this.Begintime + "'";
            sqlCondition += " and N_Time between'" + this.Begintime + "'";
            sql5 += " and '" + this.Endtime + "'";
            sqlCondition += " and '" + this.Endtime + "'";
            if (this.gv_Obj.Rows.Count > 1)
            {
                for (int i = 0; i < this.gv_Obj.Rows.Count - 1; i++)
                {
                    string SymLogic = "";
                    if (!string.IsNullOrEmpty(this.gv_Obj.Rows[i].Cells["Col_Name"].FormattedValue.ToString()))
                    {
                        string DbName = this.gv_Obj.Rows[i].Cells["Col_Name"].Value.ToString();

                        string Symbol = this.gv_Obj.Rows[i].Cells["Col_Comparison"].FormattedValue.ToString();
                        string SymValue = this.gv_Obj.Rows[i].Cells["Col_Value"].FormattedValue.ToString();
                        if (i == 0)
                        {
                            SymLogic = "与";
                        }
                        if (i > 0)
                        {
                            SymLogic = this.gv_Obj.Rows[i - 1].Cells["Col_Logic"].FormattedValue.ToString();
                        }
                        if (!string.IsNullOrEmpty(DbName) && !string.IsNullOrEmpty(Symbol) && !string.IsNullOrEmpty(SymValue) && !string.IsNullOrEmpty(SymLogic))
                        {
                            sql5 += "" + SelectSymbol(SymLogic) + DbName + SelectSymbol(Symbol) + "'" + SymValue + "'";
                            sqlCondition += "" + SelectSymbol(SymLogic) + DbName + SelectSymbol(Symbol) + "'" + SymValue + "'";
                        }
                    }
                }
            }
            sql5 += " group by " + sql1.TrimEnd(',');
            sql = "Select " + sql2 + sql5;
            sql_1 = "Select " + sql1 + sql3 + sql5;
            sql_2 = "Select " + sql4 + " from(" + sql_1 + ") as a";
            sql3 = "Select " + sql3 + " from V_D_Saver";
            sql = "Select * from(" + sql + " union " + sql_2 + ") as b order by " + ByName + " desc";
            return;
        }
        #endregion
    }
}
