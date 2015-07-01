namespace WSV
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Strip_FrmMain = new System.Windows.Forms.Panel();
            this.lab_TableName = new System.Windows.Forms.Label();
            this.lab_Client = new System.Windows.Forms.Label();
            this.lab_SoftWare = new System.Windows.Forms.Label();
            this.lab_Version = new System.Windows.Forms.Label();
            this.lab_Operator = new System.Windows.Forms.Label();
            this.lab_Time = new System.Windows.Forms.Label();
            this.t_Time = new System.Windows.Forms.Timer(this.components);
            this.Menu_FrmMain = new System.Windows.Forms.MenuStrip();
            this.Menu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_FrmMain.SuspendLayout();
            this.Menu_FrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Strip_FrmMain
            // 
            this.Strip_FrmMain.Controls.Add(this.lab_TableName);
            this.Strip_FrmMain.Controls.Add(this.lab_Client);
            this.Strip_FrmMain.Controls.Add(this.lab_SoftWare);
            this.Strip_FrmMain.Controls.Add(this.lab_Version);
            this.Strip_FrmMain.Controls.Add(this.lab_Operator);
            this.Strip_FrmMain.Controls.Add(this.lab_Time);
            this.Strip_FrmMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Strip_FrmMain.Location = new System.Drawing.Point(0, 386);
            this.Strip_FrmMain.Name = "Strip_FrmMain";
            this.Strip_FrmMain.Size = new System.Drawing.Size(823, 22);
            this.Strip_FrmMain.TabIndex = 5;
            // 
            // lab_TableName
            // 
            this.lab_TableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_TableName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lab_TableName.Location = new System.Drawing.Point(553, 0);
            this.lab_TableName.Name = "lab_TableName";
            this.lab_TableName.Size = new System.Drawing.Size(72, 22);
            this.lab_TableName.TabIndex = 5;
            this.lab_TableName.Text = "系统员";
            this.lab_TableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Client
            // 
            this.lab_Client.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Client.Location = new System.Drawing.Point(347, 0);
            this.lab_Client.Name = "lab_Client";
            this.lab_Client.Size = new System.Drawing.Size(278, 22);
            this.lab_Client.TabIndex = 1;
            this.lab_Client.Text = "某某有限公司";
            this.lab_Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_SoftWare
            // 
            this.lab_SoftWare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_SoftWare.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_SoftWare.Location = new System.Drawing.Point(77, 0);
            this.lab_SoftWare.Name = "lab_SoftWare";
            this.lab_SoftWare.Size = new System.Drawing.Size(270, 22);
            this.lab_SoftWare.TabIndex = 0;
            this.lab_SoftWare.Text = "郑州五诚科技有限公司 0371-86566575";
            this.lab_SoftWare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Version
            // 
            this.lab_Version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Version.Dock = System.Windows.Forms.DockStyle.Left;
            this.lab_Version.Location = new System.Drawing.Point(0, 0);
            this.lab_Version.Name = "lab_Version";
            this.lab_Version.Size = new System.Drawing.Size(77, 22);
            this.lab_Version.TabIndex = 4;
            this.lab_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Operator
            // 
            this.lab_Operator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Operator.Dock = System.Windows.Forms.DockStyle.Right;
            this.lab_Operator.Location = new System.Drawing.Point(625, 0);
            this.lab_Operator.Name = "lab_Operator";
            this.lab_Operator.Size = new System.Drawing.Size(72, 22);
            this.lab_Operator.TabIndex = 2;
            this.lab_Operator.Text = "管理员";
            this.lab_Operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Time
            // 
            this.lab_Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lab_Time.Location = new System.Drawing.Point(697, 0);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(126, 22);
            this.lab_Time.TabIndex = 3;
            this.lab_Time.Text = "2020-01-12 13:48:50";
            this.lab_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_Time
            // 
            this.t_Time.Enabled = true;
            this.t_Time.Interval = 500;
            this.t_Time.Tick += new System.EventHandler(this.t_Time_Tick);
            // 
            // Menu_FrmMain
            // 
            this.Menu_FrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_System});
            this.Menu_FrmMain.Location = new System.Drawing.Point(0, 0);
            this.Menu_FrmMain.Name = "Menu_FrmMain";
            this.Menu_FrmMain.Size = new System.Drawing.Size(823, 24);
            this.Menu_FrmMain.TabIndex = 7;
            this.Menu_FrmMain.Text = "menuStrip1";
            // 
            // Menu_System
            // 
            this.Menu_System.Name = "Menu_System";
            this.Menu_System.Size = new System.Drawing.Size(89, 20);
            this.Menu_System.Text = "设备信息管理系统";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 408);
            this.Controls.Add(this.Strip_FrmMain);
            this.Controls.Add(this.Menu_FrmMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu_FrmMain;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备信息管理系统1.1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Strip_FrmMain.ResumeLayout(false);
            this.Menu_FrmMain.ResumeLayout(false);
            this.Menu_FrmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Strip_FrmMain;
        private System.Windows.Forms.Label lab_Client;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Timer t_Time;
        private System.Windows.Forms.Label lab_SoftWare;
        private System.Windows.Forms.MenuStrip Menu_FrmMain;
        private System.Windows.Forms.ToolStripMenuItem Menu_System;
        public System.Windows.Forms.Label lab_Operator;
        public System.Windows.Forms.Label lab_Version;
        public System.Windows.Forms.Label lab_TableName;
    }
}