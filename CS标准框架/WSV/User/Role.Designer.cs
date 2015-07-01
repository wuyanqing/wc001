namespace WSV.User
{
    partial class Role
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
            this.Btn_Add = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Tv_Role = new WSV.Control.MyTreeView.MyTreeView();
            this.Gv_Role = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Role)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Add,
            this.Btn_Del,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(592, 32);
            this.toolStrip1.TabIndex = 0;
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
            // Tv_Role
            // 
            this.Tv_Role.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tv_Role.Location = new System.Drawing.Point(0, 32);
            this.Tv_Role.Name = "Tv_Role";
            this.Tv_Role.SelectNodesValue = null;
            this.Tv_Role.Size = new System.Drawing.Size(150, 414);
            this.Tv_Role.TabIndex = 0;
            this.Tv_Role.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_Role_AfterSelect);
            // 
            // Gv_Role
            // 
            this.Gv_Role.AllowUserToAddRows = false;
            this.Gv_Role.AllowUserToDeleteRows = false;
            this.Gv_Role.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Role.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Role.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Code,
            this.Col_Name});
            this.Gv_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_Role.EnterNextRow = true;
            this.Gv_Role.Location = new System.Drawing.Point(150, 32);
            this.Gv_Role.Name = "Gv_Role";
            this.Gv_Role.ReadOnly = true;
            this.Gv_Role.RowCode = false;
            this.Gv_Role.RowHeadersWidth = 20;
            this.Gv_Role.RowTemplate.Height = 23;
            this.Gv_Role.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Role.Size = new System.Drawing.Size(442, 414);
            this.Gv_Role.TabIndex = 0;
            this.Gv_Role.Total = false;
            this.Gv_Role.TotalText = "";
            this.Gv_Role.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Role_CellDoubleClick);
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
            this.Col_Name.ReadOnly = true;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.Gv_Role);
            this.Controls.Add(this.Tv_Role);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Role";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统角色";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Role_FormClosed);
            this.Load += new System.EventHandler(this.Role_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Role)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private WSV.Control.MyTreeView.MyTreeView Tv_Role;
        private WSV.Control.DataGridView.MyDataGridView Gv_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
    }
}