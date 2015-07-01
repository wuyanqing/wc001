namespace WSV.SysInfo
{
    partial class Alias
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
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Gv_Alias = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Alias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Save,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(592, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::WSV.Properties.Resources.Btn_Save;
            this.Btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(58, 29);
            this.Btn_Save.Text = "保存";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
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
            // Gv_Alias
            // 
            this.Gv_Alias.AllowUserToAddRows = false;
            this.Gv_Alias.AllowUserToDeleteRows = false;
            this.Gv_Alias.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Alias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Alias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Alias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Code,
            this.Col_Name,
            this.Col_RuleName,
            this.Col_DbName,
            this.Col_DataType,
            this.Col_State});
            this.Gv_Alias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_Alias.EnterNextRow = true;
            this.Gv_Alias.Location = new System.Drawing.Point(3, 17);
            this.Gv_Alias.Name = "Gv_Alias";
            this.Gv_Alias.RowCode = false;
            this.Gv_Alias.RowHeadersWidth = 20;
            this.Gv_Alias.RowTemplate.Height = 23;
            this.Gv_Alias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Alias.Size = new System.Drawing.Size(586, 394);
            this.Gv_Alias.TabIndex = 0;
            this.Gv_Alias.Total = false;
            this.Gv_Alias.TotalText = "";
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
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
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            // 
            // Col_RuleName
            // 
            this.Col_RuleName.DataPropertyName = "RuleName";
            this.Col_RuleName.HeaderText = "程序名称";
            this.Col_RuleName.Name = "Col_RuleName";
            this.Col_RuleName.ReadOnly = true;
            // 
            // Col_DbName
            // 
            this.Col_DbName.DataPropertyName = "DbName";
            this.Col_DbName.HeaderText = "数据名称";
            this.Col_DbName.Name = "Col_DbName";
            this.Col_DbName.ReadOnly = true;
            // 
            // Col_DataType
            // 
            this.Col_DataType.DataPropertyName = "DataType";
            this.Col_DataType.HeaderText = "数据类型";
            this.Col_DataType.Name = "Col_DataType";
            this.Col_DataType.ReadOnly = true;
            // 
            // Col_State
            // 
            this.Col_State.DataPropertyName = "State";
            this.Col_State.HeaderText = "已启用";
            this.Col_State.Name = "Col_State";
            this.Col_State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gv_Alias);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息列表";
            // 
            // Alias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Alias";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统别名";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alias_FormClosed);
            this.Load += new System.EventHandler(this.Alias_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Alias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.DataGridView.MyDataGridView Gv_Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_State;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}