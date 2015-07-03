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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ForeShow = new System.Windows.Forms.ToolStripMenuItem();
            this.BackShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBatchCompleteCount = new System.Windows.Forms.Label();
            this.lblCurrentRoute = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBatchValue2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTxt = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblBatchValue2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 510);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(514, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 407);
            this.panel5.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(8, 214);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(490, 180);
            this.panel7.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(4, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(340, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "车牌号1005：等待时间约2小时";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(4, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(355, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "车牌号1002：等待时间约30分钟";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(160, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(150, 15, 3, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 27);
            this.label18.TabIndex = 41;
            this.label18.Text = "排队车牌号";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17073F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82927F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 178);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "排队车辆总数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前入库卷烟名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "当前入库车牌号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "预计完成时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(96, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "二号链板机入库情况";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 407);
            this.panel4.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(3, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 180);
            this.panel6.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(4, 127);
            this.label16.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(340, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "车牌号1004：等待时间约3小时";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(4, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "车牌号1003：等待时间约2小时";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(4, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(355, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "车牌号1001：等待时间约30分钟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(160, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(150, 15, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "排队车牌号";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.48665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.51335F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBatchCompleteCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentRoute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 178);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "排队车辆总数";
            // 
            // lblBatchCompleteCount
            // 
            this.lblBatchCompleteCount.AutoSize = true;
            this.lblBatchCompleteCount.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lblBatchCompleteCount.ForeColor = System.Drawing.Color.Black;
            this.lblBatchCompleteCount.Location = new System.Drawing.Point(13, 46);
            this.lblBatchCompleteCount.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblBatchCompleteCount.Name = "lblBatchCompleteCount";
            this.lblBatchCompleteCount.Size = new System.Drawing.Size(187, 27);
            this.lblBatchCompleteCount.TabIndex = 4;
            this.lblBatchCompleteCount.Text = "当前入库车牌号";
            // 
            // lblCurrentRoute
            // 
            this.lblCurrentRoute.AutoSize = true;
            this.lblCurrentRoute.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentRoute.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentRoute.Location = new System.Drawing.Point(13, 8);
            this.lblCurrentRoute.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lblCurrentRoute.Name = "lblCurrentRoute";
            this.lblCurrentRoute.Size = new System.Drawing.Size(212, 25);
            this.lblCurrentRoute.TabIndex = 1;
            this.lblCurrentRoute.Text = "当前入库卷烟名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "预计完成时间";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(94, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 30);
            this.label11.TabIndex = 38;
            this.label11.Text = "一号链板机入库情况";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 48);
            this.panel3.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(402, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "调度作业进行中";
            // 
            // lblBatchValue2
            // 
            this.lblBatchValue2.AutoSize = true;
            this.lblBatchValue2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.lblBatchValue2.ForeColor = System.Drawing.Color.Red;
            this.lblBatchValue2.Location = new System.Drawing.Point(1122, 140);
            this.lblBatchValue2.Name = "lblBatchValue2";
            this.lblBatchValue2.Size = new System.Drawing.Size(0, 24);
            this.lblBatchValue2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblTimeTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 90);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(321, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "永州入库车辆调度系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTime.Location = new System.Drawing.Point(3, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(137, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "北京时间：";
            // 
            // lblTimeTxt
            // 
            this.lblTimeTxt.AutoSize = true;
            this.lblTimeTxt.Font = new System.Drawing.Font("宋体", 18F);
            this.lblTimeTxt.ForeColor = System.Drawing.Color.White;
            this.lblTimeTxt.Location = new System.Drawing.Point(136, 58);
            this.lblTimeTxt.Name = "lblTimeTxt";
            this.lblTimeTxt.Size = new System.Drawing.Size(0, 24);
            this.lblTimeTxt.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(9, 417);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1004, 42);
            this.panel8.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(-1, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(525, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "送货单排队序列:1006     1007    1008    1009";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(351, 148);
            this.Name = "OrderList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenScreen;
        private System.Windows.Forms.ToolStripMenuItem CloseScreen;
        private System.Windows.Forms.ToolStripMenuItem BackShow;
        private System.Windows.Forms.ToolStripMenuItem ExitScreen;
        private System.Windows.Forms.ToolStripMenuItem ForeShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBatchValue2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBatchCompleteCount;
        private System.Windows.Forms.Label lblCurrentRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimeTxt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;

    }
}