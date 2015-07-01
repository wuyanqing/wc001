using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WSV.Control.TextBox
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox()
        {
            // 
            // TODO: 在此处添加构造函数逻辑 
            // 
            this.ImeMode = ImeMode.Off;                      //输入法
            this.BorderStyle = BorderStyle.FixedSingle;       //样式

            Font NewFont = new Font(this.Text, 10, FontStyle.Regular);        //字体格式
            this.Font = NewFont;
            if (this.Tag == null)
            {
                this.Tag = "";
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!b_TableFlag)
                return base.ProcessDialogKey(keyData);
            Keys key = (keyData & Keys.KeyCode);
            if (key == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (upper)
            {
                if (e.KeyChar >= 97 & e.KeyChar <= 122)
                {
                    e.KeyChar = (char)(e.KeyChar - 32);
                }
            }
            base.OnKeyPress(e);
        }
        //得到焦点时发生
        protected override void OnGotFocus(EventArgs e)
        {
            this.SelectAll();       //当得到焦点时选中
            base.OnGotFocus(e);
        }


        /// <summary>
        /// 文本框中的字母是否大写
        /// </summary>
        public bool Upper { set { upper = value; } get { return upper; } }
        /// <summary>
        /// 回车是否Tab
        /// </summary>
        public bool TableFlag { set { b_TableFlag = value; } get { return b_TableFlag; } }
        #region

        private bool upper = false;
        private bool b_TableFlag = true;
        #endregion
    }
}
