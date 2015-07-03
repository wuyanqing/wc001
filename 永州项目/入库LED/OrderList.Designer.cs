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
            this.lbstate = new System.Windows.Forms.Label();
            this.btnswitch = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblCurrentRoute2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentRoute = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBatchValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PbarBatch = new System.Windows.Forms.ProgressBar();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.lbstate);
            this.panel2.Controls.Add(this.btnswitch);
            this.panel2.Controls.Add(this.btnstop);
            this.panel2.Controls.Add(this.btnstart);
            this.panel2.Controls.Add(this.lblCurrentRoute2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblCurrentRoute);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblTimeTxt);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 221);
            this.panel2.TabIndex = 1;
            // 
            // lbstate
            // 
            this.lbstate.AutoSize = true;
            this.lbstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbstate.ForeColor = System.Drawing.Color.Red;
            this.lbstate.Location = new System.Drawing.Point(233, 188);
            this.lbstate.Name = "lbstate";
            this.lbstate.Size = new System.Drawing.Size(64, 22);
            this.lbstate.TabIndex = 40;
            this.lbstate.Text = "调度中";
            // 
            // btnswitch
            // 
            this.btnswitch.BackColor = System.Drawing.Color.Azure;
            this.btnswitch.ForeColor = System.Drawing.Color.Red;
            this.btnswitch.Location = new System.Drawing.Point(403, 189);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(75, 23);
            this.btnswitch.TabIndex = 39;
            this.btnswitch.Text = "切换下辆车";
            this.btnswitch.UseVisualStyleBackColor = false;
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Azure;
            this.btnstop.ForeColor = System.Drawing.Color.Red;
            this.btnstop.Location = new System.Drawing.Point(129, 189);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 38;
            this.btnstop.Text = "停止调度";
            this.btnstop.UseVisualStyleBackColor = false;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Azure;
            this.btnstart.ForeColor = System.Drawing.Color.Red;
            this.btnstart.Location = new System.Drawing.Point(28, 189);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 37;
            this.btnstart.Text = "开始调度";
            this.btnstart.UseVisualStyleBackColor = false;
            // 
            // lblCurrentRoute2
            // 
            this.lblCurrentRoute2.AutoSize = true;
            this.lblCurrentRoute2.Font = new System.Drawing.Font("宋体", 10F);
            this.lblCurrentRoute2.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentRoute2.Location = new System.Drawing.Point(368, 3);
            this.lblCurrentRoute2.Name = "lblCurrentRoute2";
            this.lblCurrentRoute2.Size = new System.Drawing.Size(28, 14);
            this.lblCurrentRoute2.TabIndex = 36;
            this.lblCurrentRoute2.Text = "570";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(287, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "入库总数量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(402, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "已入数量:";
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
            // lblCurrentRoute
            // 
            this.lblCurrentRoute.AutoSize = true;
            this.lblCurrentRoute.Font = new System.Drawing.Font("宋体", 10F);
            this.lblCurrentRoute.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentRoute.Location = new System.Drawing.Point(472, 3);
            this.lblCurrentRoute.Name = "lblCurrentRoute";
            this.lblCurrentRoute.Size = new System.Drawing.Size(28, 14);
            this.lblCurrentRoute.TabIndex = 32;
            this.lblCurrentRoute.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblBatchValue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.PbarBatch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 156);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库明细 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "5辆";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "待卸车辆数：";
            // 
            // lblBatchValue
            // 
            this.lblBatchValue.AutoSize = true;
            this.lblBatchValue.Location = new System.Drawing.Point(339, 66);
            this.lblBatchValue.Name = "lblBatchValue";
            this.lblBatchValue.Size = new System.Drawing.Size(28, 17);
            this.lblBatchValue.TabIndex = 16;
            this.lblBatchValue.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "入库总量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "车牌号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "车牌号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(11, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 22);
            this.label13.TabIndex = 12;
            this.label13.Text = "入库进度：";
            // 
            // PbarBatch
            // 
            this.PbarBatch.Location = new System.Drawing.Point(117, 63);
            this.PbarBatch.Name = "PbarBatch";
            this.PbarBatch.Size = new System.Drawing.Size(207, 23);
            this.PbarBatch.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "准备入库：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
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
        private System.Windows.Forms.Label lblCurrentRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentRoute2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBatchValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar PbarBatch;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lbstate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;

    }
}