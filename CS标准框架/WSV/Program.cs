using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WSV
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.ThreadException +=new System.Threading.ThreadExceptionEventHandler(BaseClass.Error.Application_ThreadException);
            string procName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            if ((System.Diagnostics.Process.GetProcessesByName(procName)).GetUpperBound(0) > 0)
            {
                MessageBox.Show("该程序已启动！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                User.Login login = new User.Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    login.Close();
                    Application.Run(new Main());
                }
            }

        } 
    }
}