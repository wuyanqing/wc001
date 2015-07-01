using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Record
{
    public partial class TypeInfo : Form
    {
        private long Id = 0;
        string My_RunCode = "";             //操作日志编号
        private Model.Record.D_TypeModel Item;
        public TypeInfo()
        {
            InitializeComponent();
        }

        private void TypeInfo_Load(object sender, EventArgs e)
        {
            BindGDV();
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
        }
        /// <summary>
        /// 选取内容
        /// </summary>
        private void Dgv_TypeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //行选择错误
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_TypeInfo.Rows.Count)
            { return; }
            this.Id = Convert.ToInt64(this.Dgv_TypeInfo.Rows[e.RowIndex].Cells["Col_ID"].Value);
            this.Tb_Code.Text = this.Dgv_TypeInfo.Rows[e.RowIndex].Cells["Col_Code"].Value.ToString();
            this.Tb_Name.Text = this.Dgv_TypeInfo.Rows[e.RowIndex].Cells["Col_Name"].Value.ToString();
        }
        /// <summary>
        /// 修改
        /// </summary>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Item = new WSV.Model.Record.D_TypeModel();
            Item.ID = this.Id;
            Item.Code = this.Tb_Code.Text.Trim();
            Item.Name = this.Tb_Name.Text.Trim();
            if (BLL.PublicFun.PublicFun.CheckKey("D_Type", "Name", Item.Name, 0))
            {
                BaseClass.Function.MessageWarning("该名称已存在！");
                return;
            }
            if (BLL.Record.D_Type.Update(Item) == "0101")
            {
                BaseClass.Function.Message("修改成功！");
                BindGDV();
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            this.Tb_Name.Text = "";
            this.Id = 0;
            TypeInfo_Load(sender, e);
        }
        private void TypeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Update_Click(sender, e);
            }
        }

        private void TypeInfo_FormClosed(object sender, FormClosedEventArgs e)
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
        /// 绑定DGV
        /// </summary>
        private void BindGDV()
        {
            this.Dgv_TypeInfo.DataSource = BLL.Record.D_Type.SelectAll().Tables[0];
        }
    }
}