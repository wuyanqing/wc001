namespace WSV.SysInfo
{
    partial class LoadoMeter
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
            this.Gv_LoadoMeter = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TableNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Tb_TableNum = new WSV.Control.TextBox.TextBox();
            this.Lb_TableNum = new System.Windows.Forms.Label();
            this.Gb_LoadoMeter = new System.Windows.Forms.GroupBox();
            this.Tb_Port = new WSV.Control.TextBox.TextBox();
            this.Lb_Port = new System.Windows.Forms.Label();
            this.Tb_Ip = new WSV.Control.TextBox.TextBox();
            this.Tb_Remark = new WSV.Control.TextBox.TextBox();
            this.Lb_Remark = new System.Windows.Forms.Label();
            this.Lb_Ip = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            this.Btn_SetLolal = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_LoadoMeter)).BeginInit();
            this.Gb_LoadoMeter.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gv_LoadoMeter
            // 
            this.Gv_LoadoMeter.AllowUserToAddRows = false;
            this.Gv_LoadoMeter.AllowUserToDeleteRows = false;
            this.Gv_LoadoMeter.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_LoadoMeter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_LoadoMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_LoadoMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_TableNum,
            this.Col_Name,
            this.Col_Ip,
            this.Col_Port,
            this.Col_Remark});
            this.Gv_LoadoMeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_LoadoMeter.EnterNextRow = true;
            this.Gv_LoadoMeter.Location = new System.Drawing.Point(0, 129);
            this.Gv_LoadoMeter.Name = "Gv_LoadoMeter";
            this.Gv_LoadoMeter.ReadOnly = true;
            this.Gv_LoadoMeter.RowCode = false;
            this.Gv_LoadoMeter.RowHeadersWidth = 20;
            this.Gv_LoadoMeter.RowTemplate.Height = 23;
            this.Gv_LoadoMeter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_LoadoMeter.Size = new System.Drawing.Size(592, 317);
            this.Gv_LoadoMeter.TabIndex = 3;
            this.Gv_LoadoMeter.Total = false;
            this.Gv_LoadoMeter.TotalText = "";
            this.Gv_LoadoMeter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_LoadoMeter_CellClick);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // Col_TableNum
            // 
            this.Col_TableNum.DataPropertyName = "TableNum";
            this.Col_TableNum.HeaderText = "台号";
            this.Col_TableNum.Name = "Col_TableNum";
            this.Col_TableNum.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "磅台名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_Ip
            // 
            this.Col_Ip.DataPropertyName = "Ip";
            this.Col_Ip.HeaderText = "机器Ip";
            this.Col_Ip.Name = "Col_Ip";
            this.Col_Ip.ReadOnly = true;
            this.Col_Ip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Port
            // 
            this.Col_Port.DataPropertyName = "Port";
            this.Col_Port.HeaderText = "端口号";
            this.Col_Port.Name = "Col_Port";
            this.Col_Port.ReadOnly = true;
            // 
            // Col_Remark
            // 
            this.Col_Remark.DataPropertyName = "Remark";
            this.Col_Remark.HeaderText = "备注";
            this.Col_Remark.Name = "Col_Remark";
            this.Col_Remark.ReadOnly = true;
            this.Col_Remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Name.Location = new System.Drawing.Point(283, 20);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(100, 23);
            this.Tb_Name.TabIndex = 2;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Location = new System.Drawing.Point(215, 24);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(65, 12);
            this.Lb_Name.TabIndex = 0;
            this.Lb_Name.Text = "磅台名称：";
            // 
            // Tb_TableNum
            // 
            this.Tb_TableNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_TableNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_TableNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_TableNum.Location = new System.Drawing.Point(88, 20);
            this.Tb_TableNum.Name = "Tb_TableNum";
            this.Tb_TableNum.Size = new System.Drawing.Size(100, 23);
            this.Tb_TableNum.TabIndex = 1;
            this.Tb_TableNum.TableFlag = true;
            this.Tb_TableNum.Tag = "";
            this.Tb_TableNum.Upper = false;
            // 
            // Lb_TableNum
            // 
            this.Lb_TableNum.AutoSize = true;
            this.Lb_TableNum.Location = new System.Drawing.Point(44, 24);
            this.Lb_TableNum.Name = "Lb_TableNum";
            this.Lb_TableNum.Size = new System.Drawing.Size(41, 12);
            this.Lb_TableNum.TabIndex = 0;
            this.Lb_TableNum.Text = "台号：";
            // 
            // Gb_LoadoMeter
            // 
            this.Gb_LoadoMeter.Controls.Add(this.Tb_Port);
            this.Gb_LoadoMeter.Controls.Add(this.Lb_Port);
            this.Gb_LoadoMeter.Controls.Add(this.Tb_Ip);
            this.Gb_LoadoMeter.Controls.Add(this.Tb_Remark);
            this.Gb_LoadoMeter.Controls.Add(this.Lb_Remark);
            this.Gb_LoadoMeter.Controls.Add(this.Lb_Ip);
            this.Gb_LoadoMeter.Controls.Add(this.Lb_TableNum);
            this.Gb_LoadoMeter.Controls.Add(this.Tb_TableNum);
            this.Gb_LoadoMeter.Controls.Add(this.Lb_Name);
            this.Gb_LoadoMeter.Controls.Add(this.Tb_Name);
            this.Gb_LoadoMeter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gb_LoadoMeter.Location = new System.Drawing.Point(0, 32);
            this.Gb_LoadoMeter.Name = "Gb_LoadoMeter";
            this.Gb_LoadoMeter.Size = new System.Drawing.Size(592, 97);
            this.Gb_LoadoMeter.TabIndex = 2;
            this.Gb_LoadoMeter.TabStop = false;
            this.Gb_LoadoMeter.Text = "详细信息";
            // 
            // Tb_Port
            // 
            this.Tb_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Port.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Port.Location = new System.Drawing.Point(88, 59);
            this.Tb_Port.Name = "Tb_Port";
            this.Tb_Port.Size = new System.Drawing.Size(100, 23);
            this.Tb_Port.TabIndex = 4;
            this.Tb_Port.TableFlag = true;
            this.Tb_Port.Tag = "";
            this.Tb_Port.Upper = false;
            // 
            // Lb_Port
            // 
            this.Lb_Port.AutoSize = true;
            this.Lb_Port.Location = new System.Drawing.Point(31, 64);
            this.Lb_Port.Name = "Lb_Port";
            this.Lb_Port.Size = new System.Drawing.Size(53, 12);
            this.Lb_Port.TabIndex = 0;
            this.Lb_Port.Text = "端口号：";
            // 
            // Tb_Ip
            // 
            this.Tb_Ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Ip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Ip.Location = new System.Drawing.Point(467, 20);
            this.Tb_Ip.Name = "Tb_Ip";
            this.Tb_Ip.Size = new System.Drawing.Size(100, 23);
            this.Tb_Ip.TabIndex = 3;
            this.Tb_Ip.TableFlag = true;
            this.Tb_Ip.Tag = "";
            this.Tb_Ip.Upper = false;
            // 
            // Tb_Remark
            // 
            this.Tb_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Remark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Remark.Location = new System.Drawing.Point(283, 59);
            this.Tb_Remark.Name = "Tb_Remark";
            this.Tb_Remark.Size = new System.Drawing.Size(284, 23);
            this.Tb_Remark.TabIndex = 5;
            this.Tb_Remark.TableFlag = true;
            this.Tb_Remark.Tag = "";
            this.Tb_Remark.Upper = false;
            // 
            // Lb_Remark
            // 
            this.Lb_Remark.AutoSize = true;
            this.Lb_Remark.Location = new System.Drawing.Point(236, 64);
            this.Lb_Remark.Name = "Lb_Remark";
            this.Lb_Remark.Size = new System.Drawing.Size(41, 12);
            this.Lb_Remark.TabIndex = 0;
            this.Lb_Remark.Text = "备注：";
            // 
            // Lb_Ip
            // 
            this.Lb_Ip.AutoSize = true;
            this.Lb_Ip.Location = new System.Drawing.Point(410, 25);
            this.Lb_Ip.Name = "Lb_Ip";
            this.Lb_Ip.Size = new System.Drawing.Size(53, 12);
            this.Lb_Ip.TabIndex = 0;
            this.Lb_Ip.Text = "机器Ip：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Add,
            this.Btn_Edit,
            this.Btn_Save,
            this.Btn_Del,
            this.Btn_SetLolal,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(592, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = global::WSV.Properties.Resources.Btn_Add;
            this.Btn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(58, 29);
            this.Btn_Add.Text = "添加";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Edit.Text = "修改";
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
            // Btn_Del
            // 
            this.Btn_Del.Image = global::WSV.Properties.Resources.Btn_Delete;
            this.Btn_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(58, 29);
            this.Btn_Del.Text = "删除";
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_SetLolal
            // 
            this.Btn_SetLolal.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_SetLolal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_SetLolal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_SetLolal.Name = "Btn_SetLolal";
            this.Btn_SetLolal.Size = new System.Drawing.Size(82, 29);
            this.Btn_SetLolal.Text = "设为本机";
            this.Btn_SetLolal.Click += new System.EventHandler(this.Btn_SetLolal_Click);
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
            // LoadoMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.Gv_LoadoMeter);
            this.Controls.Add(this.Gb_LoadoMeter);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoadoMeter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "磅台设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadoMeter_FormClosed);
            this.Load += new System.EventHandler(this.LoadoMeter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_LoadoMeter)).EndInit();
            this.Gb_LoadoMeter.ResumeLayout(false);
            this.Gb_LoadoMeter.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSV.Control.DataGridView.MyDataGridView Gv_LoadoMeter;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private System.Windows.Forms.Label Lb_Name;
        private WSV.Control.TextBox.TextBox Tb_TableNum;
        private System.Windows.Forms.Label Lb_TableNum;
        private System.Windows.Forms.GroupBox Gb_LoadoMeter;
        private WSV.Control.TextBox.TextBox Tb_Remark;
        private System.Windows.Forms.Label Lb_Remark;
        private System.Windows.Forms.Label Lb_Ip;
        private WSV.Control.TextBox.TextBox Tb_Ip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Edit;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_SetLolal;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.TextBox.TextBox Tb_Port;
        private System.Windows.Forms.Label Lb_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TableNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Remark;
    }
}