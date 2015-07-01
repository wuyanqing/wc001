using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WSV.Control.TextBox
{
    public class FloatTextBox : TextBox
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //Keys key = (keyData & Keys.KeyCode);
            //if (key == Keys.Enter)
            //{
            //    SendKeys.Send("{TAB}");
            //    return true;
            //}
            return base.ProcessDialogKey(keyData);
        }


        public const int WM_CONTEXTMENU = 0x007b;//右键菜单消息 
        public const int WM_CHAR = 0x0102; //输入字符消息（键盘输入的，输入法输入的好像不是这个消息） 
        public const int WM_CUT = 0x0300; //程序发送此消息给一个编辑框或combobox来删除当前选择的文本 
        public const int WM_COPY = 0x0301; //程序发送此消息给一个编辑框或combobox来复制当前选择的文本到剪贴板 
        public const int WM_PASTE = 0x0302; //程序发送此消息给editcontrol或combobox从剪贴板中得到数据 
        public const int WM_CLEAR = 0x0303; //程序发送此消息给editcontrol或combobox清除当前选择的内容； 
        public const int WM_UNDO = 0x0304; //程序发送此消息给editcontrol或combobox撤消最后一次操作 

        public FloatTextBox()
        {
            // 
            // TODO: 在此处添加构造函数逻辑 
            // 
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CHAR:
                    System.Console.WriteLine(m.WParam);
                    bool isSign = ((int)m.WParam == 45);
                    bool isNum = ((int)m.WParam >= 48) && ((int)m.WParam <= 57);
                    bool isBack = (int)m.WParam == (int)Keys.Back;
                    bool isDelete = (int)m.WParam == (int)Keys.Delete;//实际上这是一个"."键 
                    bool isCtr = ((int)m.WParam == 24) || ((int)m.WParam == 22) || ((int)m.WParam == 26) || ((int)m.WParam == 3);

                    if (isNum || isBack || isCtr)
                    {
                        base.WndProc(ref m);
                    }
                    if (isSign)
                    {
                        if (this.SelectionStart != 0)
                        {
                            break;
                        }
                        base.WndProc(ref m);
                        break;
                    }
                    if (isDelete)
                    {
                        if (this.Text.IndexOf(".") < 0)
                        {
                            base.WndProc(ref m);
                        }
                    }
                    if ((int)m.WParam == 1)
                    {
                        this.SelectAll();
                    }
                    if ((int)m.WParam == 13)
                    {
                        base.WndProc(ref m);
                    }
                    break;
                case WM_PASTE:
                    IDataObject iData = Clipboard.GetDataObject();//取剪贴板对象 

                    if (iData.GetDataPresent(DataFormats.Text)) //判断是否是Text 
                    {
                        string str = (string)iData.GetData(DataFormats.Text);//取数据 
                        if (MatchNumber(str))
                        {
                            base.WndProc(ref m);
                            break;
                        }
                    }
                    m.Result = (IntPtr)0;//不可以粘贴 
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private bool MatchNumber(string ClipboardTe)
        {

            return true;
        }


        //当文本框改变时
        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = "0";
                this.SelectAll();
            }
            base.OnTextChanged(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            //  ^[1-9]\d*$|^0$   整型
            if (!IsRegEx(@"[+|-]?\d*\.?\d*$", this.Text))
            {
                this.Text = "";
            }
            base.OnLostFocus(e);
        }

        /// <summary>
        /// 检查是否符合正则
        /// </summary>
        /// <param name="RegExValue">正则表达式</param>
        /// <param name="ItemValue">需要验证的字符串</param>
        /// <returns>返回真说明通过验证，否则不符合正则</returns>
        public bool IsRegEx(string RegExValue, object ItemValue)
        {
            bool Flag = false;
            Regex regex = new Regex(RegExValue);
            if (regex.IsMatch(ItemValue.ToString())) { Flag = true; }
            return Flag;
        }
    }
}
