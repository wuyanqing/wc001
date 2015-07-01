using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WSV.BLL.SysInfo;

namespace WSV.SysInfo
{
    public partial class BillInfo : Form
    {
        private string My_RunCode = "";//操作日志编号
        public BillInfo()
        {
            InitializeComponent();
        }

        private void BillInfo_Load(object sender, EventArgs e)
        {
            BindDB();
            SelectAllBill();
            if (list_AllBill.Items.Count > 0)
                this.list_AllBill.SelectedIndex = 0;
        }
        private void BillInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            //Print.BillPrint.Report.MyReport.Dispose();
        }
        ////添加
        //private void Btn_Add_Click(object sender, EventArgs e)
        //{
        //    BaseClass.MessageBoxFrm Mess = new WSV.BaseClass.MessageBoxFrm("输入", "请输入文件名：");
        //    Mess.ShowDialog();
        //    if (Mess.Value.Trim() != "")
        //    {
        //        DirectoryInfo mydir = new DirectoryInfo(Application.StartupPath + @"\Bill");
        //        FileInfo[] Files = mydir.GetFiles("*.fr3");
        //        //this.list_AllBill.Items.Clear();
        //        for (int i = 0; i < Files.Length; i++)
        //        {
        //            string FileName = Files[i].Name.Substring(0, Files[i].Name.Length - 4);
        //            if (FileName == Mess.Value)
        //            {
        //                BaseClass.Function.MessageWarning("该磅单名称已经存在！");
        //                return;
        //            }
        //            //tree_AllBill.Nodes.Add(FileName, FileName,0);
        //        }
        //        File.CreateText(Application.StartupPath + @"\Bill" + @"\" + Mess.Value + ".fr3");
        //    }
        //    //int iRent = this.list_AllBill.SelectedIndex;
        //    //this.list_AllBill.Items.RemoveAt(this.list_AllBill.SelectedIndex);
        //    this.list_AllBill.Items.AddAt(Mess.Value, Mess.Value, 0);
        //    //SelectAllBill();
        //    if (list_AllBill.Items.Count > 0)
        //        this.list_AllBill.SelectedIndex = 0;
        //}
        //设计磅单
        private void Btn_Design_Click(object sender, EventArgs e)
        {
            //Print.BillPrint.Report.MyReport.PrintReport(2);

        }
        //预览
        private void Btn_Preview_Click(object sender, EventArgs e)
        {
            //Print.BillPrint.Report.MyReport.PrintReport(1);
        }
        //磅单选择改变时
        private void list_AllBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Print.BillPrint.Report.MyReport.Dispose();
            //Print.BillPrint.Report.MyReport.FileName = Application.StartupPath + @"\Bill" + @"\" + list_AllBill.Text.Trim() + ".fr3";
            //Print.BillPrint.Report.MyReport.LoadReport(this.Ds, "Bill");
        }

        //删除
        private void But_Del_Click(object sender, EventArgs e)
        {
            if (list_AllBill.Items.Count <= 1)
                return;
            if (MessageBox.Show("确认删除“" + list_AllBill.Text + "”？", "称重提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                File.Delete(Application.StartupPath + @"\Bill" + @"\" + list_AllBill.Text.Trim() + ".fr3");
                this.list_AllBill.Items.RemoveAt(this.list_AllBill.SelectedIndex);
                //SelectAllBill();
                if (list_AllBill.Items.Count > 0)
                    this.list_AllBill.SelectedIndex = 0;
            }
        }

        //修改名字  
        private void But_ReName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改“" + list_AllBill.Text + "”的文件名？", "称重提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                BaseClass.MessageBoxFrm Mess = new WSV.BaseClass.MessageBoxFrm("输入", "请输入文件名：");
                Mess.ShowDialog();
                if (Mess.Value.Trim() != "")
                {
                    DirectoryInfo mydir = new DirectoryInfo(Application.StartupPath + @"\Bill");
                    FileInfo[] Files = mydir.GetFiles("*.fr3");
                    //this.list_AllBill.Items.Clear();
                    for (int i = 0; i < Files.Length; i++)
                    {
                        string FileName = Files[i].Name.Substring(0, Files[i].Name.Length - 4);
                        if (FileName == Mess.Value)
                        {
                            BaseClass.Function.MessageWarning("该磅单名称已经存在！");
                            return;
                        }
                        //tree_AllBill.Nodes.Add(FileName, FileName,0);
                    }
                    File.Move(Application.StartupPath + @"\Bill" + @"\" + list_AllBill.Text.Trim() + ".fr3",
                        Application.StartupPath + @"\Bill" + @"\" + Mess.Value + ".fr3");
                }
                int iRent = this.list_AllBill.SelectedIndex;
                this.list_AllBill.Items.RemoveAt(this.list_AllBill.SelectedIndex);
                this.list_AllBill.Items.AddAt(Mess.Value, Mess.Value, iRent);
                //SelectAllBill();
                if (list_AllBill.Items.Count > 0)
                    this.list_AllBill.SelectedIndex = iRent;
            }
        }

        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
            this.Close();
        }

        private DataSet Ds;
        //得到Bill文件夹下面的所有磅单文件
        private void SelectAllBill()
        {
            DirectoryInfo mydir = new DirectoryInfo(Application.StartupPath + @"\Bill");
            FileInfo[] Files = mydir.GetFiles("*.fr3");
            //this.list_AllBill.Items.Clear();
            for (int i = 0; i < Files.Length; i++)
            {
                string FileName = Files[i].Name.Substring(0, Files[i].Name.Length - 4);
                this.list_AllBill.Items.Add(FileName, FileName);

                //tree_AllBill.Nodes.Add(FileName, FileName,0);
            }
        }
        //绑定设计数据库
        private void BindDB()
        {
            Ds = BillInfoBLL.BillPrint("", "Bill");
            DataRow Dr = Ds.Tables[0].NewRow();
            foreach (DataColumn Col in Ds.Tables[0].Columns)
            {
                if (Col.DataType == System.Type.GetType("System.String"))
                    Dr[Col.ColumnName] = Col.ColumnName;
                else if (Col.DataType == System.Type.GetType("System.DateTime"))
                    Dr[Col.ColumnName] = DateTime.Now;
                else
                    Dr[Col.ColumnName] = 1000;
            }
            Ds.Tables[0].Rows.Add(Dr);
            this.gv_DB.DataSource = Ds.Tables[0];
        }
    }
}