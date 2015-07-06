using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarDispatch
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //绑定未递交货运单所有的车辆数据
        private void CarDataBind()
        {
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.DataSource = Bll.CarMain.MainBlll.SelectAllCar("0").Tables[0];
        }
        //绑定1号伸缩链板机的未卸货排队车辆数据
        private void DataBind1()
        {
            this.myDataGridView2.AutoGenerateColumns = false;
            this.myDataGridView2.DataSource = Bll.CarMain.MainBlll.SelectAll("1","").Tables[0];
        }
        //绑定2号伸缩链板机的未卸货排队车辆数据
        private void DataBind2()
        {
            this.myDataGridView3.AutoGenerateColumns = false;
            this.myDataGridView3.DataSource = Bll.CarMain.MainBlll.SelectAll("2", "").Tables[0];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //BLL.PublicFun.IniFile Ini = new BLL.PublicFun.IniFile(Model.FilePath.Config);
            this.button1.Text = "开始调度";
            CarDataBind();
            this.myDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.comboBox1.Text= "请选择车牌号";
            //if (this.myDataGridView1.Rows.Count > 0)
            //    this.myDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataBind1();
            DataBind2();
            this.label32.Text = Bll.CarMain.MainBlll.SelectAllCar("1").Tables[0].Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "开始调度")
            {
                if (Bll.CarMain.MainBlll.UpdateCarDispatchState("1") == "0101")
                {
                    this.button1.Text = "停止调度";
                }
            }
           else 
            {
                if (Bll.CarMain.MainBlll.UpdateCarDispatchState("0") == "0101")
                {
                    this.button1.Text = "开始调度";

                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.button1.Text == "停止调度")
            {
                BaseClass.Function.MessageWarning("退出前，请先停止车辆调度！");
                this.Owner = this;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inform.inform frm = new inform.inform();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
