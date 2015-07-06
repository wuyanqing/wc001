namespace LEDSHOW
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbwaitcars2 = new System.Windows.Forms.Label();
            this.lblAllCurrentQty2 = new System.Windows.Forms.Label();
            this.lblCurrentQty2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblBatchValue2 = new System.Windows.Forms.Label();
            this.lbwaitstoragecar2 = new System.Windows.Forms.Label();
            this.lbcurrentstoragecar2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbwaitcars1 = new System.Windows.Forms.Label();
            this.lblAllCurrentQty1 = new System.Windows.Forms.Label();
            this.lblCurrentQty1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBatchValue1 = new System.Windows.Forms.Label();
            this.lbwaitstoragecar1 = new System.Windows.Forms.Label();
            this.lbcurrentstoragecar1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ForeShow = new System.Windows.Forms.ToolStripMenuItem();
            this.BackShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAllWaitCars = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "永州入库实时进度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(12, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 14);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "当前时间：";
            // 
            // lblTimeTxt
            // 
            this.lblTimeTxt.AutoSize = true;
            this.lblTimeTxt.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTimeTxt.ForeColor = System.Drawing.Color.Red;
            this.lblTimeTxt.Location = new System.Drawing.Point(78, 2);
            this.lblTimeTxt.Name = "lblTimeTxt";
            this.lblTimeTxt.Size = new System.Drawing.Size(0, 14);
            this.lblTimeTxt.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.lbAllWaitCars);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblTimeTxt);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 221);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbwaitcars2);
            this.groupBox2.Controls.Add(this.lblAllCurrentQty2);
            this.groupBox2.Controls.Add(this.lblCurrentQty2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblBatchValue2);
            this.groupBox2.Controls.Add(this.lbwaitstoragecar2);
            this.groupBox2.Controls.Add(this.lbcurrentstoragecar2);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(253, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 179);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2号链板机入库明细 ";
            // 
            // lbwaitcars2
            // 
            this.lbwaitcars2.AutoSize = true;
            this.lbwaitcars2.Location = new System.Drawing.Point(85, 62);
            this.lbwaitcars2.Name = "lbwaitcars2";
            this.lbwaitcars2.Size = new System.Drawing.Size(30, 17);
            this.lbwaitcars2.TabIndex = 18;
            this.lbwaitcars2.Text = "2辆";
            // 
            // lblAllCurrentQty2
            // 
            this.lblAllCurrentQty2.AutoSize = true;
            this.lblAllCurrentQty2.Font = new System.Drawing.Font("宋体", 10F);
            this.lblAllCurrentQty2.ForeColor = System.Drawing.Color.Red;
            this.lblAllCurrentQty2.Location = new System.Drawing.Point(96, 31);
            this.lblAllCurrentQty2.Name = "lblAllCurrentQty2";
            this.lblAllCurrentQty2.Size = new System.Drawing.Size(28, 14);
            this.lblAllCurrentQty2.TabIndex = 36;
            this.lblAllCurrentQty2.Text = "300";
            // 
            // lblCurrentQty2
            // 
            this.lblCurrentQty2.AutoSize = true;
            this.lblCurrentQty2.Font = new System.Drawing.Font("宋体", 10F);
            this.lblCurrentQty2.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentQty2.Location = new System.Drawing.Point(213, 31);
            this.lblCurrentQty2.Name = "lblCurrentQty2";
            this.lblCurrentQty2.Size = new System.Drawing.Size(28, 14);
            this.lblCurrentQty2.TabIndex = 32;
            this.lblCurrentQty2.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(6, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "待卸车辆数：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10F);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(135, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 14);
            this.label17.TabIndex = 34;
            this.label17.Text = "未入数量:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(6, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 14);
            this.label18.TabIndex = 35;
            this.label18.Text = "入库总数量:";
            // 
            // lblBatchValue2
            // 
            this.lblBatchValue2.AutoSize = true;
            this.lblBatchValue2.Location = new System.Drawing.Point(205, 130);
            this.lblBatchValue2.Name = "lblBatchValue2";
            this.lblBatchValue2.Size = new System.Drawing.Size(28, 17);
            this.lblBatchValue2.TabIndex = 16;
            this.lblBatchValue2.Text = "0%";
            // 
            // lbwaitstoragecar2
            // 
            this.lbwaitstoragecar2.AutoSize = true;
            this.lbwaitstoragecar2.Location = new System.Drawing.Point(85, 158);
            this.lbwaitstoragecar2.Name = "lbwaitstoragecar2";
            this.lbwaitstoragecar2.Size = new System.Drawing.Size(50, 17);
            this.lbwaitstoragecar2.TabIndex = 14;
            this.lbwaitstoragecar2.Text = "车牌号";
            // 
            // lbcurrentstoragecar2
            // 
            this.lbcurrentstoragecar2.AutoSize = true;
            this.lbcurrentstoragecar2.Location = new System.Drawing.Point(85, 94);
            this.lbcurrentstoragecar2.Name = "lbcurrentstoragecar2";
            this.lbcurrentstoragecar2.Size = new System.Drawing.Size(50, 17);
            this.lbcurrentstoragecar2.TabIndex = 13;
            this.lbcurrentstoragecar2.Text = "车牌号";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(4, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 17);
            this.label23.TabIndex = 12;
            this.label23.Text = "入库进度：";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(88, 125);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(104, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.Location = new System.Drawing.Point(4, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 17);
            this.label24.TabIndex = 8;
            this.label24.Text = "准备入库：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(6, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 17);
            this.label25.TabIndex = 4;
            this.label25.Text = "正在入库：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(478, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbwaitcars1);
            this.groupBox1.Controls.Add(this.lblAllCurrentQty1);
            this.groupBox1.Controls.Add(this.lblCurrentQty1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBatchValue1);
            this.groupBox1.Controls.Add(this.lbwaitstoragecar1);
            this.groupBox1.Controls.Add(this.lbcurrentstoragecar1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 182);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1号链板机入库明细 ";
            // 
            // lbwaitcars1
            // 
            this.lbwaitcars1.AutoSize = true;
            this.lbwaitcars1.Location = new System.Drawing.Point(85, 62);
            this.lbwaitcars1.Name = "lbwaitcars1";
            this.lbwaitcars1.Size = new System.Drawing.Size(30, 17);
            this.lbwaitcars1.TabIndex = 18;
            this.lbwaitcars1.Text = "3辆";
            // 
            // lblAllCurrentQty1
            // 
            this.lblAllCurrentQty1.AutoSize = true;
            this.lblAllCurrentQty1.Font = new System.Drawing.Font("宋体", 10F);
            this.lblAllCurrentQty1.ForeColor = System.Drawing.Color.Red;
            this.lblAllCurrentQty1.Location = new System.Drawing.Point(92, 34);
            this.lblAllCurrentQty1.Name = "lblAllCurrentQty1";
            this.lblAllCurrentQty1.Size = new System.Drawing.Size(28, 14);
            this.lblAllCurrentQty1.TabIndex = 36;
            this.lblAllCurrentQty1.Text = "570";
            // 
            // lblCurrentQty1
            // 
            this.lblCurrentQty1.AutoSize = true;
            this.lblCurrentQty1.Font = new System.Drawing.Font("宋体", 10F);
            this.lblCurrentQty1.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentQty1.Location = new System.Drawing.Point(213, 34);
            this.lblCurrentQty1.Name = "lblCurrentQty1";
            this.lblCurrentQty1.Size = new System.Drawing.Size(28, 14);
            this.lblCurrentQty1.TabIndex = 32;
            this.lblCurrentQty1.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "待卸车辆数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "未入数量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(2, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "入库总数量:";
            // 
            // lblBatchValue1
            // 
            this.lblBatchValue1.AutoSize = true;
            this.lblBatchValue1.Location = new System.Drawing.Point(204, 130);
            this.lblBatchValue1.Name = "lblBatchValue1";
            this.lblBatchValue1.Size = new System.Drawing.Size(28, 17);
            this.lblBatchValue1.TabIndex = 16;
            this.lblBatchValue1.Text = "0%";
            // 
            // lbwaitstoragecar1
            // 
            this.lbwaitstoragecar1.AutoSize = true;
            this.lbwaitstoragecar1.Location = new System.Drawing.Point(85, 158);
            this.lbwaitstoragecar1.Name = "lbwaitstoragecar1";
            this.lbwaitstoragecar1.Size = new System.Drawing.Size(50, 17);
            this.lbwaitstoragecar1.TabIndex = 14;
            this.lbwaitstoragecar1.Text = "车牌号";
            // 
            // lbcurrentstoragecar1
            // 
            this.lbcurrentstoragecar1.AutoSize = true;
            this.lbcurrentstoragecar1.Location = new System.Drawing.Point(85, 94);
            this.lbcurrentstoragecar1.Name = "lbcurrentstoragecar1";
            this.lbcurrentstoragecar1.Size = new System.Drawing.Size(50, 17);
            this.lbcurrentstoragecar1.TabIndex = 13;
            this.lbcurrentstoragecar1.Text = "车牌号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(4, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "入库进度：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(88, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(104, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(4, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "准备入库：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "正在入库：";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LED显示屏";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenScreen,
            this.CloseScreen,
            this.ForeShow,
            this.BackShow,
            this.ExitScreen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 114);
            // 
            // OpenScreen
            // 
            this.OpenScreen.Name = "OpenScreen";
            this.OpenScreen.Size = new System.Drawing.Size(158, 22);
            this.OpenScreen.Text = "打开LED显示屏";
            this.OpenScreen.Click += new System.EventHandler(this.OpenScreen_Click);
            // 
            // CloseScreen
            // 
            this.CloseScreen.Name = "CloseScreen";
            this.CloseScreen.Size = new System.Drawing.Size(158, 22);
            this.CloseScreen.Text = "关闭LED显示屏";
            this.CloseScreen.Click += new System.EventHandler(this.CloseScreen_Click);
            // 
            // ForeShow
            // 
            this.ForeShow.Name = "ForeShow";
            this.ForeShow.Size = new System.Drawing.Size(158, 22);
            this.ForeShow.Text = "前台播放LED屏";
            this.ForeShow.Click += new System.EventHandler(this.ForeShow_Click);
            // 
            // BackShow
            // 
            this.BackShow.Name = "BackShow";
            this.BackShow.Size = new System.Drawing.Size(158, 22);
            this.BackShow.Text = "后台播放LED屏";
            this.BackShow.Click += new System.EventHandler(this.BackShow_Click);
            // 
            // ExitScreen
            // 
            this.ExitScreen.Name = "ExitScreen";
            this.ExitScreen.Size = new System.Drawing.Size(158, 22);
            this.ExitScreen.Text = "退出LED显示屏";
            this.ExitScreen.Click += new System.EventHandler(this.ExitScreen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(337, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "待卸车辆总数：";
            // 
            // lbAllWaitCars
            // 
            this.lbAllWaitCars.AutoSize = true;
            this.lbAllWaitCars.Font = new System.Drawing.Font("宋体", 12F);
            this.lbAllWaitCars.ForeColor = System.Drawing.Color.Red;
            this.lbAllWaitCars.Location = new System.Drawing.Point(458, 6);
            this.lbAllWaitCars.Name = "lbAllWaitCars";
            this.lbAllWaitCars.Size = new System.Drawing.Size(32, 16);
            this.lbAllWaitCars.TabIndex = 36;
            this.lbAllWaitCars.Text = "2辆";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(351, 148);
            this.Name = "OrderList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OrderList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenScreen;
        private System.Windows.Forms.ToolStripMenuItem CloseScreen;
        private System.Windows.Forms.ToolStripMenuItem BackShow;
        private System.Windows.Forms.ToolStripMenuItem ExitScreen;
        private System.Windows.Forms.ToolStripMenuItem ForeShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentQty1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAllCurrentQty1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBatchValue1;
        private System.Windows.Forms.Label lbwaitstoragecar1;
        private System.Windows.Forms.Label lbcurrentstoragecar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbwaitcars1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbwaitcars2;
        private System.Windows.Forms.Label lblAllCurrentQty2;
        private System.Windows.Forms.Label lblCurrentQty2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblBatchValue2;
        private System.Windows.Forms.Label lbwaitstoragecar2;
        private System.Windows.Forms.Label lbcurrentstoragecar2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbAllWaitCars;
        private System.Windows.Forms.Label label3;

    }
}