using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.Count
{
    public partial class ProjectName_Add : Form
    {
        public ProjectName_Add()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
        }
        private string _ProName = "";
        public string ProName
        { get { return _ProName; } set { _ProName = value; } }
        private void ProjectName_Add_Load(object sender, EventArgs e)
        {
            this.Tb_Name.Text = "ProjectName1";
            this.Tb_Name.SelectAll();
            this.Tb_Name.Focus();
        }
        /// <summary>
        /// 确定
        /// </summary>
        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            if (BLL.PublicFun.PublicFun.CheckKey("D_StatProject", "Name", this.Tb_Name.Text.Trim(), 0))
            {
                MessageBox.Show("名称["+this.Tb_Name.Text.Trim()+"]已存在！");
                this.Tb_Name.Focus();
                return;
            }
            ProName = this.Tb_Name.Text.Trim();
            this.Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Tb_Name.Text = "";
            this.Close();
        }
        /// <summary>
        /// 回车键作为确定的快捷键
        /// </summary>
        private void ProjectName_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Enter_Click(sender, e);
            }
        }
    }
}