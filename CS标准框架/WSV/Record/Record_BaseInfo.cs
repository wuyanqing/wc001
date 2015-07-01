using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BLL.Record;
using WSV.Model.Record;

namespace WSV.Record
{
    public partial class Record_BaseInfo : Form
    {
        public Record_BaseInfo()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
        }

        #region 私有变量
        D_BaseModel Item;
        private long Id = 0;
        private bool used = true;
        private string _Scode;
        string My_RunCode = "";             //操作日志编号
        #endregion

        #region 私有方法
        private void Record_BaseInfo_Load(object sender, EventArgs e)
        {
            BindLB();
            BindDGV(this.Lb_BaseInfo.SelectedValue, used);
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
        }
        public string Scode
        {
            get { return _Scode; }
            set { _Scode = value; }
        }
        /// <summary>
        /// 添加
        /// </summary>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (this.Tb_Code.ReadOnly)
            {
                ClearBind();
                return;
            }
            if (string.IsNullOrEmpty(this.Tb_Code.Text.Trim()))
            {
                BaseClass.Function.MessageWarning("编号不能为空！");
                this.Tb_Code.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.Tb_Name.Text.Trim()))
            {
                BaseClass.Function.MessageWarning("名称不能为空！");
                this.Tb_Name.Focus();
                return;
            }
            if (D_Base.ValiDateCode(this.Tb_Code.Text.Trim(), this.Lb_BaseInfo.SelectedValue.ToString()))
            {
                BaseClass.Function.MessageWarning("编号已存在！");
                this.Tb_Code.Focus();
                return;
            }
            BindBasicItem();
            if (D_Base.Insert(Item) == "0101")
            {
                BaseClass.Function.Message("添加成功！");
                ClearBind();
                BindDGV(this.Lb_BaseInfo.SelectedValue, used);
            }
        }

        private void Dgv_baseInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //行选择错误
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_baseInfo.Rows.Count)
            { return; }
            BindBasicText(e.RowIndex);
            this.Tb_Code.ReadOnly = true;
        }
        /// <summary>
        /// 修改
        /// </summary>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Tb_Code.Text.Trim()))
            {
                BaseClass.Function.MessageWarning("编号不能为空！");
                this.Tb_Code.Focus();
                return;
            }
            BindBasicItem();
            if (Item.ID == 0)
            {
                BaseClass.Function.MessageWarning("该条信息不存在，请先添加！");
                return;
            }
            if (D_Base.Update(Item) == "0101")
            {
                BaseClass.Function.Message("修改成功！");
                BindDGV(this.Lb_BaseInfo.SelectedValue, used);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            string DbName = BLL.PublicFun.PublicFun.GetKey("Flag", "DC_Base", "Code", this.Lb_BaseInfo.SelectedValue.ToString(), 0);
            if (this.Id == 0)
            {
                BaseClass.Function.MessageWarning("请先选中一行！");
                return;
            }
            if (BLL.PublicFun.PublicFun.CheckKey("D_Saver", DbName, this.Lb_BaseInfo.SelectedValue.ToString() + this.Tb_Code.Text.Trim(), 0))
            {
                BaseClass.Function.MessageWarning("该数据正被使用，不能删除！");
            }
            else
            {
                if (BaseClass.Function.MessageYesNo("确定要删除该数据？"))
                {
                    if (BLL.Record.D_Base.Delete(this.Id) == "0101")
                    {
                        BaseClass.Function.Message("删除成功！");
                        BindDGV(this.Lb_BaseInfo.SelectedValue, used);
                    }
                }
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            ClearBind();
            BindDGV(this.Lb_BaseInfo.SelectedValue, used);
        }
        /// <summary>
        /// 作废
        /// </summary>
        private void Btn_Used_Click(object sender, EventArgs e)
        {
            bool Flag = false;
            if (this.Id == 0)
            {
                BaseClass.Function.MessageWarning("请先选中一行！");
                return;
            }
            D_Base.Update_Used(this.Id, Flag);
            ClearBind();
            BindDGV(this.Lb_BaseInfo.SelectedValue, used);
        }
        /// <summary>
        /// 反作废
        /// </summary>
        private void Btn_NoUsed_Click(object sender, EventArgs e)
        {
            BaseIsUsed BaseIsUsedWin = new BaseIsUsed();
            BaseIsUsedWin.Code = this.Lb_BaseInfo.SelectedValue.ToString();
            BaseIsUsedWin.ShowDialog();
            BindDGV(this.Lb_BaseInfo.SelectedValue, used);
        }
        /// <summary>
        /// 选择ListBox项目
        /// </summary>
        private void Lb_BaseInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBind();
            BindDGV(this.Lb_BaseInfo.SelectedValue, used);
        }
        //自动得到助记码
        private void Tb_Name_KeyUp(object sender, KeyEventArgs e)
        {
            this.Tb_Rem.Text = BaseClass.Function.VailCode(this.Tb_Name.Text.Trim());
        }

        private void Record_BaseInfo_FormClosed(object sender, FormClosedEventArgs e)
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
        /// <summary>
        /// 编号不能输入字符
        /// </summary>
        private void Tb_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '!' && e.KeyChar <= '/' || e.KeyChar >= ':' && e.KeyChar <= '~')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 自定义私有方法
        /// <summary>
        /// 绑定ListBox
        /// </summary>
        private void BindLB()
        {
            this.Lb_BaseInfo.DataBindings(DC_Base.SelectAll(), "Name", "Code");
            if (Scode != null)
            {
                this.Lb_BaseInfo.SelectedByValue(Scode);
            }
        }
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDGV(object Pid, bool used)
        {
            this.Dgv_baseInfo.DataSource = D_Base.SelectByPCode(Pid.ToString(), used).Tables[0];
        }
        //基础信息文本框显示
        private void BindBasicText(int Row)
        {
            this.Id = Convert.ToInt64(this.Dgv_baseInfo.Rows[Row].Cells["Col_Id"].Value);
            this.Tb_Code.Text = this.Dgv_baseInfo.Rows[Row].Cells["Col_CodeID"].Value.ToString();
            this.Tb_Name.Text = this.Dgv_baseInfo.Rows[Row].Cells["Col_Name"].Value.ToString();
            this.Tb_Rem.Text = this.Dgv_baseInfo.Rows[Row].Cells["Col_Rem"].Value.ToString();
        }

        //绑定基础信息类
        private void BindBasicItem()
        {
            Item = new D_BaseModel();
            Item.ID = this.Id;
            Item.CodeID = this.Tb_Code.Text.Trim();
            Item.Name = this.Tb_Name.Text.Trim();
            Item.ParentCode = this.Lb_BaseInfo.SelectedValue.ToString();
            Item.Rem = this.Tb_Rem.Text.Trim();
        }

        //清除所有绑定
        private void ClearBind()
        {
            this.Tb_Code.ReadOnly = false;
            this.Tb_Code.Text = "";
            this.Tb_Name.Text = "";
            this.Tb_Rem.Text = "";
            this.Id = 0;
            Item = new D_BaseModel();
        }
        #endregion
    }
}