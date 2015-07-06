using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarDispatch.BaseClass
{
    public class Error
    {
        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string errorMsg = string.Format("未处理异常: \n{0}\n", e.Exception.Message);
            errorMsg += Environment.NewLine;

            DialogResult result = MessageBox.Show(errorMsg, "Application Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);

            //如果点击“中止”则退出程序
            if (result == DialogResult.Abort)
            {
                Application.Exit();
            }
        }
    }
}
