using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WSV.Search
{
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
            this.Icon = WSV.Properties.Resources.wucheng;
        }
        private string _Code;
        private bool _Flag = true;
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public bool Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }
        private void FrmImage_Load(object sender, EventArgs e)
        {
            //Model.Weight.StateModel Item = new WSV.Model.Weight.StateModel();
            this.pBT_Video1.Visible = true;
            this.pBT_Video2.Visible = true;
            this.pBT_Video3.Visible = true;
            this.pBT_Video4.Visible = true;
            this.pBG_Video1.Visible = true;
            this.pBG_Video2.Visible = true;
            this.pBG_Video3.Visible = true;
            this.pBG_Video4.Visible = true;
            this.pBM_Curve.Visible = false;
            this.pBT_Curve.Visible = false;
            if (Flag)
            {
                Model.Weight.StateModel Item = new WSV.Model.Weight.StateModel();
                if (!string.IsNullOrEmpty(this.Code))
                {
                    BLL.Search.SearchBll.DataShowImage(ref Item, this.Code);
                    this.pBG_Video1.Image = bytetoimage(Item.G_Image1);
                    this.pBG_Video2.Image = bytetoimage(Item.G_Image2);
                    this.pBG_Video3.Image = bytetoimage(Item.G_Image3);
                    this.pBG_Video4.Image = bytetoimage(Item.G_Image4);
                    this.pBT_Video1.Image = bytetoimage(Item.T_Image1);
                    this.pBT_Video2.Image = bytetoimage(Item.T_Image2);
                    this.pBT_Video3.Image = bytetoimage(Item.T_Image3);
                    this.pBT_Video4.Image = bytetoimage(Item.T_Image4);
                    this.pBM_Curve.Image = bytetoimage(Item.G_Curve);
                    this.pBT_Curve.Image = bytetoimage(Item.T_Curve);
                }
            }
            else
            {
                Model.Weight.WeightModel Item = new WSV.Model.Weight.WeightModel();
                if (Convert.ToDecimal(BLL.PublicFun.PublicFun.GetKey("Gross", "V_D_Saver_Temp", Code, this.Code, 0)) == 0)
                {
                    BLL.Weight.WeightBLL.SelectImage(this.Code, Item, "P");
                    this.pBT_Video1.Image = bytetoimage(Item.StateFun.T_Image1);
                    this.pBT_Video2.Image = bytetoimage(Item.StateFun.T_Image2);
                    this.pBT_Video3.Image = bytetoimage(Item.StateFun.T_Image3);
                    this.pBT_Video4.Image = bytetoimage(Item.StateFun.T_Image4);
                    this.pBT_Curve.Image = bytetoimage(Item.StateFun.T_Curve);
                }
                else
                {
                    BLL.Weight.WeightBLL.SelectImage(this.Code, Item, "M");
                    this.pBG_Video1.Image = bytetoimage(Item.StateFun.G_Image1);
                    this.pBG_Video2.Image = bytetoimage(Item.StateFun.G_Image2);
                    this.pBG_Video3.Image = bytetoimage(Item.StateFun.G_Image3);
                    this.pBG_Video4.Image = bytetoimage(Item.StateFun.G_Image4);
                    this.pBM_Curve.Image = bytetoimage(Item.StateFun.G_Curve);
                }
            }
        }
        //二进制变成图片
        private Image bytetoimage(byte[] bytedata)
        {
            Image image = WSV.Properties.Resources.dl;
            if (bytedata != null)
            {
                MemoryStream imagevlues = new MemoryStream(bytedata);
                image = Image.FromStream(imagevlues);
                imagevlues.Close();
                imagevlues.Dispose();

                //image.Dispose();
            }
            return image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "显示曲线图")
            {
                this.pBT_Video1.Visible = false;
                this.pBT_Video2.Visible = false;
                this.pBT_Video3.Visible = false;
                this.pBT_Video4.Visible = false;
                this.pBG_Video1.Visible = false;
                this.pBG_Video2.Visible = false;
                this.pBG_Video3.Visible = false;
                this.pBG_Video4.Visible = false;
                this.pBM_Curve.Visible = true;
                this.pBT_Curve.Visible = true;
                this.button1.Text = "显示图片";
            }
            else if (this.button1.Text == "显示图片")
            {
                this.pBT_Video1.Visible = true;
                this.pBT_Video2.Visible = true;
                this.pBT_Video3.Visible = true;
                this.pBT_Video4.Visible = true;
                this.pBG_Video1.Visible = true;
                this.pBG_Video2.Visible = true;
                this.pBG_Video3.Visible = true;
                this.pBG_Video4.Visible = true;
                this.pBM_Curve.Visible = false;
                this.pBT_Curve.Visible = false;
                this.button1.Text = "显示曲线图";
            }
        }
    }
}