namespace WSV.Record
{
    partial class BaseIsUsed
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
            this.Dgv_baseUsedInfo = new WSV.Control.DataGridView.MyDataGridView();
            this.Col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_SelectAll = new System.Windows.Forms.ToolStripButton();
            this.Btn_NoUsed = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_baseUsedInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_baseUsedInfo
            // 
            this.Dgv_baseUsedInfo.AllowUserToAddRows = false;
            this.Dgv_baseUsedInfo.AllowUserToDeleteRows = false;
            this.Dgv_baseUsedInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_baseUsedInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_baseUsedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_baseUsedInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Check,
            this.Col_Id,
            this.Col_CodeID,
            this.Col_Name,
            this.Col_Rem});
            this.Dgv_baseUsedInfo.EnterNextRow = true;
            this.Dgv_baseUsedInfo.Location = new System.Drawing.Point(2, 34);
            this.Dgv_baseUsedInfo.Name = "Dgv_baseUsedInfo";
            this.Dgv_baseUsedInfo.ReadOnly = true;
            this.Dgv_baseUsedInfo.RowCode = false;
            this.Dgv_baseUsedInfo.RowHeadersWidth = 20;
            this.Dgv_baseUsedInfo.RowTemplate.Height = 23;
            this.Dgv_baseUsedInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_baseUsedInfo.Size = new System.Drawing.Size(450, 358);
            this.Dgv_baseUsedInfo.TabIndex = 5;
            this.Dgv_baseUsedInfo.Total = false;
            this.Dgv_baseUsedInfo.TotalText = "";
            this.Dgv_baseUsedInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_baseUsedInfo_CellClick);
            // 
            // Col_Check
            // 
            this.Col_Check.FalseValue = "0";
            this.Col_Check.HeaderText = "";
            this.Col_Check.IndeterminateValue = "0";
            this.Col_Check.MinimumWidth = 3;
            this.Col_Check.Name = "Col_Check";
            this.Col_Check.ReadOnly = true;
            this.Col_Check.TrueValue = "1";
            this.Col_Check.Width = 30;
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "ID";
            this.Col_Id.HeaderText = "ID";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // Col_CodeID
            // 
            this.Col_CodeID.DataPropertyName = "CodeID";
            this.Col_CodeID.HeaderText = "编号";
            this.Col_CodeID.Name = "Col_CodeID";
            this.Col_CodeID.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_Rem
            // 
            this.Col_Rem.DataPropertyName = "Rem";
            this.Col_Rem.HeaderText = "简码";
            this.Col_Rem.Name = "Col_Rem";
            this.Col_Rem.ReadOnly = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_SelectAll,
            this.Btn_NoUsed,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(454, 32);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_SelectAll
            // 
            this.Btn_SelectAll.Image = global::WSV.Properties.Resources.Btn_Save;
            this.Btn_SelectAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_SelectAll.Name = "Btn_SelectAll";
            this.Btn_SelectAll.Size = new System.Drawing.Size(58, 29);
            this.Btn_SelectAll.Text = "全选";
            this.Btn_SelectAll.Click += new System.EventHandler(this.Btn_SelectAll_Click);
            // 
            // Btn_NoUsed
            // 
            this.Btn_NoUsed.Image = global::WSV.Properties.Resources.Btn_Edit;
            this.Btn_NoUsed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_NoUsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_NoUsed.Name = "Btn_NoUsed";
            this.Btn_NoUsed.Size = new System.Drawing.Size(70, 29);
            this.Btn_NoUsed.Text = "反作废";
            this.Btn_NoUsed.Click += new System.EventHandler(this.Btn_NoUsed_Click);
            // 
            // BaseIsUsed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 394);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Dgv_baseUsedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseIsUsed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "作废信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseIsUsed_FormClosed);
            this.Load += new System.EventHandler(this.BaseIsUsed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_baseUsedInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSV.Control.DataGridView.MyDataGridView Dgv_baseUsedInfo;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_NoUsed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rem;
        private System.Windows.Forms.ToolStripButton Btn_SelectAll;
    }
}