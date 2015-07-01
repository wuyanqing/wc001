using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OWC11;

namespace WSV.Count
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.wucheng;
        }
        private string _Title, _sqlCount, _ByName;
        /// <summary>
        /// 图形报表名称
        /// </summary>
        public string Title { get { return _Title; } set { _Title = value; } }
        /// <summary>
        /// 图形报表条件
        /// </summary>
        public string sqlCount { get { return _sqlCount; } set { _sqlCount = value; } }
        /// 汇总的第一个字段
        /// </summary>
        public string ByName { get { return _ByName; } set { _ByName = value; } }

        private void Graph_Load(object sender, EventArgs e)
        {
            ShowChart();
        }
        public void ShowChart()
        {
            try
            {
                string sql = "select sum(EndNet) as EndNet,sum(Gross) as Gross," + this.ByName + " from V_D_saver " + this.sqlCount + " and " + this.ByName + "<>'' group by " + this.ByName + ""; //"select * from data_saver";
                DataTable table = BLL.Count.ChartBll.SaverInfo(sql).Tables[0];
                if (table != null && table.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            sb.Append(table.Rows[i][this.ByName].ToString());
                        }
                        else
                        {
                            sb.Append("," + table.Rows[i][this.ByName].ToString());
                        }
                    }
                    string[] CategoriesArr ={ sb.ToString() };
                    sb = new StringBuilder();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            //sb.Append(table.Rows[i]["gross"].ToString());
                            sb.Append(table.Rows[i]["EndNet"].ToString());
                        }
                        else
                        {
                            //sb.Append(table.Rows[i]["gross"].ToString());
                            sb.Append("," + table.Rows[i]["EndNet"].ToString());
                        }
                    }
                    string[] ValuesArr = { sb.ToString() };
                    BLL.Count.ChartFactory chartFactory = new WSV.BLL.Count.ChartFactory();
                    //ChartFactory 
                    //初始化赋值
                    chartFactory.chartCategoriesArrValue = CategoriesArr;
                    chartFactory.chartValuesArrValue = ValuesArr;
                    chartFactory.chartTitleValue = Title;//柱形图标注名称
                    chartFactory.chartTypeValue = "垂直柱状统计图";//图类型,在类中定义过

                    OWC11.ChartSpaceClass oChartSpace = chartFactory.BuildCharts();
                    string path = System.IO.Directory.GetCurrentDirectory() + "\\data\\图形报表.bmp";  //产生图片并保存 页可以是png gif图片

                    oChartSpace.ExportPicture(path, "jpeg", this.Width - 20, this.Height - 50);//后面是图片的宽和高

                    //下面使用    FileStream 对象的原因是本例使用线程.每秒重新生成一个图,并将原图覆盖.
                    //如果不使用 FileStream 将会出现共享冲突.        
                    FileStream fs = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\data\\图形报表.bmp", FileMode.Open, FileAccess.Read);
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    //本例使用pictureBox1显示图片
                    this.pictureBox1.Image = img;
                    this.pictureBox1.Refresh();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}