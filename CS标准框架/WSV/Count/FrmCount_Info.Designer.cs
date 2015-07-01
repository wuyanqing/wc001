namespace WSV.Count
{
    partial class FrmCount_Info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCount_Info));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Count = new System.Windows.Forms.ToolStripButton();
            this.Btn_Print = new System.Windows.Forms.ToolStripButton();
            this.Btn_ToExecel = new System.Windows.Forms.ToolStripButton();
            this.Btn_VCount = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Dgv_CountInfo = new WSV.Control.DataGridView.MyDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_ReportCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_EndTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_BeginTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_RepotType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_ReportName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CountInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Count,
            this.Btn_Print,
            this.Btn_ToExecel,
            this.Btn_VCount,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Count
            // 
            this.Btn_Count.Image = global::WSV.Properties.Resources.Btn_Preview;
            this.Btn_Count.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(82, 29);
            this.Btn_Count.Text = "汇总条件";
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Count_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Image = global::WSV.Properties.Resources.Btn_Print;
            this.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(58, 29);
            this.Btn_Print.Text = "打印";
            this.Btn_Print.ToolTipText = "打印";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_ToExecel
            // 
            this.Btn_ToExecel.Image = global::WSV.Properties.Resources.Btn_Export;
            this.Btn_ToExecel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_ToExecel.Name = "Btn_ToExecel";
            this.Btn_ToExecel.Size = new System.Drawing.Size(58, 29);
            this.Btn_ToExecel.Text = "导出";
            this.Btn_ToExecel.Click += new System.EventHandler(this.Btn_ToExecel_Click);
            // 
            // Btn_VCount
            // 
            this.Btn_VCount.Image = global::WSV.Properties.Resources.Btn_VCount;
            this.Btn_VCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_VCount.Name = "Btn_VCount";
            this.Btn_VCount.Size = new System.Drawing.Size(82, 29);
            this.Btn_VCount.Text = "图形报表";
            this.Btn_VCount.Click += new System.EventHandler(this.Btn_VCount_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.ToolTipText = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Dgv_CountInfo
            // 
            this.Dgv_CountInfo.AllowUserToAddRows = false;
            this.Dgv_CountInfo.AllowUserToDeleteRows = false;
            this.Dgv_CountInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_CountInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_CountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_CountInfo.EnterNextRow = true;
            this.Dgv_CountInfo.Location = new System.Drawing.Point(0, 132);
            this.Dgv_CountInfo.Name = "Dgv_CountInfo";
            this.Dgv_CountInfo.ReadOnly = true;
            this.Dgv_CountInfo.RowCode = true;
            this.Dgv_CountInfo.RowTemplate.Height = 23;
            this.Dgv_CountInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_CountInfo.Size = new System.Drawing.Size(916, 347);
            this.Dgv_CountInfo.TabIndex = 2;
            this.Dgv_CountInfo.Total = false;
            this.Dgv_CountInfo.TotalText = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lab_ReportCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab_EndTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lab_BeginTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 37);
            this.panel1.TabIndex = 3;
            // 
            // lab_ReportCount
            // 
            this.lab_ReportCount.AutoSize = true;
            this.lab_ReportCount.Location = new System.Drawing.Point(497, 14);
            this.lab_ReportCount.Name = "lab_ReportCount";
            this.lab_ReportCount.Size = new System.Drawing.Size(41, 12);
            this.lab_ReportCount.TabIndex = 5;
            this.lab_ReportCount.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "记录数：";
            // 
            // lab_EndTime
            // 
            this.lab_EndTime.AutoSize = true;
            this.lab_EndTime.Location = new System.Drawing.Point(299, 14);
            this.lab_EndTime.Name = "lab_EndTime";
            this.lab_EndTime.Size = new System.Drawing.Size(41, 12);
            this.lab_EndTime.TabIndex = 3;
            this.lab_EndTime.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "截止日期：";
            // 
            // lab_BeginTime
            // 
            this.lab_BeginTime.AutoSize = true;
            this.lab_BeginTime.Location = new System.Drawing.Point(75, 14);
            this.lab_BeginTime.Name = "lab_BeginTime";
            this.lab_BeginTime.Size = new System.Drawing.Size(41, 12);
            this.lab_BeginTime.TabIndex = 1;
            this.lab_BeginTime.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "开始日期：";
            // 
            // lab_RepotType
            // 
            this.lab_RepotType.BackColor = System.Drawing.Color.Transparent;
            this.lab_RepotType.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_RepotType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_RepotType.Location = new System.Drawing.Point(11, 11);
            this.lab_RepotType.Name = "lab_RepotType";
            this.lab_RepotType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_RepotType.Size = new System.Drawing.Size(170, 51);
            this.lab_RepotType.TabIndex = 5;
            this.lab_RepotType.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WSV.Properties.Resources.Top_Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 100);
            this.panel2.TabIndex = 6;
            // 
            // lab_ReportName
            // 
            this.lab_ReportName.BackColor = System.Drawing.Color.Transparent;
            this.lab_ReportName.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ReportName.Location = new System.Drawing.Point(118, 11);
            this.lab_ReportName.Name = "lab_ReportName";
            this.lab_ReportName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_ReportName.Size = new System.Drawing.Size(170, 51);
            this.lab_ReportName.TabIndex = 6;
            this.lab_ReportName.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WSV.Properties.Resources.Top_Left;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(916, 100);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lab_ReportName);
            this.panel5.Controls.Add(this.lab_RepotType);
            this.panel5.Location = new System.Drawing.Point(284, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 77);
            this.panel5.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WSV.Properties.Resources.Top_Right;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(720, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 100);
            this.panel3.TabIndex = 8;
            // 
            // FrmCount_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 516);
            this.Controls.Add(this.Dgv_CountInfo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCount_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据汇总";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCount_Info_FormClosed);
            this.Resize += new System.EventHandler(this.FrmCount_Info_Resize);
            this.Load += new System.EventHandler(this.FrmCount_Info_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CountInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Print;
        private System.Windows.Forms.ToolStripButton Btn_ToExecel;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.DataGridView.MyDataGridView Dgv_CountInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_EndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_BeginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_ReportCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_RepotType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_ReportName;
        private System.Windows.Forms.ToolStripButton Btn_Count;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripButton Btn_VCount;

    }
}