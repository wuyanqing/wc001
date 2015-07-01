namespace WSV.Search
{
    partial class Search_Info
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Search = new System.Windows.Forms.ToolStripButton();
            this.Btn_Print = new System.Windows.Forms.ToolStripButton();
            this.Btn_Export = new System.Windows.Forms.ToolStripButton();
            this.Btn_Updata = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.Btn_IsCheck = new System.Windows.Forms.ToolStripButton();
            this.Btn_UnCheck = new System.Windows.Forms.ToolStripButton();
            this.Btn_IsUsed = new System.Windows.Forms.ToolStripButton();
            this.Btn_UnUsed = new System.Windows.Forms.ToolStripButton();
            this.Btn_PrintMend = new System.Windows.Forms.ToolStripButton();
            this.Btn_Pic = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_DateType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_Explain = new System.Windows.Forms.Label();
            this.lab_ReportCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_EndTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_BeginTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_SearchInfo = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Verify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SearchInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Search,
            this.Btn_Print,
            this.Btn_Export,
            this.Btn_Updata,
            this.Btn_Fresh,
            this.Btn_Delete,
            this.Btn_IsCheck,
            this.Btn_UnCheck,
            this.Btn_IsUsed,
            this.Btn_UnUsed,
            this.Btn_PrintMend,
            this.Btn_Pic,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(919, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Search
            // 
            this.Btn_Search.AutoSize = false;
            this.Btn_Search.Image = global::WSV.Properties.Resources.Btn_Search;
            this.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 29);
            this.Btn_Search.Text = "查询";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.AutoSize = false;
            this.Btn_Print.Image = global::WSV.Properties.Resources.Btn_Print;
            this.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(58, 29);
            this.Btn_Print.Text = "打印";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Export
            // 
            this.Btn_Export.AutoSize = false;
            this.Btn_Export.Image = global::WSV.Properties.Resources.Btn_Export;
            this.Btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(58, 29);
            this.Btn_Export.Text = "导出";
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // Btn_Updata
            // 
            this.Btn_Updata.AutoSize = false;
            this.Btn_Updata.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_Updata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Updata.Name = "Btn_Updata";
            this.Btn_Updata.Size = new System.Drawing.Size(58, 29);
            this.Btn_Updata.Tag = "Edit";
            this.Btn_Updata.Text = "修改";
            this.Btn_Updata.Click += new System.EventHandler(this.Btn_Updata_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.AutoSize = false;
            this.Btn_Fresh.Image = global::WSV.Properties.Resources.Btn_Fresh;
            this.Btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(58, 29);
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AutoSize = false;
            this.Btn_Delete.Image = global::WSV.Properties.Resources.Btn_Delete;
            this.Btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(58, 29);
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_IsCheck
            // 
            this.Btn_IsCheck.AutoSize = false;
            this.Btn_IsCheck.Image = global::WSV.Properties.Resources.Btn_IsCheck;
            this.Btn_IsCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_IsCheck.Name = "Btn_IsCheck";
            this.Btn_IsCheck.Size = new System.Drawing.Size(58, 29);
            this.Btn_IsCheck.Tag = "Check";
            this.Btn_IsCheck.Text = "审核";
            this.Btn_IsCheck.Click += new System.EventHandler(this.Btn_IsCheck_Click);
            // 
            // Btn_UnCheck
            // 
            this.Btn_UnCheck.AutoSize = false;
            this.Btn_UnCheck.Image = global::WSV.Properties.Resources.Btn_Check;
            this.Btn_UnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_UnCheck.Name = "Btn_UnCheck";
            this.Btn_UnCheck.Size = new System.Drawing.Size(77, 29);
            this.Btn_UnCheck.Tag = "Check";
            this.Btn_UnCheck.Text = "反审核";
            this.Btn_UnCheck.Click += new System.EventHandler(this.Btn_UnCheck_Click);
            // 
            // Btn_IsUsed
            // 
            this.Btn_IsUsed.AutoSize = false;
            this.Btn_IsUsed.Image = global::WSV.Properties.Resources.Btn_IsUsed;
            this.Btn_IsUsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_IsUsed.Name = "Btn_IsUsed";
            this.Btn_IsUsed.Size = new System.Drawing.Size(58, 29);
            this.Btn_IsUsed.Tag = "Used";
            this.Btn_IsUsed.Text = "作废";
            this.Btn_IsUsed.Click += new System.EventHandler(this.Btn_IsUsed_Click);
            // 
            // Btn_UnUsed
            // 
            this.Btn_UnUsed.AutoSize = false;
            this.Btn_UnUsed.Image = global::WSV.Properties.Resources.Btn_Used;
            this.Btn_UnUsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_UnUsed.Name = "Btn_UnUsed";
            this.Btn_UnUsed.Size = new System.Drawing.Size(77, 29);
            this.Btn_UnUsed.Tag = "Used";
            this.Btn_UnUsed.Text = "反作废";
            this.Btn_UnUsed.Click += new System.EventHandler(this.Btn_UnUsed_Click);
            // 
            // Btn_PrintMend
            // 
            this.Btn_PrintMend.AutoSize = false;
            this.Btn_PrintMend.Image = global::WSV.Properties.Resources.Btn_PrintMend;
            this.Btn_PrintMend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_PrintMend.Name = "Btn_PrintMend";
            this.Btn_PrintMend.Size = new System.Drawing.Size(58, 29);
            this.Btn_PrintMend.Tag = "PrintMend";
            this.Btn_PrintMend.Text = "补打";
            this.Btn_PrintMend.Click += new System.EventHandler(this.Btn_PrintMend_Click);
            // 
            // Btn_Pic
            // 
            this.Btn_Pic.Image = global::WSV.Properties.Resources.Btn_Pic;
            this.Btn_Pic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Pic.Name = "Btn_Pic";
            this.Btn_Pic.Size = new System.Drawing.Size(89, 36);
            this.Btn_Pic.Text = "显示图片";
            this.Btn_Pic.Click += new System.EventHandler(this.Btn_Pic_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoSize = false;
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WSV.Properties.Resources.Top_Left;
            this.panel1.Controls.Add(this.lab_DateType);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 100);
            this.panel1.TabIndex = 2;
            // 
            // lab_DateType
            // 
            this.lab_DateType.BackColor = System.Drawing.Color.Transparent;
            this.lab_DateType.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_DateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_DateType.Location = new System.Drawing.Point(125, 21);
            this.lab_DateType.Name = "lab_DateType";
            this.lab_DateType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_DateType.Size = new System.Drawing.Size(557, 56);
            this.lab_DateType.TabIndex = 6;
            this.lab_DateType.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WSV.Properties.Resources.Top_Right;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(725, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 100);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lab_Explain);
            this.panel2.Controls.Add(this.lab_ReportCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lab_EndTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lab_BeginTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 37);
            this.panel2.TabIndex = 4;
            // 
            // lab_Explain
            // 
            this.lab_Explain.Location = new System.Drawing.Point(571, 13);
            this.lab_Explain.Name = "lab_Explain";
            this.lab_Explain.Size = new System.Drawing.Size(282, 16);
            this.lab_Explain.TabIndex = 6;
            this.lab_Explain.Text = "label1";
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
            // Dgv_SearchInfo
            // 
            this.Dgv_SearchInfo.AllowUserToAddRows = false;
            this.Dgv_SearchInfo.AllowUserToDeleteRows = false;
            this.Dgv_SearchInfo.AllowUserToOrderColumns = true;
            this.Dgv_SearchInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SearchInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_SearchInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SearchInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_State,
            this.Col_Used,
            this.Col_Verify});
            this.Dgv_SearchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_SearchInfo.EnterNextRow = true;
            this.Dgv_SearchInfo.Location = new System.Drawing.Point(0, 139);
            this.Dgv_SearchInfo.Name = "Dgv_SearchInfo";
            this.Dgv_SearchInfo.ReadOnly = true;
            this.Dgv_SearchInfo.RowCode = true;
            this.Dgv_SearchInfo.RowTemplate.Height = 23;
            this.Dgv_SearchInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_SearchInfo.Size = new System.Drawing.Size(919, 340);
            this.Dgv_SearchInfo.TabIndex = 1;
            this.Dgv_SearchInfo.Total = false;
            this.Dgv_SearchInfo.TotalText = "";
            this.Dgv_SearchInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_SearchInfo_MouseDown);
            this.Dgv_SearchInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_SearchInfo_CellClick);
            this.Dgv_SearchInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_SearchInfo_CellDoubleClick);
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Visible = false;
            // 
            // Col_State
            // 
            this.Col_State.DataPropertyName = "State";
            this.Col_State.HeaderText = "是否正式数据";
            this.Col_State.Name = "Col_State";
            this.Col_State.ReadOnly = true;
            this.Col_State.Visible = false;
            // 
            // Col_Used
            // 
            this.Col_Used.DataPropertyName = "Used";
            this.Col_Used.HeaderText = "是否作废";
            this.Col_Used.Name = "Col_Used";
            this.Col_Used.ReadOnly = true;
            this.Col_Used.Visible = false;
            // 
            // Col_Verify
            // 
            this.Col_Verify.DataPropertyName = "Verify";
            this.Col_Verify.HeaderText = "是否审核";
            this.Col_Verify.Name = "Col_Verify";
            this.Col_Verify.ReadOnly = true;
            this.Col_Verify.Visible = false;
            // 
            // Search_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 516);
            this.Controls.Add(this.Dgv_SearchInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Search_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_Info_FormClosed);
            this.Resize += new System.EventHandler(this.Search_Info_Resize);
            this.Shown += new System.EventHandler(this.Search_Info_Shown);
            this.Load += new System.EventHandler(this.Search_Info_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SearchInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Print;
        private System.Windows.Forms.ToolStripButton Btn_Updata;
        private System.Windows.Forms.ToolStripButton Btn_Delete;
        private System.Windows.Forms.ToolStripButton Btn_IsCheck;
        private System.Windows.Forms.ToolStripButton Btn_IsUsed;
        private System.Windows.Forms.ToolStripButton Btn_PrintMend;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.DataGridView.MyDataGridView Dgv_SearchInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_DateType;
        private System.Windows.Forms.ToolStripButton Btn_UnCheck;
        private System.Windows.Forms.ToolStripButton Btn_UnUsed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_ReportCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_EndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_BeginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton Btn_Search;
        private System.Windows.Forms.Label lab_Explain;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Export;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton Btn_Pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Verify;
    }
}