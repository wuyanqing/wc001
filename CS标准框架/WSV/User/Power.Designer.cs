namespace WSV.User
{
    partial class Power
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
            this.Btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Del = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lab_RuleName = new System.Windows.Forms.Label();
            this.Tb_RuleName = new WSV.Control.TextBox.TextBox();
            this.Lab_Parent = new System.Windows.Forms.Label();
            this.Tb_Parent = new WSV.Control.TextBox.TextBox();
            this.Lab_Code = new System.Windows.Forms.Label();
            this.Tb_Code = new WSV.Control.TextBox.TextBox();
            this.Lab_Name = new System.Windows.Forms.Label();
            this.Tb_Name = new WSV.Control.TextBox.TextBox();
            this.Gv_Power = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tv_Power = new WSV.Control.MyTreeView.MyTreeView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Power)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Add,
            this.Btn_Edit,
            this.Btn_Save,
            this.Btn_Del,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(692, 32);
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
            this.groupBox1.Controls.Add(this.Lab_RuleName);
            this.groupBox1.Controls.Add(this.Tb_RuleName);
            this.groupBox1.Controls.Add(this.Lab_Parent);
            this.groupBox1.Controls.Add(this.Tb_Parent);
            this.groupBox1.Controls.Add(this.Lab_Code);
            this.groupBox1.Controls.Add(this.Tb_Code);
            this.groupBox1.Controls.Add(this.Lab_Name);
            this.groupBox1.Controls.Add(this.Tb_Name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(150, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限信息";
            // 
            // Lab_RuleName
            // 
            this.Lab_RuleName.AutoSize = true;
            this.Lab_RuleName.Location = new System.Drawing.Point(228, 63);
            this.Lab_RuleName.Name = "Lab_RuleName";
            this.Lab_RuleName.Size = new System.Drawing.Size(65, 12);
            this.Lab_RuleName.TabIndex = 0;
            this.Lab_RuleName.Text = "模块名称：";
            // 
            // Tb_RuleName
            // 
            this.Tb_RuleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_RuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_RuleName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_RuleName.Location = new System.Drawing.Point(296, 58);
            this.Tb_RuleName.Name = "Tb_RuleName";
            this.Tb_RuleName.Size = new System.Drawing.Size(100, 23);
            this.Tb_RuleName.TabIndex = 4;
            this.Tb_RuleName.TableFlag = true;
            this.Tb_RuleName.Tag = "";
            this.Tb_RuleName.Upper = false;
            // 
            // Lab_Parent
            // 
            this.Lab_Parent.AutoSize = true;
            this.Lab_Parent.Location = new System.Drawing.Point(37, 24);
            this.Lab_Parent.Name = "Lab_Parent";
            this.Lab_Parent.Size = new System.Drawing.Size(41, 12);
            this.Lab_Parent.TabIndex = 0;
            this.Lab_Parent.Text = "父类：";
            // 
            // Tb_Parent
            // 
            this.Tb_Parent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Parent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Parent.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Parent.Location = new System.Drawing.Point(81, 20);
            this.Tb_Parent.Name = "Tb_Parent";
            this.Tb_Parent.ReadOnly = true;
            this.Tb_Parent.Size = new System.Drawing.Size(100, 23);
            this.Tb_Parent.TabIndex = 1;
            this.Tb_Parent.TableFlag = true;
            this.Tb_Parent.Tag = "";
            this.Tb_Parent.Upper = false;
            // 
            // Lab_Code
            // 
            this.Lab_Code.AutoSize = true;
            this.Lab_Code.Location = new System.Drawing.Point(252, 24);
            this.Lab_Code.Name = "Lab_Code";
            this.Lab_Code.Size = new System.Drawing.Size(41, 12);
            this.Lab_Code.TabIndex = 0;
            this.Lab_Code.Text = "编号：";
            // 
            // Tb_Code
            // 
            this.Tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Code.Location = new System.Drawing.Point(296, 20);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.Size = new System.Drawing.Size(100, 23);
            this.Tb_Code.TabIndex = 2;
            this.Tb_Code.TableFlag = true;
            this.Tb_Code.Tag = "";
            this.Tb_Code.Upper = false;
            // 
            // Lab_Name
            // 
            this.Lab_Name.AutoSize = true;
            this.Lab_Name.Location = new System.Drawing.Point(37, 62);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(41, 12);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "名称：";
            // 
            // Tb_Name
            // 
            this.Tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tb_Name.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Tb_Name.Location = new System.Drawing.Point(81, 58);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(100, 23);
            this.Tb_Name.TabIndex = 3;
            this.Tb_Name.TableFlag = true;
            this.Tb_Name.Tag = "";
            this.Tb_Name.Upper = false;
            // 
            // Gv_Power
            // 
            this.Gv_Power.AllowUserToAddRows = false;
            this.Gv_Power.AllowUserToDeleteRows = false;
            this.Gv_Power.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gv_Power.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gv_Power.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Power.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Code,
            this.Col_Name,
            this.Col_RuleName});
            this.Gv_Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gv_Power.EnterNextRow = true;
            this.Gv_Power.Location = new System.Drawing.Point(150, 125);
            this.Gv_Power.Name = "Gv_Power";
            this.Gv_Power.ReadOnly = true;
            this.Gv_Power.RowCode = false;
            this.Gv_Power.RowHeadersWidth = 20;
            this.Gv_Power.RowTemplate.Height = 23;
            this.Gv_Power.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gv_Power.Size = new System.Drawing.Size(542, 321);
            this.Gv_Power.TabIndex = 0;
            this.Gv_Power.Total = false;
            this.Gv_Power.TotalText = "";
            this.Gv_Power.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Power_CellClick);
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
            // Col_RuleName
            // 
            this.Col_RuleName.DataPropertyName = "RuleName";
            this.Col_RuleName.HeaderText = "模块名称";
            this.Col_RuleName.Name = "Col_RuleName";
            this.Col_RuleName.ReadOnly = true;
            // 
            // Tv_Power
            // 
            this.Tv_Power.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tv_Power.Location = new System.Drawing.Point(0, 32);
            this.Tv_Power.Name = "Tv_Power";
            this.Tv_Power.SelectNodesValue = null;
            this.Tv_Power.Size = new System.Drawing.Size(150, 414);
            this.Tv_Power.TabIndex = 0;
            this.Tv_Power.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_Power_AfterSelect);
            // 
            // Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 446);
            this.Controls.Add(this.Gv_Power);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tv_Power);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Power";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统权限";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Power_FormClosed);
            this.Load += new System.EventHandler(this.Power_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSV.Control.MyTreeView.MyTreeView Tv_Power;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Add;
        private System.Windows.Forms.ToolStripButton Btn_Edit;
        private System.Windows.Forms.ToolStripButton Btn_Save;
        private System.Windows.Forms.ToolStripButton Btn_Del;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lab_Code;
        private WSV.Control.TextBox.TextBox Tb_Code;
        private System.Windows.Forms.Label Lab_Name;
        private WSV.Control.TextBox.TextBox Tb_Name;
        private System.Windows.Forms.Label Lab_Parent;
        private WSV.Control.TextBox.TextBox Tb_Parent;
        private WSV.Control.DataGridView.MyDataGridView Gv_Power;
        private System.Windows.Forms.Label Lab_RuleName;
        private WSV.Control.TextBox.TextBox Tb_RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RuleName;
    }
}