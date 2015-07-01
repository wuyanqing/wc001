using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSV.SysInfo
{
    public partial class LoadBll : Form
    {
        public LoadBll()
        {
            InitializeComponent();
        }
        private bool _Flag;
        public bool Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }
        private void LoadBll_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (Flag)
            //{
            //    Print.BillPrint.Report.MyReport.PrintReport(3);
            //}
            //else
            //{
            //    timer1.Stop();
            //    this.Close();
            //}
        }
    }
}