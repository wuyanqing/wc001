using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WSV.MyLog
{
    public partial class WeightRecord : Form
    {
        WSV.Model.Weight.WeightModel Values = new WSV.Model.Weight.WeightModel();
        private string _Scode = "";
        public string Scode { get { return _Scode; } set { _Scode = value; } }
        public WeightRecord()
        {
            InitializeComponent();
        }

        private void WeightRecord_Load(object sender, EventArgs e)
        {
            bool flag = BLL.MyLog.DL_Weight.Addpicture(Scode, Values);
            if (flag)
            {
                
                this.pB_Video1.Image = bytetoimage(Values.StateFun.Image1);
                this.pB_Video2.Image = bytetoimage(Values.StateFun.Image2);
                this.pB_Video3.Image = bytetoimage(Values.StateFun.Image3);
                this.pB_Video4.Image = bytetoimage(Values.StateFun.Image4);
            }
            bool flag1 = BLL.MyLog.DL_Weight.AddCurve(Scode, Values);
            if (flag1)
            {
                this.pB_Curve.Image = bytetoimage(Values.StateFun.Curve);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (toolStripLabel1.Text == "显示曲线图")
            {
                pB_Curve.Visible = true;
                pB_Video1.Visible = false;
                pB_Video2.Visible = false;
                pB_Video3.Visible = false;
                pB_Video4.Visible = false;
                //toolStrip1.Text = "显示图片";
                toolStripLabel1.Text = "显示图片";
                this.Text = "曲线图";
            }
            else
            {
                pB_Curve.Visible = false;
                pB_Video1.Visible = true;
                pB_Video2.Visible = true;
                pB_Video3.Visible = true;
                pB_Video4.Visible = true;
                toolStripLabel1.Text = "显示曲线图";
                this.Text = "视频图片";
            }
        }
        //二进制变为图片
        private Image bytetoimage(byte[] bytedata)
        {
            MemoryStream imagevlues = new MemoryStream(bytedata);
            System.Drawing.Image image = Image.FromStream(imagevlues);
            imagevlues.Close();
            imagevlues.Dispose();

            return image;
            //image.Dispose();
        }

        private void WeightRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pB_Video1.Image = null;
            this.pB_Video2.Image = null;
            this.pB_Video3.Image = null;
            this.pB_Video4.Image = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}