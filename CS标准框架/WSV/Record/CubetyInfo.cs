using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Record
{
    public partial class CubetyInfo : Form
    {
        Model.Record.D_CubetyModel Item;
        private long Id = 0;
        public CubetyInfo()
        {
            InitializeComponent();
        }

        private void CubetyInfo_Load(object sender, EventArgs e)
        {
            BindDpb();
            BindDGV();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (this.Com_Item.SelectedIndex == 0)
            {
                BaseClass.Function.MessageWarning("请选择货名！");
                this.Com_Item.Focus();
                return;
            }
            BindBasicItem();
            if (BLL.Record.CubetyBll.Insert(Item) == "0101")
            {
                BaseClass.Function.Message("添加成功！");
                ClearBind();
                BindDGV();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (this.Com_Item.SelectedIndex == 0)
            {
                BaseClass.Function.MessageWarning("请选择货名！");
                this.Com_Item.Focus();
                return;
            }
            BindBasicItem();
            if (Item.ID == 0)
            {
                BaseClass.Function.MessageWarning("该条信息不存在，请先添加！");
                return;
            }
            if (BLL.Record.CubetyBll.Update(Item) == "0101")
            {
                BaseClass.Function.Message("修改成功！");
                BindDGV();
            }
        }

        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            ClearBind();
            BindDGV();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (this.Id == 0)
            {
                BaseClass.Function.MessageWarning("请先选中一行！");
                return;
            }
            if (BaseClass.Function.MessageYesNo("确定要删除该数据？"))
            {
                if (BLL.Record.CubetyBll.Delete(this.Id) == "0101")
                {
                    BaseClass.Function.Message("删除成功！");
                    BindDGV();
                }
            }
        }
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDGV()
        {
            this.Dgv_CubetyInfo.DataSource = BLL.Record.CubetyBll.SelectAll().Tables[0];
        }
        /// <summary>
        /// 绑定DGV
        /// </summary>
        private void BindDpb()
        {
            this.Com_Item.DataBindings(BLL.Record.CubetyBll.BindItem(), "Name", "Code");
        }
        //基础信息文本框显示
        private void BindBasicText(int Row)
        {
            this.Id = Convert.ToInt64(this.Dgv_CubetyInfo.Rows[Row].Cells["Col_Id"].Value);
            Com_Item.Text = this.Dgv_CubetyInfo.Rows[Row].Cells["Col_Code"].Value.ToString();
            this.Float_Txt_Cubety.Text = this.Dgv_CubetyInfo.Rows[Row].Cells["Col_Cubety"].Value.ToString();
        }

        //绑定基础信息类
        private void BindBasicItem()
        {
            Item = new WSV.Model.Record.D_CubetyModel();
            Item.ID = this.Id;
            Item.Code = this.Com_Item.SelectedValue.ToString();
            Item.Cubety = Convert.ToDecimal(this.Float_Txt_Cubety.Text.Trim());
        }

        //清除所有绑定
        private void ClearBind()
        {
            this.Com_Item.SelectedIndex = 0;
            this.Float_Txt_Cubety.Text = "0";
            this.Id = 0;
            Item = new WSV.Model.Record.D_CubetyModel();
        }

        private void Dgv_CubetyInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //行选择错误
            if (e.RowIndex < 0 || e.RowIndex >= this.Dgv_CubetyInfo.Rows.Count)
            { return; }
            BindBasicText(e.RowIndex);
        }
    }
}