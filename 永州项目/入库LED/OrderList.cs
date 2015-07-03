using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataRabbit.DBAccessing.Application;
using DataRabbit.DBAccessing;
using DataRabbit.DBAccessing.ORM;
using DataRabbit.HashOrm;
using DataRabbit;
using System.Threading;

using LEDSHOW.Dao;
using THOK.Util;

namespace LEDSHOW
{
    public partial class OrderList : Form
    {
        OrderFormConfig config = new OrderFormConfig(@".\OrderFormConfig.xml");
        bool IsSendToasynChronousScreen = false;
        int _Left = 0;
        int _LeftOffset = 0;

        public OrderList()
        {
            InitializeComponent();
        }
        private void Run()
        {
            try
            {
                lblTimeTxt.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分");

                using (PersistentManager pm = new PersistentManager())
                {

                    LedShowDao ledShowDao = new LedShowDao();
                    //总数量  
                    string sortNo = Convert.ToString("all"); ;
                    DataTable infoTable = ledShowDao.FindOrderInfo(sortNo);
                    RefreshData refreshData = new RefreshData();
                    if (!String.IsNullOrEmpty(infoTable.Rows[0][0].ToString()))
                    {
                        refreshData.Total = Convert.ToInt32(infoTable.Rows[0]["total"]);
                        //已入库
                        infoTable = ledShowDao.FindOrderInfo("");
                        if (!String.IsNullOrEmpty(infoTable.Rows[0][0].ToString()))
                        {
                            refreshData.Untotal = Convert.ToInt32(infoTable.Rows[0]["total"]);
                        }
                        else
                        {
                            refreshData.Untotal = 0;
                        }
                        //查询车载入库信息
                        infoTable = ledShowDao.FindProductMiss("");
                        if (infoTable.Rows.Count == 0)
                        {
                            string tem = "当前无入库任务。";
                            refreshData.Product_name += tem;
                        }
                        else
                        {
                            int i = 0;
                            foreach (DataRow dr in infoTable.Rows)
                            {
                                i += 1;
                                if (i < 10)
                                {
                                    string tem = string.Format("{0},  {1},  {2} 正在入库\r\n", dr["cell_name"], dr["task_quantity"], dr["product_name"]);
                                    refreshData.Product_name += tem;
                                }
                            }
                        }
                        Refresh(refreshData);
                    }
                    else
                    {
                        //string tem = "当前无入库任务。";
                        string tem = "正在入库：";
                        refreshData.Product_name += tem;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Refresh(RefreshData refreshData)
        {
            lblCurrentRoute2.Text = refreshData.Total.ToString(); //入库总数
            lblCurrentRoute.Text = refreshData.Untotal.ToString();//已入库数量   
            PbarBatch.Value = (int)(Convert.ToDouble(refreshData.Untotal) / refreshData.Total * 100);
            lblBatchValue.Text = PbarBatch.Value.ToString() + "%";
            label4.Text = refreshData.Product_name;
        }

        private Bitmap PrintForm()
        {
            Bitmap bit = new Bitmap(this.Size.Width, this.Size.Height);
            this.DrawToBitmap(bit, new Rectangle(0, 0, this.Width, this.Height));
            bit.Save("D:\\a.bmp");
            return bit;
        }
        private void PrintScreen()
        {
            Graphics graphic = this.CreateGraphics();

            Size s = this.Size;

            Image memImage = new Bitmap(s.Width, s.Height, graphic);

            Graphics memGraphic = Graphics.FromImage(memImage);

            IntPtr dc1 = graphic.GetHdc();

            IntPtr dc2 = memGraphic.GetHdc();

            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);

            graphic.ReleaseHdc(dc1);

            memGraphic.ReleaseHdc(dc2);

            memImage.Save(@".\test.jpg");

        }



        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]

        private static extern bool BitBlt(

                  IntPtr hdcDest,   //   handle   to   destination   DC     

                  int nXDest,   //   x-coord   of   destination   upper-left   corner     

                  int nYDest,   //   y-coord   of   destination   upper-left   corner     

                  int nWidth,   //   width   of   destination   rectangle     

                  int nHeight,   //   height   of   destination   rectangle     

                  IntPtr hdcSrc,   //   handle   to   source   DC     

                  int nXSrc,   //   x-coordinate   of   source   upper-left   corner     

                  int nYSrc,   //   y-coordinate   of   source   upper-left   corner     

                  System.Int32 dwRop   //   raster   operation   code     

                  );

        private void OrderList_Load(object sender, EventArgs e)
        {
            this.Top = Convert.ToInt32(config.getTop());
            this.Left = Convert.ToInt32(config.getLeft());
            this._Left = this.Left;
            this._LeftOffset = Convert.ToInt32(config.getLeftOffset());
            this.Height = Convert.ToInt32(config.getHeight());
            this.Width = Convert.ToInt32(config.getWidth());
            this.timer1.Interval = Convert.ToInt32(config.getTimerInterval());
            this.IsSendToasynChronousScreen = config.getIsSendToasynChronousScreen();

            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));

                    if (led.IsOpenScreen)
                    {
                        led.SendToLed(PrintForm());
                    }
                    else if (led.OpenScreen())
                    {
                        led.SendToLed(PrintForm());
                    }
                    else
                    {
                        MessageBox.Show(address + "号屏打开失败！请检查！", "电子标签服务", MessageBoxButtons.OK);
                    }
                }
            }
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            this.timer1.Enabled = true;

        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));
                    led.Dispose();
                }
            }
        }
        private void SendToasynChronousScreen()
        {
            if (IsSendToasynChronousScreen)
            {
                string[] ledaddresses = config.getLedAddressList();
                foreach (string address in ledaddresses)
                {
                    LED2008 led = LED2008.Create(Convert.ToInt32(address));

                    if (led.IsOpenScreen)
                    {
                        led.SendToLed(PrintForm());
                    }
                    else if (led.OpenScreen())
                    {
                        led.SendToLed(PrintForm());
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OpenScreen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void CloseScreen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ExitScreen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BackShow_Click(object sender, EventArgs e)
        {
            this.Left = this._Left + this._LeftOffset;
        }

        private void ForeShow_Click(object sender, EventArgs e)
        {
            this.Left = this._Left;
        }
    }
}
