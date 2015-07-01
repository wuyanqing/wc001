namespace WSV.MyLog
{
    partial class MyOper
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
            this.Btn_Export = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_UsedName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_WorkWise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dt_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_TimeBegin = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.gv = new WSV.Control.DataGridView.MyDataGridView();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_WorkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_G_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_T_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_G_Oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_T_Oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Search,
            this.Btn_Export,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(636, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::WSV.Properties.Resources.Btn_Search;
            this.Btn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 29);
            this.Btn_Search.Text = "查询";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Export
            // 
            this.Btn_Export.Image = global::WSV.Properties.Resources.Btn_Export;
            this.Btn_Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(58, 29);
            this.Btn_Export.Text = "导出";
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.Image = global::WSV.Properties.Resources.Btn_Fresh;
            this.Btn_Fresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(58, 29);
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cmb_UsedName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cmb_WorkWise);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Dt_TimeEnd);
            this.groupBox1.Controls.Add(this.Dt_DateEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dt_TimeBegin);
            this.groupBox1.Controls.Add(this.Dt_DateBegin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "操作人员:";
            // 
            // Cmb_UsedName
            // 
            this.Cmb_UsedName.FormattingEnabled = true;
            this.Cmb_UsedName.Location = new System.Drawing.Point(456, 67);
            this.Cmb_UsedName.Name = "Cmb_UsedName";
            this.Cmb_UsedName.Size = new System.Drawing.Size(87, 20);
            this.Cmb_UsedName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "操作方式:";
            // 
            // Cmb_WorkWise
            // 
            this.Cmb_WorkWise.FormattingEnabled = true;
            this.Cmb_WorkWise.Location = new System.Drawing.Point(456, 26);
            this.Cmb_WorkWise.Name = "Cmb_WorkWise";
            this.Cmb_WorkWise.Size = new System.Drawing.Size(87, 20);
            this.Cmb_WorkWise.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "结束时间:";
            // 
            // Dt_TimeEnd
            // 
            this.Dt_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeEnd.Location = new System.Drawing.Point(249, 66);
            this.Dt_TimeEnd.Name = "Dt_TimeEnd";
            this.Dt_TimeEnd.ShowUpDown = true;
            this.Dt_TimeEnd.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeEnd.TabIndex = 27;
            // 
            // Dt_DateEnd
            // 
            this.Dt_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateEnd.Location = new System.Drawing.Point(158, 66);
            this.Dt_DateEnd.Name = "Dt_DateEnd";
            this.Dt_DateEnd.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateEnd.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "开始时间:";
            // 
            // Dt_TimeBegin
            // 
            this.Dt_TimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeBegin.Location = new System.Drawing.Point(248, 25);
            this.Dt_TimeBegin.Name = "Dt_TimeBegin";
            this.Dt_TimeBegin.ShowUpDown = true;
            this.Dt_TimeBegin.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeBegin.TabIndex = 24;
            // 
            // Dt_DateBegin
            // 
            this.Dt_DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateBegin.Location = new System.Drawing.Point(157, 25);
            this.Dt_DateBegin.Name = "Dt_DateBegin";
            this.Dt_DateBegin.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateBegin.TabIndex = 23;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkName,
            this.UserName,
            this.DT,
            this.ID,
            this.Code,
            this.CarCode,
            this.Col_WorkCode,
            this.Col_Name,
            this.Col_G_Table,
            this.Col_T_Table,
            this.Col_G_Oper,
            this.Col_T_Oper});
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.EnterNextRow = true;
            this.gv.Location = new System.Drawing.Point(0, 144);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowCode = true;
            this.gv.RowTemplate.Height = 23;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(636, 304);
            this.gv.TabIndex = 2;
            this.gv.Total = false;
            this.gv.TotalText = "";
            // 
            // WorkName
            // 
            this.WorkName.DataPropertyName = "WorkName";
            this.WorkName.HeaderText = "操作方式";
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "操作人员";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.DataPropertyName = "DT";
            this.DT.HeaderText = "维护时间";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // CarCode
            // 
            this.CarCode.DataPropertyName = "CarCode";
            this.CarCode.HeaderText = "车号";
            this.CarCode.Name = "CarCode";
            this.CarCode.ReadOnly = true;
            // 
            // Col_WorkCode
            // 
            this.Col_WorkCode.DataPropertyName = "WorkCode";
            this.Col_WorkCode.HeaderText = "操作编号";
            this.Col_WorkCode.Name = "Col_WorkCode";
            this.Col_WorkCode.ReadOnly = true;
            this.Col_WorkCode.Visible = false;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "操作台号";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_G_Table
            // 
            this.Col_G_Table.DataPropertyName = "G_Table";
            this.Col_G_Table.HeaderText = "毛台号";
            this.Col_G_Table.Name = "Col_G_Table";
            this.Col_G_Table.ReadOnly = true;
            // 
            // Col_T_Table
            // 
            this.Col_T_Table.DataPropertyName = "T_Table";
            this.Col_T_Table.HeaderText = "皮台号";
            this.Col_T_Table.Name = "Col_T_Table";
            this.Col_T_Table.ReadOnly = true;
            // 
            // Col_G_Oper
            // 
            this.Col_G_Oper.DataPropertyName = "G_Oper";
            this.Col_G_Oper.HeaderText = "毛司磅员";
            this.Col_G_Oper.Name = "Col_G_Oper";
            this.Col_G_Oper.ReadOnly = true;
            // 
            // Col_T_Oper
            // 
            this.Col_T_Oper.DataPropertyName = "T_Oper";
            this.Col_T_Oper.HeaderText = "皮司磅员";
            this.Col_T_Oper.Name = "Col_T_Oper";
            this.Col_T_Oper.ReadOnly = true;
            // 
            // MyOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 448);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MyOper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维护日志";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyOper_FormClosed);
            this.Load += new System.EventHandler(this.MyOper_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.DataGridView.MyDataGridView gv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Search;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_WorkWise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dt_TimeEnd;
        private System.Windows.Forms.DateTimePicker Dt_DateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dt_TimeBegin;
        private System.Windows.Forms.DateTimePicker Dt_DateBegin;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_UsedName;
        private System.Windows.Forms.ToolStripButton Btn_Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WorkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_G_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_T_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_G_Oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_T_Oper;
    }
}