using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WSV.BLL.PublicFun;
using WSV.BaseClass;

namespace WSV.SysInfo
{
    public partial class BackUp : Form
    {
        string BackupPath=@"D:\Data";
        public BackUp()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.wucheng;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }
        //数据备份
        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            if (!File.Exists(BackupPath)) { Directory.CreateDirectory(BackupPath); }
            string FileName = DateTime.Now.ToString("yyyy-MM-dd");
            if (PublicFun.BackUp(BackupPath+@"\"+FileName+".bak"))
            {
                Function.Message("数据库备份--成功！");
            }
        }
        //数据恢复
        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory =BackupPath;
            openFile.Filter = "BakUp files (*.bak)|*.bak";
            openFile.ShowDialog();
            string FileName = "";
            FileName = openFile.FileName;
            if (FileName == "") { return; }
            if (Function.MessageYesNo("您确定要还原数据，此操作将会覆盖现有数据！"))
            {
                if (PublicFun.ReStore(BackupPath + @"\" + FileName + ".bak"))
                {
                    Function.Message("数据库恢复--成功！");
                }
            }
        }
    }
}