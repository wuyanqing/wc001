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
            lblTimeTxt.Text = DateTime.Now.ToString();
        }
        private void Run()
        {
            try
            {
                lblTimeTxt.Text = DateTime.Now.ToString();
                using (PersistentManager pm = new PersistentManager("DefaultConnection"))
                {

                    TimeDao timeshow = new TimeDao();
                    timeshow.SetPersistentManager(pm);
                    //一号
                    string sortNo = Convert.ToString("one");


                    DataTable infoTable = timeshow.FindSortTime(sortNo);
                    RefreshAgv refreshAgv = new RefreshAgv();
                    int nu = 0;
                    RefreshData2 re = new RefreshData2();
                    if (infoTable.Rows.Count > 1)
                    {
                        nu = Convert.ToInt32(infoTable.Rows[0]["Times"]);

                        double a = nu * 0.0 / 3600;
                        re.CompleteQuantity2 = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]) / Convert.ToInt32(a);
                    }
                    else
                    {
                        re.CompleteQuantity2 = 0;
                    }

                }

                using (PersistentManager pm = new PersistentManager("DefaultConnection2"))
                {
                    LedShowDao ledShowDao = new LedShowDao();
                    ledShowDao.SetPersistentManager(pm);
                    string sortNo = Convert.ToString("all");

                    DataTable infoTable = ledShowDao.FindOrderInfo(sortNo);
                    RefreshData refreshData = new RefreshData();
                    refreshData.TotalCustomer = Convert.ToInt32(infoTable.Rows[0]["CUSTOMERNUM"]);
                    refreshData.TotalRoute = Convert.ToInt32(infoTable.Rows[0]["ROUTENUM"]);
                    refreshData.TotalQuantity = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]);

                    //已分拣
                    infoTable = ledShowDao.FindOrderInfo("");
                    refreshData.CompleteCustomer = Convert.ToInt32(infoTable.Rows[0]["CUSTOMERNUM"]);
                    refreshData.CompleteRoute = Convert.ToInt32(infoTable.Rows[0]["ROUTENUM"]);
                    refreshData.CompleteQuantity = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]);

                    if (refreshData.CompleteQuantity >= 1)
                    {
                        refreshData.Average = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]) / ledShowDao.FindSortingAverage();
                    }
                    else
                    {
                        refreshData.Average = 0;
                    }
                    if (ledShowDao.FindCurrentRoute().Rows.Count != 0)
                    {
                        refreshData.RouteName = ledShowDao.FindCurrentRoute().Rows[0]["ROUTENAME"].ToString();
                    }
                    else
                    {
                        refreshData.RouteName = "";
                    }

                    refreshData.Batch = Convert.ToDateTime(ledShowDao.FindOrderdate().Rows[0]["ORDERDATE"]).ToString("yyyy-MM-dd") + "批次：" + ledShowDao.FindOrderdate().Rows[0]["BATCHNO"].ToString();
                    Refresh(refreshData);
                }
                using (PersistentManager pm = new PersistentManager("DefaultConnection3"))
                {

                    LedShowDao ledShowDao = new LedShowDao();
                    ledShowDao.SetPersistentManager(pm);
                    string sortNo = Convert.ToString("all"); ;

                    DataTable infoTable = ledShowDao.FindOrderInfo(sortNo);
                    RefreshData2 refreshData2 = new RefreshData2();
                    refreshData2.TotalCustomer2 = Convert.ToInt32(infoTable.Rows[0]["CUSTOMERNUM"]);
                    refreshData2.TotalRoute2 = Convert.ToInt32(infoTable.Rows[0]["ROUTENUM"]);
                    refreshData2.TotalQuantity2 = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]);

                    infoTable = ledShowDao.FindOrderInfo("");
                    refreshData2.CompleteCustomer2 = Convert.ToInt32(infoTable.Rows[0]["CUSTOMERNUM"]);
                    refreshData2.CompleteRoute2 = Convert.ToInt32(infoTable.Rows[0]["ROUTENUM"]);
                    refreshData2.CompleteQuantity2 = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]);
                    if (refreshData2.CompleteQuantity2 >= 1)
                    {
                        refreshData2.Average2 = Convert.ToInt32(infoTable.Rows[0]["QUANTITY"]) / ledShowDao.FindSortingAverage();
                    }
                    else
                    {
                        refreshData2.Average2 = 0;
                    }
                    if (ledShowDao.FindCurrentRoute().Rows.Count != 0)
                    {
                        refreshData2.RouteName2 = ledShowDao.FindCurrentRoute().Rows[0]["ROUTENAME"].ToString();
                    }
                    else
                    {
                        refreshData2.RouteName2 = "";
                    }
                    refreshData2.Batch2 = Convert.ToDateTime(ledShowDao.FindOrderdate().Rows[0]["ORDERDATE"]).ToString("yyyy-MM-dd") + "批次：" + ledShowDao.FindOrderdate().Rows[0]["BATCHNO"].ToString();
                    Refresh2(refreshData2);
                 
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法连接数据库");
              
            }
        }
        private void Refresh(RefreshData refreshData)
        {
        }
        private void Refresh2(RefreshData2 refreshData)
        {
           
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
