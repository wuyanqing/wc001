using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarDispatch.BaseClass
{
    public partial class MessageBoxFrm : Form
    {
        public MessageBoxFrm()
        {
            InitializeComponent();
        }
        public MessageBoxFrm(string Titel, string Mess)
        {
            InitializeComponent();
            this._FrmTxt = Titel;
            this._MessTxt = Mess;
        }

        private void MessageBoxFrm_Load(object sender, EventArgs e)
        {
            this.Text = _FrmTxt;
            this.lab_Show.Text = _MessTxt;
        }

        //确定
        private void But_Ok_Click(object sender, EventArgs e)
        {
            this._RetTxt = this.txt_Mess.Text;
            this.Close();
        }
        //取消
        private void But_Cancel_Click(object sender, EventArgs e)
        {
            this._RetTxt = "";
            this.Close();
        }

        #region 私有变量
        string _FrmTxt = "", _MessTxt = "";
        string _RetTxt = "";
        #endregion

        #region 公共变量
        /// <summary>
        /// 窗体标题
        /// </summary>
        public string Titel { set { _FrmTxt = value; } }
        /// <summary>
        /// 提示
        /// </summary>
        public string Mess { set { _MessTxt = value; } }
        /// <summary>
        /// 返回值
        /// </summary>
        public string Value { get { return _RetTxt; } }
        #endregion
    }
}