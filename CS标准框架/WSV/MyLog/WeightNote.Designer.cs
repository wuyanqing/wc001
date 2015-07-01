namespace WSV.MyLog
{
    partial class WeightNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Search = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Dgv = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TableCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_UsedName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dt_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_TimeBegin = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::WSV.Properties.Resources.Btn_Search;
            this.Btn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 36);
            this.Btn_Search.Text = "查询";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 36);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Search,
            this.Btn_Export,
            this.toolStripButton1,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(640, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Export
            // 
            this.Btn_Export.Image = global::WSV.Properties.Resources.Btn_Export;
            this.Btn_Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(58, 36);
            this.Btn_Export.Text = "导出";
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WSV.Properties.Resources.Btn_Pic;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton1.Text = "显示图片";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.Image = global::WSV.Properties.Resources.Btn_Fresh;
            this.Btn_Fresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(58, 36);
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Code,
            this.Col_Name,
            this.Col_Weight,
            this.Col_TableCode,
            this.Col_IP,
            this.Col_Datetime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.EnterNextRow = true;
            this.Dgv.Location = new System.Drawing.Point(0, 145);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowCode = true;
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(640, 305);
            this.Dgv.TabIndex = 5;
            this.Dgv.Total = false;
            this.Dgv.TotalText = "";
            this.Dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Visible = false;
            // 
            // Col_Code
            // 
            this.Col_Code.DataPropertyName = "Code";
            this.Col_Code.HeaderText = "编号";
            this.Col_Code.Name = "Col_Code";
            this.Col_Code.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "操作人员";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_Weight
            // 
            this.Col_Weight.DataPropertyName = "Weight";
            this.Col_Weight.HeaderText = "重量";
            this.Col_Weight.Name = "Col_Weight";
            this.Col_Weight.ReadOnly = true;
            // 
            // Col_TableCode
            // 
            this.Col_TableCode.DataPropertyName = "TableCode";
            this.Col_TableCode.HeaderText = "台号编号";
            this.Col_TableCode.Name = "Col_TableCode";
            this.Col_TableCode.ReadOnly = true;
            // 
            // Col_IP
            // 
            this.Col_IP.DataPropertyName = "IP";
            this.Col_IP.HeaderText = "IP";
            this.Col_IP.Name = "Col_IP";
            this.Col_IP.ReadOnly = true;
            // 
            // Col_Datetime
            // 
            this.Col_Datetime.DataPropertyName = "Datetime";
            this.Col_Datetime.HeaderText = "过磅时间";
            this.Col_Datetime.Name = "Col_Datetime";
            this.Col_Datetime.ReadOnly = true;
            this.Col_Datetime.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cmb_UsedName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Dt_TimeEnd);
            this.groupBox1.Controls.Add(this.Dt_DateEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dt_TimeBegin);
            this.groupBox1.Controls.Add(this.Dt_DateBegin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "操作人员:";
            // 
            // Cmb_UsedName
            // 
            this.Cmb_UsedName.FormattingEnabled = true;
            this.Cmb_UsedName.Location = new System.Drawing.Point(438, 25);
            this.Cmb_UsedName.Name = "Cmb_UsedName";
            this.Cmb_UsedName.Size = new System.Drawing.Size(87, 20);
            this.Cmb_UsedName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "结束时间:";
            // 
            // Dt_TimeEnd
            // 
            this.Dt_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeEnd.Location = new System.Drawing.Point(287, 65);
            this.Dt_TimeEnd.Name = "Dt_TimeEnd";
            this.Dt_TimeEnd.ShowUpDown = true;
            this.Dt_TimeEnd.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeEnd.TabIndex = 37;
            // 
            // Dt_DateEnd
            // 
            this.Dt_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateEnd.Location = new System.Drawing.Point(196, 65);
            this.Dt_DateEnd.Name = "Dt_DateEnd";
            this.Dt_DateEnd.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateEnd.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "开始时间:";
            // 
            // Dt_TimeBegin
            // 
            this.Dt_TimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeBegin.Location = new System.Drawing.Point(287, 24);
            this.Dt_TimeBegin.Name = "Dt_TimeBegin";
            this.Dt_TimeBegin.ShowUpDown = true;
            this.Dt_TimeBegin.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeBegin.TabIndex = 34;
            // 
            // Dt_DateBegin
            // 
            this.Dt_DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateBegin.Location = new System.Drawing.Point(196, 24);
            this.Dt_DateBegin.Name = "Dt_DateBegin";
            this.Dt_DateBegin.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateBegin.TabIndex = 33;
            // 
            // WeightNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WeightNote";
            this.Text = " 过磅日志";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeightNote_FormClosed);
            this.Load += new System.EventHandler(this.WeightNote_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Btn_Search;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private WSV.Control.DataGridView.MyDataGridView Dgv;
        private System.Windows.Forms.ToolStripButton Btn_Export;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_UsedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dt_TimeEnd;
        private System.Windows.Forms.DateTimePicker Dt_DateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dt_TimeBegin;
        private System.Windows.Forms.DateTimePicker Dt_DateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TableCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Datetime;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}