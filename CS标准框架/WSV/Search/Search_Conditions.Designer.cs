namespace WSV.Search
{
    partial class Search_Conditions
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
            this.Dgv_Condition = new System.Windows.Forms.DataGridView();
            this.Col_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_Comparison = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Logic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.Rbt_TempDate = new System.Windows.Forms.RadioButton();
            this.Rbt_Date = new System.Windows.Forms.RadioButton();
            this.Cmb_Check = new WSV.Control.MyComboBox.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Used = new WSV.Control.MyComboBox.MyComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Type = new WSV.Control.MyComboBox.MyComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dt_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.Dt_TimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Dt_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Down = new System.Windows.Forms.Button();
            this.Btn_Up = new System.Windows.Forms.Button();
            this.Dgv_SetInfo = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Show = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Condition)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SetInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Condition
            // 
            this.Dgv_Condition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Condition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name,
            this.Col_Comparison,
            this.Col_Value,
            this.Col_Logic});
            this.Dgv_Condition.Location = new System.Drawing.Point(3, 94);
            this.Dgv_Condition.Name = "Dgv_Condition";
            this.Dgv_Condition.RowHeadersWidth = 20;
            this.Dgv_Condition.RowTemplate.Height = 23;
            this.Dgv_Condition.Size = new System.Drawing.Size(426, 203);
            this.Dgv_Condition.TabIndex = 0;
            this.Dgv_Condition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Condition_CellDoubleClick);
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_Comparison
            // 
            this.Col_Comparison.HeaderText = "比较关系";
            this.Col_Comparison.Name = "Col_Comparison";
            this.Col_Comparison.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Comparison.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Col_Value
            // 
            this.Col_Value.HeaderText = "数值";
            this.Col_Value.Name = "Col_Value";
            // 
            // Col_Logic
            // 
            this.Col_Logic.HeaderText = "逻辑";
            this.Col_Logic.Name = "Col_Logic";
            this.Col_Logic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Logic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Cancel);
            this.groupBox1.Controls.Add(this.Btn_Enter);
            this.groupBox1.Controls.Add(this.Rbt_TempDate);
            this.groupBox1.Controls.Add(this.Rbt_Date);
            this.groupBox1.Controls.Add(this.Cmb_Check);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cmb_Used);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Type);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(125, 216);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(69, 39);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Location = new System.Drawing.Point(42, 216);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(69, 39);
            this.Btn_Enter.TabIndex = 8;
            this.Btn_Enter.Text = "确定";
            this.Btn_Enter.UseVisualStyleBackColor = true;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // Rbt_TempDate
            // 
            this.Rbt_TempDate.AutoSize = true;
            this.Rbt_TempDate.Location = new System.Drawing.Point(125, 59);
            this.Rbt_TempDate.Name = "Rbt_TempDate";
            this.Rbt_TempDate.Size = new System.Drawing.Size(71, 16);
            this.Rbt_TempDate.TabIndex = 7;
            this.Rbt_TempDate.Text = "临时数据";
            this.Rbt_TempDate.UseVisualStyleBackColor = true;
            // 
            // Rbt_Date
            // 
            this.Rbt_Date.AutoSize = true;
            this.Rbt_Date.Checked = true;
            this.Rbt_Date.Location = new System.Drawing.Point(38, 59);
            this.Rbt_Date.Name = "Rbt_Date";
            this.Rbt_Date.Size = new System.Drawing.Size(71, 16);
            this.Rbt_Date.TabIndex = 6;
            this.Rbt_Date.TabStop = true;
            this.Rbt_Date.Text = "正式数据";
            this.Rbt_Date.UseVisualStyleBackColor = true;
            // 
            // Cmb_Check
            // 
            this.Cmb_Check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Check.FormattingEnabled = true;
            this.Cmb_Check.Location = new System.Drawing.Point(95, 170);
            this.Cmb_Check.Name = "Cmb_Check";
            this.Cmb_Check.Size = new System.Drawing.Size(99, 24);
            this.Cmb_Check.TabIndex = 5;
            this.Cmb_Check.text = null;
            this.Cmb_Check.value = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "审核状态";
            // 
            // Cmb_Used
            // 
            this.Cmb_Used.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Used.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Used.FormattingEnabled = true;
            this.Cmb_Used.Location = new System.Drawing.Point(95, 136);
            this.Cmb_Used.Name = "Cmb_Used";
            this.Cmb_Used.Size = new System.Drawing.Size(99, 24);
            this.Cmb_Used.TabIndex = 3;
            this.Cmb_Used.text = null;
            this.Cmb_Used.value = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据类型";
            // 
            // Cmb_Type
            // 
            this.Cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Cmb_Type.FormattingEnabled = true;
            this.Cmb_Type.Location = new System.Drawing.Point(95, 98);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Size = new System.Drawing.Size(99, 24);
            this.Cmb_Type.TabIndex = 0;
            this.Cmb_Type.text = null;
            this.Cmb_Type.value = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(248, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 328);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dt_TimeEnd);
            this.tabPage1.Controls.Add(this.Dt_TimeBegin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Dt_DateEnd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Dt_DateBegin);
            this.tabPage1.Controls.Add(this.Dgv_Condition);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "条件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dt_TimeEnd
            // 
            this.Dt_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeEnd.Location = new System.Drawing.Point(252, 55);
            this.Dt_TimeEnd.Name = "Dt_TimeEnd";
            this.Dt_TimeEnd.ShowUpDown = true;
            this.Dt_TimeEnd.Size = new System.Drawing.Size(77, 21);
            this.Dt_TimeEnd.TabIndex = 6;
            // 
            // Dt_TimeBegin
            // 
            this.Dt_TimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeBegin.Location = new System.Drawing.Point(252, 16);
            this.Dt_TimeBegin.Name = "Dt_TimeBegin";
            this.Dt_TimeBegin.ShowUpDown = true;
            this.Dt_TimeBegin.Size = new System.Drawing.Size(77, 21);
            this.Dt_TimeBegin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "结束时间：";
            // 
            // Dt_DateEnd
            // 
            this.Dt_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_DateEnd.Location = new System.Drawing.Point(153, 55);
            this.Dt_DateEnd.Name = "Dt_DateEnd";
            this.Dt_DateEnd.Size = new System.Drawing.Size(93, 21);
            this.Dt_DateEnd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "开始时间：";
            // 
            // Dt_DateBegin
            // 
            this.Dt_DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_DateBegin.Location = new System.Drawing.Point(153, 16);
            this.Dt_DateBegin.Name = "Dt_DateBegin";
            this.Dt_DateBegin.Size = new System.Drawing.Size(93, 21);
            this.Dt_DateBegin.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Save);
            this.tabPage2.Controls.Add(this.Btn_Down);
            this.tabPage2.Controls.Add(this.Btn_Up);
            this.tabPage2.Controls.Add(this.Dgv_SetInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(333, 201);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(62, 29);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "保存设置";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Down
            // 
            this.Btn_Down.Location = new System.Drawing.Point(331, 145);
            this.Btn_Down.Name = "Btn_Down";
            this.Btn_Down.Size = new System.Drawing.Size(64, 29);
            this.Btn_Down.TabIndex = 2;
            this.Btn_Down.Text = "下移";
            this.Btn_Down.UseVisualStyleBackColor = true;
            this.Btn_Down.Click += new System.EventHandler(this.Btn_Down_Click);
            // 
            // Btn_Up
            // 
            this.Btn_Up.Location = new System.Drawing.Point(331, 90);
            this.Btn_Up.Name = "Btn_Up";
            this.Btn_Up.Size = new System.Drawing.Size(64, 29);
            this.Btn_Up.TabIndex = 1;
            this.Btn_Up.Text = "上移";
            this.Btn_Up.UseVisualStyleBackColor = true;
            this.Btn_Up.Click += new System.EventHandler(this.Btn_Up_Click);
            // 
            // Dgv_SetInfo
            // 
            this.Dgv_SetInfo.AllowUserToAddRows = false;
            this.Dgv_SetInfo.AllowUserToDeleteRows = false;
            this.Dgv_SetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SetInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Col_ID,
            this.Col_Place,
            this.Col_Show,
            this.Col_As,
            this.Col_DBName,
            this.Col_Print});
            this.Dgv_SetInfo.Location = new System.Drawing.Point(6, 6);
            this.Dgv_SetInfo.MultiSelect = false;
            this.Dgv_SetInfo.Name = "Dgv_SetInfo";
            this.Dgv_SetInfo.RowHeadersWidth = 20;
            this.Dgv_SetInfo.RowTemplate.Height = 23;
            this.Dgv_SetInfo.Size = new System.Drawing.Size(282, 291);
            this.Dgv_SetInfo.TabIndex = 0;
            // 
            // Column_Name
            // 
            this.Column_Name.DataPropertyName = "Name";
            this.Column_Name.HeaderText = "名称";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.Visible = false;
            // 
            // Col_Place
            // 
            this.Col_Place.DataPropertyName = "Place";
            this.Col_Place.HeaderText = "显示位置";
            this.Col_Place.Name = "Col_Place";
            this.Col_Place.ReadOnly = true;
            this.Col_Place.Width = 80;
            // 
            // Col_Show
            // 
            this.Col_Show.DataPropertyName = "Show";
            this.Col_Show.HeaderText = "是否显示";
            this.Col_Show.Name = "Col_Show";
            this.Col_Show.Width = 70;
            // 
            // Col_As
            // 
            this.Col_As.DataPropertyName = "As";
            this.Col_As.HeaderText = "编号";
            this.Col_As.Name = "Col_As";
            this.Col_As.Visible = false;
            // 
            // Col_DBName
            // 
            this.Col_DBName.DataPropertyName = "DBName";
            this.Col_DBName.HeaderText = "数据库名字";
            this.Col_DBName.Name = "Col_DBName";
            this.Col_DBName.Visible = false;
            // 
            // Col_Print
            // 
            this.Col_Print.DataPropertyName = "Print";
            this.Col_Print.HeaderText = "是否打印";
            this.Col_Print.Name = "Col_Print";
            this.Col_Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_Print.Visible = false;
            // 
            // Search_Conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 339);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Conditions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询条件";
            this.Load += new System.EventHandler(this.Search_Conditions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Condition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SetInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Condition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Type;
        private System.Windows.Forms.RadioButton Rbt_TempDate;
        private System.Windows.Forms.RadioButton Rbt_Date;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Check;
        private System.Windows.Forms.Label label3;
        private WSV.Control.MyComboBox.MyComboBox Cmb_Used;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_SetInfo;
        private System.Windows.Forms.Button Btn_Down;
        private System.Windows.Forms.Button Btn_Up;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Comparison;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Value;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Logic;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dt_DateBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dt_DateEnd;
        private System.Windows.Forms.DateTimePicker Dt_TimeBegin;
        private System.Windows.Forms.DateTimePicker Dt_TimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Place;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DBName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Print;
    }
}